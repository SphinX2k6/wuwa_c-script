using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069FF RID: 27135
	public struct IClientDisableAllPlayerOperation : IFlatbufferObject
	{
		// Token: 0x1700C786 RID: 51078
		// (get) Token: 0x0602E8B8 RID: 190648 RVA: 0x00659019 File Offset: 0x00657219
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E8B9 RID: 190649 RVA: 0x00659026 File Offset: 0x00657226
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E8BA RID: 190650 RVA: 0x00659030 File Offset: 0x00657230
		public static IClientDisableAllPlayerOperation GetRootAsIClientDisableAllPlayerOperation(ByteBuffer _bb)
		{
			return IClientDisableAllPlayerOperation.GetRootAsIClientDisableAllPlayerOperation(_bb, default(IClientDisableAllPlayerOperation));
		}

		// Token: 0x0602E8BB RID: 190651 RVA: 0x0065904C File Offset: 0x0065724C
		public static IClientDisableAllPlayerOperation GetRootAsIClientDisableAllPlayerOperation(ByteBuffer _bb, IClientDisableAllPlayerOperation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E8BC RID: 190652 RVA: 0x00659069 File Offset: 0x00657269
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E8BD RID: 190653 RVA: 0x00659078 File Offset: 0x00657278
		public IClientDisableAllPlayerOperation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C787 RID: 51079
		// (get) Token: 0x0602E8BE RID: 190654 RVA: 0x00659088 File Offset: 0x00657288
		public EPlayerOperationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPlayerOperationType.EnableAll;
				}
				return (EPlayerOperationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C788 RID: 51080
		// (get) Token: 0x0602E8BF RID: 190655 RVA: 0x006590C4 File Offset: 0x006572C4
		public EDisplayModeInPlayerOp DisplayMode
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EDisplayModeInPlayerOp.ShowUi;
				}
				return (EDisplayModeInPlayerOp)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C789 RID: 51081
		// (get) Token: 0x0602E8C0 RID: 190656 RVA: 0x00659100 File Offset: 0x00657300
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E8C1 RID: 190657 RVA: 0x0065913C File Offset: 0x0065733C
		public static Offset<IClientDisableAllPlayerOperation> CreateIClientDisableAllPlayerOperation(FlatBufferBuilder builder, EPlayerOperationType Type = EPlayerOperationType.EnableAll, EDisplayModeInPlayerOp DisplayMode = EDisplayModeInPlayerOp.ShowUi, byte NullMask = 0)
		{
			builder.StartTable(3);
			IClientDisableAllPlayerOperation.AddNullMask(builder, NullMask);
			IClientDisableAllPlayerOperation.AddDisplayMode(builder, DisplayMode);
			IClientDisableAllPlayerOperation.AddType(builder, Type);
			return IClientDisableAllPlayerOperation.EndIClientDisableAllPlayerOperation(builder);
		}

		// Token: 0x0602E8C2 RID: 190658 RVA: 0x00659160 File Offset: 0x00657360
		public static void StartIClientDisableAllPlayerOperation(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602E8C3 RID: 190659 RVA: 0x00659169 File Offset: 0x00657369
		public static void AddType(FlatBufferBuilder builder, EPlayerOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E8C4 RID: 190660 RVA: 0x00659174 File Offset: 0x00657374
		public static void AddDisplayMode(FlatBufferBuilder builder, EDisplayModeInPlayerOp displayMode)
		{
			builder.AddByte(1, (byte)displayMode, 0);
		}

		// Token: 0x0602E8C5 RID: 190661 RVA: 0x0065917F File Offset: 0x0065737F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602E8C6 RID: 190662 RVA: 0x0065918A File Offset: 0x0065738A
		public static Offset<IClientDisableAllPlayerOperation> EndIClientDisableAllPlayerOperation(FlatBufferBuilder builder)
		{
			return new Offset<IClientDisableAllPlayerOperation>(builder.EndTable());
		}

		// Token: 0x0602E8C7 RID: 190663 RVA: 0x00659198 File Offset: 0x00657398
		public IClientDisableAllPlayerOperationT UnPack()
		{
			IClientDisableAllPlayerOperationT clientDisableAllPlayerOperationT = new IClientDisableAllPlayerOperationT();
			this.UnPackTo(clientDisableAllPlayerOperationT);
			return clientDisableAllPlayerOperationT;
		}

		// Token: 0x0602E8C8 RID: 190664 RVA: 0x006591B3 File Offset: 0x006573B3
		public void UnPackTo(IClientDisableAllPlayerOperationT _o)
		{
			_o.Type = this.Type;
			_o.DisplayMode = this.DisplayMode;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602E8C9 RID: 190665 RVA: 0x006591DC File Offset: 0x006573DC
		public static Offset<IClientDisableAllPlayerOperation> Pack(FlatBufferBuilder builder, IClientDisableAllPlayerOperationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientDisableAllPlayerOperation>);
			}
			return IClientDisableAllPlayerOperation.CreateIClientDisableAllPlayerOperation(builder, _o.Type, _o.DisplayMode, _o.NullMask);
		}

		// Token: 0x0401176C RID: 71532
		private Table __p;
	}
}
