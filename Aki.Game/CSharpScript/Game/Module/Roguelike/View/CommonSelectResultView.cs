using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike.View
{
	// Token: 0x02004E47 RID: 20039
	[NullableContext(2)]
	[Nullable(0)]
	public class CommonSelectResultView : RogueSelectResultBaseView
	{
		// Token: 0x06033A95 RID: 211605 RVA: 0x00C184A9 File Offset: 0x00C166A9
		[NullableContext(1)]
		public CommonSelectResultView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06033A96 RID: 211606 RVA: 0x00C184B4 File Offset: 0x00C166B4
		protected override void OnCloseBtnClick()
		{
			if (!this.CommonSelectItem.GetRootItem().IsUIActiveInHierarchy())
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
				return;
			}
			this.CommonSelectItem.GetRootItem().SetUIActive(false);
			this.ExtraCommonSelectItem.GetRootItem().SetUIActive(false);
			if (this.RogueSelectResult.GetNewUnlockAffixEntry().Count <= 0)
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
				return;
			}
			this.PhantomSelectItem.GetRootItem().SetUIActive(true);
			base.GetText(4).ShowTextNew("RoguelikeView_21_Text");
			this.InitPhantomSelectItem();
		}

		// Token: 0x06033A97 RID: 211607 RVA: 0x00C18558 File Offset: 0x00C16758
		protected override UniTask OnBeforeStartAsync()
		{
			CommonSelectResultView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CommonSelectResultView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033A98 RID: 211608 RVA: 0x00C1859C File Offset: 0x00C1679C
		private void InitCommonSelectItem()
		{
			if (this.RogueSelectResult.SelectRogueGainEntry != null)
			{
				this.CommonSelectItem.Update(this.RogueSelectResult.SelectRogueGainEntry);
				this.CommonSelectItem.SetToggleUnDetermined();
			}
			if (this.RogueSelectResult.ExtraRogueGainEntry != null)
			{
				this.ExtraCommonSelectItem.Update(this.RogueSelectResult.ExtraRogueGainEntry);
				this.ExtraCommonSelectItem.SetToggleUnDetermined();
			}
		}

		// Token: 0x06033A99 RID: 211609 RVA: 0x00C18608 File Offset: 0x00C16808
		private void InitPhantomSelectItem()
		{
			PhantomSelectItemContextData data = new PhantomSelectItemContextData
			{
				RogueGainEntry = this.RogueSelectResult.NewRogueGainEntry,
				RoguelikeInfo = RoguelikeModel.Instance.RogueInfo
			};
			this.PhantomSelectItem.Update(data);
			this.PhantomSelectItem.SetToggleUnDetermined();
		}

		// Token: 0x06033A9A RID: 211610 RVA: 0x00C18654 File Offset: 0x00C16854
		protected override void OnBeforeDestroy()
		{
			CommonSelectItem commonSelectItem = this.CommonSelectItem;
			if (commonSelectItem != null)
			{
				commonSelectItem.Destroy(null);
			}
			if (this.CommonItemActor != null)
			{
				UiActorPool.Instance.RecycleAsync(this.CommonItemActor, "UiItem_CommonSelectItem_Prefab");
			}
			CommonSelectItem extraCommonSelectItem = this.ExtraCommonSelectItem;
			if (extraCommonSelectItem != null)
			{
				extraCommonSelectItem.Destroy(null);
			}
			if (this.ExtraCommonItemActor != null)
			{
				UiActorPool.Instance.RecycleAsync(this.ExtraCommonItemActor, "UiItem_CommonSelectItem_Prefab");
			}
			PhantomSelectItem phantomSelectItem = this.PhantomSelectItem;
			if (phantomSelectItem != null)
			{
				phantomSelectItem.Destroy(null);
			}
			if (this.PhantomItemActor != null)
			{
				UiActorPool.Instance.RecycleAsync(this.PhantomItemActor, "UiItem_PhantomSelectItem_Prefab");
			}
		}

		// Token: 0x06033A9B RID: 211611 RVA: 0x00C186EE File Offset: 0x00C168EE
		protected override void OnDescModelChange()
		{
			this.Refresh();
		}

		// Token: 0x06033A9C RID: 211612 RVA: 0x00C186F6 File Offset: 0x00C168F6
		protected override void Refresh()
		{
			this.CommonSelectItem.RefreshPanel();
			this.ExtraCommonSelectItem.RefreshPanel();
			this.PhantomSelectItem.RefreshPanel();
			this.RefreshTitleText();
		}

		// Token: 0x06033A9D RID: 211613 RVA: 0x00C18720 File Offset: 0x00C16920
		protected void RefreshTitleText()
		{
			string key = null;
			if (this.RogueSelectResult.IsShowCommon)
			{
				key = "RoguelikeView_20_Text";
			}
			else if (this.RogueSelectResult.GetNewUnlockAffixEntry().Count > 0)
			{
				key = "RoguelikeView_21_Text";
			}
			base.GetText(4).ShowTextNew(key);
		}

		// Token: 0x06033A9E RID: 211614 RVA: 0x00C1876C File Offset: 0x00C1696C
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams.Length != 1)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Guide;
				ELogAuthor author = ELogAuthor.JT;
				string message = "聚焦引导extraParam项配置有误";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("configParams", configParams);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			if (configParams[0] == "Sub")
			{
				PhantomSelectItem phantomSelectItem = this.PhantomSelectItem;
				UUIItem uuiitem = (phantomSelectItem != null) ? phantomSelectItem.GetSubItem() : null;
				if (uuiitem != null)
				{
					return new UUIItem[]
					{
						uuiitem,
						uuiitem
					};
				}
			}
			return null;
		}

		// Token: 0x0401B641 RID: 112193
		private RogueSelectResult RogueSelectResult;

		// Token: 0x0401B642 RID: 112194
		private readonly UiPoolActor CommonItemActor;

		// Token: 0x0401B643 RID: 112195
		private CommonSelectItem CommonSelectItem;

		// Token: 0x0401B644 RID: 112196
		private readonly UiPoolActor ExtraCommonItemActor;

		// Token: 0x0401B645 RID: 112197
		private CommonSelectItem ExtraCommonSelectItem;

		// Token: 0x0401B646 RID: 112198
		private readonly UiPoolActor PhantomItemActor;

		// Token: 0x0401B647 RID: 112199
		private PhantomSelectItem PhantomSelectItem;
	}
}
