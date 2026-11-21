using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EE6 RID: 24294
	public struct ISceneTextComponent : IFlatbufferObject
	{
		// Token: 0x1700B387 RID: 45959
		// (get) Token: 0x06028BBA RID: 166842 RVA: 0x00591511 File Offset: 0x0058F711
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028BBB RID: 166843 RVA: 0x0059151E File Offset: 0x0058F71E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028BBC RID: 166844 RVA: 0x00591528 File Offset: 0x0058F728
		public static ISceneTextComponent GetRootAsISceneTextComponent(ByteBuffer _bb)
		{
			return ISceneTextComponent.GetRootAsISceneTextComponent(_bb, default(ISceneTextComponent));
		}

		// Token: 0x06028BBD RID: 166845 RVA: 0x00591544 File Offset: 0x0058F744
		public static ISceneTextComponent GetRootAsISceneTextComponent(ByteBuffer _bb, ISceneTextComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028BBE RID: 166846 RVA: 0x00591561 File Offset: 0x0058F761
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028BBF RID: 166847 RVA: 0x00591570 File Offset: 0x0058F770
		public ISceneTextComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B388 RID: 45960
		// (get) Token: 0x06028BC0 RID: 166848 RVA: 0x00591580 File Offset: 0x0058F780
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B389 RID: 45961
		// (get) Token: 0x06028BC1 RID: 166849 RVA: 0x005915C0 File Offset: 0x0058F7C0
		public string DisplayState
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028BC2 RID: 166850 RVA: 0x005915F7 File Offset: 0x0058F7F7
		public Span<byte> GetDisplayStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06028BC3 RID: 166851 RVA: 0x00591606 File Offset: 0x0058F806
		public byte[] GetDisplayStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700B38A RID: 45962
		// (get) Token: 0x06028BC4 RID: 166852 RVA: 0x00591614 File Offset: 0x0058F814
		public IPosAndRot? RelativeTransform
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IPosAndRot?(default(IPosAndRot).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B38B RID: 45963
		// (get) Token: 0x06028BC5 RID: 166853 RVA: 0x00591674 File Offset: 0x0058F874
		public TSceneText TextConfigType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return TSceneText.NONE;
				}
				return (TSceneText)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028BC6 RID: 166854 RVA: 0x005916B4 File Offset: 0x0058F8B4
		public TTable? TextConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06028BC7 RID: 166855 RVA: 0x005916FC File Offset: 0x0058F8FC
		public ISceneTextGuideUi TextConfigAsISceneTextGuideUi()
		{
			return this.TextConfig<ISceneTextGuideUi>().Value;
		}

		// Token: 0x06028BC8 RID: 166856 RVA: 0x00591718 File Offset: 0x0058F918
		public ISceneTextSubtitleWithVoice TextConfigAsISceneTextSubtitleWithVoice()
		{
			return this.TextConfig<ISceneTextSubtitleWithVoice>().Value;
		}

		// Token: 0x1700B38C RID: 45964
		// (get) Token: 0x06028BC9 RID: 166857 RVA: 0x00591734 File Offset: 0x0058F934
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028BCA RID: 166858 RVA: 0x00591771 File Offset: 0x0058F971
		public static Offset<ISceneTextComponent> CreateISceneTextComponent(FlatBufferBuilder builder, bool Disabled = false, StringOffset DisplayStateOffset = default(StringOffset), Offset<IPosAndRot> RelativeTransformOffset = default(Offset<IPosAndRot>), TSceneText TextConfig_type = TSceneText.NONE, int TextConfigOffset = 0, byte NullMask = 0)
		{
			builder.StartTable(6);
			ISceneTextComponent.AddTextConfig(builder, TextConfigOffset);
			ISceneTextComponent.AddRelativeTransform(builder, RelativeTransformOffset);
			ISceneTextComponent.AddDisplayState(builder, DisplayStateOffset);
			ISceneTextComponent.AddNullMask(builder, NullMask);
			ISceneTextComponent.AddTextConfigType(builder, TextConfig_type);
			ISceneTextComponent.AddDisabled(builder, Disabled);
			return ISceneTextComponent.EndISceneTextComponent(builder);
		}

		// Token: 0x06028BCB RID: 166859 RVA: 0x005917AD File Offset: 0x0058F9AD
		public static void StartISceneTextComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06028BCC RID: 166860 RVA: 0x005917B6 File Offset: 0x0058F9B6
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06028BCD RID: 166861 RVA: 0x005917C1 File Offset: 0x0058F9C1
		public static void AddDisplayState(FlatBufferBuilder builder, StringOffset displayStateOffset)
		{
			builder.AddOffset(1, displayStateOffset.Value, 0);
		}

		// Token: 0x06028BCE RID: 166862 RVA: 0x005917D1 File Offset: 0x0058F9D1
		public static void AddRelativeTransform(FlatBufferBuilder builder, Offset<IPosAndRot> relativeTransformOffset)
		{
			builder.AddOffset(2, relativeTransformOffset.Value, 0);
		}

		// Token: 0x06028BCF RID: 166863 RVA: 0x005917E1 File Offset: 0x0058F9E1
		public static void AddTextConfigType(FlatBufferBuilder builder, TSceneText textConfigType)
		{
			builder.AddByte(3, (byte)textConfigType, 0);
		}

		// Token: 0x06028BD0 RID: 166864 RVA: 0x005917EC File Offset: 0x0058F9EC
		public static void AddTextConfig(FlatBufferBuilder builder, int textConfigOffset)
		{
			builder.AddOffset(4, textConfigOffset, 0);
		}

		// Token: 0x06028BD1 RID: 166865 RVA: 0x005917F7 File Offset: 0x0058F9F7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06028BD2 RID: 166866 RVA: 0x00591802 File Offset: 0x0058FA02
		public static Offset<ISceneTextComponent> EndISceneTextComponent(FlatBufferBuilder builder)
		{
			return new Offset<ISceneTextComponent>(builder.EndTable());
		}

		// Token: 0x06028BD3 RID: 166867 RVA: 0x00591810 File Offset: 0x0058FA10
		public ISceneTextComponentT UnPack()
		{
			ISceneTextComponentT sceneTextComponentT = new ISceneTextComponentT();
			this.UnPackTo(sceneTextComponentT);
			return sceneTextComponentT;
		}

		// Token: 0x06028BD4 RID: 166868 RVA: 0x0059182C File Offset: 0x0058FA2C
		public void UnPackTo(ISceneTextComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.DisplayState = this.DisplayState;
			_o.RelativeTransform = ((this.RelativeTransform != null) ? this.RelativeTransform.Value.UnPack() : null);
			_o.TextConfig = new TSceneTextUnion();
			_o.TextConfig.Type = this.TextConfigType;
			TSceneText textConfigType = this.TextConfigType;
			if (textConfigType != TSceneText.ISceneTextGuideUi)
			{
				if (textConfigType == TSceneText.ISceneTextSubtitleWithVoice)
				{
					_o.TextConfig.Value = ((this.TextConfig<ISceneTextSubtitleWithVoice>() != null) ? this.TextConfig<ISceneTextSubtitleWithVoice>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.TextConfig.Value = ((this.TextConfig<ISceneTextGuideUi>() != null) ? this.TextConfig<ISceneTextGuideUi>().Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06028BD5 RID: 166869 RVA: 0x00591928 File Offset: 0x0058FB28
		public static Offset<ISceneTextComponent> Pack(FlatBufferBuilder builder, ISceneTextComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneTextComponent>);
			}
			StringOffset displayStateOffset = (_o.DisplayState == null) ? default(StringOffset) : builder.CreateString(_o.DisplayState);
			Offset<IPosAndRot> relativeTransformOffset = (_o.RelativeTransform == null) ? default(Offset<IPosAndRot>) : IPosAndRot.Pack(builder, _o.RelativeTransform);
			TSceneText textConfig_type = (_o.TextConfig == null) ? TSceneText.NONE : _o.TextConfig.Type;
			int textConfigOffset = (_o.TextConfig == null) ? 0 : TSceneTextUnion.Pack(builder, _o.TextConfig);
			return ISceneTextComponent.CreateISceneTextComponent(builder, _o.Disabled, displayStateOffset, relativeTransformOffset, textConfig_type, textConfigOffset, _o.NullMask);
		}

		// Token: 0x0400FB4F RID: 64335
		private Table __p;
	}
}
