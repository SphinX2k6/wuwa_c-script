using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004ECF RID: 20175
	public class IAudioControlType_UnionUnion
	{
		// Token: 0x170090D3 RID: 37075
		// (get) Token: 0x0601FCB5 RID: 130229 RVA: 0x0046CEC1 File Offset: 0x0046B0C1
		// (set) Token: 0x0601FCB6 RID: 130230 RVA: 0x0046CEC9 File Offset: 0x0046B0C9
		public IAudioControlType_Union Type { get; set; }

		// Token: 0x170090D4 RID: 37076
		// (get) Token: 0x0601FCB7 RID: 130231 RVA: 0x0046CED2 File Offset: 0x0046B0D2
		// (set) Token: 0x0601FCB8 RID: 130232 RVA: 0x0046CEDA File Offset: 0x0046B0DA
		public object Value { get; set; }

		// Token: 0x0601FCB9 RID: 130233 RVA: 0x0046CEE3 File Offset: 0x0046B0E3
		public IAudioControlType_UnionUnion()
		{
			this.Type = IAudioControlType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601FCBA RID: 130234 RVA: 0x0046CEF9 File Offset: 0x0046B0F9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601FCBB RID: 130235 RVA: 0x0046CF0B File Offset: 0x0046B10B
		public IAudioControlTypeT AsIAudioControlType()
		{
			return this.As<IAudioControlTypeT>();
		}

		// Token: 0x0601FCBC RID: 130236 RVA: 0x0046CF13 File Offset: 0x0046B113
		public static IAudioControlType_UnionUnion FromIAudioControlType(IAudioControlTypeT _iaudiocontroltype)
		{
			return new IAudioControlType_UnionUnion
			{
				Type = IAudioControlType_Union.IAudioControlType,
				Value = _iaudiocontroltype
			};
		}

		// Token: 0x0601FCBD RID: 130237 RVA: 0x0046CF28 File Offset: 0x0046B128
		public IGramophoneAudioControlT AsIGramophoneAudioControl()
		{
			return this.As<IGramophoneAudioControlT>();
		}

		// Token: 0x0601FCBE RID: 130238 RVA: 0x0046CF30 File Offset: 0x0046B130
		public static IAudioControlType_UnionUnion FromIGramophoneAudioControl(IGramophoneAudioControlT _igramophoneaudiocontrol)
		{
			return new IAudioControlType_UnionUnion
			{
				Type = IAudioControlType_Union.IGramophoneAudioControl,
				Value = _igramophoneaudiocontrol
			};
		}

		// Token: 0x0601FCBF RID: 130239 RVA: 0x0046CF45 File Offset: 0x0046B145
		public ITrafficAudioControlT AsITrafficAudioControl()
		{
			return this.As<ITrafficAudioControlT>();
		}

		// Token: 0x0601FCC0 RID: 130240 RVA: 0x0046CF4D File Offset: 0x0046B14D
		public static IAudioControlType_UnionUnion FromITrafficAudioControl(ITrafficAudioControlT _itrafficaudiocontrol)
		{
			return new IAudioControlType_UnionUnion
			{
				Type = IAudioControlType_Union.ITrafficAudioControl,
				Value = _itrafficaudiocontrol
			};
		}

		// Token: 0x0601FCC1 RID: 130241 RVA: 0x0046CF64 File Offset: 0x0046B164
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
