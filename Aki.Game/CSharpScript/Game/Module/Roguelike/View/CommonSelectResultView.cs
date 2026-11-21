using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike.View
{
	// Token: 0x02003E10 RID: 15888
	[NullableContext(2)]
	[Nullable(0)]
	public class CommonSelectResultView : RogueSelectResultBaseView
	{
		// Token: 0x06028900 RID: 166144 RVA: 0x00B619D1 File Offset: 0x00B5FBD1
		[NullableContext(1)]
		public CommonSelectResultView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06028901 RID: 166145 RVA: 0x00B619DC File Offset: 0x00B5FBDC
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

		// Token: 0x06028902 RID: 166146 RVA: 0x00B61A80 File Offset: 0x00B5FC80
		protected override UniTask OnBeforeStartAsync()
		{
			CommonSelectResultView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CommonSelectResultView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06028903 RID: 166147 RVA: 0x00B61AC4 File Offset: 0x00B5FCC4
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

		// Token: 0x06028904 RID: 166148 RVA: 0x00B61B30 File Offset: 0x00B5FD30
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

		// Token: 0x06028905 RID: 166149 RVA: 0x00B61B7C File Offset: 0x00B5FD7C
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

		// Token: 0x06028906 RID: 166150 RVA: 0x00B61C16 File Offset: 0x00B5FE16
		protected override void OnDescModelChange()
		{
			this.Refresh();
		}

		// Token: 0x06028907 RID: 166151 RVA: 0x00B61C1E File Offset: 0x00B5FE1E
		protected override void Refresh()
		{
			this.CommonSelectItem.RefreshPanel();
			this.ExtraCommonSelectItem.RefreshPanel();
			this.PhantomSelectItem.RefreshPanel();
			this.RefreshTitleText();
		}

		// Token: 0x06028908 RID: 166152 RVA: 0x00B61C48 File Offset: 0x00B5FE48
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

		// Token: 0x06028909 RID: 166153 RVA: 0x00B61C94 File Offset: 0x00B5FE94
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

		// Token: 0x04016014 RID: 90132
		private RogueSelectResult RogueSelectResult;

		// Token: 0x04016015 RID: 90133
		private readonly UiPoolActor CommonItemActor;

		// Token: 0x04016016 RID: 90134
		private CommonSelectItem CommonSelectItem;

		// Token: 0x04016017 RID: 90135
		private readonly UiPoolActor ExtraCommonItemActor;

		// Token: 0x04016018 RID: 90136
		private CommonSelectItem ExtraCommonSelectItem;

		// Token: 0x04016019 RID: 90137
		private readonly UiPoolActor PhantomItemActor;

		// Token: 0x0401601A RID: 90138
		private PhantomSelectItem PhantomSelectItem;
	}
}
