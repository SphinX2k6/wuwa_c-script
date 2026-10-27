using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006648 RID: 26184
	public struct IEnableAllMotorRadioOperation : IFlatbufferObject
	{
		// Token: 0x1700C28F RID: 49807
		// (get) Token: 0x0602D7B7 RID: 186295 RVA: 0x0063AC10 File Offset: 0x00638E10
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D7B8 RID: 186296 RVA: 0x0063AC1D File Offset: 0x00638E1D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D7B9 RID: 186297 RVA: 0x0063AC24 File Offset: 0x00638E24
		public static IEnableAllMotorRadioOperation GetRootAsIEnableAllMotorRadioOperation(ByteBuffer _bb)
		{
			return IEnableAllMotorRadioOperation.GetRootAsIEnableAllMotorRadioOperation(_bb, default(IEnableAllMotorRadioOperation));
		}

		// Token: 0x0602D7BA RID: 186298 RVA: 0x0063AC40 File Offset: 0x00638E40
		public static IEnableAllMotorRadioOperation GetRootAsIEnableAllMotorRadioOperation(ByteBuffer _bb, IEnableAllMotorRadioOperation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D7BB RID: 186299 RVA: 0x0063AC5D File Offset: 0x00638E5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D7BC RID: 186300 RVA: 0x0063AC6C File Offset: 0x00638E6C
		public IEnableAllMotorRadioOperation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C290 RID: 49808
		// (get) Token: 0x0602D7BD RID: 186301 RVA: 0x0063AC7C File Offset: 0x00638E7C
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

		// Token: 0x0602D7BE RID: 186302 RVA: 0x0063ACB8 File Offset: 0x00638EB8
		public static Offset<IEnableAllMotorRadioOperation> CreateIEnableAllMotorRadioOperation(FlatBufferBuilder builder, EMotorRadioOperationType Type = EMotorRadioOperationType.EnableAll)
		{
			builder.StartTable(1);
			IEnableAllMotorRadioOperation.AddType(builder, Type);
			return IEnableAllMotorRadioOperation.EndIEnableAllMotorRadioOperation(builder);
		}

		// Token: 0x0602D7BF RID: 186303 RVA: 0x0063ACCE File Offset: 0x00638ECE
		public static void StartIEnableAllMotorRadioOperation(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602D7C0 RID: 186304 RVA: 0x0063ACD7 File Offset: 0x00638ED7
		public static void AddType(FlatBufferBuilder builder, EMotorRadioOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D7C1 RID: 186305 RVA: 0x0063ACE2 File Offset: 0x00638EE2
		public static Offset<IEnableAllMotorRadioOperation> EndIEnableAllMotorRadioOperation(FlatBufferBuilder builder)
		{
			return new Offset<IEnableAllMotorRadioOperation>(builder.EndTable());
		}

		// Token: 0x0602D7C2 RID: 186306 RVA: 0x0063ACF0 File Offset: 0x00638EF0
		public IEnableAllMotorRadioOperationT UnPack()
		{
			IEnableAllMotorRadioOperationT enableAllMotorRadioOperationT = new IEnableAllMotorRadioOperationT();
			this.UnPackTo(enableAllMotorRadioOperationT);
			return enableAllMotorRadioOperationT;
		}

		// Token: 0x0602D7C3 RID: 186307 RVA: 0x0063AD0B File Offset: 0x00638F0B
		public void UnPackTo(IEnableAllMotorRadioOperationT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602D7C4 RID: 186308 RVA: 0x0063AD1C File Offset: 0x00638F1C
		public static Offset<IEnableAllMotorRadioOperation> Pack(FlatBufferBuilder builder, IEnableAllMotorRadioOperationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnableAllMotorRadioOperation>);
			}
			return IEnableAllMotorRadioOperation.CreateIEnableAllMotorRadioOperation(builder, _o.Type);
		}

		// Token: 0x04010CE6 RID: 68838
		private Table __p;
	}
}
