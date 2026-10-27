using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004E3F RID: 20031
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleSelectResultView : RogueSelectResultBaseView
	{
		// Token: 0x06033A43 RID: 211523 RVA: 0x00C16548 File Offset: 0x00C14748
		public RoleSelectResultView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06033A44 RID: 211524 RVA: 0x00C16578 File Offset: 0x00C14778
		protected override UniTask OnCreateAsync()
		{
			RoleSelectResultView.<OnCreateAsync>d__4 <OnCreateAsync>d__;
			<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnCreateAsync>d__.<>4__this = this;
			<OnCreateAsync>d__.<>1__state = -1;
			<OnCreateAsync>d__.<>t__builder.Start<RoleSelectResultView.<OnCreateAsync>d__4>(ref <OnCreateAsync>d__);
			return <OnCreateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033A45 RID: 211525 RVA: 0x00C165BC File Offset: 0x00C147BC
		protected override void OnStart()
		{
			base.OnStart();
			this.UiPoolActorPrivate.UiItem.SetUIParent(base.GetHorizontalLayout(3).GetRootComponent(), false);
			this.RogueSelectResult = (this.OpenParam as RogueSelectResult);
			this.RoleSelectItemLayout = new GenericLayout<RoleSelectItem, RogueGainEntry>(base.GetHorizontalLayout(3), this.CreateRoleSelectItem, null, false, true);
		}

		// Token: 0x06033A46 RID: 211526 RVA: 0x00C16618 File Offset: 0x00C14818
		protected override void OnBeforeDestroy()
		{
			if (this.UiPoolActorPrivate != null)
			{
				UiActorPool.Instance.RecycleAsync(this.UiPoolActorPrivate, "UiItem_RoleSelectItem_Prefab");
			}
		}

		// Token: 0x06033A47 RID: 211527 RVA: 0x00C16637 File Offset: 0x00C14837
		protected override void OnCloseBtnClick()
		{
			base.CloseMe(delegate(bool _)
			{
				RogueSelectResult rogueSelectResult = this.RogueSelectResult;
				if (rogueSelectResult == null)
				{
					return;
				}
				Action callBack = rogueSelectResult.CallBack;
				if (callBack == null)
				{
					return;
				}
				callBack();
			});
		}

		// Token: 0x06033A48 RID: 211528 RVA: 0x00C1664B File Offset: 0x00C1484B
		protected override void OnDescModelChange()
		{
			this.Refresh();
		}

		// Token: 0x06033A49 RID: 211529 RVA: 0x00C16653 File Offset: 0x00C14853
		protected override void OnBeforeShow()
		{
			this.Refresh();
		}

		// Token: 0x06033A4A RID: 211530 RVA: 0x00C1665B File Offset: 0x00C1485B
		protected override void Refresh()
		{
			this.RefreshPhantomSelectItemList();
			this.RefreshTitleText();
		}

		// Token: 0x06033A4B RID: 211531 RVA: 0x00C1666C File Offset: 0x00C1486C
		private void RefreshPhantomSelectItemList()
		{
			this.RoleSelectItemLayout.RefreshByDataAsync(new <>z__ReadOnlySingleElementList<RogueGainEntry>(this.RogueSelectResult.NewRogueGainEntry), false, null).ContinueWith(new Action(this.RefreshNewRoleBuff));
		}

		// Token: 0x06033A4C RID: 211532 RVA: 0x00C166B0 File Offset: 0x00C148B0
		private void RefreshNewRoleBuff()
		{
			RogueGainEntry newRogueGainEntry = this.RogueSelectResult.NewRogueGainEntry;
			RogueGainEntry oldRogueGainEntry = this.RogueSelectResult.OldRogueGainEntry;
			HashSet<long> hashSet = new HashSet<long>();
			if (newRogueGainEntry != null)
			{
				foreach (AffixEntry affixEntry in newRogueGainEntry.AffixEntryList)
				{
					bool flag = false;
					if (((oldRogueGainEntry != null) ? oldRogueGainEntry.AffixEntryList : null) != null)
					{
						foreach (AffixEntry affixEntry2 in oldRogueGainEntry.AffixEntryList)
						{
							int? id = affixEntry2.Id;
							int value = affixEntry.Id.Value;
							if (id.GetValueOrDefault() == value & id != null)
							{
								flag = true;
								break;
							}
						}
					}
					if (!flag && !hashSet.Contains((long)affixEntry.Id.Value))
					{
						hashSet.Add((long)affixEntry.Id.Value);
					}
				}
			}
			if (hashSet.Count <= 0)
			{
				return;
			}
			RoleSelectItem layoutItemByIndex = this.RoleSelectItemLayout.GetLayoutItemByIndex(0);
			if (layoutItemByIndex == null)
			{
				return;
			}
			layoutItemByIndex.SetSecondColorForAttrItem(hashSet);
		}

		// Token: 0x06033A4D RID: 211533 RVA: 0x00C167F4 File Offset: 0x00C149F4
		protected void RefreshTitleText()
		{
			base.GetText(4).ShowTextNew("RoguelikeView_18_Text");
		}

		// Token: 0x0401B629 RID: 112169
		[Nullable(2)]
		private RogueSelectResult RogueSelectResult;

		// Token: 0x0401B62A RID: 112170
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RoleSelectItem, RogueGainEntry> RoleSelectItemLayout;

		// Token: 0x0401B62B RID: 112171
		[Nullable(2)]
		protected UiPoolActor UiPoolActorPrivate;

		// Token: 0x0401B62C RID: 112172
		private readonly Func<RoleSelectItem> CreateRoleSelectItem = () => new RoleSelectItem();
	}
}
