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
	// Token: 0x02004DA6 RID: 19878
	[NullableContext(1)]
	[Nullable(0)]
	public class SilentAreaInfoSubItem : UiPanelBase
	{
		// Token: 0x06031F53 RID: 204627 RVA: 0x00DFB03C File Offset: 0x00DF923C
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

		// Token: 0x06031F54 RID: 204628 RVA: 0x00DFB0A5 File Offset: 0x00DF92A5
		public void SetCurrentShowType(EInformationViewType type)
		{
			this.CurrentShowType = type;
		}

		// Token: 0x06031F55 RID: 204629 RVA: 0x00DFB0B0 File Offset: 0x00DF92B0
		public void Initialize(AActor actor, IInformationSubTitle config)
		{
			base.CreateByActorAsync(actor, null, false).ContinueWith(delegate()
			{
				this.UpdateItem(config);
			}).Forget();
		}

		// Token: 0x06031F56 RID: 204630 RVA: 0x00DFB0F0 File Offset: 0x00DF92F0
		public void UpdateItem(IInformationSubTitle config)
		{
			bool flag = this.UpdateTitleText(config.TidTitle);
			this.UpdateDescribeText(config.TidContent, flag ? 32 : 36);
		}

		// Token: 0x06031F57 RID: 204631 RVA: 0x00DFB120 File Offset: 0x00DF9320
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

		// Token: 0x06031F58 RID: 204632 RVA: 0x00DFB194 File Offset: 0x00DF9394
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

		// Token: 0x0401A72C RID: 108332
		private EInformationViewType CurrentShowType;

		// Token: 0x0200AACD RID: 43725
		[NullableContext(0)]
		private enum EChildComponent
		{
			// Token: 0x04034C6B RID: 216171
			Title,
			// Token: 0x04034C6C RID: 216172
			Describe
		}
	}
}
