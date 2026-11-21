using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200678D RID: 26509
	public struct IAddFlowInteractOption : IFlatbufferObject
	{
		// Token: 0x1700C0BC RID: 49340
		// (get) Token: 0x0602CF2E RID: 184110 RVA: 0x00624D95 File Offset: 0x00622F95
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CF2F RID: 184111 RVA: 0x00624DA2 File Offset: 0x00622FA2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CF30 RID: 184112 RVA: 0x00624DAC File Offset: 0x00622FAC
		public static IAddFlowInteractOption GetRootAsIAddFlowInteractOption(ByteBuffer _bb)
		{
			return IAddFlowInteractOption.GetRootAsIAddFlowInteractOption(_bb, default(IAddFlowInteractOption));
		}

		// Token: 0x0602CF31 RID: 184113 RVA: 0x00624DC8 File Offset: 0x00622FC8
		public static IAddFlowInteractOption GetRootAsIAddFlowInteractOption(ByteBuffer _bb, IAddFlowInteractOption obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CF32 RID: 184114 RVA: 0x00624DE5 File Offset: 0x00622FE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CF33 RID: 184115 RVA: 0x00624DF4 File Offset: 0x00622FF4
		public IAddFlowInteractOption __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C0BD RID: 49341
		// (get) Token: 0x0602CF34 RID: 184116 RVA: 0x00624E04 File Offset: 0x00623004
		public IInteractOption? Option
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IInteractOption?(default(IInteractOption).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700C0BE RID: 49342
		// (get) Token: 0x0602CF35 RID: 184117 RVA: 0x00624E64 File Offset: 0x00623064
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

		// Token: 0x1700C0BF RID: 49343
		// (get) Token: 0x0602CF36 RID: 184118 RVA: 0x00624EA0 File Offset: 0x006230A0
		public bool DelayRemoveByQuestEnd
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C0C0 RID: 49344
		// (get) Token: 0x0602CF37 RID: 184119 RVA: 0x00624EE0 File Offset: 0x006230E0
		public string InteractToken
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602CF38 RID: 184120 RVA: 0x00624F18 File Offset: 0x00623118
		public Span<byte> GetInteractTokenBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0602CF39 RID: 184121 RVA: 0x00624F28 File Offset: 0x00623128
		public byte[] GetInteractTokenArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700C0C1 RID: 49345
		// (get) Token: 0x0602CF3A RID: 184122 RVA: 0x00624F38 File Offset: 0x00623138
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

		// Token: 0x0602CF3B RID: 184123 RVA: 0x00624F75 File Offset: 0x00623175
		public static Offset<IAddFlowInteractOption> CreateIAddFlowInteractOption(FlatBufferBuilder builder, Offset<IInteractOption> OptionOffset = default(Offset<IInteractOption>), int EntityId = 0, bool DelayRemoveByQuestEnd = false, StringOffset InteractTokenOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(5);
			IAddFlowInteractOption.AddInteractToken(builder, InteractTokenOffset);
			IAddFlowInteractOption.AddEntityId(builder, EntityId);
			IAddFlowInteractOption.AddOption(builder, OptionOffset);
			IAddFlowInteractOption.AddNullMask(builder, NullMask);
			IAddFlowInteractOption.AddDelayRemoveByQuestEnd(builder, DelayRemoveByQuestEnd);
			return IAddFlowInteractOption.EndIAddFlowInteractOption(builder);
		}

		// Token: 0x0602CF3C RID: 184124 RVA: 0x00624FA9 File Offset: 0x006231A9
		public static void StartIAddFlowInteractOption(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602CF3D RID: 184125 RVA: 0x00624FB2 File Offset: 0x006231B2
		public static void AddOption(FlatBufferBuilder builder, Offset<IInteractOption> optionOffset)
		{
			builder.AddOffset(0, optionOffset.Value, 0);
		}

		// Token: 0x0602CF3E RID: 184126 RVA: 0x00624FC2 File Offset: 0x006231C2
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0602CF3F RID: 184127 RVA: 0x00624FCD File Offset: 0x006231CD
		public static void AddDelayRemoveByQuestEnd(FlatBufferBuilder builder, bool delayRemoveByQuestEnd)
		{
			builder.AddBool(2, delayRemoveByQuestEnd, false);
		}

		// Token: 0x0602CF40 RID: 184128 RVA: 0x00624FD8 File Offset: 0x006231D8
		public static void AddInteractToken(FlatBufferBuilder builder, StringOffset interactTokenOffset)
		{
			builder.AddOffset(3, interactTokenOffset.Value, 0);
		}

		// Token: 0x0602CF41 RID: 184129 RVA: 0x00624FE8 File Offset: 0x006231E8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602CF42 RID: 184130 RVA: 0x00624FF3 File Offset: 0x006231F3
		public static Offset<IAddFlowInteractOption> EndIAddFlowInteractOption(FlatBufferBuilder builder)
		{
			return new Offset<IAddFlowInteractOption>(builder.EndTable());
		}

		// Token: 0x0602CF43 RID: 184131 RVA: 0x00625000 File Offset: 0x00623200
		public IAddFlowInteractOptionT UnPack()
		{
			IAddFlowInteractOptionT addFlowInteractOptionT = new IAddFlowInteractOptionT();
			this.UnPackTo(addFlowInteractOptionT);
			return addFlowInteractOptionT;
		}

		// Token: 0x0602CF44 RID: 184132 RVA: 0x0062501C File Offset: 0x0062321C
		public void UnPackTo(IAddFlowInteractOptionT _o)
		{
			_o.Option = ((this.Option != null) ? this.Option.Value.UnPack() : null);
			_o.EntityId = this.EntityId;
			_o.DelayRemoveByQuestEnd = this.DelayRemoveByQuestEnd;
			_o.InteractToken = this.InteractToken;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602CF45 RID: 184133 RVA: 0x00625088 File Offset: 0x00623288
		public static Offset<IAddFlowInteractOption> Pack(FlatBufferBuilder builder, IAddFlowInteractOptionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAddFlowInteractOption>);
			}
			Offset<IInteractOption> optionOffset = (_o.Option == null) ? default(Offset<IInteractOption>) : IInteractOption.Pack(builder, _o.Option);
			StringOffset interactTokenOffset = (_o.InteractToken == null) ? default(StringOffset) : builder.CreateString(_o.InteractToken);
			return IAddFlowInteractOption.CreateIAddFlowInteractOption(builder, optionOffset, _o.EntityId, _o.DelayRemoveByQuestEnd, interactTokenOffset, _o.NullMask);
		}

		// Token: 0x04011301 RID: 70401
		private Table __p;
	}
}
