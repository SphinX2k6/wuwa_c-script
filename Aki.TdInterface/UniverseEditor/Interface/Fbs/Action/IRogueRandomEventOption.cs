using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EE5 RID: 28389
	public struct IRogueRandomEventOption : IFlatbufferObject
	{
		// Token: 0x1700D331 RID: 54065
		// (get) Token: 0x0603229D RID: 205469 RVA: 0x006C791A File Offset: 0x006C5B1A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603229E RID: 205470 RVA: 0x006C7927 File Offset: 0x006C5B27
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603229F RID: 205471 RVA: 0x006C7930 File Offset: 0x006C5B30
		public static IRogueRandomEventOption GetRootAsIRogueRandomEventOption(ByteBuffer _bb)
		{
			return IRogueRandomEventOption.GetRootAsIRogueRandomEventOption(_bb, default(IRogueRandomEventOption));
		}

		// Token: 0x060322A0 RID: 205472 RVA: 0x006C794C File Offset: 0x006C5B4C
		public static IRogueRandomEventOption GetRootAsIRogueRandomEventOption(ByteBuffer _bb, IRogueRandomEventOption obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060322A1 RID: 205473 RVA: 0x006C7969 File Offset: 0x006C5B69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060322A2 RID: 205474 RVA: 0x006C7978 File Offset: 0x006C5B78
		public IRogueRandomEventOption __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D332 RID: 54066
		// (get) Token: 0x060322A3 RID: 205475 RVA: 0x006C7988 File Offset: 0x006C5B88
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

		// Token: 0x060322A4 RID: 205476 RVA: 0x006C79C4 File Offset: 0x006C5BC4
		public ISystemOption? SystemOptions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ISystemOption?(default(ISystemOption).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700D333 RID: 54067
		// (get) Token: 0x060322A5 RID: 205477 RVA: 0x006C7A24 File Offset: 0x006C5C24
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

		// Token: 0x1700D334 RID: 54068
		// (get) Token: 0x060322A6 RID: 205478 RVA: 0x006C7A50 File Offset: 0x006C5C50
		public bool KeepPreTalkItem
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D335 RID: 54069
		// (get) Token: 0x060322A7 RID: 205479 RVA: 0x006C7A90 File Offset: 0x006C5C90
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

		// Token: 0x1700D336 RID: 54070
		// (get) Token: 0x060322A8 RID: 205480 RVA: 0x006C7AD0 File Offset: 0x006C5CD0
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

		// Token: 0x060322A9 RID: 205481 RVA: 0x006C7B0D File Offset: 0x006C5D0D
		public static Offset<IRogueRandomEventOption> CreateIRogueRandomEventOption(FlatBufferBuilder builder, ESystemOptionType Type = ESystemOptionType.RogueRandomEvent, VectorOffset SystemOptionsOffset = default(VectorOffset), bool KeepPreTalkItem = false, int EventId = 0, byte NullMask = 0)
		{
			builder.StartTable(5);
			IRogueRandomEventOption.AddEventId(builder, EventId);
			IRogueRandomEventOption.AddSystemOptions(builder, SystemOptionsOffset);
			IRogueRandomEventOption.AddNullMask(builder, NullMask);
			IRogueRandomEventOption.AddKeepPreTalkItem(builder, KeepPreTalkItem);
			IRogueRandomEventOption.AddType(builder, Type);
			return IRogueRandomEventOption.EndIRogueRandomEventOption(builder);
		}

		// Token: 0x060322AA RID: 205482 RVA: 0x006C7B41 File Offset: 0x006C5D41
		public static void StartIRogueRandomEventOption(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060322AB RID: 205483 RVA: 0x006C7B4A File Offset: 0x006C5D4A
		public static void AddType(FlatBufferBuilder builder, ESystemOptionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060322AC RID: 205484 RVA: 0x006C7B55 File Offset: 0x006C5D55
		public static void AddSystemOptions(FlatBufferBuilder builder, VectorOffset systemOptionsOffset)
		{
			builder.AddOffset(1, systemOptionsOffset.Value, 0);
		}

		// Token: 0x060322AD RID: 205485 RVA: 0x006C7B68 File Offset: 0x006C5D68
		public static VectorOffset CreateSystemOptionsVector(FlatBufferBuilder builder, Offset<ISystemOption>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060322AE RID: 205486 RVA: 0x006C7BA8 File Offset: 0x006C5DA8
		public static VectorOffset CreateSystemOptionsVectorBlock(FlatBufferBuilder builder, Offset<ISystemOption>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISystemOption>>(data);
			return builder.EndVector();
		}

		// Token: 0x060322AF RID: 205487 RVA: 0x006C7BC2 File Offset: 0x006C5DC2
		public static VectorOffset CreateSystemOptionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISystemOption>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISystemOption>>(data);
			return builder.EndVector();
		}

		// Token: 0x060322B0 RID: 205488 RVA: 0x006C7BE0 File Offset: 0x006C5DE0
		public static VectorOffset CreateSystemOptionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISystemOption>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060322B1 RID: 205489 RVA: 0x006C7BF9 File Offset: 0x006C5DF9
		public static void StartSystemOptionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060322B2 RID: 205490 RVA: 0x006C7C04 File Offset: 0x006C5E04
		public static void AddKeepPreTalkItem(FlatBufferBuilder builder, bool keepPreTalkItem)
		{
			builder.AddBool(2, keepPreTalkItem, false);
		}

		// Token: 0x060322B3 RID: 205491 RVA: 0x006C7C0F File Offset: 0x006C5E0F
		public static void AddEventId(FlatBufferBuilder builder, int eventId)
		{
			builder.AddInt(3, eventId, 0);
		}

		// Token: 0x060322B4 RID: 205492 RVA: 0x006C7C1A File Offset: 0x006C5E1A
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x060322B5 RID: 205493 RVA: 0x006C7C25 File Offset: 0x006C5E25
		public static Offset<IRogueRandomEventOption> EndIRogueRandomEventOption(FlatBufferBuilder builder)
		{
			return new Offset<IRogueRandomEventOption>(builder.EndTable());
		}

		// Token: 0x060322B6 RID: 205494 RVA: 0x006C7C34 File Offset: 0x006C5E34
		public IRogueRandomEventOptionT UnPack()
		{
			IRogueRandomEventOptionT rogueRandomEventOptionT = new IRogueRandomEventOptionT();
			this.UnPackTo(rogueRandomEventOptionT);
			return rogueRandomEventOptionT;
		}

		// Token: 0x060322B7 RID: 205495 RVA: 0x006C7C50 File Offset: 0x006C5E50
		public void UnPackTo(IRogueRandomEventOptionT _o)
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

		// Token: 0x060322B8 RID: 205496 RVA: 0x006C7CE0 File Offset: 0x006C5EE0
		public static Offset<IRogueRandomEventOption> Pack(FlatBufferBuilder builder, IRogueRandomEventOptionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRogueRandomEventOption>);
			}
			VectorOffset systemOptionsOffset = default(VectorOffset);
			if (_o.SystemOptions != null)
			{
				Offset<ISystemOption>[] array = new Offset<ISystemOption>[_o.SystemOptions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ISystemOption.Pack(builder, _o.SystemOptions[i]);
				}
				systemOptionsOffset = IRogueRandomEventOption.CreateSystemOptionsVector(builder, array);
			}
			return IRogueRandomEventOption.CreateIRogueRandomEventOption(builder, _o.Type, systemOptionsOffset, _o.KeepPreTalkItem, _o.EventId, _o.NullMask);
		}

		// Token: 0x040118D7 RID: 71895
		private Table __p;
	}
}
