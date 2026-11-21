using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200430A RID: 17162
	public struct IKillSingleMonster : IFlatbufferObject
	{
		// Token: 0x1700758E RID: 30094
		// (get) Token: 0x0601821E RID: 98846 RVA: 0x00371867 File Offset: 0x0036FA67
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601821F RID: 98847 RVA: 0x00371874 File Offset: 0x0036FA74
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018220 RID: 98848 RVA: 0x0037187C File Offset: 0x0036FA7C
		public static IKillSingleMonster GetRootAsIKillSingleMonster(ByteBuffer _bb)
		{
			return IKillSingleMonster.GetRootAsIKillSingleMonster(_bb, default(IKillSingleMonster));
		}

		// Token: 0x06018221 RID: 98849 RVA: 0x00371898 File Offset: 0x0036FA98
		public static IKillSingleMonster GetRootAsIKillSingleMonster(ByteBuffer _bb, IKillSingleMonster obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018222 RID: 98850 RVA: 0x003718B5 File Offset: 0x0036FAB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018223 RID: 98851 RVA: 0x003718C4 File Offset: 0x0036FAC4
		public IKillSingleMonster __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700758F RID: 30095
		// (get) Token: 0x06018224 RID: 98852 RVA: 0x003718D4 File Offset: 0x0036FAD4
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

		// Token: 0x17007590 RID: 30096
		// (get) Token: 0x06018225 RID: 98853 RVA: 0x00371910 File Offset: 0x0036FB10
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

		// Token: 0x06018226 RID: 98854 RVA: 0x0037194C File Offset: 0x0036FB4C
		public static Offset<IKillSingleMonster> CreateIKillSingleMonster(FlatBufferBuilder builder, int EntityId = 0, int AddTime = 0)
		{
			builder.StartTable(2);
			IKillSingleMonster.AddAddTime(builder, AddTime);
			IKillSingleMonster.AddEntityId(builder, EntityId);
			return IKillSingleMonster.EndIKillSingleMonster(builder);
		}

		// Token: 0x06018227 RID: 98855 RVA: 0x00371969 File Offset: 0x0036FB69
		public static void StartIKillSingleMonster(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06018228 RID: 98856 RVA: 0x00371972 File Offset: 0x0036FB72
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x06018229 RID: 98857 RVA: 0x0037197D File Offset: 0x0036FB7D
		public static void AddAddTime(FlatBufferBuilder builder, int addTime)
		{
			builder.AddInt(1, addTime, 0);
		}

		// Token: 0x0601822A RID: 98858 RVA: 0x00371988 File Offset: 0x0036FB88
		public static Offset<IKillSingleMonster> EndIKillSingleMonster(FlatBufferBuilder builder)
		{
			return new Offset<IKillSingleMonster>(builder.EndTable());
		}

		// Token: 0x0601822B RID: 98859 RVA: 0x00371998 File Offset: 0x0036FB98
		public IKillSingleMonsterT UnPack()
		{
			IKillSingleMonsterT killSingleMonsterT = new IKillSingleMonsterT();
			this.UnPackTo(killSingleMonsterT);
			return killSingleMonsterT;
		}

		// Token: 0x0601822C RID: 98860 RVA: 0x003719B3 File Offset: 0x0036FBB3
		public void UnPackTo(IKillSingleMonsterT _o)
		{
			_o.EntityId = this.EntityId;
			_o.AddTime = this.AddTime;
		}

		// Token: 0x0601822D RID: 98861 RVA: 0x003719D0 File Offset: 0x0036FBD0
		public static Offset<IKillSingleMonster> Pack(FlatBufferBuilder builder, IKillSingleMonsterT _o)
		{
			if (_o == null)
			{
				return default(Offset<IKillSingleMonster>);
			}
			return IKillSingleMonster.CreateIKillSingleMonster(builder, _o.EntityId, _o.AddTime);
		}

		// Token: 0x0400C286 RID: 49798
		private Table __p;
	}
}
