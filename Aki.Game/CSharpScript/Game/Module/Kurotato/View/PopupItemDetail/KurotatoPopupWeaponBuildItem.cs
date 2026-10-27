using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.PopupItemDetail
{
	// Token: 0x02005738 RID: 22328
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class KurotatoPopupWeaponBuildItem : GridProxyAbstract<IKurotatoWeaponBuildInfoPanel>
	{
		// Token: 0x06038C48 RID: 232520 RVA: 0x00D7A4B4 File Offset: 0x00D786B4
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

		// Token: 0x06038C49 RID: 232521 RVA: 0x00D7A53E File Offset: 0x00D7873E
		protected override void OnStart()
		{
			this.BuildInfoLayout = new GenericLayout<InfoItem, IInfoItemData>(base.GetVerticalLayout(1), () => new InfoItem(), null, false, true);
		}

		// Token: 0x06038C4A RID: 232522 RVA: 0x00D7A574 File Offset: 0x00D78774
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

		// Token: 0x0401DC7C RID: 121980
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<InfoItem, IInfoItemData> BuildInfoLayout;

		// Token: 0x0200B919 RID: 47385
		private enum EChildComp
		{
			// Token: 0x04037FB7 RID: 229303
			TextName,
			// Token: 0x04037FB8 RID: 229304
			PanelVerticalLayout,
			// Token: 0x04037FB9 RID: 229305
			TextDesc
		}
	}
}
