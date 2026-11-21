using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorParkour
{
	// Token: 0x02005372 RID: 21362
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MotorParkourRankItem : GridProxyAbstract<MotorParkourRankData>
	{
		// Token: 0x06035279 RID: 217721 RVA: 0x00ED8204 File Offset: 0x00ED6404
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

		// Token: 0x0603527A RID: 217722 RVA: 0x00ED82B0 File Offset: 0x00ED64B0
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

		// Token: 0x0200AFF7 RID: 45047
		private class EComponents
		{
			// Token: 0x04036621 RID: 222753
			public const int SpriteRankNum = 0;

			// Token: 0x04036622 RID: 222754
			public const int SpriteRankBg = 1;

			// Token: 0x04036623 RID: 222755
			public const int TextName = 2;

			// Token: 0x04036624 RID: 222756
			public const int TextTime = 3;
		}
	}
}
