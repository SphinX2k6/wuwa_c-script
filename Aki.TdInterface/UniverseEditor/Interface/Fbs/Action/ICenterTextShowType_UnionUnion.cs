using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200692F RID: 26927
	public class ICenterTextShowType_UnionUnion
	{
		// Token: 0x1700C63E RID: 50750
		// (get) Token: 0x0602E258 RID: 189016 RVA: 0x0064E30D File Offset: 0x0064C50D
		// (set) Token: 0x0602E259 RID: 189017 RVA: 0x0064E315 File Offset: 0x0064C515
		public ICenterTextShowType_Union Type { get; set; }

		// Token: 0x1700C63F RID: 50751
		// (get) Token: 0x0602E25A RID: 189018 RVA: 0x0064E31E File Offset: 0x0064C51E
		// (set) Token: 0x0602E25B RID: 189019 RVA: 0x0064E326 File Offset: 0x0064C526
		public object Value { get; set; }

		// Token: 0x0602E25C RID: 189020 RVA: 0x0064E32F File Offset: 0x0064C52F
		public ICenterTextShowType_UnionUnion()
		{
			this.Type = ICenterTextShowType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602E25D RID: 189021 RVA: 0x0064E345 File Offset: 0x0064C545
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602E25E RID: 189022 RVA: 0x0064E357 File Offset: 0x0064C557
		public ICenterTextShowTypeT AsICenterTextShowType()
		{
			return this.As<ICenterTextShowTypeT>();
		}

		// Token: 0x0602E25F RID: 189023 RVA: 0x0064E35F File Offset: 0x0064C55F
		public static ICenterTextShowType_UnionUnion FromICenterTextShowType(ICenterTextShowTypeT _icentertextshowtype)
		{
			return new ICenterTextShowType_UnionUnion
			{
				Type = ICenterTextShowType_Union.ICenterTextShowType,
				Value = _icentertextshowtype
			};
		}

		// Token: 0x0602E260 RID: 189024 RVA: 0x0064E374 File Offset: 0x0064C574
		public IICenterTextShowAllT AsIICenterTextShowAll()
		{
			return this.As<IICenterTextShowAllT>();
		}

		// Token: 0x0602E261 RID: 189025 RVA: 0x0064E37C File Offset: 0x0064C57C
		public static ICenterTextShowType_UnionUnion FromIICenterTextShowAll(IICenterTextShowAllT _iicentertextshowall)
		{
			return new ICenterTextShowType_UnionUnion
			{
				Type = ICenterTextShowType_Union.IICenterTextShowAll,
				Value = _iicentertextshowall
			};
		}

		// Token: 0x0602E262 RID: 189026 RVA: 0x0064E391 File Offset: 0x0064C591
		public IICenterTextFadeOutT AsIICenterTextFadeOut()
		{
			return this.As<IICenterTextFadeOutT>();
		}

		// Token: 0x0602E263 RID: 189027 RVA: 0x0064E399 File Offset: 0x0064C599
		public static ICenterTextShowType_UnionUnion FromIICenterTextFadeOut(IICenterTextFadeOutT _iicentertextfadeout)
		{
			return new ICenterTextShowType_UnionUnion
			{
				Type = ICenterTextShowType_Union.IICenterTextFadeOut,
				Value = _iicentertextfadeout
			};
		}

		// Token: 0x0602E264 RID: 189028 RVA: 0x0064E3AE File Offset: 0x0064C5AE
		public IICenterTextTypeWriterT AsIICenterTextTypeWriter()
		{
			return this.As<IICenterTextTypeWriterT>();
		}

		// Token: 0x0602E265 RID: 189029 RVA: 0x0064E3B6 File Offset: 0x0064C5B6
		public static ICenterTextShowType_UnionUnion FromIICenterTextTypeWriter(IICenterTextTypeWriterT _iicentertexttypewriter)
		{
			return new ICenterTextShowType_UnionUnion
			{
				Type = ICenterTextShowType_Union.IICenterTextTypeWriter,
				Value = _iicentertexttypewriter
			};
		}

		// Token: 0x0602E266 RID: 189030 RVA: 0x0064E3CC File Offset: 0x0064C5CC
		public static int Pack(FlatBufferBuilder builder, ICenterTextShowType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ICenterTextShowType_Union.ICenterTextShowType:
				return ICenterTextShowType.Pack(builder, _o.AsICenterTextShowType()).Value;
			case ICenterTextShowType_Union.IICenterTextShowAll:
				return IICenterTextShowAll.Pack(builder, _o.AsIICenterTextShowAll()).Value;
			case ICenterTextShowType_Union.IICenterTextFadeOut:
				return IICenterTextFadeOut.Pack(builder, _o.AsIICenterTextFadeOut()).Value;
			case ICenterTextShowType_Union.IICenterTextTypeWriter:
				return IICenterTextTypeWriter.Pack(builder, _o.AsIICenterTextTypeWriter()).Value;
			default:
				return 0;
			}
		}
	}
}
