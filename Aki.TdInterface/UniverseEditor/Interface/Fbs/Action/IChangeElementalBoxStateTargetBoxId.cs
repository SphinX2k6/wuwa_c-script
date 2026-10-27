using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062DB RID: 25307
	public struct IChangeElementalBoxStateTargetBoxId : IFlatbufferObject
	{
		// Token: 0x1700BCE3 RID: 48355
		// (get) Token: 0x0602BBE3 RID: 179171 RVA: 0x00604C39 File Offset: 0x00602E39
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BBE4 RID: 179172 RVA: 0x00604C46 File Offset: 0x00602E46
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BBE5 RID: 179173 RVA: 0x00604C50 File Offset: 0x00602E50
		public static IChangeElementalBoxStateTargetBoxId GetRootAsIChangeElementalBoxStateTargetBoxId(ByteBuffer _bb)
		{
			return IChangeElementalBoxStateTargetBoxId.GetRootAsIChangeElementalBoxStateTargetBoxId(_bb, default(IChangeElementalBoxStateTargetBoxId));
		}

		// Token: 0x0602BBE6 RID: 179174 RVA: 0x00604C6C File Offset: 0x00602E6C
		public static IChangeElementalBoxStateTargetBoxId GetRootAsIChangeElementalBoxStateTargetBoxId(ByteBuffer _bb, IChangeElementalBoxStateTargetBoxId obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BBE7 RID: 179175 RVA: 0x00604C89 File Offset: 0x00602E89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BBE8 RID: 179176 RVA: 0x00604C98 File Offset: 0x00602E98
		public IChangeElementalBoxStateTargetBoxId __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BCE4 RID: 48356
		// (get) Token: 0x0602BBE9 RID: 179177 RVA: 0x00604CA8 File Offset: 0x00602EA8
		public EChangeElementalBoxStateTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EChangeElementalBoxStateTargetType.Player;
				}
				return (EChangeElementalBoxStateTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BCE5 RID: 48357
		// (get) Token: 0x0602BBEA RID: 179178 RVA: 0x00604CE4 File Offset: 0x00602EE4
		public int TargetBoxId
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

		// Token: 0x0602BBEB RID: 179179 RVA: 0x00604D20 File Offset: 0x00602F20
		public static Offset<IChangeElementalBoxStateTargetBoxId> CreateIChangeElementalBoxStateTargetBoxId(FlatBufferBuilder builder, EChangeElementalBoxStateTargetType Type = EChangeElementalBoxStateTargetType.Player, int TargetBoxId = 0)
		{
			builder.StartTable(2);
			IChangeElementalBoxStateTargetBoxId.AddTargetBoxId(builder, TargetBoxId);
			IChangeElementalBoxStateTargetBoxId.AddType(builder, Type);
			return IChangeElementalBoxStateTargetBoxId.EndIChangeElementalBoxStateTargetBoxId(builder);
		}

		// Token: 0x0602BBEC RID: 179180 RVA: 0x00604D3D File Offset: 0x00602F3D
		public static void StartIChangeElementalBoxStateTargetBoxId(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602BBED RID: 179181 RVA: 0x00604D46 File Offset: 0x00602F46
		public static void AddType(FlatBufferBuilder builder, EChangeElementalBoxStateTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602BBEE RID: 179182 RVA: 0x00604D51 File Offset: 0x00602F51
		public static void AddTargetBoxId(FlatBufferBuilder builder, int targetBoxId)
		{
			builder.AddInt(1, targetBoxId, 0);
		}

		// Token: 0x0602BBEF RID: 179183 RVA: 0x00604D5C File Offset: 0x00602F5C
		public static Offset<IChangeElementalBoxStateTargetBoxId> EndIChangeElementalBoxStateTargetBoxId(FlatBufferBuilder builder)
		{
			return new Offset<IChangeElementalBoxStateTargetBoxId>(builder.EndTable());
		}

		// Token: 0x0602BBF0 RID: 179184 RVA: 0x00604D6C File Offset: 0x00602F6C
		public IChangeElementalBoxStateTargetBoxIdT UnPack()
		{
			IChangeElementalBoxStateTargetBoxIdT changeElementalBoxStateTargetBoxIdT = new IChangeElementalBoxStateTargetBoxIdT();
			this.UnPackTo(changeElementalBoxStateTargetBoxIdT);
			return changeElementalBoxStateTargetBoxIdT;
		}

		// Token: 0x0602BBF1 RID: 179185 RVA: 0x00604D87 File Offset: 0x00602F87
		public void UnPackTo(IChangeElementalBoxStateTargetBoxIdT _o)
		{
			_o.Type = this.Type;
			_o.TargetBoxId = this.TargetBoxId;
		}

		// Token: 0x0602BBF2 RID: 179186 RVA: 0x00604DA4 File Offset: 0x00602FA4
		public static Offset<IChangeElementalBoxStateTargetBoxId> Pack(FlatBufferBuilder builder, IChangeElementalBoxStateTargetBoxIdT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangeElementalBoxStateTargetBoxId>);
			}
			return IChangeElementalBoxStateTargetBoxId.CreateIChangeElementalBoxStateTargetBoxId(builder, _o.Type, _o.TargetBoxId);
		}

		// Token: 0x04010881 RID: 67713
		private Table __p;
	}
}
