using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054D8 RID: 21720
	public struct ICircuitConnectLayout : IFlatbufferObject
	{
		// Token: 0x17009B2B RID: 39723
		// (get) Token: 0x06022487 RID: 140423 RVA: 0x004B9CEE File Offset: 0x004B7EEE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022488 RID: 140424 RVA: 0x004B9CFB File Offset: 0x004B7EFB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022489 RID: 140425 RVA: 0x004B9D04 File Offset: 0x004B7F04
		public static ICircuitConnectLayout GetRootAsICircuitConnectLayout(ByteBuffer _bb)
		{
			return ICircuitConnectLayout.GetRootAsICircuitConnectLayout(_bb, default(ICircuitConnectLayout));
		}

		// Token: 0x0602248A RID: 140426 RVA: 0x004B9D20 File Offset: 0x004B7F20
		public static ICircuitConnectLayout GetRootAsICircuitConnectLayout(ByteBuffer _bb, ICircuitConnectLayout obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602248B RID: 140427 RVA: 0x004B9D3D File Offset: 0x004B7F3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602248C RID: 140428 RVA: 0x004B9D4C File Offset: 0x004B7F4C
		public ICircuitConnectLayout __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009B2C RID: 39724
		// (get) Token: 0x0602248D RID: 140429 RVA: 0x004B9D5C File Offset: 0x004B7F5C
		public TCircuitConnectLayoutType ElementTypeType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TCircuitConnectLayoutType.NONE;
				}
				return (TCircuitConnectLayoutType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602248E RID: 140430 RVA: 0x004B9D98 File Offset: 0x004B7F98
		public TTable? ElementType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602248F RID: 140431 RVA: 0x004B9DDC File Offset: 0x004B7FDC
		public ICircuitConnectCurveLayout ElementTypeAsICircuitConnectCurveLayout()
		{
			return this.ElementType<ICircuitConnectCurveLayout>().Value;
		}

		// Token: 0x06022490 RID: 140432 RVA: 0x004B9DF8 File Offset: 0x004B7FF8
		public ICircuitConnectOutputPortLayout ElementTypeAsICircuitConnectOutputPortLayout()
		{
			return this.ElementType<ICircuitConnectOutputPortLayout>().Value;
		}

		// Token: 0x06022491 RID: 140433 RVA: 0x004B9E14 File Offset: 0x004B8014
		public ICircuitConnectPowerPortLayout ElementTypeAsICircuitConnectPowerPortLayout()
		{
			return this.ElementType<ICircuitConnectPowerPortLayout>().Value;
		}

		// Token: 0x06022492 RID: 140434 RVA: 0x004B9E30 File Offset: 0x004B8030
		public ICircuitConnectStraightLayout ElementTypeAsICircuitConnectStraightLayout()
		{
			return this.ElementType<ICircuitConnectStraightLayout>().Value;
		}

		// Token: 0x17009B2D RID: 39725
		// (get) Token: 0x06022493 RID: 140435 RVA: 0x004B9E4C File Offset: 0x004B804C
		public IVectorInfo? Position
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009B2E RID: 39726
		// (get) Token: 0x06022494 RID: 140436 RVA: 0x004B9EAC File Offset: 0x004B80AC
		public IVectorInfo? Rotation
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

		// Token: 0x06022495 RID: 140437 RVA: 0x004B9F0A File Offset: 0x004B810A
		public static Offset<ICircuitConnectLayout> CreateICircuitConnectLayout(FlatBufferBuilder builder, TCircuitConnectLayoutType ElementType_type = TCircuitConnectLayoutType.NONE, int ElementTypeOffset = 0, Offset<IVectorInfo> PositionOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> RotationOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(4);
			ICircuitConnectLayout.AddRotation(builder, RotationOffset);
			ICircuitConnectLayout.AddPosition(builder, PositionOffset);
			ICircuitConnectLayout.AddElementType(builder, ElementTypeOffset);
			ICircuitConnectLayout.AddElementTypeType(builder, ElementType_type);
			return ICircuitConnectLayout.EndICircuitConnectLayout(builder);
		}

		// Token: 0x06022496 RID: 140438 RVA: 0x004B9F36 File Offset: 0x004B8136
		public static void StartICircuitConnectLayout(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06022497 RID: 140439 RVA: 0x004B9F3F File Offset: 0x004B813F
		public static void AddElementTypeType(FlatBufferBuilder builder, TCircuitConnectLayoutType elementTypeType)
		{
			builder.AddByte(0, (byte)elementTypeType, 0);
		}

		// Token: 0x06022498 RID: 140440 RVA: 0x004B9F4A File Offset: 0x004B814A
		public static void AddElementType(FlatBufferBuilder builder, int elementTypeOffset)
		{
			builder.AddOffset(1, elementTypeOffset, 0);
		}

		// Token: 0x06022499 RID: 140441 RVA: 0x004B9F55 File Offset: 0x004B8155
		public static void AddPosition(FlatBufferBuilder builder, Offset<IVectorInfo> positionOffset)
		{
			builder.AddOffset(2, positionOffset.Value, 0);
		}

		// Token: 0x0602249A RID: 140442 RVA: 0x004B9F65 File Offset: 0x004B8165
		public static void AddRotation(FlatBufferBuilder builder, Offset<IVectorInfo> rotationOffset)
		{
			builder.AddOffset(3, rotationOffset.Value, 0);
		}

		// Token: 0x0602249B RID: 140443 RVA: 0x004B9F75 File Offset: 0x004B8175
		public static Offset<ICircuitConnectLayout> EndICircuitConnectLayout(FlatBufferBuilder builder)
		{
			return new Offset<ICircuitConnectLayout>(builder.EndTable());
		}

		// Token: 0x0602249C RID: 140444 RVA: 0x004B9F84 File Offset: 0x004B8184
		public ICircuitConnectLayoutT UnPack()
		{
			ICircuitConnectLayoutT circuitConnectLayoutT = new ICircuitConnectLayoutT();
			this.UnPackTo(circuitConnectLayoutT);
			return circuitConnectLayoutT;
		}

		// Token: 0x0602249D RID: 140445 RVA: 0x004B9FA0 File Offset: 0x004B81A0
		public void UnPackTo(ICircuitConnectLayoutT _o)
		{
			_o.ElementType = new TCircuitConnectLayoutTypeUnion();
			_o.ElementType.Type = this.ElementTypeType;
			switch (this.ElementTypeType)
			{
			case TCircuitConnectLayoutType.ICircuitConnectCurveLayout:
				_o.ElementType.Value = ((this.ElementType<ICircuitConnectCurveLayout>() != null) ? this.ElementType<ICircuitConnectCurveLayout>().Value.UnPack() : null);
				break;
			case TCircuitConnectLayoutType.ICircuitConnectOutputPortLayout:
				_o.ElementType.Value = ((this.ElementType<ICircuitConnectOutputPortLayout>() != null) ? this.ElementType<ICircuitConnectOutputPortLayout>().Value.UnPack() : null);
				break;
			case TCircuitConnectLayoutType.ICircuitConnectPowerPortLayout:
				_o.ElementType.Value = ((this.ElementType<ICircuitConnectPowerPortLayout>() != null) ? this.ElementType<ICircuitConnectPowerPortLayout>().Value.UnPack() : null);
				break;
			case TCircuitConnectLayoutType.ICircuitConnectStraightLayout:
				_o.ElementType.Value = ((this.ElementType<ICircuitConnectStraightLayout>() != null) ? this.ElementType<ICircuitConnectStraightLayout>().Value.UnPack() : null);
				break;
			}
			_o.Position = ((this.Position != null) ? this.Position.Value.UnPack() : null);
			_o.Rotation = ((this.Rotation != null) ? this.Rotation.Value.UnPack() : null);
		}

		// Token: 0x0602249E RID: 140446 RVA: 0x004BA134 File Offset: 0x004B8334
		public static Offset<ICircuitConnectLayout> Pack(FlatBufferBuilder builder, ICircuitConnectLayoutT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICircuitConnectLayout>);
			}
			TCircuitConnectLayoutType elementType_type = (_o.ElementType == null) ? TCircuitConnectLayoutType.NONE : _o.ElementType.Type;
			int elementTypeOffset = (_o.ElementType == null) ? 0 : TCircuitConnectLayoutTypeUnion.Pack(builder, _o.ElementType);
			Offset<IVectorInfo> positionOffset = (_o.Position == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Position);
			Offset<IVectorInfo> rotationOffset = (_o.Rotation == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Rotation);
			return ICircuitConnectLayout.CreateICircuitConnectLayout(builder, elementType_type, elementTypeOffset, positionOffset, rotationOffset);
		}

		// Token: 0x0400EA2B RID: 59947
		private Table __p;
	}
}
