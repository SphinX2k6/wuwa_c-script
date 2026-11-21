using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056B8 RID: 22200
	public struct IEntityAttachTarget : IFlatbufferObject
	{
		// Token: 0x17009FC3 RID: 40899
		// (get) Token: 0x060238FA RID: 145658 RVA: 0x004E3E10 File Offset: 0x004E2010
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060238FB RID: 145659 RVA: 0x004E3E1D File Offset: 0x004E201D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060238FC RID: 145660 RVA: 0x004E3E24 File Offset: 0x004E2024
		public static IEntityAttachTarget GetRootAsIEntityAttachTarget(ByteBuffer _bb)
		{
			return IEntityAttachTarget.GetRootAsIEntityAttachTarget(_bb, default(IEntityAttachTarget));
		}

		// Token: 0x060238FD RID: 145661 RVA: 0x004E3E40 File Offset: 0x004E2040
		public static IEntityAttachTarget GetRootAsIEntityAttachTarget(ByteBuffer _bb, IEntityAttachTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060238FE RID: 145662 RVA: 0x004E3E5D File Offset: 0x004E205D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060238FF RID: 145663 RVA: 0x004E3E6C File Offset: 0x004E206C
		public IEntityAttachTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009FC4 RID: 40900
		// (get) Token: 0x06023900 RID: 145664 RVA: 0x004E3E7C File Offset: 0x004E207C
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

		// Token: 0x17009FC5 RID: 40901
		// (get) Token: 0x06023901 RID: 145665 RVA: 0x004E3EB8 File Offset: 0x004E20B8
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

		// Token: 0x17009FC6 RID: 40902
		// (get) Token: 0x06023902 RID: 145666 RVA: 0x004E3EF4 File Offset: 0x004E20F4
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

		// Token: 0x06023903 RID: 145667 RVA: 0x004E3F2B File Offset: 0x004E212B
		public Span<byte> GetAttachPointBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06023904 RID: 145668 RVA: 0x004E3F3A File Offset: 0x004E213A
		public byte[] GetAttachPointArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17009FC7 RID: 40903
		// (get) Token: 0x06023905 RID: 145669 RVA: 0x004E3F48 File Offset: 0x004E2148
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

		// Token: 0x06023906 RID: 145670 RVA: 0x004E3FA6 File Offset: 0x004E21A6
		public static Offset<IEntityAttachTarget> CreateIEntityAttachTarget(FlatBufferBuilder builder, EAttachType Type = EAttachType.Actor, int EntityId = 0, StringOffset AttachPointOffset = default(StringOffset), Offset<IVectorInfo> PosOffsetOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(4);
			IEntityAttachTarget.AddPosOffset(builder, PosOffsetOffset);
			IEntityAttachTarget.AddAttachPoint(builder, AttachPointOffset);
			IEntityAttachTarget.AddEntityId(builder, EntityId);
			IEntityAttachTarget.AddType(builder, Type);
			return IEntityAttachTarget.EndIEntityAttachTarget(builder);
		}

		// Token: 0x06023907 RID: 145671 RVA: 0x004E3FD2 File Offset: 0x004E21D2
		public static void StartIEntityAttachTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06023908 RID: 145672 RVA: 0x004E3FDB File Offset: 0x004E21DB
		public static void AddType(FlatBufferBuilder builder, EAttachType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06023909 RID: 145673 RVA: 0x004E3FE6 File Offset: 0x004E21E6
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0602390A RID: 145674 RVA: 0x004E3FF1 File Offset: 0x004E21F1
		public static void AddAttachPoint(FlatBufferBuilder builder, StringOffset attachPointOffset)
		{
			builder.AddOffset(2, attachPointOffset.Value, 0);
		}

		// Token: 0x0602390B RID: 145675 RVA: 0x004E4001 File Offset: 0x004E2201
		public static void AddPosOffset(FlatBufferBuilder builder, Offset<IVectorInfo> posOffsetOffset)
		{
			builder.AddOffset(3, posOffsetOffset.Value, 0);
		}

		// Token: 0x0602390C RID: 145676 RVA: 0x004E4011 File Offset: 0x004E2211
		public static Offset<IEntityAttachTarget> EndIEntityAttachTarget(FlatBufferBuilder builder)
		{
			return new Offset<IEntityAttachTarget>(builder.EndTable());
		}

		// Token: 0x0602390D RID: 145677 RVA: 0x004E4020 File Offset: 0x004E2220
		public IEntityAttachTargetT UnPack()
		{
			IEntityAttachTargetT entityAttachTargetT = new IEntityAttachTargetT();
			this.UnPackTo(entityAttachTargetT);
			return entityAttachTargetT;
		}

		// Token: 0x0602390E RID: 145678 RVA: 0x004E403C File Offset: 0x004E223C
		public void UnPackTo(IEntityAttachTargetT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.AttachPoint = this.AttachPoint;
			_o.PosOffset = ((this.PosOffset != null) ? this.PosOffset.Value.UnPack() : null);
		}

		// Token: 0x0602390F RID: 145679 RVA: 0x004E409C File Offset: 0x004E229C
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

		// Token: 0x0400EDEC RID: 60908
		private Table __p;
	}
}
