using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004028 RID: 16424
	public struct IHollowCylinderTriggerShape : IFlatbufferObject
	{
		// Token: 0x17006F87 RID: 28551
		// (get) Token: 0x06016883 RID: 92291 RVA: 0x003397DC File Offset: 0x003379DC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016884 RID: 92292 RVA: 0x003397E9 File Offset: 0x003379E9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016885 RID: 92293 RVA: 0x003397F0 File Offset: 0x003379F0
		public static IHollowCylinderTriggerShape GetRootAsIHollowCylinderTriggerShape(ByteBuffer _bb)
		{
			return IHollowCylinderTriggerShape.GetRootAsIHollowCylinderTriggerShape(_bb, default(IHollowCylinderTriggerShape));
		}

		// Token: 0x06016886 RID: 92294 RVA: 0x0033980C File Offset: 0x00337A0C
		public static IHollowCylinderTriggerShape GetRootAsIHollowCylinderTriggerShape(ByteBuffer _bb, IHollowCylinderTriggerShape obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016887 RID: 92295 RVA: 0x00339829 File Offset: 0x00337A29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016888 RID: 92296 RVA: 0x00339838 File Offset: 0x00337A38
		public IHollowCylinderTriggerShape __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006F88 RID: 28552
		// (get) Token: 0x06016889 RID: 92297 RVA: 0x00339848 File Offset: 0x00337A48
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

		// Token: 0x17006F89 RID: 28553
		// (get) Token: 0x0601688A RID: 92298 RVA: 0x00339884 File Offset: 0x00337A84
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

		// Token: 0x17006F8A RID: 28554
		// (get) Token: 0x0601688B RID: 92299 RVA: 0x003398E4 File Offset: 0x00337AE4
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

		// Token: 0x17006F8B RID: 28555
		// (get) Token: 0x0601688C RID: 92300 RVA: 0x00339920 File Offset: 0x00337B20
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

		// Token: 0x17006F8C RID: 28556
		// (get) Token: 0x0601688D RID: 92301 RVA: 0x00339960 File Offset: 0x00337B60
		public int InnerRadius
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601688E RID: 92302 RVA: 0x0033999D File Offset: 0x00337B9D
		public static Offset<IHollowCylinderTriggerShape> CreateIHollowCylinderTriggerShape(FlatBufferBuilder builder, ETriggerShape Type = ETriggerShape.Box, Offset<IVectorInfo> CenterOffset = default(Offset<IVectorInfo>), int Radius = 0, int Height = 0, int InnerRadius = 0)
		{
			builder.StartTable(5);
			IHollowCylinderTriggerShape.AddInnerRadius(builder, InnerRadius);
			IHollowCylinderTriggerShape.AddHeight(builder, Height);
			IHollowCylinderTriggerShape.AddRadius(builder, Radius);
			IHollowCylinderTriggerShape.AddCenter(builder, CenterOffset);
			IHollowCylinderTriggerShape.AddType(builder, Type);
			return IHollowCylinderTriggerShape.EndIHollowCylinderTriggerShape(builder);
		}

		// Token: 0x0601688F RID: 92303 RVA: 0x003399D1 File Offset: 0x00337BD1
		public static void StartIHollowCylinderTriggerShape(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06016890 RID: 92304 RVA: 0x003399DA File Offset: 0x00337BDA
		public static void AddType(FlatBufferBuilder builder, ETriggerShape type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016891 RID: 92305 RVA: 0x003399E5 File Offset: 0x00337BE5
		public static void AddCenter(FlatBufferBuilder builder, Offset<IVectorInfo> centerOffset)
		{
			builder.AddOffset(1, centerOffset.Value, 0);
		}

		// Token: 0x06016892 RID: 92306 RVA: 0x003399F5 File Offset: 0x00337BF5
		public static void AddRadius(FlatBufferBuilder builder, int radius)
		{
			builder.AddInt(2, radius, 0);
		}

		// Token: 0x06016893 RID: 92307 RVA: 0x00339A00 File Offset: 0x00337C00
		public static void AddHeight(FlatBufferBuilder builder, int height)
		{
			builder.AddInt(3, height, 0);
		}

		// Token: 0x06016894 RID: 92308 RVA: 0x00339A0B File Offset: 0x00337C0B
		public static void AddInnerRadius(FlatBufferBuilder builder, int innerRadius)
		{
			builder.AddInt(4, innerRadius, 0);
		}

		// Token: 0x06016895 RID: 92309 RVA: 0x00339A16 File Offset: 0x00337C16
		public static Offset<IHollowCylinderTriggerShape> EndIHollowCylinderTriggerShape(FlatBufferBuilder builder)
		{
			return new Offset<IHollowCylinderTriggerShape>(builder.EndTable());
		}

		// Token: 0x06016896 RID: 92310 RVA: 0x00339A24 File Offset: 0x00337C24
		public IHollowCylinderTriggerShapeT UnPack()
		{
			IHollowCylinderTriggerShapeT hollowCylinderTriggerShapeT = new IHollowCylinderTriggerShapeT();
			this.UnPackTo(hollowCylinderTriggerShapeT);
			return hollowCylinderTriggerShapeT;
		}

		// Token: 0x06016897 RID: 92311 RVA: 0x00339A40 File Offset: 0x00337C40
		public void UnPackTo(IHollowCylinderTriggerShapeT _o)
		{
			_o.Type = this.Type;
			_o.Center = ((this.Center != null) ? this.Center.Value.UnPack() : null);
			_o.Radius = this.Radius;
			_o.Height = this.Height;
			_o.InnerRadius = this.InnerRadius;
		}

		// Token: 0x06016898 RID: 92312 RVA: 0x00339AAC File Offset: 0x00337CAC
		public static Offset<IHollowCylinderTriggerShape> Pack(FlatBufferBuilder builder, IHollowCylinderTriggerShapeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHollowCylinderTriggerShape>);
			}
			Offset<IVectorInfo> centerOffset = (_o.Center == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Center);
			return IHollowCylinderTriggerShape.CreateIHollowCylinderTriggerShape(builder, _o.Type, centerOffset, _o.Radius, _o.Height, _o.InnerRadius);
		}

		// Token: 0x0400BB93 RID: 48019
		private Table __p;
	}
}
