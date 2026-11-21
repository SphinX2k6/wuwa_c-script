using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F8A RID: 20362
	public class ICheckJigsawType_UnionUnion
	{
		// Token: 0x17009199 RID: 37273
		// (get) Token: 0x0601FB65 RID: 129893 RVA: 0x00468751 File Offset: 0x00466951
		// (set) Token: 0x0601FB66 RID: 129894 RVA: 0x00468759 File Offset: 0x00466959
		public ICheckJigsawType_Union Type { get; set; }

		// Token: 0x1700919A RID: 37274
		// (get) Token: 0x0601FB67 RID: 129895 RVA: 0x00468762 File Offset: 0x00466962
		// (set) Token: 0x0601FB68 RID: 129896 RVA: 0x0046876A File Offset: 0x0046696A
		public object Value { get; set; }

		// Token: 0x0601FB69 RID: 129897 RVA: 0x00468773 File Offset: 0x00466973
		public ICheckJigsawType_UnionUnion()
		{
			this.Type = ICheckJigsawType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601FB6A RID: 129898 RVA: 0x00468789 File Offset: 0x00466989
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601FB6B RID: 129899 RVA: 0x0046879B File Offset: 0x0046699B
		public ICheckJigsawTypeT AsICheckJigsawType()
		{
			return this.As<ICheckJigsawTypeT>();
		}

		// Token: 0x0601FB6C RID: 129900 RVA: 0x004687A3 File Offset: 0x004669A3
		public static ICheckJigsawType_UnionUnion FromICheckJigsawType(ICheckJigsawTypeT _icheckjigsawtype)
		{
			return new ICheckJigsawType_UnionUnion
			{
				Type = ICheckJigsawType_Union.ICheckJigsawType,
				Value = _icheckjigsawtype
			};
		}

		// Token: 0x0601FB6D RID: 129901 RVA: 0x004687B8 File Offset: 0x004669B8
		public ICheckJigsawItemPlaceIndexT AsICheckJigsawItemPlaceIndex()
		{
			return this.As<ICheckJigsawItemPlaceIndexT>();
		}

		// Token: 0x0601FB6E RID: 129902 RVA: 0x004687C0 File Offset: 0x004669C0
		public static ICheckJigsawType_UnionUnion FromICheckJigsawItemPlaceIndex(ICheckJigsawItemPlaceIndexT _icheckjigsawitemplaceindex)
		{
			return new ICheckJigsawType_UnionUnion
			{
				Type = ICheckJigsawType_Union.ICheckJigsawItemPlaceIndex,
				Value = _icheckjigsawitemplaceindex
			};
		}

		// Token: 0x0601FB6F RID: 129903 RVA: 0x004687D5 File Offset: 0x004669D5
		public ICheckJigsawItemMoveT AsICheckJigsawItemMove()
		{
			return this.As<ICheckJigsawItemMoveT>();
		}

		// Token: 0x0601FB70 RID: 129904 RVA: 0x004687DD File Offset: 0x004669DD
		public static ICheckJigsawType_UnionUnion FromICheckJigsawItemMove(ICheckJigsawItemMoveT _icheckjigsawitemmove)
		{
			return new ICheckJigsawType_UnionUnion
			{
				Type = ICheckJigsawType_Union.ICheckJigsawItemMove,
				Value = _icheckjigsawitemmove
			};
		}

		// Token: 0x0601FB71 RID: 129905 RVA: 0x004687F4 File Offset: 0x004669F4
		public static int Pack(FlatBufferBuilder builder, ICheckJigsawType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ICheckJigsawType_Union.ICheckJigsawType:
				return ICheckJigsawType.Pack(builder, _o.AsICheckJigsawType()).Value;
			case ICheckJigsawType_Union.ICheckJigsawItemPlaceIndex:
				return ICheckJigsawItemPlaceIndex.Pack(builder, _o.AsICheckJigsawItemPlaceIndex()).Value;
			case ICheckJigsawType_Union.ICheckJigsawItemMove:
				return ICheckJigsawItemMove.Pack(builder, _o.AsICheckJigsawItemMove()).Value;
			default:
				return 0;
			}
		}
	}
}
