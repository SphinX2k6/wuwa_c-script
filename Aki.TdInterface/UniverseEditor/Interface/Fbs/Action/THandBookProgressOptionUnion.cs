using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007EF5 RID: 32501
	public class THandBookProgressOptionUnion
	{
		// Token: 0x1700F271 RID: 62065
		// (get) Token: 0x0603AA21 RID: 240161 RVA: 0x007E332A File Offset: 0x007E152A
		// (set) Token: 0x0603AA22 RID: 240162 RVA: 0x007E3332 File Offset: 0x007E1532
		public THandBookProgressOption Type { get; set; }

		// Token: 0x1700F272 RID: 62066
		// (get) Token: 0x0603AA23 RID: 240163 RVA: 0x007E333B File Offset: 0x007E153B
		// (set) Token: 0x0603AA24 RID: 240164 RVA: 0x007E3343 File Offset: 0x007E1543
		public object Value { get; set; }

		// Token: 0x0603AA25 RID: 240165 RVA: 0x007E334C File Offset: 0x007E154C
		public THandBookProgressOptionUnion()
		{
			this.Type = THandBookProgressOption.NONE;
			this.Value = null;
		}

		// Token: 0x0603AA26 RID: 240166 RVA: 0x007E3362 File Offset: 0x007E1562
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AA27 RID: 240167 RVA: 0x007E3374 File Offset: 0x007E1574
		public IHandBookGrantEmojiOptionT AsIHandBookGrantEmojiOption()
		{
			return this.As<IHandBookGrantEmojiOptionT>();
		}

		// Token: 0x0603AA28 RID: 240168 RVA: 0x007E337C File Offset: 0x007E157C
		public static THandBookProgressOptionUnion FromIHandBookGrantEmojiOption(IHandBookGrantEmojiOptionT _ihandbookgrantemojioption)
		{
			return new THandBookProgressOptionUnion
			{
				Type = THandBookProgressOption.IHandBookGrantEmojiOption,
				Value = _ihandbookgrantemojioption
			};
		}

		// Token: 0x0603AA29 RID: 240169 RVA: 0x007E3391 File Offset: 0x007E1591
		public IHandBookRollbackEmojiOptionT AsIHandBookRollbackEmojiOption()
		{
			return this.As<IHandBookRollbackEmojiOptionT>();
		}

		// Token: 0x0603AA2A RID: 240170 RVA: 0x007E3399 File Offset: 0x007E1599
		public static THandBookProgressOptionUnion FromIHandBookRollbackEmojiOption(IHandBookRollbackEmojiOptionT _ihandbookrollbackemojioption)
		{
			return new THandBookProgressOptionUnion
			{
				Type = THandBookProgressOption.IHandBookRollbackEmojiOption,
				Value = _ihandbookrollbackemojioption
			};
		}

		// Token: 0x0603AA2B RID: 240171 RVA: 0x007E33B0 File Offset: 0x007E15B0
		public static int Pack(FlatBufferBuilder builder, THandBookProgressOptionUnion _o)
		{
			THandBookProgressOption type = _o.Type;
			if (type == THandBookProgressOption.IHandBookGrantEmojiOption)
			{
				return IHandBookGrantEmojiOption.Pack(builder, _o.AsIHandBookGrantEmojiOption()).Value;
			}
			if (type != THandBookProgressOption.IHandBookRollbackEmojiOption)
			{
				return 0;
			}
			return IHandBookRollbackEmojiOption.Pack(builder, _o.AsIHandBookRollbackEmojiOption()).Value;
		}
	}
}
