using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorParkour
{
	// Token: 0x020063F1 RID: 25585
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MotorParkourGameRankItem : GridProxyAbstract<MotorParkourRankData>
	{
		// Token: 0x060405A4 RID: 263588 RVA: 0x00F90BD4 File Offset: 0x00F8EDD4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060405A5 RID: 263589 RVA: 0x00F90C60 File Offset: 0x00F8EE60
		[NullableContext(1)]
		public override void Refresh(MotorParkourRankData data, bool isSelected, int gridIndex)
		{
			int id = gridIndex + 1;
			this.SetSpriteByPath(MotorParkourConfig.Instance.GetMotorParkourRankById(id).Value.SpriteNum, base.GetSprite(0), false, null, null);
			UUIText text = base.GetText(2);
			if (text != null)
			{
				text.SetText(data.ShowTimeString, true);
			}
			if (!data.IsOwn)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.Name, Array.Empty<object>());
				return;
			}
			string playerName = FunctionModel.Instance.GetPlayerName();
			UUIText text2 = base.GetText(1);
			if (text2 == null)
			{
				return;
			}
			text2.SetText(playerName, true);
		}

		// Token: 0x0200C60A RID: 50698
		private class EComponents
		{
			// Token: 0x0403BCA6 RID: 244902
			public const int SpriteRankNum = 0;

			// Token: 0x0403BCA7 RID: 244903
			public const int TextName = 1;

			// Token: 0x0403BCA8 RID: 244904
			public const int TextTime = 2;
		}
	}
}
