using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046A6 RID: 18086
	public struct IUseSkillCheckByFollowShooterSkillId : IFlatbufferObject
	{
		// Token: 0x17007EA9 RID: 32425
		// (get) Token: 0x0601A8FD RID: 108797 RVA: 0x003C74E6 File Offset: 0x003C56E6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A8FE RID: 108798 RVA: 0x003C74F3 File Offset: 0x003C56F3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A8FF RID: 108799 RVA: 0x003C74FC File Offset: 0x003C56FC
		public static IUseSkillCheckByFollowShooterSkillId GetRootAsIUseSkillCheckByFollowShooterSkillId(ByteBuffer _bb)
		{
			return IUseSkillCheckByFollowShooterSkillId.GetRootAsIUseSkillCheckByFollowShooterSkillId(_bb, default(IUseSkillCheckByFollowShooterSkillId));
		}

		// Token: 0x0601A900 RID: 108800 RVA: 0x003C7518 File Offset: 0x003C5718
		public static IUseSkillCheckByFollowShooterSkillId GetRootAsIUseSkillCheckByFollowShooterSkillId(ByteBuffer _bb, IUseSkillCheckByFollowShooterSkillId obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A901 RID: 108801 RVA: 0x003C7535 File Offset: 0x003C5735
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A902 RID: 108802 RVA: 0x003C7544 File Offset: 0x003C5744
		public IUseSkillCheckByFollowShooterSkillId __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007EAA RID: 32426
		// (get) Token: 0x0601A903 RID: 108803 RVA: 0x003C7554 File Offset: 0x003C5754
		public EUseSkillCheckType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EUseSkillCheckType.CheckSkillGenre;
				}
				return (EUseSkillCheckType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007EAB RID: 32427
		// (get) Token: 0x0601A904 RID: 108804 RVA: 0x003C7590 File Offset: 0x003C5790
		public int SkillId
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

		// Token: 0x0601A905 RID: 108805 RVA: 0x003C75CC File Offset: 0x003C57CC
		public static Offset<IUseSkillCheckByFollowShooterSkillId> CreateIUseSkillCheckByFollowShooterSkillId(FlatBufferBuilder builder, EUseSkillCheckType Type = EUseSkillCheckType.CheckSkillGenre, int SkillId = 0)
		{
			builder.StartTable(2);
			IUseSkillCheckByFollowShooterSkillId.AddSkillId(builder, SkillId);
			IUseSkillCheckByFollowShooterSkillId.AddType(builder, Type);
			return IUseSkillCheckByFollowShooterSkillId.EndIUseSkillCheckByFollowShooterSkillId(builder);
		}

		// Token: 0x0601A906 RID: 108806 RVA: 0x003C75E9 File Offset: 0x003C57E9
		public static void StartIUseSkillCheckByFollowShooterSkillId(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601A907 RID: 108807 RVA: 0x003C75F2 File Offset: 0x003C57F2
		public static void AddType(FlatBufferBuilder builder, EUseSkillCheckType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A908 RID: 108808 RVA: 0x003C75FD File Offset: 0x003C57FD
		public static void AddSkillId(FlatBufferBuilder builder, int skillId)
		{
			builder.AddInt(1, skillId, 0);
		}

		// Token: 0x0601A909 RID: 108809 RVA: 0x003C7608 File Offset: 0x003C5808
		public static Offset<IUseSkillCheckByFollowShooterSkillId> EndIUseSkillCheckByFollowShooterSkillId(FlatBufferBuilder builder)
		{
			return new Offset<IUseSkillCheckByFollowShooterSkillId>(builder.EndTable());
		}

		// Token: 0x0601A90A RID: 108810 RVA: 0x003C7618 File Offset: 0x003C5818
		public IUseSkillCheckByFollowShooterSkillIdT UnPack()
		{
			IUseSkillCheckByFollowShooterSkillIdT useSkillCheckByFollowShooterSkillIdT = new IUseSkillCheckByFollowShooterSkillIdT();
			this.UnPackTo(useSkillCheckByFollowShooterSkillIdT);
			return useSkillCheckByFollowShooterSkillIdT;
		}

		// Token: 0x0601A90B RID: 108811 RVA: 0x003C7633 File Offset: 0x003C5833
		public void UnPackTo(IUseSkillCheckByFollowShooterSkillIdT _o)
		{
			_o.Type = this.Type;
			_o.SkillId = this.SkillId;
		}

		// Token: 0x0601A90C RID: 108812 RVA: 0x003C7650 File Offset: 0x003C5850
		public static Offset<IUseSkillCheckByFollowShooterSkillId> Pack(FlatBufferBuilder builder, IUseSkillCheckByFollowShooterSkillIdT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUseSkillCheckByFollowShooterSkillId>);
			}
			return IUseSkillCheckByFollowShooterSkillId.CreateIUseSkillCheckByFollowShooterSkillId(builder, _o.Type, _o.SkillId);
		}

		// Token: 0x0400C8E1 RID: 51425
		private Table __p;
	}
}
