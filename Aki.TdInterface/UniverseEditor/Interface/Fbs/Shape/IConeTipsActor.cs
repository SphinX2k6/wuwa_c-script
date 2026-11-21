using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x0200400D RID: 16397
	public struct IConeTipsActor : IFlatbufferObject
	{
		// Token: 0x17006F26 RID: 28454
		// (get) Token: 0x06016755 RID: 91989 RVA: 0x00337417 File Offset: 0x00335617
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016756 RID: 91990 RVA: 0x00337424 File Offset: 0x00335624
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016757 RID: 91991 RVA: 0x0033742C File Offset: 0x0033562C
		public static IConeTipsActor GetRootAsIConeTipsActor(ByteBuffer _bb)
		{
			return IConeTipsActor.GetRootAsIConeTipsActor(_bb, default(IConeTipsActor));
		}

		// Token: 0x06016758 RID: 91992 RVA: 0x00337448 File Offset: 0x00335648
		public static IConeTipsActor GetRootAsIConeTipsActor(ByteBuffer _bb, IConeTipsActor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016759 RID: 91993 RVA: 0x00337465 File Offset: 0x00335665
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601675A RID: 91994 RVA: 0x00337474 File Offset: 0x00335674
		public IConeTipsActor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006F27 RID: 28455
		// (get) Token: 0x0601675B RID: 91995 RVA: 0x00337484 File Offset: 0x00335684
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

		// Token: 0x17006F28 RID: 28456
		// (get) Token: 0x0601675C RID: 91996 RVA: 0x003374C0 File Offset: 0x003356C0
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

		// Token: 0x17006F29 RID: 28457
		// (get) Token: 0x0601675D RID: 91997 RVA: 0x003374FC File Offset: 0x003356FC
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

		// Token: 0x17006F2A RID: 28458
		// (get) Token: 0x0601675E RID: 91998 RVA: 0x0033753C File Offset: 0x0033573C
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

		// Token: 0x17006F2B RID: 28459
		// (get) Token: 0x0601675F RID: 91999 RVA: 0x00337580 File Offset: 0x00335780
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

		// Token: 0x06016760 RID: 92000 RVA: 0x003375BD File Offset: 0x003357BD
		public static Offset<IConeTipsActor> CreateIConeTipsActor(FlatBufferBuilder builder, ETipsActorType Type = ETipsActorType.Sphere, ETipsActorColorType ColorType = ETipsActorColorType.Inner, float Radius = 0f, float Height = 0f, byte NullMask = 0)
		{
			builder.StartTable(5);
			IConeTipsActor.AddHeight(builder, Height);
			IConeTipsActor.AddRadius(builder, Radius);
			IConeTipsActor.AddNullMask(builder, NullMask);
			IConeTipsActor.AddColorType(builder, ColorType);
			IConeTipsActor.AddType(builder, Type);
			return IConeTipsActor.EndIConeTipsActor(builder);
		}

		// Token: 0x06016761 RID: 92001 RVA: 0x003375F1 File Offset: 0x003357F1
		public static void StartIConeTipsActor(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06016762 RID: 92002 RVA: 0x003375FA File Offset: 0x003357FA
		public static void AddType(FlatBufferBuilder builder, ETipsActorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016763 RID: 92003 RVA: 0x00337605 File Offset: 0x00335805
		public static void AddColorType(FlatBufferBuilder builder, ETipsActorColorType colorType)
		{
			builder.AddByte(1, (byte)colorType, 0);
		}

		// Token: 0x06016764 RID: 92004 RVA: 0x00337610 File Offset: 0x00335810
		public static void AddRadius(FlatBufferBuilder builder, float radius)
		{
			builder.AddFloat(2, radius, 0.0);
		}

		// Token: 0x06016765 RID: 92005 RVA: 0x00337623 File Offset: 0x00335823
		public static void AddHeight(FlatBufferBuilder builder, float height)
		{
			builder.AddFloat(3, height, 0.0);
		}

		// Token: 0x06016766 RID: 92006 RVA: 0x00337636 File Offset: 0x00335836
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06016767 RID: 92007 RVA: 0x00337641 File Offset: 0x00335841
		public static Offset<IConeTipsActor> EndIConeTipsActor(FlatBufferBuilder builder)
		{
			return new Offset<IConeTipsActor>(builder.EndTable());
		}

		// Token: 0x06016768 RID: 92008 RVA: 0x00337650 File Offset: 0x00335850
		public IConeTipsActorT UnPack()
		{
			IConeTipsActorT coneTipsActorT = new IConeTipsActorT();
			this.UnPackTo(coneTipsActorT);
			return coneTipsActorT;
		}

		// Token: 0x06016769 RID: 92009 RVA: 0x0033766B File Offset: 0x0033586B
		public void UnPackTo(IConeTipsActorT _o)
		{
			_o.Type = this.Type;
			_o.ColorType = this.ColorType;
			_o.Radius = this.Radius;
			_o.Height = this.Height;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601676A RID: 92010 RVA: 0x003376AC File Offset: 0x003358AC
		public static Offset<IConeTipsActor> Pack(FlatBufferBuilder builder, IConeTipsActorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IConeTipsActor>);
			}
			return IConeTipsActor.CreateIConeTipsActor(builder, _o.Type, _o.ColorType, _o.Radius, _o.Height, _o.NullMask);
		}

		// Token: 0x0400BB5E RID: 47966
		private Table __p;
	}
}
