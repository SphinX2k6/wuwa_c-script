using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.NewWorld.Common.Component;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.CurveControl
{
	// Token: 0x0200720A RID: 29194
	[NullableContext(2)]
	[Nullable(0)]
	public class ChargeSlashCurveControl : CurveControlBase
	{
		// Token: 0x06047784 RID: 292740 RVA: 0x012341DC File Offset: 0x012323DC
		[NullableContext(1)]
		protected override void OnInit(CurveControlComponent config)
		{
			Entity entity = this.Entity;
			this.ActorComp = ((entity != null) ? entity.GetComponent<SceneItemActorComponent>() : null);
			Entity entity2 = this.Entity;
			this.TagComp = ((entity2 != null) ? entity2.GetComponent<LevelTagComponent>() : null);
			IChargeSlashControl chargeSlashConfig = config.CurveControlConfig;
			if (chargeSlashConfig != null)
			{
				this.RiseHeight = (float)chargeSlashConfig.UpHeight;
				if (!string.IsNullOrEmpty(chargeSlashConfig.UpCurvePath))
				{
					ResourceSystem.Instance.LoadAsync<UCurveFloat>(chargeSlashConfig.UpCurvePath, delegate([Nullable(2)] UCurveFloat obj, string _)
					{
						if (obj != null)
						{
							this.RiseCurve = obj;
							return;
						}
						Log instance = Log.Instance;
						ELogModule module = ELogModule.SceneItemCurveControl;
						ELogAuthor author = ELogAuthor.CH;
						string message = "[ChargeSlashCurveControl.OnInit] RiseCurve Load Failed";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Path", chargeSlashConfig.UpCurvePath);
						instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					}, 100, "js_undefined");
				}
			}
		}

		// Token: 0x06047785 RID: 292741 RVA: 0x01234287 File Offset: 0x01232487
		protected override void OnStart()
		{
			this.StartLoc.DeepCopy(this.ActorComp.ActorLocationProxy);
			this.StartRaiseMaterial = false;
			this.StopRaiseMaterial = false;
			this.StartRebornMaterial = false;
		}

		// Token: 0x06047786 RID: 292742 RVA: 0x012342B4 File Offset: 0x012324B4
		protected override void TickStartStage()
		{
			if (this.RiseCurve == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneItemCurveControl;
				ELogAuthor author = ELogAuthor.CH;
				string message = "[ChargeSlashCurveControl.TickStartStage] RiseCurve is null";
				string item = "PbDataId";
				SceneItemActorComponent actorComp = this.ActorComp;
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (actorComp != null) ? new int?(actorComp.CreatureData.GetPbDataId()) : null);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			if (!this.StartRaiseMaterial)
			{
				this.StartRaiseMaterial = true;
				LevelTagComponent tagComp = this.TagComp;
				if (tagComp != null && tagComp.HasTag(CurveControlDefine.RebornPerformanceTagId))
				{
					LevelTagComponent tagComp2 = this.TagComp;
					if (tagComp2 != null)
					{
						tagComp2.RemoveTag(new int?(CurveControlDefine.RebornPerformanceTagId));
					}
				}
				LevelTagComponent tagComp3 = this.TagComp;
				if (tagComp3 != null)
				{
					tagComp3.AddTag(new int?(CurveControlDefine.RaisePerformanceTagId));
				}
			}
			float inTime = this.CurTime / this.StartTime;
			float floatValue = this.RiseCurve.GetFloatValue(inTime);
			Vector vector = Vector.Create();
			vector.DeepCopy(this.StartLoc);
			vector.Z += (double)(floatValue * this.RiseHeight);
			this.ActorComp.SetActorLocation(vector.ToUeVector(false), "ChargeSlashCurveControl.StartStage", true);
		}

		// Token: 0x06047787 RID: 292743 RVA: 0x012343D8 File Offset: 0x012325D8
		protected override void TickEndStage()
		{
			if (this.CurTime <= this.StartTime + this.LoopTime || this.StopRaiseMaterial)
			{
				if (this.CurTime > this.StartTime + this.LoopTime + 800f && !this.StartRebornMaterial)
				{
					this.StartRebornMaterial = true;
					SceneItemActorComponent actorComp = this.ActorComp;
					if (actorComp != null)
					{
						actorComp.SetActorLocation(this.StartLoc.ToUeVector(false), "ChargeSlashCurveControl.EndStage", true);
					}
					LevelTagComponent tagComp = this.TagComp;
					if (tagComp == null)
					{
						return;
					}
					tagComp.AddTag(new int?(CurveControlDefine.RebornPerformanceTagId));
				}
				return;
			}
			this.StopRaiseMaterial = true;
			LevelTagComponent tagComp2 = this.TagComp;
			if (tagComp2 == null)
			{
				return;
			}
			tagComp2.RemoveTag(new int?(CurveControlDefine.RaisePerformanceTagId));
		}

		// Token: 0x04025976 RID: 153974
		private SceneItemActorComponent ActorComp;

		// Token: 0x04025977 RID: 153975
		private LevelTagComponent TagComp;

		// Token: 0x04025978 RID: 153976
		[Nullable(1)]
		private readonly Vector StartLoc = Vector.Create();

		// Token: 0x04025979 RID: 153977
		private float RiseHeight;

		// Token: 0x0402597A RID: 153978
		private UCurveFloat RiseCurve;

		// Token: 0x0402597B RID: 153979
		private bool StartRaiseMaterial;

		// Token: 0x0402597C RID: 153980
		private bool StopRaiseMaterial;

		// Token: 0x0402597D RID: 153981
		private bool StartRebornMaterial;
	}
}
