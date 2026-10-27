using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.GenericPrompt.View;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02004B5B RID: 19291
	public class TowerDefenseStrengthenTipsView : GenericPromptFloatTipsBase
	{
		// Token: 0x06031F31 RID: 204593 RVA: 0x00B9763E File Offset: 0x00B9583E
		[NullableContext(1)]
		public TowerDefenseStrengthenTipsView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06031F32 RID: 204594 RVA: 0x00B97648 File Offset: 0x00B95848
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06031F33 RID: 204595 RVA: 0x00B976B4 File Offset: 0x00B958B4
		protected override UniTask OnBeforeStartAsync()
		{
			TowerDefenseStrengthenTipsView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TowerDefenseStrengthenTipsView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031F34 RID: 204596 RVA: 0x00B976F8 File Offset: 0x00B958F8
		protected override UniTask OnPlayingStartSequenceAsync()
		{
			TowerDefenseStrengthenTipsView.<OnPlayingStartSequenceAsync>d__5 <OnPlayingStartSequenceAsync>d__;
			<OnPlayingStartSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnPlayingStartSequenceAsync>d__.<>4__this = this;
			<OnPlayingStartSequenceAsync>d__.<>1__state = -1;
			<OnPlayingStartSequenceAsync>d__.<>t__builder.Start<TowerDefenseStrengthenTipsView.<OnPlayingStartSequenceAsync>d__5>(ref <OnPlayingStartSequenceAsync>d__);
			return <OnPlayingStartSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031F35 RID: 204597 RVA: 0x00B9773C File Offset: 0x00B9593C
		protected override UniTask OnPlayingCloseSequenceAsync()
		{
			TowerDefenseStrengthenTipsView.<OnPlayingCloseSequenceAsync>d__6 <OnPlayingCloseSequenceAsync>d__;
			<OnPlayingCloseSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnPlayingCloseSequenceAsync>d__.<>4__this = this;
			<OnPlayingCloseSequenceAsync>d__.<>1__state = -1;
			<OnPlayingCloseSequenceAsync>d__.<>t__builder.Start<TowerDefenseStrengthenTipsView.<OnPlayingCloseSequenceAsync>d__6>(ref <OnPlayingCloseSequenceAsync>d__);
			return <OnPlayingCloseSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031F36 RID: 204598 RVA: 0x00B97780 File Offset: 0x00B95980
		private UniTask RefreshTips()
		{
			TowerDefenseStrengthenTipsView.<RefreshTips>d__7 <RefreshTips>d__;
			<RefreshTips>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshTips>d__.<>4__this = this;
			<RefreshTips>d__.<>1__state = -1;
			<RefreshTips>d__.<>t__builder.Start<TowerDefenseStrengthenTipsView.<RefreshTips>d__7>(ref <RefreshTips>d__);
			return <RefreshTips>d__.<>t__builder.Task;
		}

		// Token: 0x06031F37 RID: 204599 RVA: 0x00B977C3 File Offset: 0x00B959C3
		protected override void SetMainText([ParamCollection] [Nullable(new byte[]
		{
			1,
			2
		})] IReadOnlyList<object> param)
		{
		}

		// Token: 0x06031F38 RID: 204600 RVA: 0x00B977C5 File Offset: 0x00B959C5
		protected override void SetExtraText([ParamCollection] [Nullable(new byte[]
		{
			1,
			2
		})] IReadOnlyList<object> param)
		{
		}

		// Token: 0x0401AA29 RID: 109097
		[Nullable(2)]
		private TowerDefenseStrengthenTipsItem TipsItem;

		// Token: 0x0200ACE4 RID: 44260
		private class EComponent
		{
			// Token: 0x0403488F RID: 215183
			public const int ItemVerticalLayout = 0;

			// Token: 0x04034890 RID: 215184
			public const int TipsItem = 1;
		}
	}
}
