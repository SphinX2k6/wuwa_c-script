using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049D6 RID: 18902
	public struct ICheckDropCatchGameplayCompleteLevel : IFlatbufferObject
	{
		// Token: 0x170088AF RID: 34991
		// (get) Token: 0x0601D850 RID: 120912 RVA: 0x004281E0 File Offset: 0x004263E0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D851 RID: 120913 RVA: 0x004281ED File Offset: 0x004263ED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D852 RID: 120914 RVA: 0x004281F4 File Offset: 0x004263F4
		public static ICheckDropCatchGameplayCompleteLevel GetRootAsICheckDropCatchGameplayCompleteLevel(ByteBuffer _bb)
		{
			return ICheckDropCatchGameplayCompleteLevel.GetRootAsICheckDropCatchGameplayCompleteLevel(_bb, default(ICheckDropCatchGameplayCompleteLevel));
		}

		// Token: 0x0601D853 RID: 120915 RVA: 0x00428210 File Offset: 0x00426410
		public static ICheckDropCatchGameplayCompleteLevel GetRootAsICheckDropCatchGameplayCompleteLevel(ByteBuffer _bb, ICheckDropCatchGameplayCompleteLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D854 RID: 120916 RVA: 0x0042822D File Offset: 0x0042642D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D855 RID: 120917 RVA: 0x0042823C File Offset: 0x0042643C
		public ICheckDropCatchGameplayCompleteLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170088B0 RID: 34992
		// (get) Token: 0x0601D856 RID: 120918 RVA: 0x0042824C File Offset: 0x0042644C
		public ECheckSystemStateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECheckSystemStateType.TrackMoonBuilding;
				}
				return (ECheckSystemStateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170088B1 RID: 34993
		// (get) Token: 0x0601D857 RID: 120919 RVA: 0x00428288 File Offset: 0x00426488
		public int LevelId
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

		// Token: 0x0601D858 RID: 120920 RVA: 0x004282C4 File Offset: 0x004264C4
		public static Offset<ICheckDropCatchGameplayCompleteLevel> CreateICheckDropCatchGameplayCompleteLevel(FlatBufferBuilder builder, ECheckSystemStateType Type = ECheckSystemStateType.TrackMoonBuilding, int LevelId = 0)
		{
			builder.StartTable(2);
			ICheckDropCatchGameplayCompleteLevel.AddLevelId(builder, LevelId);
			ICheckDropCatchGameplayCompleteLevel.AddType(builder, Type);
			return ICheckDropCatchGameplayCompleteLevel.EndICheckDropCatchGameplayCompleteLevel(builder);
		}

		// Token: 0x0601D859 RID: 120921 RVA: 0x004282E1 File Offset: 0x004264E1
		public static void StartICheckDropCatchGameplayCompleteLevel(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601D85A RID: 120922 RVA: 0x004282EA File Offset: 0x004264EA
		public static void AddType(FlatBufferBuilder builder, ECheckSystemStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D85B RID: 120923 RVA: 0x004282F5 File Offset: 0x004264F5
		public static void AddLevelId(FlatBufferBuilder builder, int levelId)
		{
			builder.AddInt(1, levelId, 0);
		}

		// Token: 0x0601D85C RID: 120924 RVA: 0x00428300 File Offset: 0x00426500
		public static Offset<ICheckDropCatchGameplayCompleteLevel> EndICheckDropCatchGameplayCompleteLevel(FlatBufferBuilder builder)
		{
			return new Offset<ICheckDropCatchGameplayCompleteLevel>(builder.EndTable());
		}

		// Token: 0x0601D85D RID: 120925 RVA: 0x00428310 File Offset: 0x00426510
		public ICheckDropCatchGameplayCompleteLevelT UnPack()
		{
			ICheckDropCatchGameplayCompleteLevelT checkDropCatchGameplayCompleteLevelT = new ICheckDropCatchGameplayCompleteLevelT();
			this.UnPackTo(checkDropCatchGameplayCompleteLevelT);
			return checkDropCatchGameplayCompleteLevelT;
		}

		// Token: 0x0601D85E RID: 120926 RVA: 0x0042832B File Offset: 0x0042652B
		public void UnPackTo(ICheckDropCatchGameplayCompleteLevelT _o)
		{
			_o.Type = this.Type;
			_o.LevelId = this.LevelId;
		}

		// Token: 0x0601D85F RID: 120927 RVA: 0x00428348 File Offset: 0x00426548
		public static Offset<ICheckDropCatchGameplayCompleteLevel> Pack(FlatBufferBuilder builder, ICheckDropCatchGameplayCompleteLevelT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckDropCatchGameplayCompleteLevel>);
			}
			return ICheckDropCatchGameplayCompleteLevel.CreateICheckDropCatchGameplayCompleteLevel(builder, _o.Type, _o.LevelId);
		}

		// Token: 0x0400D203 RID: 53763
		private Table __p;
	}
}
