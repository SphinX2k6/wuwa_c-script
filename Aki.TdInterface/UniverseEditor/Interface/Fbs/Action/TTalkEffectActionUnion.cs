using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077C3 RID: 30659
	public class TTalkEffectActionUnion
	{
		// Token: 0x1700E6C5 RID: 59077
		// (get) Token: 0x060379EE RID: 227822 RVA: 0x00785E28 File Offset: 0x00784028
		// (set) Token: 0x060379EF RID: 227823 RVA: 0x00785E30 File Offset: 0x00784030
		public TTalkEffectAction Type { get; set; }

		// Token: 0x1700E6C6 RID: 59078
		// (get) Token: 0x060379F0 RID: 227824 RVA: 0x00785E39 File Offset: 0x00784039
		// (set) Token: 0x060379F1 RID: 227825 RVA: 0x00785E41 File Offset: 0x00784041
		public object Value { get; set; }

		// Token: 0x060379F2 RID: 227826 RVA: 0x00785E4A File Offset: 0x0078404A
		public TTalkEffectActionUnion()
		{
			this.Type = TTalkEffectAction.NONE;
			this.Value = null;
		}

		// Token: 0x060379F3 RID: 227827 RVA: 0x00785E60 File Offset: 0x00784060
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060379F4 RID: 227828 RVA: 0x00785E72 File Offset: 0x00784072
		public ITalkEffectPlayT AsITalkEffectPlay()
		{
			return this.As<ITalkEffectPlayT>();
		}

		// Token: 0x060379F5 RID: 227829 RVA: 0x00785E7A File Offset: 0x0078407A
		public static TTalkEffectActionUnion FromITalkEffectPlay(ITalkEffectPlayT _italkeffectplay)
		{
			return new TTalkEffectActionUnion
			{
				Type = TTalkEffectAction.ITalkEffectPlay,
				Value = _italkeffectplay
			};
		}

		// Token: 0x060379F6 RID: 227830 RVA: 0x00785E8F File Offset: 0x0078408F
		public ITalkEffectStopT AsITalkEffectStop()
		{
			return this.As<ITalkEffectStopT>();
		}

		// Token: 0x060379F7 RID: 227831 RVA: 0x00785E97 File Offset: 0x00784097
		public static TTalkEffectActionUnion FromITalkEffectStop(ITalkEffectStopT _italkeffectstop)
		{
			return new TTalkEffectActionUnion
			{
				Type = TTalkEffectAction.ITalkEffectStop,
				Value = _italkeffectstop
			};
		}

		// Token: 0x060379F8 RID: 227832 RVA: 0x00785EAC File Offset: 0x007840AC
		public static int Pack(FlatBufferBuilder builder, TTalkEffectActionUnion _o)
		{
			TTalkEffectAction type = _o.Type;
			if (type == TTalkEffectAction.ITalkEffectPlay)
			{
				return ITalkEffectPlay.Pack(builder, _o.AsITalkEffectPlay()).Value;
			}
			if (type != TTalkEffectAction.ITalkEffectStop)
			{
				return 0;
			}
			return ITalkEffectStop.Pack(builder, _o.AsITalkEffectStop()).Value;
		}
	}
}
