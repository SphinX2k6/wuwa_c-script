using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Components
{
	// Token: 0x02004516 RID: 17686
	public class MarkDetectorRangeImageComponent : MarkPanelBase
	{
		// Token: 0x0602CA16 RID: 182806 RVA: 0x00C85B68 File Offset: 0x00C83D68
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

		// Token: 0x0602CA17 RID: 182807 RVA: 0x00C85BB0 File Offset: 0x00C83DB0
		protected override UniTask OnBeforeStartAsync()
		{
			MarkDetectorRangeImageComponent.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MarkDetectorRangeImageComponent.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602CA18 RID: 182808 RVA: 0x00C85BF3 File Offset: 0x00C83DF3
		protected override void OnStart()
		{
			this.RootItem.SetAnchorOffset(Vector2D.ZeroVector);
			this.RootItem.SetUIItemScale(Vector.OneVector);
		}

		// Token: 0x0602CA19 RID: 182809 RVA: 0x00C85C18 File Offset: 0x00C83E18
		protected override void OnBeforeShow()
		{
			UUIItem rootItem = base.GetRootItem();
			if (ObjectUtils.IsValid(rootItem))
			{
				rootItem.D_SetRelativeScale3D(this.TempRangeScale);
			}
		}

		// Token: 0x1700595B RID: 22875
		// (get) Token: 0x0602CA1A RID: 182810 RVA: 0x00C85C40 File Offset: 0x00C83E40
		[Nullable(2)]
		public UUITexture RangeImage
		{
			[NullableContext(2)]
			get
			{
				return base.GetTexture(0);
			}
		}

		// Token: 0x0602CA1B RID: 182811 RVA: 0x00C85C4C File Offset: 0x00C83E4C
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

		// Token: 0x04017EC7 RID: 97991
		private FVectorDouble TempRangeScale = new FVectorDouble();

		// Token: 0x0200A19B RID: 41371
		public static class EChildComponents
		{
			// Token: 0x040322C9 RID: 205513
			public const int RangeImage = 0;
		}
	}
}
