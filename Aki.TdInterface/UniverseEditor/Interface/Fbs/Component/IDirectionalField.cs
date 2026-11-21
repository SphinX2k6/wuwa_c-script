using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055EF RID: 21999
	public struct IDirectionalField : IFlatbufferObject
	{
		// Token: 0x17009DA6 RID: 40358
		// (get) Token: 0x060230BB RID: 143547 RVA: 0x004D3117 File Offset: 0x004D1317
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060230BC RID: 143548 RVA: 0x004D3124 File Offset: 0x004D1324
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060230BD RID: 143549 RVA: 0x004D312C File Offset: 0x004D132C
		public static IDirectionalField GetRootAsIDirectionalField(ByteBuffer _bb)
		{
			return IDirectionalField.GetRootAsIDirectionalField(_bb, default(IDirectionalField));
		}

		// Token: 0x060230BE RID: 143550 RVA: 0x004D3148 File Offset: 0x004D1348
		public static IDirectionalField GetRootAsIDirectionalField(ByteBuffer _bb, IDirectionalField obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060230BF RID: 143551 RVA: 0x004D3165 File Offset: 0x004D1365
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060230C0 RID: 143552 RVA: 0x004D3174 File Offset: 0x004D1374
		public IDirectionalField __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009DA7 RID: 40359
		// (get) Token: 0x060230C1 RID: 143553 RVA: 0x004D3184 File Offset: 0x004D1384
		public EConveyorBeltFieldType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EConveyorBeltFieldType.DirectionalField;
				}
				return (EConveyorBeltFieldType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009DA8 RID: 40360
		// (get) Token: 0x060230C2 RID: 143554 RVA: 0x004D31C0 File Offset: 0x004D13C0
		public IVectorInfo? Direction
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060230C3 RID: 143555 RVA: 0x004D321D File Offset: 0x004D141D
		public static Offset<IDirectionalField> CreateIDirectionalField(FlatBufferBuilder builder, EConveyorBeltFieldType Type = EConveyorBeltFieldType.DirectionalField, Offset<IVectorInfo> DirectionOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			IDirectionalField.AddDirection(builder, DirectionOffset);
			IDirectionalField.AddType(builder, Type);
			return IDirectionalField.EndIDirectionalField(builder);
		}

		// Token: 0x060230C4 RID: 143556 RVA: 0x004D323A File Offset: 0x004D143A
		public static void StartIDirectionalField(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060230C5 RID: 143557 RVA: 0x004D3243 File Offset: 0x004D1443
		public static void AddType(FlatBufferBuilder builder, EConveyorBeltFieldType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060230C6 RID: 143558 RVA: 0x004D324E File Offset: 0x004D144E
		public static void AddDirection(FlatBufferBuilder builder, Offset<IVectorInfo> directionOffset)
		{
			builder.AddOffset(1, directionOffset.Value, 0);
		}

		// Token: 0x060230C7 RID: 143559 RVA: 0x004D325E File Offset: 0x004D145E
		public static Offset<IDirectionalField> EndIDirectionalField(FlatBufferBuilder builder)
		{
			return new Offset<IDirectionalField>(builder.EndTable());
		}

		// Token: 0x060230C8 RID: 143560 RVA: 0x004D326C File Offset: 0x004D146C
		public IDirectionalFieldT UnPack()
		{
			IDirectionalFieldT directionalFieldT = new IDirectionalFieldT();
			this.UnPackTo(directionalFieldT);
			return directionalFieldT;
		}

		// Token: 0x060230C9 RID: 143561 RVA: 0x004D3288 File Offset: 0x004D1488
		public void UnPackTo(IDirectionalFieldT _o)
		{
			_o.Type = this.Type;
			_o.Direction = ((this.Direction != null) ? this.Direction.Value.UnPack() : null);
		}

		// Token: 0x060230CA RID: 143562 RVA: 0x004D32D0 File Offset: 0x004D14D0
		public static Offset<IDirectionalField> Pack(FlatBufferBuilder builder, IDirectionalFieldT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDirectionalField>);
			}
			Offset<IVectorInfo> directionOffset = (_o.Direction == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Direction);
			return IDirectionalField.CreateIDirectionalField(builder, _o.Type, directionOffset);
		}

		// Token: 0x0400EC9D RID: 60573
		private Table __p;
	}
}
