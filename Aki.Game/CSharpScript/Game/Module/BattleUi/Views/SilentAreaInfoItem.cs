using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DC0 RID: 24000
	[NullableContext(1)]
	[Nullable(0)]
	public class SilentAreaInfoItem : UiPanelBase
	{
		// Token: 0x0603CFC7 RID: 249799 RVA: 0x00EA9A40 File Offset: 0x00EA7C40
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603CFC8 RID: 249800 RVA: 0x00EA9ACC File Offset: 0x00EA7CCC
		public void Initialize(AActor actor, ILevelPlayInformation config)
		{
			base.CreateByActorAsync(actor, null, false).ContinueWith(delegate()
			{
				this.UpdateItem(config);
			}).Forget();
		}

		// Token: 0x0603CFC9 RID: 249801 RVA: 0x00EA9B0C File Offset: 0x00EA7D0C
		public void SetCurrentShowType(EInformationViewType type)
		{
			this.CurrentShowType = type;
		}

		// Token: 0x0603CFCA RID: 249802 RVA: 0x00EA9B18 File Offset: 0x00EA7D18
		protected override UniTask OnBeforeStartAsync()
		{
			SilentAreaInfoItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SilentAreaInfoItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603CFCB RID: 249803 RVA: 0x00EA9B5B File Offset: 0x00EA7D5B
		public void UpdateItem(ILevelPlayInformation config)
		{
			this.UpdateTitleText(config.TidMainTitle);
			this.UpdateSubItems(config.SubTitles);
		}

		// Token: 0x0603CFCC RID: 249804 RVA: 0x00EA9B78 File Offset: 0x00EA7D78
		private void UpdateTitleText(string title)
		{
			UUIText text = base.GetText(0);
			string newText;
			if (this.CurrentShowType == EInformationViewType.LevelPlay)
			{
				newText = PublicUtil.Instance.GetConfigTextByKey(title);
			}
			else
			{
				newText = ConfigMultiTextLang.GetLocalTextNew(title, null);
			}
			if (text == null)
			{
				return;
			}
			text.SetText(newText, true);
		}

		// Token: 0x0603CFCD RID: 249805 RVA: 0x00EA9BB8 File Offset: 0x00EA7DB8
		private void UpdateSubItems(List<IInformationSubTitle> subConfigs)
		{
			for (int i = 0; i < subConfigs.Count; i++)
			{
				IInformationSubTitle config = subConfigs[i];
				if (i < this.SubItems.Count)
				{
					SilentAreaInfoSubItem silentAreaInfoSubItem = this.SubItems[i];
					silentAreaInfoSubItem.SetCurrentShowType(this.CurrentShowType);
					silentAreaInfoSubItem.UpdateItem(config);
				}
				else
				{
					UUIItem uuiitem = LguiUtil.Instance.CopyItem(base.GetItem(1), base.GetItem(2));
					SilentAreaInfoSubItem silentAreaInfoSubItem = new SilentAreaInfoSubItem();
					silentAreaInfoSubItem.SetCurrentShowType(this.CurrentShowType);
					silentAreaInfoSubItem.Initialize(uuiitem.GetOwner(), config);
					this.SubItems.Add(silentAreaInfoSubItem);
				}
			}
			for (int j = 0; j < this.SubItems.Count; j++)
			{
				this.SubItems[j].SetActive(j < subConfigs.Count);
			}
		}

		// Token: 0x0401FC68 RID: 130152
		private EInformationViewType CurrentShowType;

		// Token: 0x0401FC69 RID: 130153
		private readonly List<SilentAreaInfoSubItem> SubItems = new List<SilentAreaInfoSubItem>();

		// Token: 0x0200C0BE RID: 49342
		[NullableContext(0)]
		private enum EChildComponent
		{
			// Token: 0x0403A284 RID: 238212
			ParentTitleText,
			// Token: 0x0403A285 RID: 238213
			SubItem,
			// Token: 0x0403A286 RID: 238214
			SubItemRoot
		}
	}
}
