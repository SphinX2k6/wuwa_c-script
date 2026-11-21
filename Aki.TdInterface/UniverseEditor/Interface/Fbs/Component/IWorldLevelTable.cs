using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061AE RID: 25006
	public struct IWorldLevelTable : IFlatbufferObject
	{
		// Token: 0x1700BA79 RID: 47737
		// (get) Token: 0x0602A809 RID: 174089 RVA: 0x005CC088 File Offset: 0x005CA288
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A80A RID: 174090 RVA: 0x005CC095 File Offset: 0x005CA295
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A80B RID: 174091 RVA: 0x005CC09C File Offset: 0x005CA29C
		public static IWorldLevelTable GetRootAsIWorldLevelTable(ByteBuffer _bb)
		{
			return IWorldLevelTable.GetRootAsIWorldLevelTable(_bb, default(IWorldLevelTable));
		}

		// Token: 0x0602A80C RID: 174092 RVA: 0x005CC0B8 File Offset: 0x005CA2B8
		public static IWorldLevelTable GetRootAsIWorldLevelTable(ByteBuffer _bb, IWorldLevelTable obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A80D RID: 174093 RVA: 0x005CC0D5 File Offset: 0x005CA2D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A80E RID: 174094 RVA: 0x005CC0E4 File Offset: 0x005CA2E4
		public IWorldLevelTable __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BA7A RID: 47738
		// (get) Token: 0x0602A80F RID: 174095 RVA: 0x005CC0F4 File Offset: 0x005CA2F4
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

		// Token: 0x1700BA7B RID: 47739
		// (get) Token: 0x0602A810 RID: 174096 RVA: 0x005CC130 File Offset: 0x005CA330
		public int WorldLevelBonusId
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

		// Token: 0x1700BA7C RID: 47740
		// (get) Token: 0x0602A811 RID: 174097 RVA: 0x005CC16C File Offset: 0x005CA36C
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

		// Token: 0x0602A812 RID: 174098 RVA: 0x005CC1A8 File Offset: 0x005CA3A8
		public static Offset<IWorldLevelTable> CreateIWorldLevelTable(FlatBufferBuilder builder, EWorldLevelBonus Type = EWorldLevelBonus.WorldLevelTable, int WorldLevelBonusId = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			IWorldLevelTable.AddWorldLevelBonusId(builder, WorldLevelBonusId);
			IWorldLevelTable.AddNullMask(builder, NullMask);
			IWorldLevelTable.AddType(builder, Type);
			return IWorldLevelTable.EndIWorldLevelTable(builder);
		}

		// Token: 0x0602A813 RID: 174099 RVA: 0x005CC1CC File Offset: 0x005CA3CC
		public static void StartIWorldLevelTable(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602A814 RID: 174100 RVA: 0x005CC1D5 File Offset: 0x005CA3D5
		public static void AddType(FlatBufferBuilder builder, EWorldLevelBonus type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A815 RID: 174101 RVA: 0x005CC1E0 File Offset: 0x005CA3E0
		public static void AddWorldLevelBonusId(FlatBufferBuilder builder, int worldLevelBonusId)
		{
			builder.AddInt(1, worldLevelBonusId, 0);
		}

		// Token: 0x0602A816 RID: 174102 RVA: 0x005CC1EB File Offset: 0x005CA3EB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602A817 RID: 174103 RVA: 0x005CC1F6 File Offset: 0x005CA3F6
		public static Offset<IWorldLevelTable> EndIWorldLevelTable(FlatBufferBuilder builder)
		{
			return new Offset<IWorldLevelTable>(builder.EndTable());
		}

		// Token: 0x0602A818 RID: 174104 RVA: 0x005CC204 File Offset: 0x005CA404
		public IWorldLevelTableT UnPack()
		{
			IWorldLevelTableT worldLevelTableT = new IWorldLevelTableT();
			this.UnPackTo(worldLevelTableT);
			return worldLevelTableT;
		}

		// Token: 0x0602A819 RID: 174105 RVA: 0x005CC21F File Offset: 0x005CA41F
		public void UnPackTo(IWorldLevelTableT _o)
		{
			_o.Type = this.Type;
			_o.WorldLevelBonusId = this.WorldLevelBonusId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602A81A RID: 174106 RVA: 0x005CC248 File Offset: 0x005CA448
		public static Offset<IWorldLevelTable> Pack(FlatBufferBuilder builder, IWorldLevelTableT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWorldLevelTable>);
			}
			return IWorldLevelTable.CreateIWorldLevelTable(builder, _o.Type, _o.WorldLevelBonusId, _o.NullMask);
		}

		// Token: 0x04010003 RID: 65539
		private Table __p;
	}
}
