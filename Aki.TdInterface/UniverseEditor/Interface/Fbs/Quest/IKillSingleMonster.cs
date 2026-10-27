using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003ECC RID: 16076
	public struct IKillSingleMonster : IFlatbufferObject
	{
		// Token: 0x17006F9F RID: 28575
		// (get) Token: 0x06016BC7 RID: 93127 RVA: 0x0034869B File Offset: 0x0034689B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016BC8 RID: 93128 RVA: 0x003486A8 File Offset: 0x003468A8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016BC9 RID: 93129 RVA: 0x003486B0 File Offset: 0x003468B0
		public static IKillSingleMonster GetRootAsIKillSingleMonster(ByteBuffer _bb)
		{
			return IKillSingleMonster.GetRootAsIKillSingleMonster(_bb, default(IKillSingleMonster));
		}

		// Token: 0x06016BCA RID: 93130 RVA: 0x003486CC File Offset: 0x003468CC
		public static IKillSingleMonster GetRootAsIKillSingleMonster(ByteBuffer _bb, IKillSingleMonster obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016BCB RID: 93131 RVA: 0x003486E9 File Offset: 0x003468E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016BCC RID: 93132 RVA: 0x003486F8 File Offset: 0x003468F8
		public IKillSingleMonster __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006FA0 RID: 28576
		// (get) Token: 0x06016BCD RID: 93133 RVA: 0x00348708 File Offset: 0x00346908
		public int EntityId
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

		// Token: 0x17006FA1 RID: 28577
		// (get) Token: 0x06016BCE RID: 93134 RVA: 0x00348744 File Offset: 0x00346944
		public int AddTime
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

		// Token: 0x06016BCF RID: 93135 RVA: 0x00348780 File Offset: 0x00346980
		public static Offset<IKillSingleMonster> CreateIKillSingleMonster(FlatBufferBuilder builder, int EntityId = 0, int AddTime = 0)
		{
			builder.StartTable(2);
			IKillSingleMonster.AddAddTime(builder, AddTime);
			IKillSingleMonster.AddEntityId(builder, EntityId);
			return IKillSingleMonster.EndIKillSingleMonster(builder);
		}

		// Token: 0x06016BD0 RID: 93136 RVA: 0x0034879D File Offset: 0x0034699D
		public static void StartIKillSingleMonster(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06016BD1 RID: 93137 RVA: 0x003487A6 File Offset: 0x003469A6
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x06016BD2 RID: 93138 RVA: 0x003487B1 File Offset: 0x003469B1
		public static void AddAddTime(FlatBufferBuilder builder, int addTime)
		{
			builder.AddInt(1, addTime, 0);
		}

		// Token: 0x06016BD3 RID: 93139 RVA: 0x003487BC File Offset: 0x003469BC
		public static Offset<IKillSingleMonster> EndIKillSingleMonster(FlatBufferBuilder builder)
		{
			return new Offset<IKillSingleMonster>(builder.EndTable());
		}

		// Token: 0x06016BD4 RID: 93140 RVA: 0x003487CC File Offset: 0x003469CC
		public IKillSingleMonsterT UnPack()
		{
			IKillSingleMonsterT killSingleMonsterT = new IKillSingleMonsterT();
			this.UnPackTo(killSingleMonsterT);
			return killSingleMonsterT;
		}

		// Token: 0x06016BD5 RID: 93141 RVA: 0x003487E7 File Offset: 0x003469E7
		public void UnPackTo(IKillSingleMonsterT _o)
		{
			_o.EntityId = this.EntityId;
			_o.AddTime = this.AddTime;
		}

		// Token: 0x06016BD6 RID: 93142 RVA: 0x00348804 File Offset: 0x00346A04
		public static Offset<IKillSingleMonster> Pack(FlatBufferBuilder builder, IKillSingleMonsterT _o)
		{
			if (_o == null)
			{
				return default(Offset<IKillSingleMonster>);
			}
			return IKillSingleMonster.CreateIKillSingleMonster(builder, _o.EntityId, _o.AddTime);
		}

		// Token: 0x0400B8A9 RID: 47273
		private Table __p;
	}
}
