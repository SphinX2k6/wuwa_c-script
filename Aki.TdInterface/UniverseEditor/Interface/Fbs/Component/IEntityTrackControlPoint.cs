using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051C2 RID: 20930
	public struct IEntityTrackControlPoint : IFlatbufferObject
	{
		// Token: 0x1700991C RID: 39196
		// (get) Token: 0x06021EB0 RID: 138928 RVA: 0x004B4977 File Offset: 0x004B2B77
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021EB1 RID: 138929 RVA: 0x004B4984 File Offset: 0x004B2B84
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021EB2 RID: 138930 RVA: 0x004B498C File Offset: 0x004B2B8C
		public static IEntityTrackControlPoint GetRootAsIEntityTrackControlPoint(ByteBuffer _bb)
		{
			return IEntityTrackControlPoint.GetRootAsIEntityTrackControlPoint(_bb, default(IEntityTrackControlPoint));
		}

		// Token: 0x06021EB3 RID: 138931 RVA: 0x004B49A8 File Offset: 0x004B2BA8
		public static IEntityTrackControlPoint GetRootAsIEntityTrackControlPoint(ByteBuffer _bb, IEntityTrackControlPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021EB4 RID: 138932 RVA: 0x004B49C5 File Offset: 0x004B2BC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021EB5 RID: 138933 RVA: 0x004B49D4 File Offset: 0x004B2BD4
		public IEntityTrackControlPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700991D RID: 39197
		// (get) Token: 0x06021EB6 RID: 138934 RVA: 0x004B49E4 File Offset: 0x004B2BE4
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

		// Token: 0x06021EB7 RID: 138935 RVA: 0x004B4A1B File Offset: 0x004B2C1B
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06021EB8 RID: 138936 RVA: 0x004B4A2A File Offset: 0x004B2C2A
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700991E RID: 39198
		// (get) Token: 0x06021EB9 RID: 138937 RVA: 0x004B4A38 File Offset: 0x004B2C38
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

		// Token: 0x1700991F RID: 39199
		// (get) Token: 0x06021EBA RID: 138938 RVA: 0x004B4A98 File Offset: 0x004B2C98
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

		// Token: 0x06021EBB RID: 138939 RVA: 0x004B4AF5 File Offset: 0x004B2CF5
		public static Offset<IEntityTrackControlPoint> CreateIEntityTrackControlPoint(FlatBufferBuilder builder, StringOffset StateOffset = default(StringOffset), Offset<IConditionGroup> LeftConditionOffset = default(Offset<IConditionGroup>), Offset<IConditionGroup> RightConditionOffset = default(Offset<IConditionGroup>))
		{
			builder.StartTable(3);
			IEntityTrackControlPoint.AddRightCondition(builder, RightConditionOffset);
			IEntityTrackControlPoint.AddLeftCondition(builder, LeftConditionOffset);
			IEntityTrackControlPoint.AddState(builder, StateOffset);
			return IEntityTrackControlPoint.EndIEntityTrackControlPoint(builder);
		}

		// Token: 0x06021EBC RID: 138940 RVA: 0x004B4B19 File Offset: 0x004B2D19
		public static void StartIEntityTrackControlPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06021EBD RID: 138941 RVA: 0x004B4B22 File Offset: 0x004B2D22
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(0, stateOffset.Value, 0);
		}

		// Token: 0x06021EBE RID: 138942 RVA: 0x004B4B32 File Offset: 0x004B2D32
		public static void AddLeftCondition(FlatBufferBuilder builder, Offset<IConditionGroup> leftConditionOffset)
		{
			builder.AddOffset(1, leftConditionOffset.Value, 0);
		}

		// Token: 0x06021EBF RID: 138943 RVA: 0x004B4B42 File Offset: 0x004B2D42
		public static void AddRightCondition(FlatBufferBuilder builder, Offset<IConditionGroup> rightConditionOffset)
		{
			builder.AddOffset(2, rightConditionOffset.Value, 0);
		}

		// Token: 0x06021EC0 RID: 138944 RVA: 0x004B4B52 File Offset: 0x004B2D52
		public static Offset<IEntityTrackControlPoint> EndIEntityTrackControlPoint(FlatBufferBuilder builder)
		{
			return new Offset<IEntityTrackControlPoint>(builder.EndTable());
		}

		// Token: 0x06021EC1 RID: 138945 RVA: 0x004B4B60 File Offset: 0x004B2D60
		public IEntityTrackControlPointT UnPack()
		{
			IEntityTrackControlPointT entityTrackControlPointT = new IEntityTrackControlPointT();
			this.UnPackTo(entityTrackControlPointT);
			return entityTrackControlPointT;
		}

		// Token: 0x06021EC2 RID: 138946 RVA: 0x004B4B7C File Offset: 0x004B2D7C
		public void UnPackTo(IEntityTrackControlPointT _o)
		{
			_o.State = this.State;
			_o.LeftCondition = ((this.LeftCondition != null) ? this.LeftCondition.Value.UnPack() : null);
			_o.RightCondition = ((this.RightCondition != null) ? this.RightCondition.Value.UnPack() : null);
		}

		// Token: 0x06021EC3 RID: 138947 RVA: 0x004B4BF4 File Offset: 0x004B2DF4
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

		// Token: 0x0400E2BC RID: 58044
		private Table __p;
	}
}
