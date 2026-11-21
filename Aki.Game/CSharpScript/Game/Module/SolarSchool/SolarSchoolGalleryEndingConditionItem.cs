using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A20 RID: 23072
	public class SolarSchoolGalleryEndingConditionItem : GridProxyAbstract<int>
	{
		// Token: 0x06038D26 RID: 232742 RVA: 0x00FE7EB8 File Offset: 0x00FE60B8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038D27 RID: 232743 RVA: 0x00FE7FA8 File Offset: 0x00FE61A8
		public override void Refresh(int conditionId, bool isSelected, int gridIndex)
		{
			this.ConditionConfig = ConfigActivityConditionById.GetConfig(conditionId, true);
			if (this.ConditionConfig == null)
			{
				return;
			}
			bool flag = this.ConditionConfig.Value.Type == 1;
			if (flag)
			{
				this.SetAttrTypeView();
			}
			else
			{
				LguiUtil.Instance.TrySetLocalTextNew(base.GetText(5), this.ConditionConfig.Value.Description, Array.Empty<object>());
			}
			base.GetItem(3).SetUIActive(flag);
			base.GetItem(4).SetUIActive(!flag);
		}

		// Token: 0x06038D28 RID: 232744 RVA: 0x00FE8038 File Offset: 0x00FE6238
		private void SetAttrTypeView()
		{
			int id = 0;
			int num = 0;
			int paramsLength = this.ConditionConfig.Value.ParamsLength;
			for (int i = 0; i < paramsLength; i++)
			{
				DicStringString? dicStringString = this.ConditionConfig.Value.Params(i);
				if (dicStringString != null)
				{
					string key = dicStringString.Value.Key;
					if (!string.IsNullOrEmpty(key))
					{
						string s = dicStringString.Value.Value ?? string.Empty;
						if (key == "Attr")
						{
							int.TryParse(s, out id);
						}
						else if (key == "Min")
						{
							int.TryParse(s, out num);
						}
					}
				}
			}
			SolarSchoolAttr? attr = SolarSchoolConfig.Instance.GetAttr(id);
			if (attr == null)
			{
				return;
			}
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(0), attr.Value.Name, Array.Empty<object>());
			base.GetText(1).SetText(num.ToString(), true);
			base.SetTextureByPath(attr.Value.YellowIconSmall, base.GetTexture(2), null, null);
		}

		// Token: 0x0401DE81 RID: 122497
		[Nullable(2)]
		private SolarSchoolGalleryData Data;

		// Token: 0x0401DE82 RID: 122498
		private ActivityCondition? ConditionConfig;

		// Token: 0x0200B5E8 RID: 46568
		private class EComponents
		{
			// Token: 0x0403840C RID: 230412
			public const int NameText = 0;

			// Token: 0x0403840D RID: 230413
			public const int ValueText = 1;

			// Token: 0x0403840E RID: 230414
			public const int AttrIcon = 2;

			// Token: 0x0403840F RID: 230415
			public const int AttrItem = 3;

			// Token: 0x04038410 RID: 230416
			public const int TextItem = 4;

			// Token: 0x04038411 RID: 230417
			public const int DescText = 5;
		}
	}
}
