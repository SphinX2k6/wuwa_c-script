using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200458A RID: 17802
	public struct IRollBlockHintStepOperation : IFlatbufferObject
	{
		// Token: 0x17007E7B RID: 32379
		// (get) Token: 0x0601AE3D RID: 110141 RVA: 0x003D65F4 File Offset: 0x003D47F4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601AE3E RID: 110142 RVA: 0x003D6601 File Offset: 0x003D4801
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601AE3F RID: 110143 RVA: 0x003D6608 File Offset: 0x003D4808
		public static IRollBlockHintStepOperation GetRootAsIRollBlockHintStepOperation(ByteBuffer _bb)
		{
			return IRollBlockHintStepOperation.GetRootAsIRollBlockHintStepOperation(_bb, default(IRollBlockHintStepOperation));
		}

		// Token: 0x0601AE40 RID: 110144 RVA: 0x003D6624 File Offset: 0x003D4824
		public static IRollBlockHintStepOperation GetRootAsIRollBlockHintStepOperation(ByteBuffer _bb, IRollBlockHintStepOperation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601AE41 RID: 110145 RVA: 0x003D6641 File Offset: 0x003D4841
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601AE42 RID: 110146 RVA: 0x003D6650 File Offset: 0x003D4850
		public IRollBlockHintStepOperation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007E7C RID: 32380
		// (get) Token: 0x0601AE43 RID: 110147 RVA: 0x003D6660 File Offset: 0x003D4860
		public ERollBlockHintStepType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERollBlockHintStepType.Roll;
				}
				return (ERollBlockHintStepType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601AE44 RID: 110148 RVA: 0x003D669C File Offset: 0x003D489C
		public static Offset<IRollBlockHintStepOperation> CreateIRollBlockHintStepOperation(FlatBufferBuilder builder, ERollBlockHintStepType Type = ERollBlockHintStepType.Roll)
		{
			builder.StartTable(1);
			IRollBlockHintStepOperation.AddType(builder, Type);
			return IRollBlockHintStepOperation.EndIRollBlockHintStepOperation(builder);
		}

		// Token: 0x0601AE45 RID: 110149 RVA: 0x003D66B2 File Offset: 0x003D48B2
		public static void StartIRollBlockHintStepOperation(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601AE46 RID: 110150 RVA: 0x003D66BB File Offset: 0x003D48BB
		public static void AddType(FlatBufferBuilder builder, ERollBlockHintStepType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601AE47 RID: 110151 RVA: 0x003D66C6 File Offset: 0x003D48C6
		public static Offset<IRollBlockHintStepOperation> EndIRollBlockHintStepOperation(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockHintStepOperation>(builder.EndTable());
		}

		// Token: 0x0601AE48 RID: 110152 RVA: 0x003D66D4 File Offset: 0x003D48D4
		public IRollBlockHintStepOperationT UnPack()
		{
			IRollBlockHintStepOperationT rollBlockHintStepOperationT = new IRollBlockHintStepOperationT();
			this.UnPackTo(rollBlockHintStepOperationT);
			return rollBlockHintStepOperationT;
		}

		// Token: 0x0601AE49 RID: 110153 RVA: 0x003D66EF File Offset: 0x003D48EF
		public void UnPackTo(IRollBlockHintStepOperationT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601AE4A RID: 110154 RVA: 0x003D6700 File Offset: 0x003D4900
		public static Offset<IRollBlockHintStepOperation> Pack(FlatBufferBuilder builder, IRollBlockHintStepOperationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRollBlockHintStepOperation>);
			}
			return IRollBlockHintStepOperation.CreateIRollBlockHintStepOperation(builder, _o.Type);
		}

		// Token: 0x0400C644 RID: 50756
		private Table __p;
	}
}
