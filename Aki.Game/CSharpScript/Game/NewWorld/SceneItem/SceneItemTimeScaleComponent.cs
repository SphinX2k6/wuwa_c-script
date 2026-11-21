using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.NewWorld.Common.Component;
using CSharpScript.Game.NewWorld.Pawn.Component;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem
{
	// Token: 0x0200624A RID: 25162
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneItemTimeScaleComponent : PawnTimeScaleComponent
	{
		// Token: 0x0603CB2C RID: 248620 RVA: 0x0116BC5F File Offset: 0x01169E5F
		protected override bool OnInit()
		{
			if (!base.OnInit())
			{
				return false;
			}
			this.CreatureDataComp = base.Entity.GetComponent<CreatureDataComponent>();
			return true;
		}

		// Token: 0x0603CB2D RID: 248621 RVA: 0x0116BC7D File Offset: 0x01169E7D
		protected override bool OnStart()
		{
			if (!base.OnStart())
			{
				return false;
			}
			if (this.TimeScaleList.Empty)
			{
				this.SetTimeScaleTicking(false, "[SceneItemTimeScaleComponent] OnStart, 初始关闭时间缩放");
			}
			this.TagComponent = base.Entity.GetComponent<LevelTagComponent>();
			return true;
		}

		// Token: 0x0603CB2E RID: 248622 RVA: 0x0116BCB4 File Offset: 0x01169EB4
		public override void SetTimeScaleTicking(bool enable, string reason = null)
		{
			if (enable && this.DisableHandle != null)
			{
				if (base.Enable(new int?(this.DisableHandle.Value), reason ?? "[SceneItemTimeScaleComponent] 开启Tick"))
				{
					this.DisableHandle = null;
					return;
				}
			}
			else if (!enable && this.DisableHandle == null)
			{
				this.DisableHandle = new int?(base.Disable(reason ?? "[SceneItemTimeScaleComponent] 关闭Tick"));
				this.ClearTimeScaleTag();
			}
		}

		// Token: 0x0603CB2F RID: 248623 RVA: 0x0116BD34 File Offset: 0x01169F34
		protected override void OnTick(float delta)
		{
			float num = 1f;
			float num2 = 1f;
			bool flag = false;
			while (!this.TimeScaleList.Empty)
			{
				TimeScale top = this.TimeScaleList.Top;
				if (top == null)
				{
					break;
				}
				if (this.IsTimescaleValid(top, delta))
				{
					num = top.CalculateTimeScale();
					flag = top.NeedAddSceneItemTag;
					if (top.EndTime - top.StartTime >= 0.800000011920929)
					{
						num2 = num;
						break;
					}
					break;
				}
				else
				{
					this.TimeScaleMap.Remove(top.Id);
					this.TimeScaleList.Pop();
				}
			}
			this.FreezeTimeScaleInternal = num;
			float topForeverTimeScale = base.GetTopForeverTimeScale(null);
			num *= topForeverTimeScale;
			num2 *= topForeverTimeScale;
			if (num != this.TimeScaleInternal)
			{
				this.ClearTimeScaleTag();
				if (flag && num != 1f)
				{
					LevelTagComponent tagComponent = this.TagComponent;
					if (tagComponent != null)
					{
						tagComponent.AddTag(new int?((num > 1f) ? SceneItemTimeScaleComponent.upsizeTag : SceneItemTimeScaleComponent.downsizeTag));
					}
				}
				this.TimeScaleInternal = num;
				base.Entity.SetTimeDilation(base.TimeDilation);
			}
			float num3 = num2;
			float timeDilation = base.TimeDilation;
			CharacterModel instance = CharacterModel.Instance;
			num2 = num3 * (timeDilation * ((instance != null) ? instance.SelfCenteredTimeDilation : 1f));
			SceneItemActorComponent component = base.Entity.GetComponent<SceneItemActorComponent>();
			if (component != null)
			{
				component.UpdateAkFinalTimeScale(num2, false);
			}
			if (this.TimeScaleList.Empty)
			{
				this.SetTimeScaleTicking(false, "[PawnTimeScaleComponent] 时间缩放结束");
			}
		}

		// Token: 0x0603CB30 RID: 248624 RVA: 0x0116BE93 File Offset: 0x0116A093
		public override int SetTimeScale(int priority, float timeDilation, UCurveFloat curve, float duration, ETimeScaleSourceType sourceType, bool needAddSceneItemTag = false, bool immuneSelfCenter = false)
		{
			int num = base.SetTimeScale(priority, timeDilation, curve, duration, sourceType, needAddSceneItemTag, false);
			if (num >= 0)
			{
				this.SetTimeScaleTicking(true, null);
			}
			this.OnTick(0f);
			return num;
		}

		// Token: 0x0603CB31 RID: 248625 RVA: 0x0116BEBC File Offset: 0x0116A0BC
		public override void RemoveTimeScale(int id)
		{
			base.RemoveTimeScale(id);
			this.OnTick(0f);
		}

		// Token: 0x0603CB32 RID: 248626 RVA: 0x0116BED0 File Offset: 0x0116A0D0
		public override int SetForeverTimeScale(ETimeScaleSourceType type, float timeScale, int priority = 0, bool refreshImmediately = false)
		{
			int result = base.SetForeverTimeScale(type, timeScale, priority, false);
			this.OnTick(0f);
			return result;
		}

		// Token: 0x0603CB33 RID: 248627 RVA: 0x0116BEE7 File Offset: 0x0116A0E7
		public override void RemoveForeverTimeScale(int id, bool refreshImmediately = false)
		{
			base.RemoveForeverTimeScale(id, false);
			this.OnTick(0f);
		}

		// Token: 0x0603CB34 RID: 248628 RVA: 0x0116BEFC File Offset: 0x0116A0FC
		private void ClearTimeScaleTag()
		{
			if (this.TagComponent != null)
			{
				this.TagComponent.RemoveTag(new int?(SceneItemTimeScaleComponent.downsizeTag));
				this.TagComponent.RemoveTag(new int?(SceneItemTimeScaleComponent.upsizeTag));
			}
		}

		// Token: 0x0603CB35 RID: 248629 RVA: 0x0116BF34 File Offset: 0x0116A134
		protected override void OnChangeTimeDilation(float timeDilation)
		{
			base.OnChangeTimeDilation(timeDilation);
			if (this.CreatureDataComp == null)
			{
				return;
			}
			if (LevelGeneralNetworks.CheckEntityCanPushTimeDilation(this.CreatureDataComp.GetEntityTimeScaleModifyStrategy()))
			{
				float num = base.CurrentTimeScale * timeDilation;
				PawnSelfCenterComponent component = base.Entity.GetComponent<PawnSelfCenterComponent>();
				if (component != null && component.ExtraTimeDilationInSelfCenteredMode != 0f)
				{
					num /= component.ExtraTimeDilationInSelfCenteredMode;
				}
				LevelGeneralNetworks.PushEntityTimeDilation(this.CreatureDataComp.GetCreatureDataId(), num);
			}
		}

		// Token: 0x0603CB36 RID: 248630 RVA: 0x0116BFA4 File Offset: 0x0116A1A4
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneItemTimeScaleComponent sceneItemTimeScaleComponent = (SceneItemTimeScaleComponent)componentTemplate;
			if (sceneItemTimeScaleComponent.TagComponent == null)
			{
				this.TagComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagComponent), "TagComponent"))
			{
				return false;
			}
			if (sceneItemTimeScaleComponent.CreatureDataComp == null)
			{
				this.CreatureDataComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CreatureDataComp), "CreatureDataComp"))
			{
				return false;
			}
			return true;
		}

		// Token: 0x170072D2 RID: 29394
		// (get) Token: 0x0603CB37 RID: 248631 RVA: 0x0116C01A File Offset: 0x0116A21A
		public override bool NeedInitInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170072D3 RID: 29395
		// (get) Token: 0x0603CB38 RID: 248632 RVA: 0x0116C01D File Offset: 0x0116A21D
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170072D4 RID: 29396
		// (get) Token: 0x0603CB39 RID: 248633 RVA: 0x0116C020 File Offset: 0x0116A220
		public override bool NeedTickInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170072D5 RID: 29397
		// (get) Token: 0x0603CB3A RID: 248634 RVA: 0x0116C023 File Offset: 0x0116A223
		public override bool NeedChangeTimeDilationInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x040202DE RID: 131806
		private static readonly int downsizeTag = GameplayTagDefine.EGameplayTagId["关卡.Common.表现.时间缩放.缩小"];

		// Token: 0x040202DF RID: 131807
		private static readonly int upsizeTag = GameplayTagDefine.EGameplayTagId["关卡.Common.表现.时间缩放.放大"];

		// Token: 0x040202E0 RID: 131808
		private LevelTagComponent TagComponent;

		// Token: 0x040202E1 RID: 131809
		private CreatureDataComponent CreatureDataComp;
	}
}
