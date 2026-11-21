using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003E08 RID: 15880
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleSelectResultView : RogueSelectResultBaseView
	{
		// Token: 0x060288AE RID: 166062 RVA: 0x00B5FA70 File Offset: 0x00B5DC70
		public RoleSelectResultView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060288AF RID: 166063 RVA: 0x00B5FAA0 File Offset: 0x00B5DCA0
		protected override UniTask OnCreateAsync()
		{
			RoleSelectResultView.<OnCreateAsync>d__4 <OnCreateAsync>d__;
			<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnCreateAsync>d__.<>4__this = this;
			<OnCreateAsync>d__.<>1__state = -1;
			<OnCreateAsync>d__.<>t__builder.Start<RoleSelectResultView.<OnCreateAsync>d__4>(ref <OnCreateAsync>d__);
			return <OnCreateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060288B0 RID: 166064 RVA: 0x00B5FAE4 File Offset: 0x00B5DCE4
		protected override void OnStart()
		{
			base.OnStart();
			this.UiPoolActorPrivate.UiItem.SetUIParent(base.GetHorizontalLayout(3).GetRootComponent(), false);
			this.RogueSelectResult = (this.OpenParam as RogueSelectResult);
			this.RoleSelectItemLayout = new GenericLayout<RoleSelectItem, RogueGainEntry>(base.GetHorizontalLayout(3), this.CreateRoleSelectItem, null, false, true);
		}

		// Token: 0x060288B1 RID: 166065 RVA: 0x00B5FB40 File Offset: 0x00B5DD40
		protected override void OnBeforeDestroy()
		{
			if (this.UiPoolActorPrivate != null)
			{
				UiActorPool.Instance.RecycleAsync(this.UiPoolActorPrivate, "UiItem_RoleSelectItem_Prefab");
			}
		}

		// Token: 0x060288B2 RID: 166066 RVA: 0x00B5FB5F File Offset: 0x00B5DD5F
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

		// Token: 0x060288B3 RID: 166067 RVA: 0x00B5FB73 File Offset: 0x00B5DD73
		protected override void OnDescModelChange()
		{
			this.Refresh();
		}

		// Token: 0x060288B4 RID: 166068 RVA: 0x00B5FB7B File Offset: 0x00B5DD7B
		protected override void OnBeforeShow()
		{
			this.Refresh();
		}

		// Token: 0x060288B5 RID: 166069 RVA: 0x00B5FB83 File Offset: 0x00B5DD83
		protected override void Refresh()
		{
			this.RefreshPhantomSelectItemList();
			this.RefreshTitleText();
		}

		// Token: 0x060288B6 RID: 166070 RVA: 0x00B5FB94 File Offset: 0x00B5DD94
		private void RefreshPhantomSelectItemList()
		{
			this.RoleSelectItemLayout.RefreshByDataAsync(new <>z__ReadOnlySingleElementList<RogueGainEntry>(this.RogueSelectResult.NewRogueGainEntry), false, null).ContinueWith(new Action(this.RefreshNewRoleBuff));
		}

		// Token: 0x060288B7 RID: 166071 RVA: 0x00B5FBD8 File Offset: 0x00B5DDD8
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

		// Token: 0x060288B8 RID: 166072 RVA: 0x00B5FD1C File Offset: 0x00B5DF1C
		protected void RefreshTitleText()
		{
			base.GetText(4).ShowTextNew("RoguelikeView_18_Text");
		}

		// Token: 0x04015FFC RID: 90108
		[Nullable(2)]
		private RogueSelectResult RogueSelectResult;

		// Token: 0x04015FFD RID: 90109
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RoleSelectItem, RogueGainEntry> RoleSelectItemLayout;

		// Token: 0x04015FFE RID: 90110
		[Nullable(2)]
		protected UiPoolActor UiPoolActorPrivate;

		// Token: 0x04015FFF RID: 90111
		private readonly Func<RoleSelectItem> CreateRoleSelectItem = () => new RoleSelectItem();
	}
}
