using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Kurotato.Data;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.KurotatoLevelSelect
{
	// Token: 0x02005755 RID: 22357
	public class KurotatoEndlessHistoryPanel : UiPanelBase
	{
		// Token: 0x06038D14 RID: 232724 RVA: 0x00D7E858 File Offset: 0x00D7CA58
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
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
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038D15 RID: 232725 RVA: 0x00D7E968 File Offset: 0x00D7CB68
		[NullableContext(1)]
		public void Refresh(KurotatoLevelData levelData)
		{
			bool hasHistory = levelData.HasHistory;
			UUIItem item = base.GetItem(5);
			if (item != null)
			{
				item.SetUIActive(hasHistory);
			}
			UUIItem item2 = base.GetItem(6);
			if (item2 != null)
			{
				item2.SetUIActive(!hasHistory);
			}
			if (!hasHistory)
			{
				return;
			}
			UUIText text = base.GetText(0);
			if (text != null)
			{
				text.SetText(levelData.HistoryKillNum.ToString(), true);
			}
			UUIText text2 = base.GetText(1);
			if (text2 != null)
			{
				text2.SetText(levelData.HistoryWave.ToString(), true);
			}
			KurotatoRoleData kurotatoRoleData = KurotatoActivityController.Instance.GetActivityData().GetKurotatoRoleData(levelData.HistoryRoleId);
			base.SetTextureByPath(SkinConfig.Instance.GetRoleSkinConfig(kurotatoRoleData.RealRoleSkinId).Value.RoleHeadIconLarge, base.GetTexture(2), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), kurotatoRoleData.Name, Array.Empty<object>());
			foreach (KurotatoWaveLevel kurotatoWaveLevel in KurotatoConfig.Instance.GetWaveLevelConfigList())
			{
				if (kurotatoWaveLevel.WaveRangeIter().ToList<int>()[0] <= levelData.HistoryWave && levelData.HistoryWave <= kurotatoWaveLevel.WaveRangeIter().ToList<int>()[1])
				{
					base.SetTextureByPath(kurotatoWaveLevel.Icon, base.GetTexture(4), null, null);
					break;
				}
			}
		}

		// Token: 0x0200B94D RID: 47437
		private enum EComponent
		{
			// Token: 0x040380A6 RID: 229542
			TxtKillNum,
			// Token: 0x040380A7 RID: 229543
			TxtWave,
			// Token: 0x040380A8 RID: 229544
			TexRole,
			// Token: 0x040380A9 RID: 229545
			TxtName,
			// Token: 0x040380AA RID: 229546
			TexPoint,
			// Token: 0x040380AB RID: 229547
			ItemInfoPanel,
			// Token: 0x040380AC RID: 229548
			ItemEmptyPanel
		}
	}
}
