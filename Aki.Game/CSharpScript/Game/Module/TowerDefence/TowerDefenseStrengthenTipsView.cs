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
	// Token: 0x02003B03 RID: 15107
	public class TowerDefenseStrengthenTipsView : GenericPromptFloatTipsBase
	{
		// Token: 0x06026CC0 RID: 158912 RVA: 0x00ADB87A File Offset: 0x00AD9A7A
		[NullableContext(1)]
		public TowerDefenseStrengthenTipsView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06026CC1 RID: 158913 RVA: 0x00ADB884 File Offset: 0x00AD9A84
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

		// Token: 0x06026CC2 RID: 158914 RVA: 0x00ADB8F0 File Offset: 0x00AD9AF0
		protected override UniTask OnBeforeStartAsync()
		{
			TowerDefenseStrengthenTipsView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TowerDefenseStrengthenTipsView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06026CC3 RID: 158915 RVA: 0x00ADB934 File Offset: 0x00AD9B34
		protected override UniTask OnPlayingStartSequenceAsync()
		{
			TowerDefenseStrengthenTipsView.<OnPlayingStartSequenceAsync>d__5 <OnPlayingStartSequenceAsync>d__;
			<OnPlayingStartSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnPlayingStartSequenceAsync>d__.<>4__this = this;
			<OnPlayingStartSequenceAsync>d__.<>1__state = -1;
			<OnPlayingStartSequenceAsync>d__.<>t__builder.Start<TowerDefenseStrengthenTipsView.<OnPlayingStartSequenceAsync>d__5>(ref <OnPlayingStartSequenceAsync>d__);
			return <OnPlayingStartSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06026CC4 RID: 158916 RVA: 0x00ADB978 File Offset: 0x00AD9B78
		protected override UniTask OnPlayingCloseSequenceAsync()
		{
			TowerDefenseStrengthenTipsView.<OnPlayingCloseSequenceAsync>d__6 <OnPlayingCloseSequenceAsync>d__;
			<OnPlayingCloseSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnPlayingCloseSequenceAsync>d__.<>4__this = this;
			<OnPlayingCloseSequenceAsync>d__.<>1__state = -1;
			<OnPlayingCloseSequenceAsync>d__.<>t__builder.Start<TowerDefenseStrengthenTipsView.<OnPlayingCloseSequenceAsync>d__6>(ref <OnPlayingCloseSequenceAsync>d__);
			return <OnPlayingCloseSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06026CC5 RID: 158917 RVA: 0x00ADB9BC File Offset: 0x00AD9BBC
		private UniTask RefreshTips()
		{
			TowerDefenseStrengthenTipsView.<RefreshTips>d__7 <RefreshTips>d__;
			<RefreshTips>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshTips>d__.<>4__this = this;
			<RefreshTips>d__.<>1__state = -1;
			<RefreshTips>d__.<>t__builder.Start<TowerDefenseStrengthenTipsView.<RefreshTips>d__7>(ref <RefreshTips>d__);
			return <RefreshTips>d__.<>t__builder.Task;
		}

		// Token: 0x06026CC6 RID: 158918 RVA: 0x00ADB9FF File Offset: 0x00AD9BFF
		protected override void SetMainText([ParamCollection] [Nullable(new byte[]
		{
			1,
			2
		})] IReadOnlyList<object> param)
		{
		}

		// Token: 0x06026CC7 RID: 158919 RVA: 0x00ADBA01 File Offset: 0x00AD9C01
		protected override void SetExtraText([ParamCollection] [Nullable(new byte[]
		{
			1,
			2
		})] IReadOnlyList<object> param)
		{
		}

		// Token: 0x0401537B RID: 86907
		[Nullable(2)]
		private TowerDefenseStrengthenTipsItem TipsItem;

		// Token: 0x02009703 RID: 38659
		private class EComponent
		{
			// Token: 0x0402F238 RID: 193080
			public const int ItemVerticalLayout = 0;

			// Token: 0x0402F239 RID: 193081
			public const int TipsItem = 1;
		}
	}
}
