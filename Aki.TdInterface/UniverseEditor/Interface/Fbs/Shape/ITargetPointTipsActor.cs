using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C55 RID: 15445
	public struct ITargetPointTipsActor : IFlatbufferObject
	{
		// Token: 0x17006A85 RID: 27269
		// (get) Token: 0x060155C1 RID: 87489 RVA: 0x00316F4A File Offset: 0x0031514A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060155C2 RID: 87490 RVA: 0x00316F57 File Offset: 0x00315157
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060155C3 RID: 87491 RVA: 0x00316F60 File Offset: 0x00315160
		public static ITargetPointTipsActor GetRootAsITargetPointTipsActor(ByteBuffer _bb)
		{
			return ITargetPointTipsActor.GetRootAsITargetPointTipsActor(_bb, default(ITargetPointTipsActor));
		}

		// Token: 0x060155C4 RID: 87492 RVA: 0x00316F7C File Offset: 0x0031517C
		public static ITargetPointTipsActor GetRootAsITargetPointTipsActor(ByteBuffer _bb, ITargetPointTipsActor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060155C5 RID: 87493 RVA: 0x00316F99 File Offset: 0x00315199
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060155C6 RID: 87494 RVA: 0x00316FA8 File Offset: 0x003151A8
		public ITargetPointTipsActor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006A86 RID: 27270
		// (get) Token: 0x060155C7 RID: 87495 RVA: 0x00316FB8 File Offset: 0x003151B8
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

		// Token: 0x17006A87 RID: 27271
		// (get) Token: 0x060155C8 RID: 87496 RVA: 0x00316FF4 File Offset: 0x003151F4
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

		// Token: 0x17006A88 RID: 27272
		// (get) Token: 0x060155C9 RID: 87497 RVA: 0x00317030 File Offset: 0x00315230
		public string Label
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060155CA RID: 87498 RVA: 0x00317067 File Offset: 0x00315267
		public Span<byte> GetLabelBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060155CB RID: 87499 RVA: 0x00317076 File Offset: 0x00315276
		public byte[] GetLabelArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17006A89 RID: 27273
		// (get) Token: 0x060155CC RID: 87500 RVA: 0x00317084 File Offset: 0x00315284
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

		// Token: 0x060155CD RID: 87501 RVA: 0x003170C1 File Offset: 0x003152C1
		public static Offset<ITargetPointTipsActor> CreateITargetPointTipsActor(FlatBufferBuilder builder, ETipsActorType Type = ETipsActorType.Sphere, ETipsActorColorType ColorType = ETipsActorColorType.Inner, StringOffset LabelOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			ITargetPointTipsActor.AddLabel(builder, LabelOffset);
			ITargetPointTipsActor.AddNullMask(builder, NullMask);
			ITargetPointTipsActor.AddColorType(builder, ColorType);
			ITargetPointTipsActor.AddType(builder, Type);
			return ITargetPointTipsActor.EndITargetPointTipsActor(builder);
		}

		// Token: 0x060155CE RID: 87502 RVA: 0x003170ED File Offset: 0x003152ED
		public static void StartITargetPointTipsActor(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060155CF RID: 87503 RVA: 0x003170F6 File Offset: 0x003152F6
		public static void AddType(FlatBufferBuilder builder, ETipsActorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060155D0 RID: 87504 RVA: 0x00317101 File Offset: 0x00315301
		public static void AddColorType(FlatBufferBuilder builder, ETipsActorColorType colorType)
		{
			builder.AddByte(1, (byte)colorType, 0);
		}

		// Token: 0x060155D1 RID: 87505 RVA: 0x0031710C File Offset: 0x0031530C
		public static void AddLabel(FlatBufferBuilder builder, StringOffset labelOffset)
		{
			builder.AddOffset(2, labelOffset.Value, 0);
		}

		// Token: 0x060155D2 RID: 87506 RVA: 0x0031711C File Offset: 0x0031531C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x060155D3 RID: 87507 RVA: 0x00317127 File Offset: 0x00315327
		public static Offset<ITargetPointTipsActor> EndITargetPointTipsActor(FlatBufferBuilder builder)
		{
			return new Offset<ITargetPointTipsActor>(builder.EndTable());
		}

		// Token: 0x060155D4 RID: 87508 RVA: 0x00317134 File Offset: 0x00315334
		public ITargetPointTipsActorT UnPack()
		{
			ITargetPointTipsActorT targetPointTipsActorT = new ITargetPointTipsActorT();
			this.UnPackTo(targetPointTipsActorT);
			return targetPointTipsActorT;
		}

		// Token: 0x060155D5 RID: 87509 RVA: 0x0031714F File Offset: 0x0031534F
		public void UnPackTo(ITargetPointTipsActorT _o)
		{
			_o.Type = this.Type;
			_o.ColorType = this.ColorType;
			_o.Label = this.Label;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060155D6 RID: 87510 RVA: 0x00317184 File Offset: 0x00315384
		public static Offset<ITargetPointTipsActor> Pack(FlatBufferBuilder builder, ITargetPointTipsActorT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITargetPointTipsActor>);
			}
			StringOffset labelOffset = (_o.Label == null) ? default(StringOffset) : builder.CreateString(_o.Label);
			return ITargetPointTipsActor.CreateITargetPointTipsActor(builder, _o.Type, _o.ColorType, labelOffset, _o.NullMask);
		}

		// Token: 0x0400B26B RID: 45675
		private Table __p;
	}
}
