using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006675 RID: 26229
	public struct IEnableMoveOperation : IFlatbufferObject
	{
		// Token: 0x1700C2D8 RID: 49880
		// (get) Token: 0x0602D915 RID: 186645 RVA: 0x0063D0B6 File Offset: 0x0063B2B6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D916 RID: 186646 RVA: 0x0063D0C3 File Offset: 0x0063B2C3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D917 RID: 186647 RVA: 0x0063D0CC File Offset: 0x0063B2CC
		public static IEnableMoveOperation GetRootAsIEnableMoveOperation(ByteBuffer _bb)
		{
			return IEnableMoveOperation.GetRootAsIEnableMoveOperation(_bb, default(IEnableMoveOperation));
		}

		// Token: 0x0602D918 RID: 186648 RVA: 0x0063D0E8 File Offset: 0x0063B2E8
		public static IEnableMoveOperation GetRootAsIEnableMoveOperation(ByteBuffer _bb, IEnableMoveOperation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D919 RID: 186649 RVA: 0x0063D105 File Offset: 0x0063B305
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D91A RID: 186650 RVA: 0x0063D114 File Offset: 0x0063B314
		public IEnableMoveOperation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C2D9 RID: 49881
		// (get) Token: 0x0602D91B RID: 186651 RVA: 0x0063D124 File Offset: 0x0063B324
		public EMoveOperationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMoveOperationType.Enable;
				}
				return (EMoveOperationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D91C RID: 186652 RVA: 0x0063D160 File Offset: 0x0063B360
		public static Offset<IEnableMoveOperation> CreateIEnableMoveOperation(FlatBufferBuilder builder, EMoveOperationType Type = EMoveOperationType.Enable)
		{
			builder.StartTable(1);
			IEnableMoveOperation.AddType(builder, Type);
			return IEnableMoveOperation.EndIEnableMoveOperation(builder);
		}

		// Token: 0x0602D91D RID: 186653 RVA: 0x0063D176 File Offset: 0x0063B376
		public static void StartIEnableMoveOperation(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602D91E RID: 186654 RVA: 0x0063D17F File Offset: 0x0063B37F
		public static void AddType(FlatBufferBuilder builder, EMoveOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D91F RID: 186655 RVA: 0x0063D18A File Offset: 0x0063B38A
		public static Offset<IEnableMoveOperation> EndIEnableMoveOperation(FlatBufferBuilder builder)
		{
			return new Offset<IEnableMoveOperation>(builder.EndTable());
		}

		// Token: 0x0602D920 RID: 186656 RVA: 0x0063D198 File Offset: 0x0063B398
		public IEnableMoveOperationT UnPack()
		{
			IEnableMoveOperationT enableMoveOperationT = new IEnableMoveOperationT();
			this.UnPackTo(enableMoveOperationT);
			return enableMoveOperationT;
		}

		// Token: 0x0602D921 RID: 186657 RVA: 0x0063D1B3 File Offset: 0x0063B3B3
		public void UnPackTo(IEnableMoveOperationT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602D922 RID: 186658 RVA: 0x0063D1C4 File Offset: 0x0063B3C4
		public static Offset<IEnableMoveOperation> Pack(FlatBufferBuilder builder, IEnableMoveOperationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnableMoveOperation>);
			}
			return IEnableMoveOperation.CreateIEnableMoveOperation(builder, _o.Type);
		}

		// Token: 0x04010D1D RID: 68893
		private Table __p;
	}
}
