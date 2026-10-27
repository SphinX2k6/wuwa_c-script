using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.SceneItem;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B18 RID: 27416
	public class LevelEventEnableSceneItemDurabilityUI : LevelEventBase
	{
		// Token: 0x060440A8 RID: 278696 RVA: 0x010B97D3 File Offset: 0x010B79D3
		public LevelEventEnableSceneItemDurabilityUI(int id) : base(id)
		{
		}

		// Token: 0x060440A9 RID: 278697 RVA: 0x010B97DC File Offset: 0x010B79DC
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			IHealthBarDisplayClientFunction healthBarDisplayClientFunction = inParams as IHealthBarDisplayClientFunction;
			this.PbDataId = healthBarDisplayClientFunction.EntityId;
			this.IsVisible = healthBarDisplayClientFunction.IsVisible;
			if (this.IsVisible)
			{
				base.CreateWaitEntityTask(this.PbDataId);
				return;
			}
			EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(this.PbDataId);
			if (entityByPbDataId != null && entityByPbDataId.Valid)
			{
				EventSystem.Instance.Emit<int, bool, int?, int?, string>(EEventName.OnEnableSceneItemDurabilityUI, entityByPbDataId.Id, false, null, null, null);
			}
			else
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.LevelEvent;
				ELogAuthor author = ELogAuthor.CK;
				string message = "[可破坏物耐久度UI]隐藏时实体不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("PbDataId", this.PbDataId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			base.FinishExecute(true, false, true);
		}

		// Token: 0x060440AA RID: 278698 RVA: 0x010B98A0 File Offset: 0x010B7AA0
		protected override void ExecuteWhenEntitiesReady()
		{
			EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(this.PbDataId);
			if (entityByPbDataId == null || !entityByPbDataId.Valid)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.LevelEvent;
				ELogAuthor author = ELogAuthor.CK;
				string message = "[可破坏物耐久度UI]显示时实体不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("PbDataId", this.PbDataId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				base.FinishExecute(false, false, true);
				return;
			}
			WorldEntity entity = entityByPbDataId.Entity;
			CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
			SceneItemDamageComponent component2 = entity.GetComponent<SceneItemDamageComponent>();
			EventSystem instance2 = EventSystem.Instance;
			EEventName name = EEventName.OnEnableSceneItemDurabilityUI;
			int id = entityByPbDataId.Id;
			bool p = true;
			int? p2 = new int?(component.GetDurabilityValue());
			float? num = (component2 != null) ? new float?(component2.GetMaxDurablePoint()) : null;
			instance2.Emit<int, bool, int?, int?, string>(name, id, p, p2, new int?(((num != null) ? new int?((int)num.GetValueOrDefault()) : null).GetValueOrDefault(100)), component.GetEntityTidName() ?? "");
			base.FinishExecute(true, false, true);
		}

		// Token: 0x060440AB RID: 278699 RVA: 0x010B99A5 File Offset: 0x010B7BA5
		protected override void OnReset()
		{
			this.PbDataId = 0;
			this.IsVisible = false;
		}

		// Token: 0x040238E4 RID: 145636
		private int PbDataId;

		// Token: 0x040238E5 RID: 145637
		private bool IsVisible;
	}
}
