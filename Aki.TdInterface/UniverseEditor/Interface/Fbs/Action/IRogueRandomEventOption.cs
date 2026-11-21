using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007669 RID: 30313
	public struct IRogueRandomEventOption : IFlatbufferObject
	{
		// Token: 0x1700DE88 RID: 56968
		// (get) Token: 0x060352DD RID: 217821 RVA: 0x0072364E File Offset: 0x0072184E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060352DE RID: 217822 RVA: 0x0072365B File Offset: 0x0072185B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060352DF RID: 217823 RVA: 0x00723664 File Offset: 0x00721864
		public static IRogueRandomEventOption GetRootAsIRogueRandomEventOption(ByteBuffer _bb)
		{
			return IRogueRandomEventOption.GetRootAsIRogueRandomEventOption(_bb, default(IRogueRandomEventOption));
		}

		// Token: 0x060352E0 RID: 217824 RVA: 0x00723680 File Offset: 0x00721880
		public static IRogueRandomEventOption GetRootAsIRogueRandomEventOption(ByteBuffer _bb, IRogueRandomEventOption obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060352E1 RID: 217825 RVA: 0x0072369D File Offset: 0x0072189D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060352E2 RID: 217826 RVA: 0x007236AC File Offset: 0x007218AC
		public IRogueRandomEventOption __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DE89 RID: 56969
		// (get) Token: 0x060352E3 RID: 217827 RVA: 0x007236BC File Offset: 0x007218BC
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

		// Token: 0x060352E4 RID: 217828 RVA: 0x007236F8 File Offset: 0x007218F8
		public ISystemOption? SystemOptions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ISystemOption?(default(ISystemOption).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DE8A RID: 56970
		// (get) Token: 0x060352E5 RID: 217829 RVA: 0x00723758 File Offset: 0x00721958
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

		// Token: 0x1700DE8B RID: 56971
		// (get) Token: 0x060352E6 RID: 217830 RVA: 0x00723784 File Offset: 0x00721984
		public bool KeepPreTalkItem
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DE8C RID: 56972
		// (get) Token: 0x060352E7 RID: 217831 RVA: 0x007237C4 File Offset: 0x007219C4
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

		// Token: 0x1700DE8D RID: 56973
		// (get) Token: 0x060352E8 RID: 217832 RVA: 0x00723804 File Offset: 0x00721A04
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

		// Token: 0x060352E9 RID: 217833 RVA: 0x00723841 File Offset: 0x00721A41
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

		// Token: 0x060352EA RID: 217834 RVA: 0x00723875 File Offset: 0x00721A75
		public static void StartIRogueRandomEventOption(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060352EB RID: 217835 RVA: 0x0072387E File Offset: 0x00721A7E
		public static void AddType(FlatBufferBuilder builder, ESystemOptionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060352EC RID: 217836 RVA: 0x00723889 File Offset: 0x00721A89
		public static void AddSystemOptions(FlatBufferBuilder builder, VectorOffset systemOptionsOffset)
		{
			builder.AddOffset(1, systemOptionsOffset.Value, 0);
		}

		// Token: 0x060352ED RID: 217837 RVA: 0x0072389C File Offset: 0x00721A9C
		public static VectorOffset CreateSystemOptionsVector(FlatBufferBuilder builder, Offset<ISystemOption>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060352EE RID: 217838 RVA: 0x007238DC File Offset: 0x00721ADC
		public static VectorOffset CreateSystemOptionsVectorBlock(FlatBufferBuilder builder, Offset<ISystemOption>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISystemOption>>(data);
			return builder.EndVector();
		}

		// Token: 0x060352EF RID: 217839 RVA: 0x007238F6 File Offset: 0x00721AF6
		public static VectorOffset CreateSystemOptionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISystemOption>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISystemOption>>(data);
			return builder.EndVector();
		}

		// Token: 0x060352F0 RID: 217840 RVA: 0x00723914 File Offset: 0x00721B14
		public static VectorOffset CreateSystemOptionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISystemOption>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060352F1 RID: 217841 RVA: 0x0072392D File Offset: 0x00721B2D
		public static void StartSystemOptionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060352F2 RID: 217842 RVA: 0x00723938 File Offset: 0x00721B38
		public static void AddKeepPreTalkItem(FlatBufferBuilder builder, bool keepPreTalkItem)
		{
			builder.AddBool(2, keepPreTalkItem, false);
		}

		// Token: 0x060352F3 RID: 217843 RVA: 0x00723943 File Offset: 0x00721B43
		public static void AddEventId(FlatBufferBuilder builder, int eventId)
		{
			builder.AddInt(3, eventId, 0);
		}

		// Token: 0x060352F4 RID: 217844 RVA: 0x0072394E File Offset: 0x00721B4E
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x060352F5 RID: 217845 RVA: 0x00723959 File Offset: 0x00721B59
		public static Offset<IRogueRandomEventOption> EndIRogueRandomEventOption(FlatBufferBuilder builder)
		{
			return new Offset<IRogueRandomEventOption>(builder.EndTable());
		}

		// Token: 0x060352F6 RID: 217846 RVA: 0x00723968 File Offset: 0x00721B68
		public IRogueRandomEventOptionT UnPack()
		{
			IRogueRandomEventOptionT rogueRandomEventOptionT = new IRogueRandomEventOptionT();
			this.UnPackTo(rogueRandomEventOptionT);
			return rogueRandomEventOptionT;
		}

		// Token: 0x060352F7 RID: 217847 RVA: 0x00723984 File Offset: 0x00721B84
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

		// Token: 0x060352F8 RID: 217848 RVA: 0x00723A14 File Offset: 0x00721C14
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

		// Token: 0x0401285C RID: 75868
		private Table __p;
	}
}
