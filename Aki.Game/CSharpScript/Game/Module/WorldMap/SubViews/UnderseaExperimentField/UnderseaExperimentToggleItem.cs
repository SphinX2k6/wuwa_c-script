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
	// Token: 0x02003715 RID: 14101
	public class UnderseaExperimentToggleItem : UiPanelBase
	{
		// Token: 0x06024B25 RID: 150309 RVA: 0x00A5C740 File Offset: 0x00A5A940
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

		// Token: 0x06024B26 RID: 150310 RVA: 0x00A5C7AC File Offset: 0x00A5A9AC
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

		// Token: 0x06024B27 RID: 150311 RVA: 0x00A5C800 File Offset: 0x00A5AA00
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

		// Token: 0x04014610 RID: 83472
		private EDeepSeaMapId DeepSeaMapId = EDeepSeaMapId.Graveyard;

		// Token: 0x02009455 RID: 37973
		public static class EComponents
		{
			// Token: 0x0402E61E RID: 189982
			public const int Cursor = 0;

			// Token: 0x0402E61F RID: 189983
			public const int PlayerIcon = 1;
		}
	}
}
