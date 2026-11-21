using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A11 RID: 27153
	public struct IClientEventPianoEvent : IFlatbufferObject
	{
		// Token: 0x1700C7A7 RID: 51111
		// (get) Token: 0x0602E955 RID: 190805 RVA: 0x0065A61C File Offset: 0x0065881C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E956 RID: 190806 RVA: 0x0065A629 File Offset: 0x00658829
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E957 RID: 190807 RVA: 0x0065A630 File Offset: 0x00658830
		public static IClientEventPianoEvent GetRootAsIClientEventPianoEvent(ByteBuffer _bb)
		{
			return IClientEventPianoEvent.GetRootAsIClientEventPianoEvent(_bb, default(IClientEventPianoEvent));
		}

		// Token: 0x0602E958 RID: 190808 RVA: 0x0065A64C File Offset: 0x0065884C
		public static IClientEventPianoEvent GetRootAsIClientEventPianoEvent(ByteBuffer _bb, IClientEventPianoEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E959 RID: 190809 RVA: 0x0065A669 File Offset: 0x00658869
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E95A RID: 190810 RVA: 0x0065A678 File Offset: 0x00658878
		public IClientEventPianoEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C7A8 RID: 51112
		// (get) Token: 0x0602E95B RID: 190811 RVA: 0x0065A688 File Offset: 0x00658888
		public EClientEventPianoEventType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EClientEventPianoEventType.UpdateSubtitle;
				}
				return (EClientEventPianoEventType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E95C RID: 190812 RVA: 0x0065A6C4 File Offset: 0x006588C4
		public static Offset<IClientEventPianoEvent> CreateIClientEventPianoEvent(FlatBufferBuilder builder, EClientEventPianoEventType Type = EClientEventPianoEventType.UpdateSubtitle)
		{
			builder.StartTable(1);
			IClientEventPianoEvent.AddType(builder, Type);
			return IClientEventPianoEvent.EndIClientEventPianoEvent(builder);
		}

		// Token: 0x0602E95D RID: 190813 RVA: 0x0065A6DA File Offset: 0x006588DA
		public static void StartIClientEventPianoEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602E95E RID: 190814 RVA: 0x0065A6E3 File Offset: 0x006588E3
		public static void AddType(FlatBufferBuilder builder, EClientEventPianoEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E95F RID: 190815 RVA: 0x0065A6EE File Offset: 0x006588EE
		public static Offset<IClientEventPianoEvent> EndIClientEventPianoEvent(FlatBufferBuilder builder)
		{
			return new Offset<IClientEventPianoEvent>(builder.EndTable());
		}

		// Token: 0x0602E960 RID: 190816 RVA: 0x0065A6FC File Offset: 0x006588FC
		public IClientEventPianoEventT UnPack()
		{
			IClientEventPianoEventT clientEventPianoEventT = new IClientEventPianoEventT();
			this.UnPackTo(clientEventPianoEventT);
			return clientEventPianoEventT;
		}

		// Token: 0x0602E961 RID: 190817 RVA: 0x0065A717 File Offset: 0x00658917
		public void UnPackTo(IClientEventPianoEventT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602E962 RID: 190818 RVA: 0x0065A728 File Offset: 0x00658928
		public static Offset<IClientEventPianoEvent> Pack(FlatBufferBuilder builder, IClientEventPianoEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientEventPianoEvent>);
			}
			return IClientEventPianoEvent.CreateIClientEventPianoEvent(builder, _o.Type);
		}

		// Token: 0x04011784 RID: 71556
		private Table __p;
	}
}
