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
	// Token: 0x02004DA4 RID: 19876
	[NullableContext(1)]
	[Nullable(0)]
	public class SilentAreaInfoItem : UiPanelBase
	{
		// Token: 0x06031F3E RID: 204606 RVA: 0x00DFA91C File Offset: 0x00DF8B1C
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

		// Token: 0x06031F3F RID: 204607 RVA: 0x00DFA9A8 File Offset: 0x00DF8BA8
		public void Initialize(AActor actor, ILevelPlayInformation config)
		{
			base.CreateByActorAsync(actor, null, false).ContinueWith(delegate()
			{
				this.UpdateItem(config);
			}).Forget();
		}

		// Token: 0x06031F40 RID: 204608 RVA: 0x00DFA9E8 File Offset: 0x00DF8BE8
		public void SetCurrentShowType(EInformationViewType type)
		{
			this.CurrentShowType = type;
		}

		// Token: 0x06031F41 RID: 204609 RVA: 0x00DFA9F4 File Offset: 0x00DF8BF4
		protected override UniTask OnBeforeStartAsync()
		{
			SilentAreaInfoItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SilentAreaInfoItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031F42 RID: 204610 RVA: 0x00DFAA37 File Offset: 0x00DF8C37
		public void UpdateItem(ILevelPlayInformation config)
		{
			this.UpdateTitleText(config.TidMainTitle);
			this.UpdateSubItems(config.SubTitles);
		}

		// Token: 0x06031F43 RID: 204611 RVA: 0x00DFAA54 File Offset: 0x00DF8C54
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

		// Token: 0x06031F44 RID: 204612 RVA: 0x00DFAA94 File Offset: 0x00DF8C94
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

		// Token: 0x0401A725 RID: 108325
		private EInformationViewType CurrentShowType;

		// Token: 0x0401A726 RID: 108326
		private readonly List<SilentAreaInfoSubItem> SubItems = new List<SilentAreaInfoSubItem>();

		// Token: 0x0200AAC7 RID: 43719
		[NullableContext(0)]
		private enum EChildComponent
		{
			// Token: 0x04034C56 RID: 216150
			ParentTitleText,
			// Token: 0x04034C57 RID: 216151
			SubItem,
			// Token: 0x04034C58 RID: 216152
			SubItemRoot
		}
	}
}
