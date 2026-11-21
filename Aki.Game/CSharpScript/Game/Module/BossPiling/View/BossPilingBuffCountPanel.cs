using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BossPiling.View
{
	// Token: 0x02004BF3 RID: 19443
	public class BossPilingBuffCountPanel : UiPanelBase
	{
		// Token: 0x0603084F RID: 198735 RVA: 0x00D845E8 File Offset: 0x00D827E8
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

		// Token: 0x06030850 RID: 198736 RVA: 0x00D84693 File Offset: 0x00D82893
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		}

		// Token: 0x06030851 RID: 198737 RVA: 0x00D846A8 File Offset: 0x00D828A8
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

		// Token: 0x06030852 RID: 198738 RVA: 0x00D84793 File Offset: 0x00D82993
		public void PlaySequence(float rate)
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlayLevelSequenceByName("Start", false, new float?(rate), false);
		}

		// Token: 0x04019AEF RID: 105199
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200A7FF RID: 43007
		private enum ECount
		{
			// Token: 0x04033E39 RID: 212537
			Title,
			// Token: 0x04033E3A RID: 212538
			TxtOld,
			// Token: 0x04033E3B RID: 212539
			PanelArrow,
			// Token: 0x04033E3C RID: 212540
			TxtNew
		}
	}
}
