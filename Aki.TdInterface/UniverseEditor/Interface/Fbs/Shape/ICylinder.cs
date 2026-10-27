using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C07 RID: 15367
	public struct ICylinder : IFlatbufferObject
	{
		// Token: 0x17006992 RID: 27026
		// (get) Token: 0x0601529F RID: 86687 RVA: 0x00310FF7 File Offset: 0x0030F1F7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060152A0 RID: 86688 RVA: 0x00311004 File Offset: 0x0030F204
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060152A1 RID: 86689 RVA: 0x0031100C File Offset: 0x0030F20C
		public static ICylinder GetRootAsICylinder(ByteBuffer _bb)
		{
			return ICylinder.GetRootAsICylinder(_bb, default(ICylinder));
		}

		// Token: 0x060152A2 RID: 86690 RVA: 0x00311028 File Offset: 0x0030F228
		public static ICylinder GetRootAsICylinder(ByteBuffer _bb, ICylinder obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060152A3 RID: 86691 RVA: 0x00311045 File Offset: 0x0030F245
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060152A4 RID: 86692 RVA: 0x00311054 File Offset: 0x0030F254
		public ICylinder __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006993 RID: 27027
		// (get) Token: 0x060152A5 RID: 86693 RVA: 0x00311064 File Offset: 0x0030F264
		public ERangeType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERangeType.CircleRange;
				}
				return (ERangeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006994 RID: 27028
		// (get) Token: 0x060152A6 RID: 86694 RVA: 0x003110A0 File Offset: 0x0030F2A0
		public IVectorInfo? Pos
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

		// Token: 0x17006995 RID: 27029
		// (get) Token: 0x060152A7 RID: 86695 RVA: 0x00311100 File Offset: 0x0030F300
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

		// Token: 0x17006996 RID: 27030
		// (get) Token: 0x060152A8 RID: 86696 RVA: 0x0031113C File Offset: 0x0030F33C
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

		// Token: 0x060152A9 RID: 86697 RVA: 0x00311179 File Offset: 0x0030F379
		public static Offset<ICylinder> CreateICylinder(FlatBufferBuilder builder, ERangeType Type = ERangeType.CircleRange, Offset<IVectorInfo> PosOffset = default(Offset<IVectorInfo>), int Radius = 0, int Height = 0)
		{
			builder.StartTable(4);
			ICylinder.AddHeight(builder, Height);
			ICylinder.AddRadius(builder, Radius);
			ICylinder.AddPos(builder, PosOffset);
			ICylinder.AddType(builder, Type);
			return ICylinder.EndICylinder(builder);
		}

		// Token: 0x060152AA RID: 86698 RVA: 0x003111A5 File Offset: 0x0030F3A5
		public static void StartICylinder(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060152AB RID: 86699 RVA: 0x003111AE File Offset: 0x0030F3AE
		public static void AddType(FlatBufferBuilder builder, ERangeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060152AC RID: 86700 RVA: 0x003111B9 File Offset: 0x0030F3B9
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(1, posOffset.Value, 0);
		}

		// Token: 0x060152AD RID: 86701 RVA: 0x003111C9 File Offset: 0x0030F3C9
		public static void AddRadius(FlatBufferBuilder builder, int radius)
		{
			builder.AddInt(2, radius, 0);
		}

		// Token: 0x060152AE RID: 86702 RVA: 0x003111D4 File Offset: 0x0030F3D4
		public static void AddHeight(FlatBufferBuilder builder, int height)
		{
			builder.AddInt(3, height, 0);
		}

		// Token: 0x060152AF RID: 86703 RVA: 0x003111DF File Offset: 0x0030F3DF
		public static Offset<ICylinder> EndICylinder(FlatBufferBuilder builder)
		{
			return new Offset<ICylinder>(builder.EndTable());
		}

		// Token: 0x060152B0 RID: 86704 RVA: 0x003111EC File Offset: 0x0030F3EC
		public ICylinderT UnPack()
		{
			ICylinderT cylinderT = new ICylinderT();
			this.UnPackTo(cylinderT);
			return cylinderT;
		}

		// Token: 0x060152B1 RID: 86705 RVA: 0x00311208 File Offset: 0x0030F408
		public void UnPackTo(ICylinderT _o)
		{
			_o.Type = this.Type;
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
			_o.Radius = this.Radius;
			_o.Height = this.Height;
		}

		// Token: 0x060152B2 RID: 86706 RVA: 0x00311268 File Offset: 0x0030F468
		public static Offset<ICylinder> Pack(FlatBufferBuilder builder, ICylinderT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICylinder>);
			}
			Offset<IVectorInfo> posOffset = (_o.Pos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Pos);
			return ICylinder.CreateICylinder(builder, _o.Type, posOffset, _o.Radius, _o.Height);
		}

		// Token: 0x0400B1DE RID: 45534
		private Table __p;
	}
}
