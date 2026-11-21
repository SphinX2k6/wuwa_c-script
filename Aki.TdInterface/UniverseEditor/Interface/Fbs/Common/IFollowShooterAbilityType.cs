using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063E9 RID: 25577
	public struct IFollowShooterAbilityType : IFlatbufferObject
	{
		// Token: 0x1700BCFD RID: 48381
		// (get) Token: 0x0602B740 RID: 177984 RVA: 0x005EBA34 File Offset: 0x005E9C34
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B741 RID: 177985 RVA: 0x005EBA41 File Offset: 0x005E9C41
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B742 RID: 177986 RVA: 0x005EBA48 File Offset: 0x005E9C48
		public static IFollowShooterAbilityType GetRootAsIFollowShooterAbilityType(ByteBuffer _bb)
		{
			return IFollowShooterAbilityType.GetRootAsIFollowShooterAbilityType(_bb, default(IFollowShooterAbilityType));
		}

		// Token: 0x0602B743 RID: 177987 RVA: 0x005EBA64 File Offset: 0x005E9C64
		public static IFollowShooterAbilityType GetRootAsIFollowShooterAbilityType(ByteBuffer _bb, IFollowShooterAbilityType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B744 RID: 177988 RVA: 0x005EBA81 File Offset: 0x005E9C81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B745 RID: 177989 RVA: 0x005EBA90 File Offset: 0x005E9C90
		public IFollowShooterAbilityType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BCFE RID: 48382
		// (get) Token: 0x0602B746 RID: 177990 RVA: 0x005EBAA0 File Offset: 0x005E9CA0
		public EFollowShooterType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFollowShooterType.JellyFish;
				}
				return (EFollowShooterType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602B747 RID: 177991 RVA: 0x005EBADC File Offset: 0x005E9CDC
		public static Offset<IFollowShooterAbilityType> CreateIFollowShooterAbilityType(FlatBufferBuilder builder, EFollowShooterType Type = EFollowShooterType.JellyFish)
		{
			builder.StartTable(1);
			IFollowShooterAbilityType.AddType(builder, Type);
			return IFollowShooterAbilityType.EndIFollowShooterAbilityType(builder);
		}

		// Token: 0x0602B748 RID: 177992 RVA: 0x005EBAF2 File Offset: 0x005E9CF2
		public static void StartIFollowShooterAbilityType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602B749 RID: 177993 RVA: 0x005EBAFB File Offset: 0x005E9CFB
		public static void AddType(FlatBufferBuilder builder, EFollowShooterType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B74A RID: 177994 RVA: 0x005EBB06 File Offset: 0x005E9D06
		public static Offset<IFollowShooterAbilityType> EndIFollowShooterAbilityType(FlatBufferBuilder builder)
		{
			return new Offset<IFollowShooterAbilityType>(builder.EndTable());
		}

		// Token: 0x0602B74B RID: 177995 RVA: 0x005EBB14 File Offset: 0x005E9D14
		public IFollowShooterAbilityTypeT UnPack()
		{
			IFollowShooterAbilityTypeT followShooterAbilityTypeT = new IFollowShooterAbilityTypeT();
			this.UnPackTo(followShooterAbilityTypeT);
			return followShooterAbilityTypeT;
		}

		// Token: 0x0602B74C RID: 177996 RVA: 0x005EBB2F File Offset: 0x005E9D2F
		public void UnPackTo(IFollowShooterAbilityTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602B74D RID: 177997 RVA: 0x005EBB40 File Offset: 0x005E9D40
		public static Offset<IFollowShooterAbilityType> Pack(FlatBufferBuilder builder, IFollowShooterAbilityTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFollowShooterAbilityType>);
			}
			return IFollowShooterAbilityType.CreateIFollowShooterAbilityType(builder, _o.Type);
		}

		// Token: 0x040104E2 RID: 66786
		private Table __p;
	}
}
