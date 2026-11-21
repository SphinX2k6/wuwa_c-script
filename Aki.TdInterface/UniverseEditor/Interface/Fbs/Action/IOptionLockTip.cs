using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073B2 RID: 29618
	public struct IOptionLockTip : IFlatbufferObject
	{
		// Token: 0x1700D991 RID: 55697
		// (get) Token: 0x06033CC2 RID: 212162 RVA: 0x006FCB5C File Offset: 0x006FAD5C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033CC3 RID: 212163 RVA: 0x006FCB69 File Offset: 0x006FAD69
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033CC4 RID: 212164 RVA: 0x006FCB70 File Offset: 0x006FAD70
		public static IOptionLockTip GetRootAsIOptionLockTip(ByteBuffer _bb)
		{
			return IOptionLockTip.GetRootAsIOptionLockTip(_bb, default(IOptionLockTip));
		}

		// Token: 0x06033CC5 RID: 212165 RVA: 0x006FCB8C File Offset: 0x006FAD8C
		public static IOptionLockTip GetRootAsIOptionLockTip(ByteBuffer _bb, IOptionLockTip obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033CC6 RID: 212166 RVA: 0x006FCBA9 File Offset: 0x006FADA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033CC7 RID: 212167 RVA: 0x006FCBB8 File Offset: 0x006FADB8
		public IOptionLockTip __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D992 RID: 55698
		// (get) Token: 0x06033CC8 RID: 212168 RVA: 0x006FCBC8 File Offset: 0x006FADC8
		public string TidAppendText
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033CC9 RID: 212169 RVA: 0x006FCBFF File Offset: 0x006FADFF
		public Span<byte> GetTidAppendTextBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06033CCA RID: 212170 RVA: 0x006FCC0E File Offset: 0x006FAE0E
		public byte[] GetTidAppendTextArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700D993 RID: 55699
		// (get) Token: 0x06033CCB RID: 212171 RVA: 0x006FCC1C File Offset: 0x006FAE1C
		public string TidHintText
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

		// Token: 0x06033CCC RID: 212172 RVA: 0x006FCC53 File Offset: 0x006FAE53
		public Span<byte> GetTidHintTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06033CCD RID: 212173 RVA: 0x006FCC62 File Offset: 0x006FAE62
		public byte[] GetTidHintTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700D994 RID: 55700
		// (get) Token: 0x06033CCE RID: 212174 RVA: 0x006FCC70 File Offset: 0x006FAE70
		public int AppendTextId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D995 RID: 55701
		// (get) Token: 0x06033CCF RID: 212175 RVA: 0x006FCCAC File Offset: 0x006FAEAC
		public int HintTextId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D996 RID: 55702
		// (get) Token: 0x06033CD0 RID: 212176 RVA: 0x006FCCEC File Offset: 0x006FAEEC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033CD1 RID: 212177 RVA: 0x006FCD29 File Offset: 0x006FAF29
		public static Offset<IOptionLockTip> CreateIOptionLockTip(FlatBufferBuilder builder, StringOffset TidAppendTextOffset = default(StringOffset), StringOffset TidHintTextOffset = default(StringOffset), int AppendTextId = 0, int HintTextId = 0, byte NullMask = 0)
		{
			builder.StartTable(5);
			IOptionLockTip.AddHintTextId(builder, HintTextId);
			IOptionLockTip.AddAppendTextId(builder, AppendTextId);
			IOptionLockTip.AddTidHintText(builder, TidHintTextOffset);
			IOptionLockTip.AddTidAppendText(builder, TidAppendTextOffset);
			IOptionLockTip.AddNullMask(builder, NullMask);
			return IOptionLockTip.EndIOptionLockTip(builder);
		}

		// Token: 0x06033CD2 RID: 212178 RVA: 0x006FCD5D File Offset: 0x006FAF5D
		public static void StartIOptionLockTip(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06033CD3 RID: 212179 RVA: 0x006FCD66 File Offset: 0x006FAF66
		public static void AddTidAppendText(FlatBufferBuilder builder, StringOffset tidAppendTextOffset)
		{
			builder.AddOffset(0, tidAppendTextOffset.Value, 0);
		}

		// Token: 0x06033CD4 RID: 212180 RVA: 0x006FCD76 File Offset: 0x006FAF76
		public static void AddTidHintText(FlatBufferBuilder builder, StringOffset tidHintTextOffset)
		{
			builder.AddOffset(1, tidHintTextOffset.Value, 0);
		}

		// Token: 0x06033CD5 RID: 212181 RVA: 0x006FCD86 File Offset: 0x006FAF86
		public static void AddAppendTextId(FlatBufferBuilder builder, int appendTextId)
		{
			builder.AddInt(2, appendTextId, 0);
		}

		// Token: 0x06033CD6 RID: 212182 RVA: 0x006FCD91 File Offset: 0x006FAF91
		public static void AddHintTextId(FlatBufferBuilder builder, int hintTextId)
		{
			builder.AddInt(3, hintTextId, 0);
		}

		// Token: 0x06033CD7 RID: 212183 RVA: 0x006FCD9C File Offset: 0x006FAF9C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06033CD8 RID: 212184 RVA: 0x006FCDA7 File Offset: 0x006FAFA7
		public static Offset<IOptionLockTip> EndIOptionLockTip(FlatBufferBuilder builder)
		{
			return new Offset<IOptionLockTip>(builder.EndTable());
		}

		// Token: 0x06033CD9 RID: 212185 RVA: 0x006FCDB4 File Offset: 0x006FAFB4
		public IOptionLockTipT UnPack()
		{
			IOptionLockTipT optionLockTipT = new IOptionLockTipT();
			this.UnPackTo(optionLockTipT);
			return optionLockTipT;
		}

		// Token: 0x06033CDA RID: 212186 RVA: 0x006FCDCF File Offset: 0x006FAFCF
		public void UnPackTo(IOptionLockTipT _o)
		{
			_o.TidAppendText = this.TidAppendText;
			_o.TidHintText = this.TidHintText;
			_o.AppendTextId = this.AppendTextId;
			_o.HintTextId = this.HintTextId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06033CDB RID: 212187 RVA: 0x006FCE10 File Offset: 0x006FB010
		public static Offset<IOptionLockTip> Pack(FlatBufferBuilder builder, IOptionLockTipT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOptionLockTip>);
			}
			StringOffset tidAppendTextOffset = (_o.TidAppendText == null) ? default(StringOffset) : builder.CreateString(_o.TidAppendText);
			StringOffset tidHintTextOffset = (_o.TidHintText == null) ? default(StringOffset) : builder.CreateString(_o.TidHintText);
			return IOptionLockTip.CreateIOptionLockTip(builder, tidAppendTextOffset, tidHintTextOffset, _o.AppendTextId, _o.HintTextId, _o.NullMask);
		}

		// Token: 0x040124E1 RID: 74977
		private Table __p;
	}
}
