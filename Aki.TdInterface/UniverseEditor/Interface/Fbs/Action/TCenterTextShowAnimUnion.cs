using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200765A RID: 30298
	public class TCenterTextShowAnimUnion
	{
		// Token: 0x1700E5CF RID: 58831
		// (get) Token: 0x0603728A RID: 225930 RVA: 0x0077A71A File Offset: 0x0077891A
		// (set) Token: 0x0603728B RID: 225931 RVA: 0x0077A722 File Offset: 0x00778922
		public TCenterTextShowAnim Type { get; set; }

		// Token: 0x1700E5D0 RID: 58832
		// (get) Token: 0x0603728C RID: 225932 RVA: 0x0077A72B File Offset: 0x0077892B
		// (set) Token: 0x0603728D RID: 225933 RVA: 0x0077A733 File Offset: 0x00778933
		public object Value { get; set; }

		// Token: 0x0603728E RID: 225934 RVA: 0x0077A73C File Offset: 0x0077893C
		public TCenterTextShowAnimUnion()
		{
			this.Type = TCenterTextShowAnim.NONE;
			this.Value = null;
		}

		// Token: 0x0603728F RID: 225935 RVA: 0x0077A752 File Offset: 0x00778952
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037290 RID: 225936 RVA: 0x0077A764 File Offset: 0x00778964
		public IICenterTextFadeOutT AsIICenterTextFadeOut()
		{
			return this.As<IICenterTextFadeOutT>();
		}

		// Token: 0x06037291 RID: 225937 RVA: 0x0077A76C File Offset: 0x0077896C
		public static TCenterTextShowAnimUnion FromIICenterTextFadeOut(IICenterTextFadeOutT _iicentertextfadeout)
		{
			return new TCenterTextShowAnimUnion
			{
				Type = TCenterTextShowAnim.IICenterTextFadeOut,
				Value = _iicentertextfadeout
			};
		}

		// Token: 0x06037292 RID: 225938 RVA: 0x0077A781 File Offset: 0x00778981
		public IICenterTextShowAllT AsIICenterTextShowAll()
		{
			return this.As<IICenterTextShowAllT>();
		}

		// Token: 0x06037293 RID: 225939 RVA: 0x0077A789 File Offset: 0x00778989
		public static TCenterTextShowAnimUnion FromIICenterTextShowAll(IICenterTextShowAllT _iicentertextshowall)
		{
			return new TCenterTextShowAnimUnion
			{
				Type = TCenterTextShowAnim.IICenterTextShowAll,
				Value = _iicentertextshowall
			};
		}

		// Token: 0x06037294 RID: 225940 RVA: 0x0077A79E File Offset: 0x0077899E
		public IICenterTextTypeWriterT AsIICenterTextTypeWriter()
		{
			return this.As<IICenterTextTypeWriterT>();
		}

		// Token: 0x06037295 RID: 225941 RVA: 0x0077A7A6 File Offset: 0x007789A6
		public static TCenterTextShowAnimUnion FromIICenterTextTypeWriter(IICenterTextTypeWriterT _iicentertexttypewriter)
		{
			return new TCenterTextShowAnimUnion
			{
				Type = TCenterTextShowAnim.IICenterTextTypeWriter,
				Value = _iicentertexttypewriter
			};
		}

		// Token: 0x06037296 RID: 225942 RVA: 0x0077A7BC File Offset: 0x007789BC
		public static int Pack(FlatBufferBuilder builder, TCenterTextShowAnimUnion _o)
		{
			switch (_o.Type)
			{
			case TCenterTextShowAnim.IICenterTextFadeOut:
				return IICenterTextFadeOut.Pack(builder, _o.AsIICenterTextFadeOut()).Value;
			case TCenterTextShowAnim.IICenterTextShowAll:
				return IICenterTextShowAll.Pack(builder, _o.AsIICenterTextShowAll()).Value;
			case TCenterTextShowAnim.IICenterTextTypeWriter:
				return IICenterTextTypeWriter.Pack(builder, _o.AsIICenterTextTypeWriter()).Value;
			default:
				return 0;
			}
		}
	}
}
