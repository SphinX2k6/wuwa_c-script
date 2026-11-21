using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F69 RID: 28521
	public class IHandBookProgressOption_UnionUnion
	{
		// Token: 0x1700D0F3 RID: 53491
		// (get) Token: 0x060315D2 RID: 202194 RVA: 0x006B1F11 File Offset: 0x006B0111
		// (set) Token: 0x060315D3 RID: 202195 RVA: 0x006B1F19 File Offset: 0x006B0119
		public IHandBookProgressOption_Union Type { get; set; }

		// Token: 0x1700D0F4 RID: 53492
		// (get) Token: 0x060315D4 RID: 202196 RVA: 0x006B1F22 File Offset: 0x006B0122
		// (set) Token: 0x060315D5 RID: 202197 RVA: 0x006B1F2A File Offset: 0x006B012A
		public object Value { get; set; }

		// Token: 0x060315D6 RID: 202198 RVA: 0x006B1F33 File Offset: 0x006B0133
		public IHandBookProgressOption_UnionUnion()
		{
			this.Type = IHandBookProgressOption_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060315D7 RID: 202199 RVA: 0x006B1F49 File Offset: 0x006B0149
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060315D8 RID: 202200 RVA: 0x006B1F5B File Offset: 0x006B015B
		public IHandBookProgressOptionT AsIHandBookProgressOption()
		{
			return this.As<IHandBookProgressOptionT>();
		}

		// Token: 0x060315D9 RID: 202201 RVA: 0x006B1F63 File Offset: 0x006B0163
		public static IHandBookProgressOption_UnionUnion FromIHandBookProgressOption(IHandBookProgressOptionT _ihandbookprogressoption)
		{
			return new IHandBookProgressOption_UnionUnion
			{
				Type = IHandBookProgressOption_Union.IHandBookProgressOption,
				Value = _ihandbookprogressoption
			};
		}

		// Token: 0x060315DA RID: 202202 RVA: 0x006B1F78 File Offset: 0x006B0178
		public IHandBookGrantEmojiOptionT AsIHandBookGrantEmojiOption()
		{
			return this.As<IHandBookGrantEmojiOptionT>();
		}

		// Token: 0x060315DB RID: 202203 RVA: 0x006B1F80 File Offset: 0x006B0180
		public static IHandBookProgressOption_UnionUnion FromIHandBookGrantEmojiOption(IHandBookGrantEmojiOptionT _ihandbookgrantemojioption)
		{
			return new IHandBookProgressOption_UnionUnion
			{
				Type = IHandBookProgressOption_Union.IHandBookGrantEmojiOption,
				Value = _ihandbookgrantemojioption
			};
		}

		// Token: 0x060315DC RID: 202204 RVA: 0x006B1F95 File Offset: 0x006B0195
		public IHandBookRollbackEmojiOptionT AsIHandBookRollbackEmojiOption()
		{
			return this.As<IHandBookRollbackEmojiOptionT>();
		}

		// Token: 0x060315DD RID: 202205 RVA: 0x006B1F9D File Offset: 0x006B019D
		public static IHandBookProgressOption_UnionUnion FromIHandBookRollbackEmojiOption(IHandBookRollbackEmojiOptionT _ihandbookrollbackemojioption)
		{
			return new IHandBookProgressOption_UnionUnion
			{
				Type = IHandBookProgressOption_Union.IHandBookRollbackEmojiOption,
				Value = _ihandbookrollbackemojioption
			};
		}

		// Token: 0x060315DE RID: 202206 RVA: 0x006B1FB4 File Offset: 0x006B01B4
		public static int Pack(FlatBufferBuilder builder, IHandBookProgressOption_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IHandBookProgressOption_Union.IHandBookProgressOption:
				return IHandBookProgressOption.Pack(builder, _o.AsIHandBookProgressOption()).Value;
			case IHandBookProgressOption_Union.IHandBookGrantEmojiOption:
				return IHandBookGrantEmojiOption.Pack(builder, _o.AsIHandBookGrantEmojiOption()).Value;
			case IHandBookProgressOption_Union.IHandBookRollbackEmojiOption:
				return IHandBookRollbackEmojiOption.Pack(builder, _o.AsIHandBookRollbackEmojiOption()).Value;
			default:
				return 0;
			}
		}
	}
}
