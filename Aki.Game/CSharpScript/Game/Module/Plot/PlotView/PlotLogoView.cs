using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x02005054 RID: 20564
	public class PlotLogoView : UiViewBase
	{
		// Token: 0x060349EB RID: 215531 RVA: 0x00C6E78C File Offset: 0x00C6C98C
		[NullableContext(1)]
		public PlotLogoView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060349EC RID: 215532 RVA: 0x00C6E798 File Offset: 0x00C6C998
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

		// Token: 0x060349ED RID: 215533 RVA: 0x00C6E7E0 File Offset: 0x00C6C9E0
		protected override UniTask OnCreateAsync()
		{
			PlotLogoView.<OnCreateAsync>d__4 <OnCreateAsync>d__;
			<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnCreateAsync>d__.<>4__this = this;
			<OnCreateAsync>d__.<>1__state = -1;
			<OnCreateAsync>d__.<>t__builder.Start<PlotLogoView.<OnCreateAsync>d__4>(ref <OnCreateAsync>d__);
			return <OnCreateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060349EE RID: 215534 RVA: 0x00C6E823 File Offset: 0x00C6CA23
		protected override void OnBeforeShow()
		{
			if (this.Texture != null)
			{
				UUITexture texture = base.GetTexture(0);
				if (texture == null)
				{
					return;
				}
				texture.SetTexture(this.Texture);
			}
		}

		// Token: 0x0401C0B1 RID: 114865
		[Nullable(2)]
		private UTexture Texture;

		// Token: 0x0200B1AE RID: 45486
		private static class EChildComp
		{
			// Token: 0x04035E2E RID: 220718
			public const int Logo = 0;
		}
	}
}
