using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200704F RID: 28751
	public struct ISetPlayerOperationRestriction : IFlatbufferObject
	{
		// Token: 0x1700D591 RID: 54673
		// (get) Token: 0x06032E13 RID: 208403 RVA: 0x006DCE14 File Offset: 0x006DB014
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032E14 RID: 208404 RVA: 0x006DCE21 File Offset: 0x006DB021
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032E15 RID: 208405 RVA: 0x006DCE28 File Offset: 0x006DB028
		public static ISetPlayerOperationRestriction GetRootAsISetPlayerOperationRestriction(ByteBuffer _bb)
		{
			return ISetPlayerOperationRestriction.GetRootAsISetPlayerOperationRestriction(_bb, default(ISetPlayerOperationRestriction));
		}

		// Token: 0x06032E16 RID: 208406 RVA: 0x006DCE44 File Offset: 0x006DB044
		public static ISetPlayerOperationRestriction GetRootAsISetPlayerOperationRestriction(ByteBuffer _bb, ISetPlayerOperationRestriction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032E17 RID: 208407 RVA: 0x006DCE61 File Offset: 0x006DB061
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032E18 RID: 208408 RVA: 0x006DCE70 File Offset: 0x006DB070
		public ISetPlayerOperationRestriction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D592 RID: 54674
		// (get) Token: 0x06032E19 RID: 208409 RVA: 0x006DCE80 File Offset: 0x006DB080
		public EPlayerOperationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPlayerOperationType.EnableAll;
				}
				return (EPlayerOperationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032E1A RID: 208410 RVA: 0x006DCEBC File Offset: 0x006DB0BC
		public static Offset<ISetPlayerOperationRestriction> CreateISetPlayerOperationRestriction(FlatBufferBuilder builder, EPlayerOperationType Type = EPlayerOperationType.EnableAll)
		{
			builder.StartTable(1);
			ISetPlayerOperationRestriction.AddType(builder, Type);
			return ISetPlayerOperationRestriction.EndISetPlayerOperationRestriction(builder);
		}

		// Token: 0x06032E1B RID: 208411 RVA: 0x006DCED2 File Offset: 0x006DB0D2
		public static void StartISetPlayerOperationRestriction(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06032E1C RID: 208412 RVA: 0x006DCEDB File Offset: 0x006DB0DB
		public static void AddType(FlatBufferBuilder builder, EPlayerOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032E1D RID: 208413 RVA: 0x006DCEE6 File Offset: 0x006DB0E6
		public static Offset<ISetPlayerOperationRestriction> EndISetPlayerOperationRestriction(FlatBufferBuilder builder)
		{
			return new Offset<ISetPlayerOperationRestriction>(builder.EndTable());
		}

		// Token: 0x06032E1E RID: 208414 RVA: 0x006DCEF4 File Offset: 0x006DB0F4
		public ISetPlayerOperationRestrictionT UnPack()
		{
			ISetPlayerOperationRestrictionT setPlayerOperationRestrictionT = new ISetPlayerOperationRestrictionT();
			this.UnPackTo(setPlayerOperationRestrictionT);
			return setPlayerOperationRestrictionT;
		}

		// Token: 0x06032E1F RID: 208415 RVA: 0x006DCF0F File Offset: 0x006DB10F
		public void UnPackTo(ISetPlayerOperationRestrictionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06032E20 RID: 208416 RVA: 0x006DCF20 File Offset: 0x006DB120
		public static Offset<ISetPlayerOperationRestriction> Pack(FlatBufferBuilder builder, ISetPlayerOperationRestrictionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetPlayerOperationRestriction>);
			}
			return ISetPlayerOperationRestriction.CreateISetPlayerOperationRestriction(builder, _o.Type);
		}

		// Token: 0x04011A94 RID: 72340
		private Table __p;
	}
}
