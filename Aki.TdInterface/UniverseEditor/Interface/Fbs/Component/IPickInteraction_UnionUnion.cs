using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200573D RID: 22333
	public class IPickInteraction_UnionUnion
	{
		// Token: 0x1700A67D RID: 42621
		// (get) Token: 0x06025653 RID: 153171 RVA: 0x00528F92 File Offset: 0x00527192
		// (set) Token: 0x06025654 RID: 153172 RVA: 0x00528F9A File Offset: 0x0052719A
		public IPickInteraction_Union Type { get; set; }

		// Token: 0x1700A67E RID: 42622
		// (get) Token: 0x06025655 RID: 153173 RVA: 0x00528FA3 File Offset: 0x005271A3
		// (set) Token: 0x06025656 RID: 153174 RVA: 0x00528FAB File Offset: 0x005271AB
		public object Value { get; set; }

		// Token: 0x06025657 RID: 153175 RVA: 0x00528FB4 File Offset: 0x005271B4
		public IPickInteraction_UnionUnion()
		{
			this.Type = IPickInteraction_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06025658 RID: 153176 RVA: 0x00528FCA File Offset: 0x005271CA
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06025659 RID: 153177 RVA: 0x00528FDC File Offset: 0x005271DC
		public IPickInteractionT AsIPickInteraction()
		{
			return this.As<IPickInteractionT>();
		}

		// Token: 0x0602565A RID: 153178 RVA: 0x00528FE4 File Offset: 0x005271E4
		public static IPickInteraction_UnionUnion FromIPickInteraction(IPickInteractionT _ipickinteraction)
		{
			return new IPickInteraction_UnionUnion
			{
				Type = IPickInteraction_Union.IPickInteraction,
				Value = _ipickinteraction
			};
		}

		// Token: 0x0602565B RID: 153179 RVA: 0x00528FF9 File Offset: 0x005271F9
		public IChessmanPickInteractionT AsIChessmanPickInteraction()
		{
			return this.As<IChessmanPickInteractionT>();
		}

		// Token: 0x0602565C RID: 153180 RVA: 0x00529001 File Offset: 0x00527201
		public static IPickInteraction_UnionUnion FromIChessmanPickInteraction(IChessmanPickInteractionT _ichessmanpickinteraction)
		{
			return new IPickInteraction_UnionUnion
			{
				Type = IPickInteraction_Union.IChessmanPickInteraction,
				Value = _ichessmanpickinteraction
			};
		}

		// Token: 0x0602565D RID: 153181 RVA: 0x00529018 File Offset: 0x00527218
		public static int Pack(FlatBufferBuilder builder, IPickInteraction_UnionUnion _o)
		{
			IPickInteraction_Union type = _o.Type;
			if (type == IPickInteraction_Union.IPickInteraction)
			{
				return IPickInteraction.Pack(builder, _o.AsIPickInteraction()).Value;
			}
			if (type != IPickInteraction_Union.IChessmanPickInteraction)
			{
				return 0;
			}
			return IChessmanPickInteraction.Pack(builder, _o.AsIChessmanPickInteraction()).Value;
		}
	}
}
