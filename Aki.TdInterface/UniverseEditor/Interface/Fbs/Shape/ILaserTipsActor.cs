using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C28 RID: 15400
	public struct ILaserTipsActor : IFlatbufferObject
	{
		// Token: 0x17006A03 RID: 27139
		// (get) Token: 0x06015405 RID: 87045 RVA: 0x00313AF7 File Offset: 0x00311CF7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015406 RID: 87046 RVA: 0x00313B04 File Offset: 0x00311D04
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015407 RID: 87047 RVA: 0x00313B0C File Offset: 0x00311D0C
		public static ILaserTipsActor GetRootAsILaserTipsActor(ByteBuffer _bb)
		{
			return ILaserTipsActor.GetRootAsILaserTipsActor(_bb, default(ILaserTipsActor));
		}

		// Token: 0x06015408 RID: 87048 RVA: 0x00313B28 File Offset: 0x00311D28
		public static ILaserTipsActor GetRootAsILaserTipsActor(ByteBuffer _bb, ILaserTipsActor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015409 RID: 87049 RVA: 0x00313B45 File Offset: 0x00311D45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601540A RID: 87050 RVA: 0x00313B54 File Offset: 0x00311D54
		public ILaserTipsActor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006A04 RID: 27140
		// (get) Token: 0x0601540B RID: 87051 RVA: 0x00313B64 File Offset: 0x00311D64
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

		// Token: 0x17006A05 RID: 27141
		// (get) Token: 0x0601540C RID: 87052 RVA: 0x00313BA0 File Offset: 0x00311DA0
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

		// Token: 0x17006A06 RID: 27142
		// (get) Token: 0x0601540D RID: 87053 RVA: 0x00313BDC File Offset: 0x00311DDC
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

		// Token: 0x17006A07 RID: 27143
		// (get) Token: 0x0601540E RID: 87054 RVA: 0x00313C1C File Offset: 0x00311E1C
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

		// Token: 0x17006A08 RID: 27144
		// (get) Token: 0x0601540F RID: 87055 RVA: 0x00313C60 File Offset: 0x00311E60
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

		// Token: 0x06015410 RID: 87056 RVA: 0x00313C9D File Offset: 0x00311E9D
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

		// Token: 0x06015411 RID: 87057 RVA: 0x00313CD1 File Offset: 0x00311ED1
		public static void StartILaserTipsActor(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06015412 RID: 87058 RVA: 0x00313CDA File Offset: 0x00311EDA
		public static void AddType(FlatBufferBuilder builder, ETipsActorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015413 RID: 87059 RVA: 0x00313CE5 File Offset: 0x00311EE5
		public static void AddColorType(FlatBufferBuilder builder, ETipsActorColorType colorType)
		{
			builder.AddByte(1, (byte)colorType, 0);
		}

		// Token: 0x06015414 RID: 87060 RVA: 0x00313CF0 File Offset: 0x00311EF0
		public static void AddRadius(FlatBufferBuilder builder, float radius)
		{
			builder.AddFloat(2, radius, 0.0);
		}

		// Token: 0x06015415 RID: 87061 RVA: 0x00313D03 File Offset: 0x00311F03
		public static void AddHeight(FlatBufferBuilder builder, float height)
		{
			builder.AddFloat(3, height, 0.0);
		}

		// Token: 0x06015416 RID: 87062 RVA: 0x00313D16 File Offset: 0x00311F16
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06015417 RID: 87063 RVA: 0x00313D21 File Offset: 0x00311F21
		public static Offset<ILaserTipsActor> EndILaserTipsActor(FlatBufferBuilder builder)
		{
			return new Offset<ILaserTipsActor>(builder.EndTable());
		}

		// Token: 0x06015418 RID: 87064 RVA: 0x00313D30 File Offset: 0x00311F30
		public ILaserTipsActorT UnPack()
		{
			ILaserTipsActorT laserTipsActorT = new ILaserTipsActorT();
			this.UnPackTo(laserTipsActorT);
			return laserTipsActorT;
		}

		// Token: 0x06015419 RID: 87065 RVA: 0x00313D4B File Offset: 0x00311F4B
		public void UnPackTo(ILaserTipsActorT _o)
		{
			_o.Type = this.Type;
			_o.ColorType = this.ColorType;
			_o.Radius = this.Radius;
			_o.Height = this.Height;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601541A RID: 87066 RVA: 0x00313D8C File Offset: 0x00311F8C
		public static Offset<ILaserTipsActor> Pack(FlatBufferBuilder builder, ILaserTipsActorT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILaserTipsActor>);
			}
			return ILaserTipsActor.CreateILaserTipsActor(builder, _o.Type, _o.ColorType, _o.Radius, _o.Height, _o.NullMask);
		}

		// Token: 0x0400B21C RID: 45596
		private Table __p;
	}
}
