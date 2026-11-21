using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.PopupItemDetail
{
	// Token: 0x0200470F RID: 18191
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class KurotatoPopupWeaponBuildItem : GridProxyAbstract<IKurotatoWeaponBuildInfoPanel>
	{
		// Token: 0x0602DB58 RID: 187224 RVA: 0x00CC8B64 File Offset: 0x00CC6D64
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602DB59 RID: 187225 RVA: 0x00CC8BEE File Offset: 0x00CC6DEE
		protected override void OnStart()
		{
			this.BuildInfoLayout = new GenericLayout<InfoItem, IInfoItemData>(base.GetVerticalLayout(1), () => new InfoItem(), null, false, true);
		}

		// Token: 0x0602DB5A RID: 187226 RVA: 0x00CC8C24 File Offset: 0x00CC6E24
		[NullableContext(1)]
		public override void Refresh(IKurotatoWeaponBuildInfoPanel data, bool isSelected, int gridIndex)
		{
			int weaponBuildLevelByBuildId = KurotatoModel.Instance.GetWeaponBuildLevelByBuildId(data.BuildId);
			KurotatoWeaponBuild value = KurotatoConfig.Instance.GetWeaponBuildById(data.BuildId).Value;
			base.GetText(0).ShowTextNew(value.Name);
			List<IReadOnlyList<int>> list = new List<IReadOnlyList<int>>
			{
				value.GetOneEffectsArray() ?? Array.Empty<int>(),
				value.GetTwoEffectsArray() ?? Array.Empty<int>(),
				value.GetThreeEffectArray() ?? Array.Empty<int>(),
				value.GetFourEffectArray() ?? Array.Empty<int>(),
				value.GetFiveEffectArray() ?? Array.Empty<int>(),
				value.GetSixEffectArray() ?? Array.Empty<int>()
			};
			List<IInfoItemData> list2 = new List<IInfoItemData>();
			for (int i = 0; i < list.Count; i++)
			{
				List<IKurotatoAttrDisplay> itemAttrDisplayList = KurotatoUtil.GetItemAttrDisplayList(list[i], true, true, false);
				List<string> list3 = new List<string>();
				foreach (IKurotatoAttrDisplay kurotatoAttrDisplay in itemAttrDisplayList)
				{
					list3.Add(kurotatoAttrDisplay.Text);
				}
				string description = string.Join(",", list3);
				InfoItemData infoItemData = new InfoItemData
				{
					Level = i + 1,
					Description = description,
					BuildLevel = weaponBuildLevelByBuildId,
					IsArrowLevel = false
				};
				if (!StringUtils.IsEmpty(infoItemData.Description))
				{
					list2.Add(infoItemData);
				}
			}
			int num = -1;
			for (int j = list2.Count - 1; j >= 0; j--)
			{
				if (list2[j].Level <= weaponBuildLevelByBuildId)
				{
					num = j;
					break;
				}
			}
			if (num >= 0)
			{
				list2[num].IsArrowLevel = true;
			}
			this.BuildInfoLayout.RefreshByData(list2, null, false);
		}

		// Token: 0x04018712 RID: 100114
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<InfoItem, IInfoItemData> BuildInfoLayout;

		// Token: 0x0200A33A RID: 41786
		private enum EChildComp
		{
			// Token: 0x040329C7 RID: 207303
			TextName,
			// Token: 0x040329C8 RID: 207304
			PanelVerticalLayout,
			// Token: 0x040329C9 RID: 207305
			TextDesc
		}
	}
}
