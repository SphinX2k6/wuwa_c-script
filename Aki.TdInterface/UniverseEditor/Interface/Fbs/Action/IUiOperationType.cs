using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074A5 RID: 29861
	public struct IUiOperationType : IFlatbufferObject
	{
		// Token: 0x1700E2B3 RID: 58035
		// (get) Token: 0x060364AC RID: 222380 RVA: 0x00761367 File Offset: 0x0075F567
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060364AD RID: 222381 RVA: 0x00761374 File Offset: 0x0075F574
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060364AE RID: 222382 RVA: 0x0076137C File Offset: 0x0075F57C
		public static IUiOperationType GetRootAsIUiOperationType(ByteBuffer _bb)
		{
			return IUiOperationType.GetRootAsIUiOperationType(_bb, default(IUiOperationType));
		}

		// Token: 0x060364AF RID: 222383 RVA: 0x00761398 File Offset: 0x0075F598
		public static IUiOperationType GetRootAsIUiOperationType(ByteBuffer _bb, IUiOperationType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060364B0 RID: 222384 RVA: 0x007613B5 File Offset: 0x0075F5B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060364B1 RID: 222385 RVA: 0x007613C4 File Offset: 0x0075F5C4
		public IUiOperationType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E2B4 RID: 58036
		// (get) Token: 0x060364B2 RID: 222386 RVA: 0x007613D4 File Offset: 0x0075F5D4
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

		// Token: 0x060364B3 RID: 222387 RVA: 0x00761410 File Offset: 0x0075F610
		public static Offset<IUiOperationType> CreateIUiOperationType(FlatBufferBuilder builder, EUiOperationType Type = EUiOperationType.Enable)
		{
			builder.StartTable(1);
			IUiOperationType.AddType(builder, Type);
			return IUiOperationType.EndIUiOperationType(builder);
		}

		// Token: 0x060364B4 RID: 222388 RVA: 0x00761426 File Offset: 0x0075F626
		public static void StartIUiOperationType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060364B5 RID: 222389 RVA: 0x0076142F File Offset: 0x0075F62F
		public static void AddType(FlatBufferBuilder builder, EUiOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060364B6 RID: 222390 RVA: 0x0076143A File Offset: 0x0075F63A
		public static Offset<IUiOperationType> EndIUiOperationType(FlatBufferBuilder builder)
		{
			return new Offset<IUiOperationType>(builder.EndTable());
		}

		// Token: 0x060364B7 RID: 222391 RVA: 0x00761448 File Offset: 0x0075F648
		public IUiOperationTypeT UnPack()
		{
			IUiOperationTypeT uiOperationTypeT = new IUiOperationTypeT();
			this.UnPackTo(uiOperationTypeT);
			return uiOperationTypeT;
		}

		// Token: 0x060364B8 RID: 222392 RVA: 0x00761463 File Offset: 0x0075F663
		public void UnPackTo(IUiOperationTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060364B9 RID: 222393 RVA: 0x00761474 File Offset: 0x0075F674
		public static Offset<IUiOperationType> Pack(FlatBufferBuilder builder, IUiOperationTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUiOperationType>);
			}
			return IUiOperationType.CreateIUiOperationType(builder, _o.Type);
		}

		// Token: 0x04012364 RID: 74596
		private Table __p;
	}
}
