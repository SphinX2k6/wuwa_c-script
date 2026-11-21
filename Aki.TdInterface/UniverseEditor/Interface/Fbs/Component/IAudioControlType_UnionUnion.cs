using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053FE RID: 21502
	public class IAudioControlType_UnionUnion
	{
		// Token: 0x17009846 RID: 38982
		// (get) Token: 0x060219F9 RID: 137721 RVA: 0x004A2C91 File Offset: 0x004A0E91
		// (set) Token: 0x060219FA RID: 137722 RVA: 0x004A2C99 File Offset: 0x004A0E99
		public IAudioControlType_Union Type { get; set; }

		// Token: 0x17009847 RID: 38983
		// (get) Token: 0x060219FB RID: 137723 RVA: 0x004A2CA2 File Offset: 0x004A0EA2
		// (set) Token: 0x060219FC RID: 137724 RVA: 0x004A2CAA File Offset: 0x004A0EAA
		public object Value { get; set; }

		// Token: 0x060219FD RID: 137725 RVA: 0x004A2CB3 File Offset: 0x004A0EB3
		public IAudioControlType_UnionUnion()
		{
			this.Type = IAudioControlType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060219FE RID: 137726 RVA: 0x004A2CC9 File Offset: 0x004A0EC9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060219FF RID: 137727 RVA: 0x004A2CDB File Offset: 0x004A0EDB
		public IAudioControlTypeT AsIAudioControlType()
		{
			return this.As<IAudioControlTypeT>();
		}

		// Token: 0x06021A00 RID: 137728 RVA: 0x004A2CE3 File Offset: 0x004A0EE3
		public static IAudioControlType_UnionUnion FromIAudioControlType(IAudioControlTypeT _iaudiocontroltype)
		{
			return new IAudioControlType_UnionUnion
			{
				Type = IAudioControlType_Union.IAudioControlType,
				Value = _iaudiocontroltype
			};
		}

		// Token: 0x06021A01 RID: 137729 RVA: 0x004A2CF8 File Offset: 0x004A0EF8
		public IGramophoneAudioControlT AsIGramophoneAudioControl()
		{
			return this.As<IGramophoneAudioControlT>();
		}

		// Token: 0x06021A02 RID: 137730 RVA: 0x004A2D00 File Offset: 0x004A0F00
		public static IAudioControlType_UnionUnion FromIGramophoneAudioControl(IGramophoneAudioControlT _igramophoneaudiocontrol)
		{
			return new IAudioControlType_UnionUnion
			{
				Type = IAudioControlType_Union.IGramophoneAudioControl,
				Value = _igramophoneaudiocontrol
			};
		}

		// Token: 0x06021A03 RID: 137731 RVA: 0x004A2D15 File Offset: 0x004A0F15
		public ITrafficAudioControlT AsITrafficAudioControl()
		{
			return this.As<ITrafficAudioControlT>();
		}

		// Token: 0x06021A04 RID: 137732 RVA: 0x004A2D1D File Offset: 0x004A0F1D
		public static IAudioControlType_UnionUnion FromITrafficAudioControl(ITrafficAudioControlT _itrafficaudiocontrol)
		{
			return new IAudioControlType_UnionUnion
			{
				Type = IAudioControlType_Union.ITrafficAudioControl,
				Value = _itrafficaudiocontrol
			};
		}

		// Token: 0x06021A05 RID: 137733 RVA: 0x004A2D34 File Offset: 0x004A0F34
		public static int Pack(FlatBufferBuilder builder, IAudioControlType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IAudioControlType_Union.IAudioControlType:
				return IAudioControlType.Pack(builder, _o.AsIAudioControlType()).Value;
			case IAudioControlType_Union.IGramophoneAudioControl:
				return IGramophoneAudioControl.Pack(builder, _o.AsIGramophoneAudioControl()).Value;
			case IAudioControlType_Union.ITrafficAudioControl:
				return ITrafficAudioControl.Pack(builder, _o.AsITrafficAudioControl()).Value;
			default:
				return 0;
			}
		}
	}
}
