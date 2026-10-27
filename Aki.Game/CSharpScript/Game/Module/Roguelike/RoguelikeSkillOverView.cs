using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004E2F RID: 20015
	public class RoguelikeSkillOverView : UiViewBase
	{
		// Token: 0x060339BC RID: 211388 RVA: 0x00C13AA5 File Offset: 0x00C11CA5
		[NullableContext(1)]
		public RoguelikeSkillOverView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060339BD RID: 211389 RVA: 0x00C13ABC File Offset: 0x00C11CBC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060339BE RID: 211390 RVA: 0x00C13B88 File Offset: 0x00C11D88
		protected override UniTask OnBeforeStartAsync()
		{
			RoguelikeSkillOverView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoguelikeSkillOverView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060339BF RID: 211391 RVA: 0x00C13BCB File Offset: 0x00C11DCB
		protected override void OnBeforeDestroy()
		{
			this.SkillDescItemList = new List<RoguelikeSkillDesc>();
		}

		// Token: 0x060339C0 RID: 211392 RVA: 0x00C13BD8 File Offset: 0x00C11DD8
		protected UniTask InitDescItem()
		{
			RoguelikeSkillOverView.<InitDescItem>d__7 <InitDescItem>d__;
			<InitDescItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitDescItem>d__.<>4__this = this;
			<InitDescItem>d__.<>1__state = -1;
			<InitDescItem>d__.<>t__builder.Start<RoguelikeSkillOverView.<InitDescItem>d__7>(ref <InitDescItem>d__);
			return <InitDescItem>d__.<>t__builder.Task;
		}

		// Token: 0x0401B5F8 RID: 112120
		[Nullable(2)]
		public PopupCaptionItem CaptionItem;

		// Token: 0x0401B5F9 RID: 112121
		[Nullable(1)]
		public List<RoguelikeSkillDesc> SkillDescItemList = new List<RoguelikeSkillDesc>();

		// Token: 0x0200AFE1 RID: 45025
		private class ERoguelikeSkillOverViewDefine
		{
			// Token: 0x04035658 RID: 218712
			public const int TxtSkillNum = 0;

			// Token: 0x04035659 RID: 218713
			public const int CaptionItem = 1;

			// Token: 0x0403565A RID: 218714
			public const int SkillDescItem = 2;

			// Token: 0x0403565B RID: 218715
			public const int SkillDescContent = 3;

			// Token: 0x0403565C RID: 218716
			public const int EmptyItem = 4;
		}
	}
}
