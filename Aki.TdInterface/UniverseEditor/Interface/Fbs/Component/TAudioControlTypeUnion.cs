using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006208 RID: 25096
	public class TAudioControlTypeUnion
	{
		// Token: 0x1700BB13 RID: 47891
		// (get) Token: 0x0602AB0F RID: 174863 RVA: 0x005D2130 File Offset: 0x005D0330
		// (set) Token: 0x0602AB10 RID: 174864 RVA: 0x005D2138 File Offset: 0x005D0338
		public TAudioControlType Type { get; set; }

		// Token: 0x1700BB14 RID: 47892
		// (get) Token: 0x0602AB11 RID: 174865 RVA: 0x005D2141 File Offset: 0x005D0341
		// (set) Token: 0x0602AB12 RID: 174866 RVA: 0x005D2149 File Offset: 0x005D0349
		public object Value { get; set; }

		// Token: 0x0602AB13 RID: 174867 RVA: 0x005D2152 File Offset: 0x005D0352
		public TAudioControlTypeUnion()
		{
			this.Type = TAudioControlType.NONE;
			this.Value = null;
		}

		// Token: 0x0602AB14 RID: 174868 RVA: 0x005D2168 File Offset: 0x005D0368
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AB15 RID: 174869 RVA: 0x005D217A File Offset: 0x005D037A
		public IGramophoneAudioControlT AsIGramophoneAudioControl()
		{
			return this.As<IGramophoneAudioControlT>();
		}

		// Token: 0x0602AB16 RID: 174870 RVA: 0x005D2182 File Offset: 0x005D0382
		public static TAudioControlTypeUnion FromIGramophoneAudioControl(IGramophoneAudioControlT _igramophoneaudiocontrol)
		{
			return new TAudioControlTypeUnion
			{
				Type = TAudioControlType.IGramophoneAudioControl,
				Value = _igramophoneaudiocontrol
			};
		}

		// Token: 0x0602AB17 RID: 174871 RVA: 0x005D2197 File Offset: 0x005D0397
		public ITrafficAudioControlT AsITrafficAudioControl()
		{
			return this.As<ITrafficAudioControlT>();
		}

		// Token: 0x0602AB18 RID: 174872 RVA: 0x005D219F File Offset: 0x005D039F
		public static TAudioControlTypeUnion FromITrafficAudioControl(ITrafficAudioControlT _itrafficaudiocontrol)
		{
			return new TAudioControlTypeUnion
			{
				Type = TAudioControlType.ITrafficAudioControl,
				Value = _itrafficaudiocontrol
			};
		}

		// Token: 0x0602AB19 RID: 174873 RVA: 0x005D21B4 File Offset: 0x005D03B4
		public static int Pack(FlatBufferBuilder builder, TAudioControlTypeUnion _o)
		{
			TAudioControlType type = _o.Type;
			if (type == TAudioControlType.IGramophoneAudioControl)
			{
				return IGramophoneAudioControl.Pack(builder, _o.AsIGramophoneAudioControl()).Value;
			}
			if (type != TAudioControlType.ITrafficAudioControl)
			{
				return 0;
			}
			return ITrafficAudioControl.Pack(builder, _o.AsITrafficAudioControl()).Value;
		}
	}
}
