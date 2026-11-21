using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x02004608 RID: 17928
	[NullableContext(1)]
	[Nullable(0)]
	public class PopupComponentInfoList : UiPanelBase
	{
		// Token: 0x0602D0E3 RID: 184547 RVA: 0x00C98E60 File Offset: 0x00C97060
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x0602D0E4 RID: 184548 RVA: 0x00C98EBA File Offset: 0x00C970BA
		protected override void OnStart()
		{
			this.ItemLayout = new GenericLayout<InfoItem, IItemInfoData>(base.GetVerticalLayout(1), new Func<InfoItem>(this.OnCreateInfoItem), null, false, true);
		}

		// Token: 0x0602D0E5 RID: 184549 RVA: 0x00C98EDD File Offset: 0x00C970DD
		public void SetTextByTextId(string textId, params string[] args)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textId, args);
		}

		// Token: 0x0602D0E6 RID: 184550 RVA: 0x00C98EF4 File Offset: 0x00C970F4
		public void Refresh(MapGridData gridData)
		{
			if (gridData.OccupiedEffectIdList.Count == 0)
			{
				this.SetActive(false);
				return;
			}
			bool isExplore = gridData.IsExplore;
			string textId = isExplore ? "RogueRes_Block_Captured_Buff" : "RogueRes_Block_Capture_Buff";
			this.SetTextByTextId(textId, Array.Empty<string>());
			List<IItemInfoData> list = new List<IItemInfoData>();
			foreach (int id in gridData.OccupiedEffectIdList)
			{
				RogueResEffect? rogueEffectById = MapRogueConfig.Instance.GetRogueEffectById(id);
				if (rogueEffectById != null)
				{
					RogueResEffectTag? rogueEffectTagById = MapRogueConfig.Instance.GetRogueEffectTagById(rogueEffectById.Value.Tag);
					if (rogueEffectTagById != null)
					{
						string text;
						if (!rogueEffectTagById.Value.IsRatio)
						{
							text = rogueEffectById.Value.DescIntParam.ToString();
						}
						else
						{
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
							defaultInterpolatedStringHandler.AppendFormatted<int>(rogueEffectById.Value.DescIntParam);
							defaultInterpolatedStringHandler.AppendLiteral("%");
							text = defaultInterpolatedStringHandler.ToStringAndClear();
						}
						string value = text;
						ItemInfoData item = new ItemInfoData
						{
							TitleId = rogueEffectTagById.Value.Text,
							Value = value,
							ValueChangeColor = isExplore
						};
						list.Add(item);
					}
				}
			}
			this.ItemLayout.RefreshByData(list, null, false);
		}

		// Token: 0x0602D0E7 RID: 184551 RVA: 0x00C9906C File Offset: 0x00C9726C
		private InfoItem OnCreateInfoItem()
		{
			return new InfoItem();
		}

		// Token: 0x040182E8 RID: 99048
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericLayout<InfoItem, IItemInfoData> ItemLayout;
	}
}
