using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View
{
	// Token: 0x02005250 RID: 21072
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballLoadingTexView : UiPanelBase, ILoopAutoScrollItem<string>
	{
		// Token: 0x0603475F RID: 214879 RVA: 0x00EAE360 File Offset: 0x00EAC560
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06034760 RID: 214880 RVA: 0x00EAE3A8 File Offset: 0x00EAC5A8
		public void Refresh(string data)
		{
			base.TrySetTextureByPath(data, base.GetTexture(0), new EUiViewName?(EUiViewName.PinballLoadingView), null);
		}

		// Token: 0x06034761 RID: 214881 RVA: 0x00EAE3C4 File Offset: 0x00EAC5C4
		UniTask ILoopAutoScrollItem<string>.CreateByActorAsync(AActor actor)
		{
			PinballLoadingTexView.<CSharpScript-Game-Module-Util-ILoopAutoScrollItem<System-String>-CreateByActorAsync>d__3 <CSharpScript-Game-Module-Util-ILoopAutoScrollItem<System-String>-CreateByActorAsync>d__;
			<CSharpScript-Game-Module-Util-ILoopAutoScrollItem<System-String>-CreateByActorAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CSharpScript-Game-Module-Util-ILoopAutoScrollItem<System-String>-CreateByActorAsync>d__.<>4__this = this;
			<CSharpScript-Game-Module-Util-ILoopAutoScrollItem<System-String>-CreateByActorAsync>d__.actor = actor;
			<CSharpScript-Game-Module-Util-ILoopAutoScrollItem<System-String>-CreateByActorAsync>d__.<>1__state = -1;
			<CSharpScript-Game-Module-Util-ILoopAutoScrollItem<System-String>-CreateByActorAsync>d__.<>t__builder.Start<PinballLoadingTexView.<CSharpScript-Game-Module-Util-ILoopAutoScrollItem<System-String>-CreateByActorAsync>d__3>(ref <CSharpScript-Game-Module-Util-ILoopAutoScrollItem<System-String>-CreateByActorAsync>d__);
			return <CSharpScript-Game-Module-Util-ILoopAutoScrollItem<System-String>-CreateByActorAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034762 RID: 214882 RVA: 0x00EAE40F File Offset: 0x00EAC60F
		public new UUIItem GetRootItem()
		{
			return this.RootItem;
		}

		// Token: 0x0200AEA2 RID: 44706
		[NullableContext(0)]
		private enum EItemComponent
		{
			// Token: 0x04035F35 RID: 220981
			Tex
		}
	}
}
