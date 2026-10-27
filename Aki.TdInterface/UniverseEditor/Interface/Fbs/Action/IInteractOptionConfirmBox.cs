using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006996 RID: 27030
	public struct IInteractOptionConfirmBox : IFlatbufferObject
	{
		// Token: 0x1700C888 RID: 51336
		// (get) Token: 0x0602F38C RID: 193420 RVA: 0x0066EB9F File Offset: 0x0066CD9F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F38D RID: 193421 RVA: 0x0066EBAC File Offset: 0x0066CDAC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F38E RID: 193422 RVA: 0x0066EBB4 File Offset: 0x0066CDB4
		public static IInteractOptionConfirmBox GetRootAsIInteractOptionConfirmBox(ByteBuffer _bb)
		{
			return IInteractOptionConfirmBox.GetRootAsIInteractOptionConfirmBox(_bb, default(IInteractOptionConfirmBox));
		}

		// Token: 0x0602F38F RID: 193423 RVA: 0x0066EBD0 File Offset: 0x0066CDD0
		public static IInteractOptionConfirmBox GetRootAsIInteractOptionConfirmBox(ByteBuffer _bb, IInteractOptionConfirmBox obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F390 RID: 193424 RVA: 0x0066EBED File Offset: 0x0066CDED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F391 RID: 193425 RVA: 0x0066EBFC File Offset: 0x0066CDFC
		public IInteractOptionConfirmBox __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C889 RID: 51337
		// (get) Token: 0x0602F392 RID: 193426 RVA: 0x0066EC0C File Offset: 0x0066CE0C
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

		// Token: 0x0602F393 RID: 193427 RVA: 0x0066EC48 File Offset: 0x0066CE48
		public TTable? Type<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602F394 RID: 193428 RVA: 0x0066EC8C File Offset: 0x0066CE8C
		public ICommonConfirmBox TypeAsICommonConfirmBox()
		{
			return this.Type<ICommonConfirmBox>().Value;
		}

		// Token: 0x0602F395 RID: 193429 RVA: 0x0066ECA8 File Offset: 0x0066CEA8
		public IHonamiStoryCorruptedChestConfirmBox TypeAsIHonamiStoryCorruptedChestConfirmBox()
		{
			return this.Type<IHonamiStoryCorruptedChestConfirmBox>().Value;
		}

		// Token: 0x0602F396 RID: 193430 RVA: 0x0066ECC4 File Offset: 0x0066CEC4
		public IHonamiStoryEvacuateConfirmBox TypeAsIHonamiStoryEvacuateConfirmBox()
		{
			return this.Type<IHonamiStoryEvacuateConfirmBox>().Value;
		}

		// Token: 0x0602F397 RID: 193431 RVA: 0x0066ECDF File Offset: 0x0066CEDF
		public static Offset<IInteractOptionConfirmBox> CreateIInteractOptionConfirmBox(FlatBufferBuilder builder, TInteractOptionConfirmBoxOption Type_type = TInteractOptionConfirmBoxOption.NONE, int TypeOffset = 0)
		{
			builder.StartTable(2);
			IInteractOptionConfirmBox.AddType(builder, TypeOffset);
			IInteractOptionConfirmBox.AddTypeType(builder, Type_type);
			return IInteractOptionConfirmBox.EndIInteractOptionConfirmBox(builder);
		}

		// Token: 0x0602F398 RID: 193432 RVA: 0x0066ECFC File Offset: 0x0066CEFC
		public static void StartIInteractOptionConfirmBox(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602F399 RID: 193433 RVA: 0x0066ED05 File Offset: 0x0066CF05
		public static void AddTypeType(FlatBufferBuilder builder, TInteractOptionConfirmBoxOption typeType)
		{
			builder.AddByte(0, (byte)typeType, 0);
		}

		// Token: 0x0602F39A RID: 193434 RVA: 0x0066ED10 File Offset: 0x0066CF10
		public static void AddType(FlatBufferBuilder builder, int typeOffset)
		{
			builder.AddOffset(1, typeOffset, 0);
		}

		// Token: 0x0602F39B RID: 193435 RVA: 0x0066ED1B File Offset: 0x0066CF1B
		public static Offset<IInteractOptionConfirmBox> EndIInteractOptionConfirmBox(FlatBufferBuilder builder)
		{
			return new Offset<IInteractOptionConfirmBox>(builder.EndTable());
		}

		// Token: 0x0602F39C RID: 193436 RVA: 0x0066ED28 File Offset: 0x0066CF28
		public IInteractOptionConfirmBoxT UnPack()
		{
			IInteractOptionConfirmBoxT interactOptionConfirmBoxT = new IInteractOptionConfirmBoxT();
			this.UnPackTo(interactOptionConfirmBoxT);
			return interactOptionConfirmBoxT;
		}

		// Token: 0x0602F39D RID: 193437 RVA: 0x0066ED44 File Offset: 0x0066CF44
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

		// Token: 0x0602F39E RID: 193438 RVA: 0x0066EE2C File Offset: 0x0066D02C
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

		// Token: 0x04011136 RID: 69942
		private Table __p;
	}
}
