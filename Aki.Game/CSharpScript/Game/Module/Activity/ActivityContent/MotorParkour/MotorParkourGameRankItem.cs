using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorParkour
{
	// Token: 0x0200536F RID: 21359
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MotorParkourGameRankItem : GridProxyAbstract<MotorParkourRankData>
	{
		// Token: 0x06035265 RID: 217701 RVA: 0x00ED7BBC File Offset: 0x00ED5DBC
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

		// Token: 0x06035266 RID: 217702 RVA: 0x00ED7C48 File Offset: 0x00ED5E48
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

		// Token: 0x0200AFF1 RID: 45041
		private class EComponents
		{
			// Token: 0x04036605 RID: 222725
			public const int SpriteRankNum = 0;

			// Token: 0x04036606 RID: 222726
			public const int TextName = 1;

			// Token: 0x04036607 RID: 222727
			public const int TextTime = 2;
		}
	}
}
