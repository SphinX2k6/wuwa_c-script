using System;
using Aki.UniverseEditor.Interface.Fbs.Component;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F29 RID: 16169
	public struct IMechaTrackScoreMechanismStateType : IFlatbufferObject
	{
		// Token: 0x1700706A RID: 28778
		// (get) Token: 0x06016F5C RID: 94044 RVA: 0x00350128 File Offset: 0x0034E328
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016F5D RID: 94045 RVA: 0x00350135 File Offset: 0x0034E335
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016F5E RID: 94046 RVA: 0x0035013C File Offset: 0x0034E33C
		public static IMechaTrackScoreMechanismStateType GetRootAsIMechaTrackScoreMechanismStateType(ByteBuffer _bb)
		{
			return IMechaTrackScoreMechanismStateType.GetRootAsIMechaTrackScoreMechanismStateType(_bb, default(IMechaTrackScoreMechanismStateType));
		}

		// Token: 0x06016F5F RID: 94047 RVA: 0x00350158 File Offset: 0x0034E358
		public static IMechaTrackScoreMechanismStateType GetRootAsIMechaTrackScoreMechanismStateType(ByteBuffer _bb, IMechaTrackScoreMechanismStateType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016F60 RID: 94048 RVA: 0x00350175 File Offset: 0x0034E375
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016F61 RID: 94049 RVA: 0x00350184 File Offset: 0x0034E384
		public IMechaTrackScoreMechanismStateType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700706B RID: 28779
		// (get) Token: 0x06016F62 RID: 94050 RVA: 0x00350194 File Offset: 0x0034E394
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

		// Token: 0x1700706C RID: 28780
		// (get) Token: 0x06016F63 RID: 94051 RVA: 0x003501F4 File Offset: 0x0034E3F4
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

		// Token: 0x06016F64 RID: 94052 RVA: 0x0035022B File Offset: 0x0034E42B
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06016F65 RID: 94053 RVA: 0x0035023A File Offset: 0x0034E43A
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700706D RID: 28781
		// (get) Token: 0x06016F66 RID: 94054 RVA: 0x00350248 File Offset: 0x0034E448
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

		// Token: 0x06016F67 RID: 94055 RVA: 0x00350284 File Offset: 0x0034E484
		public static Offset<IMechaTrackScoreMechanismStateType> CreateIMechaTrackScoreMechanismStateType(FlatBufferBuilder builder, Offset<IStaticEntitiyMatch> EntitiyMatchOffset = default(Offset<IStaticEntitiyMatch>), StringOffset StateOffset = default(StringOffset), int ScoreId = 0)
		{
			builder.StartTable(3);
			IMechaTrackScoreMechanismStateType.AddScoreId(builder, ScoreId);
			IMechaTrackScoreMechanismStateType.AddState(builder, StateOffset);
			IMechaTrackScoreMechanismStateType.AddEntitiyMatch(builder, EntitiyMatchOffset);
			return IMechaTrackScoreMechanismStateType.EndIMechaTrackScoreMechanismStateType(builder);
		}

		// Token: 0x06016F68 RID: 94056 RVA: 0x003502A8 File Offset: 0x0034E4A8
		public static void StartIMechaTrackScoreMechanismStateType(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06016F69 RID: 94057 RVA: 0x003502B1 File Offset: 0x0034E4B1
		public static void AddEntitiyMatch(FlatBufferBuilder builder, Offset<IStaticEntitiyMatch> entitiyMatchOffset)
		{
			builder.AddOffset(0, entitiyMatchOffset.Value, 0);
		}

		// Token: 0x06016F6A RID: 94058 RVA: 0x003502C1 File Offset: 0x0034E4C1
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(1, stateOffset.Value, 0);
		}

		// Token: 0x06016F6B RID: 94059 RVA: 0x003502D1 File Offset: 0x0034E4D1
		public static void AddScoreId(FlatBufferBuilder builder, int scoreId)
		{
			builder.AddInt(2, scoreId, 0);
		}

		// Token: 0x06016F6C RID: 94060 RVA: 0x003502DC File Offset: 0x0034E4DC
		public static Offset<IMechaTrackScoreMechanismStateType> EndIMechaTrackScoreMechanismStateType(FlatBufferBuilder builder)
		{
			return new Offset<IMechaTrackScoreMechanismStateType>(builder.EndTable());
		}

		// Token: 0x06016F6D RID: 94061 RVA: 0x003502EC File Offset: 0x0034E4EC
		public IMechaTrackScoreMechanismStateTypeT UnPack()
		{
			IMechaTrackScoreMechanismStateTypeT mechaTrackScoreMechanismStateTypeT = new IMechaTrackScoreMechanismStateTypeT();
			this.UnPackTo(mechaTrackScoreMechanismStateTypeT);
			return mechaTrackScoreMechanismStateTypeT;
		}

		// Token: 0x06016F6E RID: 94062 RVA: 0x00350308 File Offset: 0x0034E508
		public void UnPackTo(IMechaTrackScoreMechanismStateTypeT _o)
		{
			_o.EntitiyMatch = ((this.EntitiyMatch != null) ? this.EntitiyMatch.Value.UnPack() : null);
			_o.State = this.State;
			_o.ScoreId = this.ScoreId;
		}

		// Token: 0x06016F6F RID: 94063 RVA: 0x0035035C File Offset: 0x0034E55C
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

		// Token: 0x0400B934 RID: 47412
		private Table __p;
	}
}
