using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D76 RID: 28022
	public struct IExecAlertSystemAction : IFlatbufferObject
	{
		// Token: 0x1700CD9B RID: 52635
		// (get) Token: 0x060305A9 RID: 198057 RVA: 0x006920BC File Offset: 0x006902BC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060305AA RID: 198058 RVA: 0x006920C9 File Offset: 0x006902C9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060305AB RID: 198059 RVA: 0x006920D0 File Offset: 0x006902D0
		public static IExecAlertSystemAction GetRootAsIExecAlertSystemAction(ByteBuffer _bb)
		{
			return IExecAlertSystemAction.GetRootAsIExecAlertSystemAction(_bb, default(IExecAlertSystemAction));
		}

		// Token: 0x060305AC RID: 198060 RVA: 0x006920EC File Offset: 0x006902EC
		public static IExecAlertSystemAction GetRootAsIExecAlertSystemAction(ByteBuffer _bb, IExecAlertSystemAction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060305AD RID: 198061 RVA: 0x00692109 File Offset: 0x00690309
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060305AE RID: 198062 RVA: 0x00692118 File Offset: 0x00690318
		public IExecAlertSystemAction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CD9C RID: 52636
		// (get) Token: 0x060305AF RID: 198063 RVA: 0x00692128 File Offset: 0x00690328
		public TAlertSystemOption OptionType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TAlertSystemOption.NONE;
				}
				return (TAlertSystemOption)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060305B0 RID: 198064 RVA: 0x00692164 File Offset: 0x00690364
		public TTable? Option<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060305B1 RID: 198065 RVA: 0x006921A8 File Offset: 0x006903A8
		public IEnableAlertArea OptionAsIEnableAlertArea()
		{
			return this.Option<IEnableAlertArea>().Value;
		}

		// Token: 0x060305B2 RID: 198066 RVA: 0x006921C4 File Offset: 0x006903C4
		public IEnableAlertUi OptionAsIEnableAlertUi()
		{
			return this.Option<IEnableAlertUi>().Value;
		}

		// Token: 0x060305B3 RID: 198067 RVA: 0x006921E0 File Offset: 0x006903E0
		public IModifyAlertValue OptionAsIModifyAlertValue()
		{
			return this.Option<IModifyAlertValue>().Value;
		}

		// Token: 0x060305B4 RID: 198068 RVA: 0x006921FC File Offset: 0x006903FC
		public ISetAlertUiVisible OptionAsISetAlertUiVisible()
		{
			return this.Option<ISetAlertUiVisible>().Value;
		}

		// Token: 0x060305B5 RID: 198069 RVA: 0x00692217 File Offset: 0x00690417
		public static Offset<IExecAlertSystemAction> CreateIExecAlertSystemAction(FlatBufferBuilder builder, TAlertSystemOption Option_type = TAlertSystemOption.NONE, int OptionOffset = 0)
		{
			builder.StartTable(2);
			IExecAlertSystemAction.AddOption(builder, OptionOffset);
			IExecAlertSystemAction.AddOptionType(builder, Option_type);
			return IExecAlertSystemAction.EndIExecAlertSystemAction(builder);
		}

		// Token: 0x060305B6 RID: 198070 RVA: 0x00692234 File Offset: 0x00690434
		public static void StartIExecAlertSystemAction(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060305B7 RID: 198071 RVA: 0x0069223D File Offset: 0x0069043D
		public static void AddOptionType(FlatBufferBuilder builder, TAlertSystemOption optionType)
		{
			builder.AddByte(0, (byte)optionType, 0);
		}

		// Token: 0x060305B8 RID: 198072 RVA: 0x00692248 File Offset: 0x00690448
		public static void AddOption(FlatBufferBuilder builder, int optionOffset)
		{
			builder.AddOffset(1, optionOffset, 0);
		}

		// Token: 0x060305B9 RID: 198073 RVA: 0x00692253 File Offset: 0x00690453
		public static Offset<IExecAlertSystemAction> EndIExecAlertSystemAction(FlatBufferBuilder builder)
		{
			return new Offset<IExecAlertSystemAction>(builder.EndTable());
		}

		// Token: 0x060305BA RID: 198074 RVA: 0x00692260 File Offset: 0x00690460
		public IExecAlertSystemActionT UnPack()
		{
			IExecAlertSystemActionT execAlertSystemActionT = new IExecAlertSystemActionT();
			this.UnPackTo(execAlertSystemActionT);
			return execAlertSystemActionT;
		}

		// Token: 0x060305BB RID: 198075 RVA: 0x0069227C File Offset: 0x0069047C
		public void UnPackTo(IExecAlertSystemActionT _o)
		{
			_o.Option = new TAlertSystemOptionUnion();
			_o.Option.Type = this.OptionType;
			switch (this.OptionType)
			{
			case TAlertSystemOption.IEnableAlertArea:
				_o.Option.Value = ((this.Option<IEnableAlertArea>() != null) ? this.Option<IEnableAlertArea>().Value.UnPack() : null);
				return;
			case TAlertSystemOption.IEnableAlertUi:
				_o.Option.Value = ((this.Option<IEnableAlertUi>() != null) ? this.Option<IEnableAlertUi>().Value.UnPack() : null);
				return;
			case TAlertSystemOption.IModifyAlertValue:
				_o.Option.Value = ((this.Option<IModifyAlertValue>() != null) ? this.Option<IModifyAlertValue>().Value.UnPack() : null);
				return;
			case TAlertSystemOption.ISetAlertUiVisible:
				_o.Option.Value = ((this.Option<ISetAlertUiVisible>() != null) ? this.Option<ISetAlertUiVisible>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x060305BC RID: 198076 RVA: 0x006923A0 File Offset: 0x006905A0
		public static Offset<IExecAlertSystemAction> Pack(FlatBufferBuilder builder, IExecAlertSystemActionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExecAlertSystemAction>);
			}
			TAlertSystemOption option_type = (_o.Option == null) ? TAlertSystemOption.NONE : _o.Option.Type;
			int optionOffset = (_o.Option == null) ? 0 : TAlertSystemOptionUnion.Pack(builder, _o.Option);
			return IExecAlertSystemAction.CreateIExecAlertSystemAction(builder, option_type, optionOffset);
		}

		// Token: 0x04011BFD RID: 72701
		private Table __p;
	}
}
