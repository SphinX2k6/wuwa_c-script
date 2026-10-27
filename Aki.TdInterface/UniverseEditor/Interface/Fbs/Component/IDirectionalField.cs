using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200508A RID: 20618
	public struct IDirectionalField : IFlatbufferObject
	{
		// Token: 0x170095B9 RID: 38329
		// (get) Token: 0x06021167 RID: 135527 RVA: 0x0049918B File Offset: 0x0049738B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021168 RID: 135528 RVA: 0x00499198 File Offset: 0x00497398
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021169 RID: 135529 RVA: 0x004991A0 File Offset: 0x004973A0
		public static IDirectionalField GetRootAsIDirectionalField(ByteBuffer _bb)
		{
			return IDirectionalField.GetRootAsIDirectionalField(_bb, default(IDirectionalField));
		}

		// Token: 0x0602116A RID: 135530 RVA: 0x004991BC File Offset: 0x004973BC
		public static IDirectionalField GetRootAsIDirectionalField(ByteBuffer _bb, IDirectionalField obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602116B RID: 135531 RVA: 0x004991D9 File Offset: 0x004973D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602116C RID: 135532 RVA: 0x004991E8 File Offset: 0x004973E8
		public IDirectionalField __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170095BA RID: 38330
		// (get) Token: 0x0602116D RID: 135533 RVA: 0x004991F8 File Offset: 0x004973F8
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

		// Token: 0x170095BB RID: 38331
		// (get) Token: 0x0602116E RID: 135534 RVA: 0x00499234 File Offset: 0x00497434
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

		// Token: 0x0602116F RID: 135535 RVA: 0x00499291 File Offset: 0x00497491
		public static Offset<IDirectionalField> CreateIDirectionalField(FlatBufferBuilder builder, EConveyorBeltFieldType Type = EConveyorBeltFieldType.DirectionalField, Offset<IVectorInfo> DirectionOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			IDirectionalField.AddDirection(builder, DirectionOffset);
			IDirectionalField.AddType(builder, Type);
			return IDirectionalField.EndIDirectionalField(builder);
		}

		// Token: 0x06021170 RID: 135536 RVA: 0x004992AE File Offset: 0x004974AE
		public static void StartIDirectionalField(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06021171 RID: 135537 RVA: 0x004992B7 File Offset: 0x004974B7
		public static void AddType(FlatBufferBuilder builder, EConveyorBeltFieldType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06021172 RID: 135538 RVA: 0x004992C2 File Offset: 0x004974C2
		public static void AddDirection(FlatBufferBuilder builder, Offset<IVectorInfo> directionOffset)
		{
			builder.AddOffset(1, directionOffset.Value, 0);
		}

		// Token: 0x06021173 RID: 135539 RVA: 0x004992D2 File Offset: 0x004974D2
		public static Offset<IDirectionalField> EndIDirectionalField(FlatBufferBuilder builder)
		{
			return new Offset<IDirectionalField>(builder.EndTable());
		}

		// Token: 0x06021174 RID: 135540 RVA: 0x004992E0 File Offset: 0x004974E0
		public IDirectionalFieldT UnPack()
		{
			IDirectionalFieldT directionalFieldT = new IDirectionalFieldT();
			this.UnPackTo(directionalFieldT);
			return directionalFieldT;
		}

		// Token: 0x06021175 RID: 135541 RVA: 0x004992FC File Offset: 0x004974FC
		public void UnPackTo(IDirectionalFieldT _o)
		{
			_o.Type = this.Type;
			_o.Direction = ((this.Direction != null) ? this.Direction.Value.UnPack() : null);
		}

		// Token: 0x06021176 RID: 135542 RVA: 0x00499344 File Offset: 0x00497544
		public static Offset<IDirectionalField> Pack(FlatBufferBuilder builder, IDirectionalFieldT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDirectionalField>);
			}
			Offset<IVectorInfo> directionOffset = (_o.Direction == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Direction);
			return IDirectionalField.CreateIDirectionalField(builder, _o.Type, directionOffset);
		}

		// Token: 0x0400E0A0 RID: 57504
		private Table __p;
	}
}
