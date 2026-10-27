using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C4C RID: 15436
	public struct ISplineTipsActor : IFlatbufferObject
	{
		// Token: 0x17006A62 RID: 27234
		// (get) Token: 0x06015557 RID: 87383 RVA: 0x00316310 File Offset: 0x00314510
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015558 RID: 87384 RVA: 0x0031631D File Offset: 0x0031451D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015559 RID: 87385 RVA: 0x00316324 File Offset: 0x00314524
		public static ISplineTipsActor GetRootAsISplineTipsActor(ByteBuffer _bb)
		{
			return ISplineTipsActor.GetRootAsISplineTipsActor(_bb, default(ISplineTipsActor));
		}

		// Token: 0x0601555A RID: 87386 RVA: 0x00316340 File Offset: 0x00314540
		public static ISplineTipsActor GetRootAsISplineTipsActor(ByteBuffer _bb, ISplineTipsActor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601555B RID: 87387 RVA: 0x0031635D File Offset: 0x0031455D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601555C RID: 87388 RVA: 0x0031636C File Offset: 0x0031456C
		public ISplineTipsActor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006A63 RID: 27235
		// (get) Token: 0x0601555D RID: 87389 RVA: 0x0031637C File Offset: 0x0031457C
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

		// Token: 0x17006A64 RID: 27236
		// (get) Token: 0x0601555E RID: 87390 RVA: 0x003163B8 File Offset: 0x003145B8
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

		// Token: 0x17006A65 RID: 27237
		// (get) Token: 0x0601555F RID: 87391 RVA: 0x003163F4 File Offset: 0x003145F4
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006A66 RID: 27238
		// (get) Token: 0x06015560 RID: 87392 RVA: 0x00316430 File Offset: 0x00314630
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

		// Token: 0x06015561 RID: 87393 RVA: 0x0031646D File Offset: 0x0031466D
		public static Offset<ISplineTipsActor> CreateISplineTipsActor(FlatBufferBuilder builder, ETipsActorType Type = ETipsActorType.Sphere, ETipsActorColorType ColorType = ETipsActorColorType.Inner, int EntityId = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			ISplineTipsActor.AddEntityId(builder, EntityId);
			ISplineTipsActor.AddNullMask(builder, NullMask);
			ISplineTipsActor.AddColorType(builder, ColorType);
			ISplineTipsActor.AddType(builder, Type);
			return ISplineTipsActor.EndISplineTipsActor(builder);
		}

		// Token: 0x06015562 RID: 87394 RVA: 0x00316499 File Offset: 0x00314699
		public static void StartISplineTipsActor(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06015563 RID: 87395 RVA: 0x003164A2 File Offset: 0x003146A2
		public static void AddType(FlatBufferBuilder builder, ETipsActorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015564 RID: 87396 RVA: 0x003164AD File Offset: 0x003146AD
		public static void AddColorType(FlatBufferBuilder builder, ETipsActorColorType colorType)
		{
			builder.AddByte(1, (byte)colorType, 0);
		}

		// Token: 0x06015565 RID: 87397 RVA: 0x003164B8 File Offset: 0x003146B8
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(2, entityId, 0);
		}

		// Token: 0x06015566 RID: 87398 RVA: 0x003164C3 File Offset: 0x003146C3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06015567 RID: 87399 RVA: 0x003164CE File Offset: 0x003146CE
		public static Offset<ISplineTipsActor> EndISplineTipsActor(FlatBufferBuilder builder)
		{
			return new Offset<ISplineTipsActor>(builder.EndTable());
		}

		// Token: 0x06015568 RID: 87400 RVA: 0x003164DC File Offset: 0x003146DC
		public ISplineTipsActorT UnPack()
		{
			ISplineTipsActorT splineTipsActorT = new ISplineTipsActorT();
			this.UnPackTo(splineTipsActorT);
			return splineTipsActorT;
		}

		// Token: 0x06015569 RID: 87401 RVA: 0x003164F7 File Offset: 0x003146F7
		public void UnPackTo(ISplineTipsActorT _o)
		{
			_o.Type = this.Type;
			_o.ColorType = this.ColorType;
			_o.EntityId = this.EntityId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601556A RID: 87402 RVA: 0x0031652C File Offset: 0x0031472C
		public static Offset<ISplineTipsActor> Pack(FlatBufferBuilder builder, ISplineTipsActorT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISplineTipsActor>);
			}
			return ISplineTipsActor.CreateISplineTipsActor(builder, _o.Type, _o.ColorType, _o.EntityId, _o.NullMask);
		}

		// Token: 0x0400B258 RID: 45656
		private Table __p;
	}
}
