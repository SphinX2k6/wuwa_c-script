using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073FD RID: 29693
	public struct IPermanentRogueRandomEvent : IFlatbufferObject
	{
		// Token: 0x1700DA19 RID: 55833
		// (get) Token: 0x06033F1C RID: 212764 RVA: 0x00700BAA File Offset: 0x006FEDAA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033F1D RID: 212765 RVA: 0x00700BB7 File Offset: 0x006FEDB7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033F1E RID: 212766 RVA: 0x00700BC0 File Offset: 0x006FEDC0
		public static IPermanentRogueRandomEvent GetRootAsIPermanentRogueRandomEvent(ByteBuffer _bb)
		{
			return IPermanentRogueRandomEvent.GetRootAsIPermanentRogueRandomEvent(_bb, default(IPermanentRogueRandomEvent));
		}

		// Token: 0x06033F1F RID: 212767 RVA: 0x00700BDC File Offset: 0x006FEDDC
		public static IPermanentRogueRandomEvent GetRootAsIPermanentRogueRandomEvent(ByteBuffer _bb, IPermanentRogueRandomEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033F20 RID: 212768 RVA: 0x00700BF9 File Offset: 0x006FEDF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033F21 RID: 212769 RVA: 0x00700C08 File Offset: 0x006FEE08
		public IPermanentRogueRandomEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DA1A RID: 55834
		// (get) Token: 0x06033F22 RID: 212770 RVA: 0x00700C18 File Offset: 0x006FEE18
		public ESystemOptionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESystemOptionType.RogueRandomEvent;
				}
				return (ESystemOptionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033F23 RID: 212771 RVA: 0x00700C54 File Offset: 0x006FEE54
		public ISystemOption? SystemOptions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ISystemOption?(default(ISystemOption).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DA1B RID: 55835
		// (get) Token: 0x06033F24 RID: 212772 RVA: 0x00700CB4 File Offset: 0x006FEEB4
		public int SystemOptionsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700DA1C RID: 55836
		// (get) Token: 0x06033F25 RID: 212773 RVA: 0x00700CE0 File Offset: 0x006FEEE0
		public bool KeepPreTalkItem
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DA1D RID: 55837
		// (get) Token: 0x06033F26 RID: 212774 RVA: 0x00700D20 File Offset: 0x006FEF20
		public int EventId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DA1E RID: 55838
		// (get) Token: 0x06033F27 RID: 212775 RVA: 0x00700D60 File Offset: 0x006FEF60
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

		// Token: 0x06033F28 RID: 212776 RVA: 0x00700D9D File Offset: 0x006FEF9D
		public static Offset<IPermanentRogueRandomEvent> CreateIPermanentRogueRandomEvent(FlatBufferBuilder builder, ESystemOptionType Type = ESystemOptionType.RogueRandomEvent, VectorOffset SystemOptionsOffset = default(VectorOffset), bool KeepPreTalkItem = false, int EventId = 0, byte NullMask = 0)
		{
			builder.StartTable(5);
			IPermanentRogueRandomEvent.AddEventId(builder, EventId);
			IPermanentRogueRandomEvent.AddSystemOptions(builder, SystemOptionsOffset);
			IPermanentRogueRandomEvent.AddNullMask(builder, NullMask);
			IPermanentRogueRandomEvent.AddKeepPreTalkItem(builder, KeepPreTalkItem);
			IPermanentRogueRandomEvent.AddType(builder, Type);
			return IPermanentRogueRandomEvent.EndIPermanentRogueRandomEvent(builder);
		}

		// Token: 0x06033F29 RID: 212777 RVA: 0x00700DD1 File Offset: 0x006FEFD1
		public static void StartIPermanentRogueRandomEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06033F2A RID: 212778 RVA: 0x00700DDA File Offset: 0x006FEFDA
		public static void AddType(FlatBufferBuilder builder, ESystemOptionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033F2B RID: 212779 RVA: 0x00700DE5 File Offset: 0x006FEFE5
		public static void AddSystemOptions(FlatBufferBuilder builder, VectorOffset systemOptionsOffset)
		{
			builder.AddOffset(1, systemOptionsOffset.Value, 0);
		}

		// Token: 0x06033F2C RID: 212780 RVA: 0x00700DF8 File Offset: 0x006FEFF8
		public static VectorOffset CreateSystemOptionsVector(FlatBufferBuilder builder, Offset<ISystemOption>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06033F2D RID: 212781 RVA: 0x00700E38 File Offset: 0x006FF038
		public static VectorOffset CreateSystemOptionsVectorBlock(FlatBufferBuilder builder, Offset<ISystemOption>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISystemOption>>(data);
			return builder.EndVector();
		}

		// Token: 0x06033F2E RID: 212782 RVA: 0x00700E52 File Offset: 0x006FF052
		public static VectorOffset CreateSystemOptionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISystemOption>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISystemOption>>(data);
			return builder.EndVector();
		}

		// Token: 0x06033F2F RID: 212783 RVA: 0x00700E70 File Offset: 0x006FF070
		public static VectorOffset CreateSystemOptionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISystemOption>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06033F30 RID: 212784 RVA: 0x00700E89 File Offset: 0x006FF089
		public static void StartSystemOptionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06033F31 RID: 212785 RVA: 0x00700E94 File Offset: 0x006FF094
		public static void AddKeepPreTalkItem(FlatBufferBuilder builder, bool keepPreTalkItem)
		{
			builder.AddBool(2, keepPreTalkItem, false);
		}

		// Token: 0x06033F32 RID: 212786 RVA: 0x00700E9F File Offset: 0x006FF09F
		public static void AddEventId(FlatBufferBuilder builder, int eventId)
		{
			builder.AddInt(3, eventId, 0);
		}

		// Token: 0x06033F33 RID: 212787 RVA: 0x00700EAA File Offset: 0x006FF0AA
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06033F34 RID: 212788 RVA: 0x00700EB5 File Offset: 0x006FF0B5
		public static Offset<IPermanentRogueRandomEvent> EndIPermanentRogueRandomEvent(FlatBufferBuilder builder)
		{
			return new Offset<IPermanentRogueRandomEvent>(builder.EndTable());
		}

		// Token: 0x06033F35 RID: 212789 RVA: 0x00700EC4 File Offset: 0x006FF0C4
		public IPermanentRogueRandomEventT UnPack()
		{
			IPermanentRogueRandomEventT permanentRogueRandomEventT = new IPermanentRogueRandomEventT();
			this.UnPackTo(permanentRogueRandomEventT);
			return permanentRogueRandomEventT;
		}

		// Token: 0x06033F36 RID: 212790 RVA: 0x00700EE0 File Offset: 0x006FF0E0
		public void UnPackTo(IPermanentRogueRandomEventT _o)
		{
			_o.Type = this.Type;
			_o.SystemOptions = new List<ISystemOptionT>();
			for (int i = 0; i < this.SystemOptionsLength; i++)
			{
				_o.SystemOptions.Add((this.SystemOptions(i) != null) ? this.SystemOptions(i).Value.UnPack() : null);
			}
			_o.KeepPreTalkItem = this.KeepPreTalkItem;
			_o.EventId = this.EventId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06033F37 RID: 212791 RVA: 0x00700F70 File Offset: 0x006FF170
		public static Offset<IPermanentRogueRandomEvent> Pack(FlatBufferBuilder builder, IPermanentRogueRandomEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPermanentRogueRandomEvent>);
			}
			VectorOffset systemOptionsOffset = default(VectorOffset);
			if (_o.SystemOptions != null)
			{
				Offset<ISystemOption>[] array = new Offset<ISystemOption>[_o.SystemOptions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ISystemOption.Pack(builder, _o.SystemOptions[i]);
				}
				systemOptionsOffset = IPermanentRogueRandomEvent.CreateSystemOptionsVector(builder, array);
			}
			return IPermanentRogueRandomEvent.CreateIPermanentRogueRandomEvent(builder, _o.Type, systemOptionsOffset, _o.KeepPreTalkItem, _o.EventId, _o.NullMask);
		}

		// Token: 0x04012542 RID: 75074
		private Table __p;
	}
}
