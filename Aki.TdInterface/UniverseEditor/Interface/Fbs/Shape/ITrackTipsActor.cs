using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004073 RID: 16499
	public struct ITrackTipsActor : IFlatbufferObject
	{
		// Token: 0x17007055 RID: 28757
		// (get) Token: 0x06016B4F RID: 93007 RVA: 0x0033EC40 File Offset: 0x0033CE40
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016B50 RID: 93008 RVA: 0x0033EC4D File Offset: 0x0033CE4D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016B51 RID: 93009 RVA: 0x0033EC54 File Offset: 0x0033CE54
		public static ITrackTipsActor GetRootAsITrackTipsActor(ByteBuffer _bb)
		{
			return ITrackTipsActor.GetRootAsITrackTipsActor(_bb, default(ITrackTipsActor));
		}

		// Token: 0x06016B52 RID: 93010 RVA: 0x0033EC70 File Offset: 0x0033CE70
		public static ITrackTipsActor GetRootAsITrackTipsActor(ByteBuffer _bb, ITrackTipsActor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016B53 RID: 93011 RVA: 0x0033EC8D File Offset: 0x0033CE8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016B54 RID: 93012 RVA: 0x0033EC9C File Offset: 0x0033CE9C
		public ITrackTipsActor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007056 RID: 28758
		// (get) Token: 0x06016B55 RID: 93013 RVA: 0x0033ECAC File Offset: 0x0033CEAC
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

		// Token: 0x17007057 RID: 28759
		// (get) Token: 0x06016B56 RID: 93014 RVA: 0x0033ECE8 File Offset: 0x0033CEE8
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

		// Token: 0x17007058 RID: 28760
		// (get) Token: 0x06016B57 RID: 93015 RVA: 0x0033ED24 File Offset: 0x0033CF24
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

		// Token: 0x17007059 RID: 28761
		// (get) Token: 0x06016B58 RID: 93016 RVA: 0x0033ED60 File Offset: 0x0033CF60
		public float Width
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

		// Token: 0x1700705A RID: 28762
		// (get) Token: 0x06016B59 RID: 93017 RVA: 0x0033EDA4 File Offset: 0x0033CFA4
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

		// Token: 0x06016B5A RID: 93018 RVA: 0x0033EDE1 File Offset: 0x0033CFE1
		public static Offset<ITrackTipsActor> CreateITrackTipsActor(FlatBufferBuilder builder, ETipsActorType Type = ETipsActorType.Sphere, ETipsActorColorType ColorType = ETipsActorColorType.Inner, int EntityId = 0, float Width = 0f, byte NullMask = 0)
		{
			builder.StartTable(5);
			ITrackTipsActor.AddWidth(builder, Width);
			ITrackTipsActor.AddEntityId(builder, EntityId);
			ITrackTipsActor.AddNullMask(builder, NullMask);
			ITrackTipsActor.AddColorType(builder, ColorType);
			ITrackTipsActor.AddType(builder, Type);
			return ITrackTipsActor.EndITrackTipsActor(builder);
		}

		// Token: 0x06016B5B RID: 93019 RVA: 0x0033EE15 File Offset: 0x0033D015
		public static void StartITrackTipsActor(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06016B5C RID: 93020 RVA: 0x0033EE1E File Offset: 0x0033D01E
		public static void AddType(FlatBufferBuilder builder, ETipsActorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016B5D RID: 93021 RVA: 0x0033EE29 File Offset: 0x0033D029
		public static void AddColorType(FlatBufferBuilder builder, ETipsActorColorType colorType)
		{
			builder.AddByte(1, (byte)colorType, 0);
		}

		// Token: 0x06016B5E RID: 93022 RVA: 0x0033EE34 File Offset: 0x0033D034
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(2, entityId, 0);
		}

		// Token: 0x06016B5F RID: 93023 RVA: 0x0033EE3F File Offset: 0x0033D03F
		public static void AddWidth(FlatBufferBuilder builder, float width)
		{
			builder.AddFloat(3, width, 0.0);
		}

		// Token: 0x06016B60 RID: 93024 RVA: 0x0033EE52 File Offset: 0x0033D052
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06016B61 RID: 93025 RVA: 0x0033EE5D File Offset: 0x0033D05D
		public static Offset<ITrackTipsActor> EndITrackTipsActor(FlatBufferBuilder builder)
		{
			return new Offset<ITrackTipsActor>(builder.EndTable());
		}

		// Token: 0x06016B62 RID: 93026 RVA: 0x0033EE6C File Offset: 0x0033D06C
		public ITrackTipsActorT UnPack()
		{
			ITrackTipsActorT trackTipsActorT = new ITrackTipsActorT();
			this.UnPackTo(trackTipsActorT);
			return trackTipsActorT;
		}

		// Token: 0x06016B63 RID: 93027 RVA: 0x0033EE87 File Offset: 0x0033D087
		public void UnPackTo(ITrackTipsActorT _o)
		{
			_o.Type = this.Type;
			_o.ColorType = this.ColorType;
			_o.EntityId = this.EntityId;
			_o.Width = this.Width;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06016B64 RID: 93028 RVA: 0x0033EEC8 File Offset: 0x0033D0C8
		public static Offset<ITrackTipsActor> Pack(FlatBufferBuilder builder, ITrackTipsActorT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrackTipsActor>);
			}
			return ITrackTipsActor.CreateITrackTipsActor(builder, _o.Type, _o.ColorType, _o.EntityId, _o.Width, _o.NullMask);
		}

		// Token: 0x0400BC18 RID: 48152
		private Table __p;
	}
}
