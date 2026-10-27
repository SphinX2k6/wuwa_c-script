using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.UnderseaExperimentField
{
	// Token: 0x020047E5 RID: 18405
	public class UnderseaOverviewItem : UiPanelBase
	{
		// Token: 0x06030359 RID: 197465 RVA: 0x00B2C948 File Offset: 0x00B2AB48
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickBtnMapShow));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603035A RID: 197466 RVA: 0x00B2C9EE File Offset: 0x00B2ABEE
		private void OnClickBtnMapShow(EToggleState toggleState)
		{
			this.ShowMap = !this.ShowMap;
			LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.CustomizedThumbnailShow, this.ShowMap);
			UUIItem item = base.GetItem(1);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(this.ShowMap);
		}

		// Token: 0x0603035B RID: 197467 RVA: 0x00B2CA28 File Offset: 0x00B2AC28
		[NullableContext(1)]
		public UniTask Initialize(UUIItem uiItem, Action<int> checkedCallback)
		{
			UnderseaOverviewItem.<Initialize>d__5 <Initialize>d__;
			<Initialize>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Initialize>d__.<>4__this = this;
			<Initialize>d__.uiItem = uiItem;
			<Initialize>d__.checkedCallback = checkedCallback;
			<Initialize>d__.<>1__state = -1;
			<Initialize>d__.<>t__builder.Start<UnderseaOverviewItem.<Initialize>d__5>(ref <Initialize>d__);
			return <Initialize>d__.<>t__builder.Task;
		}

		// Token: 0x04019F5D RID: 106333
		private bool ShowMap;

		// Token: 0x04019F5E RID: 106334
		[Nullable(2)]
		private UnderseaExperimentFieldPanel UnderseaOverviewPanel;

		// Token: 0x0200AAA5 RID: 43685
		public static class EComponents
		{
			// Token: 0x04033EA0 RID: 212640
			public const int BtnMapShow = 0;

			// Token: 0x04033EA1 RID: 212641
			public const int MapLayout = 1;
		}
	}
}
