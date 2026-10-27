using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003BF2 RID: 15346
	public struct IBoxTipsActor : IFlatbufferObject
	{
		// Token: 0x17006952 RID: 26962
		// (get) Token: 0x060151BD RID: 86461 RVA: 0x0030EFE0 File Offset: 0x0030D1E0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060151BE RID: 86462 RVA: 0x0030EFED File Offset: 0x0030D1ED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060151BF RID: 86463 RVA: 0x0030EFF4 File Offset: 0x0030D1F4
		public static IBoxTipsActor GetRootAsIBoxTipsActor(ByteBuffer _bb)
		{
			return IBoxTipsActor.GetRootAsIBoxTipsActor(_bb, default(IBoxTipsActor));
		}

		// Token: 0x060151C0 RID: 86464 RVA: 0x0030F010 File Offset: 0x0030D210
		public static IBoxTipsActor GetRootAsIBoxTipsActor(ByteBuffer _bb, IBoxTipsActor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060151C1 RID: 86465 RVA: 0x0030F02D File Offset: 0x0030D22D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060151C2 RID: 86466 RVA: 0x0030F03C File Offset: 0x0030D23C
		public IBoxTipsActor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006953 RID: 26963
		// (get) Token: 0x060151C3 RID: 86467 RVA: 0x0030F04C File Offset: 0x0030D24C
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

		// Token: 0x17006954 RID: 26964
		// (get) Token: 0x060151C4 RID: 86468 RVA: 0x0030F088 File Offset: 0x0030D288
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

		// Token: 0x17006955 RID: 26965
		// (get) Token: 0x060151C5 RID: 86469 RVA: 0x0030F0C4 File Offset: 0x0030D2C4
		public float X
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

		// Token: 0x17006956 RID: 26966
		// (get) Token: 0x060151C6 RID: 86470 RVA: 0x0030F104 File Offset: 0x0030D304
		public float Y
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

		// Token: 0x17006957 RID: 26967
		// (get) Token: 0x060151C7 RID: 86471 RVA: 0x0030F148 File Offset: 0x0030D348
		public float Z
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

		// Token: 0x17006958 RID: 26968
		// (get) Token: 0x060151C8 RID: 86472 RVA: 0x0030F18C File Offset: 0x0030D38C
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

		// Token: 0x060151C9 RID: 86473 RVA: 0x0030F1C9 File Offset: 0x0030D3C9
		public static Offset<IBoxTipsActor> CreateIBoxTipsActor(FlatBufferBuilder builder, ETipsActorType Type = ETipsActorType.Sphere, ETipsActorColorType ColorType = ETipsActorColorType.Inner, float X = 0f, float Y = 0f, float Z = 0f, byte NullMask = 0)
		{
			builder.StartTable(6);
			IBoxTipsActor.AddZ(builder, Z);
			IBoxTipsActor.AddY(builder, Y);
			IBoxTipsActor.AddX(builder, X);
			IBoxTipsActor.AddNullMask(builder, NullMask);
			IBoxTipsActor.AddColorType(builder, ColorType);
			IBoxTipsActor.AddType(builder, Type);
			return IBoxTipsActor.EndIBoxTipsActor(builder);
		}

		// Token: 0x060151CA RID: 86474 RVA: 0x0030F205 File Offset: 0x0030D405
		public static void StartIBoxTipsActor(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x060151CB RID: 86475 RVA: 0x0030F20E File Offset: 0x0030D40E
		public static void AddType(FlatBufferBuilder builder, ETipsActorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060151CC RID: 86476 RVA: 0x0030F219 File Offset: 0x0030D419
		public static void AddColorType(FlatBufferBuilder builder, ETipsActorColorType colorType)
		{
			builder.AddByte(1, (byte)colorType, 0);
		}

		// Token: 0x060151CD RID: 86477 RVA: 0x0030F224 File Offset: 0x0030D424
		public static void AddX(FlatBufferBuilder builder, float x)
		{
			builder.AddFloat(2, x, 0.0);
		}

		// Token: 0x060151CE RID: 86478 RVA: 0x0030F237 File Offset: 0x0030D437
		public static void AddY(FlatBufferBuilder builder, float y)
		{
			builder.AddFloat(3, y, 0.0);
		}

		// Token: 0x060151CF RID: 86479 RVA: 0x0030F24A File Offset: 0x0030D44A
		public static void AddZ(FlatBufferBuilder builder, float z)
		{
			builder.AddFloat(4, z, 0.0);
		}

		// Token: 0x060151D0 RID: 86480 RVA: 0x0030F25D File Offset: 0x0030D45D
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x060151D1 RID: 86481 RVA: 0x0030F268 File Offset: 0x0030D468
		public static Offset<IBoxTipsActor> EndIBoxTipsActor(FlatBufferBuilder builder)
		{
			return new Offset<IBoxTipsActor>(builder.EndTable());
		}

		// Token: 0x060151D2 RID: 86482 RVA: 0x0030F278 File Offset: 0x0030D478
		public IBoxTipsActorT UnPack()
		{
			IBoxTipsActorT boxTipsActorT = new IBoxTipsActorT();
			this.UnPackTo(boxTipsActorT);
			return boxTipsActorT;
		}

		// Token: 0x060151D3 RID: 86483 RVA: 0x0030F294 File Offset: 0x0030D494
		public void UnPackTo(IBoxTipsActorT _o)
		{
			_o.Type = this.Type;
			_o.ColorType = this.ColorType;
			_o.X = this.X;
			_o.Y = this.Y;
			_o.Z = this.Z;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060151D4 RID: 86484 RVA: 0x0030F2EC File Offset: 0x0030D4EC
		public static Offset<IBoxTipsActor> Pack(FlatBufferBuilder builder, IBoxTipsActorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBoxTipsActor>);
			}
			return IBoxTipsActor.CreateIBoxTipsActor(builder, _o.Type, _o.ColorType, _o.X, _o.Y, _o.Z, _o.NullMask);
		}

		// Token: 0x0400B1BB RID: 45499
		private Table __p;
	}
}
