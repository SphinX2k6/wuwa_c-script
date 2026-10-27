using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C4B RID: 27723
	public struct IOptionLockTip : IFlatbufferObject
	{
		// Token: 0x1700CE76 RID: 52854
		// (get) Token: 0x06030D67 RID: 200039 RVA: 0x006A265C File Offset: 0x006A085C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030D68 RID: 200040 RVA: 0x006A2669 File Offset: 0x006A0869
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030D69 RID: 200041 RVA: 0x006A2670 File Offset: 0x006A0870
		public static IOptionLockTip GetRootAsIOptionLockTip(ByteBuffer _bb)
		{
			return IOptionLockTip.GetRootAsIOptionLockTip(_bb, default(IOptionLockTip));
		}

		// Token: 0x06030D6A RID: 200042 RVA: 0x006A268C File Offset: 0x006A088C
		public static IOptionLockTip GetRootAsIOptionLockTip(ByteBuffer _bb, IOptionLockTip obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030D6B RID: 200043 RVA: 0x006A26A9 File Offset: 0x006A08A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030D6C RID: 200044 RVA: 0x006A26B8 File Offset: 0x006A08B8
		public IOptionLockTip __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CE77 RID: 52855
		// (get) Token: 0x06030D6D RID: 200045 RVA: 0x006A26C8 File Offset: 0x006A08C8
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

		// Token: 0x06030D6E RID: 200046 RVA: 0x006A26FF File Offset: 0x006A08FF
		public Span<byte> GetTidAppendTextBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06030D6F RID: 200047 RVA: 0x006A270E File Offset: 0x006A090E
		public byte[] GetTidAppendTextArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700CE78 RID: 52856
		// (get) Token: 0x06030D70 RID: 200048 RVA: 0x006A271C File Offset: 0x006A091C
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

		// Token: 0x06030D71 RID: 200049 RVA: 0x006A2753 File Offset: 0x006A0953
		public Span<byte> GetTidHintTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06030D72 RID: 200050 RVA: 0x006A2762 File Offset: 0x006A0962
		public byte[] GetTidHintTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700CE79 RID: 52857
		// (get) Token: 0x06030D73 RID: 200051 RVA: 0x006A2770 File Offset: 0x006A0970
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

		// Token: 0x1700CE7A RID: 52858
		// (get) Token: 0x06030D74 RID: 200052 RVA: 0x006A27AC File Offset: 0x006A09AC
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

		// Token: 0x1700CE7B RID: 52859
		// (get) Token: 0x06030D75 RID: 200053 RVA: 0x006A27EC File Offset: 0x006A09EC
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

		// Token: 0x06030D76 RID: 200054 RVA: 0x006A2829 File Offset: 0x006A0A29
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

		// Token: 0x06030D77 RID: 200055 RVA: 0x006A285D File Offset: 0x006A0A5D
		public static void StartIOptionLockTip(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06030D78 RID: 200056 RVA: 0x006A2866 File Offset: 0x006A0A66
		public static void AddTidAppendText(FlatBufferBuilder builder, StringOffset tidAppendTextOffset)
		{
			builder.AddOffset(0, tidAppendTextOffset.Value, 0);
		}

		// Token: 0x06030D79 RID: 200057 RVA: 0x006A2876 File Offset: 0x006A0A76
		public static void AddTidHintText(FlatBufferBuilder builder, StringOffset tidHintTextOffset)
		{
			builder.AddOffset(1, tidHintTextOffset.Value, 0);
		}

		// Token: 0x06030D7A RID: 200058 RVA: 0x006A2886 File Offset: 0x006A0A86
		public static void AddAppendTextId(FlatBufferBuilder builder, int appendTextId)
		{
			builder.AddInt(2, appendTextId, 0);
		}

		// Token: 0x06030D7B RID: 200059 RVA: 0x006A2891 File Offset: 0x006A0A91
		public static void AddHintTextId(FlatBufferBuilder builder, int hintTextId)
		{
			builder.AddInt(3, hintTextId, 0);
		}

		// Token: 0x06030D7C RID: 200060 RVA: 0x006A289C File Offset: 0x006A0A9C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06030D7D RID: 200061 RVA: 0x006A28A7 File Offset: 0x006A0AA7
		public static Offset<IOptionLockTip> EndIOptionLockTip(FlatBufferBuilder builder)
		{
			return new Offset<IOptionLockTip>(builder.EndTable());
		}

		// Token: 0x06030D7E RID: 200062 RVA: 0x006A28B4 File Offset: 0x006A0AB4
		public IOptionLockTipT UnPack()
		{
			IOptionLockTipT optionLockTipT = new IOptionLockTipT();
			this.UnPackTo(optionLockTipT);
			return optionLockTipT;
		}

		// Token: 0x06030D7F RID: 200063 RVA: 0x006A28CF File Offset: 0x006A0ACF
		public void UnPackTo(IOptionLockTipT _o)
		{
			_o.TidAppendText = this.TidAppendText;
			_o.TidHintText = this.TidHintText;
			_o.AppendTextId = this.AppendTextId;
			_o.HintTextId = this.HintTextId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06030D80 RID: 200064 RVA: 0x006A2910 File Offset: 0x006A0B10
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

		// Token: 0x04011589 RID: 71049
		private Table __p;
	}
}
