using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x02005632 RID: 22066
	[NullableContext(1)]
	[Nullable(0)]
	public class PopupComponentInfoList : UiPanelBase
	{
		// Token: 0x060381E5 RID: 229861 RVA: 0x00D4B118 File Offset: 0x00D49318
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x060381E6 RID: 229862 RVA: 0x00D4B172 File Offset: 0x00D49372
		protected override void OnStart()
		{
			this.ItemLayout = new GenericLayout<InfoItem, IItemInfoData>(base.GetVerticalLayout(1), new Func<InfoItem>(this.OnCreateInfoItem), null, false, true);
		}

		// Token: 0x060381E7 RID: 229863 RVA: 0x00D4B195 File Offset: 0x00D49395
		public void SetTextByTextId(string textId, params string[] args)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textId, args);
		}

		// Token: 0x060381E8 RID: 229864 RVA: 0x00D4B1AC File Offset: 0x00D493AC
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

		// Token: 0x060381E9 RID: 229865 RVA: 0x00D4B324 File Offset: 0x00D49524
		private InfoItem OnCreateInfoItem()
		{
			return new InfoItem();
		}

		// Token: 0x0401D85D RID: 120925
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericLayout<InfoItem, IItemInfoData> ItemLayout;
	}
}
