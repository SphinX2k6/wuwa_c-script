using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003FFE RID: 16382
	public struct IBoxTipsActor : IFlatbufferObject
	{
		// Token: 0x17006EFA RID: 28410
		// (get) Token: 0x060166B3 RID: 91827 RVA: 0x00335B68 File Offset: 0x00333D68
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060166B4 RID: 91828 RVA: 0x00335B75 File Offset: 0x00333D75
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060166B5 RID: 91829 RVA: 0x00335B7C File Offset: 0x00333D7C
		public static IBoxTipsActor GetRootAsIBoxTipsActor(ByteBuffer _bb)
		{
			return IBoxTipsActor.GetRootAsIBoxTipsActor(_bb, default(IBoxTipsActor));
		}

		// Token: 0x060166B6 RID: 91830 RVA: 0x00335B98 File Offset: 0x00333D98
		public static IBoxTipsActor GetRootAsIBoxTipsActor(ByteBuffer _bb, IBoxTipsActor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060166B7 RID: 91831 RVA: 0x00335BB5 File Offset: 0x00333DB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060166B8 RID: 91832 RVA: 0x00335BC4 File Offset: 0x00333DC4
		public IBoxTipsActor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006EFB RID: 28411
		// (get) Token: 0x060166B9 RID: 91833 RVA: 0x00335BD4 File Offset: 0x00333DD4
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

		// Token: 0x17006EFC RID: 28412
		// (get) Token: 0x060166BA RID: 91834 RVA: 0x00335C10 File Offset: 0x00333E10
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

		// Token: 0x17006EFD RID: 28413
		// (get) Token: 0x060166BB RID: 91835 RVA: 0x00335C4C File Offset: 0x00333E4C
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

		// Token: 0x17006EFE RID: 28414
		// (get) Token: 0x060166BC RID: 91836 RVA: 0x00335C8C File Offset: 0x00333E8C
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

		// Token: 0x17006EFF RID: 28415
		// (get) Token: 0x060166BD RID: 91837 RVA: 0x00335CD0 File Offset: 0x00333ED0
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

		// Token: 0x17006F00 RID: 28416
		// (get) Token: 0x060166BE RID: 91838 RVA: 0x00335D14 File Offset: 0x00333F14
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

		// Token: 0x060166BF RID: 91839 RVA: 0x00335D51 File Offset: 0x00333F51
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

		// Token: 0x060166C0 RID: 91840 RVA: 0x00335D8D File Offset: 0x00333F8D
		public static void StartIBoxTipsActor(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x060166C1 RID: 91841 RVA: 0x00335D96 File Offset: 0x00333F96
		public static void AddType(FlatBufferBuilder builder, ETipsActorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060166C2 RID: 91842 RVA: 0x00335DA1 File Offset: 0x00333FA1
		public static void AddColorType(FlatBufferBuilder builder, ETipsActorColorType colorType)
		{
			builder.AddByte(1, (byte)colorType, 0);
		}

		// Token: 0x060166C3 RID: 91843 RVA: 0x00335DAC File Offset: 0x00333FAC
		public static void AddX(FlatBufferBuilder builder, float x)
		{
			builder.AddFloat(2, x, 0.0);
		}

		// Token: 0x060166C4 RID: 91844 RVA: 0x00335DBF File Offset: 0x00333FBF
		public static void AddY(FlatBufferBuilder builder, float y)
		{
			builder.AddFloat(3, y, 0.0);
		}

		// Token: 0x060166C5 RID: 91845 RVA: 0x00335DD2 File Offset: 0x00333FD2
		public static void AddZ(FlatBufferBuilder builder, float z)
		{
			builder.AddFloat(4, z, 0.0);
		}

		// Token: 0x060166C6 RID: 91846 RVA: 0x00335DE5 File Offset: 0x00333FE5
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x060166C7 RID: 91847 RVA: 0x00335DF0 File Offset: 0x00333FF0
		public static Offset<IBoxTipsActor> EndIBoxTipsActor(FlatBufferBuilder builder)
		{
			return new Offset<IBoxTipsActor>(builder.EndTable());
		}

		// Token: 0x060166C8 RID: 91848 RVA: 0x00335E00 File Offset: 0x00334000
		public IBoxTipsActorT UnPack()
		{
			IBoxTipsActorT boxTipsActorT = new IBoxTipsActorT();
			this.UnPackTo(boxTipsActorT);
			return boxTipsActorT;
		}

		// Token: 0x060166C9 RID: 91849 RVA: 0x00335E1C File Offset: 0x0033401C
		public void UnPackTo(IBoxTipsActorT _o)
		{
			_o.Type = this.Type;
			_o.ColorType = this.ColorType;
			_o.X = this.X;
			_o.Y = this.Y;
			_o.Z = this.Z;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060166CA RID: 91850 RVA: 0x00335E74 File Offset: 0x00334074
		public static Offset<IBoxTipsActor> Pack(FlatBufferBuilder builder, IBoxTipsActorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBoxTipsActor>);
			}
			return IBoxTipsActor.CreateIBoxTipsActor(builder, _o.Type, _o.ColorType, _o.X, _o.Y, _o.Z, _o.NullMask);
		}

		// Token: 0x0400BB46 RID: 47942
		private Table __p;
	}
}
