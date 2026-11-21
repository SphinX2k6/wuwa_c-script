using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005727 RID: 22311
	public struct IEntityTrackControlPoint : IFlatbufferObject
	{
		// Token: 0x1700A10B RID: 41227
		// (get) Token: 0x06023E08 RID: 146952 RVA: 0x004EE9DF File Offset: 0x004ECBDF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023E09 RID: 146953 RVA: 0x004EE9EC File Offset: 0x004ECBEC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023E0A RID: 146954 RVA: 0x004EE9F4 File Offset: 0x004ECBF4
		public static IEntityTrackControlPoint GetRootAsIEntityTrackControlPoint(ByteBuffer _bb)
		{
			return IEntityTrackControlPoint.GetRootAsIEntityTrackControlPoint(_bb, default(IEntityTrackControlPoint));
		}

		// Token: 0x06023E0B RID: 146955 RVA: 0x004EEA10 File Offset: 0x004ECC10
		public static IEntityTrackControlPoint GetRootAsIEntityTrackControlPoint(ByteBuffer _bb, IEntityTrackControlPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023E0C RID: 146956 RVA: 0x004EEA2D File Offset: 0x004ECC2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023E0D RID: 146957 RVA: 0x004EEA3C File Offset: 0x004ECC3C
		public IEntityTrackControlPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A10C RID: 41228
		// (get) Token: 0x06023E0E RID: 146958 RVA: 0x004EEA4C File Offset: 0x004ECC4C
		public string State
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023E0F RID: 146959 RVA: 0x004EEA83 File Offset: 0x004ECC83
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06023E10 RID: 146960 RVA: 0x004EEA92 File Offset: 0x004ECC92
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700A10D RID: 41229
		// (get) Token: 0x06023E11 RID: 146961 RVA: 0x004EEAA0 File Offset: 0x004ECCA0
		public IConditionGroup? LeftCondition
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A10E RID: 41230
		// (get) Token: 0x06023E12 RID: 146962 RVA: 0x004EEB00 File Offset: 0x004ECD00
		public IConditionGroup? RightCondition
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06023E13 RID: 146963 RVA: 0x004EEB5D File Offset: 0x004ECD5D
		public static Offset<IEntityTrackControlPoint> CreateIEntityTrackControlPoint(FlatBufferBuilder builder, StringOffset StateOffset = default(StringOffset), Offset<IConditionGroup> LeftConditionOffset = default(Offset<IConditionGroup>), Offset<IConditionGroup> RightConditionOffset = default(Offset<IConditionGroup>))
		{
			builder.StartTable(3);
			IEntityTrackControlPoint.AddRightCondition(builder, RightConditionOffset);
			IEntityTrackControlPoint.AddLeftCondition(builder, LeftConditionOffset);
			IEntityTrackControlPoint.AddState(builder, StateOffset);
			return IEntityTrackControlPoint.EndIEntityTrackControlPoint(builder);
		}

		// Token: 0x06023E14 RID: 146964 RVA: 0x004EEB81 File Offset: 0x004ECD81
		public static void StartIEntityTrackControlPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06023E15 RID: 146965 RVA: 0x004EEB8A File Offset: 0x004ECD8A
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(0, stateOffset.Value, 0);
		}

		// Token: 0x06023E16 RID: 146966 RVA: 0x004EEB9A File Offset: 0x004ECD9A
		public static void AddLeftCondition(FlatBufferBuilder builder, Offset<IConditionGroup> leftConditionOffset)
		{
			builder.AddOffset(1, leftConditionOffset.Value, 0);
		}

		// Token: 0x06023E17 RID: 146967 RVA: 0x004EEBAA File Offset: 0x004ECDAA
		public static void AddRightCondition(FlatBufferBuilder builder, Offset<IConditionGroup> rightConditionOffset)
		{
			builder.AddOffset(2, rightConditionOffset.Value, 0);
		}

		// Token: 0x06023E18 RID: 146968 RVA: 0x004EEBBA File Offset: 0x004ECDBA
		public static Offset<IEntityTrackControlPoint> EndIEntityTrackControlPoint(FlatBufferBuilder builder)
		{
			return new Offset<IEntityTrackControlPoint>(builder.EndTable());
		}

		// Token: 0x06023E19 RID: 146969 RVA: 0x004EEBC8 File Offset: 0x004ECDC8
		public IEntityTrackControlPointT UnPack()
		{
			IEntityTrackControlPointT entityTrackControlPointT = new IEntityTrackControlPointT();
			this.UnPackTo(entityTrackControlPointT);
			return entityTrackControlPointT;
		}

		// Token: 0x06023E1A RID: 146970 RVA: 0x004EEBE4 File Offset: 0x004ECDE4
		public void UnPackTo(IEntityTrackControlPointT _o)
		{
			_o.State = this.State;
			_o.LeftCondition = ((this.LeftCondition != null) ? this.LeftCondition.Value.UnPack() : null);
			_o.RightCondition = ((this.RightCondition != null) ? this.RightCondition.Value.UnPack() : null);
		}

		// Token: 0x06023E1B RID: 146971 RVA: 0x004EEC5C File Offset: 0x004ECE5C
		public static Offset<IEntityTrackControlPoint> Pack(FlatBufferBuilder builder, IEntityTrackControlPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityTrackControlPoint>);
			}
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			Offset<IConditionGroup> leftConditionOffset = (_o.LeftCondition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.LeftCondition);
			Offset<IConditionGroup> rightConditionOffset = (_o.RightCondition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.RightCondition);
			return IEntityTrackControlPoint.CreateIEntityTrackControlPoint(builder, stateOffset, leftConditionOffset, rightConditionOffset);
		}

		// Token: 0x0400EEBA RID: 61114
		private Table __p;
	}
}
