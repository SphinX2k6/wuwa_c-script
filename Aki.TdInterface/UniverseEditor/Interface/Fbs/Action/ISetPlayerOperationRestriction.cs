using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200781B RID: 30747
	public struct ISetPlayerOperationRestriction : IFlatbufferObject
	{
		// Token: 0x1700E172 RID: 57714
		// (get) Token: 0x060360B0 RID: 221360 RVA: 0x0073D33C File Offset: 0x0073B53C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060360B1 RID: 221361 RVA: 0x0073D349 File Offset: 0x0073B549
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060360B2 RID: 221362 RVA: 0x0073D350 File Offset: 0x0073B550
		public static ISetPlayerOperationRestriction GetRootAsISetPlayerOperationRestriction(ByteBuffer _bb)
		{
			return ISetPlayerOperationRestriction.GetRootAsISetPlayerOperationRestriction(_bb, default(ISetPlayerOperationRestriction));
		}

		// Token: 0x060360B3 RID: 221363 RVA: 0x0073D36C File Offset: 0x0073B56C
		public static ISetPlayerOperationRestriction GetRootAsISetPlayerOperationRestriction(ByteBuffer _bb, ISetPlayerOperationRestriction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060360B4 RID: 221364 RVA: 0x0073D389 File Offset: 0x0073B589
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060360B5 RID: 221365 RVA: 0x0073D398 File Offset: 0x0073B598
		public ISetPlayerOperationRestriction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E173 RID: 57715
		// (get) Token: 0x060360B6 RID: 221366 RVA: 0x0073D3A8 File Offset: 0x0073B5A8
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

		// Token: 0x060360B7 RID: 221367 RVA: 0x0073D3E4 File Offset: 0x0073B5E4
		public static Offset<ISetPlayerOperationRestriction> CreateISetPlayerOperationRestriction(FlatBufferBuilder builder, EPlayerOperationType Type = EPlayerOperationType.EnableAll)
		{
			builder.StartTable(1);
			ISetPlayerOperationRestriction.AddType(builder, Type);
			return ISetPlayerOperationRestriction.EndISetPlayerOperationRestriction(builder);
		}

		// Token: 0x060360B8 RID: 221368 RVA: 0x0073D3FA File Offset: 0x0073B5FA
		public static void StartISetPlayerOperationRestriction(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060360B9 RID: 221369 RVA: 0x0073D403 File Offset: 0x0073B603
		public static void AddType(FlatBufferBuilder builder, EPlayerOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060360BA RID: 221370 RVA: 0x0073D40E File Offset: 0x0073B60E
		public static Offset<ISetPlayerOperationRestriction> EndISetPlayerOperationRestriction(FlatBufferBuilder builder)
		{
			return new Offset<ISetPlayerOperationRestriction>(builder.EndTable());
		}

		// Token: 0x060360BB RID: 221371 RVA: 0x0073D41C File Offset: 0x0073B61C
		public ISetPlayerOperationRestrictionT UnPack()
		{
			ISetPlayerOperationRestrictionT setPlayerOperationRestrictionT = new ISetPlayerOperationRestrictionT();
			this.UnPackTo(setPlayerOperationRestrictionT);
			return setPlayerOperationRestrictionT;
		}

		// Token: 0x060360BC RID: 221372 RVA: 0x0073D437 File Offset: 0x0073B637
		public void UnPackTo(ISetPlayerOperationRestrictionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060360BD RID: 221373 RVA: 0x0073D448 File Offset: 0x0073B648
		public static Offset<ISetPlayerOperationRestriction> Pack(FlatBufferBuilder builder, ISetPlayerOperationRestrictionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetPlayerOperationRestriction>);
			}
			return ISetPlayerOperationRestriction.CreateISetPlayerOperationRestriction(builder, _o.Type);
		}

		// Token: 0x04012A81 RID: 76417
		private Table __p;
	}
}
