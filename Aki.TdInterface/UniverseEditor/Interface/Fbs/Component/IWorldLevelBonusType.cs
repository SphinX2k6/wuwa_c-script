using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061A8 RID: 25000
	public struct IWorldLevelBonusType : IFlatbufferObject
	{
		// Token: 0x1700BA74 RID: 47732
		// (get) Token: 0x0602A7E9 RID: 174057 RVA: 0x005CBDC6 File Offset: 0x005C9FC6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A7EA RID: 174058 RVA: 0x005CBDD3 File Offset: 0x005C9FD3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A7EB RID: 174059 RVA: 0x005CBDDC File Offset: 0x005C9FDC
		public static IWorldLevelBonusType GetRootAsIWorldLevelBonusType(ByteBuffer _bb)
		{
			return IWorldLevelBonusType.GetRootAsIWorldLevelBonusType(_bb, default(IWorldLevelBonusType));
		}

		// Token: 0x0602A7EC RID: 174060 RVA: 0x005CBDF8 File Offset: 0x005C9FF8
		public static IWorldLevelBonusType GetRootAsIWorldLevelBonusType(ByteBuffer _bb, IWorldLevelBonusType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A7ED RID: 174061 RVA: 0x005CBE15 File Offset: 0x005CA015
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A7EE RID: 174062 RVA: 0x005CBE24 File Offset: 0x005CA024
		public IWorldLevelBonusType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BA75 RID: 47733
		// (get) Token: 0x0602A7EF RID: 174063 RVA: 0x005CBE34 File Offset: 0x005CA034
		public EWorldLevelBonus Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EWorldLevelBonus.WorldLevelTable;
				}
				return (EWorldLevelBonus)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602A7F0 RID: 174064 RVA: 0x005CBE70 File Offset: 0x005CA070
		public static Offset<IWorldLevelBonusType> CreateIWorldLevelBonusType(FlatBufferBuilder builder, EWorldLevelBonus Type = EWorldLevelBonus.WorldLevelTable)
		{
			builder.StartTable(1);
			IWorldLevelBonusType.AddType(builder, Type);
			return IWorldLevelBonusType.EndIWorldLevelBonusType(builder);
		}

		// Token: 0x0602A7F1 RID: 174065 RVA: 0x005CBE86 File Offset: 0x005CA086
		public static void StartIWorldLevelBonusType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602A7F2 RID: 174066 RVA: 0x005CBE8F File Offset: 0x005CA08F
		public static void AddType(FlatBufferBuilder builder, EWorldLevelBonus type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A7F3 RID: 174067 RVA: 0x005CBE9A File Offset: 0x005CA09A
		public static Offset<IWorldLevelBonusType> EndIWorldLevelBonusType(FlatBufferBuilder builder)
		{
			return new Offset<IWorldLevelBonusType>(builder.EndTable());
		}

		// Token: 0x0602A7F4 RID: 174068 RVA: 0x005CBEA8 File Offset: 0x005CA0A8
		public IWorldLevelBonusTypeT UnPack()
		{
			IWorldLevelBonusTypeT worldLevelBonusTypeT = new IWorldLevelBonusTypeT();
			this.UnPackTo(worldLevelBonusTypeT);
			return worldLevelBonusTypeT;
		}

		// Token: 0x0602A7F5 RID: 174069 RVA: 0x005CBEC3 File Offset: 0x005CA0C3
		public void UnPackTo(IWorldLevelBonusTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602A7F6 RID: 174070 RVA: 0x005CBED4 File Offset: 0x005CA0D4
		public static Offset<IWorldLevelBonusType> Pack(FlatBufferBuilder builder, IWorldLevelBonusTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWorldLevelBonusType>);
			}
			return IWorldLevelBonusType.CreateIWorldLevelBonusType(builder, _o.Type);
		}

		// Token: 0x0400FFFA RID: 65530
		private Table __p;
	}
}
