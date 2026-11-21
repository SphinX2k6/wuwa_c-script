using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043A0 RID: 17312
	public struct IOperation : IFlatbufferObject
	{
		// Token: 0x170076C7 RID: 30407
		// (get) Token: 0x060187AA RID: 100266 RVA: 0x0037CEC0 File Offset: 0x0037B0C0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060187AB RID: 100267 RVA: 0x0037CECD File Offset: 0x0037B0CD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060187AC RID: 100268 RVA: 0x0037CED4 File Offset: 0x0037B0D4
		public static IOperation GetRootAsIOperation(ByteBuffer _bb)
		{
			return IOperation.GetRootAsIOperation(_bb, default(IOperation));
		}

		// Token: 0x060187AD RID: 100269 RVA: 0x0037CEF0 File Offset: 0x0037B0F0
		public static IOperation GetRootAsIOperation(ByteBuffer _bb, IOperation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060187AE RID: 100270 RVA: 0x0037CF0D File Offset: 0x0037B10D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060187AF RID: 100271 RVA: 0x0037CF1C File Offset: 0x0037B11C
		public IOperation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170076C8 RID: 30408
		// (get) Token: 0x060187B0 RID: 100272 RVA: 0x0037CF2C File Offset: 0x0037B12C
		public EOperation Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EOperation.DisableHLOD;
				}
				return (EOperation)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060187B1 RID: 100273 RVA: 0x0037CF68 File Offset: 0x0037B168
		public static Offset<IOperation> CreateIOperation(FlatBufferBuilder builder, EOperation Type = EOperation.DisableHLOD)
		{
			builder.StartTable(1);
			IOperation.AddType(builder, Type);
			return IOperation.EndIOperation(builder);
		}

		// Token: 0x060187B2 RID: 100274 RVA: 0x0037CF7E File Offset: 0x0037B17E
		public static void StartIOperation(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060187B3 RID: 100275 RVA: 0x0037CF87 File Offset: 0x0037B187
		public static void AddType(FlatBufferBuilder builder, EOperation type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060187B4 RID: 100276 RVA: 0x0037CF92 File Offset: 0x0037B192
		public static Offset<IOperation> EndIOperation(FlatBufferBuilder builder)
		{
			return new Offset<IOperation>(builder.EndTable());
		}

		// Token: 0x060187B5 RID: 100277 RVA: 0x0037CFA0 File Offset: 0x0037B1A0
		public IOperationT UnPack()
		{
			IOperationT operationT = new IOperationT();
			this.UnPackTo(operationT);
			return operationT;
		}

		// Token: 0x060187B6 RID: 100278 RVA: 0x0037CFBB File Offset: 0x0037B1BB
		public void UnPackTo(IOperationT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060187B7 RID: 100279 RVA: 0x0037CFCC File Offset: 0x0037B1CC
		public static Offset<IOperation> Pack(FlatBufferBuilder builder, IOperationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOperation>);
			}
			return IOperation.CreateIOperation(builder, _o.Type);
		}

		// Token: 0x0400C356 RID: 50006
		private Table __p;
	}
}
