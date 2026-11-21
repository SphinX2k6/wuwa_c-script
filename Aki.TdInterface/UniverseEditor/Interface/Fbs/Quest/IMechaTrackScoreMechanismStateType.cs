using System;
using Aki.UniverseEditor.Interface.Fbs.Component;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004367 RID: 17255
	public struct IMechaTrackScoreMechanismStateType : IFlatbufferObject
	{
		// Token: 0x17007659 RID: 30297
		// (get) Token: 0x060185B4 RID: 99764 RVA: 0x00379350 File Offset: 0x00377550
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060185B5 RID: 99765 RVA: 0x0037935D File Offset: 0x0037755D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060185B6 RID: 99766 RVA: 0x00379364 File Offset: 0x00377564
		public static IMechaTrackScoreMechanismStateType GetRootAsIMechaTrackScoreMechanismStateType(ByteBuffer _bb)
		{
			return IMechaTrackScoreMechanismStateType.GetRootAsIMechaTrackScoreMechanismStateType(_bb, default(IMechaTrackScoreMechanismStateType));
		}

		// Token: 0x060185B7 RID: 99767 RVA: 0x00379380 File Offset: 0x00377580
		public static IMechaTrackScoreMechanismStateType GetRootAsIMechaTrackScoreMechanismStateType(ByteBuffer _bb, IMechaTrackScoreMechanismStateType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060185B8 RID: 99768 RVA: 0x0037939D File Offset: 0x0037759D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060185B9 RID: 99769 RVA: 0x003793AC File Offset: 0x003775AC
		public IMechaTrackScoreMechanismStateType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700765A RID: 30298
		// (get) Token: 0x060185BA RID: 99770 RVA: 0x003793BC File Offset: 0x003775BC
		public IStaticEntitiyMatch? EntitiyMatch
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IStaticEntitiyMatch?(default(IStaticEntitiyMatch).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700765B RID: 30299
		// (get) Token: 0x060185BB RID: 99771 RVA: 0x0037941C File Offset: 0x0037761C
		public string State
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060185BC RID: 99772 RVA: 0x00379453 File Offset: 0x00377653
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060185BD RID: 99773 RVA: 0x00379462 File Offset: 0x00377662
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700765C RID: 30300
		// (get) Token: 0x060185BE RID: 99774 RVA: 0x00379470 File Offset: 0x00377670
		public int ScoreId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060185BF RID: 99775 RVA: 0x003794AC File Offset: 0x003776AC
		public static Offset<IMechaTrackScoreMechanismStateType> CreateIMechaTrackScoreMechanismStateType(FlatBufferBuilder builder, Offset<IStaticEntitiyMatch> EntitiyMatchOffset = default(Offset<IStaticEntitiyMatch>), StringOffset StateOffset = default(StringOffset), int ScoreId = 0)
		{
			builder.StartTable(3);
			IMechaTrackScoreMechanismStateType.AddScoreId(builder, ScoreId);
			IMechaTrackScoreMechanismStateType.AddState(builder, StateOffset);
			IMechaTrackScoreMechanismStateType.AddEntitiyMatch(builder, EntitiyMatchOffset);
			return IMechaTrackScoreMechanismStateType.EndIMechaTrackScoreMechanismStateType(builder);
		}

		// Token: 0x060185C0 RID: 99776 RVA: 0x003794D0 File Offset: 0x003776D0
		public static void StartIMechaTrackScoreMechanismStateType(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060185C1 RID: 99777 RVA: 0x003794D9 File Offset: 0x003776D9
		public static void AddEntitiyMatch(FlatBufferBuilder builder, Offset<IStaticEntitiyMatch> entitiyMatchOffset)
		{
			builder.AddOffset(0, entitiyMatchOffset.Value, 0);
		}

		// Token: 0x060185C2 RID: 99778 RVA: 0x003794E9 File Offset: 0x003776E9
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(1, stateOffset.Value, 0);
		}

		// Token: 0x060185C3 RID: 99779 RVA: 0x003794F9 File Offset: 0x003776F9
		public static void AddScoreId(FlatBufferBuilder builder, int scoreId)
		{
			builder.AddInt(2, scoreId, 0);
		}

		// Token: 0x060185C4 RID: 99780 RVA: 0x00379504 File Offset: 0x00377704
		public static Offset<IMechaTrackScoreMechanismStateType> EndIMechaTrackScoreMechanismStateType(FlatBufferBuilder builder)
		{
			return new Offset<IMechaTrackScoreMechanismStateType>(builder.EndTable());
		}

		// Token: 0x060185C5 RID: 99781 RVA: 0x00379514 File Offset: 0x00377714
		public IMechaTrackScoreMechanismStateTypeT UnPack()
		{
			IMechaTrackScoreMechanismStateTypeT mechaTrackScoreMechanismStateTypeT = new IMechaTrackScoreMechanismStateTypeT();
			this.UnPackTo(mechaTrackScoreMechanismStateTypeT);
			return mechaTrackScoreMechanismStateTypeT;
		}

		// Token: 0x060185C6 RID: 99782 RVA: 0x00379530 File Offset: 0x00377730
		public void UnPackTo(IMechaTrackScoreMechanismStateTypeT _o)
		{
			_o.EntitiyMatch = ((this.EntitiyMatch != null) ? this.EntitiyMatch.Value.UnPack() : null);
			_o.State = this.State;
			_o.ScoreId = this.ScoreId;
		}

		// Token: 0x060185C7 RID: 99783 RVA: 0x00379584 File Offset: 0x00377784
		public static Offset<IMechaTrackScoreMechanismStateType> Pack(FlatBufferBuilder builder, IMechaTrackScoreMechanismStateTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMechaTrackScoreMechanismStateType>);
			}
			Offset<IStaticEntitiyMatch> entitiyMatchOffset = (_o.EntitiyMatch == null) ? default(Offset<IStaticEntitiyMatch>) : IStaticEntitiyMatch.Pack(builder, _o.EntitiyMatch);
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			return IMechaTrackScoreMechanismStateType.CreateIMechaTrackScoreMechanismStateType(builder, entitiyMatchOffset, stateOffset, _o.ScoreId);
		}

		// Token: 0x0400C311 RID: 49937
		private Table __p;
	}
}
