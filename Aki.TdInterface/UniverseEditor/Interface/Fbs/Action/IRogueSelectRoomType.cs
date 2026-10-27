using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EF1 RID: 28401
	public struct IRogueSelectRoomType : IFlatbufferObject
	{
		// Token: 0x1700D347 RID: 54087
		// (get) Token: 0x060322FF RID: 205567 RVA: 0x006C83E3 File Offset: 0x006C65E3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032300 RID: 205568 RVA: 0x006C83F0 File Offset: 0x006C65F0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032301 RID: 205569 RVA: 0x006C83F8 File Offset: 0x006C65F8
		public static IRogueSelectRoomType GetRootAsIRogueSelectRoomType(ByteBuffer _bb)
		{
			return IRogueSelectRoomType.GetRootAsIRogueSelectRoomType(_bb, default(IRogueSelectRoomType));
		}

		// Token: 0x06032302 RID: 205570 RVA: 0x006C8414 File Offset: 0x006C6614
		public static IRogueSelectRoomType GetRootAsIRogueSelectRoomType(ByteBuffer _bb, IRogueSelectRoomType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032303 RID: 205571 RVA: 0x006C8431 File Offset: 0x006C6631
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032304 RID: 205572 RVA: 0x006C8440 File Offset: 0x006C6640
		public IRogueSelectRoomType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D348 RID: 54088
		// (get) Token: 0x06032305 RID: 205573 RVA: 0x006C8450 File Offset: 0x006C6650
		public ERogueSelectRoomType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERogueSelectRoomType.Role;
				}
				return (ERogueSelectRoomType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032306 RID: 205574 RVA: 0x006C848C File Offset: 0x006C668C
		public static Offset<IRogueSelectRoomType> CreateIRogueSelectRoomType(FlatBufferBuilder builder, ERogueSelectRoomType Type = ERogueSelectRoomType.Role)
		{
			builder.StartTable(1);
			IRogueSelectRoomType.AddType(builder, Type);
			return IRogueSelectRoomType.EndIRogueSelectRoomType(builder);
		}

		// Token: 0x06032307 RID: 205575 RVA: 0x006C84A2 File Offset: 0x006C66A2
		public static void StartIRogueSelectRoomType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06032308 RID: 205576 RVA: 0x006C84AB File Offset: 0x006C66AB
		public static void AddType(FlatBufferBuilder builder, ERogueSelectRoomType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032309 RID: 205577 RVA: 0x006C84B6 File Offset: 0x006C66B6
		public static Offset<IRogueSelectRoomType> EndIRogueSelectRoomType(FlatBufferBuilder builder)
		{
			return new Offset<IRogueSelectRoomType>(builder.EndTable());
		}

		// Token: 0x0603230A RID: 205578 RVA: 0x006C84C4 File Offset: 0x006C66C4
		public IRogueSelectRoomTypeT UnPack()
		{
			IRogueSelectRoomTypeT rogueSelectRoomTypeT = new IRogueSelectRoomTypeT();
			this.UnPackTo(rogueSelectRoomTypeT);
			return rogueSelectRoomTypeT;
		}

		// Token: 0x0603230B RID: 205579 RVA: 0x006C84DF File Offset: 0x006C66DF
		public void UnPackTo(IRogueSelectRoomTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603230C RID: 205580 RVA: 0x006C84F0 File Offset: 0x006C66F0
		public static Offset<IRogueSelectRoomType> Pack(FlatBufferBuilder builder, IRogueSelectRoomTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRogueSelectRoomType>);
			}
			return IRogueSelectRoomType.CreateIRogueSelectRoomType(builder, _o.Type);
		}

		// Token: 0x040118E4 RID: 71908
		private Table __p;
	}
}
