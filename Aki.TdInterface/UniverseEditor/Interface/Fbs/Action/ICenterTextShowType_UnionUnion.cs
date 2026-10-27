using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062BE RID: 25278
	public class ICenterTextShowType_UnionUnion
	{
		// Token: 0x1700BCB4 RID: 48308
		// (get) Token: 0x0602BAEF RID: 178927 RVA: 0x00603301 File Offset: 0x00601501
		// (set) Token: 0x0602BAF0 RID: 178928 RVA: 0x00603309 File Offset: 0x00601509
		public ICenterTextShowType_Union Type { get; set; }

		// Token: 0x1700BCB5 RID: 48309
		// (get) Token: 0x0602BAF1 RID: 178929 RVA: 0x00603312 File Offset: 0x00601512
		// (set) Token: 0x0602BAF2 RID: 178930 RVA: 0x0060331A File Offset: 0x0060151A
		public object Value { get; set; }

		// Token: 0x0602BAF3 RID: 178931 RVA: 0x00603323 File Offset: 0x00601523
		public ICenterTextShowType_UnionUnion()
		{
			this.Type = ICenterTextShowType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602BAF4 RID: 178932 RVA: 0x00603339 File Offset: 0x00601539
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602BAF5 RID: 178933 RVA: 0x0060334B File Offset: 0x0060154B
		public ICenterTextShowTypeT AsICenterTextShowType()
		{
			return this.As<ICenterTextShowTypeT>();
		}

		// Token: 0x0602BAF6 RID: 178934 RVA: 0x00603353 File Offset: 0x00601553
		public static ICenterTextShowType_UnionUnion FromICenterTextShowType(ICenterTextShowTypeT _icentertextshowtype)
		{
			return new ICenterTextShowType_UnionUnion
			{
				Type = ICenterTextShowType_Union.ICenterTextShowType,
				Value = _icentertextshowtype
			};
		}

		// Token: 0x0602BAF7 RID: 178935 RVA: 0x00603368 File Offset: 0x00601568
		public IICenterTextShowAllT AsIICenterTextShowAll()
		{
			return this.As<IICenterTextShowAllT>();
		}

		// Token: 0x0602BAF8 RID: 178936 RVA: 0x00603370 File Offset: 0x00601570
		public static ICenterTextShowType_UnionUnion FromIICenterTextShowAll(IICenterTextShowAllT _iicentertextshowall)
		{
			return new ICenterTextShowType_UnionUnion
			{
				Type = ICenterTextShowType_Union.IICenterTextShowAll,
				Value = _iicentertextshowall
			};
		}

		// Token: 0x0602BAF9 RID: 178937 RVA: 0x00603385 File Offset: 0x00601585
		public IICenterTextFadeOutT AsIICenterTextFadeOut()
		{
			return this.As<IICenterTextFadeOutT>();
		}

		// Token: 0x0602BAFA RID: 178938 RVA: 0x0060338D File Offset: 0x0060158D
		public static ICenterTextShowType_UnionUnion FromIICenterTextFadeOut(IICenterTextFadeOutT _iicentertextfadeout)
		{
			return new ICenterTextShowType_UnionUnion
			{
				Type = ICenterTextShowType_Union.IICenterTextFadeOut,
				Value = _iicentertextfadeout
			};
		}

		// Token: 0x0602BAFB RID: 178939 RVA: 0x006033A2 File Offset: 0x006015A2
		public IICenterTextTypeWriterT AsIICenterTextTypeWriter()
		{
			return this.As<IICenterTextTypeWriterT>();
		}

		// Token: 0x0602BAFC RID: 178940 RVA: 0x006033AA File Offset: 0x006015AA
		public static ICenterTextShowType_UnionUnion FromIICenterTextTypeWriter(IICenterTextTypeWriterT _iicentertexttypewriter)
		{
			return new ICenterTextShowType_UnionUnion
			{
				Type = ICenterTextShowType_Union.IICenterTextTypeWriter,
				Value = _iicentertexttypewriter
			};
		}

		// Token: 0x0602BAFD RID: 178941 RVA: 0x006033C0 File Offset: 0x006015C0
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
