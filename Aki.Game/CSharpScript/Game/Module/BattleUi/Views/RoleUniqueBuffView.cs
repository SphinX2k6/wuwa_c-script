using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D95 RID: 19861
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleUniqueBuffView : BattleVisibleChildView
	{
		// Token: 0x06031E32 RID: 204338 RVA: 0x00DF37DC File Offset: 0x00DF19DC
		protected override void OnStart()
		{
			base.OnStart();
			base.InitChildType(EBattleUiChild.Ignore);
			this.InitExceedTipItem();
			int value = ConfigCommonParamById.GetIntConfig("RoleUniqueBuffItemCount").Value;
			this.BuffItemContainer.Init(this.RootItem, value, false, true, true, this.ExceedTipItem.GetRootItem());
			this.AddEvents();
		}

		// Token: 0x06031E33 RID: 204339 RVA: 0x00DF3838 File Offset: 0x00DF1A38
		protected override void OnBeforeDestroy()
		{
			this.Refresh(null);
			this.DestroyExceedTipItem();
			this.CurRoleBar = null;
			foreach (TopBuffContainer topBuffContainer in this.RoleBarMap.Values)
			{
				topBuffContainer.Destroy();
			}
		}

		// Token: 0x06031E34 RID: 204340 RVA: 0x00DF38A4 File Offset: 0x00DF1AA4
		public override void Reset()
		{
			this.RemoveEvents();
			base.Reset();
		}

		// Token: 0x06031E35 RID: 204341 RVA: 0x00DF38B2 File Offset: 0x00DF1AB2
		private void InitExceedTipItem()
		{
			this.ExceedTipItem = new BuffItem(this.RootItem);
			this.ExceedTipItem.ActivateExceedTip();
		}

		// Token: 0x06031E36 RID: 204342 RVA: 0x00DF38D0 File Offset: 0x00DF1AD0
		private void DestroyExceedTipItem()
		{
			if (this.ExceedTipItem != null)
			{
				this.ExceedTipItem.DestroyCompatible();
				this.ExceedTipItem = null;
			}
		}

		// Token: 0x06031E37 RID: 204343 RVA: 0x00DF38EC File Offset: 0x00DF1AEC
		[NullableContext(2)]
		public void Refresh(BattleUiRoleData roleData)
		{
			int? num;
			if (roleData == null)
			{
				num = null;
			}
			else
			{
				EntityHandle entityHandle = roleData.EntityHandle;
				num = ((entityHandle != null) ? new int?(entityHandle.Id) : null);
			}
			int? num2 = num;
			this.EntityId = new int?(num2.GetValueOrDefault());
			if (roleData != null)
			{
				this.BuffItemContainer.RefreshBuff(roleData.EntityHandle);
				this.LoadRoleTopBuff(roleData).Forget();
			}
			else
			{
				this.BuffItemContainer.ClearAll();
			}
			this.RefreshAllRoleTopBuffVisible();
		}

		// Token: 0x06031E38 RID: 204344 RVA: 0x00DF396C File Offset: 0x00DF1B6C
		public void Tick(float delta)
		{
			this.BuffItemContainer.Tick(delta);
			foreach (TopBuffContainer topBuffContainer in this.RoleBarMap.Values)
			{
				topBuffContainer.Tick(delta);
			}
		}

		// Token: 0x06031E39 RID: 204345 RVA: 0x00DF39D0 File Offset: 0x00DF1BD0
		public void AddBuff(GameplayCue buffCueConfig, int handleId)
		{
			this.BuffItemContainer.AddBuffByCue(buffCueConfig, handleId, true);
		}

		// Token: 0x06031E3A RID: 204346 RVA: 0x00DF39E0 File Offset: 0x00DF1BE0
		public void RemoveBuff(GameplayCue buffCueConfig, int handleId)
		{
			this.BuffItemContainer.RemoveBuffByCue(buffCueConfig, handleId, true);
		}

		// Token: 0x06031E3B RID: 204347 RVA: 0x00DF39F4 File Offset: 0x00DF1BF4
		public void OnRemoveEntity(int entityId)
		{
			TopBuffContainer topBuffContainer;
			if (this.RoleBarMap.Remove(entityId, out topBuffContainer))
			{
				topBuffContainer.Destroy();
				if (this.CurRoleBar == topBuffContainer)
				{
					this.CurRoleBar = null;
					return;
				}
			}
			else
			{
				this.NoRoleBarSet.Remove(entityId);
			}
		}

		// Token: 0x06031E3C RID: 204348 RVA: 0x00DF3A35 File Offset: 0x00DF1C35
		private void AddEvents()
		{
			EventSystem.Instance.Add(EEventName.BattleUiAllRoleDataChanged, new Action(this.OnFormationLoaded));
		}

		// Token: 0x06031E3D RID: 204349 RVA: 0x00DF3A53 File Offset: 0x00DF1C53
		private void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.BattleUiAllRoleDataChanged, new Action(this.OnFormationLoaded));
		}

		// Token: 0x06031E3E RID: 204350 RVA: 0x00DF3A71 File Offset: 0x00DF1C71
		private void OnFormationLoaded()
		{
			this.LoadAllRoleTopBuff();
			this.RefreshAllRoleTopBuffVisible();
		}

		// Token: 0x06031E3F RID: 204351 RVA: 0x00DF3A80 File Offset: 0x00DF1C80
		private void LoadAllRoleTopBuff()
		{
			foreach (SceneTeamItem sceneTeamItem in SceneTeamModel.Instance.GetTeamItems(true))
			{
				EntityHandle entityHandle = sceneTeamItem.EntityHandle;
				int? num = (entityHandle != null) ? new int?(entityHandle.Id) : null;
				if (num != null)
				{
					BattleUiRoleData roleData = BattleUiModel.Instance.GetRoleData(num.Value);
					if (roleData != null)
					{
						this.LoadRoleTopBuff(roleData).Forget();
					}
				}
			}
		}

		// Token: 0x06031E40 RID: 204352 RVA: 0x00DF3B1C File Offset: 0x00DF1D1C
		private UniTask LoadRoleTopBuff(BattleUiRoleData roleData)
		{
			RoleUniqueBuffView.<LoadRoleTopBuff>d__21 <LoadRoleTopBuff>d__;
			<LoadRoleTopBuff>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadRoleTopBuff>d__.<>4__this = this;
			<LoadRoleTopBuff>d__.roleData = roleData;
			<LoadRoleTopBuff>d__.<>1__state = -1;
			<LoadRoleTopBuff>d__.<>t__builder.Start<RoleUniqueBuffView.<LoadRoleTopBuff>d__21>(ref <LoadRoleTopBuff>d__);
			return <LoadRoleTopBuff>d__.<>t__builder.Task;
		}

		// Token: 0x06031E41 RID: 204353 RVA: 0x00DF3B68 File Offset: 0x00DF1D68
		private void RefreshAllRoleTopBuffVisible()
		{
			foreach (KeyValuePair<int, TopBuffContainer> keyValuePair in this.RoleBarMap)
			{
				int num;
				TopBuffContainer topBuffContainer;
				keyValuePair.Deconstruct(out num, out topBuffContainer);
				int num2 = num;
				TopBuffContainer topBuffContainer2 = topBuffContainer;
				int? entityId = this.EntityId;
				if (num2 == entityId.GetValueOrDefault() & entityId != null)
				{
					topBuffContainer2.SetVisible(true);
					this.CurRoleBar = topBuffContainer2;
				}
				else
				{
					topBuffContainer2.SetVisible(false);
				}
			}
		}

		// Token: 0x06031E43 RID: 204355 RVA: 0x00DF3C21 File Offset: 0x00DF1E21
		// Note: this type is marked as 'beforefieldinit'.
		static RoleUniqueBuffView()
		{
			Dictionary<int, Type> dictionary = new Dictionary<int, Type>();
			dictionary[1106] = typeof(TopBuffYouHu);
			dictionary[1307] = typeof(TopBuffBuLing);
			RoleUniqueBuffView.RoleClassMap = dictionary;
		}

		// Token: 0x0401A65A RID: 108122
		[StaticVariableRuleIgnore]
		private static readonly Dictionary<int, Type> RoleClassMap;

		// Token: 0x0401A65B RID: 108123
		private readonly BuffItemContainer BuffItemContainer = new BuffItemContainer();

		// Token: 0x0401A65C RID: 108124
		[Nullable(2)]
		private BuffItem ExceedTipItem;

		// Token: 0x0401A65D RID: 108125
		private int? EntityId;

		// Token: 0x0401A65E RID: 108126
		[Nullable(2)]
		private TopBuffContainer CurRoleBar;

		// Token: 0x0401A65F RID: 108127
		private readonly Dictionary<int, TopBuffContainer> RoleBarMap = new Dictionary<int, TopBuffContainer>();

		// Token: 0x0401A660 RID: 108128
		private readonly HashSet<int> NoRoleBarSet = new HashSet<int>();
	}
}
