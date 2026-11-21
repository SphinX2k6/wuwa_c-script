using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057D8 RID: 22488
	public struct IFixedFill : IFlatbufferObject
	{
		// Token: 0x1700A298 RID: 41624
		// (get) Token: 0x06024509 RID: 148745 RVA: 0x004FD472 File Offset: 0x004FB672
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602450A RID: 148746 RVA: 0x004FD47F File Offset: 0x004FB67F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602450B RID: 148747 RVA: 0x004FD488 File Offset: 0x004FB688
		public static IFixedFill GetRootAsIFixedFill(ByteBuffer _bb)
		{
			return IFixedFill.GetRootAsIFixedFill(_bb, default(IFixedFill));
		}

		// Token: 0x0602450C RID: 148748 RVA: 0x004FD4A4 File Offset: 0x004FB6A4
		public static IFixedFill GetRootAsIFixedFill(ByteBuffer _bb, IFixedFill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602450D RID: 148749 RVA: 0x004FD4C1 File Offset: 0x004FB6C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602450E RID: 148750 RVA: 0x004FD4D0 File Offset: 0x004FB6D0
		public IFixedFill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A299 RID: 41625
		// (get) Token: 0x0602450F RID: 148751 RVA: 0x004FD4E0 File Offset: 0x004FB6E0
		public EFillType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFillType.Fixed;
				}
				return (EFillType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A29A RID: 41626
		// (get) Token: 0x06024510 RID: 148752 RVA: 0x004FD51C File Offset: 0x004FB71C
		public int ModelId
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

		// Token: 0x1700A29B RID: 41627
		// (get) Token: 0x06024511 RID: 148753 RVA: 0x004FD558 File Offset: 0x004FB758
		public IPieceIndex? Centre
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IPieceIndex?(default(IPieceIndex).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A29C RID: 41628
		// (get) Token: 0x06024512 RID: 148754 RVA: 0x004FD5B8 File Offset: 0x004FB7B8
		public IJigsawConfig? Config
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IJigsawConfig?(default(IJigsawConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A29D RID: 41629
		// (get) Token: 0x06024513 RID: 148755 RVA: 0x004FD618 File Offset: 0x004FB818
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

		// Token: 0x06024514 RID: 148756 RVA: 0x004FD655 File Offset: 0x004FB855
		public static Offset<IFixedFill> CreateIFixedFill(FlatBufferBuilder builder, EFillType Type = EFillType.Fixed, int ModelId = 0, Offset<IPieceIndex> CentreOffset = default(Offset<IPieceIndex>), Offset<IJigsawConfig> ConfigOffset = default(Offset<IJigsawConfig>), byte NullMask = 0)
		{
			builder.StartTable(5);
			IFixedFill.AddConfig(builder, ConfigOffset);
			IFixedFill.AddCentre(builder, CentreOffset);
			IFixedFill.AddModelId(builder, ModelId);
			IFixedFill.AddNullMask(builder, NullMask);
			IFixedFill.AddType(builder, Type);
			return IFixedFill.EndIFixedFill(builder);
		}

		// Token: 0x06024515 RID: 148757 RVA: 0x004FD689 File Offset: 0x004FB889
		public static void StartIFixedFill(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06024516 RID: 148758 RVA: 0x004FD692 File Offset: 0x004FB892
		public static void AddType(FlatBufferBuilder builder, EFillType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024517 RID: 148759 RVA: 0x004FD69D File Offset: 0x004FB89D
		public static void AddModelId(FlatBufferBuilder builder, int modelId)
		{
			builder.AddInt(1, modelId, 0);
		}

		// Token: 0x06024518 RID: 148760 RVA: 0x004FD6A8 File Offset: 0x004FB8A8
		public static void AddCentre(FlatBufferBuilder builder, Offset<IPieceIndex> centreOffset)
		{
			builder.AddOffset(2, centreOffset.Value, 0);
		}

		// Token: 0x06024519 RID: 148761 RVA: 0x004FD6B8 File Offset: 0x004FB8B8
		public static void AddConfig(FlatBufferBuilder builder, Offset<IJigsawConfig> configOffset)
		{
			builder.AddOffset(3, configOffset.Value, 0);
		}

		// Token: 0x0602451A RID: 148762 RVA: 0x004FD6C8 File Offset: 0x004FB8C8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602451B RID: 148763 RVA: 0x004FD6D3 File Offset: 0x004FB8D3
		public static Offset<IFixedFill> EndIFixedFill(FlatBufferBuilder builder)
		{
			return new Offset<IFixedFill>(builder.EndTable());
		}

		// Token: 0x0602451C RID: 148764 RVA: 0x004FD6E0 File Offset: 0x004FB8E0
		public IFixedFillT UnPack()
		{
			IFixedFillT fixedFillT = new IFixedFillT();
			this.UnPackTo(fixedFillT);
			return fixedFillT;
		}

		// Token: 0x0602451D RID: 148765 RVA: 0x004FD6FC File Offset: 0x004FB8FC
		public void UnPackTo(IFixedFillT _o)
		{
			_o.Type = this.Type;
			_o.ModelId = this.ModelId;
			_o.Centre = ((this.Centre != null) ? this.Centre.Value.UnPack() : null);
			_o.Config = ((this.Config != null) ? this.Config.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602451E RID: 148766 RVA: 0x004FD78C File Offset: 0x004FB98C
		public static Offset<IFixedFill> Pack(FlatBufferBuilder builder, IFixedFillT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFixedFill>);
			}
			Offset<IPieceIndex> centreOffset = (_o.Centre == null) ? default(Offset<IPieceIndex>) : IPieceIndex.Pack(builder, _o.Centre);
			Offset<IJigsawConfig> configOffset = (_o.Config == null) ? default(Offset<IJigsawConfig>) : IJigsawConfig.Pack(builder, _o.Config);
			return IFixedFill.CreateIFixedFill(builder, _o.Type, _o.ModelId, centreOffset, configOffset, _o.NullMask);
		}

		// Token: 0x0400EFCE RID: 61390
		private Table __p;
	}
}
