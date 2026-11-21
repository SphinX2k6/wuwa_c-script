using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A65 RID: 27237
	public struct IClientSetPlayerOperationRestriction : IFlatbufferObject
	{
		// Token: 0x1700C81B RID: 51227
		// (get) Token: 0x0602EBB9 RID: 191417 RVA: 0x0065EA39 File Offset: 0x0065CC39
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EBBA RID: 191418 RVA: 0x0065EA46 File Offset: 0x0065CC46
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EBBB RID: 191419 RVA: 0x0065EA50 File Offset: 0x0065CC50
		public static IClientSetPlayerOperationRestriction GetRootAsIClientSetPlayerOperationRestriction(ByteBuffer _bb)
		{
			return IClientSetPlayerOperationRestriction.GetRootAsIClientSetPlayerOperationRestriction(_bb, default(IClientSetPlayerOperationRestriction));
		}

		// Token: 0x0602EBBC RID: 191420 RVA: 0x0065EA6C File Offset: 0x0065CC6C
		public static IClientSetPlayerOperationRestriction GetRootAsIClientSetPlayerOperationRestriction(ByteBuffer _bb, IClientSetPlayerOperationRestriction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EBBD RID: 191421 RVA: 0x0065EA89 File Offset: 0x0065CC89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EBBE RID: 191422 RVA: 0x0065EA98 File Offset: 0x0065CC98
		public IClientSetPlayerOperationRestriction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C81C RID: 51228
		// (get) Token: 0x0602EBBF RID: 191423 RVA: 0x0065EAA8 File Offset: 0x0065CCA8
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

		// Token: 0x0602EBC0 RID: 191424 RVA: 0x0065EAE4 File Offset: 0x0065CCE4
		public static Offset<IClientSetPlayerOperationRestriction> CreateIClientSetPlayerOperationRestriction(FlatBufferBuilder builder, EPlayerOperationType Type = EPlayerOperationType.EnableAll)
		{
			builder.StartTable(1);
			IClientSetPlayerOperationRestriction.AddType(builder, Type);
			return IClientSetPlayerOperationRestriction.EndIClientSetPlayerOperationRestriction(builder);
		}

		// Token: 0x0602EBC1 RID: 191425 RVA: 0x0065EAFA File Offset: 0x0065CCFA
		public static void StartIClientSetPlayerOperationRestriction(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602EBC2 RID: 191426 RVA: 0x0065EB03 File Offset: 0x0065CD03
		public static void AddType(FlatBufferBuilder builder, EPlayerOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602EBC3 RID: 191427 RVA: 0x0065EB0E File Offset: 0x0065CD0E
		public static Offset<IClientSetPlayerOperationRestriction> EndIClientSetPlayerOperationRestriction(FlatBufferBuilder builder)
		{
			return new Offset<IClientSetPlayerOperationRestriction>(builder.EndTable());
		}

		// Token: 0x0602EBC4 RID: 191428 RVA: 0x0065EB1C File Offset: 0x0065CD1C
		public IClientSetPlayerOperationRestrictionT UnPack()
		{
			IClientSetPlayerOperationRestrictionT clientSetPlayerOperationRestrictionT = new IClientSetPlayerOperationRestrictionT();
			this.UnPackTo(clientSetPlayerOperationRestrictionT);
			return clientSetPlayerOperationRestrictionT;
		}

		// Token: 0x0602EBC5 RID: 191429 RVA: 0x0065EB37 File Offset: 0x0065CD37
		public void UnPackTo(IClientSetPlayerOperationRestrictionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602EBC6 RID: 191430 RVA: 0x0065EB48 File Offset: 0x0065CD48
		public static Offset<IClientSetPlayerOperationRestriction> Pack(FlatBufferBuilder builder, IClientSetPlayerOperationRestrictionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientSetPlayerOperationRestriction>);
			}
			return IClientSetPlayerOperationRestriction.CreateIClientSetPlayerOperationRestriction(builder, _o.Type);
		}

		// Token: 0x040117ED RID: 71661
		private Table __p;
	}
}
