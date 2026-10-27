using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F62 RID: 16226
	public struct IOperation : IFlatbufferObject
	{
		// Token: 0x170070D6 RID: 28886
		// (get) Token: 0x06017148 RID: 94536 RVA: 0x00353A4C File Offset: 0x00351C4C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017149 RID: 94537 RVA: 0x00353A59 File Offset: 0x00351C59
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601714A RID: 94538 RVA: 0x00353A60 File Offset: 0x00351C60
		public static IOperation GetRootAsIOperation(ByteBuffer _bb)
		{
			return IOperation.GetRootAsIOperation(_bb, default(IOperation));
		}

		// Token: 0x0601714B RID: 94539 RVA: 0x00353A7C File Offset: 0x00351C7C
		public static IOperation GetRootAsIOperation(ByteBuffer _bb, IOperation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601714C RID: 94540 RVA: 0x00353A99 File Offset: 0x00351C99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601714D RID: 94541 RVA: 0x00353AA8 File Offset: 0x00351CA8
		public IOperation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170070D7 RID: 28887
		// (get) Token: 0x0601714E RID: 94542 RVA: 0x00353AB8 File Offset: 0x00351CB8
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

		// Token: 0x0601714F RID: 94543 RVA: 0x00353AF4 File Offset: 0x00351CF4
		public static Offset<IOperation> CreateIOperation(FlatBufferBuilder builder, EOperation Type = EOperation.DisableHLOD)
		{
			builder.StartTable(1);
			IOperation.AddType(builder, Type);
			return IOperation.EndIOperation(builder);
		}

		// Token: 0x06017150 RID: 94544 RVA: 0x00353B0A File Offset: 0x00351D0A
		public static void StartIOperation(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06017151 RID: 94545 RVA: 0x00353B13 File Offset: 0x00351D13
		public static void AddType(FlatBufferBuilder builder, EOperation type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017152 RID: 94546 RVA: 0x00353B1E File Offset: 0x00351D1E
		public static Offset<IOperation> EndIOperation(FlatBufferBuilder builder)
		{
			return new Offset<IOperation>(builder.EndTable());
		}

		// Token: 0x06017153 RID: 94547 RVA: 0x00353B2C File Offset: 0x00351D2C
		public IOperationT UnPack()
		{
			IOperationT operationT = new IOperationT();
			this.UnPackTo(operationT);
			return operationT;
		}

		// Token: 0x06017154 RID: 94548 RVA: 0x00353B47 File Offset: 0x00351D47
		public void UnPackTo(IOperationT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06017155 RID: 94549 RVA: 0x00353B58 File Offset: 0x00351D58
		public static Offset<IOperation> Pack(FlatBufferBuilder builder, IOperationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOperation>);
			}
			return IOperation.CreateIOperation(builder, _o.Type);
		}

		// Token: 0x0400B978 RID: 47480
		private Table __p;
	}
}
