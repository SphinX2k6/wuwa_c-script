using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004ABB RID: 19131
	public class ICheckJigsawType_UnionUnion
	{
		// Token: 0x17008AAC RID: 35500
		// (get) Token: 0x0601E07C RID: 123004 RVA: 0x00436F31 File Offset: 0x00435131
		// (set) Token: 0x0601E07D RID: 123005 RVA: 0x00436F39 File Offset: 0x00435139
		public ICheckJigsawType_Union Type { get; set; }

		// Token: 0x17008AAD RID: 35501
		// (get) Token: 0x0601E07E RID: 123006 RVA: 0x00436F42 File Offset: 0x00435142
		// (set) Token: 0x0601E07F RID: 123007 RVA: 0x00436F4A File Offset: 0x0043514A
		public object Value { get; set; }

		// Token: 0x0601E080 RID: 123008 RVA: 0x00436F53 File Offset: 0x00435153
		public ICheckJigsawType_UnionUnion()
		{
			this.Type = ICheckJigsawType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601E081 RID: 123009 RVA: 0x00436F69 File Offset: 0x00435169
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601E082 RID: 123010 RVA: 0x00436F7B File Offset: 0x0043517B
		public ICheckJigsawTypeT AsICheckJigsawType()
		{
			return this.As<ICheckJigsawTypeT>();
		}

		// Token: 0x0601E083 RID: 123011 RVA: 0x00436F83 File Offset: 0x00435183
		public static ICheckJigsawType_UnionUnion FromICheckJigsawType(ICheckJigsawTypeT _icheckjigsawtype)
		{
			return new ICheckJigsawType_UnionUnion
			{
				Type = ICheckJigsawType_Union.ICheckJigsawType,
				Value = _icheckjigsawtype
			};
		}

		// Token: 0x0601E084 RID: 123012 RVA: 0x00436F98 File Offset: 0x00435198
		public ICheckJigsawItemPlaceIndexT AsICheckJigsawItemPlaceIndex()
		{
			return this.As<ICheckJigsawItemPlaceIndexT>();
		}

		// Token: 0x0601E085 RID: 123013 RVA: 0x00436FA0 File Offset: 0x004351A0
		public static ICheckJigsawType_UnionUnion FromICheckJigsawItemPlaceIndex(ICheckJigsawItemPlaceIndexT _icheckjigsawitemplaceindex)
		{
			return new ICheckJigsawType_UnionUnion
			{
				Type = ICheckJigsawType_Union.ICheckJigsawItemPlaceIndex,
				Value = _icheckjigsawitemplaceindex
			};
		}

		// Token: 0x0601E086 RID: 123014 RVA: 0x00436FB5 File Offset: 0x004351B5
		public ICheckJigsawItemMoveT AsICheckJigsawItemMove()
		{
			return this.As<ICheckJigsawItemMoveT>();
		}

		// Token: 0x0601E087 RID: 123015 RVA: 0x00436FBD File Offset: 0x004351BD
		public static ICheckJigsawType_UnionUnion FromICheckJigsawItemMove(ICheckJigsawItemMoveT _icheckjigsawitemmove)
		{
			return new ICheckJigsawType_UnionUnion
			{
				Type = ICheckJigsawType_Union.ICheckJigsawItemMove,
				Value = _icheckjigsawitemmove
			};
		}

		// Token: 0x0601E088 RID: 123016 RVA: 0x00436FD4 File Offset: 0x004351D4
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
