using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005270 RID: 21104
	public struct IFixedFill : IFlatbufferObject
	{
		// Token: 0x17009A9C RID: 39580
		// (get) Token: 0x06022573 RID: 140659 RVA: 0x004C29AE File Offset: 0x004C0BAE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022574 RID: 140660 RVA: 0x004C29BB File Offset: 0x004C0BBB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022575 RID: 140661 RVA: 0x004C29C4 File Offset: 0x004C0BC4
		public static IFixedFill GetRootAsIFixedFill(ByteBuffer _bb)
		{
			return IFixedFill.GetRootAsIFixedFill(_bb, default(IFixedFill));
		}

		// Token: 0x06022576 RID: 140662 RVA: 0x004C29E0 File Offset: 0x004C0BE0
		public static IFixedFill GetRootAsIFixedFill(ByteBuffer _bb, IFixedFill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022577 RID: 140663 RVA: 0x004C29FD File Offset: 0x004C0BFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022578 RID: 140664 RVA: 0x004C2A0C File Offset: 0x004C0C0C
		public IFixedFill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009A9D RID: 39581
		// (get) Token: 0x06022579 RID: 140665 RVA: 0x004C2A1C File Offset: 0x004C0C1C
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

		// Token: 0x17009A9E RID: 39582
		// (get) Token: 0x0602257A RID: 140666 RVA: 0x004C2A58 File Offset: 0x004C0C58
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

		// Token: 0x17009A9F RID: 39583
		// (get) Token: 0x0602257B RID: 140667 RVA: 0x004C2A94 File Offset: 0x004C0C94
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

		// Token: 0x17009AA0 RID: 39584
		// (get) Token: 0x0602257C RID: 140668 RVA: 0x004C2AF4 File Offset: 0x004C0CF4
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

		// Token: 0x17009AA1 RID: 39585
		// (get) Token: 0x0602257D RID: 140669 RVA: 0x004C2B54 File Offset: 0x004C0D54
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

		// Token: 0x0602257E RID: 140670 RVA: 0x004C2B91 File Offset: 0x004C0D91
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

		// Token: 0x0602257F RID: 140671 RVA: 0x004C2BC5 File Offset: 0x004C0DC5
		public static void StartIFixedFill(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06022580 RID: 140672 RVA: 0x004C2BCE File Offset: 0x004C0DCE
		public static void AddType(FlatBufferBuilder builder, EFillType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022581 RID: 140673 RVA: 0x004C2BD9 File Offset: 0x004C0DD9
		public static void AddModelId(FlatBufferBuilder builder, int modelId)
		{
			builder.AddInt(1, modelId, 0);
		}

		// Token: 0x06022582 RID: 140674 RVA: 0x004C2BE4 File Offset: 0x004C0DE4
		public static void AddCentre(FlatBufferBuilder builder, Offset<IPieceIndex> centreOffset)
		{
			builder.AddOffset(2, centreOffset.Value, 0);
		}

		// Token: 0x06022583 RID: 140675 RVA: 0x004C2BF4 File Offset: 0x004C0DF4
		public static void AddConfig(FlatBufferBuilder builder, Offset<IJigsawConfig> configOffset)
		{
			builder.AddOffset(3, configOffset.Value, 0);
		}

		// Token: 0x06022584 RID: 140676 RVA: 0x004C2C04 File Offset: 0x004C0E04
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06022585 RID: 140677 RVA: 0x004C2C0F File Offset: 0x004C0E0F
		public static Offset<IFixedFill> EndIFixedFill(FlatBufferBuilder builder)
		{
			return new Offset<IFixedFill>(builder.EndTable());
		}

		// Token: 0x06022586 RID: 140678 RVA: 0x004C2C1C File Offset: 0x004C0E1C
		public IFixedFillT UnPack()
		{
			IFixedFillT fixedFillT = new IFixedFillT();
			this.UnPackTo(fixedFillT);
			return fixedFillT;
		}

		// Token: 0x06022587 RID: 140679 RVA: 0x004C2C38 File Offset: 0x004C0E38
		public void UnPackTo(IFixedFillT _o)
		{
			_o.Type = this.Type;
			_o.ModelId = this.ModelId;
			_o.Centre = ((this.Centre != null) ? this.Centre.Value.UnPack() : null);
			_o.Config = ((this.Config != null) ? this.Config.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06022588 RID: 140680 RVA: 0x004C2CC8 File Offset: 0x004C0EC8
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

		// Token: 0x0400E3C8 RID: 58312
		private Table __p;
	}
}
