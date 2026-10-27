using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006394 RID: 25492
	public struct IClientEnableAllPlayerOperation : IFlatbufferObject
	{
		// Token: 0x1700BE16 RID: 48662
		// (get) Token: 0x0602C1AD RID: 180653 RVA: 0x0060EF69 File Offset: 0x0060D169
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C1AE RID: 180654 RVA: 0x0060EF76 File Offset: 0x0060D176
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C1AF RID: 180655 RVA: 0x0060EF80 File Offset: 0x0060D180
		public static IClientEnableAllPlayerOperation GetRootAsIClientEnableAllPlayerOperation(ByteBuffer _bb)
		{
			return IClientEnableAllPlayerOperation.GetRootAsIClientEnableAllPlayerOperation(_bb, default(IClientEnableAllPlayerOperation));
		}

		// Token: 0x0602C1B0 RID: 180656 RVA: 0x0060EF9C File Offset: 0x0060D19C
		public static IClientEnableAllPlayerOperation GetRootAsIClientEnableAllPlayerOperation(ByteBuffer _bb, IClientEnableAllPlayerOperation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C1B1 RID: 180657 RVA: 0x0060EFB9 File Offset: 0x0060D1B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C1B2 RID: 180658 RVA: 0x0060EFC8 File Offset: 0x0060D1C8
		public IClientEnableAllPlayerOperation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BE17 RID: 48663
		// (get) Token: 0x0602C1B3 RID: 180659 RVA: 0x0060EFD8 File Offset: 0x0060D1D8
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

		// Token: 0x0602C1B4 RID: 180660 RVA: 0x0060F014 File Offset: 0x0060D214
		public static Offset<IClientEnableAllPlayerOperation> CreateIClientEnableAllPlayerOperation(FlatBufferBuilder builder, EPlayerOperationType Type = EPlayerOperationType.EnableAll)
		{
			builder.StartTable(1);
			IClientEnableAllPlayerOperation.AddType(builder, Type);
			return IClientEnableAllPlayerOperation.EndIClientEnableAllPlayerOperation(builder);
		}

		// Token: 0x0602C1B5 RID: 180661 RVA: 0x0060F02A File Offset: 0x0060D22A
		public static void StartIClientEnableAllPlayerOperation(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602C1B6 RID: 180662 RVA: 0x0060F033 File Offset: 0x0060D233
		public static void AddType(FlatBufferBuilder builder, EPlayerOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C1B7 RID: 180663 RVA: 0x0060F03E File Offset: 0x0060D23E
		public static Offset<IClientEnableAllPlayerOperation> EndIClientEnableAllPlayerOperation(FlatBufferBuilder builder)
		{
			return new Offset<IClientEnableAllPlayerOperation>(builder.EndTable());
		}

		// Token: 0x0602C1B8 RID: 180664 RVA: 0x0060F04C File Offset: 0x0060D24C
		public IClientEnableAllPlayerOperationT UnPack()
		{
			IClientEnableAllPlayerOperationT clientEnableAllPlayerOperationT = new IClientEnableAllPlayerOperationT();
			this.UnPackTo(clientEnableAllPlayerOperationT);
			return clientEnableAllPlayerOperationT;
		}

		// Token: 0x0602C1B9 RID: 180665 RVA: 0x0060F067 File Offset: 0x0060D267
		public void UnPackTo(IClientEnableAllPlayerOperationT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602C1BA RID: 180666 RVA: 0x0060F078 File Offset: 0x0060D278
		public static Offset<IClientEnableAllPlayerOperation> Pack(FlatBufferBuilder builder, IClientEnableAllPlayerOperationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientEnableAllPlayerOperation>);
			}
			return IClientEnableAllPlayerOperation.CreateIClientEnableAllPlayerOperation(builder, _o.Type);
		}

		// Token: 0x04010964 RID: 67940
		private Table __p;
	}
}
