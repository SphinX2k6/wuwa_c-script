using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074F5 RID: 29941
	public struct IPostAkEventTargeted : IFlatbufferObject
	{
		// Token: 0x1700DC66 RID: 56422
		// (get) Token: 0x06034816 RID: 215062 RVA: 0x007118D8 File Offset: 0x0070FAD8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034817 RID: 215063 RVA: 0x007118E5 File Offset: 0x0070FAE5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034818 RID: 215064 RVA: 0x007118EC File Offset: 0x0070FAEC
		public static IPostAkEventTargeted GetRootAsIPostAkEventTargeted(ByteBuffer _bb)
		{
			return IPostAkEventTargeted.GetRootAsIPostAkEventTargeted(_bb, default(IPostAkEventTargeted));
		}

		// Token: 0x06034819 RID: 215065 RVA: 0x00711908 File Offset: 0x0070FB08
		public static IPostAkEventTargeted GetRootAsIPostAkEventTargeted(ByteBuffer _bb, IPostAkEventTargeted obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603481A RID: 215066 RVA: 0x00711925 File Offset: 0x0070FB25
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603481B RID: 215067 RVA: 0x00711934 File Offset: 0x0070FB34
		public IPostAkEventTargeted __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DC67 RID: 56423
		// (get) Token: 0x0603481C RID: 215068 RVA: 0x00711944 File Offset: 0x0070FB44
		public EPostAkEvent Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPostAkEvent.Global;
				}
				return (EPostAkEvent)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DC68 RID: 56424
		// (get) Token: 0x0603481D RID: 215069 RVA: 0x00711980 File Offset: 0x0070FB80
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DC69 RID: 56425
		// (get) Token: 0x0603481E RID: 215070 RVA: 0x007119BC File Offset: 0x0070FBBC
		public string AkEvent
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

		// Token: 0x0603481F RID: 215071 RVA: 0x007119F3 File Offset: 0x0070FBF3
		public Span<byte> GetAkEventBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06034820 RID: 215072 RVA: 0x00711A02 File Offset: 0x0070FC02
		public byte[] GetAkEventArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x06034821 RID: 215073 RVA: 0x00711A10 File Offset: 0x0070FC10
		public static Offset<IPostAkEventTargeted> CreateIPostAkEventTargeted(FlatBufferBuilder builder, EPostAkEvent Type = EPostAkEvent.Global, int EntityId = 0, StringOffset AkEventOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IPostAkEventTargeted.AddAkEvent(builder, AkEventOffset);
			IPostAkEventTargeted.AddEntityId(builder, EntityId);
			IPostAkEventTargeted.AddType(builder, Type);
			return IPostAkEventTargeted.EndIPostAkEventTargeted(builder);
		}

		// Token: 0x06034822 RID: 215074 RVA: 0x00711A34 File Offset: 0x0070FC34
		public static void StartIPostAkEventTargeted(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06034823 RID: 215075 RVA: 0x00711A3D File Offset: 0x0070FC3D
		public static void AddType(FlatBufferBuilder builder, EPostAkEvent type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034824 RID: 215076 RVA: 0x00711A48 File Offset: 0x0070FC48
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x06034825 RID: 215077 RVA: 0x00711A53 File Offset: 0x0070FC53
		public static void AddAkEvent(FlatBufferBuilder builder, StringOffset akEventOffset)
		{
			builder.AddOffset(2, akEventOffset.Value, 0);
		}

		// Token: 0x06034826 RID: 215078 RVA: 0x00711A63 File Offset: 0x0070FC63
		public static Offset<IPostAkEventTargeted> EndIPostAkEventTargeted(FlatBufferBuilder builder)
		{
			return new Offset<IPostAkEventTargeted>(builder.EndTable());
		}

		// Token: 0x06034827 RID: 215079 RVA: 0x00711A70 File Offset: 0x0070FC70
		public IPostAkEventTargetedT UnPack()
		{
			IPostAkEventTargetedT postAkEventTargetedT = new IPostAkEventTargetedT();
			this.UnPackTo(postAkEventTargetedT);
			return postAkEventTargetedT;
		}

		// Token: 0x06034828 RID: 215080 RVA: 0x00711A8B File Offset: 0x0070FC8B
		public void UnPackTo(IPostAkEventTargetedT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.AkEvent = this.AkEvent;
		}

		// Token: 0x06034829 RID: 215081 RVA: 0x00711AB4 File Offset: 0x0070FCB4
		public static Offset<IPostAkEventTargeted> Pack(FlatBufferBuilder builder, IPostAkEventTargetedT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPostAkEventTargeted>);
			}
			StringOffset akEventOffset = (_o.AkEvent == null) ? default(StringOffset) : builder.CreateString(_o.AkEvent);
			return IPostAkEventTargeted.CreateIPostAkEventTargeted(builder, _o.Type, _o.EntityId, akEventOffset);
		}

		// Token: 0x040126BE RID: 75454
		private Table __p;
	}
}
