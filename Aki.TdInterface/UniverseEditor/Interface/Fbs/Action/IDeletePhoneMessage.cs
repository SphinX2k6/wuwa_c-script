using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BD8 RID: 27608
	public struct IDeletePhoneMessage : IFlatbufferObject
	{
		// Token: 0x1700CA7F RID: 51839
		// (get) Token: 0x0602F84A RID: 194634 RVA: 0x0067A91A File Offset: 0x00678B1A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F84B RID: 194635 RVA: 0x0067A927 File Offset: 0x00678B27
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F84C RID: 194636 RVA: 0x0067A930 File Offset: 0x00678B30
		public static IDeletePhoneMessage GetRootAsIDeletePhoneMessage(ByteBuffer _bb)
		{
			return IDeletePhoneMessage.GetRootAsIDeletePhoneMessage(_bb, default(IDeletePhoneMessage));
		}

		// Token: 0x0602F84D RID: 194637 RVA: 0x0067A94C File Offset: 0x00678B4C
		public static IDeletePhoneMessage GetRootAsIDeletePhoneMessage(ByteBuffer _bb, IDeletePhoneMessage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F84E RID: 194638 RVA: 0x0067A969 File Offset: 0x00678B69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F84F RID: 194639 RVA: 0x0067A978 File Offset: 0x00678B78
		public IDeletePhoneMessage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CA80 RID: 51840
		// (get) Token: 0x0602F850 RID: 194640 RVA: 0x0067A988 File Offset: 0x00678B88
		public EPhoneSystemInteractType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPhoneSystemInteractType.SendPhoneMessage;
				}
				return (EPhoneSystemInteractType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CA81 RID: 51841
		// (get) Token: 0x0602F851 RID: 194641 RVA: 0x0067A9C4 File Offset: 0x00678BC4
		public int PhoneMessageId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CA82 RID: 51842
		// (get) Token: 0x0602F852 RID: 194642 RVA: 0x0067AA00 File Offset: 0x00678C00
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F853 RID: 194643 RVA: 0x0067AA3C File Offset: 0x00678C3C
		public static Offset<IDeletePhoneMessage> CreateIDeletePhoneMessage(FlatBufferBuilder builder, EPhoneSystemInteractType Type = EPhoneSystemInteractType.SendPhoneMessage, int PhoneMessageId = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			IDeletePhoneMessage.AddPhoneMessageId(builder, PhoneMessageId);
			IDeletePhoneMessage.AddNullMask(builder, NullMask);
			IDeletePhoneMessage.AddType(builder, Type);
			return IDeletePhoneMessage.EndIDeletePhoneMessage(builder);
		}

		// Token: 0x0602F854 RID: 194644 RVA: 0x0067AA60 File Offset: 0x00678C60
		public static void StartIDeletePhoneMessage(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602F855 RID: 194645 RVA: 0x0067AA69 File Offset: 0x00678C69
		public static void AddType(FlatBufferBuilder builder, EPhoneSystemInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F856 RID: 194646 RVA: 0x0067AA74 File Offset: 0x00678C74
		public static void AddPhoneMessageId(FlatBufferBuilder builder, int phoneMessageId)
		{
			builder.AddInt(1, phoneMessageId, 0);
		}

		// Token: 0x0602F857 RID: 194647 RVA: 0x0067AA7F File Offset: 0x00678C7F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602F858 RID: 194648 RVA: 0x0067AA8A File Offset: 0x00678C8A
		public static Offset<IDeletePhoneMessage> EndIDeletePhoneMessage(FlatBufferBuilder builder)
		{
			return new Offset<IDeletePhoneMessage>(builder.EndTable());
		}

		// Token: 0x0602F859 RID: 194649 RVA: 0x0067AA98 File Offset: 0x00678C98
		public IDeletePhoneMessageT UnPack()
		{
			IDeletePhoneMessageT deletePhoneMessageT = new IDeletePhoneMessageT();
			this.UnPackTo(deletePhoneMessageT);
			return deletePhoneMessageT;
		}

		// Token: 0x0602F85A RID: 194650 RVA: 0x0067AAB3 File Offset: 0x00678CB3
		public void UnPackTo(IDeletePhoneMessageT _o)
		{
			_o.Type = this.Type;
			_o.PhoneMessageId = this.PhoneMessageId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602F85B RID: 194651 RVA: 0x0067AADC File Offset: 0x00678CDC
		public static Offset<IDeletePhoneMessage> Pack(FlatBufferBuilder builder, IDeletePhoneMessageT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDeletePhoneMessage>);
			}
			return IDeletePhoneMessage.CreateIDeletePhoneMessage(builder, _o.Type, _o.PhoneMessageId, _o.NullMask);
		}

		// Token: 0x040119D9 RID: 72153
		private Table __p;
	}
}
