using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077F7 RID: 30711
	public struct ISetNpcGroupPerform : IFlatbufferObject
	{
		// Token: 0x1700E113 RID: 57619
		// (get) Token: 0x06035F2F RID: 220975 RVA: 0x0073A075 File Offset: 0x00738275
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035F30 RID: 220976 RVA: 0x0073A082 File Offset: 0x00738282
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035F31 RID: 220977 RVA: 0x0073A08C File Offset: 0x0073828C
		public static ISetNpcGroupPerform GetRootAsISetNpcGroupPerform(ByteBuffer _bb)
		{
			return ISetNpcGroupPerform.GetRootAsISetNpcGroupPerform(_bb, default(ISetNpcGroupPerform));
		}

		// Token: 0x06035F32 RID: 220978 RVA: 0x0073A0A8 File Offset: 0x007382A8
		public static ISetNpcGroupPerform GetRootAsISetNpcGroupPerform(ByteBuffer _bb, ISetNpcGroupPerform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035F33 RID: 220979 RVA: 0x0073A0C5 File Offset: 0x007382C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035F34 RID: 220980 RVA: 0x0073A0D4 File Offset: 0x007382D4
		public ISetNpcGroupPerform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E114 RID: 57620
		// (get) Token: 0x06035F35 RID: 220981 RVA: 0x0073A0E4 File Offset: 0x007382E4
		public string Key
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

		// Token: 0x06035F36 RID: 220982 RVA: 0x0073A11B File Offset: 0x0073831B
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06035F37 RID: 220983 RVA: 0x0073A12A File Offset: 0x0073832A
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700E115 RID: 57621
		// (get) Token: 0x06035F38 RID: 220984 RVA: 0x0073A138 File Offset: 0x00738338
		public TSetNpcGroupPerformType PerformTypeType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TSetNpcGroupPerformType.NONE;
				}
				return (TSetNpcGroupPerformType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035F39 RID: 220985 RVA: 0x0073A174 File Offset: 0x00738374
		public TTable? PerformType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06035F3A RID: 220986 RVA: 0x0073A1B8 File Offset: 0x007383B8
		public ISetNpcHandInHandPerform PerformTypeAsISetNpcHandInHandPerform()
		{
			return this.PerformType<ISetNpcHandInHandPerform>().Value;
		}

		// Token: 0x06035F3B RID: 220987 RVA: 0x0073A1D4 File Offset: 0x007383D4
		public ISetNpcHighFivePerform PerformTypeAsISetNpcHighFivePerform()
		{
			return this.PerformType<ISetNpcHighFivePerform>().Value;
		}

		// Token: 0x06035F3C RID: 220988 RVA: 0x0073A1F0 File Offset: 0x007383F0
		public ISetNpcHuggingBearPerform PerformTypeAsISetNpcHuggingBearPerform()
		{
			return this.PerformType<ISetNpcHuggingBearPerform>().Value;
		}

		// Token: 0x06035F3D RID: 220989 RVA: 0x0073A20C File Offset: 0x0073840C
		public ISetNpcSequencePerform PerformTypeAsISetNpcSequencePerform()
		{
			return this.PerformType<ISetNpcSequencePerform>().Value;
		}

		// Token: 0x06035F3E RID: 220990 RVA: 0x0073A228 File Offset: 0x00738428
		public ISetNpcSupportedWalkingPerform PerformTypeAsISetNpcSupportedWalkingPerform()
		{
			return this.PerformType<ISetNpcSupportedWalkingPerform>().Value;
		}

		// Token: 0x06035F3F RID: 220991 RVA: 0x0073A244 File Offset: 0x00738444
		public ISetNpcTwoPersonPerform PerformTypeAsISetNpcTwoPersonPerform()
		{
			return this.PerformType<ISetNpcTwoPersonPerform>().Value;
		}

		// Token: 0x1700E116 RID: 57622
		// (get) Token: 0x06035F40 RID: 220992 RVA: 0x0073A260 File Offset: 0x00738460
		public bool IsWaitActionFinish
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E117 RID: 57623
		// (get) Token: 0x06035F41 RID: 220993 RVA: 0x0073A2A0 File Offset: 0x007384A0
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

		// Token: 0x06035F42 RID: 220994 RVA: 0x0073A2DD File Offset: 0x007384DD
		public static Offset<ISetNpcGroupPerform> CreateISetNpcGroupPerform(FlatBufferBuilder builder, StringOffset KeyOffset = default(StringOffset), TSetNpcGroupPerformType PerformType_type = TSetNpcGroupPerformType.NONE, int PerformTypeOffset = 0, bool IsWaitActionFinish = false, byte NullMask = 0)
		{
			builder.StartTable(5);
			ISetNpcGroupPerform.AddPerformType(builder, PerformTypeOffset);
			ISetNpcGroupPerform.AddKey(builder, KeyOffset);
			ISetNpcGroupPerform.AddNullMask(builder, NullMask);
			ISetNpcGroupPerform.AddIsWaitActionFinish(builder, IsWaitActionFinish);
			ISetNpcGroupPerform.AddPerformTypeType(builder, PerformType_type);
			return ISetNpcGroupPerform.EndISetNpcGroupPerform(builder);
		}

		// Token: 0x06035F43 RID: 220995 RVA: 0x0073A311 File Offset: 0x00738511
		public static void StartISetNpcGroupPerform(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06035F44 RID: 220996 RVA: 0x0073A31A File Offset: 0x0073851A
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(0, keyOffset.Value, 0);
		}

		// Token: 0x06035F45 RID: 220997 RVA: 0x0073A32A File Offset: 0x0073852A
		public static void AddPerformTypeType(FlatBufferBuilder builder, TSetNpcGroupPerformType performTypeType)
		{
			builder.AddByte(1, (byte)performTypeType, 0);
		}

		// Token: 0x06035F46 RID: 220998 RVA: 0x0073A335 File Offset: 0x00738535
		public static void AddPerformType(FlatBufferBuilder builder, int performTypeOffset)
		{
			builder.AddOffset(2, performTypeOffset, 0);
		}

		// Token: 0x06035F47 RID: 220999 RVA: 0x0073A340 File Offset: 0x00738540
		public static void AddIsWaitActionFinish(FlatBufferBuilder builder, bool isWaitActionFinish)
		{
			builder.AddBool(3, isWaitActionFinish, false);
		}

		// Token: 0x06035F48 RID: 221000 RVA: 0x0073A34B File Offset: 0x0073854B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06035F49 RID: 221001 RVA: 0x0073A356 File Offset: 0x00738556
		public static Offset<ISetNpcGroupPerform> EndISetNpcGroupPerform(FlatBufferBuilder builder)
		{
			return new Offset<ISetNpcGroupPerform>(builder.EndTable());
		}

		// Token: 0x06035F4A RID: 221002 RVA: 0x0073A364 File Offset: 0x00738564
		public ISetNpcGroupPerformT UnPack()
		{
			ISetNpcGroupPerformT setNpcGroupPerformT = new ISetNpcGroupPerformT();
			this.UnPackTo(setNpcGroupPerformT);
			return setNpcGroupPerformT;
		}

		// Token: 0x06035F4B RID: 221003 RVA: 0x0073A380 File Offset: 0x00738580
		public void UnPackTo(ISetNpcGroupPerformT _o)
		{
			_o.Key = this.Key;
			_o.PerformType = new TSetNpcGroupPerformTypeUnion();
			_o.PerformType.Type = this.PerformTypeType;
			switch (this.PerformTypeType)
			{
			case TSetNpcGroupPerformType.ISetNpcHandInHandPerform:
				_o.PerformType.Value = ((this.PerformType<ISetNpcHandInHandPerform>() != null) ? this.PerformType<ISetNpcHandInHandPerform>().Value.UnPack() : null);
				break;
			case TSetNpcGroupPerformType.ISetNpcHighFivePerform:
				_o.PerformType.Value = ((this.PerformType<ISetNpcHighFivePerform>() != null) ? this.PerformType<ISetNpcHighFivePerform>().Value.UnPack() : null);
				break;
			case TSetNpcGroupPerformType.ISetNpcHuggingBearPerform:
				_o.PerformType.Value = ((this.PerformType<ISetNpcHuggingBearPerform>() != null) ? this.PerformType<ISetNpcHuggingBearPerform>().Value.UnPack() : null);
				break;
			case TSetNpcGroupPerformType.ISetNpcSequencePerform:
				_o.PerformType.Value = ((this.PerformType<ISetNpcSequencePerform>() != null) ? this.PerformType<ISetNpcSequencePerform>().Value.UnPack() : null);
				break;
			case TSetNpcGroupPerformType.ISetNpcSupportedWalkingPerform:
				_o.PerformType.Value = ((this.PerformType<ISetNpcSupportedWalkingPerform>() != null) ? this.PerformType<ISetNpcSupportedWalkingPerform>().Value.UnPack() : null);
				break;
			case TSetNpcGroupPerformType.ISetNpcTwoPersonPerform:
				_o.PerformType.Value = ((this.PerformType<ISetNpcTwoPersonPerform>() != null) ? this.PerformType<ISetNpcTwoPersonPerform>().Value.UnPack() : null);
				break;
			}
			_o.IsWaitActionFinish = this.IsWaitActionFinish;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06035F4C RID: 221004 RVA: 0x0073A554 File Offset: 0x00738754
		public static Offset<ISetNpcGroupPerform> Pack(FlatBufferBuilder builder, ISetNpcGroupPerformT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetNpcGroupPerform>);
			}
			StringOffset keyOffset = (_o.Key == null) ? default(StringOffset) : builder.CreateString(_o.Key);
			TSetNpcGroupPerformType performType_type = (_o.PerformType == null) ? TSetNpcGroupPerformType.NONE : _o.PerformType.Type;
			int performTypeOffset = (_o.PerformType == null) ? 0 : TSetNpcGroupPerformTypeUnion.Pack(builder, _o.PerformType);
			return ISetNpcGroupPerform.CreateISetNpcGroupPerform(builder, keyOffset, performType_type, performTypeOffset, _o.IsWaitActionFinish, _o.NullMask);
		}

		// Token: 0x04012A42 RID: 76354
		private Table __p;
	}
}
