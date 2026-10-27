using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200638E RID: 25486
	public struct IClientDisableAllPlayerOperation : IFlatbufferObject
	{
		// Token: 0x1700BE02 RID: 48642
		// (get) Token: 0x0602C156 RID: 180566 RVA: 0x0060DFE4 File Offset: 0x0060C1E4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C157 RID: 180567 RVA: 0x0060DFF1 File Offset: 0x0060C1F1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C158 RID: 180568 RVA: 0x0060DFF8 File Offset: 0x0060C1F8
		public static IClientDisableAllPlayerOperation GetRootAsIClientDisableAllPlayerOperation(ByteBuffer _bb)
		{
			return IClientDisableAllPlayerOperation.GetRootAsIClientDisableAllPlayerOperation(_bb, default(IClientDisableAllPlayerOperation));
		}

		// Token: 0x0602C159 RID: 180569 RVA: 0x0060E014 File Offset: 0x0060C214
		public static IClientDisableAllPlayerOperation GetRootAsIClientDisableAllPlayerOperation(ByteBuffer _bb, IClientDisableAllPlayerOperation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C15A RID: 180570 RVA: 0x0060E031 File Offset: 0x0060C231
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C15B RID: 180571 RVA: 0x0060E040 File Offset: 0x0060C240
		public IClientDisableAllPlayerOperation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BE03 RID: 48643
		// (get) Token: 0x0602C15C RID: 180572 RVA: 0x0060E050 File Offset: 0x0060C250
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

		// Token: 0x1700BE04 RID: 48644
		// (get) Token: 0x0602C15D RID: 180573 RVA: 0x0060E08C File Offset: 0x0060C28C
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

		// Token: 0x1700BE05 RID: 48645
		// (get) Token: 0x0602C15E RID: 180574 RVA: 0x0060E0C8 File Offset: 0x0060C2C8
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

		// Token: 0x0602C15F RID: 180575 RVA: 0x0060E104 File Offset: 0x0060C304
		public static Offset<IClientDisableAllPlayerOperation> CreateIClientDisableAllPlayerOperation(FlatBufferBuilder builder, EPlayerOperationType Type = EPlayerOperationType.EnableAll, EDisplayModeInPlayerOp DisplayMode = EDisplayModeInPlayerOp.ShowUi, byte NullMask = 0)
		{
			builder.StartTable(3);
			IClientDisableAllPlayerOperation.AddNullMask(builder, NullMask);
			IClientDisableAllPlayerOperation.AddDisplayMode(builder, DisplayMode);
			IClientDisableAllPlayerOperation.AddType(builder, Type);
			return IClientDisableAllPlayerOperation.EndIClientDisableAllPlayerOperation(builder);
		}

		// Token: 0x0602C160 RID: 180576 RVA: 0x0060E128 File Offset: 0x0060C328
		public static void StartIClientDisableAllPlayerOperation(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602C161 RID: 180577 RVA: 0x0060E131 File Offset: 0x0060C331
		public static void AddType(FlatBufferBuilder builder, EPlayerOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C162 RID: 180578 RVA: 0x0060E13C File Offset: 0x0060C33C
		public static void AddDisplayMode(FlatBufferBuilder builder, EDisplayModeInPlayerOp displayMode)
		{
			builder.AddByte(1, (byte)displayMode, 0);
		}

		// Token: 0x0602C163 RID: 180579 RVA: 0x0060E147 File Offset: 0x0060C347
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602C164 RID: 180580 RVA: 0x0060E152 File Offset: 0x0060C352
		public static Offset<IClientDisableAllPlayerOperation> EndIClientDisableAllPlayerOperation(FlatBufferBuilder builder)
		{
			return new Offset<IClientDisableAllPlayerOperation>(builder.EndTable());
		}

		// Token: 0x0602C165 RID: 180581 RVA: 0x0060E160 File Offset: 0x0060C360
		public IClientDisableAllPlayerOperationT UnPack()
		{
			IClientDisableAllPlayerOperationT clientDisableAllPlayerOperationT = new IClientDisableAllPlayerOperationT();
			this.UnPackTo(clientDisableAllPlayerOperationT);
			return clientDisableAllPlayerOperationT;
		}

		// Token: 0x0602C166 RID: 180582 RVA: 0x0060E17B File Offset: 0x0060C37B
		public void UnPackTo(IClientDisableAllPlayerOperationT _o)
		{
			_o.Type = this.Type;
			_o.DisplayMode = this.DisplayMode;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602C167 RID: 180583 RVA: 0x0060E1A4 File Offset: 0x0060C3A4
		public static Offset<IClientDisableAllPlayerOperation> Pack(FlatBufferBuilder builder, IClientDisableAllPlayerOperationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientDisableAllPlayerOperation>);
			}
			return IClientDisableAllPlayerOperation.CreateIClientDisableAllPlayerOperation(builder, _o.Type, _o.DisplayMode, _o.NullMask);
		}

		// Token: 0x04010959 RID: 67929
		private Table __p;
	}
}
