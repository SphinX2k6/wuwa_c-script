using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D44 RID: 23876
	public class IPickInteraction_UnionUnion
	{
		// Token: 0x1700AFA1 RID: 44961
		// (get) Token: 0x06027B73 RID: 162675 RVA: 0x0056F11E File Offset: 0x0056D31E
		// (set) Token: 0x06027B74 RID: 162676 RVA: 0x0056F126 File Offset: 0x0056D326
		public IPickInteraction_Union Type { get; set; }

		// Token: 0x1700AFA2 RID: 44962
		// (get) Token: 0x06027B75 RID: 162677 RVA: 0x0056F12F File Offset: 0x0056D32F
		// (set) Token: 0x06027B76 RID: 162678 RVA: 0x0056F137 File Offset: 0x0056D337
		public object Value { get; set; }

		// Token: 0x06027B77 RID: 162679 RVA: 0x0056F140 File Offset: 0x0056D340
		public IPickInteraction_UnionUnion()
		{
			this.Type = IPickInteraction_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06027B78 RID: 162680 RVA: 0x0056F156 File Offset: 0x0056D356
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06027B79 RID: 162681 RVA: 0x0056F168 File Offset: 0x0056D368
		public IPickInteractionT AsIPickInteraction()
		{
			return this.As<IPickInteractionT>();
		}

		// Token: 0x06027B7A RID: 162682 RVA: 0x0056F170 File Offset: 0x0056D370
		public static IPickInteraction_UnionUnion FromIPickInteraction(IPickInteractionT _ipickinteraction)
		{
			return new IPickInteraction_UnionUnion
			{
				Type = IPickInteraction_Union.IPickInteraction,
				Value = _ipickinteraction
			};
		}

		// Token: 0x06027B7B RID: 162683 RVA: 0x0056F185 File Offset: 0x0056D385
		public IChessmanPickInteractionT AsIChessmanPickInteraction()
		{
			return this.As<IChessmanPickInteractionT>();
		}

		// Token: 0x06027B7C RID: 162684 RVA: 0x0056F18D File Offset: 0x0056D38D
		public static IPickInteraction_UnionUnion FromIChessmanPickInteraction(IChessmanPickInteractionT _ichessmanpickinteraction)
		{
			return new IPickInteraction_UnionUnion
			{
				Type = IPickInteraction_Union.IChessmanPickInteraction,
				Value = _ichessmanpickinteraction
			};
		}

		// Token: 0x06027B7D RID: 162685 RVA: 0x0056F1A4 File Offset: 0x0056D3A4
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
