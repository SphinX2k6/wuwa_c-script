using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DC2 RID: 24002
	[NullableContext(1)]
	[Nullable(0)]
	public class SilentAreaInfoSubItem : UiPanelBase
	{
		// Token: 0x0603CFDC RID: 249820 RVA: 0x00EAA160 File Offset: 0x00EA8360
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603CFDD RID: 249821 RVA: 0x00EAA1C9 File Offset: 0x00EA83C9
		public void SetCurrentShowType(EInformationViewType type)
		{
			this.CurrentShowType = type;
		}

		// Token: 0x0603CFDE RID: 249822 RVA: 0x00EAA1D4 File Offset: 0x00EA83D4
		public void Initialize(AActor actor, IInformationSubTitle config)
		{
			base.CreateByActorAsync(actor, null, false).ContinueWith(delegate()
			{
				this.UpdateItem(config);
			}).Forget();
		}

		// Token: 0x0603CFDF RID: 249823 RVA: 0x00EAA214 File Offset: 0x00EA8414
		public void UpdateItem(IInformationSubTitle config)
		{
			bool flag = this.UpdateTitleText(config.TidTitle);
			this.UpdateDescribeText(config.TidContent, flag ? 32 : 36);
		}

		// Token: 0x0603CFE0 RID: 249824 RVA: 0x00EAA244 File Offset: 0x00EA8444
		private bool UpdateTitleText(string title)
		{
			UUIText text = base.GetText(0);
			string text2;
			if (this.CurrentShowType == EInformationViewType.LevelPlay)
			{
				text2 = PublicUtil.Instance.GetConfigTextByKey(title);
			}
			else
			{
				text2 = ConfigMultiTextLang.GetLocalTextNew(title, null);
			}
			if (string.IsNullOrWhiteSpace(text2))
			{
				if (text != null)
				{
					UUIItem parentAsUIItem = text.GetParentAsUIItem();
					if (parentAsUIItem != null)
					{
						parentAsUIItem.SetUIActive(false);
					}
				}
				return false;
			}
			if (text != null)
			{
				text.SetText(text2, true);
			}
			if (text != null)
			{
				UUIItem parentAsUIItem2 = text.GetParentAsUIItem();
				if (parentAsUIItem2 != null)
				{
					parentAsUIItem2.SetUIActive(true);
				}
			}
			return true;
		}

		// Token: 0x0603CFE1 RID: 249825 RVA: 0x00EAA2B8 File Offset: 0x00EA84B8
		private void UpdateDescribeText(string title, int fontSize)
		{
			UUIText text = base.GetText(1);
			string text2;
			if (this.CurrentShowType == EInformationViewType.LevelPlay)
			{
				text2 = PublicUtil.Instance.GetConfigTextByKey(title);
			}
			else
			{
				text2 = ConfigMultiTextLang.GetLocalTextNew(title, null);
			}
			if (string.IsNullOrWhiteSpace(text2))
			{
				if (text != null)
				{
					text.SetUIActive(false);
				}
				return;
			}
			if (text != null)
			{
				text.SetText(text2, true);
			}
			if (text != null)
			{
				text.SetFontSize((float)fontSize);
			}
			if (text != null)
			{
				text.SetUIActive(true);
			}
		}

		// Token: 0x0401FC6F RID: 130159
		private EInformationViewType CurrentShowType;

		// Token: 0x0200C0C4 RID: 49348
		[NullableContext(0)]
		private enum EChildComponent
		{
			// Token: 0x0403A299 RID: 238233
			Title,
			// Token: 0x0403A29A RID: 238234
			Describe
		}
	}
}
