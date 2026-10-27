using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C40 RID: 15424
	public struct ISphereTipsActor : IFlatbufferObject
	{
		// Token: 0x17006A42 RID: 27202
		// (get) Token: 0x060154E7 RID: 87271 RVA: 0x0031569D File Offset: 0x0031389D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060154E8 RID: 87272 RVA: 0x003156AA File Offset: 0x003138AA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060154E9 RID: 87273 RVA: 0x003156B4 File Offset: 0x003138B4
		public static ISphereTipsActor GetRootAsISphereTipsActor(ByteBuffer _bb)
		{
			return ISphereTipsActor.GetRootAsISphereTipsActor(_bb, default(ISphereTipsActor));
		}

		// Token: 0x060154EA RID: 87274 RVA: 0x003156D0 File Offset: 0x003138D0
		public static ISphereTipsActor GetRootAsISphereTipsActor(ByteBuffer _bb, ISphereTipsActor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060154EB RID: 87275 RVA: 0x003156ED File Offset: 0x003138ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060154EC RID: 87276 RVA: 0x003156FC File Offset: 0x003138FC
		public ISphereTipsActor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006A43 RID: 27203
		// (get) Token: 0x060154ED RID: 87277 RVA: 0x0031570C File Offset: 0x0031390C
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

		// Token: 0x17006A44 RID: 27204
		// (get) Token: 0x060154EE RID: 87278 RVA: 0x00315748 File Offset: 0x00313948
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

		// Token: 0x17006A45 RID: 27205
		// (get) Token: 0x060154EF RID: 87279 RVA: 0x00315784 File Offset: 0x00313984
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

		// Token: 0x17006A46 RID: 27206
		// (get) Token: 0x060154F0 RID: 87280 RVA: 0x003157C4 File Offset: 0x003139C4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060154F1 RID: 87281 RVA: 0x00315801 File Offset: 0x00313A01
		public static Offset<ISphereTipsActor> CreateISphereTipsActor(FlatBufferBuilder builder, ETipsActorType Type = ETipsActorType.Sphere, ETipsActorColorType ColorType = ETipsActorColorType.Inner, float Radius = 0f, byte NullMask = 0)
		{
			builder.StartTable(4);
			ISphereTipsActor.AddRadius(builder, Radius);
			ISphereTipsActor.AddNullMask(builder, NullMask);
			ISphereTipsActor.AddColorType(builder, ColorType);
			ISphereTipsActor.AddType(builder, Type);
			return ISphereTipsActor.EndISphereTipsActor(builder);
		}

		// Token: 0x060154F2 RID: 87282 RVA: 0x0031582D File Offset: 0x00313A2D
		public static void StartISphereTipsActor(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060154F3 RID: 87283 RVA: 0x00315836 File Offset: 0x00313A36
		public static void AddType(FlatBufferBuilder builder, ETipsActorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060154F4 RID: 87284 RVA: 0x00315841 File Offset: 0x00313A41
		public static void AddColorType(FlatBufferBuilder builder, ETipsActorColorType colorType)
		{
			builder.AddByte(1, (byte)colorType, 0);
		}

		// Token: 0x060154F5 RID: 87285 RVA: 0x0031584C File Offset: 0x00313A4C
		public static void AddRadius(FlatBufferBuilder builder, float radius)
		{
			builder.AddFloat(2, radius, 0.0);
		}

		// Token: 0x060154F6 RID: 87286 RVA: 0x0031585F File Offset: 0x00313A5F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x060154F7 RID: 87287 RVA: 0x0031586A File Offset: 0x00313A6A
		public static Offset<ISphereTipsActor> EndISphereTipsActor(FlatBufferBuilder builder)
		{
			return new Offset<ISphereTipsActor>(builder.EndTable());
		}

		// Token: 0x060154F8 RID: 87288 RVA: 0x00315878 File Offset: 0x00313A78
		public ISphereTipsActorT UnPack()
		{
			ISphereTipsActorT sphereTipsActorT = new ISphereTipsActorT();
			this.UnPackTo(sphereTipsActorT);
			return sphereTipsActorT;
		}

		// Token: 0x060154F9 RID: 87289 RVA: 0x00315893 File Offset: 0x00313A93
		public void UnPackTo(ISphereTipsActorT _o)
		{
			_o.Type = this.Type;
			_o.ColorType = this.ColorType;
			_o.Radius = this.Radius;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060154FA RID: 87290 RVA: 0x003158C8 File Offset: 0x00313AC8
		public static Offset<ISphereTipsActor> Pack(FlatBufferBuilder builder, ISphereTipsActorT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISphereTipsActor>);
			}
			return ISphereTipsActor.CreateISphereTipsActor(builder, _o.Type, _o.ColorType, _o.Radius, _o.NullMask);
		}

		// Token: 0x0400B246 RID: 45638
		private Table __p;
	}
}
