using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x02005334 RID: 21300
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueResSkillOverView : UiViewBase
	{
		// Token: 0x0603671F RID: 223007 RVA: 0x00CE3E4E File Offset: 0x00CE204E
		public RogueResSkillOverView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06036720 RID: 223008 RVA: 0x00CE3E64 File Offset: 0x00CE2064
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem))
			};
		}

		// Token: 0x06036721 RID: 223009 RVA: 0x00CE3EEC File Offset: 0x00CE20EC
		protected override UniTask OnBeforeStartAsync()
		{
			RogueResSkillOverView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueResSkillOverView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036722 RID: 223010 RVA: 0x00CE3F2F File Offset: 0x00CE212F
		protected override void OnBeforeDestroy()
		{
			this.SkillDescItemList.Clear();
		}

		// Token: 0x06036723 RID: 223011 RVA: 0x00CE3F3C File Offset: 0x00CE213C
		protected UniTask InitDescItem()
		{
			RogueResSkillOverView.<InitDescItem>d__7 <InitDescItem>d__;
			<InitDescItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitDescItem>d__.<>4__this = this;
			<InitDescItem>d__.<>1__state = -1;
			<InitDescItem>d__.<>t__builder.Start<RogueResSkillOverView.<InitDescItem>d__7>(ref <InitDescItem>d__);
			return <InitDescItem>d__.<>t__builder.Task;
		}

		// Token: 0x0401CCB1 RID: 117937
		[Nullable(2)]
		public PopupCaptionItem CaptionItem;

		// Token: 0x0401CCB2 RID: 117938
		public List<RogueResSkillDesc> SkillDescItemList = new List<RogueResSkillDesc>();

		// Token: 0x0401CCB3 RID: 117939
		private int SeasonId;
	}
}
