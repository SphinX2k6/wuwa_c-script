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
	// Token: 0x02004024 RID: 16420
	public class PlotLogoView : UiViewBase
	{
		// Token: 0x060298DE RID: 170206 RVA: 0x00BBBA2C File Offset: 0x00BB9C2C
		[NullableContext(1)]
		public PlotLogoView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060298DF RID: 170207 RVA: 0x00BBBA38 File Offset: 0x00BB9C38
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

		// Token: 0x060298E0 RID: 170208 RVA: 0x00BBBA80 File Offset: 0x00BB9C80
		protected override UniTask OnCreateAsync()
		{
			PlotLogoView.<OnCreateAsync>d__4 <OnCreateAsync>d__;
			<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnCreateAsync>d__.<>4__this = this;
			<OnCreateAsync>d__.<>1__state = -1;
			<OnCreateAsync>d__.<>t__builder.Start<PlotLogoView.<OnCreateAsync>d__4>(ref <OnCreateAsync>d__);
			return <OnCreateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060298E1 RID: 170209 RVA: 0x00BBBAC3 File Offset: 0x00BB9CC3
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

		// Token: 0x04016ADC RID: 92892
		[Nullable(2)]
		private UTexture Texture;

		// Token: 0x02009BE8 RID: 39912
		private static class EChildComp
		{
			// Token: 0x04030883 RID: 198787
			public const int Logo = 0;
		}
	}
}
