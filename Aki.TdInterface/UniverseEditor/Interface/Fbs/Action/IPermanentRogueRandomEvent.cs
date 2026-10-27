using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C96 RID: 27798
	public struct IPermanentRogueRandomEvent : IFlatbufferObject
	{
		// Token: 0x1700CEFE RID: 52990
		// (get) Token: 0x06030FC1 RID: 200641 RVA: 0x006A66AA File Offset: 0x006A48AA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030FC2 RID: 200642 RVA: 0x006A66B7 File Offset: 0x006A48B7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030FC3 RID: 200643 RVA: 0x006A66C0 File Offset: 0x006A48C0
		public static IPermanentRogueRandomEvent GetRootAsIPermanentRogueRandomEvent(ByteBuffer _bb)
		{
			return IPermanentRogueRandomEvent.GetRootAsIPermanentRogueRandomEvent(_bb, default(IPermanentRogueRandomEvent));
		}

		// Token: 0x06030FC4 RID: 200644 RVA: 0x006A66DC File Offset: 0x006A48DC
		public static IPermanentRogueRandomEvent GetRootAsIPermanentRogueRandomEvent(ByteBuffer _bb, IPermanentRogueRandomEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030FC5 RID: 200645 RVA: 0x006A66F9 File Offset: 0x006A48F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030FC6 RID: 200646 RVA: 0x006A6708 File Offset: 0x006A4908
		public IPermanentRogueRandomEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CEFF RID: 52991
		// (get) Token: 0x06030FC7 RID: 200647 RVA: 0x006A6718 File Offset: 0x006A4918
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

		// Token: 0x06030FC8 RID: 200648 RVA: 0x006A6754 File Offset: 0x006A4954
		public ISystemOption? SystemOptions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ISystemOption?(default(ISystemOption).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700CF00 RID: 52992
		// (get) Token: 0x06030FC9 RID: 200649 RVA: 0x006A67B4 File Offset: 0x006A49B4
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

		// Token: 0x1700CF01 RID: 52993
		// (get) Token: 0x06030FCA RID: 200650 RVA: 0x006A67E0 File Offset: 0x006A49E0
		public bool KeepPreTalkItem
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CF02 RID: 52994
		// (get) Token: 0x06030FCB RID: 200651 RVA: 0x006A6820 File Offset: 0x006A4A20
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

		// Token: 0x1700CF03 RID: 52995
		// (get) Token: 0x06030FCC RID: 200652 RVA: 0x006A6860 File Offset: 0x006A4A60
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

		// Token: 0x06030FCD RID: 200653 RVA: 0x006A689D File Offset: 0x006A4A9D
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

		// Token: 0x06030FCE RID: 200654 RVA: 0x006A68D1 File Offset: 0x006A4AD1
		public static void StartIPermanentRogueRandomEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06030FCF RID: 200655 RVA: 0x006A68DA File Offset: 0x006A4ADA
		public static void AddType(FlatBufferBuilder builder, ESystemOptionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030FD0 RID: 200656 RVA: 0x006A68E5 File Offset: 0x006A4AE5
		public static void AddSystemOptions(FlatBufferBuilder builder, VectorOffset systemOptionsOffset)
		{
			builder.AddOffset(1, systemOptionsOffset.Value, 0);
		}

		// Token: 0x06030FD1 RID: 200657 RVA: 0x006A68F8 File Offset: 0x006A4AF8
		public static VectorOffset CreateSystemOptionsVector(FlatBufferBuilder builder, Offset<ISystemOption>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06030FD2 RID: 200658 RVA: 0x006A6938 File Offset: 0x006A4B38
		public static VectorOffset CreateSystemOptionsVectorBlock(FlatBufferBuilder builder, Offset<ISystemOption>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISystemOption>>(data);
			return builder.EndVector();
		}

		// Token: 0x06030FD3 RID: 200659 RVA: 0x006A6952 File Offset: 0x006A4B52
		public static VectorOffset CreateSystemOptionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISystemOption>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISystemOption>>(data);
			return builder.EndVector();
		}

		// Token: 0x06030FD4 RID: 200660 RVA: 0x006A6970 File Offset: 0x006A4B70
		public static VectorOffset CreateSystemOptionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISystemOption>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06030FD5 RID: 200661 RVA: 0x006A6989 File Offset: 0x006A4B89
		public static void StartSystemOptionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06030FD6 RID: 200662 RVA: 0x006A6994 File Offset: 0x006A4B94
		public static void AddKeepPreTalkItem(FlatBufferBuilder builder, bool keepPreTalkItem)
		{
			builder.AddBool(2, keepPreTalkItem, false);
		}

		// Token: 0x06030FD7 RID: 200663 RVA: 0x006A699F File Offset: 0x006A4B9F
		public static void AddEventId(FlatBufferBuilder builder, int eventId)
		{
			builder.AddInt(3, eventId, 0);
		}

		// Token: 0x06030FD8 RID: 200664 RVA: 0x006A69AA File Offset: 0x006A4BAA
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06030FD9 RID: 200665 RVA: 0x006A69B5 File Offset: 0x006A4BB5
		public static Offset<IPermanentRogueRandomEvent> EndIPermanentRogueRandomEvent(FlatBufferBuilder builder)
		{
			return new Offset<IPermanentRogueRandomEvent>(builder.EndTable());
		}

		// Token: 0x06030FDA RID: 200666 RVA: 0x006A69C4 File Offset: 0x006A4BC4
		public IPermanentRogueRandomEventT UnPack()
		{
			IPermanentRogueRandomEventT permanentRogueRandomEventT = new IPermanentRogueRandomEventT();
			this.UnPackTo(permanentRogueRandomEventT);
			return permanentRogueRandomEventT;
		}

		// Token: 0x06030FDB RID: 200667 RVA: 0x006A69E0 File Offset: 0x006A4BE0
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

		// Token: 0x06030FDC RID: 200668 RVA: 0x006A6A70 File Offset: 0x006A4C70
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

		// Token: 0x040115EA RID: 71146
		private Table __p;
	}
}
