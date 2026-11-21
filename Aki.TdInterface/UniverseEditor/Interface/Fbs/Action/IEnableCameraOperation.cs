using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CC2 RID: 27842
	public struct IEnableCameraOperation : IFlatbufferObject
	{
		// Token: 0x1700CC3A RID: 52282
		// (get) Token: 0x0602FFC6 RID: 196550 RVA: 0x00687CF9 File Offset: 0x00685EF9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FFC7 RID: 196551 RVA: 0x00687D06 File Offset: 0x00685F06
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FFC8 RID: 196552 RVA: 0x00687D10 File Offset: 0x00685F10
		public static IEnableCameraOperation GetRootAsIEnableCameraOperation(ByteBuffer _bb)
		{
			return IEnableCameraOperation.GetRootAsIEnableCameraOperation(_bb, default(IEnableCameraOperation));
		}

		// Token: 0x0602FFC9 RID: 196553 RVA: 0x00687D2C File Offset: 0x00685F2C
		public static IEnableCameraOperation GetRootAsIEnableCameraOperation(ByteBuffer _bb, IEnableCameraOperation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FFCA RID: 196554 RVA: 0x00687D49 File Offset: 0x00685F49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FFCB RID: 196555 RVA: 0x00687D58 File Offset: 0x00685F58
		public IEnableCameraOperation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CC3B RID: 52283
		// (get) Token: 0x0602FFCC RID: 196556 RVA: 0x00687D68 File Offset: 0x00685F68
		public ECameraOperationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECameraOperationType.Enable;
				}
				return (ECameraOperationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FFCD RID: 196557 RVA: 0x00687DA4 File Offset: 0x00685FA4
		public static Offset<IEnableCameraOperation> CreateIEnableCameraOperation(FlatBufferBuilder builder, ECameraOperationType Type = ECameraOperationType.Enable)
		{
			builder.StartTable(1);
			IEnableCameraOperation.AddType(builder, Type);
			return IEnableCameraOperation.EndIEnableCameraOperation(builder);
		}

		// Token: 0x0602FFCE RID: 196558 RVA: 0x00687DBA File Offset: 0x00685FBA
		public static void StartIEnableCameraOperation(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602FFCF RID: 196559 RVA: 0x00687DC3 File Offset: 0x00685FC3
		public static void AddType(FlatBufferBuilder builder, ECameraOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FFD0 RID: 196560 RVA: 0x00687DCE File Offset: 0x00685FCE
		public static Offset<IEnableCameraOperation> EndIEnableCameraOperation(FlatBufferBuilder builder)
		{
			return new Offset<IEnableCameraOperation>(builder.EndTable());
		}

		// Token: 0x0602FFD1 RID: 196561 RVA: 0x00687DDC File Offset: 0x00685FDC
		public IEnableCameraOperationT UnPack()
		{
			IEnableCameraOperationT enableCameraOperationT = new IEnableCameraOperationT();
			this.UnPackTo(enableCameraOperationT);
			return enableCameraOperationT;
		}

		// Token: 0x0602FFD2 RID: 196562 RVA: 0x00687DF7 File Offset: 0x00685FF7
		public void UnPackTo(IEnableCameraOperationT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602FFD3 RID: 196563 RVA: 0x00687E08 File Offset: 0x00686008
		public static Offset<IEnableCameraOperation> Pack(FlatBufferBuilder builder, IEnableCameraOperationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnableCameraOperation>);
			}
			return IEnableCameraOperation.CreateIEnableCameraOperation(builder, _o.Type);
		}

		// Token: 0x04011B09 RID: 72457
		private Table __p;
	}
}
