using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C0D RID: 15373
	public struct ICylinderTipsActor : IFlatbufferObject
	{
		// Token: 0x170069A8 RID: 27048
		// (get) Token: 0x060152E3 RID: 86755 RVA: 0x00311808 File Offset: 0x0030FA08
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060152E4 RID: 86756 RVA: 0x00311815 File Offset: 0x0030FA15
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060152E5 RID: 86757 RVA: 0x0031181C File Offset: 0x0030FA1C
		public static ICylinderTipsActor GetRootAsICylinderTipsActor(ByteBuffer _bb)
		{
			return ICylinderTipsActor.GetRootAsICylinderTipsActor(_bb, default(ICylinderTipsActor));
		}

		// Token: 0x060152E6 RID: 86758 RVA: 0x00311838 File Offset: 0x0030FA38
		public static ICylinderTipsActor GetRootAsICylinderTipsActor(ByteBuffer _bb, ICylinderTipsActor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060152E7 RID: 86759 RVA: 0x00311855 File Offset: 0x0030FA55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060152E8 RID: 86760 RVA: 0x00311864 File Offset: 0x0030FA64
		public ICylinderTipsActor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170069A9 RID: 27049
		// (get) Token: 0x060152E9 RID: 86761 RVA: 0x00311874 File Offset: 0x0030FA74
		public ETipsActorType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETipsActorType.Sphere;
				}
				return (ETipsActorType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170069AA RID: 27050
		// (get) Token: 0x060152EA RID: 86762 RVA: 0x003118B0 File Offset: 0x0030FAB0
		public ETipsActorColorType ColorType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ETipsActorColorType.Inner;
				}
				return (ETipsActorColorType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170069AB RID: 27051
		// (get) Token: 0x060152EB RID: 86763 RVA: 0x003118EC File Offset: 0x0030FAEC
		public float Radius
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170069AC RID: 27052
		// (get) Token: 0x060152EC RID: 86764 RVA: 0x0031192C File Offset: 0x0030FB2C
		public float Height
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170069AD RID: 27053
		// (get) Token: 0x060152ED RID: 86765 RVA: 0x00311970 File Offset: 0x0030FB70
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060152EE RID: 86766 RVA: 0x003119AD File Offset: 0x0030FBAD
		public static Offset<ICylinderTipsActor> CreateICylinderTipsActor(FlatBufferBuilder builder, ETipsActorType Type = ETipsActorType.Sphere, ETipsActorColorType ColorType = ETipsActorColorType.Inner, float Radius = 0f, float Height = 0f, byte NullMask = 0)
		{
			builder.StartTable(5);
			ICylinderTipsActor.AddHeight(builder, Height);
			ICylinderTipsActor.AddRadius(builder, Radius);
			ICylinderTipsActor.AddNullMask(builder, NullMask);
			ICylinderTipsActor.AddColorType(builder, ColorType);
			ICylinderTipsActor.AddType(builder, Type);
			return ICylinderTipsActor.EndICylinderTipsActor(builder);
		}

		// Token: 0x060152EF RID: 86767 RVA: 0x003119E1 File Offset: 0x0030FBE1
		public static void StartICylinderTipsActor(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060152F0 RID: 86768 RVA: 0x003119EA File Offset: 0x0030FBEA
		public static void AddType(FlatBufferBuilder builder, ETipsActorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060152F1 RID: 86769 RVA: 0x003119F5 File Offset: 0x0030FBF5
		public static void AddColorType(FlatBufferBuilder builder, ETipsActorColorType colorType)
		{
			builder.AddByte(1, (byte)colorType, 0);
		}

		// Token: 0x060152F2 RID: 86770 RVA: 0x00311A00 File Offset: 0x0030FC00
		public static void AddRadius(FlatBufferBuilder builder, float radius)
		{
			builder.AddFloat(2, radius, 0.0);
		}

		// Token: 0x060152F3 RID: 86771 RVA: 0x00311A13 File Offset: 0x0030FC13
		public static void AddHeight(FlatBufferBuilder builder, float height)
		{
			builder.AddFloat(3, height, 0.0);
		}

		// Token: 0x060152F4 RID: 86772 RVA: 0x00311A26 File Offset: 0x0030FC26
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x060152F5 RID: 86773 RVA: 0x00311A31 File Offset: 0x0030FC31
		public static Offset<ICylinderTipsActor> EndICylinderTipsActor(FlatBufferBuilder builder)
		{
			return new Offset<ICylinderTipsActor>(builder.EndTable());
		}

		// Token: 0x060152F6 RID: 86774 RVA: 0x00311A40 File Offset: 0x0030FC40
		public ICylinderTipsActorT UnPack()
		{
			ICylinderTipsActorT cylinderTipsActorT = new ICylinderTipsActorT();
			this.UnPackTo(cylinderTipsActorT);
			return cylinderTipsActorT;
		}

		// Token: 0x060152F7 RID: 86775 RVA: 0x00311A5B File Offset: 0x0030FC5B
		public void UnPackTo(ICylinderTipsActorT _o)
		{
			_o.Type = this.Type;
			_o.ColorType = this.ColorType;
			_o.Radius = this.Radius;
			_o.Height = this.Height;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060152F8 RID: 86776 RVA: 0x00311A9C File Offset: 0x0030FC9C
		public static Offset<ICylinderTipsActor> Pack(FlatBufferBuilder builder, ICylinderTipsActorT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICylinderTipsActor>);
			}
			return ICylinderTipsActor.CreateICylinderTipsActor(builder, _o.Type, _o.ColorType, _o.Radius, _o.Height, _o.NullMask);
		}

		// Token: 0x0400B1EA RID: 45546
		private Table __p;
	}
}
