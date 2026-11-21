using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004013 RID: 16403
	public struct ICylinder : IFlatbufferObject
	{
		// Token: 0x17006F3A RID: 28474
		// (get) Token: 0x06016795 RID: 92053 RVA: 0x00337B7F File Offset: 0x00335D7F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016796 RID: 92054 RVA: 0x00337B8C File Offset: 0x00335D8C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016797 RID: 92055 RVA: 0x00337B94 File Offset: 0x00335D94
		public static ICylinder GetRootAsICylinder(ByteBuffer _bb)
		{
			return ICylinder.GetRootAsICylinder(_bb, default(ICylinder));
		}

		// Token: 0x06016798 RID: 92056 RVA: 0x00337BB0 File Offset: 0x00335DB0
		public static ICylinder GetRootAsICylinder(ByteBuffer _bb, ICylinder obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016799 RID: 92057 RVA: 0x00337BCD File Offset: 0x00335DCD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601679A RID: 92058 RVA: 0x00337BDC File Offset: 0x00335DDC
		public ICylinder __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006F3B RID: 28475
		// (get) Token: 0x0601679B RID: 92059 RVA: 0x00337BEC File Offset: 0x00335DEC
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

		// Token: 0x17006F3C RID: 28476
		// (get) Token: 0x0601679C RID: 92060 RVA: 0x00337C28 File Offset: 0x00335E28
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

		// Token: 0x17006F3D RID: 28477
		// (get) Token: 0x0601679D RID: 92061 RVA: 0x00337C88 File Offset: 0x00335E88
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

		// Token: 0x17006F3E RID: 28478
		// (get) Token: 0x0601679E RID: 92062 RVA: 0x00337CC4 File Offset: 0x00335EC4
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

		// Token: 0x0601679F RID: 92063 RVA: 0x00337D01 File Offset: 0x00335F01
		public static Offset<ICylinder> CreateICylinder(FlatBufferBuilder builder, ERangeType Type = ERangeType.CircleRange, Offset<IVectorInfo> PosOffset = default(Offset<IVectorInfo>), int Radius = 0, int Height = 0)
		{
			builder.StartTable(4);
			ICylinder.AddHeight(builder, Height);
			ICylinder.AddRadius(builder, Radius);
			ICylinder.AddPos(builder, PosOffset);
			ICylinder.AddType(builder, Type);
			return ICylinder.EndICylinder(builder);
		}

		// Token: 0x060167A0 RID: 92064 RVA: 0x00337D2D File Offset: 0x00335F2D
		public static void StartICylinder(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060167A1 RID: 92065 RVA: 0x00337D36 File Offset: 0x00335F36
		public static void AddType(FlatBufferBuilder builder, ERangeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060167A2 RID: 92066 RVA: 0x00337D41 File Offset: 0x00335F41
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(1, posOffset.Value, 0);
		}

		// Token: 0x060167A3 RID: 92067 RVA: 0x00337D51 File Offset: 0x00335F51
		public static void AddRadius(FlatBufferBuilder builder, int radius)
		{
			builder.AddInt(2, radius, 0);
		}

		// Token: 0x060167A4 RID: 92068 RVA: 0x00337D5C File Offset: 0x00335F5C
		public static void AddHeight(FlatBufferBuilder builder, int height)
		{
			builder.AddInt(3, height, 0);
		}

		// Token: 0x060167A5 RID: 92069 RVA: 0x00337D67 File Offset: 0x00335F67
		public static Offset<ICylinder> EndICylinder(FlatBufferBuilder builder)
		{
			return new Offset<ICylinder>(builder.EndTable());
		}

		// Token: 0x060167A6 RID: 92070 RVA: 0x00337D74 File Offset: 0x00335F74
		public ICylinderT UnPack()
		{
			ICylinderT cylinderT = new ICylinderT();
			this.UnPackTo(cylinderT);
			return cylinderT;
		}

		// Token: 0x060167A7 RID: 92071 RVA: 0x00337D90 File Offset: 0x00335F90
		public void UnPackTo(ICylinderT _o)
		{
			_o.Type = this.Type;
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
			_o.Radius = this.Radius;
			_o.Height = this.Height;
		}

		// Token: 0x060167A8 RID: 92072 RVA: 0x00337DF0 File Offset: 0x00335FF0
		public static Offset<ICylinder> Pack(FlatBufferBuilder builder, ICylinderT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICylinder>);
			}
			Offset<IVectorInfo> posOffset = (_o.Pos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Pos);
			return ICylinder.CreateICylinder(builder, _o.Type, posOffset, _o.Radius, _o.Height);
		}

		// Token: 0x0400BB69 RID: 47977
		private Table __p;
	}
}
