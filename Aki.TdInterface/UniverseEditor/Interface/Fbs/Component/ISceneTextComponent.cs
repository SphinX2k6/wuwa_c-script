using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058D9 RID: 22745
	public struct ISceneTextComponent : IFlatbufferObject
	{
		// Token: 0x1700AA57 RID: 43607
		// (get) Token: 0x06026658 RID: 157272 RVA: 0x0054A9C5 File Offset: 0x00548BC5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026659 RID: 157273 RVA: 0x0054A9D2 File Offset: 0x00548BD2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602665A RID: 157274 RVA: 0x0054A9DC File Offset: 0x00548BDC
		public static ISceneTextComponent GetRootAsISceneTextComponent(ByteBuffer _bb)
		{
			return ISceneTextComponent.GetRootAsISceneTextComponent(_bb, default(ISceneTextComponent));
		}

		// Token: 0x0602665B RID: 157275 RVA: 0x0054A9F8 File Offset: 0x00548BF8
		public static ISceneTextComponent GetRootAsISceneTextComponent(ByteBuffer _bb, ISceneTextComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602665C RID: 157276 RVA: 0x0054AA15 File Offset: 0x00548C15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602665D RID: 157277 RVA: 0x0054AA24 File Offset: 0x00548C24
		public ISceneTextComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AA58 RID: 43608
		// (get) Token: 0x0602665E RID: 157278 RVA: 0x0054AA34 File Offset: 0x00548C34
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AA59 RID: 43609
		// (get) Token: 0x0602665F RID: 157279 RVA: 0x0054AA74 File Offset: 0x00548C74
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

		// Token: 0x06026660 RID: 157280 RVA: 0x0054AAAB File Offset: 0x00548CAB
		public Span<byte> GetDisplayStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06026661 RID: 157281 RVA: 0x0054AABA File Offset: 0x00548CBA
		public byte[] GetDisplayStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700AA5A RID: 43610
		// (get) Token: 0x06026662 RID: 157282 RVA: 0x0054AAC8 File Offset: 0x00548CC8
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

		// Token: 0x1700AA5B RID: 43611
		// (get) Token: 0x06026663 RID: 157283 RVA: 0x0054AB28 File Offset: 0x00548D28
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

		// Token: 0x06026664 RID: 157284 RVA: 0x0054AB68 File Offset: 0x00548D68
		public TTable? TextConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06026665 RID: 157285 RVA: 0x0054ABB0 File Offset: 0x00548DB0
		public ISceneTextGuideUi TextConfigAsISceneTextGuideUi()
		{
			return this.TextConfig<ISceneTextGuideUi>().Value;
		}

		// Token: 0x06026666 RID: 157286 RVA: 0x0054ABCC File Offset: 0x00548DCC
		public ISceneTextSubtitleWithVoice TextConfigAsISceneTextSubtitleWithVoice()
		{
			return this.TextConfig<ISceneTextSubtitleWithVoice>().Value;
		}

		// Token: 0x1700AA5C RID: 43612
		// (get) Token: 0x06026667 RID: 157287 RVA: 0x0054ABE8 File Offset: 0x00548DE8
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

		// Token: 0x06026668 RID: 157288 RVA: 0x0054AC25 File Offset: 0x00548E25
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

		// Token: 0x06026669 RID: 157289 RVA: 0x0054AC61 File Offset: 0x00548E61
		public static void StartISceneTextComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602666A RID: 157290 RVA: 0x0054AC6A File Offset: 0x00548E6A
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602666B RID: 157291 RVA: 0x0054AC75 File Offset: 0x00548E75
		public static void AddDisplayState(FlatBufferBuilder builder, StringOffset displayStateOffset)
		{
			builder.AddOffset(1, displayStateOffset.Value, 0);
		}

		// Token: 0x0602666C RID: 157292 RVA: 0x0054AC85 File Offset: 0x00548E85
		public static void AddRelativeTransform(FlatBufferBuilder builder, Offset<IPosAndRot> relativeTransformOffset)
		{
			builder.AddOffset(2, relativeTransformOffset.Value, 0);
		}

		// Token: 0x0602666D RID: 157293 RVA: 0x0054AC95 File Offset: 0x00548E95
		public static void AddTextConfigType(FlatBufferBuilder builder, TSceneText textConfigType)
		{
			builder.AddByte(3, (byte)textConfigType, 0);
		}

		// Token: 0x0602666E RID: 157294 RVA: 0x0054ACA0 File Offset: 0x00548EA0
		public static void AddTextConfig(FlatBufferBuilder builder, int textConfigOffset)
		{
			builder.AddOffset(4, textConfigOffset, 0);
		}

		// Token: 0x0602666F RID: 157295 RVA: 0x0054ACAB File Offset: 0x00548EAB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06026670 RID: 157296 RVA: 0x0054ACB6 File Offset: 0x00548EB6
		public static Offset<ISceneTextComponent> EndISceneTextComponent(FlatBufferBuilder builder)
		{
			return new Offset<ISceneTextComponent>(builder.EndTable());
		}

		// Token: 0x06026671 RID: 157297 RVA: 0x0054ACC4 File Offset: 0x00548EC4
		public ISceneTextComponentT UnPack()
		{
			ISceneTextComponentT sceneTextComponentT = new ISceneTextComponentT();
			this.UnPackTo(sceneTextComponentT);
			return sceneTextComponentT;
		}

		// Token: 0x06026672 RID: 157298 RVA: 0x0054ACE0 File Offset: 0x00548EE0
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

		// Token: 0x06026673 RID: 157299 RVA: 0x0054ADDC File Offset: 0x00548FDC
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

		// Token: 0x0400EE5C RID: 61020
		private Table __p;
	}
}
