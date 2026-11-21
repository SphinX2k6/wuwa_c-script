using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x0200539D RID: 21405
	public class MotorFightItemTypeItem : SyncGridProxyAbstract<MotorFightItemType>
	{
		// Token: 0x06035405 RID: 218117 RVA: 0x00EDFAE0 File Offset: 0x00EDDCE0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06035406 RID: 218118 RVA: 0x00EDFB6C File Offset: 0x00EDDD6C
		public override void Refresh(MotorFightItemType data)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.Name, Array.Empty<object>());
			this.SetSpriteByPath(data.Icon, base.GetSprite(1), false, null, null);
			Tuple<int, int> tuple = this.GetUnlockNum(data.Id);
			int item = tuple.Item1;
			int item2 = tuple.Item2;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "PrefabTextItem_3218283778_Text", new <>z__ReadOnlyArray<object>(new object[]
			{
				item,
				item2
			}));
		}

		// Token: 0x0401C158 RID: 115032
		[Nullable(1)]
		public Func<int, Tuple<int, int>> GetUnlockNum = (int type) => new Tuple<int, int>(0, 0);

		// Token: 0x0200B032 RID: 45106
		private class EComponents
		{
			// Token: 0x04036739 RID: 223033
			public const int TextTypeName = 0;

			// Token: 0x0403673A RID: 223034
			public const int SpriteIcon = 1;

			// Token: 0x0403673B RID: 223035
			public const int TextUnlockNum = 2;
		}
	}
}
