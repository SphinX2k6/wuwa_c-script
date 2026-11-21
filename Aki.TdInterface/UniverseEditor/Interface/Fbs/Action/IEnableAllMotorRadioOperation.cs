using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CB9 RID: 27833
	public struct IEnableAllMotorRadioOperation : IFlatbufferObject
	{
		// Token: 0x1700CC2D RID: 52269
		// (get) Token: 0x0602FF88 RID: 196488 RVA: 0x00687778 File Offset: 0x00685978
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FF89 RID: 196489 RVA: 0x00687785 File Offset: 0x00685985
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FF8A RID: 196490 RVA: 0x0068778C File Offset: 0x0068598C
		public static IEnableAllMotorRadioOperation GetRootAsIEnableAllMotorRadioOperation(ByteBuffer _bb)
		{
			return IEnableAllMotorRadioOperation.GetRootAsIEnableAllMotorRadioOperation(_bb, default(IEnableAllMotorRadioOperation));
		}

		// Token: 0x0602FF8B RID: 196491 RVA: 0x006877A8 File Offset: 0x006859A8
		public static IEnableAllMotorRadioOperation GetRootAsIEnableAllMotorRadioOperation(ByteBuffer _bb, IEnableAllMotorRadioOperation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FF8C RID: 196492 RVA: 0x006877C5 File Offset: 0x006859C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FF8D RID: 196493 RVA: 0x006877D4 File Offset: 0x006859D4
		public IEnableAllMotorRadioOperation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CC2E RID: 52270
		// (get) Token: 0x0602FF8E RID: 196494 RVA: 0x006877E4 File Offset: 0x006859E4
		public EMotorRadioOperationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMotorRadioOperationType.EnableAll;
				}
				return (EMotorRadioOperationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FF8F RID: 196495 RVA: 0x00687820 File Offset: 0x00685A20
		public static Offset<IEnableAllMotorRadioOperation> CreateIEnableAllMotorRadioOperation(FlatBufferBuilder builder, EMotorRadioOperationType Type = EMotorRadioOperationType.EnableAll)
		{
			builder.StartTable(1);
			IEnableAllMotorRadioOperation.AddType(builder, Type);
			return IEnableAllMotorRadioOperation.EndIEnableAllMotorRadioOperation(builder);
		}

		// Token: 0x0602FF90 RID: 196496 RVA: 0x00687836 File Offset: 0x00685A36
		public static void StartIEnableAllMotorRadioOperation(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602FF91 RID: 196497 RVA: 0x0068783F File Offset: 0x00685A3F
		public static void AddType(FlatBufferBuilder builder, EMotorRadioOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FF92 RID: 196498 RVA: 0x0068784A File Offset: 0x00685A4A
		public static Offset<IEnableAllMotorRadioOperation> EndIEnableAllMotorRadioOperation(FlatBufferBuilder builder)
		{
			return new Offset<IEnableAllMotorRadioOperation>(builder.EndTable());
		}

		// Token: 0x0602FF93 RID: 196499 RVA: 0x00687858 File Offset: 0x00685A58
		public IEnableAllMotorRadioOperationT UnPack()
		{
			IEnableAllMotorRadioOperationT enableAllMotorRadioOperationT = new IEnableAllMotorRadioOperationT();
			this.UnPackTo(enableAllMotorRadioOperationT);
			return enableAllMotorRadioOperationT;
		}

		// Token: 0x0602FF94 RID: 196500 RVA: 0x00687873 File Offset: 0x00685A73
		public void UnPackTo(IEnableAllMotorRadioOperationT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602FF95 RID: 196501 RVA: 0x00687884 File Offset: 0x00685A84
		public static Offset<IEnableAllMotorRadioOperation> Pack(FlatBufferBuilder builder, IEnableAllMotorRadioOperationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnableAllMotorRadioOperation>);
			}
			return IEnableAllMotorRadioOperation.CreateIEnableAllMotorRadioOperation(builder, _o.Type);
		}

		// Token: 0x04011B01 RID: 72449
		private Table __p;
	}
}
