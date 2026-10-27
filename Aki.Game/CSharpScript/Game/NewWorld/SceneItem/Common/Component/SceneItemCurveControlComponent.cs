using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.NewWorld.SceneItem.CurveControl;

namespace CSharpScript.Game.NewWorld.SceneItem.Common.Component
{
	// Token: 0x02007217 RID: 29207
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneItemCurveControlComponent : EntityComponent
	{
		// Token: 0x0604780D RID: 292877 RVA: 0x01239B50 File Offset: 0x01237D50
		protected override bool OnInitData(IEntityArgs args = null)
		{
			CreateEntityData createEntityData = (args != null) ? args.GetP1<CreateEntityData>() : null;
			CurveControlComponent curveControlComponent = ((createEntityData != null) ? createEntityData.GetParam<SceneItemCurveControlComponent>() : null) as CurveControlComponent;
			this.ActorComp = base.Entity.GetComponent<BaseActorComponent>();
			CurveControlFactory instance = CurveControlFactory.Instance;
			IChargeSlashControl curveControlConfig = curveControlComponent.CurveControlConfig;
			this.CurveControl = instance.CreateCurveControl((curveControlConfig != null) ? new ECurveControlType?(curveControlConfig.Type) : null);
			if (this.CurveControl == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module = ELogModule.SceneItemCurveControl;
				ELogAuthor author = ELogAuthor.CH;
				string message = "[CurveControl] CreateCurveControl Failed";
				string item = "PbDataId";
				BaseActorComponent actorComp = this.ActorComp;
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (actorComp != null) ? new int?(actorComp.CreatureData.GetPbDataId()) : null);
				instance2.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			this.CurveControl.Init(base.Entity, curveControlComponent);
			base.DisableByKey(EEntityDisableKey.CurveControlComponent, false);
			return true;
		}

		// Token: 0x0604780E RID: 292878 RVA: 0x01239C34 File Offset: 0x01237E34
		protected override void OnTick(float delta)
		{
			if (this.FirstTick)
			{
				this.FirstTick = false;
				return;
			}
			if (this.CurveControl == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneItemCurveControl;
				ELogAuthor author = ELogAuthor.CH;
				string message = "[CurveControl] OnTick Failed";
				string item = "PbDataId";
				BaseActorComponent actorComp = this.ActorComp;
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (actorComp != null) ? new int?(actorComp.CreatureData.GetPbDataId()) : null);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				base.DisableByKey(EEntityDisableKey.CurveControlComponent, false);
				this.FirstTick = true;
				return;
			}
			if (!this.CurveControl.Tick(delta))
			{
				base.DisableByKey(EEntityDisableKey.CurveControlComponent, false);
				this.FirstTick = true;
			}
		}

		// Token: 0x0604780F RID: 292879 RVA: 0x01239CD8 File Offset: 0x01237ED8
		public void StartPerformance(float delayTime)
		{
			if (this.CurveControl == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneItemCurveControl;
				ELogAuthor author = ELogAuthor.CH;
				string message = "[CurveControl] StartPerformance Failed";
				string item = "PbDataId";
				BaseActorComponent actorComp = this.ActorComp;
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (actorComp != null) ? new int?(actorComp.CreatureData.GetPbDataId()) : null);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			Entity entity = (baseCharacter != null) ? baseCharacter.GetEntityNoBlueprint() : null;
			if (entity == null)
			{
				Log.Instance.Error(ELogModule.SceneItemCurveControl, ELogAuthor.CH, "curCharEntity is null", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			BaseAttributeComponent component = entity.GetComponent<BaseAttributeComponent>();
			if (component == null)
			{
				Log.Instance.Error(ELogModule.SceneItemCurveControl, ELogAuthor.CH, "attrComp is null", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			float currentValue = component.GetCurrentValue(EAttributeType.SpecialEnergy2Max);
			float num = component.GetCurrentValue(EAttributeType.SpecialEnergy1Max) / currentValue * 0.05f;
			float num2 = component.GetCurrentValue(EAttributeType.SpecialEnergy3Max) / currentValue * 0.05f - num;
			this.CurveControl.SetAllTime((num - delayTime) * 1000f, num2 * 1000f, 2500f);
			this.CurveControl.Start();
			base.EnableByKey(EEntityDisableKey.CurveControlComponent, true);
		}

		// Token: 0x06047810 RID: 292880 RVA: 0x01239E04 File Offset: 0x01238004
		public void StopPerformance()
		{
			if (this.CurveControl == null || this.CurveControl.IsStop())
			{
				return;
			}
			this.CurveControl.Stop(false);
		}

		// Token: 0x06047811 RID: 292881 RVA: 0x01239E28 File Offset: 0x01238028
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneItemCurveControlComponent sceneItemCurveControlComponent = (SceneItemCurveControlComponent)componentTemplate;
			if (base.CanResetComponentProperty("CurveControl"))
			{
				if (sceneItemCurveControlComponent.CurveControl == null)
				{
					this.CurveControl = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CurveControlBase>(this.CurveControl), "CurveControl"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("ActorComp"))
			{
				if (sceneItemCurveControlComponent.ActorComp == null)
				{
					this.ActorComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseActorComponent>(this.ActorComp), "ActorComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("FirstTick"))
			{
				this.FirstTick = sceneItemCurveControlComponent.FirstTick;
			}
			return true;
		}

		// Token: 0x040259EC RID: 154092
		private const float STEP_TIME = 0.05f;

		// Token: 0x040259ED RID: 154093
		private CurveControlBase CurveControl;

		// Token: 0x040259EE RID: 154094
		private BaseActorComponent ActorComp;

		// Token: 0x040259EF RID: 154095
		private bool FirstTick = true;
	}
}
