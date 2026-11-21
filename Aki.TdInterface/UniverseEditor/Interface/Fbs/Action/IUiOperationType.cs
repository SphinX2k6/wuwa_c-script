using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C9B RID: 31899
	public struct IUiOperationType : IFlatbufferObject
	{
		// Token: 0x1700EED7 RID: 61143
		// (get) Token: 0x060398B5 RID: 235701 RVA: 0x007C43F2 File Offset: 0x007C25F2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060398B6 RID: 235702 RVA: 0x007C43FF File Offset: 0x007C25FF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060398B7 RID: 235703 RVA: 0x007C4408 File Offset: 0x007C2608
		public static IUiOperationType GetRootAsIUiOperationType(ByteBuffer _bb)
		{
			return IUiOperationType.GetRootAsIUiOperationType(_bb, default(IUiOperationType));
		}

		// Token: 0x060398B8 RID: 235704 RVA: 0x007C4424 File Offset: 0x007C2624
		public static IUiOperationType GetRootAsIUiOperationType(ByteBuffer _bb, IUiOperationType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060398B9 RID: 235705 RVA: 0x007C4441 File Offset: 0x007C2641
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060398BA RID: 235706 RVA: 0x007C4450 File Offset: 0x007C2650
		public IUiOperationType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EED8 RID: 61144
		// (get) Token: 0x060398BB RID: 235707 RVA: 0x007C4460 File Offset: 0x007C2660
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

		// Token: 0x060398BC RID: 235708 RVA: 0x007C449C File Offset: 0x007C269C
		public static Offset<IUiOperationType> CreateIUiOperationType(FlatBufferBuilder builder, EUiOperationType Type = EUiOperationType.Enable)
		{
			builder.StartTable(1);
			IUiOperationType.AddType(builder, Type);
			return IUiOperationType.EndIUiOperationType(builder);
		}

		// Token: 0x060398BD RID: 235709 RVA: 0x007C44B2 File Offset: 0x007C26B2
		public static void StartIUiOperationType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060398BE RID: 235710 RVA: 0x007C44BB File Offset: 0x007C26BB
		public static void AddType(FlatBufferBuilder builder, EUiOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060398BF RID: 235711 RVA: 0x007C44C6 File Offset: 0x007C26C6
		public static Offset<IUiOperationType> EndIUiOperationType(FlatBufferBuilder builder)
		{
			return new Offset<IUiOperationType>(builder.EndTable());
		}

		// Token: 0x060398C0 RID: 235712 RVA: 0x007C44D4 File Offset: 0x007C26D4
		public IUiOperationTypeT UnPack()
		{
			IUiOperationTypeT uiOperationTypeT = new IUiOperationTypeT();
			this.UnPackTo(uiOperationTypeT);
			return uiOperationTypeT;
		}

		// Token: 0x060398C1 RID: 235713 RVA: 0x007C44EF File Offset: 0x007C26EF
		public void UnPackTo(IUiOperationTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060398C2 RID: 235714 RVA: 0x007C4500 File Offset: 0x007C2700
		public static Offset<IUiOperationType> Pack(FlatBufferBuilder builder, IUiOperationTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUiOperationType>);
			}
			return IUiOperationType.CreateIUiOperationType(builder, _o.Type);
		}

		// Token: 0x04013392 RID: 78738
		private Table __p;
	}
}
