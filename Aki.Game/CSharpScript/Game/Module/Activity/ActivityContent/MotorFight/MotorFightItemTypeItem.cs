using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x0200641F RID: 25631
	public class MotorFightItemTypeItem : SyncGridProxyAbstract<MotorFightItemType>
	{
		// Token: 0x06040744 RID: 264004 RVA: 0x00F98B40 File Offset: 0x00F96D40
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

		// Token: 0x06040745 RID: 264005 RVA: 0x00F98BCC File Offset: 0x00F96DCC
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

		// Token: 0x04021829 RID: 137257
		[Nullable(1)]
		public Func<int, Tuple<int, int>> GetUnlockNum = (int type) => new Tuple<int, int>(0, 0);

		// Token: 0x0200C64B RID: 50763
		private class EComponents
		{
			// Token: 0x0403BDDC RID: 245212
			public const int TextTypeName = 0;

			// Token: 0x0403BDDD RID: 245213
			public const int SpriteIcon = 1;

			// Token: 0x0403BDDE RID: 245214
			public const int TextUnlockNum = 2;
		}
	}
}
