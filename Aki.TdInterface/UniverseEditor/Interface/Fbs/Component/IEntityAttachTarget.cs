using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005153 RID: 20819
	public struct IEntityAttachTarget : IFlatbufferObject
	{
		// Token: 0x170097D6 RID: 38870
		// (get) Token: 0x060219A6 RID: 137638 RVA: 0x004A9E84 File Offset: 0x004A8084
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060219A7 RID: 137639 RVA: 0x004A9E91 File Offset: 0x004A8091
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060219A8 RID: 137640 RVA: 0x004A9E98 File Offset: 0x004A8098
		public static IEntityAttachTarget GetRootAsIEntityAttachTarget(ByteBuffer _bb)
		{
			return IEntityAttachTarget.GetRootAsIEntityAttachTarget(_bb, default(IEntityAttachTarget));
		}

		// Token: 0x060219A9 RID: 137641 RVA: 0x004A9EB4 File Offset: 0x004A80B4
		public static IEntityAttachTarget GetRootAsIEntityAttachTarget(ByteBuffer _bb, IEntityAttachTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060219AA RID: 137642 RVA: 0x004A9ED1 File Offset: 0x004A80D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060219AB RID: 137643 RVA: 0x004A9EE0 File Offset: 0x004A80E0
		public IEntityAttachTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170097D7 RID: 38871
		// (get) Token: 0x060219AC RID: 137644 RVA: 0x004A9EF0 File Offset: 0x004A80F0
		public EAttachType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAttachType.Actor;
				}
				return (EAttachType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170097D8 RID: 38872
		// (get) Token: 0x060219AD RID: 137645 RVA: 0x004A9F2C File Offset: 0x004A812C
		public int EntityId
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

		// Token: 0x170097D9 RID: 38873
		// (get) Token: 0x060219AE RID: 137646 RVA: 0x004A9F68 File Offset: 0x004A8168
		public string AttachPoint
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060219AF RID: 137647 RVA: 0x004A9F9F File Offset: 0x004A819F
		public Span<byte> GetAttachPointBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060219B0 RID: 137648 RVA: 0x004A9FAE File Offset: 0x004A81AE
		public byte[] GetAttachPointArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x170097DA RID: 38874
		// (get) Token: 0x060219B1 RID: 137649 RVA: 0x004A9FBC File Offset: 0x004A81BC
		public IVectorInfo? PosOffset
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060219B2 RID: 137650 RVA: 0x004AA01A File Offset: 0x004A821A
		public static Offset<IEntityAttachTarget> CreateIEntityAttachTarget(FlatBufferBuilder builder, EAttachType Type = EAttachType.Actor, int EntityId = 0, StringOffset AttachPointOffset = default(StringOffset), Offset<IVectorInfo> PosOffsetOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(4);
			IEntityAttachTarget.AddPosOffset(builder, PosOffsetOffset);
			IEntityAttachTarget.AddAttachPoint(builder, AttachPointOffset);
			IEntityAttachTarget.AddEntityId(builder, EntityId);
			IEntityAttachTarget.AddType(builder, Type);
			return IEntityAttachTarget.EndIEntityAttachTarget(builder);
		}

		// Token: 0x060219B3 RID: 137651 RVA: 0x004AA046 File Offset: 0x004A8246
		public static void StartIEntityAttachTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060219B4 RID: 137652 RVA: 0x004AA04F File Offset: 0x004A824F
		public static void AddType(FlatBufferBuilder builder, EAttachType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060219B5 RID: 137653 RVA: 0x004AA05A File Offset: 0x004A825A
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x060219B6 RID: 137654 RVA: 0x004AA065 File Offset: 0x004A8265
		public static void AddAttachPoint(FlatBufferBuilder builder, StringOffset attachPointOffset)
		{
			builder.AddOffset(2, attachPointOffset.Value, 0);
		}

		// Token: 0x060219B7 RID: 137655 RVA: 0x004AA075 File Offset: 0x004A8275
		public static void AddPosOffset(FlatBufferBuilder builder, Offset<IVectorInfo> posOffsetOffset)
		{
			builder.AddOffset(3, posOffsetOffset.Value, 0);
		}

		// Token: 0x060219B8 RID: 137656 RVA: 0x004AA085 File Offset: 0x004A8285
		public static Offset<IEntityAttachTarget> EndIEntityAttachTarget(FlatBufferBuilder builder)
		{
			return new Offset<IEntityAttachTarget>(builder.EndTable());
		}

		// Token: 0x060219B9 RID: 137657 RVA: 0x004AA094 File Offset: 0x004A8294
		public IEntityAttachTargetT UnPack()
		{
			IEntityAttachTargetT entityAttachTargetT = new IEntityAttachTargetT();
			this.UnPackTo(entityAttachTargetT);
			return entityAttachTargetT;
		}

		// Token: 0x060219BA RID: 137658 RVA: 0x004AA0B0 File Offset: 0x004A82B0
		public void UnPackTo(IEntityAttachTargetT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.AttachPoint = this.AttachPoint;
			_o.PosOffset = ((this.PosOffset != null) ? this.PosOffset.Value.UnPack() : null);
		}

		// Token: 0x060219BB RID: 137659 RVA: 0x004AA110 File Offset: 0x004A8310
		public static Offset<IEntityAttachTarget> Pack(FlatBufferBuilder builder, IEntityAttachTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityAttachTarget>);
			}
			StringOffset attachPointOffset = (_o.AttachPoint == null) ? default(StringOffset) : builder.CreateString(_o.AttachPoint);
			Offset<IVectorInfo> posOffsetOffset = (_o.PosOffset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.PosOffset);
			return IEntityAttachTarget.CreateIEntityAttachTarget(builder, _o.Type, _o.EntityId, attachPointOffset, posOffsetOffset);
		}

		// Token: 0x0400E1EF RID: 57839
		private Table __p;
	}
}
