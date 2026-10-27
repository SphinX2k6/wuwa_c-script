using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066F6 RID: 26358
	public struct IExecAlertSystemAction : IFlatbufferObject
	{
		// Token: 0x1700C3E5 RID: 50149
		// (get) Token: 0x0602DD6C RID: 187756 RVA: 0x00644B48 File Offset: 0x00642D48
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DD6D RID: 187757 RVA: 0x00644B55 File Offset: 0x00642D55
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DD6E RID: 187758 RVA: 0x00644B5C File Offset: 0x00642D5C
		public static IExecAlertSystemAction GetRootAsIExecAlertSystemAction(ByteBuffer _bb)
		{
			return IExecAlertSystemAction.GetRootAsIExecAlertSystemAction(_bb, default(IExecAlertSystemAction));
		}

		// Token: 0x0602DD6F RID: 187759 RVA: 0x00644B78 File Offset: 0x00642D78
		public static IExecAlertSystemAction GetRootAsIExecAlertSystemAction(ByteBuffer _bb, IExecAlertSystemAction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DD70 RID: 187760 RVA: 0x00644B95 File Offset: 0x00642D95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DD71 RID: 187761 RVA: 0x00644BA4 File Offset: 0x00642DA4
		public IExecAlertSystemAction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C3E6 RID: 50150
		// (get) Token: 0x0602DD72 RID: 187762 RVA: 0x00644BB4 File Offset: 0x00642DB4
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

		// Token: 0x0602DD73 RID: 187763 RVA: 0x00644BF0 File Offset: 0x00642DF0
		public TTable? Option<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602DD74 RID: 187764 RVA: 0x00644C34 File Offset: 0x00642E34
		public IEnableAlertArea OptionAsIEnableAlertArea()
		{
			return this.Option<IEnableAlertArea>().Value;
		}

		// Token: 0x0602DD75 RID: 187765 RVA: 0x00644C50 File Offset: 0x00642E50
		public IEnableAlertUi OptionAsIEnableAlertUi()
		{
			return this.Option<IEnableAlertUi>().Value;
		}

		// Token: 0x0602DD76 RID: 187766 RVA: 0x00644C6C File Offset: 0x00642E6C
		public IModifyAlertValue OptionAsIModifyAlertValue()
		{
			return this.Option<IModifyAlertValue>().Value;
		}

		// Token: 0x0602DD77 RID: 187767 RVA: 0x00644C88 File Offset: 0x00642E88
		public ISetAlertUiVisible OptionAsISetAlertUiVisible()
		{
			return this.Option<ISetAlertUiVisible>().Value;
		}

		// Token: 0x0602DD78 RID: 187768 RVA: 0x00644CA3 File Offset: 0x00642EA3
		public static Offset<IExecAlertSystemAction> CreateIExecAlertSystemAction(FlatBufferBuilder builder, TAlertSystemOption Option_type = TAlertSystemOption.NONE, int OptionOffset = 0)
		{
			builder.StartTable(2);
			IExecAlertSystemAction.AddOption(builder, OptionOffset);
			IExecAlertSystemAction.AddOptionType(builder, Option_type);
			return IExecAlertSystemAction.EndIExecAlertSystemAction(builder);
		}

		// Token: 0x0602DD79 RID: 187769 RVA: 0x00644CC0 File Offset: 0x00642EC0
		public static void StartIExecAlertSystemAction(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602DD7A RID: 187770 RVA: 0x00644CC9 File Offset: 0x00642EC9
		public static void AddOptionType(FlatBufferBuilder builder, TAlertSystemOption optionType)
		{
			builder.AddByte(0, (byte)optionType, 0);
		}

		// Token: 0x0602DD7B RID: 187771 RVA: 0x00644CD4 File Offset: 0x00642ED4
		public static void AddOption(FlatBufferBuilder builder, int optionOffset)
		{
			builder.AddOffset(1, optionOffset, 0);
		}

		// Token: 0x0602DD7C RID: 187772 RVA: 0x00644CDF File Offset: 0x00642EDF
		public static Offset<IExecAlertSystemAction> EndIExecAlertSystemAction(FlatBufferBuilder builder)
		{
			return new Offset<IExecAlertSystemAction>(builder.EndTable());
		}

		// Token: 0x0602DD7D RID: 187773 RVA: 0x00644CEC File Offset: 0x00642EEC
		public IExecAlertSystemActionT UnPack()
		{
			IExecAlertSystemActionT execAlertSystemActionT = new IExecAlertSystemActionT();
			this.UnPackTo(execAlertSystemActionT);
			return execAlertSystemActionT;
		}

		// Token: 0x0602DD7E RID: 187774 RVA: 0x00644D08 File Offset: 0x00642F08
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

		// Token: 0x0602DD7F RID: 187775 RVA: 0x00644E2C File Offset: 0x0064302C
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

		// Token: 0x04010DCE RID: 69070
		private Table __p;
	}
}
