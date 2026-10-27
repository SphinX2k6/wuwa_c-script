using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006651 RID: 26193
	public struct IEnableCameraOperation : IFlatbufferObject
	{
		// Token: 0x1700C29C RID: 49820
		// (get) Token: 0x0602D7F5 RID: 186357 RVA: 0x0063B191 File Offset: 0x00639391
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D7F6 RID: 186358 RVA: 0x0063B19E File Offset: 0x0063939E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D7F7 RID: 186359 RVA: 0x0063B1A8 File Offset: 0x006393A8
		public static IEnableCameraOperation GetRootAsIEnableCameraOperation(ByteBuffer _bb)
		{
			return IEnableCameraOperation.GetRootAsIEnableCameraOperation(_bb, default(IEnableCameraOperation));
		}

		// Token: 0x0602D7F8 RID: 186360 RVA: 0x0063B1C4 File Offset: 0x006393C4
		public static IEnableCameraOperation GetRootAsIEnableCameraOperation(ByteBuffer _bb, IEnableCameraOperation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D7F9 RID: 186361 RVA: 0x0063B1E1 File Offset: 0x006393E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D7FA RID: 186362 RVA: 0x0063B1F0 File Offset: 0x006393F0
		public IEnableCameraOperation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C29D RID: 49821
		// (get) Token: 0x0602D7FB RID: 186363 RVA: 0x0063B200 File Offset: 0x00639400
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

		// Token: 0x0602D7FC RID: 186364 RVA: 0x0063B23C File Offset: 0x0063943C
		public static Offset<IEnableCameraOperation> CreateIEnableCameraOperation(FlatBufferBuilder builder, ECameraOperationType Type = ECameraOperationType.Enable)
		{
			builder.StartTable(1);
			IEnableCameraOperation.AddType(builder, Type);
			return IEnableCameraOperation.EndIEnableCameraOperation(builder);
		}

		// Token: 0x0602D7FD RID: 186365 RVA: 0x0063B252 File Offset: 0x00639452
		public static void StartIEnableCameraOperation(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602D7FE RID: 186366 RVA: 0x0063B25B File Offset: 0x0063945B
		public static void AddType(FlatBufferBuilder builder, ECameraOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D7FF RID: 186367 RVA: 0x0063B266 File Offset: 0x00639466
		public static Offset<IEnableCameraOperation> EndIEnableCameraOperation(FlatBufferBuilder builder)
		{
			return new Offset<IEnableCameraOperation>(builder.EndTable());
		}

		// Token: 0x0602D800 RID: 186368 RVA: 0x0063B274 File Offset: 0x00639474
		public IEnableCameraOperationT UnPack()
		{
			IEnableCameraOperationT enableCameraOperationT = new IEnableCameraOperationT();
			this.UnPackTo(enableCameraOperationT);
			return enableCameraOperationT;
		}

		// Token: 0x0602D801 RID: 186369 RVA: 0x0063B28F File Offset: 0x0063948F
		public void UnPackTo(IEnableCameraOperationT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602D802 RID: 186370 RVA: 0x0063B2A0 File Offset: 0x006394A0
		public static Offset<IEnableCameraOperation> Pack(FlatBufferBuilder builder, IEnableCameraOperationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnableCameraOperation>);
			}
			return IEnableCameraOperation.CreateIEnableCameraOperation(builder, _o.Type);
		}

		// Token: 0x04010CEE RID: 68846
		private Table __p;
	}
}
