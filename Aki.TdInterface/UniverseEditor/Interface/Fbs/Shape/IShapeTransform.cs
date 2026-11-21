using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x0200404C RID: 16460
	public struct IShapeTransform : IFlatbufferObject
	{
		// Token: 0x17006FEC RID: 28652
		// (get) Token: 0x060169E1 RID: 92641 RVA: 0x0033C128 File Offset: 0x0033A328
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060169E2 RID: 92642 RVA: 0x0033C135 File Offset: 0x0033A335
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060169E3 RID: 92643 RVA: 0x0033C13C File Offset: 0x0033A33C
		public static IShapeTransform GetRootAsIShapeTransform(ByteBuffer _bb)
		{
			return IShapeTransform.GetRootAsIShapeTransform(_bb, default(IShapeTransform));
		}

		// Token: 0x060169E4 RID: 92644 RVA: 0x0033C158 File Offset: 0x0033A358
		public static IShapeTransform GetRootAsIShapeTransform(ByteBuffer _bb, IShapeTransform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060169E5 RID: 92645 RVA: 0x0033C175 File Offset: 0x0033A375
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060169E6 RID: 92646 RVA: 0x0033C184 File Offset: 0x0033A384
		public IShapeTransform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006FED RID: 28653
		// (get) Token: 0x060169E7 RID: 92647 RVA: 0x0033C194 File Offset: 0x0033A394
		public IVectorInfo? Pos
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17006FEE RID: 28654
		// (get) Token: 0x060169E8 RID: 92648 RVA: 0x0033C1F4 File Offset: 0x0033A3F4
		public IVectorInfo? Rot
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

		// Token: 0x17006FEF RID: 28655
		// (get) Token: 0x060169E9 RID: 92649 RVA: 0x0033C254 File Offset: 0x0033A454
		public IVectorInfo? Scale
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

		// Token: 0x060169EA RID: 92650 RVA: 0x0033C2B1 File Offset: 0x0033A4B1
		public static Offset<IShapeTransform> CreateIShapeTransform(FlatBufferBuilder builder, Offset<IVectorInfo> PosOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> RotOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> ScaleOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(3);
			IShapeTransform.AddScale(builder, ScaleOffset);
			IShapeTransform.AddRot(builder, RotOffset);
			IShapeTransform.AddPos(builder, PosOffset);
			return IShapeTransform.EndIShapeTransform(builder);
		}

		// Token: 0x060169EB RID: 92651 RVA: 0x0033C2D5 File Offset: 0x0033A4D5
		public static void StartIShapeTransform(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060169EC RID: 92652 RVA: 0x0033C2DE File Offset: 0x0033A4DE
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(0, posOffset.Value, 0);
		}

		// Token: 0x060169ED RID: 92653 RVA: 0x0033C2EE File Offset: 0x0033A4EE
		public static void AddRot(FlatBufferBuilder builder, Offset<IVectorInfo> rotOffset)
		{
			builder.AddOffset(1, rotOffset.Value, 0);
		}

		// Token: 0x060169EE RID: 92654 RVA: 0x0033C2FE File Offset: 0x0033A4FE
		public static void AddScale(FlatBufferBuilder builder, Offset<IVectorInfo> scaleOffset)
		{
			builder.AddOffset(2, scaleOffset.Value, 0);
		}

		// Token: 0x060169EF RID: 92655 RVA: 0x0033C30E File Offset: 0x0033A50E
		public static Offset<IShapeTransform> EndIShapeTransform(FlatBufferBuilder builder)
		{
			return new Offset<IShapeTransform>(builder.EndTable());
		}

		// Token: 0x060169F0 RID: 92656 RVA: 0x0033C31C File Offset: 0x0033A51C
		public IShapeTransformT UnPack()
		{
			IShapeTransformT shapeTransformT = new IShapeTransformT();
			this.UnPackTo(shapeTransformT);
			return shapeTransformT;
		}

		// Token: 0x060169F1 RID: 92657 RVA: 0x0033C338 File Offset: 0x0033A538
		public void UnPackTo(IShapeTransformT _o)
		{
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
			_o.Rot = ((this.Rot != null) ? this.Rot.Value.UnPack() : null);
			_o.Scale = ((this.Scale != null) ? this.Scale.Value.UnPack() : null);
		}

		// Token: 0x060169F2 RID: 92658 RVA: 0x0033C3D4 File Offset: 0x0033A5D4
		public static Offset<IShapeTransform> Pack(FlatBufferBuilder builder, IShapeTransformT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShapeTransform>);
			}
			Offset<IVectorInfo> posOffset = (_o.Pos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Pos);
			Offset<IVectorInfo> rotOffset = (_o.Rot == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Rot);
			Offset<IVectorInfo> scaleOffset = (_o.Scale == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Scale);
			return IShapeTransform.CreateIShapeTransform(builder, posOffset, rotOffset, scaleOffset);
		}

		// Token: 0x0400BBD2 RID: 48082
		private Table __p;
	}
}
