using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C19 RID: 15385
	public struct IHollowCylinderTipsActor : IFlatbufferObject
	{
		// Token: 0x170069D2 RID: 27090
		// (get) Token: 0x06015367 RID: 86887 RVA: 0x003127E4 File Offset: 0x003109E4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015368 RID: 86888 RVA: 0x003127F1 File Offset: 0x003109F1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015369 RID: 86889 RVA: 0x003127F8 File Offset: 0x003109F8
		public static IHollowCylinderTipsActor GetRootAsIHollowCylinderTipsActor(ByteBuffer _bb)
		{
			return IHollowCylinderTipsActor.GetRootAsIHollowCylinderTipsActor(_bb, default(IHollowCylinderTipsActor));
		}

		// Token: 0x0601536A RID: 86890 RVA: 0x00312814 File Offset: 0x00310A14
		public static IHollowCylinderTipsActor GetRootAsIHollowCylinderTipsActor(ByteBuffer _bb, IHollowCylinderTipsActor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601536B RID: 86891 RVA: 0x00312831 File Offset: 0x00310A31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601536C RID: 86892 RVA: 0x00312840 File Offset: 0x00310A40
		public IHollowCylinderTipsActor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170069D3 RID: 27091
		// (get) Token: 0x0601536D RID: 86893 RVA: 0x00312850 File Offset: 0x00310A50
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

		// Token: 0x170069D4 RID: 27092
		// (get) Token: 0x0601536E RID: 86894 RVA: 0x0031288C File Offset: 0x00310A8C
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

		// Token: 0x170069D5 RID: 27093
		// (get) Token: 0x0601536F RID: 86895 RVA: 0x003128C8 File Offset: 0x00310AC8
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

		// Token: 0x170069D6 RID: 27094
		// (get) Token: 0x06015370 RID: 86896 RVA: 0x00312908 File Offset: 0x00310B08
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

		// Token: 0x170069D7 RID: 27095
		// (get) Token: 0x06015371 RID: 86897 RVA: 0x0031294C File Offset: 0x00310B4C
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

		// Token: 0x170069D8 RID: 27096
		// (get) Token: 0x06015372 RID: 86898 RVA: 0x00312990 File Offset: 0x00310B90
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

		// Token: 0x06015373 RID: 86899 RVA: 0x003129CD File Offset: 0x00310BCD
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

		// Token: 0x06015374 RID: 86900 RVA: 0x00312A09 File Offset: 0x00310C09
		public static void StartIHollowCylinderTipsActor(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06015375 RID: 86901 RVA: 0x00312A12 File Offset: 0x00310C12
		public static void AddType(FlatBufferBuilder builder, ETipsActorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015376 RID: 86902 RVA: 0x00312A1D File Offset: 0x00310C1D
		public static void AddColorType(FlatBufferBuilder builder, ETipsActorColorType colorType)
		{
			builder.AddByte(1, (byte)colorType, 0);
		}

		// Token: 0x06015377 RID: 86903 RVA: 0x00312A28 File Offset: 0x00310C28
		public static void AddRadius(FlatBufferBuilder builder, float radius)
		{
			builder.AddFloat(2, radius, 0.0);
		}

		// Token: 0x06015378 RID: 86904 RVA: 0x00312A3B File Offset: 0x00310C3B
		public static void AddInnerRadius(FlatBufferBuilder builder, float innerRadius)
		{
			builder.AddFloat(3, innerRadius, 0.0);
		}

		// Token: 0x06015379 RID: 86905 RVA: 0x00312A4E File Offset: 0x00310C4E
		public static void AddHeight(FlatBufferBuilder builder, float height)
		{
			builder.AddFloat(4, height, 0.0);
		}

		// Token: 0x0601537A RID: 86906 RVA: 0x00312A61 File Offset: 0x00310C61
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0601537B RID: 86907 RVA: 0x00312A6C File Offset: 0x00310C6C
		public static Offset<IHollowCylinderTipsActor> EndIHollowCylinderTipsActor(FlatBufferBuilder builder)
		{
			return new Offset<IHollowCylinderTipsActor>(builder.EndTable());
		}

		// Token: 0x0601537C RID: 86908 RVA: 0x00312A7C File Offset: 0x00310C7C
		public IHollowCylinderTipsActorT UnPack()
		{
			IHollowCylinderTipsActorT hollowCylinderTipsActorT = new IHollowCylinderTipsActorT();
			this.UnPackTo(hollowCylinderTipsActorT);
			return hollowCylinderTipsActorT;
		}

		// Token: 0x0601537D RID: 86909 RVA: 0x00312A98 File Offset: 0x00310C98
		public void UnPackTo(IHollowCylinderTipsActorT _o)
		{
			_o.Type = this.Type;
			_o.ColorType = this.ColorType;
			_o.Radius = this.Radius;
			_o.InnerRadius = this.InnerRadius;
			_o.Height = this.Height;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601537E RID: 86910 RVA: 0x00312AF0 File Offset: 0x00310CF0
		public static Offset<IHollowCylinderTipsActor> Pack(FlatBufferBuilder builder, IHollowCylinderTipsActorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHollowCylinderTipsActor>);
			}
			return IHollowCylinderTipsActor.CreateIHollowCylinderTipsActor(builder, _o.Type, _o.ColorType, _o.Radius, _o.InnerRadius, _o.Height, _o.NullMask);
		}

		// Token: 0x0400B201 RID: 45569
		private Table __p;
	}
}
