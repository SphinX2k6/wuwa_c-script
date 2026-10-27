using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077DE RID: 30686
	public class TToggleDragActorPlayUnion
	{
		// Token: 0x1700E6D7 RID: 59095
		// (get) Token: 0x06037A8E RID: 227982 RVA: 0x00786DF6 File Offset: 0x00784FF6
		// (set) Token: 0x06037A8F RID: 227983 RVA: 0x00786DFE File Offset: 0x00784FFE
		public TToggleDragActorPlay Type { get; set; }

		// Token: 0x1700E6D8 RID: 59096
		// (get) Token: 0x06037A90 RID: 227984 RVA: 0x00786E07 File Offset: 0x00785007
		// (set) Token: 0x06037A91 RID: 227985 RVA: 0x00786E0F File Offset: 0x0078500F
		public object Value { get; set; }

		// Token: 0x06037A92 RID: 227986 RVA: 0x00786E18 File Offset: 0x00785018
		public TToggleDragActorPlayUnion()
		{
			this.Type = TToggleDragActorPlay.NONE;
			this.Value = null;
		}

		// Token: 0x06037A93 RID: 227987 RVA: 0x00786E2E File Offset: 0x0078502E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037A94 RID: 227988 RVA: 0x00786E40 File Offset: 0x00785040
		public IToggleDragActorPlayDisableT AsIToggleDragActorPlayDisable()
		{
			return this.As<IToggleDragActorPlayDisableT>();
		}

		// Token: 0x06037A95 RID: 227989 RVA: 0x00786E48 File Offset: 0x00785048
		public static TToggleDragActorPlayUnion FromIToggleDragActorPlayDisable(IToggleDragActorPlayDisableT _itoggledragactorplaydisable)
		{
			return new TToggleDragActorPlayUnion
			{
				Type = TToggleDragActorPlay.IToggleDragActorPlayDisable,
				Value = _itoggledragactorplaydisable
			};
		}

		// Token: 0x06037A96 RID: 227990 RVA: 0x00786E5D File Offset: 0x0078505D
		public IToggleDragActorPlayEnableT AsIToggleDragActorPlayEnable()
		{
			return this.As<IToggleDragActorPlayEnableT>();
		}

		// Token: 0x06037A97 RID: 227991 RVA: 0x00786E65 File Offset: 0x00785065
		public static TToggleDragActorPlayUnion FromIToggleDragActorPlayEnable(IToggleDragActorPlayEnableT _itoggledragactorplayenable)
		{
			return new TToggleDragActorPlayUnion
			{
				Type = TToggleDragActorPlay.IToggleDragActorPlayEnable,
				Value = _itoggledragactorplayenable
			};
		}

		// Token: 0x06037A98 RID: 227992 RVA: 0x00786E7C File Offset: 0x0078507C
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
