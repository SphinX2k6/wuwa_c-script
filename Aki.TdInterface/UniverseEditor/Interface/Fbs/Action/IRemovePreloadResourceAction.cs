using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E5B RID: 28251
	public struct IRemovePreloadResourceAction : IFlatbufferObject
	{
		// Token: 0x1700D273 RID: 53875
		// (get) Token: 0x06031EBA RID: 204474 RVA: 0x006C1092 File Offset: 0x006BF292
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031EBB RID: 204475 RVA: 0x006C109F File Offset: 0x006BF29F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031EBC RID: 204476 RVA: 0x006C10A8 File Offset: 0x006BF2A8
		public static IRemovePreloadResourceAction GetRootAsIRemovePreloadResourceAction(ByteBuffer _bb)
		{
			return IRemovePreloadResourceAction.GetRootAsIRemovePreloadResourceAction(_bb, default(IRemovePreloadResourceAction));
		}

		// Token: 0x06031EBD RID: 204477 RVA: 0x006C10C4 File Offset: 0x006BF2C4
		public static IRemovePreloadResourceAction GetRootAsIRemovePreloadResourceAction(ByteBuffer _bb, IRemovePreloadResourceAction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031EBE RID: 204478 RVA: 0x006C10E1 File Offset: 0x006BF2E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031EBF RID: 204479 RVA: 0x006C10F0 File Offset: 0x006BF2F0
		public IRemovePreloadResourceAction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D274 RID: 53876
		// (get) Token: 0x06031EC0 RID: 204480 RVA: 0x006C1100 File Offset: 0x006BF300
		public TRemovePreloadResourceConfig RemovePreloadResourceObjectTypeType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TRemovePreloadResourceConfig.NONE;
				}
				return (TRemovePreloadResourceConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031EC1 RID: 204481 RVA: 0x006C113C File Offset: 0x006BF33C
		public TTable? RemovePreloadResourceObjectType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06031EC2 RID: 204482 RVA: 0x006C1180 File Offset: 0x006BF380
		public IRemovePreloadFlows RemovePreloadResourceObjectTypeAsIRemovePreloadFlows()
		{
			return this.RemovePreloadResourceObjectType<IRemovePreloadFlows>().Value;
		}

		// Token: 0x06031EC3 RID: 204483 RVA: 0x006C119C File Offset: 0x006BF39C
		public IRemovePreloadLinkResource RemovePreloadResourceObjectTypeAsIRemovePreloadLinkResource()
		{
			return this.RemovePreloadResourceObjectType<IRemovePreloadLinkResource>().Value;
		}

		// Token: 0x06031EC4 RID: 204484 RVA: 0x006C11B8 File Offset: 0x006BF3B8
		public IRemovePreloadResourcePhantomCharacter RemovePreloadResourceObjectTypeAsIRemovePreloadResourcePhantomCharacter()
		{
			return this.RemovePreloadResourceObjectType<IRemovePreloadResourcePhantomCharacter>().Value;
		}

		// Token: 0x06031EC5 RID: 204485 RVA: 0x006C11D4 File Offset: 0x006BF3D4
		public IRemovePreloadResourceTrialCharacter RemovePreloadResourceObjectTypeAsIRemovePreloadResourceTrialCharacter()
		{
			return this.RemovePreloadResourceObjectType<IRemovePreloadResourceTrialCharacter>().Value;
		}

		// Token: 0x06031EC6 RID: 204486 RVA: 0x006C11EF File Offset: 0x006BF3EF
		public static Offset<IRemovePreloadResourceAction> CreateIRemovePreloadResourceAction(FlatBufferBuilder builder, TRemovePreloadResourceConfig RemovePreloadResourceObjectType_type = TRemovePreloadResourceConfig.NONE, int RemovePreloadResourceObjectTypeOffset = 0)
		{
			builder.StartTable(2);
			IRemovePreloadResourceAction.AddRemovePreloadResourceObjectType(builder, RemovePreloadResourceObjectTypeOffset);
			IRemovePreloadResourceAction.AddRemovePreloadResourceObjectTypeType(builder, RemovePreloadResourceObjectType_type);
			return IRemovePreloadResourceAction.EndIRemovePreloadResourceAction(builder);
		}

		// Token: 0x06031EC7 RID: 204487 RVA: 0x006C120C File Offset: 0x006BF40C
		public static void StartIRemovePreloadResourceAction(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031EC8 RID: 204488 RVA: 0x006C1215 File Offset: 0x006BF415
		public static void AddRemovePreloadResourceObjectTypeType(FlatBufferBuilder builder, TRemovePreloadResourceConfig removePreloadResourceObjectTypeType)
		{
			builder.AddByte(0, (byte)removePreloadResourceObjectTypeType, 0);
		}

		// Token: 0x06031EC9 RID: 204489 RVA: 0x006C1220 File Offset: 0x006BF420
		public static void AddRemovePreloadResourceObjectType(FlatBufferBuilder builder, int removePreloadResourceObjectTypeOffset)
		{
			builder.AddOffset(1, removePreloadResourceObjectTypeOffset, 0);
		}

		// Token: 0x06031ECA RID: 204490 RVA: 0x006C122B File Offset: 0x006BF42B
		public static Offset<IRemovePreloadResourceAction> EndIRemovePreloadResourceAction(FlatBufferBuilder builder)
		{
			return new Offset<IRemovePreloadResourceAction>(builder.EndTable());
		}

		// Token: 0x06031ECB RID: 204491 RVA: 0x006C1238 File Offset: 0x006BF438
		public IRemovePreloadResourceActionT UnPack()
		{
			IRemovePreloadResourceActionT removePreloadResourceActionT = new IRemovePreloadResourceActionT();
			this.UnPackTo(removePreloadResourceActionT);
			return removePreloadResourceActionT;
		}

		// Token: 0x06031ECC RID: 204492 RVA: 0x006C1254 File Offset: 0x006BF454
		public void UnPackTo(IRemovePreloadResourceActionT _o)
		{
			_o.RemovePreloadResourceObjectType = new TRemovePreloadResourceConfigUnion();
			_o.RemovePreloadResourceObjectType.Type = this.RemovePreloadResourceObjectTypeType;
			switch (this.RemovePreloadResourceObjectTypeType)
			{
			case TRemovePreloadResourceConfig.IRemovePreloadFlows:
				_o.RemovePreloadResourceObjectType.Value = ((this.RemovePreloadResourceObjectType<IRemovePreloadFlows>() != null) ? this.RemovePreloadResourceObjectType<IRemovePreloadFlows>().Value.UnPack() : null);
				return;
			case TRemovePreloadResourceConfig.IRemovePreloadLinkResource:
				_o.RemovePreloadResourceObjectType.Value = ((this.RemovePreloadResourceObjectType<IRemovePreloadLinkResource>() != null) ? this.RemovePreloadResourceObjectType<IRemovePreloadLinkResource>().Value.UnPack() : null);
				return;
			case TRemovePreloadResourceConfig.IRemovePreloadResourcePhantomCharacter:
				_o.RemovePreloadResourceObjectType.Value = ((this.RemovePreloadResourceObjectType<IRemovePreloadResourcePhantomCharacter>() != null) ? this.RemovePreloadResourceObjectType<IRemovePreloadResourcePhantomCharacter>().Value.UnPack() : null);
				return;
			case TRemovePreloadResourceConfig.IRemovePreloadResourceTrialCharacter:
				_o.RemovePreloadResourceObjectType.Value = ((this.RemovePreloadResourceObjectType<IRemovePreloadResourceTrialCharacter>() != null) ? this.RemovePreloadResourceObjectType<IRemovePreloadResourceTrialCharacter>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06031ECD RID: 204493 RVA: 0x006C1378 File Offset: 0x006BF578
		public static Offset<IRemovePreloadResourceAction> Pack(FlatBufferBuilder builder, IRemovePreloadResourceActionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRemovePreloadResourceAction>);
			}
			TRemovePreloadResourceConfig removePreloadResourceObjectType_type = (_o.RemovePreloadResourceObjectType == null) ? TRemovePreloadResourceConfig.NONE : _o.RemovePreloadResourceObjectType.Type;
			int removePreloadResourceObjectTypeOffset = (_o.RemovePreloadResourceObjectType == null) ? 0 : TRemovePreloadResourceConfigUnion.Pack(builder, _o.RemovePreloadResourceObjectType);
			return IRemovePreloadResourceAction.CreateIRemovePreloadResourceAction(builder, removePreloadResourceObjectType_type, removePreloadResourceObjectTypeOffset);
		}

		// Token: 0x04011840 RID: 71744
		private Table __p;
	}
}
