using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200711E RID: 28958
	public struct ILiveScOperation : IFlatbufferObject
	{
		// Token: 0x1700D413 RID: 54291
		// (get) Token: 0x060324DF RID: 206047 RVA: 0x006CD42A File Offset: 0x006CB62A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060324E0 RID: 206048 RVA: 0x006CD437 File Offset: 0x006CB637
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060324E1 RID: 206049 RVA: 0x006CD440 File Offset: 0x006CB640
		public static ILiveScOperation GetRootAsILiveScOperation(ByteBuffer _bb)
		{
			return ILiveScOperation.GetRootAsILiveScOperation(_bb, default(ILiveScOperation));
		}

		// Token: 0x060324E2 RID: 206050 RVA: 0x006CD45C File Offset: 0x006CB65C
		public static ILiveScOperation GetRootAsILiveScOperation(ByteBuffer _bb, ILiveScOperation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060324E3 RID: 206051 RVA: 0x006CD479 File Offset: 0x006CB679
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060324E4 RID: 206052 RVA: 0x006CD488 File Offset: 0x006CB688
		public ILiveScOperation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D414 RID: 54292
		// (get) Token: 0x060324E5 RID: 206053 RVA: 0x006CD498 File Offset: 0x006CB698
		public ELiveScOperationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELiveScOperationType.Send;
				}
				return (ELiveScOperationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060324E6 RID: 206054 RVA: 0x006CD4D4 File Offset: 0x006CB6D4
		public static Offset<ILiveScOperation> CreateILiveScOperation(FlatBufferBuilder builder, ELiveScOperationType Type = ELiveScOperationType.Send)
		{
			builder.StartTable(1);
			ILiveScOperation.AddType(builder, Type);
			return ILiveScOperation.EndILiveScOperation(builder);
		}

		// Token: 0x060324E7 RID: 206055 RVA: 0x006CD4EA File Offset: 0x006CB6EA
		public static void StartILiveScOperation(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060324E8 RID: 206056 RVA: 0x006CD4F3 File Offset: 0x006CB6F3
		public static void AddType(FlatBufferBuilder builder, ELiveScOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060324E9 RID: 206057 RVA: 0x006CD4FE File Offset: 0x006CB6FE
		public static Offset<ILiveScOperation> EndILiveScOperation(FlatBufferBuilder builder)
		{
			return new Offset<ILiveScOperation>(builder.EndTable());
		}

		// Token: 0x060324EA RID: 206058 RVA: 0x006CD50C File Offset: 0x006CB70C
		public ILiveScOperationT UnPack()
		{
			ILiveScOperationT liveScOperationT = new ILiveScOperationT();
			this.UnPackTo(liveScOperationT);
			return liveScOperationT;
		}

		// Token: 0x060324EB RID: 206059 RVA: 0x006CD527 File Offset: 0x006CB727
		public void UnPackTo(ILiveScOperationT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060324EC RID: 206060 RVA: 0x006CD538 File Offset: 0x006CB738
		public static Offset<ILiveScOperation> Pack(FlatBufferBuilder builder, ILiveScOperationT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILiveScOperation>);
			}
			return ILiveScOperation.CreateILiveScOperation(builder, _o.Type);
		}

		// Token: 0x04012103 RID: 73987
		private Table __p;
	}
}
