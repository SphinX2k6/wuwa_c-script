using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005013 RID: 20499
	public struct ICheckSpringFestivalGuessJokerFirstComplete : IFlatbufferObject
	{
		// Token: 0x170092AB RID: 37547
		// (get) Token: 0x0601FFFB RID: 131067 RVA: 0x00470CE2 File Offset: 0x0046EEE2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FFFC RID: 131068 RVA: 0x00470CEF File Offset: 0x0046EEEF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FFFD RID: 131069 RVA: 0x00470CF8 File Offset: 0x0046EEF8
		public static ICheckSpringFestivalGuessJokerFirstComplete GetRootAsICheckSpringFestivalGuessJokerFirstComplete(ByteBuffer _bb)
		{
			return ICheckSpringFestivalGuessJokerFirstComplete.GetRootAsICheckSpringFestivalGuessJokerFirstComplete(_bb, default(ICheckSpringFestivalGuessJokerFirstComplete));
		}

		// Token: 0x0601FFFE RID: 131070 RVA: 0x00470D14 File Offset: 0x0046EF14
		public static ICheckSpringFestivalGuessJokerFirstComplete GetRootAsICheckSpringFestivalGuessJokerFirstComplete(ByteBuffer _bb, ICheckSpringFestivalGuessJokerFirstComplete obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FFFF RID: 131071 RVA: 0x00470D31 File Offset: 0x0046EF31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020000 RID: 131072 RVA: 0x00470D40 File Offset: 0x0046EF40
		public ICheckSpringFestivalGuessJokerFirstComplete __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170092AC RID: 37548
		// (get) Token: 0x06020001 RID: 131073 RVA: 0x00470D50 File Offset: 0x0046EF50
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

		// Token: 0x170092AD RID: 37549
		// (get) Token: 0x06020002 RID: 131074 RVA: 0x00470D8C File Offset: 0x0046EF8C
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

		// Token: 0x06020003 RID: 131075 RVA: 0x00470DC8 File Offset: 0x0046EFC8
		public static Offset<ICheckSpringFestivalGuessJokerFirstComplete> CreateICheckSpringFestivalGuessJokerFirstComplete(FlatBufferBuilder builder, ECheckSystemStateType Type = ECheckSystemStateType.TrackMoonBuilding, int LevelId = 0)
		{
			builder.StartTable(2);
			ICheckSpringFestivalGuessJokerFirstComplete.AddLevelId(builder, LevelId);
			ICheckSpringFestivalGuessJokerFirstComplete.AddType(builder, Type);
			return ICheckSpringFestivalGuessJokerFirstComplete.EndICheckSpringFestivalGuessJokerFirstComplete(builder);
		}

		// Token: 0x06020004 RID: 131076 RVA: 0x00470DE5 File Offset: 0x0046EFE5
		public static void StartICheckSpringFestivalGuessJokerFirstComplete(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06020005 RID: 131077 RVA: 0x00470DEE File Offset: 0x0046EFEE
		public static void AddType(FlatBufferBuilder builder, ECheckSystemStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020006 RID: 131078 RVA: 0x00470DF9 File Offset: 0x0046EFF9
		public static void AddLevelId(FlatBufferBuilder builder, int levelId)
		{
			builder.AddInt(1, levelId, 0);
		}

		// Token: 0x06020007 RID: 131079 RVA: 0x00470E04 File Offset: 0x0046F004
		public static Offset<ICheckSpringFestivalGuessJokerFirstComplete> EndICheckSpringFestivalGuessJokerFirstComplete(FlatBufferBuilder builder)
		{
			return new Offset<ICheckSpringFestivalGuessJokerFirstComplete>(builder.EndTable());
		}

		// Token: 0x06020008 RID: 131080 RVA: 0x00470E14 File Offset: 0x0046F014
		public ICheckSpringFestivalGuessJokerFirstCompleteT UnPack()
		{
			ICheckSpringFestivalGuessJokerFirstCompleteT checkSpringFestivalGuessJokerFirstCompleteT = new ICheckSpringFestivalGuessJokerFirstCompleteT();
			this.UnPackTo(checkSpringFestivalGuessJokerFirstCompleteT);
			return checkSpringFestivalGuessJokerFirstCompleteT;
		}

		// Token: 0x06020009 RID: 131081 RVA: 0x00470E2F File Offset: 0x0046F02F
		public void UnPackTo(ICheckSpringFestivalGuessJokerFirstCompleteT _o)
		{
			_o.Type = this.Type;
			_o.LevelId = this.LevelId;
		}

		// Token: 0x0602000A RID: 131082 RVA: 0x00470E4C File Offset: 0x0046F04C
		public static Offset<ICheckSpringFestivalGuessJokerFirstComplete> Pack(FlatBufferBuilder builder, ICheckSpringFestivalGuessJokerFirstCompleteT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckSpringFestivalGuessJokerFirstComplete>);
			}
			return ICheckSpringFestivalGuessJokerFirstComplete.CreateICheckSpringFestivalGuessJokerFirstComplete(builder, _o.Type, _o.LevelId);
		}

		// Token: 0x0400DED0 RID: 57040
		private Table __p;
	}
}
