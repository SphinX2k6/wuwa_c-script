using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041E7 RID: 16871
	public struct ITrackAreaText : IFlatbufferObject
	{
		// Token: 0x170077B0 RID: 30640
		// (get) Token: 0x06018DFA RID: 101882 RVA: 0x0039432C File Offset: 0x0039252C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018DFB RID: 101883 RVA: 0x00394339 File Offset: 0x00392539
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018DFC RID: 101884 RVA: 0x00394340 File Offset: 0x00392540
		public static ITrackAreaText GetRootAsITrackAreaText(ByteBuffer _bb)
		{
			return ITrackAreaText.GetRootAsITrackAreaText(_bb, default(ITrackAreaText));
		}

		// Token: 0x06018DFD RID: 101885 RVA: 0x0039435C File Offset: 0x0039255C
		public static ITrackAreaText GetRootAsITrackAreaText(ByteBuffer _bb, ITrackAreaText obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018DFE RID: 101886 RVA: 0x00394379 File Offset: 0x00392579
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018DFF RID: 101887 RVA: 0x00394388 File Offset: 0x00392588
		public ITrackAreaText __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170077B1 RID: 30641
		// (get) Token: 0x06018E00 RID: 101888 RVA: 0x00394398 File Offset: 0x00392598
		public bool Show
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170077B2 RID: 30642
		// (get) Token: 0x06018E01 RID: 101889 RVA: 0x003943D8 File Offset: 0x003925D8
		public string Tid
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018E02 RID: 101890 RVA: 0x0039440F File Offset: 0x0039260F
		public Span<byte> GetTidBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06018E03 RID: 101891 RVA: 0x0039441E File Offset: 0x0039261E
		public byte[] GetTidArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06018E04 RID: 101892 RVA: 0x0039442C File Offset: 0x0039262C
		public static Offset<ITrackAreaText> CreateITrackAreaText(FlatBufferBuilder builder, bool Show = false, StringOffset TidOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ITrackAreaText.AddTid(builder, TidOffset);
			ITrackAreaText.AddShow(builder, Show);
			return ITrackAreaText.EndITrackAreaText(builder);
		}

		// Token: 0x06018E05 RID: 101893 RVA: 0x00394449 File Offset: 0x00392649
		public static void StartITrackAreaText(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06018E06 RID: 101894 RVA: 0x00394452 File Offset: 0x00392652
		public static void AddShow(FlatBufferBuilder builder, bool show)
		{
			builder.AddBool(0, show, false);
		}

		// Token: 0x06018E07 RID: 101895 RVA: 0x0039445D File Offset: 0x0039265D
		public static void AddTid(FlatBufferBuilder builder, StringOffset tidOffset)
		{
			builder.AddOffset(1, tidOffset.Value, 0);
		}

		// Token: 0x06018E08 RID: 101896 RVA: 0x0039446D File Offset: 0x0039266D
		public static Offset<ITrackAreaText> EndITrackAreaText(FlatBufferBuilder builder)
		{
			return new Offset<ITrackAreaText>(builder.EndTable());
		}

		// Token: 0x06018E09 RID: 101897 RVA: 0x0039447C File Offset: 0x0039267C
		public ITrackAreaTextT UnPack()
		{
			ITrackAreaTextT trackAreaTextT = new ITrackAreaTextT();
			this.UnPackTo(trackAreaTextT);
			return trackAreaTextT;
		}

		// Token: 0x06018E0A RID: 101898 RVA: 0x00394497 File Offset: 0x00392697
		public void UnPackTo(ITrackAreaTextT _o)
		{
			_o.Show = this.Show;
			_o.Tid = this.Tid;
		}

		// Token: 0x06018E0B RID: 101899 RVA: 0x003944B4 File Offset: 0x003926B4
		public static Offset<ITrackAreaText> Pack(FlatBufferBuilder builder, ITrackAreaTextT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrackAreaText>);
			}
			StringOffset tidOffset = (_o.Tid == null) ? default(StringOffset) : builder.CreateString(_o.Tid);
			return ITrackAreaText.CreateITrackAreaText(builder, _o.Show, tidOffset);
		}

		// Token: 0x0400BE3C RID: 48700
		private Table __p;
	}
}
