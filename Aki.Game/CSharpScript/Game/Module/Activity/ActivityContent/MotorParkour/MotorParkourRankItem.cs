using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorParkour
{
	// Token: 0x020063F4 RID: 25588
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MotorParkourRankItem : GridProxyAbstract<MotorParkourRankData>
	{
		// Token: 0x060405B8 RID: 263608 RVA: 0x00F9121C File Offset: 0x00F8F41C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060405B9 RID: 263609 RVA: 0x00F912C8 File Offset: 0x00F8F4C8
		[NullableContext(1)]
		public override void Refresh(MotorParkourRankData data, bool isSelected, int gridIndex)
		{
			int id = gridIndex + 1;
			MotorParkourRank? motorParkourRankById = MotorParkourConfig.Instance.GetMotorParkourRankById(id);
			this.SetSpriteByPath(motorParkourRankById.Value.SpriteNum, base.GetSprite(0), false, null, null);
			this.SetSpriteByPath(motorParkourRankById.Value.SpriteBg, base.GetSprite(1), false, null, null);
			string remainTimeDataFormat = TimeUtil.Instance.GetRemainTimeDataFormat5((double)data.Time * TimeUtil.Instance.Millisecond);
			UUIText text = base.GetText(3);
			if (text != null)
			{
				text.SetText(remainTimeDataFormat, true);
			}
			if (!data.IsOwn)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(2), data.Name, Array.Empty<object>());
				return;
			}
			string playerName = FunctionModel.Instance.GetPlayerName();
			UUIText text2 = base.GetText(2);
			if (text2 == null)
			{
				return;
			}
			text2.SetText(playerName, true);
		}

		// Token: 0x0200C610 RID: 50704
		private class EComponents
		{
			// Token: 0x0403BCC2 RID: 244930
			public const int SpriteRankNum = 0;

			// Token: 0x0403BCC3 RID: 244931
			public const int SpriteRankBg = 1;

			// Token: 0x0403BCC4 RID: 244932
			public const int TextName = 2;

			// Token: 0x0403BCC5 RID: 244933
			public const int TextTime = 3;
		}
	}
}
