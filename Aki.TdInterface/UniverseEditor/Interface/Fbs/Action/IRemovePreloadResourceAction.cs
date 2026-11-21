using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075DC RID: 30172
	public struct IRemovePreloadResourceAction : IFlatbufferObject
	{
		// Token: 0x1700DDC5 RID: 56773
		// (get) Token: 0x06034EE2 RID: 216802 RVA: 0x0071CB92 File Offset: 0x0071AD92
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034EE3 RID: 216803 RVA: 0x0071CB9F File Offset: 0x0071AD9F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034EE4 RID: 216804 RVA: 0x0071CBA8 File Offset: 0x0071ADA8
		public static IRemovePreloadResourceAction GetRootAsIRemovePreloadResourceAction(ByteBuffer _bb)
		{
			return IRemovePreloadResourceAction.GetRootAsIRemovePreloadResourceAction(_bb, default(IRemovePreloadResourceAction));
		}

		// Token: 0x06034EE5 RID: 216805 RVA: 0x0071CBC4 File Offset: 0x0071ADC4
		public static IRemovePreloadResourceAction GetRootAsIRemovePreloadResourceAction(ByteBuffer _bb, IRemovePreloadResourceAction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034EE6 RID: 216806 RVA: 0x0071CBE1 File Offset: 0x0071ADE1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034EE7 RID: 216807 RVA: 0x0071CBF0 File Offset: 0x0071ADF0
		public IRemovePreloadResourceAction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DDC6 RID: 56774
		// (get) Token: 0x06034EE8 RID: 216808 RVA: 0x0071CC00 File Offset: 0x0071AE00
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

		// Token: 0x06034EE9 RID: 216809 RVA: 0x0071CC3C File Offset: 0x0071AE3C
		public TTable? RemovePreloadResourceObjectType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06034EEA RID: 216810 RVA: 0x0071CC80 File Offset: 0x0071AE80
		public IRemovePreloadFlows RemovePreloadResourceObjectTypeAsIRemovePreloadFlows()
		{
			return this.RemovePreloadResourceObjectType<IRemovePreloadFlows>().Value;
		}

		// Token: 0x06034EEB RID: 216811 RVA: 0x0071CC9C File Offset: 0x0071AE9C
		public IRemovePreloadLinkResource RemovePreloadResourceObjectTypeAsIRemovePreloadLinkResource()
		{
			return this.RemovePreloadResourceObjectType<IRemovePreloadLinkResource>().Value;
		}

		// Token: 0x06034EEC RID: 216812 RVA: 0x0071CCB8 File Offset: 0x0071AEB8
		public IRemovePreloadResourcePhantomCharacter RemovePreloadResourceObjectTypeAsIRemovePreloadResourcePhantomCharacter()
		{
			return this.RemovePreloadResourceObjectType<IRemovePreloadResourcePhantomCharacter>().Value;
		}

		// Token: 0x06034EED RID: 216813 RVA: 0x0071CCD4 File Offset: 0x0071AED4
		public IRemovePreloadResourceTrialCharacter RemovePreloadResourceObjectTypeAsIRemovePreloadResourceTrialCharacter()
		{
			return this.RemovePreloadResourceObjectType<IRemovePreloadResourceTrialCharacter>().Value;
		}

		// Token: 0x06034EEE RID: 216814 RVA: 0x0071CCEF File Offset: 0x0071AEEF
		public static Offset<IRemovePreloadResourceAction> CreateIRemovePreloadResourceAction(FlatBufferBuilder builder, TRemovePreloadResourceConfig RemovePreloadResourceObjectType_type = TRemovePreloadResourceConfig.NONE, int RemovePreloadResourceObjectTypeOffset = 0)
		{
			builder.StartTable(2);
			IRemovePreloadResourceAction.AddRemovePreloadResourceObjectType(builder, RemovePreloadResourceObjectTypeOffset);
			IRemovePreloadResourceAction.AddRemovePreloadResourceObjectTypeType(builder, RemovePreloadResourceObjectType_type);
			return IRemovePreloadResourceAction.EndIRemovePreloadResourceAction(builder);
		}

		// Token: 0x06034EEF RID: 216815 RVA: 0x0071CD0C File Offset: 0x0071AF0C
		public static void StartIRemovePreloadResourceAction(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06034EF0 RID: 216816 RVA: 0x0071CD15 File Offset: 0x0071AF15
		public static void AddRemovePreloadResourceObjectTypeType(FlatBufferBuilder builder, TRemovePreloadResourceConfig removePreloadResourceObjectTypeType)
		{
			builder.AddByte(0, (byte)removePreloadResourceObjectTypeType, 0);
		}

		// Token: 0x06034EF1 RID: 216817 RVA: 0x0071CD20 File Offset: 0x0071AF20
		public static void AddRemovePreloadResourceObjectType(FlatBufferBuilder builder, int removePreloadResourceObjectTypeOffset)
		{
			builder.AddOffset(1, removePreloadResourceObjectTypeOffset, 0);
		}

		// Token: 0x06034EF2 RID: 216818 RVA: 0x0071CD2B File Offset: 0x0071AF2B
		public static Offset<IRemovePreloadResourceAction> EndIRemovePreloadResourceAction(FlatBufferBuilder builder)
		{
			return new Offset<IRemovePreloadResourceAction>(builder.EndTable());
		}

		// Token: 0x06034EF3 RID: 216819 RVA: 0x0071CD38 File Offset: 0x0071AF38
		public IRemovePreloadResourceActionT UnPack()
		{
			IRemovePreloadResourceActionT removePreloadResourceActionT = new IRemovePreloadResourceActionT();
			this.UnPackTo(removePreloadResourceActionT);
			return removePreloadResourceActionT;
		}

		// Token: 0x06034EF4 RID: 216820 RVA: 0x0071CD54 File Offset: 0x0071AF54
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

		// Token: 0x06034EF5 RID: 216821 RVA: 0x0071CE78 File Offset: 0x0071B078
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

		// Token: 0x040127C2 RID: 75714
		private Table __p;
	}
}
