using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049F2 RID: 18930
	public struct IRollBlockHintStepOperation : IFlatbufferObject
	{
		// Token: 0x170084BC RID: 33980
		// (get) Token: 0x0601C612 RID: 116242 RVA: 0x00402890 File Offset: 0x00400A90
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C613 RID: 116243 RVA: 0x0040289D File Offset: 0x00400A9D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C614 RID: 116244 RVA: 0x004028A4 File Offset: 0x00400AA4
		public static IRollBlockHintStepOperation GetRootAsIRollBlockHintStepOperation(ByteBuffer _bb)
		{
			return IRollBlockHintStepOperation.GetRootAsIRollBlockHintStepOperation(_bb, default(IRollBlockHintStepOperation));
		}

		// Token: 0x0601C615 RID: 116245 RVA: 0x004028C0 File Offset: 0x00400AC0
		public static IRollBlockHintStepOperation GetRootAsIRollBlockHintStepOperation(ByteBuffer _bb, IRollBlockHintStepOperation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C616 RID: 116246 RVA: 0x004028DD File Offset: 0x00400ADD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C617 RID: 116247 RVA: 0x004028EC File Offset: 0x00400AEC
		public IRollBlockHintStepOperation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170084BD RID: 33981
		// (get) Token: 0x0601C618 RID: 116248 RVA: 0x004028FC File Offset: 0x00400AFC
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

		// Token: 0x0601C619 RID: 116249 RVA: 0x00402938 File Offset: 0x00400B38
		public static Offset<IRollBlockHintStepOperation> CreateIRollBlockHintStepOperation(FlatBufferBuilder builder, ERollBlockHintStepType Type = ERollBlockHintStepType.Roll)
		{
			builder.StartTable(1);
			IRollBlockHintStepOperation.AddType(builder, Type);
			return IRollBlockHintStepOperation.EndIRollBlockHintStepOperation(builder);
		}

		// Token: 0x0601C61A RID: 116250 RVA: 0x0040294E File Offset: 0x00400B4E
		public static void StartIRollBlockHintStepOperation(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601C61B RID: 116251 RVA: 0x00402957 File Offset: 0x00400B57
		public static void AddType(FlatBufferBuilder builder, ERollBlockHintStepType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601C61C RID: 116252 RVA: 0x00402962 File Offset: 0x00400B62
		public static Offset<IRollBlockHintStepOperation> EndIRollBlockHintStepOperation(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockHintStepOperation>(builder.EndTable());
		}

		// Token: 0x0601C61D RID: 116253 RVA: 0x00402970 File Offset: 0x00400B70
		public IRollBlockHintStepOperationT UnPack()
		{
			IRollBlockHintStepOperationT rollBlockHintStepOperationT = new IRollBlockHintStepOperationT();
			this.UnPackTo(rollBlockHintStepOperationT);
			return rollBlockHintStepOperationT;
		}

		// Token: 0x0601C61E RID: 116254 RVA: 0x0040298B File Offset: 0x00400B8B
		public void UnPackTo(IRollBlockHintStepOperationT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601C61F RID: 116255 RVA: 0x0040299C File Offset: 0x00400B9C
		public static Offset<IRollBlockHintStepOperation> Pack(FlatBufferBuilder builder, IRollBlockHintStepOperationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRollBlockHintStepOperation>);
			}
			return IRollBlockHintStepOperation.CreateIRollBlockHintStepOperation(builder, _o.Type);
		}

		// Token: 0x0400D073 RID: 53363
		private Table __p;
	}
}
