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
	// Token: 0x02003DF8 RID: 15864
	public class RoguelikeSkillOverView : UiViewBase
	{
		// Token: 0x06028827 RID: 165927 RVA: 0x00B5CFD4 File Offset: 0x00B5B1D4
		[NullableContext(1)]
		public RoguelikeSkillOverView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06028828 RID: 165928 RVA: 0x00B5CFE8 File Offset: 0x00B5B1E8
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

		// Token: 0x06028829 RID: 165929 RVA: 0x00B5D0B4 File Offset: 0x00B5B2B4
		protected override UniTask OnBeforeStartAsync()
		{
			RoguelikeSkillOverView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoguelikeSkillOverView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602882A RID: 165930 RVA: 0x00B5D0F7 File Offset: 0x00B5B2F7
		protected override void OnBeforeDestroy()
		{
			this.SkillDescItemList = new List<RoguelikeSkillDesc>();
		}

		// Token: 0x0602882B RID: 165931 RVA: 0x00B5D104 File Offset: 0x00B5B304
		protected UniTask InitDescItem()
		{
			RoguelikeSkillOverView.<InitDescItem>d__7 <InitDescItem>d__;
			<InitDescItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitDescItem>d__.<>4__this = this;
			<InitDescItem>d__.<>1__state = -1;
			<InitDescItem>d__.<>t__builder.Start<RoguelikeSkillOverView.<InitDescItem>d__7>(ref <InitDescItem>d__);
			return <InitDescItem>d__.<>t__builder.Task;
		}

		// Token: 0x04015FCB RID: 90059
		[Nullable(2)]
		public PopupCaptionItem CaptionItem;

		// Token: 0x04015FCC RID: 90060
		[Nullable(1)]
		public List<RoguelikeSkillDesc> SkillDescItemList = new List<RoguelikeSkillDesc>();

		// Token: 0x02009A13 RID: 39443
		private class ERoguelikeSkillOverViewDefine
		{
			// Token: 0x04030088 RID: 196744
			public const int TxtSkillNum = 0;

			// Token: 0x04030089 RID: 196745
			public const int CaptionItem = 1;

			// Token: 0x0403008A RID: 196746
			public const int SkillDescItem = 2;

			// Token: 0x0403008B RID: 196747
			public const int SkillDescContent = 3;

			// Token: 0x0403008C RID: 196748
			public const int EmptyItem = 4;
		}
	}
}
