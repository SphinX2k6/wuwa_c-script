using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x02004818 RID: 18456
	public struct IOccupationType : IFlatbufferObject
	{
		// Token: 0x170080D1 RID: 32977
		// (get) Token: 0x0601B4FF RID: 111871 RVA: 0x003DEAC7 File Offset: 0x003DCCC7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B500 RID: 111872 RVA: 0x003DEAD4 File Offset: 0x003DCCD4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B501 RID: 111873 RVA: 0x003DEADC File Offset: 0x003DCCDC
		public static IOccupationType GetRootAsIOccupationType(ByteBuffer _bb)
		{
			return IOccupationType.GetRootAsIOccupationType(_bb, default(IOccupationType));
		}

		// Token: 0x0601B502 RID: 111874 RVA: 0x003DEAF8 File Offset: 0x003DCCF8
		public static IOccupationType GetRootAsIOccupationType(ByteBuffer _bb, IOccupationType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B503 RID: 111875 RVA: 0x003DEB15 File Offset: 0x003DCD15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B504 RID: 111876 RVA: 0x003DEB24 File Offset: 0x003DCD24
		public IOccupationType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170080D2 RID: 32978
		// (get) Token: 0x0601B505 RID: 111877 RVA: 0x003DEB34 File Offset: 0x003DCD34
		public EOccupationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EOccupationType.Npc;
				}
				return (EOccupationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B506 RID: 111878 RVA: 0x003DEB70 File Offset: 0x003DCD70
		public static Offset<IOccupationType> CreateIOccupationType(FlatBufferBuilder builder, EOccupationType Type = EOccupationType.Npc)
		{
			builder.StartTable(1);
			IOccupationType.AddType(builder, Type);
			return IOccupationType.EndIOccupationType(builder);
		}

		// Token: 0x0601B507 RID: 111879 RVA: 0x003DEB86 File Offset: 0x003DCD86
		public static void StartIOccupationType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601B508 RID: 111880 RVA: 0x003DEB8F File Offset: 0x003DCD8F
		public static void AddType(FlatBufferBuilder builder, EOccupationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B509 RID: 111881 RVA: 0x003DEB9A File Offset: 0x003DCD9A
		public static Offset<IOccupationType> EndIOccupationType(FlatBufferBuilder builder)
		{
			return new Offset<IOccupationType>(builder.EndTable());
		}

		// Token: 0x0601B50A RID: 111882 RVA: 0x003DEBA8 File Offset: 0x003DCDA8
		public IOccupationTypeT UnPack()
		{
			IOccupationTypeT occupationTypeT = new IOccupationTypeT();
			this.UnPackTo(occupationTypeT);
			return occupationTypeT;
		}

		// Token: 0x0601B50B RID: 111883 RVA: 0x003DEBC3 File Offset: 0x003DCDC3
		public void UnPackTo(IOccupationTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601B50C RID: 111884 RVA: 0x003DEBD4 File Offset: 0x003DCDD4
		public static Offset<IOccupationType> Pack(FlatBufferBuilder builder, IOccupationTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOccupationType>);
			}
			return IOccupationType.CreateIOccupationType(builder, _o.Type);
		}

		// Token: 0x0400CC16 RID: 52246
		private Table __p;
	}
}
