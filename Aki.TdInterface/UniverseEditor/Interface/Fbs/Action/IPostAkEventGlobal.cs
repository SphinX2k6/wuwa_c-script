using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D71 RID: 28017
	public struct IPostAkEventGlobal : IFlatbufferObject
	{
		// Token: 0x1700D105 RID: 53509
		// (get) Token: 0x060317BC RID: 202684 RVA: 0x006B57C2 File Offset: 0x006B39C2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060317BD RID: 202685 RVA: 0x006B57CF File Offset: 0x006B39CF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060317BE RID: 202686 RVA: 0x006B57D8 File Offset: 0x006B39D8
		public static IPostAkEventGlobal GetRootAsIPostAkEventGlobal(ByteBuffer _bb)
		{
			return IPostAkEventGlobal.GetRootAsIPostAkEventGlobal(_bb, default(IPostAkEventGlobal));
		}

		// Token: 0x060317BF RID: 202687 RVA: 0x006B57F4 File Offset: 0x006B39F4
		public static IPostAkEventGlobal GetRootAsIPostAkEventGlobal(ByteBuffer _bb, IPostAkEventGlobal obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060317C0 RID: 202688 RVA: 0x006B5811 File Offset: 0x006B3A11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060317C1 RID: 202689 RVA: 0x006B5820 File Offset: 0x006B3A20
		public IPostAkEventGlobal __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D106 RID: 53510
		// (get) Token: 0x060317C2 RID: 202690 RVA: 0x006B5830 File Offset: 0x006B3A30
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

		// Token: 0x1700D107 RID: 53511
		// (get) Token: 0x060317C3 RID: 202691 RVA: 0x006B586C File Offset: 0x006B3A6C
		public string AkEvent
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060317C4 RID: 202692 RVA: 0x006B58A3 File Offset: 0x006B3AA3
		public Span<byte> GetAkEventBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060317C5 RID: 202693 RVA: 0x006B58B2 File Offset: 0x006B3AB2
		public byte[] GetAkEventArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060317C6 RID: 202694 RVA: 0x006B58C0 File Offset: 0x006B3AC0
		public static Offset<IPostAkEventGlobal> CreateIPostAkEventGlobal(FlatBufferBuilder builder, EPostAkEvent Type = EPostAkEvent.Global, StringOffset AkEventOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IPostAkEventGlobal.AddAkEvent(builder, AkEventOffset);
			IPostAkEventGlobal.AddType(builder, Type);
			return IPostAkEventGlobal.EndIPostAkEventGlobal(builder);
		}

		// Token: 0x060317C7 RID: 202695 RVA: 0x006B58DD File Offset: 0x006B3ADD
		public static void StartIPostAkEventGlobal(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060317C8 RID: 202696 RVA: 0x006B58E6 File Offset: 0x006B3AE6
		public static void AddType(FlatBufferBuilder builder, EPostAkEvent type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060317C9 RID: 202697 RVA: 0x006B58F1 File Offset: 0x006B3AF1
		public static void AddAkEvent(FlatBufferBuilder builder, StringOffset akEventOffset)
		{
			builder.AddOffset(1, akEventOffset.Value, 0);
		}

		// Token: 0x060317CA RID: 202698 RVA: 0x006B5901 File Offset: 0x006B3B01
		public static Offset<IPostAkEventGlobal> EndIPostAkEventGlobal(FlatBufferBuilder builder)
		{
			return new Offset<IPostAkEventGlobal>(builder.EndTable());
		}

		// Token: 0x060317CB RID: 202699 RVA: 0x006B5910 File Offset: 0x006B3B10
		public IPostAkEventGlobalT UnPack()
		{
			IPostAkEventGlobalT postAkEventGlobalT = new IPostAkEventGlobalT();
			this.UnPackTo(postAkEventGlobalT);
			return postAkEventGlobalT;
		}

		// Token: 0x060317CC RID: 202700 RVA: 0x006B592B File Offset: 0x006B3B2B
		public void UnPackTo(IPostAkEventGlobalT _o)
		{
			_o.Type = this.Type;
			_o.AkEvent = this.AkEvent;
		}

		// Token: 0x060317CD RID: 202701 RVA: 0x006B5948 File Offset: 0x006B3B48
		public static Offset<IPostAkEventGlobal> Pack(FlatBufferBuilder builder, IPostAkEventGlobalT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPostAkEventGlobal>);
			}
			StringOffset akEventOffset = (_o.AkEvent == null) ? default(StringOffset) : builder.CreateString(_o.AkEvent);
			return IPostAkEventGlobal.CreateIPostAkEventGlobal(builder, _o.Type, akEventOffset);
		}

		// Token: 0x04011734 RID: 71476
		private Table __p;
	}
}
