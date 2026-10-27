using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BEF RID: 23535
	public class TAudioControlTypeUnion
	{
		// Token: 0x1700B1C9 RID: 45513
		// (get) Token: 0x0602853D RID: 165181 RVA: 0x0058A552 File Offset: 0x00588752
		// (set) Token: 0x0602853E RID: 165182 RVA: 0x0058A55A File Offset: 0x0058875A
		public TAudioControlType Type { get; set; }

		// Token: 0x1700B1CA RID: 45514
		// (get) Token: 0x0602853F RID: 165183 RVA: 0x0058A563 File Offset: 0x00588763
		// (set) Token: 0x06028540 RID: 165184 RVA: 0x0058A56B File Offset: 0x0058876B
		public object Value { get; set; }

		// Token: 0x06028541 RID: 165185 RVA: 0x0058A574 File Offset: 0x00588774
		public TAudioControlTypeUnion()
		{
			this.Type = TAudioControlType.NONE;
			this.Value = null;
		}

		// Token: 0x06028542 RID: 165186 RVA: 0x0058A58A File Offset: 0x0058878A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06028543 RID: 165187 RVA: 0x0058A59C File Offset: 0x0058879C
		public IGramophoneAudioControlT AsIGramophoneAudioControl()
		{
			return this.As<IGramophoneAudioControlT>();
		}

		// Token: 0x06028544 RID: 165188 RVA: 0x0058A5A4 File Offset: 0x005887A4
		public static TAudioControlTypeUnion FromIGramophoneAudioControl(IGramophoneAudioControlT _igramophoneaudiocontrol)
		{
			return new TAudioControlTypeUnion
			{
				Type = TAudioControlType.IGramophoneAudioControl,
				Value = _igramophoneaudiocontrol
			};
		}

		// Token: 0x06028545 RID: 165189 RVA: 0x0058A5B9 File Offset: 0x005887B9
		public ITrafficAudioControlT AsITrafficAudioControl()
		{
			return this.As<ITrafficAudioControlT>();
		}

		// Token: 0x06028546 RID: 165190 RVA: 0x0058A5C1 File Offset: 0x005887C1
		public static TAudioControlTypeUnion FromITrafficAudioControl(ITrafficAudioControlT _itrafficaudiocontrol)
		{
			return new TAudioControlTypeUnion
			{
				Type = TAudioControlType.ITrafficAudioControl,
				Value = _itrafficaudiocontrol
			};
		}

		// Token: 0x06028547 RID: 165191 RVA: 0x0058A5D8 File Offset: 0x005887D8
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
