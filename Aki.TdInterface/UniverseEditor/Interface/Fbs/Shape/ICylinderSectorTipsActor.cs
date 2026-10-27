using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C0A RID: 15370
	public struct ICylinderSectorTipsActor : IFlatbufferObject
	{
		// Token: 0x1700699B RID: 27035
		// (get) Token: 0x060152BD RID: 86717 RVA: 0x00311397 File Offset: 0x0030F597
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060152BE RID: 86718 RVA: 0x003113A4 File Offset: 0x0030F5A4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060152BF RID: 86719 RVA: 0x003113AC File Offset: 0x0030F5AC
		public static ICylinderSectorTipsActor GetRootAsICylinderSectorTipsActor(ByteBuffer _bb)
		{
			return ICylinderSectorTipsActor.GetRootAsICylinderSectorTipsActor(_bb, default(ICylinderSectorTipsActor));
		}

		// Token: 0x060152C0 RID: 86720 RVA: 0x003113C8 File Offset: 0x0030F5C8
		public static ICylinderSectorTipsActor GetRootAsICylinderSectorTipsActor(ByteBuffer _bb, ICylinderSectorTipsActor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060152C1 RID: 86721 RVA: 0x003113E5 File Offset: 0x0030F5E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060152C2 RID: 86722 RVA: 0x003113F4 File Offset: 0x0030F5F4
		public ICylinderSectorTipsActor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700699C RID: 27036
		// (get) Token: 0x060152C3 RID: 86723 RVA: 0x00311404 File Offset: 0x0030F604
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

		// Token: 0x1700699D RID: 27037
		// (get) Token: 0x060152C4 RID: 86724 RVA: 0x00311440 File Offset: 0x0030F640
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

		// Token: 0x1700699E RID: 27038
		// (get) Token: 0x060152C5 RID: 86725 RVA: 0x0031147C File Offset: 0x0030F67C
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

		// Token: 0x1700699F RID: 27039
		// (get) Token: 0x060152C6 RID: 86726 RVA: 0x003114BC File Offset: 0x0030F6BC
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

		// Token: 0x170069A0 RID: 27040
		// (get) Token: 0x060152C7 RID: 86727 RVA: 0x00311500 File Offset: 0x0030F700
		public float Angle
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170069A1 RID: 27041
		// (get) Token: 0x060152C8 RID: 86728 RVA: 0x00311544 File Offset: 0x0030F744
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060152C9 RID: 86729 RVA: 0x00311581 File Offset: 0x0030F781
		public static Offset<ICylinderSectorTipsActor> CreateICylinderSectorTipsActor(FlatBufferBuilder builder, ETipsActorType Type = ETipsActorType.Sphere, ETipsActorColorType ColorType = ETipsActorColorType.Inner, float Radius = 0f, float Height = 0f, float Angle = 0f, byte NullMask = 0)
		{
			builder.StartTable(6);
			ICylinderSectorTipsActor.AddAngle(builder, Angle);
			ICylinderSectorTipsActor.AddHeight(builder, Height);
			ICylinderSectorTipsActor.AddRadius(builder, Radius);
			ICylinderSectorTipsActor.AddNullMask(builder, NullMask);
			ICylinderSectorTipsActor.AddColorType(builder, ColorType);
			ICylinderSectorTipsActor.AddType(builder, Type);
			return ICylinderSectorTipsActor.EndICylinderSectorTipsActor(builder);
		}

		// Token: 0x060152CA RID: 86730 RVA: 0x003115BD File Offset: 0x0030F7BD
		public static void StartICylinderSectorTipsActor(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x060152CB RID: 86731 RVA: 0x003115C6 File Offset: 0x0030F7C6
		public static void AddType(FlatBufferBuilder builder, ETipsActorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060152CC RID: 86732 RVA: 0x003115D1 File Offset: 0x0030F7D1
		public static void AddColorType(FlatBufferBuilder builder, ETipsActorColorType colorType)
		{
			builder.AddByte(1, (byte)colorType, 0);
		}

		// Token: 0x060152CD RID: 86733 RVA: 0x003115DC File Offset: 0x0030F7DC
		public static void AddRadius(FlatBufferBuilder builder, float radius)
		{
			builder.AddFloat(2, radius, 0.0);
		}

		// Token: 0x060152CE RID: 86734 RVA: 0x003115EF File Offset: 0x0030F7EF
		public static void AddHeight(FlatBufferBuilder builder, float height)
		{
			builder.AddFloat(3, height, 0.0);
		}

		// Token: 0x060152CF RID: 86735 RVA: 0x00311602 File Offset: 0x0030F802
		public static void AddAngle(FlatBufferBuilder builder, float angle)
		{
			builder.AddFloat(4, angle, 0.0);
		}

		// Token: 0x060152D0 RID: 86736 RVA: 0x00311615 File Offset: 0x0030F815
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x060152D1 RID: 86737 RVA: 0x00311620 File Offset: 0x0030F820
		public static Offset<ICylinderSectorTipsActor> EndICylinderSectorTipsActor(FlatBufferBuilder builder)
		{
			return new Offset<ICylinderSectorTipsActor>(builder.EndTable());
		}

		// Token: 0x060152D2 RID: 86738 RVA: 0x00311630 File Offset: 0x0030F830
		public ICylinderSectorTipsActorT UnPack()
		{
			ICylinderSectorTipsActorT cylinderSectorTipsActorT = new ICylinderSectorTipsActorT();
			this.UnPackTo(cylinderSectorTipsActorT);
			return cylinderSectorTipsActorT;
		}

		// Token: 0x060152D3 RID: 86739 RVA: 0x0031164C File Offset: 0x0030F84C
		public void UnPackTo(ICylinderSectorTipsActorT _o)
		{
			_o.Type = this.Type;
			_o.ColorType = this.ColorType;
			_o.Radius = this.Radius;
			_o.Height = this.Height;
			_o.Angle = this.Angle;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060152D4 RID: 86740 RVA: 0x003116A4 File Offset: 0x0030F8A4
		public static Offset<ICylinderSectorTipsActor> Pack(FlatBufferBuilder builder, ICylinderSectorTipsActorT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICylinderSectorTipsActor>);
			}
			return ICylinderSectorTipsActor.CreateICylinderSectorTipsActor(builder, _o.Type, _o.ColorType, _o.Radius, _o.Height, _o.Angle, _o.NullMask);
		}

		// Token: 0x0400B1E3 RID: 45539
		private Table __p;
	}
}
