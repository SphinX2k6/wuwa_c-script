using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C41 RID: 27713
	public struct IDisableCameraOperation : IFlatbufferObject
	{
		// Token: 0x1700CB10 RID: 51984
		// (get) Token: 0x0602FB0A RID: 195338 RVA: 0x0067ED3F File Offset: 0x0067CF3F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FB0B RID: 195339 RVA: 0x0067ED4C File Offset: 0x0067CF4C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FB0C RID: 195340 RVA: 0x0067ED54 File Offset: 0x0067CF54
		public static IDisableCameraOperation GetRootAsIDisableCameraOperation(ByteBuffer _bb)
		{
			return IDisableCameraOperation.GetRootAsIDisableCameraOperation(_bb, default(IDisableCameraOperation));
		}

		// Token: 0x0602FB0D RID: 195341 RVA: 0x0067ED70 File Offset: 0x0067CF70
		public static IDisableCameraOperation GetRootAsIDisableCameraOperation(ByteBuffer _bb, IDisableCameraOperation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FB0E RID: 195342 RVA: 0x0067ED8D File Offset: 0x0067CF8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FB0F RID: 195343 RVA: 0x0067ED9C File Offset: 0x0067CF9C
		public IDisableCameraOperation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CB11 RID: 51985
		// (get) Token: 0x0602FB10 RID: 195344 RVA: 0x0067EDAC File Offset: 0x0067CFAC
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

		// Token: 0x0602FB11 RID: 195345 RVA: 0x0067EDE8 File Offset: 0x0067CFE8
		public static Offset<IDisableCameraOperation> CreateIDisableCameraOperation(FlatBufferBuilder builder, ECameraOperationType Type = ECameraOperationType.Enable)
		{
			builder.StartTable(1);
			IDisableCameraOperation.AddType(builder, Type);
			return IDisableCameraOperation.EndIDisableCameraOperation(builder);
		}

		// Token: 0x0602FB12 RID: 195346 RVA: 0x0067EDFE File Offset: 0x0067CFFE
		public static void StartIDisableCameraOperation(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602FB13 RID: 195347 RVA: 0x0067EE07 File Offset: 0x0067D007
		public static void AddType(FlatBufferBuilder builder, ECameraOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FB14 RID: 195348 RVA: 0x0067EE12 File Offset: 0x0067D012
		public static Offset<IDisableCameraOperation> EndIDisableCameraOperation(FlatBufferBuilder builder)
		{
			return new Offset<IDisableCameraOperation>(builder.EndTable());
		}

		// Token: 0x0602FB15 RID: 195349 RVA: 0x0067EE20 File Offset: 0x0067D020
		public IDisableCameraOperationT UnPack()
		{
			IDisableCameraOperationT disableCameraOperationT = new IDisableCameraOperationT();
			this.UnPackTo(disableCameraOperationT);
			return disableCameraOperationT;
		}

		// Token: 0x0602FB16 RID: 195350 RVA: 0x0067EE3B File Offset: 0x0067D03B
		public void UnPackTo(IDisableCameraOperationT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602FB17 RID: 195351 RVA: 0x0067EE4C File Offset: 0x0067D04C
		public static Offset<IDisableCameraOperation> Pack(FlatBufferBuilder builder, IDisableCameraOperationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDisableCameraOperation>);
			}
			return IDisableCameraOperation.CreateIDisableCameraOperation(builder, _o.Type);
		}

		// Token: 0x04011A4F RID: 72271
		private Table __p;
	}
}
