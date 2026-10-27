using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CA2 RID: 27810
	public struct IPhoneMessageBoardConfig : IFlatbufferObject
	{
		// Token: 0x1700CF13 RID: 53011
		// (get) Token: 0x0603101D RID: 200733 RVA: 0x006A7072 File Offset: 0x006A5272
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603101E RID: 200734 RVA: 0x006A707F File Offset: 0x006A527F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603101F RID: 200735 RVA: 0x006A7088 File Offset: 0x006A5288
		public static IPhoneMessageBoardConfig GetRootAsIPhoneMessageBoardConfig(ByteBuffer _bb)
		{
			return IPhoneMessageBoardConfig.GetRootAsIPhoneMessageBoardConfig(_bb, default(IPhoneMessageBoardConfig));
		}

		// Token: 0x06031020 RID: 200736 RVA: 0x006A70A4 File Offset: 0x006A52A4
		public static IPhoneMessageBoardConfig GetRootAsIPhoneMessageBoardConfig(ByteBuffer _bb, IPhoneMessageBoardConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031021 RID: 200737 RVA: 0x006A70C1 File Offset: 0x006A52C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031022 RID: 200738 RVA: 0x006A70D0 File Offset: 0x006A52D0
		public IPhoneMessageBoardConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CF14 RID: 53012
		// (get) Token: 0x06031023 RID: 200739 RVA: 0x006A70E0 File Offset: 0x006A52E0
		public int PhoneMessageId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CF15 RID: 53013
		// (get) Token: 0x06031024 RID: 200740 RVA: 0x006A711C File Offset: 0x006A531C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031025 RID: 200741 RVA: 0x006A7158 File Offset: 0x006A5358
		public static Offset<IPhoneMessageBoardConfig> CreateIPhoneMessageBoardConfig(FlatBufferBuilder builder, int PhoneMessageId = 0, byte NullMask = 0)
		{
			builder.StartTable(2);
			IPhoneMessageBoardConfig.AddPhoneMessageId(builder, PhoneMessageId);
			IPhoneMessageBoardConfig.AddNullMask(builder, NullMask);
			return IPhoneMessageBoardConfig.EndIPhoneMessageBoardConfig(builder);
		}

		// Token: 0x06031026 RID: 200742 RVA: 0x006A7175 File Offset: 0x006A5375
		public static void StartIPhoneMessageBoardConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031027 RID: 200743 RVA: 0x006A717E File Offset: 0x006A537E
		public static void AddPhoneMessageId(FlatBufferBuilder builder, int phoneMessageId)
		{
			builder.AddInt(0, phoneMessageId, 0);
		}

		// Token: 0x06031028 RID: 200744 RVA: 0x006A7189 File Offset: 0x006A5389
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x06031029 RID: 200745 RVA: 0x006A7194 File Offset: 0x006A5394
		public static Offset<IPhoneMessageBoardConfig> EndIPhoneMessageBoardConfig(FlatBufferBuilder builder)
		{
			return new Offset<IPhoneMessageBoardConfig>(builder.EndTable());
		}

		// Token: 0x0603102A RID: 200746 RVA: 0x006A71A4 File Offset: 0x006A53A4
		public IPhoneMessageBoardConfigT UnPack()
		{
			IPhoneMessageBoardConfigT phoneMessageBoardConfigT = new IPhoneMessageBoardConfigT();
			this.UnPackTo(phoneMessageBoardConfigT);
			return phoneMessageBoardConfigT;
		}

		// Token: 0x0603102B RID: 200747 RVA: 0x006A71BF File Offset: 0x006A53BF
		public void UnPackTo(IPhoneMessageBoardConfigT _o)
		{
			_o.PhoneMessageId = this.PhoneMessageId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603102C RID: 200748 RVA: 0x006A71DC File Offset: 0x006A53DC
		public static Offset<IPhoneMessageBoardConfig> Pack(FlatBufferBuilder builder, IPhoneMessageBoardConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPhoneMessageBoardConfig>);
			}
			return IPhoneMessageBoardConfig.CreateIPhoneMessageBoardConfig(builder, _o.PhoneMessageId, _o.NullMask);
		}

		// Token: 0x040115FB RID: 71163
		private Table __p;
	}
}
