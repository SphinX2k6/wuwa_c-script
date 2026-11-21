using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A95 RID: 14997
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TrapDefenseResultInfoItem : GridProxyAbstract<ITrapDefensePauseInfo>
	{
		// Token: 0x06026883 RID: 157827 RVA: 0x00ACCAEC File Offset: 0x00ACACEC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06026884 RID: 157828 RVA: 0x00ACCB98 File Offset: 0x00ACAD98
		public override void Refresh(ITrapDefensePauseInfo data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			ETrapDefensePauseInfoType type = data.Type;
			if (type == ETrapDefensePauseInfoType.Health)
			{
				string resourcePath = UiResourceConfig.Instance.GetResourcePath("TrapDefenseResultHealth");
				this.SetSpriteByPath(resourcePath, base.GetSprite(0), false, null, null);
				UUISprite sprite = base.GetSprite(3);
				if (sprite != null)
				{
					sprite.SetUIActive(true);
				}
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "TowerDefense_HomeHp_Text", Array.Empty<object>());
				int? num = data.Value;
				long value = (num != null) ? ((long)num.GetValueOrDefault()) : TrapDefenseModel.Instance.BattleData.GetHealth();
				UUIText text = base.GetText(2);
				if (text == null)
				{
					return;
				}
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
				defaultInterpolatedStringHandler.AppendFormatted<long>(value);
				text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
				return;
			}
			else
			{
				string resourcePath2 = UiResourceConfig.Instance.GetResourcePath("TrapDefenseResultBatch");
				this.SetSpriteByPath(resourcePath2, base.GetSprite(0), false, null, null);
				UUISprite sprite2 = base.GetSprite(3);
				if (sprite2 != null)
				{
					sprite2.SetUIActive(false);
				}
				int num2 = data.Value ?? TrapDefenseModel.Instance.BattleData.GetBatch();
				string textStringId = (type == ETrapDefensePauseInfoType.BatchCur) ? "TowerDefense_WaveCurCount_Text" : "TowerDefense_WaveCount_Text";
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textStringId, Array.Empty<object>());
				if (TrapDefenseModel.Instance.GetCurInstToLevelData().Config.ModeType != 3)
				{
					int? num = data.MaxBatch;
					long num3 = (num != null) ? ((long)num.GetValueOrDefault()) : TrapDefenseModel.Instance.BattleData.GetMaxBatch();
					LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "TowerDefense_ESC_WaveCountNum_Text", new <>z__ReadOnlyArray<object>(new object[]
					{
						num2,
						num3
					}));
					return;
				}
				UUIText text2 = base.GetText(2);
				if (text2 == null)
				{
					return;
				}
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
				defaultInterpolatedStringHandler.AppendFormatted<int>(num2);
				text2.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
				return;
			}
		}

		// Token: 0x040151DB RID: 86491
		protected ITrapDefensePauseInfo Data;

		// Token: 0x020096A0 RID: 38560
		[NullableContext(0)]
		internal class EItem
		{
			// Token: 0x0402F073 RID: 192627
			public const int Icon = 0;

			// Token: 0x0402F074 RID: 192628
			public const int Title = 1;

			// Token: 0x0402F075 RID: 192629
			public const int Value = 2;

			// Token: 0x0402F076 RID: 192630
			public const int Split = 3;
		}
	}
}
