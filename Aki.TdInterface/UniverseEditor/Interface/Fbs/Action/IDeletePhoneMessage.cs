using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006567 RID: 25959
	public struct IDeletePhoneMessage : IFlatbufferObject
	{
		// Token: 0x1700C0E4 RID: 49380
		// (get) Token: 0x0602D08E RID: 184462 RVA: 0x0062E156 File Offset: 0x0062C356
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D08F RID: 184463 RVA: 0x0062E163 File Offset: 0x0062C363
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D090 RID: 184464 RVA: 0x0062E16C File Offset: 0x0062C36C
		public static IDeletePhoneMessage GetRootAsIDeletePhoneMessage(ByteBuffer _bb)
		{
			return IDeletePhoneMessage.GetRootAsIDeletePhoneMessage(_bb, default(IDeletePhoneMessage));
		}

		// Token: 0x0602D091 RID: 184465 RVA: 0x0062E188 File Offset: 0x0062C388
		public static IDeletePhoneMessage GetRootAsIDeletePhoneMessage(ByteBuffer _bb, IDeletePhoneMessage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D092 RID: 184466 RVA: 0x0062E1A5 File Offset: 0x0062C3A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D093 RID: 184467 RVA: 0x0062E1B4 File Offset: 0x0062C3B4
		public IDeletePhoneMessage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C0E5 RID: 49381
		// (get) Token: 0x0602D094 RID: 184468 RVA: 0x0062E1C4 File Offset: 0x0062C3C4
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

		// Token: 0x1700C0E6 RID: 49382
		// (get) Token: 0x0602D095 RID: 184469 RVA: 0x0062E200 File Offset: 0x0062C400
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

		// Token: 0x1700C0E7 RID: 49383
		// (get) Token: 0x0602D096 RID: 184470 RVA: 0x0062E23C File Offset: 0x0062C43C
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

		// Token: 0x0602D097 RID: 184471 RVA: 0x0062E278 File Offset: 0x0062C478
		public static Offset<IDeletePhoneMessage> CreateIDeletePhoneMessage(FlatBufferBuilder builder, EPhoneSystemInteractType Type = EPhoneSystemInteractType.SendPhoneMessage, int PhoneMessageId = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			IDeletePhoneMessage.AddPhoneMessageId(builder, PhoneMessageId);
			IDeletePhoneMessage.AddNullMask(builder, NullMask);
			IDeletePhoneMessage.AddType(builder, Type);
			return IDeletePhoneMessage.EndIDeletePhoneMessage(builder);
		}

		// Token: 0x0602D098 RID: 184472 RVA: 0x0062E29C File Offset: 0x0062C49C
		public static void StartIDeletePhoneMessage(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602D099 RID: 184473 RVA: 0x0062E2A5 File Offset: 0x0062C4A5
		public static void AddType(FlatBufferBuilder builder, EPhoneSystemInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D09A RID: 184474 RVA: 0x0062E2B0 File Offset: 0x0062C4B0
		public static void AddPhoneMessageId(FlatBufferBuilder builder, int phoneMessageId)
		{
			builder.AddInt(1, phoneMessageId, 0);
		}

		// Token: 0x0602D09B RID: 184475 RVA: 0x0062E2BB File Offset: 0x0062C4BB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602D09C RID: 184476 RVA: 0x0062E2C6 File Offset: 0x0062C4C6
		public static Offset<IDeletePhoneMessage> EndIDeletePhoneMessage(FlatBufferBuilder builder)
		{
			return new Offset<IDeletePhoneMessage>(builder.EndTable());
		}

		// Token: 0x0602D09D RID: 184477 RVA: 0x0062E2D4 File Offset: 0x0062C4D4
		public IDeletePhoneMessageT UnPack()
		{
			IDeletePhoneMessageT deletePhoneMessageT = new IDeletePhoneMessageT();
			this.UnPackTo(deletePhoneMessageT);
			return deletePhoneMessageT;
		}

		// Token: 0x0602D09E RID: 184478 RVA: 0x0062E2EF File Offset: 0x0062C4EF
		public void UnPackTo(IDeletePhoneMessageT _o)
		{
			_o.Type = this.Type;
			_o.PhoneMessageId = this.PhoneMessageId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602D09F RID: 184479 RVA: 0x0062E318 File Offset: 0x0062C518
		public static Offset<IDeletePhoneMessage> Pack(FlatBufferBuilder builder, IDeletePhoneMessageT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDeletePhoneMessage>);
			}
			return IDeletePhoneMessage.CreateIDeletePhoneMessage(builder, _o.Type, _o.PhoneMessageId, _o.NullMask);
		}

		// Token: 0x04010BBB RID: 68539
		private Table __p;
	}
}
