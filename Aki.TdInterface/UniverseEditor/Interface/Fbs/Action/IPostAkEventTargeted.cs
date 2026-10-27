using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D7A RID: 28026
	public struct IPostAkEventTargeted : IFlatbufferObject
	{
		// Token: 0x1700D11E RID: 53534
		// (get) Token: 0x0603181A RID: 202778 RVA: 0x006B61F0 File Offset: 0x006B43F0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603181B RID: 202779 RVA: 0x006B61FD File Offset: 0x006B43FD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603181C RID: 202780 RVA: 0x006B6204 File Offset: 0x006B4404
		public static IPostAkEventTargeted GetRootAsIPostAkEventTargeted(ByteBuffer _bb)
		{
			return IPostAkEventTargeted.GetRootAsIPostAkEventTargeted(_bb, default(IPostAkEventTargeted));
		}

		// Token: 0x0603181D RID: 202781 RVA: 0x006B6220 File Offset: 0x006B4420
		public static IPostAkEventTargeted GetRootAsIPostAkEventTargeted(ByteBuffer _bb, IPostAkEventTargeted obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603181E RID: 202782 RVA: 0x006B623D File Offset: 0x006B443D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603181F RID: 202783 RVA: 0x006B624C File Offset: 0x006B444C
		public IPostAkEventTargeted __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D11F RID: 53535
		// (get) Token: 0x06031820 RID: 202784 RVA: 0x006B625C File Offset: 0x006B445C
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

		// Token: 0x1700D120 RID: 53536
		// (get) Token: 0x06031821 RID: 202785 RVA: 0x006B6298 File Offset: 0x006B4498
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

		// Token: 0x1700D121 RID: 53537
		// (get) Token: 0x06031822 RID: 202786 RVA: 0x006B62D4 File Offset: 0x006B44D4
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

		// Token: 0x06031823 RID: 202787 RVA: 0x006B630B File Offset: 0x006B450B
		public Span<byte> GetAkEventBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06031824 RID: 202788 RVA: 0x006B631A File Offset: 0x006B451A
		public byte[] GetAkEventArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x06031825 RID: 202789 RVA: 0x006B6328 File Offset: 0x006B4528
		public static Offset<IPostAkEventTargeted> CreateIPostAkEventTargeted(FlatBufferBuilder builder, EPostAkEvent Type = EPostAkEvent.Global, int EntityId = 0, StringOffset AkEventOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IPostAkEventTargeted.AddAkEvent(builder, AkEventOffset);
			IPostAkEventTargeted.AddEntityId(builder, EntityId);
			IPostAkEventTargeted.AddType(builder, Type);
			return IPostAkEventTargeted.EndIPostAkEventTargeted(builder);
		}

		// Token: 0x06031826 RID: 202790 RVA: 0x006B634C File Offset: 0x006B454C
		public static void StartIPostAkEventTargeted(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06031827 RID: 202791 RVA: 0x006B6355 File Offset: 0x006B4555
		public static void AddType(FlatBufferBuilder builder, EPostAkEvent type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031828 RID: 202792 RVA: 0x006B6360 File Offset: 0x006B4560
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x06031829 RID: 202793 RVA: 0x006B636B File Offset: 0x006B456B
		public static void AddAkEvent(FlatBufferBuilder builder, StringOffset akEventOffset)
		{
			builder.AddOffset(2, akEventOffset.Value, 0);
		}

		// Token: 0x0603182A RID: 202794 RVA: 0x006B637B File Offset: 0x006B457B
		public static Offset<IPostAkEventTargeted> EndIPostAkEventTargeted(FlatBufferBuilder builder)
		{
			return new Offset<IPostAkEventTargeted>(builder.EndTable());
		}

		// Token: 0x0603182B RID: 202795 RVA: 0x006B6388 File Offset: 0x006B4588
		public IPostAkEventTargetedT UnPack()
		{
			IPostAkEventTargetedT postAkEventTargetedT = new IPostAkEventTargetedT();
			this.UnPackTo(postAkEventTargetedT);
			return postAkEventTargetedT;
		}

		// Token: 0x0603182C RID: 202796 RVA: 0x006B63A3 File Offset: 0x006B45A3
		public void UnPackTo(IPostAkEventTargetedT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.AkEvent = this.AkEvent;
		}

		// Token: 0x0603182D RID: 202797 RVA: 0x006B63CC File Offset: 0x006B45CC
		public static Offset<IPostAkEventTargeted> Pack(FlatBufferBuilder builder, IPostAkEventTargetedT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPostAkEventTargeted>);
			}
			StringOffset akEventOffset = (_o.AkEvent == null) ? default(StringOffset) : builder.CreateString(_o.AkEvent);
			return IPostAkEventTargeted.CreateIPostAkEventTargeted(builder, _o.Type, _o.EntityId, akEventOffset);
		}

		// Token: 0x04011742 RID: 71490
		private Table __p;
	}
}
