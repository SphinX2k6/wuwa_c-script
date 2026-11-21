using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007418 RID: 29720
	public struct IPhoneMessageBoardConfig : IFlatbufferObject
	{
		// Token: 0x1700DA50 RID: 55888
		// (get) Token: 0x06033FF4 RID: 212980 RVA: 0x007022A6 File Offset: 0x007004A6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033FF5 RID: 212981 RVA: 0x007022B3 File Offset: 0x007004B3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033FF6 RID: 212982 RVA: 0x007022BC File Offset: 0x007004BC
		public static IPhoneMessageBoardConfig GetRootAsIPhoneMessageBoardConfig(ByteBuffer _bb)
		{
			return IPhoneMessageBoardConfig.GetRootAsIPhoneMessageBoardConfig(_bb, default(IPhoneMessageBoardConfig));
		}

		// Token: 0x06033FF7 RID: 212983 RVA: 0x007022D8 File Offset: 0x007004D8
		public static IPhoneMessageBoardConfig GetRootAsIPhoneMessageBoardConfig(ByteBuffer _bb, IPhoneMessageBoardConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033FF8 RID: 212984 RVA: 0x007022F5 File Offset: 0x007004F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033FF9 RID: 212985 RVA: 0x00702304 File Offset: 0x00700504
		public IPhoneMessageBoardConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DA51 RID: 55889
		// (get) Token: 0x06033FFA RID: 212986 RVA: 0x00702314 File Offset: 0x00700514
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

		// Token: 0x1700DA52 RID: 55890
		// (get) Token: 0x06033FFB RID: 212987 RVA: 0x00702350 File Offset: 0x00700550
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

		// Token: 0x06033FFC RID: 212988 RVA: 0x0070238C File Offset: 0x0070058C
		public static Offset<IPhoneMessageBoardConfig> CreateIPhoneMessageBoardConfig(FlatBufferBuilder builder, int PhoneMessageId = 0, byte NullMask = 0)
		{
			builder.StartTable(2);
			IPhoneMessageBoardConfig.AddPhoneMessageId(builder, PhoneMessageId);
			IPhoneMessageBoardConfig.AddNullMask(builder, NullMask);
			return IPhoneMessageBoardConfig.EndIPhoneMessageBoardConfig(builder);
		}

		// Token: 0x06033FFD RID: 212989 RVA: 0x007023A9 File Offset: 0x007005A9
		public static void StartIPhoneMessageBoardConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06033FFE RID: 212990 RVA: 0x007023B2 File Offset: 0x007005B2
		public static void AddPhoneMessageId(FlatBufferBuilder builder, int phoneMessageId)
		{
			builder.AddInt(0, phoneMessageId, 0);
		}

		// Token: 0x06033FFF RID: 212991 RVA: 0x007023BD File Offset: 0x007005BD
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x06034000 RID: 212992 RVA: 0x007023C8 File Offset: 0x007005C8
		public static Offset<IPhoneMessageBoardConfig> EndIPhoneMessageBoardConfig(FlatBufferBuilder builder)
		{
			return new Offset<IPhoneMessageBoardConfig>(builder.EndTable());
		}

		// Token: 0x06034001 RID: 212993 RVA: 0x007023D8 File Offset: 0x007005D8
		public IPhoneMessageBoardConfigT UnPack()
		{
			IPhoneMessageBoardConfigT phoneMessageBoardConfigT = new IPhoneMessageBoardConfigT();
			this.UnPackTo(phoneMessageBoardConfigT);
			return phoneMessageBoardConfigT;
		}

		// Token: 0x06034002 RID: 212994 RVA: 0x007023F3 File Offset: 0x007005F3
		public void UnPackTo(IPhoneMessageBoardConfigT _o)
		{
			_o.PhoneMessageId = this.PhoneMessageId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06034003 RID: 212995 RVA: 0x00702410 File Offset: 0x00700610
		public static Offset<IPhoneMessageBoardConfig> Pack(FlatBufferBuilder builder, IPhoneMessageBoardConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPhoneMessageBoardConfig>);
			}
			return IPhoneMessageBoardConfig.CreateIPhoneMessageBoardConfig(builder, _o.PhoneMessageId, _o.NullMask);
		}

		// Token: 0x0401256B RID: 75115
		private Table __p;
	}
}
