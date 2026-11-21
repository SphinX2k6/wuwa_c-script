using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004034 RID: 16436
	public struct ILaserTipsActor : IFlatbufferObject
	{
		// Token: 0x17006FAB RID: 28587
		// (get) Token: 0x060168FB RID: 92411 RVA: 0x0033A67F File Offset: 0x0033887F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060168FC RID: 92412 RVA: 0x0033A68C File Offset: 0x0033888C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060168FD RID: 92413 RVA: 0x0033A694 File Offset: 0x00338894
		public static ILaserTipsActor GetRootAsILaserTipsActor(ByteBuffer _bb)
		{
			return ILaserTipsActor.GetRootAsILaserTipsActor(_bb, default(ILaserTipsActor));
		}

		// Token: 0x060168FE RID: 92414 RVA: 0x0033A6B0 File Offset: 0x003388B0
		public static ILaserTipsActor GetRootAsILaserTipsActor(ByteBuffer _bb, ILaserTipsActor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060168FF RID: 92415 RVA: 0x0033A6CD File Offset: 0x003388CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016900 RID: 92416 RVA: 0x0033A6DC File Offset: 0x003388DC
		public ILaserTipsActor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006FAC RID: 28588
		// (get) Token: 0x06016901 RID: 92417 RVA: 0x0033A6EC File Offset: 0x003388EC
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

		// Token: 0x17006FAD RID: 28589
		// (get) Token: 0x06016902 RID: 92418 RVA: 0x0033A728 File Offset: 0x00338928
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

		// Token: 0x17006FAE RID: 28590
		// (get) Token: 0x06016903 RID: 92419 RVA: 0x0033A764 File Offset: 0x00338964
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

		// Token: 0x17006FAF RID: 28591
		// (get) Token: 0x06016904 RID: 92420 RVA: 0x0033A7A4 File Offset: 0x003389A4
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

		// Token: 0x17006FB0 RID: 28592
		// (get) Token: 0x06016905 RID: 92421 RVA: 0x0033A7E8 File Offset: 0x003389E8
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

		// Token: 0x06016906 RID: 92422 RVA: 0x0033A825 File Offset: 0x00338A25
		public static Offset<ILaserTipsActor> CreateILaserTipsActor(FlatBufferBuilder builder, ETipsActorType Type = ETipsActorType.Sphere, ETipsActorColorType ColorType = ETipsActorColorType.Inner, float Radius = 0f, float Height = 0f, byte NullMask = 0)
		{
			builder.StartTable(5);
			ILaserTipsActor.AddHeight(builder, Height);
			ILaserTipsActor.AddRadius(builder, Radius);
			ILaserTipsActor.AddNullMask(builder, NullMask);
			ILaserTipsActor.AddColorType(builder, ColorType);
			ILaserTipsActor.AddType(builder, Type);
			return ILaserTipsActor.EndILaserTipsActor(builder);
		}

		// Token: 0x06016907 RID: 92423 RVA: 0x0033A859 File Offset: 0x00338A59
		public static void StartILaserTipsActor(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06016908 RID: 92424 RVA: 0x0033A862 File Offset: 0x00338A62
		public static void AddType(FlatBufferBuilder builder, ETipsActorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016909 RID: 92425 RVA: 0x0033A86D File Offset: 0x00338A6D
		public static void AddColorType(FlatBufferBuilder builder, ETipsActorColorType colorType)
		{
			builder.AddByte(1, (byte)colorType, 0);
		}

		// Token: 0x0601690A RID: 92426 RVA: 0x0033A878 File Offset: 0x00338A78
		public static void AddRadius(FlatBufferBuilder builder, float radius)
		{
			builder.AddFloat(2, radius, 0.0);
		}

		// Token: 0x0601690B RID: 92427 RVA: 0x0033A88B File Offset: 0x00338A8B
		public static void AddHeight(FlatBufferBuilder builder, float height)
		{
			builder.AddFloat(3, height, 0.0);
		}

		// Token: 0x0601690C RID: 92428 RVA: 0x0033A89E File Offset: 0x00338A9E
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0601690D RID: 92429 RVA: 0x0033A8A9 File Offset: 0x00338AA9
		public static Offset<ILaserTipsActor> EndILaserTipsActor(FlatBufferBuilder builder)
		{
			return new Offset<ILaserTipsActor>(builder.EndTable());
		}

		// Token: 0x0601690E RID: 92430 RVA: 0x0033A8B8 File Offset: 0x00338AB8
		public ILaserTipsActorT UnPack()
		{
			ILaserTipsActorT laserTipsActorT = new ILaserTipsActorT();
			this.UnPackTo(laserTipsActorT);
			return laserTipsActorT;
		}

		// Token: 0x0601690F RID: 92431 RVA: 0x0033A8D3 File Offset: 0x00338AD3
		public void UnPackTo(ILaserTipsActorT _o)
		{
			_o.Type = this.Type;
			_o.ColorType = this.ColorType;
			_o.Radius = this.Radius;
			_o.Height = this.Height;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06016910 RID: 92432 RVA: 0x0033A914 File Offset: 0x00338B14
		public static Offset<ILaserTipsActor> Pack(FlatBufferBuilder builder, ILaserTipsActorT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILaserTipsActor>);
			}
			return ILaserTipsActor.CreateILaserTipsActor(builder, _o.Type, _o.ColorType, _o.Radius, _o.Height, _o.NullMask);
		}

		// Token: 0x0400BBA7 RID: 48039
		private Table __p;
	}
}
