using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C10 RID: 15376
	public struct ICylinderTriggerShape : IFlatbufferObject
	{
		// Token: 0x170069B3 RID: 27059
		// (get) Token: 0x06015305 RID: 86789 RVA: 0x00311BD0 File Offset: 0x0030FDD0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015306 RID: 86790 RVA: 0x00311BDD File Offset: 0x0030FDDD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015307 RID: 86791 RVA: 0x00311BE4 File Offset: 0x0030FDE4
		public static ICylinderTriggerShape GetRootAsICylinderTriggerShape(ByteBuffer _bb)
		{
			return ICylinderTriggerShape.GetRootAsICylinderTriggerShape(_bb, default(ICylinderTriggerShape));
		}

		// Token: 0x06015308 RID: 86792 RVA: 0x00311C00 File Offset: 0x0030FE00
		public static ICylinderTriggerShape GetRootAsICylinderTriggerShape(ByteBuffer _bb, ICylinderTriggerShape obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015309 RID: 86793 RVA: 0x00311C1D File Offset: 0x0030FE1D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601530A RID: 86794 RVA: 0x00311C2C File Offset: 0x0030FE2C
		public ICylinderTriggerShape __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170069B4 RID: 27060
		// (get) Token: 0x0601530B RID: 86795 RVA: 0x00311C3C File Offset: 0x0030FE3C
		public ETriggerShape Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETriggerShape.Box;
				}
				return (ETriggerShape)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170069B5 RID: 27061
		// (get) Token: 0x0601530C RID: 86796 RVA: 0x00311C78 File Offset: 0x0030FE78
		public IVectorInfo? Center
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

		// Token: 0x170069B6 RID: 27062
		// (get) Token: 0x0601530D RID: 86797 RVA: 0x00311CD8 File Offset: 0x0030FED8
		public int Radius
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

		// Token: 0x170069B7 RID: 27063
		// (get) Token: 0x0601530E RID: 86798 RVA: 0x00311D14 File Offset: 0x0030FF14
		public int Height
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601530F RID: 86799 RVA: 0x00311D51 File Offset: 0x0030FF51
		public static Offset<ICylinderTriggerShape> CreateICylinderTriggerShape(FlatBufferBuilder builder, ETriggerShape Type = ETriggerShape.Box, Offset<IVectorInfo> CenterOffset = default(Offset<IVectorInfo>), int Radius = 0, int Height = 0)
		{
			builder.StartTable(4);
			ICylinderTriggerShape.AddHeight(builder, Height);
			ICylinderTriggerShape.AddRadius(builder, Radius);
			ICylinderTriggerShape.AddCenter(builder, CenterOffset);
			ICylinderTriggerShape.AddType(builder, Type);
			return ICylinderTriggerShape.EndICylinderTriggerShape(builder);
		}

		// Token: 0x06015310 RID: 86800 RVA: 0x00311D7D File Offset: 0x0030FF7D
		public static void StartICylinderTriggerShape(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06015311 RID: 86801 RVA: 0x00311D86 File Offset: 0x0030FF86
		public static void AddType(FlatBufferBuilder builder, ETriggerShape type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015312 RID: 86802 RVA: 0x00311D91 File Offset: 0x0030FF91
		public static void AddCenter(FlatBufferBuilder builder, Offset<IVectorInfo> centerOffset)
		{
			builder.AddOffset(1, centerOffset.Value, 0);
		}

		// Token: 0x06015313 RID: 86803 RVA: 0x00311DA1 File Offset: 0x0030FFA1
		public static void AddRadius(FlatBufferBuilder builder, int radius)
		{
			builder.AddInt(2, radius, 0);
		}

		// Token: 0x06015314 RID: 86804 RVA: 0x00311DAC File Offset: 0x0030FFAC
		public static void AddHeight(FlatBufferBuilder builder, int height)
		{
			builder.AddInt(3, height, 0);
		}

		// Token: 0x06015315 RID: 86805 RVA: 0x00311DB7 File Offset: 0x0030FFB7
		public static Offset<ICylinderTriggerShape> EndICylinderTriggerShape(FlatBufferBuilder builder)
		{
			return new Offset<ICylinderTriggerShape>(builder.EndTable());
		}

		// Token: 0x06015316 RID: 86806 RVA: 0x00311DC4 File Offset: 0x0030FFC4
		public ICylinderTriggerShapeT UnPack()
		{
			ICylinderTriggerShapeT cylinderTriggerShapeT = new ICylinderTriggerShapeT();
			this.UnPackTo(cylinderTriggerShapeT);
			return cylinderTriggerShapeT;
		}

		// Token: 0x06015317 RID: 86807 RVA: 0x00311DE0 File Offset: 0x0030FFE0
		public void UnPackTo(ICylinderTriggerShapeT _o)
		{
			_o.Type = this.Type;
			_o.Center = ((this.Center != null) ? this.Center.Value.UnPack() : null);
			_o.Radius = this.Radius;
			_o.Height = this.Height;
		}

		// Token: 0x06015318 RID: 86808 RVA: 0x00311E40 File Offset: 0x00310040
		public static Offset<ICylinderTriggerShape> Pack(FlatBufferBuilder builder, ICylinderTriggerShapeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICylinderTriggerShape>);
			}
			Offset<IVectorInfo> centerOffset = (_o.Center == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Center);
			return ICylinderTriggerShape.CreateICylinderTriggerShape(builder, _o.Type, centerOffset, _o.Radius, _o.Height);
		}

		// Token: 0x0400B1F0 RID: 45552
		private Table __p;
	}
}
