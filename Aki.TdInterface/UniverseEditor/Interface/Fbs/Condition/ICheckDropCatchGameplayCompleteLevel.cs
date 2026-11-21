using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E96 RID: 20118
	public struct ICheckDropCatchGameplayCompleteLevel : IFlatbufferObject
	{
		// Token: 0x17008F7F RID: 36735
		// (get) Token: 0x0601F2C3 RID: 127683 RVA: 0x00458E4C File Offset: 0x0045704C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F2C4 RID: 127684 RVA: 0x00458E59 File Offset: 0x00457059
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F2C5 RID: 127685 RVA: 0x00458E60 File Offset: 0x00457060
		public static ICheckDropCatchGameplayCompleteLevel GetRootAsICheckDropCatchGameplayCompleteLevel(ByteBuffer _bb)
		{
			return ICheckDropCatchGameplayCompleteLevel.GetRootAsICheckDropCatchGameplayCompleteLevel(_bb, default(ICheckDropCatchGameplayCompleteLevel));
		}

		// Token: 0x0601F2C6 RID: 127686 RVA: 0x00458E7C File Offset: 0x0045707C
		public static ICheckDropCatchGameplayCompleteLevel GetRootAsICheckDropCatchGameplayCompleteLevel(ByteBuffer _bb, ICheckDropCatchGameplayCompleteLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F2C7 RID: 127687 RVA: 0x00458E99 File Offset: 0x00457099
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F2C8 RID: 127688 RVA: 0x00458EA8 File Offset: 0x004570A8
		public ICheckDropCatchGameplayCompleteLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008F80 RID: 36736
		// (get) Token: 0x0601F2C9 RID: 127689 RVA: 0x00458EB8 File Offset: 0x004570B8
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

		// Token: 0x17008F81 RID: 36737
		// (get) Token: 0x0601F2CA RID: 127690 RVA: 0x00458EF4 File Offset: 0x004570F4
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

		// Token: 0x0601F2CB RID: 127691 RVA: 0x00458F30 File Offset: 0x00457130
		public static Offset<ICheckDropCatchGameplayCompleteLevel> CreateICheckDropCatchGameplayCompleteLevel(FlatBufferBuilder builder, ECheckSystemStateType Type = ECheckSystemStateType.TrackMoonBuilding, int LevelId = 0)
		{
			builder.StartTable(2);
			ICheckDropCatchGameplayCompleteLevel.AddLevelId(builder, LevelId);
			ICheckDropCatchGameplayCompleteLevel.AddType(builder, Type);
			return ICheckDropCatchGameplayCompleteLevel.EndICheckDropCatchGameplayCompleteLevel(builder);
		}

		// Token: 0x0601F2CC RID: 127692 RVA: 0x00458F4D File Offset: 0x0045714D
		public static void StartICheckDropCatchGameplayCompleteLevel(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601F2CD RID: 127693 RVA: 0x00458F56 File Offset: 0x00457156
		public static void AddType(FlatBufferBuilder builder, ECheckSystemStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F2CE RID: 127694 RVA: 0x00458F61 File Offset: 0x00457161
		public static void AddLevelId(FlatBufferBuilder builder, int levelId)
		{
			builder.AddInt(1, levelId, 0);
		}

		// Token: 0x0601F2CF RID: 127695 RVA: 0x00458F6C File Offset: 0x0045716C
		public static Offset<ICheckDropCatchGameplayCompleteLevel> EndICheckDropCatchGameplayCompleteLevel(FlatBufferBuilder builder)
		{
			return new Offset<ICheckDropCatchGameplayCompleteLevel>(builder.EndTable());
		}

		// Token: 0x0601F2D0 RID: 127696 RVA: 0x00458F7C File Offset: 0x0045717C
		public ICheckDropCatchGameplayCompleteLevelT UnPack()
		{
			ICheckDropCatchGameplayCompleteLevelT checkDropCatchGameplayCompleteLevelT = new ICheckDropCatchGameplayCompleteLevelT();
			this.UnPackTo(checkDropCatchGameplayCompleteLevelT);
			return checkDropCatchGameplayCompleteLevelT;
		}

		// Token: 0x0601F2D1 RID: 127697 RVA: 0x00458F97 File Offset: 0x00457197
		public void UnPackTo(ICheckDropCatchGameplayCompleteLevelT _o)
		{
			_o.Type = this.Type;
			_o.LevelId = this.LevelId;
		}

		// Token: 0x0601F2D2 RID: 127698 RVA: 0x00458FB4 File Offset: 0x004571B4
		public static Offset<ICheckDropCatchGameplayCompleteLevel> Pack(FlatBufferBuilder builder, ICheckDropCatchGameplayCompleteLevelT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckDropCatchGameplayCompleteLevel>);
			}
			return ICheckDropCatchGameplayCompleteLevel.CreateICheckDropCatchGameplayCompleteLevel(builder, _o.Type, _o.LevelId);
		}

		// Token: 0x0400DCD7 RID: 56535
		private Table __p;
	}
}
