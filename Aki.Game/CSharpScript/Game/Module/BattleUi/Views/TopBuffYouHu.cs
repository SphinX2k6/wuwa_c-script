using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004E2A RID: 20010
	public class TopBuffYouHu : TopBuffContainer
	{
		// Token: 0x06032560 RID: 206176 RVA: 0x00E1C83C File Offset: 0x00E1AA3C
		protected override UniTask OnInitAsync()
		{
			TopBuffYouHu.<OnInitAsync>d__3 <OnInitAsync>d__;
			<OnInitAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnInitAsync>d__.<>4__this = this;
			<OnInitAsync>d__.<>1__state = -1;
			<OnInitAsync>d__.<>t__builder.Start<TopBuffYouHu.<OnInitAsync>d__3>(ref <OnInitAsync>d__);
			return <OnInitAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032561 RID: 206177 RVA: 0x00E1C880 File Offset: 0x00E1AA80
		public override void SetVisible(bool visible)
		{
			foreach (TopBuffItemYouHu topBuffItemYouHu in this.ItemList)
			{
				topBuffItemYouHu.SetVisible(0, visible);
			}
		}

		// Token: 0x06032562 RID: 206178 RVA: 0x00E1C8D4 File Offset: 0x00E1AAD4
		private void AddEvents()
		{
			foreach (int tagId in TopBuffYouHu.TagIds)
			{
				base.ListenForTagCountChanged(tagId, new BaseTagComponent.TTagChangedCallback(this.OnTagCountChange));
			}
		}

		// Token: 0x06032563 RID: 206179 RVA: 0x00E1C90C File Offset: 0x00E1AB0C
		private void RemoveEvents()
		{
		}

		// Token: 0x06032564 RID: 206180 RVA: 0x00E1C90E File Offset: 0x00E1AB0E
		private void OnTagCountChange(int count, int tagId, int exactTagId, int oldCount)
		{
			this.RefreshItemList();
		}

		// Token: 0x06032565 RID: 206181 RVA: 0x00E1C918 File Offset: 0x00E1AB18
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

		// Token: 0x06032566 RID: 206182 RVA: 0x00E1CA20 File Offset: 0x00E1AC20
		protected override void OnDestroy()
		{
			this.RemoveEvents();
			foreach (TopBuffItemYouHu topBuffItemYouHu in this.ItemList)
			{
				topBuffItemYouHu.Destroy(null);
			}
		}

		// Token: 0x0401AAE1 RID: 109281
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly int[] TagIds = new int[]
		{
			GameplayTagDefine.EGameplayTagId["角色.R2T1YouHuMd10011.逻辑.底奖.如意"],
			GameplayTagDefine.EGameplayTagId["角色.R2T1YouHuMd10011.逻辑.底奖.鼎"],
			GameplayTagDefine.EGameplayTagId["角色.R2T1YouHuMd10011.逻辑.底奖.编钟"],
			GameplayTagDefine.EGameplayTagId["角色.R2T1YouHuMd10011.逻辑.底奖.面具"]
		};

		// Token: 0x0401AAE2 RID: 109282
		[Nullable(1)]
		private readonly List<TopBuffItemYouHu> ItemList = new List<TopBuffItemYouHu>();

		// Token: 0x0200ABD3 RID: 43987
		private enum EItemVisible
		{
			// Token: 0x040352D3 RID: 217811
			Default,
			// Token: 0x040352D4 RID: 217812
			Tag
		}
	}
}
