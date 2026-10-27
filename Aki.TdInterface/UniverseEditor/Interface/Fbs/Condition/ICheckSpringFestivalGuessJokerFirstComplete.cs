using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B2C RID: 19244
	public struct ICheckSpringFestivalGuessJokerFirstComplete : IFlatbufferObject
	{
		// Token: 0x17008B9B RID: 35739
		// (get) Token: 0x0601E470 RID: 124016 RVA: 0x0043E536 File Offset: 0x0043C736
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E471 RID: 124017 RVA: 0x0043E543 File Offset: 0x0043C743
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E472 RID: 124018 RVA: 0x0043E54C File Offset: 0x0043C74C
		public static ICheckSpringFestivalGuessJokerFirstComplete GetRootAsICheckSpringFestivalGuessJokerFirstComplete(ByteBuffer _bb)
		{
			return ICheckSpringFestivalGuessJokerFirstComplete.GetRootAsICheckSpringFestivalGuessJokerFirstComplete(_bb, default(ICheckSpringFestivalGuessJokerFirstComplete));
		}

		// Token: 0x0601E473 RID: 124019 RVA: 0x0043E568 File Offset: 0x0043C768
		public static ICheckSpringFestivalGuessJokerFirstComplete GetRootAsICheckSpringFestivalGuessJokerFirstComplete(ByteBuffer _bb, ICheckSpringFestivalGuessJokerFirstComplete obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E474 RID: 124020 RVA: 0x0043E585 File Offset: 0x0043C785
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E475 RID: 124021 RVA: 0x0043E594 File Offset: 0x0043C794
		public ICheckSpringFestivalGuessJokerFirstComplete __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008B9C RID: 35740
		// (get) Token: 0x0601E476 RID: 124022 RVA: 0x0043E5A4 File Offset: 0x0043C7A4
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

		// Token: 0x17008B9D RID: 35741
		// (get) Token: 0x0601E477 RID: 124023 RVA: 0x0043E5E0 File Offset: 0x0043C7E0
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

		// Token: 0x0601E478 RID: 124024 RVA: 0x0043E61C File Offset: 0x0043C81C
		public static Offset<ICheckSpringFestivalGuessJokerFirstComplete> CreateICheckSpringFestivalGuessJokerFirstComplete(FlatBufferBuilder builder, ECheckSystemStateType Type = ECheckSystemStateType.TrackMoonBuilding, int LevelId = 0)
		{
			builder.StartTable(2);
			ICheckSpringFestivalGuessJokerFirstComplete.AddLevelId(builder, LevelId);
			ICheckSpringFestivalGuessJokerFirstComplete.AddType(builder, Type);
			return ICheckSpringFestivalGuessJokerFirstComplete.EndICheckSpringFestivalGuessJokerFirstComplete(builder);
		}

		// Token: 0x0601E479 RID: 124025 RVA: 0x0043E639 File Offset: 0x0043C839
		public static void StartICheckSpringFestivalGuessJokerFirstComplete(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601E47A RID: 124026 RVA: 0x0043E642 File Offset: 0x0043C842
		public static void AddType(FlatBufferBuilder builder, ECheckSystemStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E47B RID: 124027 RVA: 0x0043E64D File Offset: 0x0043C84D
		public static void AddLevelId(FlatBufferBuilder builder, int levelId)
		{
			builder.AddInt(1, levelId, 0);
		}

		// Token: 0x0601E47C RID: 124028 RVA: 0x0043E658 File Offset: 0x0043C858
		public static Offset<ICheckSpringFestivalGuessJokerFirstComplete> EndICheckSpringFestivalGuessJokerFirstComplete(FlatBufferBuilder builder)
		{
			return new Offset<ICheckSpringFestivalGuessJokerFirstComplete>(builder.EndTable());
		}

		// Token: 0x0601E47D RID: 124029 RVA: 0x0043E668 File Offset: 0x0043C868
		public ICheckSpringFestivalGuessJokerFirstCompleteT UnPack()
		{
			ICheckSpringFestivalGuessJokerFirstCompleteT checkSpringFestivalGuessJokerFirstCompleteT = new ICheckSpringFestivalGuessJokerFirstCompleteT();
			this.UnPackTo(checkSpringFestivalGuessJokerFirstCompleteT);
			return checkSpringFestivalGuessJokerFirstCompleteT;
		}

		// Token: 0x0601E47E RID: 124030 RVA: 0x0043E683 File Offset: 0x0043C883
		public void UnPackTo(ICheckSpringFestivalGuessJokerFirstCompleteT _o)
		{
			_o.Type = this.Type;
			_o.LevelId = this.LevelId;
		}

		// Token: 0x0601E47F RID: 124031 RVA: 0x0043E6A0 File Offset: 0x0043C8A0
		public static Offset<ICheckSpringFestivalGuessJokerFirstComplete> Pack(FlatBufferBuilder builder, ICheckSpringFestivalGuessJokerFirstCompleteT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckSpringFestivalGuessJokerFirstComplete>);
			}
			return ICheckSpringFestivalGuessJokerFirstComplete.CreateICheckSpringFestivalGuessJokerFirstComplete(builder, _o.Type, _o.LevelId);
		}

		// Token: 0x0400D3D1 RID: 54225
		private Table __p;
	}
}
