using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C1F RID: 15391
	public struct IHollowSphereTipsActor : IFlatbufferObject
	{
		// Token: 0x170069EA RID: 27114
		// (get) Token: 0x060153AF RID: 86959 RVA: 0x00313083 File Offset: 0x00311283
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060153B0 RID: 86960 RVA: 0x00313090 File Offset: 0x00311290
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060153B1 RID: 86961 RVA: 0x00313098 File Offset: 0x00311298
		public static IHollowSphereTipsActor GetRootAsIHollowSphereTipsActor(ByteBuffer _bb)
		{
			return IHollowSphereTipsActor.GetRootAsIHollowSphereTipsActor(_bb, default(IHollowSphereTipsActor));
		}

		// Token: 0x060153B2 RID: 86962 RVA: 0x003130B4 File Offset: 0x003112B4
		public static IHollowSphereTipsActor GetRootAsIHollowSphereTipsActor(ByteBuffer _bb, IHollowSphereTipsActor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060153B3 RID: 86963 RVA: 0x003130D1 File Offset: 0x003112D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060153B4 RID: 86964 RVA: 0x003130E0 File Offset: 0x003112E0
		public IHollowSphereTipsActor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170069EB RID: 27115
		// (get) Token: 0x060153B5 RID: 86965 RVA: 0x003130F0 File Offset: 0x003112F0
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

		// Token: 0x170069EC RID: 27116
		// (get) Token: 0x060153B6 RID: 86966 RVA: 0x0031312C File Offset: 0x0031132C
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

		// Token: 0x170069ED RID: 27117
		// (get) Token: 0x060153B7 RID: 86967 RVA: 0x00313168 File Offset: 0x00311368
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

		// Token: 0x170069EE RID: 27118
		// (get) Token: 0x060153B8 RID: 86968 RVA: 0x003131A8 File Offset: 0x003113A8
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

		// Token: 0x170069EF RID: 27119
		// (get) Token: 0x060153B9 RID: 86969 RVA: 0x003131EC File Offset: 0x003113EC
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

		// Token: 0x060153BA RID: 86970 RVA: 0x00313229 File Offset: 0x00311429
		public static Offset<IHollowSphereTipsActor> CreateIHollowSphereTipsActor(FlatBufferBuilder builder, ETipsActorType Type = ETipsActorType.Sphere, ETipsActorColorType ColorType = ETipsActorColorType.Inner, float Radius = 0f, float InnerRadius = 0f, byte NullMask = 0)
		{
			builder.StartTable(5);
			IHollowSphereTipsActor.AddInnerRadius(builder, InnerRadius);
			IHollowSphereTipsActor.AddRadius(builder, Radius);
			IHollowSphereTipsActor.AddNullMask(builder, NullMask);
			IHollowSphereTipsActor.AddColorType(builder, ColorType);
			IHollowSphereTipsActor.AddType(builder, Type);
			return IHollowSphereTipsActor.EndIHollowSphereTipsActor(builder);
		}

		// Token: 0x060153BB RID: 86971 RVA: 0x0031325D File Offset: 0x0031145D
		public static void StartIHollowSphereTipsActor(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060153BC RID: 86972 RVA: 0x00313266 File Offset: 0x00311466
		public static void AddType(FlatBufferBuilder builder, ETipsActorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060153BD RID: 86973 RVA: 0x00313271 File Offset: 0x00311471
		public static void AddColorType(FlatBufferBuilder builder, ETipsActorColorType colorType)
		{
			builder.AddByte(1, (byte)colorType, 0);
		}

		// Token: 0x060153BE RID: 86974 RVA: 0x0031327C File Offset: 0x0031147C
		public static void AddRadius(FlatBufferBuilder builder, float radius)
		{
			builder.AddFloat(2, radius, 0.0);
		}

		// Token: 0x060153BF RID: 86975 RVA: 0x0031328F File Offset: 0x0031148F
		public static void AddInnerRadius(FlatBufferBuilder builder, float innerRadius)
		{
			builder.AddFloat(3, innerRadius, 0.0);
		}

		// Token: 0x060153C0 RID: 86976 RVA: 0x003132A2 File Offset: 0x003114A2
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x060153C1 RID: 86977 RVA: 0x003132AD File Offset: 0x003114AD
		public static Offset<IHollowSphereTipsActor> EndIHollowSphereTipsActor(FlatBufferBuilder builder)
		{
			return new Offset<IHollowSphereTipsActor>(builder.EndTable());
		}

		// Token: 0x060153C2 RID: 86978 RVA: 0x003132BC File Offset: 0x003114BC
		public IHollowSphereTipsActorT UnPack()
		{
			IHollowSphereTipsActorT hollowSphereTipsActorT = new IHollowSphereTipsActorT();
			this.UnPackTo(hollowSphereTipsActorT);
			return hollowSphereTipsActorT;
		}

		// Token: 0x060153C3 RID: 86979 RVA: 0x003132D7 File Offset: 0x003114D7
		public void UnPackTo(IHollowSphereTipsActorT _o)
		{
			_o.Type = this.Type;
			_o.ColorType = this.ColorType;
			_o.Radius = this.Radius;
			_o.InnerRadius = this.InnerRadius;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060153C4 RID: 86980 RVA: 0x00313318 File Offset: 0x00311518
		public static Offset<IHollowSphereTipsActor> Pack(FlatBufferBuilder builder, IHollowSphereTipsActorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHollowSphereTipsActor>);
			}
			return IHollowSphereTipsActor.CreateIHollowSphereTipsActor(builder, _o.Type, _o.ColorType, _o.Radius, _o.InnerRadius, _o.NullMask);
		}

		// Token: 0x0400B20E RID: 45582
		private Table __p;
	}
}
