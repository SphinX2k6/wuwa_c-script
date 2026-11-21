using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x02004304 RID: 17156
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueResSkillOverView : UiViewBase
	{
		// Token: 0x0602B61B RID: 177691 RVA: 0x00C3181E File Offset: 0x00C2FA1E
		public RogueResSkillOverView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602B61C RID: 177692 RVA: 0x00C31834 File Offset: 0x00C2FA34
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

		// Token: 0x0602B61D RID: 177693 RVA: 0x00C318BC File Offset: 0x00C2FABC
		protected override UniTask OnBeforeStartAsync()
		{
			RogueResSkillOverView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueResSkillOverView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602B61E RID: 177694 RVA: 0x00C318FF File Offset: 0x00C2FAFF
		protected override void OnBeforeDestroy()
		{
			this.SkillDescItemList.Clear();
		}

		// Token: 0x0602B61F RID: 177695 RVA: 0x00C3190C File Offset: 0x00C2FB0C
		protected UniTask InitDescItem()
		{
			RogueResSkillOverView.<InitDescItem>d__7 <InitDescItem>d__;
			<InitDescItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitDescItem>d__.<>4__this = this;
			<InitDescItem>d__.<>1__state = -1;
			<InitDescItem>d__.<>t__builder.Start<RogueResSkillOverView.<InitDescItem>d__7>(ref <InitDescItem>d__);
			return <InitDescItem>d__.<>t__builder.Task;
		}

		// Token: 0x040176E7 RID: 95975
		[Nullable(2)]
		public PopupCaptionItem CaptionItem;

		// Token: 0x040176E8 RID: 95976
		public List<RogueResSkillDesc> SkillDescItemList = new List<RogueResSkillDesc>();

		// Token: 0x040176E9 RID: 95977
		private int SeasonId;
	}
}
