using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E68 RID: 32360
	public class TCenterTextShowAnimUnion
	{
		// Token: 0x1700F20D RID: 61965
		// (get) Token: 0x0603A72F RID: 239407 RVA: 0x007DE816 File Offset: 0x007DCA16
		// (set) Token: 0x0603A730 RID: 239408 RVA: 0x007DE81E File Offset: 0x007DCA1E
		public TCenterTextShowAnim Type { get; set; }

		// Token: 0x1700F20E RID: 61966
		// (get) Token: 0x0603A731 RID: 239409 RVA: 0x007DE827 File Offset: 0x007DCA27
		// (set) Token: 0x0603A732 RID: 239410 RVA: 0x007DE82F File Offset: 0x007DCA2F
		public object Value { get; set; }

		// Token: 0x0603A733 RID: 239411 RVA: 0x007DE838 File Offset: 0x007DCA38
		public TCenterTextShowAnimUnion()
		{
			this.Type = TCenterTextShowAnim.NONE;
			this.Value = null;
		}

		// Token: 0x0603A734 RID: 239412 RVA: 0x007DE84E File Offset: 0x007DCA4E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A735 RID: 239413 RVA: 0x007DE860 File Offset: 0x007DCA60
		public IICenterTextFadeOutT AsIICenterTextFadeOut()
		{
			return this.As<IICenterTextFadeOutT>();
		}

		// Token: 0x0603A736 RID: 239414 RVA: 0x007DE868 File Offset: 0x007DCA68
		public static TCenterTextShowAnimUnion FromIICenterTextFadeOut(IICenterTextFadeOutT _iicentertextfadeout)
		{
			return new TCenterTextShowAnimUnion
			{
				Type = TCenterTextShowAnim.IICenterTextFadeOut,
				Value = _iicentertextfadeout
			};
		}

		// Token: 0x0603A737 RID: 239415 RVA: 0x007DE87D File Offset: 0x007DCA7D
		public IICenterTextShowAllT AsIICenterTextShowAll()
		{
			return this.As<IICenterTextShowAllT>();
		}

		// Token: 0x0603A738 RID: 239416 RVA: 0x007DE885 File Offset: 0x007DCA85
		public static TCenterTextShowAnimUnion FromIICenterTextShowAll(IICenterTextShowAllT _iicentertextshowall)
		{
			return new TCenterTextShowAnimUnion
			{
				Type = TCenterTextShowAnim.IICenterTextShowAll,
				Value = _iicentertextshowall
			};
		}

		// Token: 0x0603A739 RID: 239417 RVA: 0x007DE89A File Offset: 0x007DCA9A
		public IICenterTextTypeWriterT AsIICenterTextTypeWriter()
		{
			return this.As<IICenterTextTypeWriterT>();
		}

		// Token: 0x0603A73A RID: 239418 RVA: 0x007DE8A2 File Offset: 0x007DCAA2
		public static TCenterTextShowAnimUnion FromIICenterTextTypeWriter(IICenterTextTypeWriterT _iicentertexttypewriter)
		{
			return new TCenterTextShowAnimUnion
			{
				Type = TCenterTextShowAnim.IICenterTextTypeWriter,
				Value = _iicentertexttypewriter
			};
		}

		// Token: 0x0603A73B RID: 239419 RVA: 0x007DE8B8 File Offset: 0x007DCAB8
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
