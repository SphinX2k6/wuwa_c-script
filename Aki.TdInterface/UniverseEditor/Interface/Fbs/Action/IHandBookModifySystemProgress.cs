using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F62 RID: 28514
	public struct IHandBookModifySystemProgress : IFlatbufferObject
	{
		// Token: 0x1700D0ED RID: 53485
		// (get) Token: 0x060315AA RID: 202154 RVA: 0x006B1AA3 File Offset: 0x006AFCA3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060315AB RID: 202155 RVA: 0x006B1AB0 File Offset: 0x006AFCB0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060315AC RID: 202156 RVA: 0x006B1AB8 File Offset: 0x006AFCB8
		public static IHandBookModifySystemProgress GetRootAsIHandBookModifySystemProgress(ByteBuffer _bb)
		{
			return IHandBookModifySystemProgress.GetRootAsIHandBookModifySystemProgress(_bb, default(IHandBookModifySystemProgress));
		}

		// Token: 0x060315AD RID: 202157 RVA: 0x006B1AD4 File Offset: 0x006AFCD4
		public static IHandBookModifySystemProgress GetRootAsIHandBookModifySystemProgress(ByteBuffer _bb, IHandBookModifySystemProgress obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060315AE RID: 202158 RVA: 0x006B1AF1 File Offset: 0x006AFCF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060315AF RID: 202159 RVA: 0x006B1B00 File Offset: 0x006AFD00
		public IHandBookModifySystemProgress __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D0EE RID: 53486
		// (get) Token: 0x060315B0 RID: 202160 RVA: 0x006B1B10 File Offset: 0x006AFD10
		public THandBookProgressOption OperationType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return THandBookProgressOption.NONE;
				}
				return (THandBookProgressOption)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060315B1 RID: 202161 RVA: 0x006B1B4C File Offset: 0x006AFD4C
		public TTable? Operation<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060315B2 RID: 202162 RVA: 0x006B1B90 File Offset: 0x006AFD90
		public IHandBookGrantEmojiOption OperationAsIHandBookGrantEmojiOption()
		{
			return this.Operation<IHandBookGrantEmojiOption>().Value;
		}

		// Token: 0x060315B3 RID: 202163 RVA: 0x006B1BAC File Offset: 0x006AFDAC
		public IHandBookRollbackEmojiOption OperationAsIHandBookRollbackEmojiOption()
		{
			return this.Operation<IHandBookRollbackEmojiOption>().Value;
		}

		// Token: 0x060315B4 RID: 202164 RVA: 0x006B1BC7 File Offset: 0x006AFDC7
		public static Offset<IHandBookModifySystemProgress> CreateIHandBookModifySystemProgress(FlatBufferBuilder builder, THandBookProgressOption Operation_type = THandBookProgressOption.NONE, int OperationOffset = 0)
		{
			builder.StartTable(2);
			IHandBookModifySystemProgress.AddOperation(builder, OperationOffset);
			IHandBookModifySystemProgress.AddOperationType(builder, Operation_type);
			return IHandBookModifySystemProgress.EndIHandBookModifySystemProgress(builder);
		}

		// Token: 0x060315B5 RID: 202165 RVA: 0x006B1BE4 File Offset: 0x006AFDE4
		public static void StartIHandBookModifySystemProgress(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060315B6 RID: 202166 RVA: 0x006B1BED File Offset: 0x006AFDED
		public static void AddOperationType(FlatBufferBuilder builder, THandBookProgressOption operationType)
		{
			builder.AddByte(0, (byte)operationType, 0);
		}

		// Token: 0x060315B7 RID: 202167 RVA: 0x006B1BF8 File Offset: 0x006AFDF8
		public static void AddOperation(FlatBufferBuilder builder, int operationOffset)
		{
			builder.AddOffset(1, operationOffset, 0);
		}

		// Token: 0x060315B8 RID: 202168 RVA: 0x006B1C03 File Offset: 0x006AFE03
		public static Offset<IHandBookModifySystemProgress> EndIHandBookModifySystemProgress(FlatBufferBuilder builder)
		{
			return new Offset<IHandBookModifySystemProgress>(builder.EndTable());
		}

		// Token: 0x060315B9 RID: 202169 RVA: 0x006B1C10 File Offset: 0x006AFE10
		public IHandBookModifySystemProgressT UnPack()
		{
			IHandBookModifySystemProgressT handBookModifySystemProgressT = new IHandBookModifySystemProgressT();
			this.UnPackTo(handBookModifySystemProgressT);
			return handBookModifySystemProgressT;
		}

		// Token: 0x060315BA RID: 202170 RVA: 0x006B1C2C File Offset: 0x006AFE2C
		public void UnPackTo(IHandBookModifySystemProgressT _o)
		{
			_o.Operation = new THandBookProgressOptionUnion();
			_o.Operation.Type = this.OperationType;
			THandBookProgressOption operationType = this.OperationType;
			if (operationType == THandBookProgressOption.IHandBookGrantEmojiOption)
			{
				_o.Operation.Value = ((this.Operation<IHandBookGrantEmojiOption>() != null) ? this.Operation<IHandBookGrantEmojiOption>().Value.UnPack() : null);
				return;
			}
			if (operationType != THandBookProgressOption.IHandBookRollbackEmojiOption)
			{
				return;
			}
			_o.Operation.Value = ((this.Operation<IHandBookRollbackEmojiOption>() != null) ? this.Operation<IHandBookRollbackEmojiOption>().Value.UnPack() : null);
		}

		// Token: 0x060315BB RID: 202171 RVA: 0x006B1CD0 File Offset: 0x006AFED0
		public static Offset<IHandBookModifySystemProgress> Pack(FlatBufferBuilder builder, IHandBookModifySystemProgressT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHandBookModifySystemProgress>);
			}
			THandBookProgressOption operation_type = (_o.Operation == null) ? THandBookProgressOption.NONE : _o.Operation.Type;
			int operationOffset = (_o.Operation == null) ? 0 : THandBookProgressOptionUnion.Pack(builder, _o.Operation);
			return IHandBookModifySystemProgress.CreateIHandBookModifySystemProgress(builder, operation_type, operationOffset);
		}

		// Token: 0x04011E71 RID: 73329
		private Table __p;
	}
}
