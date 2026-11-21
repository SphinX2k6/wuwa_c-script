using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A63 RID: 23139
	public class SolarSchoolSummaryAttributeItem : UiPanelBase
	{
		// Token: 0x0603900C RID: 233484 RVA: 0x00FF76F8 File Offset: 0x00FF58F8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603900D RID: 233485 RVA: 0x00FF77A3 File Offset: 0x00FF59A3
		protected override void OnStart()
		{
			if (this.LevelSequencePlayer == null)
			{
				this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			}
		}

		// Token: 0x0603900E RID: 233486 RVA: 0x00FF77C0 File Offset: 0x00FF59C0
		public void RefreshAttr(ValueTuple<ESolarSchoolSecondAttr, int> data)
		{
			ESolarSchoolSecondAttr item = data.Item1;
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			SolarSchoolAttr? solarSchoolAttr = SolarSchoolConfig.Instance.TryGetAttrByType(instance.ActivityId, (int)item);
			if (solarSchoolAttr == null)
			{
				return;
			}
			SolarSchoolAttr value = solarSchoolAttr.Value;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), value.Name, Array.Empty<object>());
			base.SetTextureByPath(value.YellowIconSmall, base.GetTexture(0), null, null);
			int item2 = data.Item2;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 1);
			defaultInterpolatedStringHandler.AppendLiteral("<color=#badbfd>");
			defaultInterpolatedStringHandler.AppendFormatted<int>(item2);
			defaultInterpolatedStringHandler.AppendLiteral("</color>");
			string newText = defaultInterpolatedStringHandler.ToStringAndClear();
			if (item2 != 0)
			{
				string str = StringUtils.Format((item2 > 0) ? "+{0}" : "-{0}", new string[]
				{
					Math.Abs(item2).ToString()
				});
				newText = ((item2 > 0) ? ("<color=#adef80>" + str + "</color>") : ("<color=#ff6e8d>" + str + "</color>"));
			}
			base.GetText(2).SetText(newText, true);
		}

		// Token: 0x0603900F RID: 233487 RVA: 0x00FF78E5 File Offset: 0x00FF5AE5
		public void SetTextVisible(bool isVisible)
		{
			base.GetText(2).SetUIActive(isVisible);
		}

		// Token: 0x06039010 RID: 233488 RVA: 0x00FF78F4 File Offset: 0x00FF5AF4
		public void TryPlayValueShowSequence()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlayOrReplaySequenceByName("ValueShow", false, null);
		}

		// Token: 0x06039011 RID: 233489 RVA: 0x00FF7920 File Offset: 0x00FF5B20
		public void Dispose()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.Clear();
			}
			this.LevelSequencePlayer = null;
		}

		// Token: 0x0401E005 RID: 122885
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200B651 RID: 46673
		private class EComponents
		{
			// Token: 0x04038663 RID: 231011
			public const int TexIcon = 0;

			// Token: 0x04038664 RID: 231012
			public const int TxtName = 1;

			// Token: 0x04038665 RID: 231013
			public const int TxtValue = 2;

			// Token: 0x04038666 RID: 231014
			public const int TexScore = 3;
		}
	}
}
