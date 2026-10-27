using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065D0 RID: 26064
	public struct IDisableAllMotorRadioOperation : IFlatbufferObject
	{
		// Token: 0x1700C16C RID: 49516
		// (get) Token: 0x0602D338 RID: 185144 RVA: 0x0063233E File Offset: 0x0063053E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D339 RID: 185145 RVA: 0x0063234B File Offset: 0x0063054B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D33A RID: 185146 RVA: 0x00632354 File Offset: 0x00630554
		public static IDisableAllMotorRadioOperation GetRootAsIDisableAllMotorRadioOperation(ByteBuffer _bb)
		{
			return IDisableAllMotorRadioOperation.GetRootAsIDisableAllMotorRadioOperation(_bb, default(IDisableAllMotorRadioOperation));
		}

		// Token: 0x0602D33B RID: 185147 RVA: 0x00632370 File Offset: 0x00630570
		public static IDisableAllMotorRadioOperation GetRootAsIDisableAllMotorRadioOperation(ByteBuffer _bb, IDisableAllMotorRadioOperation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D33C RID: 185148 RVA: 0x0063238D File Offset: 0x0063058D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D33D RID: 185149 RVA: 0x0063239C File Offset: 0x0063059C
		public IDisableAllMotorRadioOperation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C16D RID: 49517
		// (get) Token: 0x0602D33E RID: 185150 RVA: 0x006323AC File Offset: 0x006305AC
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

		// Token: 0x0602D33F RID: 185151 RVA: 0x006323E8 File Offset: 0x006305E8
		public static Offset<IDisableAllMotorRadioOperation> CreateIDisableAllMotorRadioOperation(FlatBufferBuilder builder, EMotorRadioOperationType Type = EMotorRadioOperationType.EnableAll)
		{
			builder.StartTable(1);
			IDisableAllMotorRadioOperation.AddType(builder, Type);
			return IDisableAllMotorRadioOperation.EndIDisableAllMotorRadioOperation(builder);
		}

		// Token: 0x0602D340 RID: 185152 RVA: 0x006323FE File Offset: 0x006305FE
		public static void StartIDisableAllMotorRadioOperation(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602D341 RID: 185153 RVA: 0x00632407 File Offset: 0x00630607
		public static void AddType(FlatBufferBuilder builder, EMotorRadioOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D342 RID: 185154 RVA: 0x00632412 File Offset: 0x00630612
		public static Offset<IDisableAllMotorRadioOperation> EndIDisableAllMotorRadioOperation(FlatBufferBuilder builder)
		{
			return new Offset<IDisableAllMotorRadioOperation>(builder.EndTable());
		}

		// Token: 0x0602D343 RID: 185155 RVA: 0x00632420 File Offset: 0x00630620
		public IDisableAllMotorRadioOperationT UnPack()
		{
			IDisableAllMotorRadioOperationT disableAllMotorRadioOperationT = new IDisableAllMotorRadioOperationT();
			this.UnPackTo(disableAllMotorRadioOperationT);
			return disableAllMotorRadioOperationT;
		}

		// Token: 0x0602D344 RID: 185156 RVA: 0x0063243B File Offset: 0x0063063B
		public void UnPackTo(IDisableAllMotorRadioOperationT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602D345 RID: 185157 RVA: 0x0063244C File Offset: 0x0063064C
		public static Offset<IDisableAllMotorRadioOperation> Pack(FlatBufferBuilder builder, IDisableAllMotorRadioOperationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDisableAllMotorRadioOperation>);
			}
			return IDisableAllMotorRadioOperation.CreateIDisableAllMotorRadioOperation(builder, _o.Type);
		}

		// Token: 0x04010C31 RID: 68657
		private Table __p;
	}
}
