using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F25 RID: 32549
	public class TLiveInteractDanmakuTriggerUnion
	{
		// Token: 0x1700F291 RID: 62097
		// (get) Token: 0x0603AB71 RID: 240497 RVA: 0x007E566A File Offset: 0x007E386A
		// (set) Token: 0x0603AB72 RID: 240498 RVA: 0x007E5672 File Offset: 0x007E3872
		public TLiveInteractDanmakuTrigger Type { get; set; }

		// Token: 0x1700F292 RID: 62098
		// (get) Token: 0x0603AB73 RID: 240499 RVA: 0x007E567B File Offset: 0x007E387B
		// (set) Token: 0x0603AB74 RID: 240500 RVA: 0x007E5683 File Offset: 0x007E3883
		public object Value { get; set; }

		// Token: 0x0603AB75 RID: 240501 RVA: 0x007E568C File Offset: 0x007E388C
		public TLiveInteractDanmakuTriggerUnion()
		{
			this.Type = TLiveInteractDanmakuTrigger.NONE;
			this.Value = null;
		}

		// Token: 0x0603AB76 RID: 240502 RVA: 0x007E56A2 File Offset: 0x007E38A2
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AB77 RID: 240503 RVA: 0x007E56B4 File Offset: 0x007E38B4
		public ILiveInteractDanmakuTriggerBattleEventT AsILiveInteractDanmakuTriggerBattleEvent()
		{
			return this.As<ILiveInteractDanmakuTriggerBattleEventT>();
		}

		// Token: 0x0603AB78 RID: 240504 RVA: 0x007E56BC File Offset: 0x007E38BC
		public static TLiveInteractDanmakuTriggerUnion FromILiveInteractDanmakuTriggerBattleEvent(ILiveInteractDanmakuTriggerBattleEventT _iliveinteractdanmakutriggerbattleevent)
		{
			return new TLiveInteractDanmakuTriggerUnion
			{
				Type = TLiveInteractDanmakuTrigger.ILiveInteractDanmakuTriggerBattleEvent,
				Value = _iliveinteractdanmakutriggerbattleevent
			};
		}

		// Token: 0x0603AB79 RID: 240505 RVA: 0x007E56D1 File Offset: 0x007E38D1
		public ILiveInteractDanmakuTriggerSkillGenreT AsILiveInteractDanmakuTriggerSkillGenre()
		{
			return this.As<ILiveInteractDanmakuTriggerSkillGenreT>();
		}

		// Token: 0x0603AB7A RID: 240506 RVA: 0x007E56D9 File Offset: 0x007E38D9
		public static TLiveInteractDanmakuTriggerUnion FromILiveInteractDanmakuTriggerSkillGenre(ILiveInteractDanmakuTriggerSkillGenreT _iliveinteractdanmakutriggerskillgenre)
		{
			return new TLiveInteractDanmakuTriggerUnion
			{
				Type = TLiveInteractDanmakuTrigger.ILiveInteractDanmakuTriggerSkillGenre,
				Value = _iliveinteractdanmakutriggerskillgenre
			};
		}

		// Token: 0x0603AB7B RID: 240507 RVA: 0x007E56EE File Offset: 0x007E38EE
		public ILiveInteractDanmakuTriggerSkillIdT AsILiveInteractDanmakuTriggerSkillId()
		{
			return this.As<ILiveInteractDanmakuTriggerSkillIdT>();
		}

		// Token: 0x0603AB7C RID: 240508 RVA: 0x007E56F6 File Offset: 0x007E38F6
		public static TLiveInteractDanmakuTriggerUnion FromILiveInteractDanmakuTriggerSkillId(ILiveInteractDanmakuTriggerSkillIdT _iliveinteractdanmakutriggerskillid)
		{
			return new TLiveInteractDanmakuTriggerUnion
			{
				Type = TLiveInteractDanmakuTrigger.ILiveInteractDanmakuTriggerSkillId,
				Value = _iliveinteractdanmakutriggerskillid
			};
		}

		// Token: 0x0603AB7D RID: 240509 RVA: 0x007E570C File Offset: 0x007E390C
		public static int Pack(FlatBufferBuilder builder, TLiveInteractDanmakuTriggerUnion _o)
		{
			switch (_o.Type)
			{
			case TLiveInteractDanmakuTrigger.ILiveInteractDanmakuTriggerBattleEvent:
				return ILiveInteractDanmakuTriggerBattleEvent.Pack(builder, _o.AsILiveInteractDanmakuTriggerBattleEvent()).Value;
			case TLiveInteractDanmakuTrigger.ILiveInteractDanmakuTriggerSkillGenre:
				return ILiveInteractDanmakuTriggerSkillGenre.Pack(builder, _o.AsILiveInteractDanmakuTriggerSkillGenre()).Value;
			case TLiveInteractDanmakuTrigger.ILiveInteractDanmakuTriggerSkillId:
				return ILiveInteractDanmakuTriggerSkillId.Pack(builder, _o.AsILiveInteractDanmakuTriggerSkillId()).Value;
			default:
				return 0;
			}
		}
	}
}
