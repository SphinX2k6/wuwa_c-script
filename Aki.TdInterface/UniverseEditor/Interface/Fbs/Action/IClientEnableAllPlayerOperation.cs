using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A05 RID: 27141
	public struct IClientEnableAllPlayerOperation : IFlatbufferObject
	{
		// Token: 0x1700C79A RID: 51098
		// (get) Token: 0x0602E90F RID: 190735 RVA: 0x00659FA1 File Offset: 0x006581A1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E910 RID: 190736 RVA: 0x00659FAE File Offset: 0x006581AE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E911 RID: 190737 RVA: 0x00659FB8 File Offset: 0x006581B8
		public static IClientEnableAllPlayerOperation GetRootAsIClientEnableAllPlayerOperation(ByteBuffer _bb)
		{
			return IClientEnableAllPlayerOperation.GetRootAsIClientEnableAllPlayerOperation(_bb, default(IClientEnableAllPlayerOperation));
		}

		// Token: 0x0602E912 RID: 190738 RVA: 0x00659FD4 File Offset: 0x006581D4
		public static IClientEnableAllPlayerOperation GetRootAsIClientEnableAllPlayerOperation(ByteBuffer _bb, IClientEnableAllPlayerOperation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E913 RID: 190739 RVA: 0x00659FF1 File Offset: 0x006581F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E914 RID: 190740 RVA: 0x0065A000 File Offset: 0x00658200
		public IClientEnableAllPlayerOperation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C79B RID: 51099
		// (get) Token: 0x0602E915 RID: 190741 RVA: 0x0065A010 File Offset: 0x00658210
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

		// Token: 0x0602E916 RID: 190742 RVA: 0x0065A04C File Offset: 0x0065824C
		public static Offset<IClientEnableAllPlayerOperation> CreateIClientEnableAllPlayerOperation(FlatBufferBuilder builder, EPlayerOperationType Type = EPlayerOperationType.EnableAll)
		{
			builder.StartTable(1);
			IClientEnableAllPlayerOperation.AddType(builder, Type);
			return IClientEnableAllPlayerOperation.EndIClientEnableAllPlayerOperation(builder);
		}

		// Token: 0x0602E917 RID: 190743 RVA: 0x0065A062 File Offset: 0x00658262
		public static void StartIClientEnableAllPlayerOperation(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602E918 RID: 190744 RVA: 0x0065A06B File Offset: 0x0065826B
		public static void AddType(FlatBufferBuilder builder, EPlayerOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E919 RID: 190745 RVA: 0x0065A076 File Offset: 0x00658276
		public static Offset<IClientEnableAllPlayerOperation> EndIClientEnableAllPlayerOperation(FlatBufferBuilder builder)
		{
			return new Offset<IClientEnableAllPlayerOperation>(builder.EndTable());
		}

		// Token: 0x0602E91A RID: 190746 RVA: 0x0065A084 File Offset: 0x00658284
		public IClientEnableAllPlayerOperationT UnPack()
		{
			IClientEnableAllPlayerOperationT clientEnableAllPlayerOperationT = new IClientEnableAllPlayerOperationT();
			this.UnPackTo(clientEnableAllPlayerOperationT);
			return clientEnableAllPlayerOperationT;
		}

		// Token: 0x0602E91B RID: 190747 RVA: 0x0065A09F File Offset: 0x0065829F
		public void UnPackTo(IClientEnableAllPlayerOperationT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602E91C RID: 190748 RVA: 0x0065A0B0 File Offset: 0x006582B0
		public static Offset<IClientEnableAllPlayerOperation> Pack(FlatBufferBuilder builder, IClientEnableAllPlayerOperationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientEnableAllPlayerOperation>);
			}
			return IClientEnableAllPlayerOperation.CreateIClientEnableAllPlayerOperation(builder, _o.Type);
		}

		// Token: 0x04011777 RID: 71543
		private Table __p;
	}
}
