using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Components
{
	// Token: 0x02005544 RID: 21828
	public class MarkDetectorRangeImageComponent : MarkPanelBase
	{
		// Token: 0x06037B47 RID: 228167 RVA: 0x00D38094 File Offset: 0x00D36294
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

		// Token: 0x06037B48 RID: 228168 RVA: 0x00D380DC File Offset: 0x00D362DC
		protected override UniTask OnBeforeStartAsync()
		{
			MarkDetectorRangeImageComponent.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MarkDetectorRangeImageComponent.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037B49 RID: 228169 RVA: 0x00D3811F File Offset: 0x00D3631F
		protected override void OnStart()
		{
			this.RootItem.SetAnchorOffset(Vector2D.ZeroVector);
			this.RootItem.SetUIItemScale(Vector.OneVector);
		}

		// Token: 0x06037B4A RID: 228170 RVA: 0x00D38144 File Offset: 0x00D36344
		protected override void OnBeforeShow()
		{
			UUIItem rootItem = base.GetRootItem();
			if (ObjectUtils.IsValid(rootItem))
			{
				rootItem.D_SetRelativeScale3D(this.TempRangeScale);
			}
		}

		// Token: 0x170085BB RID: 34235
		// (get) Token: 0x06037B4B RID: 228171 RVA: 0x00D3816C File Offset: 0x00D3636C
		[Nullable(2)]
		public UUITexture RangeImage
		{
			[NullableContext(2)]
			get
			{
				return base.GetTexture(0);
			}
		}

		// Token: 0x06037B4C RID: 228172 RVA: 0x00D38178 File Offset: 0x00D36378
		public void SetRangeScale(double x, double y, double z)
		{
			this.TempRangeScale.Set(x, y, z);
			if (base.IsShowOrShowing)
			{
				UUIItem rootItem = base.GetRootItem();
				if (ObjectUtils.IsValid(rootItem))
				{
					rootItem.D_SetRelativeScale3D(this.TempRangeScale);
				}
			}
		}

		// Token: 0x0401D441 RID: 119873
		private FVectorDouble TempRangeScale = new FVectorDouble();

		// Token: 0x0200B770 RID: 46960
		public static class EChildComponents
		{
			// Token: 0x0403789E RID: 227486
			public const int RangeImage = 0;
		}
	}
}
