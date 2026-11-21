using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200710A RID: 28938
	public class ILiveInteractDanmakuTrigger_UnionUnion
	{
		// Token: 0x1700D3EA RID: 54250
		// (get) Token: 0x06032421 RID: 205857 RVA: 0x006CBE9A File Offset: 0x006CA09A
		// (set) Token: 0x06032422 RID: 205858 RVA: 0x006CBEA2 File Offset: 0x006CA0A2
		public ILiveInteractDanmakuTrigger_Union Type { get; set; }

		// Token: 0x1700D3EB RID: 54251
		// (get) Token: 0x06032423 RID: 205859 RVA: 0x006CBEAB File Offset: 0x006CA0AB
		// (set) Token: 0x06032424 RID: 205860 RVA: 0x006CBEB3 File Offset: 0x006CA0B3
		public object Value { get; set; }

		// Token: 0x06032425 RID: 205861 RVA: 0x006CBEBC File Offset: 0x006CA0BC
		public ILiveInteractDanmakuTrigger_UnionUnion()
		{
			this.Type = ILiveInteractDanmakuTrigger_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06032426 RID: 205862 RVA: 0x006CBED2 File Offset: 0x006CA0D2
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06032427 RID: 205863 RVA: 0x006CBEE4 File Offset: 0x006CA0E4
		public ILiveInteractDanmakuTriggerT AsILiveInteractDanmakuTrigger()
		{
			return this.As<ILiveInteractDanmakuTriggerT>();
		}

		// Token: 0x06032428 RID: 205864 RVA: 0x006CBEEC File Offset: 0x006CA0EC
		public static ILiveInteractDanmakuTrigger_UnionUnion FromILiveInteractDanmakuTrigger(ILiveInteractDanmakuTriggerT _iliveinteractdanmakutrigger)
		{
			return new ILiveInteractDanmakuTrigger_UnionUnion
			{
				Type = ILiveInteractDanmakuTrigger_Union.ILiveInteractDanmakuTrigger,
				Value = _iliveinteractdanmakutrigger
			};
		}

		// Token: 0x06032429 RID: 205865 RVA: 0x006CBF01 File Offset: 0x006CA101
		public ILiveInteractDanmakuTriggerSkillGenreT AsILiveInteractDanmakuTriggerSkillGenre()
		{
			return this.As<ILiveInteractDanmakuTriggerSkillGenreT>();
		}

		// Token: 0x0603242A RID: 205866 RVA: 0x006CBF09 File Offset: 0x006CA109
		public static ILiveInteractDanmakuTrigger_UnionUnion FromILiveInteractDanmakuTriggerSkillGenre(ILiveInteractDanmakuTriggerSkillGenreT _iliveinteractdanmakutriggerskillgenre)
		{
			return new ILiveInteractDanmakuTrigger_UnionUnion
			{
				Type = ILiveInteractDanmakuTrigger_Union.ILiveInteractDanmakuTriggerSkillGenre,
				Value = _iliveinteractdanmakutriggerskillgenre
			};
		}

		// Token: 0x0603242B RID: 205867 RVA: 0x006CBF1E File Offset: 0x006CA11E
		public ILiveInteractDanmakuTriggerSkillIdT AsILiveInteractDanmakuTriggerSkillId()
		{
			return this.As<ILiveInteractDanmakuTriggerSkillIdT>();
		}

		// Token: 0x0603242C RID: 205868 RVA: 0x006CBF26 File Offset: 0x006CA126
		public static ILiveInteractDanmakuTrigger_UnionUnion FromILiveInteractDanmakuTriggerSkillId(ILiveInteractDanmakuTriggerSkillIdT _iliveinteractdanmakutriggerskillid)
		{
			return new ILiveInteractDanmakuTrigger_UnionUnion
			{
				Type = ILiveInteractDanmakuTrigger_Union.ILiveInteractDanmakuTriggerSkillId,
				Value = _iliveinteractdanmakutriggerskillid
			};
		}

		// Token: 0x0603242D RID: 205869 RVA: 0x006CBF3B File Offset: 0x006CA13B
		public ILiveInteractDanmakuTriggerBattleEventT AsILiveInteractDanmakuTriggerBattleEvent()
		{
			return this.As<ILiveInteractDanmakuTriggerBattleEventT>();
		}

		// Token: 0x0603242E RID: 205870 RVA: 0x006CBF43 File Offset: 0x006CA143
		public static ILiveInteractDanmakuTrigger_UnionUnion FromILiveInteractDanmakuTriggerBattleEvent(ILiveInteractDanmakuTriggerBattleEventT _iliveinteractdanmakutriggerbattleevent)
		{
			return new ILiveInteractDanmakuTrigger_UnionUnion
			{
				Type = ILiveInteractDanmakuTrigger_Union.ILiveInteractDanmakuTriggerBattleEvent,
				Value = _iliveinteractdanmakutriggerbattleevent
			};
		}

		// Token: 0x0603242F RID: 205871 RVA: 0x006CBF58 File Offset: 0x006CA158
		public static int Pack(FlatBufferBuilder builder, ILiveInteractDanmakuTrigger_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ILiveInteractDanmakuTrigger_Union.ILiveInteractDanmakuTrigger:
				return ILiveInteractDanmakuTrigger.Pack(builder, _o.AsILiveInteractDanmakuTrigger()).Value;
			case ILiveInteractDanmakuTrigger_Union.ILiveInteractDanmakuTriggerSkillGenre:
				return ILiveInteractDanmakuTriggerSkillGenre.Pack(builder, _o.AsILiveInteractDanmakuTriggerSkillGenre()).Value;
			case ILiveInteractDanmakuTrigger_Union.ILiveInteractDanmakuTriggerSkillId:
				return ILiveInteractDanmakuTriggerSkillId.Pack(builder, _o.AsILiveInteractDanmakuTriggerSkillId()).Value;
			case ILiveInteractDanmakuTrigger_Union.ILiveInteractDanmakuTriggerBattleEvent:
				return ILiveInteractDanmakuTriggerBattleEvent.Pack(builder, _o.AsILiveInteractDanmakuTriggerBattleEvent()).Value;
			default:
				return 0;
			}
		}
	}
}
