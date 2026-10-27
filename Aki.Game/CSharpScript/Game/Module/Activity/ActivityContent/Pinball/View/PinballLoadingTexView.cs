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
	// Token: 0x020062D2 RID: 25298
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballLoadingTexView : UiPanelBase, ILoopAutoScrollItem<string>
	{
		// Token: 0x0603FA9E RID: 260766 RVA: 0x00F67404 File Offset: 0x00F65604
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

		// Token: 0x0603FA9F RID: 260767 RVA: 0x00F6744C File Offset: 0x00F6564C
		public void Refresh(string data)
		{
			base.TrySetTextureByPath(data, base.GetTexture(0), new EUiViewName?(EUiViewName.PinballLoadingView), null);
		}

		// Token: 0x0603FAA0 RID: 260768 RVA: 0x00F67468 File Offset: 0x00F65668
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

		// Token: 0x0603FAA1 RID: 260769 RVA: 0x00F674B3 File Offset: 0x00F656B3
		public new UUIItem GetRootItem()
		{
			return this.RootItem;
		}

		// Token: 0x0200C4BB RID: 50363
		[NullableContext(0)]
		private enum EItemComponent
		{
			// Token: 0x0403B5D3 RID: 243155
			Tex
		}
	}
}
