using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065F7 RID: 26103
	public struct IDisableUiOperation : IFlatbufferObject
	{
		// Token: 0x1700C1F3 RID: 49651
		// (get) Token: 0x0602D503 RID: 185603 RVA: 0x00635D60 File Offset: 0x00633F60
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D504 RID: 185604 RVA: 0x00635D6D File Offset: 0x00633F6D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D505 RID: 185605 RVA: 0x00635D74 File Offset: 0x00633F74
		public static IDisableUiOperation GetRootAsIDisableUiOperation(ByteBuffer _bb)
		{
			return IDisableUiOperation.GetRootAsIDisableUiOperation(_bb, default(IDisableUiOperation));
		}

		// Token: 0x0602D506 RID: 185606 RVA: 0x00635D90 File Offset: 0x00633F90
		public static IDisableUiOperation GetRootAsIDisableUiOperation(ByteBuffer _bb, IDisableUiOperation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D507 RID: 185607 RVA: 0x00635DAD File Offset: 0x00633FAD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D508 RID: 185608 RVA: 0x00635DBC File Offset: 0x00633FBC
		public IDisableUiOperation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C1F4 RID: 49652
		// (get) Token: 0x0602D509 RID: 185609 RVA: 0x00635DCC File Offset: 0x00633FCC
		public EUiOperationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EUiOperationType.Enable;
				}
				return (EUiOperationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D50A RID: 185610 RVA: 0x00635E08 File Offset: 0x00634008
		public static Offset<IDisableUiOperation> CreateIDisableUiOperation(FlatBufferBuilder builder, EUiOperationType Type = EUiOperationType.Enable)
		{
			builder.StartTable(1);
			IDisableUiOperation.AddType(builder, Type);
			return IDisableUiOperation.EndIDisableUiOperation(builder);
		}

		// Token: 0x0602D50B RID: 185611 RVA: 0x00635E1E File Offset: 0x0063401E
		public static void StartIDisableUiOperation(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602D50C RID: 185612 RVA: 0x00635E27 File Offset: 0x00634027
		public static void AddType(FlatBufferBuilder builder, EUiOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D50D RID: 185613 RVA: 0x00635E32 File Offset: 0x00634032
		public static Offset<IDisableUiOperation> EndIDisableUiOperation(FlatBufferBuilder builder)
		{
			return new Offset<IDisableUiOperation>(builder.EndTable());
		}

		// Token: 0x0602D50E RID: 185614 RVA: 0x00635E40 File Offset: 0x00634040
		public IDisableUiOperationT UnPack()
		{
			IDisableUiOperationT disableUiOperationT = new IDisableUiOperationT();
			this.UnPackTo(disableUiOperationT);
			return disableUiOperationT;
		}

		// Token: 0x0602D50F RID: 185615 RVA: 0x00635E5B File Offset: 0x0063405B
		public void UnPackTo(IDisableUiOperationT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602D510 RID: 185616 RVA: 0x00635E6C File Offset: 0x0063406C
		public static Offset<IDisableUiOperation> Pack(FlatBufferBuilder builder, IDisableUiOperationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDisableUiOperation>);
			}
			return IDisableUiOperation.CreateIDisableUiOperation(builder, _o.Type);
		}

		// Token: 0x04010C7B RID: 68731
		private Table __p;
	}
}
