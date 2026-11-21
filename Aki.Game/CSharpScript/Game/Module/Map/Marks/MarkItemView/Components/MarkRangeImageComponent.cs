using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Components
{
	// Token: 0x0200451C RID: 17692
	[NullableContext(2)]
	[Nullable(0)]
	public class MarkRangeImageComponent : MarkPanelBase
	{
		// Token: 0x0602CA44 RID: 182852 RVA: 0x00C8601C File Offset: 0x00C8421C
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

		// Token: 0x0602CA45 RID: 182853 RVA: 0x00C860A8 File Offset: 0x00C842A8
		protected override UniTask OnBeforeStartAsync()
		{
			MarkRangeImageComponent.<OnBeforeStartAsync>d__2 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MarkRangeImageComponent.<OnBeforeStartAsync>d__2>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602CA46 RID: 182854 RVA: 0x00C860EB File Offset: 0x00C842EB
		protected override void OnStart()
		{
			this.RootItem.SetAnchorOffset(Vector2D.ZeroVector);
			this.RootItem.SetUIItemScale(Vector.OneVector);
			this.RangeSprite.SetUIActive(true);
			this.RangeImage.SetUIActive(false);
		}

		// Token: 0x17005967 RID: 22887
		// (get) Token: 0x0602CA47 RID: 182855 RVA: 0x00C86125 File Offset: 0x00C84325
		public UUITexture RangeImage
		{
			get
			{
				return base.GetTexture(0);
			}
		}

		// Token: 0x17005968 RID: 22888
		// (get) Token: 0x0602CA48 RID: 182856 RVA: 0x00C8612E File Offset: 0x00C8432E
		public UUIItem RangeArea
		{
			get
			{
				return base.GetItem(1);
			}
		}

		// Token: 0x17005969 RID: 22889
		// (get) Token: 0x0602CA49 RID: 182857 RVA: 0x00C86137 File Offset: 0x00C84337
		public UUISprite RangeSprite
		{
			get
			{
				return base.GetSprite(2);
			}
		}

		// Token: 0x0200A1A0 RID: 41376
		[NullableContext(0)]
		public static class EChildComponents
		{
			// Token: 0x040322D1 RID: 205521
			public const int RangeImage = 0;

			// Token: 0x040322D2 RID: 205522
			public const int RangeArea = 1;

			// Token: 0x040322D3 RID: 205523
			public const int RangeAreaSprite = 2;
		}
	}
}
