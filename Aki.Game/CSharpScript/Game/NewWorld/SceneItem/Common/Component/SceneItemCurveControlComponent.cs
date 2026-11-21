using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.NewWorld.SceneItem.CurveControl;

namespace CSharpScript.Game.NewWorld.SceneItem.Common.Component
{
	// Token: 0x020062CC RID: 25292
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneItemCurveControlComponent : EntityComponent
	{
		// Token: 0x0603D133 RID: 250163 RVA: 0x01193294 File Offset: 0x01191494
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

		// Token: 0x0603D134 RID: 250164 RVA: 0x01193378 File Offset: 0x01191578
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

		// Token: 0x0603D135 RID: 250165 RVA: 0x0119341C File Offset: 0x0119161C
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

		// Token: 0x0603D136 RID: 250166 RVA: 0x01193548 File Offset: 0x01191748
		public void StopPerformance()
		{
			if (this.CurveControl == null || this.CurveControl.IsStop())
			{
				return;
			}
			this.CurveControl.Stop(false);
		}

		// Token: 0x0603D137 RID: 250167 RVA: 0x0119356C File Offset: 0x0119176C
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneItemCurveControlComponent sceneItemCurveControlComponent = (SceneItemCurveControlComponent)componentTemplate;
			if (sceneItemCurveControlComponent.CurveControl == null)
			{
				this.CurveControl = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CurveControl), "CurveControl"))
			{
				return false;
			}
			if (sceneItemCurveControlComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
			{
				return false;
			}
			this.FirstTick = sceneItemCurveControlComponent.FirstTick;
			return true;
		}

		// Token: 0x170073A1 RID: 29601
		// (get) Token: 0x0603D138 RID: 250168 RVA: 0x011935EE File Offset: 0x011917EE
		public override bool NeedTickInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0402065B RID: 132699
		private const float STEP_TIME = 0.05f;

		// Token: 0x0402065C RID: 132700
		private CurveControlBase CurveControl;

		// Token: 0x0402065D RID: 132701
		private BaseActorComponent ActorComp;

		// Token: 0x0402065E RID: 132702
		private bool FirstTick = true;
	}
}
