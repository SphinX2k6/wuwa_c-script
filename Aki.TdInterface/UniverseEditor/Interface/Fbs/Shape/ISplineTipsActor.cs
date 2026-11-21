using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x0200405B RID: 16475
	public struct ISplineTipsActor : IFlatbufferObject
	{
		// Token: 0x17007013 RID: 28691
		// (get) Token: 0x06016A6B RID: 92779 RVA: 0x0033D1B0 File Offset: 0x0033B3B0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016A6C RID: 92780 RVA: 0x0033D1BD File Offset: 0x0033B3BD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016A6D RID: 92781 RVA: 0x0033D1C4 File Offset: 0x0033B3C4
		public static ISplineTipsActor GetRootAsISplineTipsActor(ByteBuffer _bb)
		{
			return ISplineTipsActor.GetRootAsISplineTipsActor(_bb, default(ISplineTipsActor));
		}

		// Token: 0x06016A6E RID: 92782 RVA: 0x0033D1E0 File Offset: 0x0033B3E0
		public static ISplineTipsActor GetRootAsISplineTipsActor(ByteBuffer _bb, ISplineTipsActor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016A6F RID: 92783 RVA: 0x0033D1FD File Offset: 0x0033B3FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016A70 RID: 92784 RVA: 0x0033D20C File Offset: 0x0033B40C
		public ISplineTipsActor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007014 RID: 28692
		// (get) Token: 0x06016A71 RID: 92785 RVA: 0x0033D21C File Offset: 0x0033B41C
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

		// Token: 0x17007015 RID: 28693
		// (get) Token: 0x06016A72 RID: 92786 RVA: 0x0033D258 File Offset: 0x0033B458
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

		// Token: 0x17007016 RID: 28694
		// (get) Token: 0x06016A73 RID: 92787 RVA: 0x0033D294 File Offset: 0x0033B494
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

		// Token: 0x17007017 RID: 28695
		// (get) Token: 0x06016A74 RID: 92788 RVA: 0x0033D2D0 File Offset: 0x0033B4D0
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

		// Token: 0x06016A75 RID: 92789 RVA: 0x0033D30D File Offset: 0x0033B50D
		public static Offset<ISplineTipsActor> CreateISplineTipsActor(FlatBufferBuilder builder, ETipsActorType Type = ETipsActorType.Sphere, ETipsActorColorType ColorType = ETipsActorColorType.Inner, int EntityId = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			ISplineTipsActor.AddEntityId(builder, EntityId);
			ISplineTipsActor.AddNullMask(builder, NullMask);
			ISplineTipsActor.AddColorType(builder, ColorType);
			ISplineTipsActor.AddType(builder, Type);
			return ISplineTipsActor.EndISplineTipsActor(builder);
		}

		// Token: 0x06016A76 RID: 92790 RVA: 0x0033D339 File Offset: 0x0033B539
		public static void StartISplineTipsActor(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06016A77 RID: 92791 RVA: 0x0033D342 File Offset: 0x0033B542
		public static void AddType(FlatBufferBuilder builder, ETipsActorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016A78 RID: 92792 RVA: 0x0033D34D File Offset: 0x0033B54D
		public static void AddColorType(FlatBufferBuilder builder, ETipsActorColorType colorType)
		{
			builder.AddByte(1, (byte)colorType, 0);
		}

		// Token: 0x06016A79 RID: 92793 RVA: 0x0033D358 File Offset: 0x0033B558
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(2, entityId, 0);
		}

		// Token: 0x06016A7A RID: 92794 RVA: 0x0033D363 File Offset: 0x0033B563
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06016A7B RID: 92795 RVA: 0x0033D36E File Offset: 0x0033B56E
		public static Offset<ISplineTipsActor> EndISplineTipsActor(FlatBufferBuilder builder)
		{
			return new Offset<ISplineTipsActor>(builder.EndTable());
		}

		// Token: 0x06016A7C RID: 92796 RVA: 0x0033D37C File Offset: 0x0033B57C
		public ISplineTipsActorT UnPack()
		{
			ISplineTipsActorT splineTipsActorT = new ISplineTipsActorT();
			this.UnPackTo(splineTipsActorT);
			return splineTipsActorT;
		}

		// Token: 0x06016A7D RID: 92797 RVA: 0x0033D397 File Offset: 0x0033B597
		public void UnPackTo(ISplineTipsActorT _o)
		{
			_o.Type = this.Type;
			_o.ColorType = this.ColorType;
			_o.EntityId = this.EntityId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06016A7E RID: 92798 RVA: 0x0033D3CC File Offset: 0x0033B5CC
		public static Offset<ISplineTipsActor> Pack(FlatBufferBuilder builder, ISplineTipsActorT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISplineTipsActor>);
			}
			return ISplineTipsActor.CreateISplineTipsActor(builder, _o.Type, _o.ColorType, _o.EntityId, _o.NullMask);
		}

		// Token: 0x0400BBE8 RID: 48104
		private Table __p;
	}
}
