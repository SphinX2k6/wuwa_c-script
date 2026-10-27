using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C49 RID: 15433
	public struct ISplineEffectTipsActor : IFlatbufferObject
	{
		// Token: 0x17006A59 RID: 27225
		// (get) Token: 0x06015539 RID: 87353 RVA: 0x00315FF7 File Offset: 0x003141F7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601553A RID: 87354 RVA: 0x00316004 File Offset: 0x00314204
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601553B RID: 87355 RVA: 0x0031600C File Offset: 0x0031420C
		public static ISplineEffectTipsActor GetRootAsISplineEffectTipsActor(ByteBuffer _bb)
		{
			return ISplineEffectTipsActor.GetRootAsISplineEffectTipsActor(_bb, default(ISplineEffectTipsActor));
		}

		// Token: 0x0601553C RID: 87356 RVA: 0x00316028 File Offset: 0x00314228
		public static ISplineEffectTipsActor GetRootAsISplineEffectTipsActor(ByteBuffer _bb, ISplineEffectTipsActor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601553D RID: 87357 RVA: 0x00316045 File Offset: 0x00314245
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601553E RID: 87358 RVA: 0x00316054 File Offset: 0x00314254
		public ISplineEffectTipsActor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006A5A RID: 27226
		// (get) Token: 0x0601553F RID: 87359 RVA: 0x00316064 File Offset: 0x00314264
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

		// Token: 0x17006A5B RID: 27227
		// (get) Token: 0x06015540 RID: 87360 RVA: 0x003160A0 File Offset: 0x003142A0
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

		// Token: 0x17006A5C RID: 27228
		// (get) Token: 0x06015541 RID: 87361 RVA: 0x003160DC File Offset: 0x003142DC
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

		// Token: 0x17006A5D RID: 27229
		// (get) Token: 0x06015542 RID: 87362 RVA: 0x00316118 File Offset: 0x00314318
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

		// Token: 0x06015543 RID: 87363 RVA: 0x00316155 File Offset: 0x00314355
		public static Offset<ISplineEffectTipsActor> CreateISplineEffectTipsActor(FlatBufferBuilder builder, ETipsActorType Type = ETipsActorType.Sphere, ETipsActorColorType ColorType = ETipsActorColorType.Inner, int EntityId = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			ISplineEffectTipsActor.AddEntityId(builder, EntityId);
			ISplineEffectTipsActor.AddNullMask(builder, NullMask);
			ISplineEffectTipsActor.AddColorType(builder, ColorType);
			ISplineEffectTipsActor.AddType(builder, Type);
			return ISplineEffectTipsActor.EndISplineEffectTipsActor(builder);
		}

		// Token: 0x06015544 RID: 87364 RVA: 0x00316181 File Offset: 0x00314381
		public static void StartISplineEffectTipsActor(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06015545 RID: 87365 RVA: 0x0031618A File Offset: 0x0031438A
		public static void AddType(FlatBufferBuilder builder, ETipsActorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015546 RID: 87366 RVA: 0x00316195 File Offset: 0x00314395
		public static void AddColorType(FlatBufferBuilder builder, ETipsActorColorType colorType)
		{
			builder.AddByte(1, (byte)colorType, 0);
		}

		// Token: 0x06015547 RID: 87367 RVA: 0x003161A0 File Offset: 0x003143A0
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(2, entityId, 0);
		}

		// Token: 0x06015548 RID: 87368 RVA: 0x003161AB File Offset: 0x003143AB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06015549 RID: 87369 RVA: 0x003161B6 File Offset: 0x003143B6
		public static Offset<ISplineEffectTipsActor> EndISplineEffectTipsActor(FlatBufferBuilder builder)
		{
			return new Offset<ISplineEffectTipsActor>(builder.EndTable());
		}

		// Token: 0x0601554A RID: 87370 RVA: 0x003161C4 File Offset: 0x003143C4
		public ISplineEffectTipsActorT UnPack()
		{
			ISplineEffectTipsActorT splineEffectTipsActorT = new ISplineEffectTipsActorT();
			this.UnPackTo(splineEffectTipsActorT);
			return splineEffectTipsActorT;
		}

		// Token: 0x0601554B RID: 87371 RVA: 0x003161DF File Offset: 0x003143DF
		public void UnPackTo(ISplineEffectTipsActorT _o)
		{
			_o.Type = this.Type;
			_o.ColorType = this.ColorType;
			_o.EntityId = this.EntityId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601554C RID: 87372 RVA: 0x00316214 File Offset: 0x00314414
		public static Offset<ISplineEffectTipsActor> Pack(FlatBufferBuilder builder, ISplineEffectTipsActorT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISplineEffectTipsActor>);
			}
			return ISplineEffectTipsActor.CreateISplineEffectTipsActor(builder, _o.Type, _o.ColorType, _o.EntityId, _o.NullMask);
		}

		// Token: 0x0400B253 RID: 45651
		private Table __p;
	}
}
