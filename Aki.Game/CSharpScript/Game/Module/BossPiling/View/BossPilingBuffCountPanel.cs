using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BossPiling.View
{
	// Token: 0x02005C13 RID: 23571
	public class BossPilingBuffCountPanel : UiPanelBase
	{
		// Token: 0x0603B904 RID: 243972 RVA: 0x00E342A0 File Offset: 0x00E324A0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603B905 RID: 243973 RVA: 0x00E3434B File Offset: 0x00E3254B
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		}

		// Token: 0x0603B906 RID: 243974 RVA: 0x00E34360 File Offset: 0x00E32560
		public void Refresh(int oldValue, int newValue, long buffId)
		{
			Buff value = ConfigBuffById.GetConfig(buffId, true).Value;
			UUIText text = base.GetText(3);
			if (text != null)
			{
				text.SetUIActive(newValue < value.StackLimitCount);
			}
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(newValue < value.StackLimitCount);
			}
			if (newValue >= value.StackLimitCount)
			{
				UUIText text2 = base.GetText(1);
				if (text2 == null)
				{
					return;
				}
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 1);
				defaultInterpolatedStringHandler.AppendFormatted<int>(newValue);
				defaultInterpolatedStringHandler.AppendLiteral(" (MAX)");
				text2.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
				return;
			}
			else
			{
				UUIText text3 = base.GetText(1);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
				if (text3 != null)
				{
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
					defaultInterpolatedStringHandler.AppendFormatted<int>(oldValue);
					text3.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
				}
				UUIText text4 = base.GetText(3);
				if (text4 == null)
				{
					return;
				}
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
				defaultInterpolatedStringHandler.AppendFormatted<int>(newValue);
				text4.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
				return;
			}
		}

		// Token: 0x0603B907 RID: 243975 RVA: 0x00E3444B File Offset: 0x00E3264B
		public void PlaySequence(float rate)
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlayLevelSequenceByName("Start", false, new float?(rate), false);
		}

		// Token: 0x0401F03E RID: 127038
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200BDF7 RID: 48631
		private enum ECount
		{
			// Token: 0x04039476 RID: 234614
			Title,
			// Token: 0x04039477 RID: 234615
			TxtOld,
			// Token: 0x04039478 RID: 234616
			PanelArrow,
			// Token: 0x04039479 RID: 234617
			TxtNew
		}
	}
}
