using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007049 RID: 28745
	public struct IInteractOptionConfirmBox : IFlatbufferObject
	{
		// Token: 0x1700D28D RID: 53901
		// (get) Token: 0x06031D68 RID: 204136 RVA: 0x006BF2A1 File Offset: 0x006BD4A1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031D69 RID: 204137 RVA: 0x006BF2AE File Offset: 0x006BD4AE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031D6A RID: 204138 RVA: 0x006BF2B8 File Offset: 0x006BD4B8
		public static IInteractOptionConfirmBox GetRootAsIInteractOptionConfirmBox(ByteBuffer _bb)
		{
			return IInteractOptionConfirmBox.GetRootAsIInteractOptionConfirmBox(_bb, default(IInteractOptionConfirmBox));
		}

		// Token: 0x06031D6B RID: 204139 RVA: 0x006BF2D4 File Offset: 0x006BD4D4
		public static IInteractOptionConfirmBox GetRootAsIInteractOptionConfirmBox(ByteBuffer _bb, IInteractOptionConfirmBox obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031D6C RID: 204140 RVA: 0x006BF2F1 File Offset: 0x006BD4F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031D6D RID: 204141 RVA: 0x006BF300 File Offset: 0x006BD500
		public IInteractOptionConfirmBox __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D28E RID: 53902
		// (get) Token: 0x06031D6E RID: 204142 RVA: 0x006BF310 File Offset: 0x006BD510
		public TInteractOptionConfirmBoxOption TypeType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TInteractOptionConfirmBoxOption.NONE;
				}
				return (TInteractOptionConfirmBoxOption)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031D6F RID: 204143 RVA: 0x006BF34C File Offset: 0x006BD54C
		public TTable? Type<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06031D70 RID: 204144 RVA: 0x006BF390 File Offset: 0x006BD590
		public ICommonConfirmBox TypeAsICommonConfirmBox()
		{
			return this.Type<ICommonConfirmBox>().Value;
		}

		// Token: 0x06031D71 RID: 204145 RVA: 0x006BF3AC File Offset: 0x006BD5AC
		public IHonamiStoryCorruptedChestConfirmBox TypeAsIHonamiStoryCorruptedChestConfirmBox()
		{
			return this.Type<IHonamiStoryCorruptedChestConfirmBox>().Value;
		}

		// Token: 0x06031D72 RID: 204146 RVA: 0x006BF3C8 File Offset: 0x006BD5C8
		public IHonamiStoryEvacuateConfirmBox TypeAsIHonamiStoryEvacuateConfirmBox()
		{
			return this.Type<IHonamiStoryEvacuateConfirmBox>().Value;
		}

		// Token: 0x06031D73 RID: 204147 RVA: 0x006BF3E3 File Offset: 0x006BD5E3
		public static Offset<IInteractOptionConfirmBox> CreateIInteractOptionConfirmBox(FlatBufferBuilder builder, TInteractOptionConfirmBoxOption Type_type = TInteractOptionConfirmBoxOption.NONE, int TypeOffset = 0)
		{
			builder.StartTable(2);
			IInteractOptionConfirmBox.AddType(builder, TypeOffset);
			IInteractOptionConfirmBox.AddTypeType(builder, Type_type);
			return IInteractOptionConfirmBox.EndIInteractOptionConfirmBox(builder);
		}

		// Token: 0x06031D74 RID: 204148 RVA: 0x006BF400 File Offset: 0x006BD600
		public static void StartIInteractOptionConfirmBox(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031D75 RID: 204149 RVA: 0x006BF409 File Offset: 0x006BD609
		public static void AddTypeType(FlatBufferBuilder builder, TInteractOptionConfirmBoxOption typeType)
		{
			builder.AddByte(0, (byte)typeType, 0);
		}

		// Token: 0x06031D76 RID: 204150 RVA: 0x006BF414 File Offset: 0x006BD614
		public static void AddType(FlatBufferBuilder builder, int typeOffset)
		{
			builder.AddOffset(1, typeOffset, 0);
		}

		// Token: 0x06031D77 RID: 204151 RVA: 0x006BF41F File Offset: 0x006BD61F
		public static Offset<IInteractOptionConfirmBox> EndIInteractOptionConfirmBox(FlatBufferBuilder builder)
		{
			return new Offset<IInteractOptionConfirmBox>(builder.EndTable());
		}

		// Token: 0x06031D78 RID: 204152 RVA: 0x006BF42C File Offset: 0x006BD62C
		public IInteractOptionConfirmBoxT UnPack()
		{
			IInteractOptionConfirmBoxT interactOptionConfirmBoxT = new IInteractOptionConfirmBoxT();
			this.UnPackTo(interactOptionConfirmBoxT);
			return interactOptionConfirmBoxT;
		}

		// Token: 0x06031D79 RID: 204153 RVA: 0x006BF448 File Offset: 0x006BD648
		public void UnPackTo(IInteractOptionConfirmBoxT _o)
		{
			_o.Type = new TInteractOptionConfirmBoxOptionUnion();
			_o.Type.Type = this.TypeType;
			switch (this.TypeType)
			{
			case TInteractOptionConfirmBoxOption.ICommonConfirmBox:
				_o.Type.Value = ((this.Type<ICommonConfirmBox>() != null) ? this.Type<ICommonConfirmBox>().Value.UnPack() : null);
				return;
			case TInteractOptionConfirmBoxOption.IHonamiStoryCorruptedChestConfirmBox:
				_o.Type.Value = ((this.Type<IHonamiStoryCorruptedChestConfirmBox>() != null) ? this.Type<IHonamiStoryCorruptedChestConfirmBox>().Value.UnPack() : null);
				return;
			case TInteractOptionConfirmBoxOption.IHonamiStoryEvacuateConfirmBox:
				_o.Type.Value = ((this.Type<IHonamiStoryEvacuateConfirmBox>() != null) ? this.Type<IHonamiStoryEvacuateConfirmBox>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06031D7A RID: 204154 RVA: 0x006BF530 File Offset: 0x006BD730
		public static Offset<IInteractOptionConfirmBox> Pack(FlatBufferBuilder builder, IInteractOptionConfirmBoxT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInteractOptionConfirmBox>);
			}
			TInteractOptionConfirmBoxOption type_type = (_o.Type == null) ? TInteractOptionConfirmBoxOption.NONE : _o.Type.Type;
			int typeOffset = (_o.Type == null) ? 0 : TInteractOptionConfirmBoxOptionUnion.Pack(builder, _o.Type);
			return IInteractOptionConfirmBox.CreateIInteractOptionConfirmBox(builder, type_type, typeOffset);
		}

		// Token: 0x04011FA3 RID: 73635
		private Table __p;
	}
}
