using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C64 RID: 15460
	public struct ITrackTipsActor : IFlatbufferObject
	{
		// Token: 0x17006AA4 RID: 27300
		// (get) Token: 0x0601563B RID: 87611 RVA: 0x00317DA0 File Offset: 0x00315FA0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601563C RID: 87612 RVA: 0x00317DAD File Offset: 0x00315FAD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601563D RID: 87613 RVA: 0x00317DB4 File Offset: 0x00315FB4
		public static ITrackTipsActor GetRootAsITrackTipsActor(ByteBuffer _bb)
		{
			return ITrackTipsActor.GetRootAsITrackTipsActor(_bb, default(ITrackTipsActor));
		}

		// Token: 0x0601563E RID: 87614 RVA: 0x00317DD0 File Offset: 0x00315FD0
		public static ITrackTipsActor GetRootAsITrackTipsActor(ByteBuffer _bb, ITrackTipsActor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601563F RID: 87615 RVA: 0x00317DED File Offset: 0x00315FED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015640 RID: 87616 RVA: 0x00317DFC File Offset: 0x00315FFC
		public ITrackTipsActor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006AA5 RID: 27301
		// (get) Token: 0x06015641 RID: 87617 RVA: 0x00317E0C File Offset: 0x0031600C
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

		// Token: 0x17006AA6 RID: 27302
		// (get) Token: 0x06015642 RID: 87618 RVA: 0x00317E48 File Offset: 0x00316048
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

		// Token: 0x17006AA7 RID: 27303
		// (get) Token: 0x06015643 RID: 87619 RVA: 0x00317E84 File Offset: 0x00316084
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

		// Token: 0x17006AA8 RID: 27304
		// (get) Token: 0x06015644 RID: 87620 RVA: 0x00317EC0 File Offset: 0x003160C0
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

		// Token: 0x17006AA9 RID: 27305
		// (get) Token: 0x06015645 RID: 87621 RVA: 0x00317F04 File Offset: 0x00316104
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

		// Token: 0x06015646 RID: 87622 RVA: 0x00317F41 File Offset: 0x00316141
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

		// Token: 0x06015647 RID: 87623 RVA: 0x00317F75 File Offset: 0x00316175
		public static void StartITrackTipsActor(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06015648 RID: 87624 RVA: 0x00317F7E File Offset: 0x0031617E
		public static void AddType(FlatBufferBuilder builder, ETipsActorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015649 RID: 87625 RVA: 0x00317F89 File Offset: 0x00316189
		public static void AddColorType(FlatBufferBuilder builder, ETipsActorColorType colorType)
		{
			builder.AddByte(1, (byte)colorType, 0);
		}

		// Token: 0x0601564A RID: 87626 RVA: 0x00317F94 File Offset: 0x00316194
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(2, entityId, 0);
		}

		// Token: 0x0601564B RID: 87627 RVA: 0x00317F9F File Offset: 0x0031619F
		public static void AddWidth(FlatBufferBuilder builder, float width)
		{
			builder.AddFloat(3, width, 0.0);
		}

		// Token: 0x0601564C RID: 87628 RVA: 0x00317FB2 File Offset: 0x003161B2
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0601564D RID: 87629 RVA: 0x00317FBD File Offset: 0x003161BD
		public static Offset<ITrackTipsActor> EndITrackTipsActor(FlatBufferBuilder builder)
		{
			return new Offset<ITrackTipsActor>(builder.EndTable());
		}

		// Token: 0x0601564E RID: 87630 RVA: 0x00317FCC File Offset: 0x003161CC
		public ITrackTipsActorT UnPack()
		{
			ITrackTipsActorT trackTipsActorT = new ITrackTipsActorT();
			this.UnPackTo(trackTipsActorT);
			return trackTipsActorT;
		}

		// Token: 0x0601564F RID: 87631 RVA: 0x00317FE7 File Offset: 0x003161E7
		public void UnPackTo(ITrackTipsActorT _o)
		{
			_o.Type = this.Type;
			_o.ColorType = this.ColorType;
			_o.EntityId = this.EntityId;
			_o.Width = this.Width;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06015650 RID: 87632 RVA: 0x00318028 File Offset: 0x00316228
		public static Offset<ITrackTipsActor> Pack(FlatBufferBuilder builder, ITrackTipsActorT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrackTipsActor>);
			}
			return ITrackTipsActor.CreateITrackTipsActor(builder, _o.Type, _o.ColorType, _o.EntityId, _o.Width, _o.NullMask);
		}

		// Token: 0x0400B288 RID: 45704
		private Table __p;
	}
}
