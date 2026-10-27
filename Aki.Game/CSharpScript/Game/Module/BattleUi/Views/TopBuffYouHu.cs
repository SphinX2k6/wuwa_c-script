using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005E45 RID: 24133
	public class TopBuffYouHu : TopBuffContainer
	{
		// Token: 0x0603D5D0 RID: 251344 RVA: 0x00ECB2D0 File Offset: 0x00EC94D0
		protected override UniTask OnInitAsync()
		{
			TopBuffYouHu.<OnInitAsync>d__3 <OnInitAsync>d__;
			<OnInitAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnInitAsync>d__.<>4__this = this;
			<OnInitAsync>d__.<>1__state = -1;
			<OnInitAsync>d__.<>t__builder.Start<TopBuffYouHu.<OnInitAsync>d__3>(ref <OnInitAsync>d__);
			return <OnInitAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D5D1 RID: 251345 RVA: 0x00ECB314 File Offset: 0x00EC9514
		public override void SetVisible(bool visible)
		{
			foreach (TopBuffItemYouHu topBuffItemYouHu in this.ItemList)
			{
				topBuffItemYouHu.SetVisible(0, visible);
			}
		}

		// Token: 0x0603D5D2 RID: 251346 RVA: 0x00ECB368 File Offset: 0x00EC9568
		private void AddEvents()
		{
			foreach (int tagId in TopBuffYouHu.TagIds)
			{
				base.ListenForTagCountChanged(tagId, new BaseTagComponent.TTagChangedCallback(this.OnTagCountChange));
			}
		}

		// Token: 0x0603D5D3 RID: 251347 RVA: 0x00ECB3A0 File Offset: 0x00EC95A0
		private void RemoveEvents()
		{
		}

		// Token: 0x0603D5D4 RID: 251348 RVA: 0x00ECB3A2 File Offset: 0x00EC95A2
		private void OnTagCountChange(int count, int tagId, int exactTagId, int oldCount)
		{
			this.RefreshItemList();
		}

		// Token: 0x0603D5D5 RID: 251349 RVA: 0x00ECB3AC File Offset: 0x00EC95AC
		private void RefreshItemList()
		{
			BattleUiRoleData roleData = this.RoleData;
			BaseTagComponent baseTagComponent = (roleData != null) ? roleData.GameplayTagComponent : null;
			if (baseTagComponent == null)
			{
				foreach (TopBuffItemYouHu topBuffItemYouHu in this.ItemList)
				{
					topBuffItemYouHu.SetVisible(1, false);
				}
				return;
			}
			int num = 0;
			int count = this.ItemList.Count;
			foreach (int tagId in TopBuffYouHu.TagIds)
			{
				int tagCount = baseTagComponent.GetTagCount(tagId);
				for (int j = 0; j < tagCount; j++)
				{
					this.ItemList[num].RefreshByTag(tagId);
					this.ItemList[num].SetVisible(1, true);
					num++;
					if (num >= count)
					{
						return;
					}
				}
			}
			for (int k = num; k < count; k++)
			{
				this.ItemList[k].SetVisible(1, false);
			}
		}

		// Token: 0x0603D5D6 RID: 251350 RVA: 0x00ECB4B4 File Offset: 0x00EC96B4
		protected override void OnDestroy()
		{
			this.RemoveEvents();
			foreach (TopBuffItemYouHu topBuffItemYouHu in this.ItemList)
			{
				topBuffItemYouHu.Destroy(null);
			}
		}

		// Token: 0x0402001A RID: 131098
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly int[] TagIds = new int[]
		{
			GameplayTagDefine.EGameplayTagId["角色.R2T1YouHuMd10011.逻辑.底奖.如意"],
			GameplayTagDefine.EGameplayTagId["角色.R2T1YouHuMd10011.逻辑.底奖.鼎"],
			GameplayTagDefine.EGameplayTagId["角色.R2T1YouHuMd10011.逻辑.底奖.编钟"],
			GameplayTagDefine.EGameplayTagId["角色.R2T1YouHuMd10011.逻辑.底奖.面具"]
		};

		// Token: 0x0402001B RID: 131099
		[Nullable(1)]
		private readonly List<TopBuffItemYouHu> ItemList = new List<TopBuffItemYouHu>();

		// Token: 0x0200C1C4 RID: 49604
		private enum EItemVisible
		{
			// Token: 0x0403A8E1 RID: 239841
			Default,
			// Token: 0x0403A8E2 RID: 239842
			Tag
		}
	}
}
