using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004025 RID: 16421
	public struct IHollowCylinderTipsActor : IFlatbufferObject
	{
		// Token: 0x17006F7A RID: 28538
		// (get) Token: 0x0601685D RID: 92253 RVA: 0x0033936C File Offset: 0x0033756C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601685E RID: 92254 RVA: 0x00339379 File Offset: 0x00337579
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601685F RID: 92255 RVA: 0x00339380 File Offset: 0x00337580
		public static IHollowCylinderTipsActor GetRootAsIHollowCylinderTipsActor(ByteBuffer _bb)
		{
			return IHollowCylinderTipsActor.GetRootAsIHollowCylinderTipsActor(_bb, default(IHollowCylinderTipsActor));
		}

		// Token: 0x06016860 RID: 92256 RVA: 0x0033939C File Offset: 0x0033759C
		public static IHollowCylinderTipsActor GetRootAsIHollowCylinderTipsActor(ByteBuffer _bb, IHollowCylinderTipsActor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016861 RID: 92257 RVA: 0x003393B9 File Offset: 0x003375B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016862 RID: 92258 RVA: 0x003393C8 File Offset: 0x003375C8
		public IHollowCylinderTipsActor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006F7B RID: 28539
		// (get) Token: 0x06016863 RID: 92259 RVA: 0x003393D8 File Offset: 0x003375D8
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

		// Token: 0x17006F7C RID: 28540
		// (get) Token: 0x06016864 RID: 92260 RVA: 0x00339414 File Offset: 0x00337614
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

		// Token: 0x17006F7D RID: 28541
		// (get) Token: 0x06016865 RID: 92261 RVA: 0x00339450 File Offset: 0x00337650
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

		// Token: 0x17006F7E RID: 28542
		// (get) Token: 0x06016866 RID: 92262 RVA: 0x00339490 File Offset: 0x00337690
		public float InnerRadius
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

		// Token: 0x17006F7F RID: 28543
		// (get) Token: 0x06016867 RID: 92263 RVA: 0x003394D4 File Offset: 0x003376D4
		public float Height
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

		// Token: 0x17006F80 RID: 28544
		// (get) Token: 0x06016868 RID: 92264 RVA: 0x00339518 File Offset: 0x00337718
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

		// Token: 0x06016869 RID: 92265 RVA: 0x00339555 File Offset: 0x00337755
		public static Offset<IHollowCylinderTipsActor> CreateIHollowCylinderTipsActor(FlatBufferBuilder builder, ETipsActorType Type = ETipsActorType.Sphere, ETipsActorColorType ColorType = ETipsActorColorType.Inner, float Radius = 0f, float InnerRadius = 0f, float Height = 0f, byte NullMask = 0)
		{
			builder.StartTable(6);
			IHollowCylinderTipsActor.AddHeight(builder, Height);
			IHollowCylinderTipsActor.AddInnerRadius(builder, InnerRadius);
			IHollowCylinderTipsActor.AddRadius(builder, Radius);
			IHollowCylinderTipsActor.AddNullMask(builder, NullMask);
			IHollowCylinderTipsActor.AddColorType(builder, ColorType);
			IHollowCylinderTipsActor.AddType(builder, Type);
			return IHollowCylinderTipsActor.EndIHollowCylinderTipsActor(builder);
		}

		// Token: 0x0601686A RID: 92266 RVA: 0x00339591 File Offset: 0x00337791
		public static void StartIHollowCylinderTipsActor(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601686B RID: 92267 RVA: 0x0033959A File Offset: 0x0033779A
		public static void AddType(FlatBufferBuilder builder, ETipsActorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601686C RID: 92268 RVA: 0x003395A5 File Offset: 0x003377A5
		public static void AddColorType(FlatBufferBuilder builder, ETipsActorColorType colorType)
		{
			builder.AddByte(1, (byte)colorType, 0);
		}

		// Token: 0x0601686D RID: 92269 RVA: 0x003395B0 File Offset: 0x003377B0
		public static void AddRadius(FlatBufferBuilder builder, float radius)
		{
			builder.AddFloat(2, radius, 0.0);
		}

		// Token: 0x0601686E RID: 92270 RVA: 0x003395C3 File Offset: 0x003377C3
		public static void AddInnerRadius(FlatBufferBuilder builder, float innerRadius)
		{
			builder.AddFloat(3, innerRadius, 0.0);
		}

		// Token: 0x0601686F RID: 92271 RVA: 0x003395D6 File Offset: 0x003377D6
		public static void AddHeight(FlatBufferBuilder builder, float height)
		{
			builder.AddFloat(4, height, 0.0);
		}

		// Token: 0x06016870 RID: 92272 RVA: 0x003395E9 File Offset: 0x003377E9
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06016871 RID: 92273 RVA: 0x003395F4 File Offset: 0x003377F4
		public static Offset<IHollowCylinderTipsActor> EndIHollowCylinderTipsActor(FlatBufferBuilder builder)
		{
			return new Offset<IHollowCylinderTipsActor>(builder.EndTable());
		}

		// Token: 0x06016872 RID: 92274 RVA: 0x00339604 File Offset: 0x00337804
		public IHollowCylinderTipsActorT UnPack()
		{
			IHollowCylinderTipsActorT hollowCylinderTipsActorT = new IHollowCylinderTipsActorT();
			this.UnPackTo(hollowCylinderTipsActorT);
			return hollowCylinderTipsActorT;
		}

		// Token: 0x06016873 RID: 92275 RVA: 0x00339620 File Offset: 0x00337820
		public void UnPackTo(IHollowCylinderTipsActorT _o)
		{
			_o.Type = this.Type;
			_o.ColorType = this.ColorType;
			_o.Radius = this.Radius;
			_o.InnerRadius = this.InnerRadius;
			_o.Height = this.Height;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06016874 RID: 92276 RVA: 0x00339678 File Offset: 0x00337878
		public static Offset<IHollowCylinderTipsActor> Pack(FlatBufferBuilder builder, IHollowCylinderTipsActorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHollowCylinderTipsActor>);
			}
			return IHollowCylinderTipsActor.CreateIHollowCylinderTipsActor(builder, _o.Type, _o.ColorType, _o.Radius, _o.InnerRadius, _o.Height, _o.NullMask);
		}

		// Token: 0x0400BB8C RID: 48012
		private Table __p;
	}
}
