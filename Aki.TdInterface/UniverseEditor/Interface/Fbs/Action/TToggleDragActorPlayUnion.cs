using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02008019 RID: 32793
	public class TToggleDragActorPlayUnion
	{
		// Token: 0x1700F333 RID: 62259
		// (get) Token: 0x0603B021 RID: 241697 RVA: 0x007EC5A6 File Offset: 0x007EA7A6
		// (set) Token: 0x0603B022 RID: 241698 RVA: 0x007EC5AE File Offset: 0x007EA7AE
		public TToggleDragActorPlay Type { get; set; }

		// Token: 0x1700F334 RID: 62260
		// (get) Token: 0x0603B023 RID: 241699 RVA: 0x007EC5B7 File Offset: 0x007EA7B7
		// (set) Token: 0x0603B024 RID: 241700 RVA: 0x007EC5BF File Offset: 0x007EA7BF
		public object Value { get; set; }

		// Token: 0x0603B025 RID: 241701 RVA: 0x007EC5C8 File Offset: 0x007EA7C8
		public TToggleDragActorPlayUnion()
		{
			this.Type = TToggleDragActorPlay.NONE;
			this.Value = null;
		}

		// Token: 0x0603B026 RID: 241702 RVA: 0x007EC5DE File Offset: 0x007EA7DE
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603B027 RID: 241703 RVA: 0x007EC5F0 File Offset: 0x007EA7F0
		public IToggleDragActorPlayDisableT AsIToggleDragActorPlayDisable()
		{
			return this.As<IToggleDragActorPlayDisableT>();
		}

		// Token: 0x0603B028 RID: 241704 RVA: 0x007EC5F8 File Offset: 0x007EA7F8
		public static TToggleDragActorPlayUnion FromIToggleDragActorPlayDisable(IToggleDragActorPlayDisableT _itoggledragactorplaydisable)
		{
			return new TToggleDragActorPlayUnion
			{
				Type = TToggleDragActorPlay.IToggleDragActorPlayDisable,
				Value = _itoggledragactorplaydisable
			};
		}

		// Token: 0x0603B029 RID: 241705 RVA: 0x007EC60D File Offset: 0x007EA80D
		public IToggleDragActorPlayEnableT AsIToggleDragActorPlayEnable()
		{
			return this.As<IToggleDragActorPlayEnableT>();
		}

		// Token: 0x0603B02A RID: 241706 RVA: 0x007EC615 File Offset: 0x007EA815
		public static TToggleDragActorPlayUnion FromIToggleDragActorPlayEnable(IToggleDragActorPlayEnableT _itoggledragactorplayenable)
		{
			return new TToggleDragActorPlayUnion
			{
				Type = TToggleDragActorPlay.IToggleDragActorPlayEnable,
				Value = _itoggledragactorplayenable
			};
		}

		// Token: 0x0603B02B RID: 241707 RVA: 0x007EC62C File Offset: 0x007EA82C
		public static int Pack(FlatBufferBuilder builder, TToggleDragActorPlayUnion _o)
		{
			TToggleDragActorPlay type = _o.Type;
			if (type == TToggleDragActorPlay.IToggleDragActorPlayDisable)
			{
				return IToggleDragActorPlayDisable.Pack(builder, _o.AsIToggleDragActorPlayDisable()).Value;
			}
			if (type != TToggleDragActorPlay.IToggleDragActorPlayEnable)
			{
				return 0;
			}
			return IToggleDragActorPlayEnable.Pack(builder, _o.AsIToggleDragActorPlayEnable()).Value;
		}
	}
}
