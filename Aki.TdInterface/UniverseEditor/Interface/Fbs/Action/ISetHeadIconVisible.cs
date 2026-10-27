using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FFE RID: 28670
	public struct ISetHeadIconVisible : IFlatbufferObject
	{
		// Token: 0x1700D4F4 RID: 54516
		// (get) Token: 0x06032B5E RID: 207710 RVA: 0x006D79A8 File Offset: 0x006D5BA8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032B5F RID: 207711 RVA: 0x006D79B5 File Offset: 0x006D5BB5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032B60 RID: 207712 RVA: 0x006D79BC File Offset: 0x006D5BBC
		public static ISetHeadIconVisible GetRootAsISetHeadIconVisible(ByteBuffer _bb)
		{
			return ISetHeadIconVisible.GetRootAsISetHeadIconVisible(_bb, default(ISetHeadIconVisible));
		}

		// Token: 0x06032B61 RID: 207713 RVA: 0x006D79D8 File Offset: 0x006D5BD8
		public static ISetHeadIconVisible GetRootAsISetHeadIconVisible(ByteBuffer _bb, ISetHeadIconVisible obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032B62 RID: 207714 RVA: 0x006D79F5 File Offset: 0x006D5BF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032B63 RID: 207715 RVA: 0x006D7A04 File Offset: 0x006D5C04
		public ISetHeadIconVisible __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D4F5 RID: 54517
		// (get) Token: 0x06032B64 RID: 207716 RVA: 0x006D7A14 File Offset: 0x006D5C14
		public THeadStyle HeadStyleConfigType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return THeadStyle.NONE;
				}
				return (THeadStyle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032B65 RID: 207717 RVA: 0x006D7A50 File Offset: 0x006D5C50
		public TTable? HeadStyleConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06032B66 RID: 207718 RVA: 0x006D7A94 File Offset: 0x006D5C94
		public IHeadStyleMonsterDisplay HeadStyleConfigAsIHeadStyleMonsterDisplay()
		{
			return this.HeadStyleConfig<IHeadStyleMonsterDisplay>().Value;
		}

		// Token: 0x06032B67 RID: 207719 RVA: 0x006D7AB0 File Offset: 0x006D5CB0
		public IHeadStyleNormal HeadStyleConfigAsIHeadStyleNormal()
		{
			return this.HeadStyleConfig<IHeadStyleNormal>().Value;
		}

		// Token: 0x06032B68 RID: 207720 RVA: 0x006D7ACC File Offset: 0x006D5CCC
		public IHeadStyleVoiceOnly HeadStyleConfigAsIHeadStyleVoiceOnly()
		{
			return this.HeadStyleConfig<IHeadStyleVoiceOnly>().Value;
		}

		// Token: 0x06032B69 RID: 207721 RVA: 0x006D7AE8 File Offset: 0x006D5CE8
		public IHeadStyleWarning HeadStyleConfigAsIHeadStyleWarning()
		{
			return this.HeadStyleConfig<IHeadStyleWarning>().Value;
		}

		// Token: 0x06032B6A RID: 207722 RVA: 0x006D7B04 File Offset: 0x006D5D04
		public IHeadStyleWeakSignal HeadStyleConfigAsIHeadStyleWeakSignal()
		{
			return this.HeadStyleConfig<IHeadStyleWeakSignal>().Value;
		}

		// Token: 0x1700D4F6 RID: 54518
		// (get) Token: 0x06032B6B RID: 207723 RVA: 0x006D7B20 File Offset: 0x006D5D20
		public bool Visible
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06032B6C RID: 207724 RVA: 0x006D7B5F File Offset: 0x006D5D5F
		public static Offset<ISetHeadIconVisible> CreateISetHeadIconVisible(FlatBufferBuilder builder, THeadStyle HeadStyleConfig_type = THeadStyle.NONE, int HeadStyleConfigOffset = 0, bool Visible = false)
		{
			builder.StartTable(3);
			ISetHeadIconVisible.AddHeadStyleConfig(builder, HeadStyleConfigOffset);
			ISetHeadIconVisible.AddVisible(builder, Visible);
			ISetHeadIconVisible.AddHeadStyleConfigType(builder, HeadStyleConfig_type);
			return ISetHeadIconVisible.EndISetHeadIconVisible(builder);
		}

		// Token: 0x06032B6D RID: 207725 RVA: 0x006D7B83 File Offset: 0x006D5D83
		public static void StartISetHeadIconVisible(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06032B6E RID: 207726 RVA: 0x006D7B8C File Offset: 0x006D5D8C
		public static void AddHeadStyleConfigType(FlatBufferBuilder builder, THeadStyle headStyleConfigType)
		{
			builder.AddByte(0, (byte)headStyleConfigType, 0);
		}

		// Token: 0x06032B6F RID: 207727 RVA: 0x006D7B97 File Offset: 0x006D5D97
		public static void AddHeadStyleConfig(FlatBufferBuilder builder, int headStyleConfigOffset)
		{
			builder.AddOffset(1, headStyleConfigOffset, 0);
		}

		// Token: 0x06032B70 RID: 207728 RVA: 0x006D7BA2 File Offset: 0x006D5DA2
		public static void AddVisible(FlatBufferBuilder builder, bool visible)
		{
			builder.AddBool(2, visible, false);
		}

		// Token: 0x06032B71 RID: 207729 RVA: 0x006D7BAD File Offset: 0x006D5DAD
		public static Offset<ISetHeadIconVisible> EndISetHeadIconVisible(FlatBufferBuilder builder)
		{
			return new Offset<ISetHeadIconVisible>(builder.EndTable());
		}

		// Token: 0x06032B72 RID: 207730 RVA: 0x006D7BBC File Offset: 0x006D5DBC
		public ISetHeadIconVisibleT UnPack()
		{
			ISetHeadIconVisibleT setHeadIconVisibleT = new ISetHeadIconVisibleT();
			this.UnPackTo(setHeadIconVisibleT);
			return setHeadIconVisibleT;
		}

		// Token: 0x06032B73 RID: 207731 RVA: 0x006D7BD8 File Offset: 0x006D5DD8
		public void UnPackTo(ISetHeadIconVisibleT _o)
		{
			_o.HeadStyleConfig = new THeadStyleUnion();
			_o.HeadStyleConfig.Type = this.HeadStyleConfigType;
			switch (this.HeadStyleConfigType)
			{
			case THeadStyle.IHeadStyleMonsterDisplay:
				_o.HeadStyleConfig.Value = ((this.HeadStyleConfig<IHeadStyleMonsterDisplay>() != null) ? this.HeadStyleConfig<IHeadStyleMonsterDisplay>().Value.UnPack() : null);
				break;
			case THeadStyle.IHeadStyleNormal:
				_o.HeadStyleConfig.Value = ((this.HeadStyleConfig<IHeadStyleNormal>() != null) ? this.HeadStyleConfig<IHeadStyleNormal>().Value.UnPack() : null);
				break;
			case THeadStyle.IHeadStyleVoiceOnly:
				_o.HeadStyleConfig.Value = ((this.HeadStyleConfig<IHeadStyleVoiceOnly>() != null) ? this.HeadStyleConfig<IHeadStyleVoiceOnly>().Value.UnPack() : null);
				break;
			case THeadStyle.IHeadStyleWarning:
				_o.HeadStyleConfig.Value = ((this.HeadStyleConfig<IHeadStyleWarning>() != null) ? this.HeadStyleConfig<IHeadStyleWarning>().Value.UnPack() : null);
				break;
			case THeadStyle.IHeadStyleWeakSignal:
				_o.HeadStyleConfig.Value = ((this.HeadStyleConfig<IHeadStyleWeakSignal>() != null) ? this.HeadStyleConfig<IHeadStyleWeakSignal>().Value.UnPack() : null);
				break;
			}
			_o.Visible = this.Visible;
		}

		// Token: 0x06032B74 RID: 207732 RVA: 0x006D7D54 File Offset: 0x006D5F54
		public static Offset<ISetHeadIconVisible> Pack(FlatBufferBuilder builder, ISetHeadIconVisibleT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetHeadIconVisible>);
			}
			THeadStyle headStyleConfig_type = (_o.HeadStyleConfig == null) ? THeadStyle.NONE : _o.HeadStyleConfig.Type;
			int headStyleConfigOffset = (_o.HeadStyleConfig == null) ? 0 : THeadStyleUnion.Pack(builder, _o.HeadStyleConfig);
			return ISetHeadIconVisible.CreateISetHeadIconVisible(builder, headStyleConfig_type, headStyleConfigOffset, _o.Visible);
		}

		// Token: 0x04011A22 RID: 72226
		private Table __p;
	}
}
