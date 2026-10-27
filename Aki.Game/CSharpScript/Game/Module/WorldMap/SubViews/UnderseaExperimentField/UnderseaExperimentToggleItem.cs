using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Area;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.UnderseaExperimentField
{
	// Token: 0x020047E4 RID: 18404
	public class UnderseaExperimentToggleItem : UiPanelBase
	{
		// Token: 0x06030355 RID: 197461 RVA: 0x00B2C7FC File Offset: 0x00B2A9FC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06030356 RID: 197462 RVA: 0x00B2C868 File Offset: 0x00B2AA68
		[NullableContext(1)]
		public UniTask Initialize(EDeepSeaMapId deepSeaMapId, UUIExtendToggle uiRoot)
		{
			UnderseaExperimentToggleItem.<Initialize>d__3 <Initialize>d__;
			<Initialize>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Initialize>d__.<>4__this = this;
			<Initialize>d__.deepSeaMapId = deepSeaMapId;
			<Initialize>d__.uiRoot = uiRoot;
			<Initialize>d__.<>1__state = -1;
			<Initialize>d__.<>t__builder.Start<UnderseaExperimentToggleItem.<Initialize>d__3>(ref <Initialize>d__);
			return <Initialize>d__.<>t__builder.Task;
		}

		// Token: 0x06030357 RID: 197463 RVA: 0x00B2C8BC File Offset: 0x00B2AABC
		public void RefreshPlayerIcon()
		{
			CustomizedThumbnail? customizedThumbnailConfig = WorldMapConfig.Instance.GetCustomizedThumbnailConfig(this.DeepSeaMapId);
			int currentAreaId = AreaModel.Instance.GetCurrentAreaId(new EAreaLevel?(EAreaLevel.FirstLevel));
			int? num = (customizedThumbnailConfig != null) ? new int?(customizedThumbnailConfig.GetValueOrDefault().AreaId) : null;
			bool uiactive = currentAreaId == num.GetValueOrDefault() & num != null;
			UUIItem item = base.GetItem(1);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(uiactive);
		}

		// Token: 0x04019F5C RID: 106332
		private EDeepSeaMapId DeepSeaMapId = EDeepSeaMapId.Graveyard;

		// Token: 0x0200AAA3 RID: 43683
		public static class EComponents
		{
			// Token: 0x04033E98 RID: 212632
			public const int Cursor = 0;

			// Token: 0x04033E99 RID: 212633
			public const int PlayerIcon = 1;
		}
	}
}
