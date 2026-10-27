using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Components
{
	// Token: 0x0200554A RID: 21834
	[NullableContext(2)]
	[Nullable(0)]
	public class MarkRangeImageComponent : MarkPanelBase
	{
		// Token: 0x06037B74 RID: 228212 RVA: 0x00D38548 File Offset: 0x00D36748
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06037B75 RID: 228213 RVA: 0x00D385D4 File Offset: 0x00D367D4
		protected override UniTask OnBeforeStartAsync()
		{
			MarkRangeImageComponent.<OnBeforeStartAsync>d__2 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MarkRangeImageComponent.<OnBeforeStartAsync>d__2>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037B76 RID: 228214 RVA: 0x00D38617 File Offset: 0x00D36817
		protected override void OnStart()
		{
			this.RootItem.SetAnchorOffset(Vector2D.ZeroVector);
			this.RootItem.SetUIItemScale(Vector.OneVector);
			this.RangeSprite.SetUIActive(true);
			this.RangeImage.SetUIActive(false);
		}

		// Token: 0x170085C7 RID: 34247
		// (get) Token: 0x06037B77 RID: 228215 RVA: 0x00D38651 File Offset: 0x00D36851
		public UUITexture RangeImage
		{
			get
			{
				return base.GetTexture(0);
			}
		}

		// Token: 0x170085C8 RID: 34248
		// (get) Token: 0x06037B78 RID: 228216 RVA: 0x00D3865A File Offset: 0x00D3685A
		public UUIItem RangeArea
		{
			get
			{
				return base.GetItem(1);
			}
		}

		// Token: 0x170085C9 RID: 34249
		// (get) Token: 0x06037B79 RID: 228217 RVA: 0x00D38663 File Offset: 0x00D36863
		public UUISprite RangeSprite
		{
			get
			{
				return base.GetSprite(2);
			}
		}

		// Token: 0x0200B775 RID: 46965
		[NullableContext(0)]
		public static class EChildComponents
		{
			// Token: 0x040378A6 RID: 227494
			public const int RangeImage = 0;

			// Token: 0x040378A7 RID: 227495
			public const int RangeArea = 1;

			// Token: 0x040378A8 RID: 227496
			public const int RangeAreaSprite = 2;
		}
	}
}
