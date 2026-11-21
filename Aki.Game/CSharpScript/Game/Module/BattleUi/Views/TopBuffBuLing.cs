using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004E25 RID: 20005
	[NullableContext(1)]
	[Nullable(0)]
	public class TopBuffBuLing : TopBuffContainer
	{
		// Token: 0x06032531 RID: 206129 RVA: 0x00E1BB60 File Offset: 0x00E19D60
		protected override UniTask OnInitAsync()
		{
			TopBuffBuLing.<OnInitAsync>d__4 <OnInitAsync>d__;
			<OnInitAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnInitAsync>d__.<>4__this = this;
			<OnInitAsync>d__.<>1__state = -1;
			<OnInitAsync>d__.<>t__builder.Start<TopBuffBuLing.<OnInitAsync>d__4>(ref <OnInitAsync>d__);
			return <OnInitAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032532 RID: 206130 RVA: 0x00E1BBA4 File Offset: 0x00E19DA4
		public override void SetVisible(bool visible)
		{
			foreach (TopBuffItemBuLing topBuffItemBuLing in this.ItemList)
			{
				topBuffItemBuLing.SetVisible(0, visible);
			}
		}

		// Token: 0x06032533 RID: 206131 RVA: 0x00E1BBF8 File Offset: 0x00E19DF8
		private void AddEvents()
		{
			foreach (int tagId in TopBuffBuLing.TagIds)
			{
				base.ListenForTagAddOrRemoveChanged(tagId, new BaseTagComponent.TTagSwitchedCallback(this.OnTagCountChange));
			}
		}

		// Token: 0x06032534 RID: 206132 RVA: 0x00E1BC30 File Offset: 0x00E19E30
		private void RemoveEvents()
		{
		}

		// Token: 0x06032535 RID: 206133 RVA: 0x00E1BC32 File Offset: 0x00E19E32
		private void OnTagCountChange(int tagId, bool tagExist)
		{
			this.Dirty = true;
		}

		// Token: 0x06032536 RID: 206134 RVA: 0x00E1BC3C File Offset: 0x00E19E3C
		public override void Tick(float delta)
		{
			base.Tick(delta);
			if (this.Dirty)
			{
				this.RefreshItemList(false);
				this.Dirty = false;
			}
			foreach (TopBuffItemBuLing topBuffItemBuLing in this.ItemList)
			{
				topBuffItemBuLing.TickHiding(delta);
			}
		}

		// Token: 0x06032537 RID: 206135 RVA: 0x00E1BCAC File Offset: 0x00E19EAC
		private void RefreshItemList(bool isInit = false)
		{
			BattleUiRoleData roleData = this.RoleData;
			BaseTagComponent baseTagComponent = (roleData != null) ? roleData.GameplayTagComponent : null;
			if (baseTagComponent == null)
			{
				foreach (TopBuffItemBuLing topBuffItemBuLing in this.ItemList)
				{
					topBuffItemBuLing.Refresh(0, 0, 0, !isInit);
				}
				return;
			}
			int count = this.ItemList.Count;
			int[] array = new int[4];
			for (int i = 0; i < TopBuffBuLing.TagIds.Length; i++)
			{
				int tagId = TopBuffBuLing.TagIds[i];
				if (baseTagComponent.HasTag(tagId))
				{
					array[i % 4] = ((i < 4) ? 1 : 2);
				}
			}
			int num = 0;
			int[] array2 = array;
			for (int j = 0; j < array2.Length; j++)
			{
				if (array2[j] > 0)
				{
					num++;
				}
			}
			if (this.LastCount == 4 && num == 4)
			{
				TopBuffItemBuLing topBuffItemBuLing2 = this.ItemList.Shift<TopBuffItemBuLing>();
				this.ItemList.Add(topBuffItemBuLing2);
				topBuffItemBuLing2.GetRootItem().SetHierarchyIndex(this.ItemList[2].GetRootItem().GetHierarchyIndex());
			}
			int num2 = -1;
			if (this.LastCount - num == 2)
			{
				num2 = num;
			}
			this.LastCount = num;
			for (int k = 0; k < num; k++)
			{
				int state = 0;
				if (num == 0)
				{
					state = 0;
				}
				else if (num == 1)
				{
					state = 2;
				}
				else if (num - k <= 2)
				{
					state = 1;
				}
				this.ItemList[k].Refresh(array[k], state, 0, !isInit);
			}
			for (int l = num; l < count; l++)
			{
				if (num2 != -1)
				{
					if (l == num2)
					{
						this.ItemList[l].Refresh(0, 0, 1, !isInit);
					}
					else if (l == num2 + 1)
					{
						this.ItemList[l].Refresh(0, 0, 2, !isInit);
					}
					else
					{
						this.ItemList[l].Refresh(0, 0, 0, !isInit);
					}
				}
				else
				{
					this.ItemList[l].Refresh(0, 0, 0, !isInit);
				}
			}
		}

		// Token: 0x06032538 RID: 206136 RVA: 0x00E1BECC File Offset: 0x00E1A0CC
		protected override void OnDestroy()
		{
			this.RemoveEvents();
			foreach (TopBuffItemBuLing topBuffItemBuLing in this.ItemList)
			{
				topBuffItemBuLing.Destroy(null);
			}
		}

		// Token: 0x0401AACD RID: 109261
		[StaticVariableRuleIgnore]
		private static readonly int[] TagIds = new int[]
		{
			GameplayTagDefine.EGameplayTagId["角色.BulingMd10011.卦象.UI标识.A1"],
			GameplayTagDefine.EGameplayTagId["角色.BulingMd10011.卦象.UI标识.A2"],
			GameplayTagDefine.EGameplayTagId["角色.BulingMd10011.卦象.UI标识.A3"],
			GameplayTagDefine.EGameplayTagId["角色.BulingMd10011.卦象.UI标识.A4"],
			GameplayTagDefine.EGameplayTagId["角色.BulingMd10011.卦象.UI标识.B1"],
			GameplayTagDefine.EGameplayTagId["角色.BulingMd10011.卦象.UI标识.B2"],
			GameplayTagDefine.EGameplayTagId["角色.BulingMd10011.卦象.UI标识.B3"],
			GameplayTagDefine.EGameplayTagId["角色.BulingMd10011.卦象.UI标识.B4"]
		};

		// Token: 0x0401AACE RID: 109262
		private bool Dirty;

		// Token: 0x0401AACF RID: 109263
		private readonly List<TopBuffItemBuLing> ItemList = new List<TopBuffItemBuLing>();

		// Token: 0x0401AAD0 RID: 109264
		private int LastCount;
	}
}
