using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B16 RID: 31510
	public class ITalkOptionPreConditionBase_UnionUnion
	{
		// Token: 0x1700EC09 RID: 60425
		// (get) Token: 0x06038BC7 RID: 232391 RVA: 0x007AC945 File Offset: 0x007AAB45
		// (set) Token: 0x06038BC8 RID: 232392 RVA: 0x007AC94D File Offset: 0x007AAB4D
		public ITalkOptionPreConditionBase_Union Type { get; set; }

		// Token: 0x1700EC0A RID: 60426
		// (get) Token: 0x06038BC9 RID: 232393 RVA: 0x007AC956 File Offset: 0x007AAB56
		// (set) Token: 0x06038BCA RID: 232394 RVA: 0x007AC95E File Offset: 0x007AAB5E
		public object Value { get; set; }

		// Token: 0x06038BCB RID: 232395 RVA: 0x007AC967 File Offset: 0x007AAB67
		public ITalkOptionPreConditionBase_UnionUnion()
		{
			this.Type = ITalkOptionPreConditionBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06038BCC RID: 232396 RVA: 0x007AC97D File Offset: 0x007AAB7D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06038BCD RID: 232397 RVA: 0x007AC98F File Offset: 0x007AAB8F
		public ITalkOptionPreConditionBaseT AsITalkOptionPreConditionBase()
		{
			return this.As<ITalkOptionPreConditionBaseT>();
		}

		// Token: 0x06038BCE RID: 232398 RVA: 0x007AC997 File Offset: 0x007AAB97
		public static ITalkOptionPreConditionBase_UnionUnion FromITalkOptionPreConditionBase(ITalkOptionPreConditionBaseT _italkoptionpreconditionbase)
		{
			return new ITalkOptionPreConditionBase_UnionUnion
			{
				Type = ITalkOptionPreConditionBase_Union.ITalkOptionPreConditionBase,
				Value = _italkoptionpreconditionbase
			};
		}

		// Token: 0x06038BCF RID: 232399 RVA: 0x007AC9AC File Offset: 0x007AABAC
		public ITalkOptionPreOptionT AsITalkOptionPreOption()
		{
			return this.As<ITalkOptionPreOptionT>();
		}

		// Token: 0x06038BD0 RID: 232400 RVA: 0x007AC9B4 File Offset: 0x007AABB4
		public static ITalkOptionPreConditionBase_UnionUnion FromITalkOptionPreOption(ITalkOptionPreOptionT _italkoptionpreoption)
		{
			return new ITalkOptionPreConditionBase_UnionUnion
			{
				Type = ITalkOptionPreConditionBase_Union.ITalkOptionPreOption,
				Value = _italkoptionpreoption
			};
		}

		// Token: 0x06038BD1 RID: 232401 RVA: 0x007AC9C9 File Offset: 0x007AABC9
		public ITalkOptionConditionT AsITalkOptionCondition()
		{
			return this.As<ITalkOptionConditionT>();
		}

		// Token: 0x06038BD2 RID: 232402 RVA: 0x007AC9D1 File Offset: 0x007AABD1
		public static ITalkOptionPreConditionBase_UnionUnion FromITalkOptionCondition(ITalkOptionConditionT _italkoptioncondition)
		{
			return new ITalkOptionPreConditionBase_UnionUnion
			{
				Type = ITalkOptionPreConditionBase_Union.ITalkOptionCondition,
				Value = _italkoptioncondition
			};
		}

		// Token: 0x06038BD3 RID: 232403 RVA: 0x007AC9E6 File Offset: 0x007AABE6
		public ITalkOptionFirstSelectT AsITalkOptionFirstSelect()
		{
			return this.As<ITalkOptionFirstSelectT>();
		}

		// Token: 0x06038BD4 RID: 232404 RVA: 0x007AC9EE File Offset: 0x007AABEE
		public static ITalkOptionPreConditionBase_UnionUnion FromITalkOptionFirstSelect(ITalkOptionFirstSelectT _italkoptionfirstselect)
		{
			return new ITalkOptionPreConditionBase_UnionUnion
			{
				Type = ITalkOptionPreConditionBase_Union.ITalkOptionFirstSelect,
				Value = _italkoptionfirstselect
			};
		}

		// Token: 0x06038BD5 RID: 232405 RVA: 0x007ACA03 File Offset: 0x007AAC03
		public ITalkOptionSystemConditionT AsITalkOptionSystemCondition()
		{
			return this.As<ITalkOptionSystemConditionT>();
		}

		// Token: 0x06038BD6 RID: 232406 RVA: 0x007ACA0B File Offset: 0x007AAC0B
		public static ITalkOptionPreConditionBase_UnionUnion FromITalkOptionSystemCondition(ITalkOptionSystemConditionT _italkoptionsystemcondition)
		{
			return new ITalkOptionPreConditionBase_UnionUnion
			{
				Type = ITalkOptionPreConditionBase_Union.ITalkOptionSystemCondition,
				Value = _italkoptionsystemcondition
			};
		}

		// Token: 0x06038BD7 RID: 232407 RVA: 0x007ACA20 File Offset: 0x007AAC20
		public static int Pack(FlatBufferBuilder builder, ITalkOptionPreConditionBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ITalkOptionPreConditionBase_Union.ITalkOptionPreConditionBase:
				return ITalkOptionPreConditionBase.Pack(builder, _o.AsITalkOptionPreConditionBase()).Value;
			case ITalkOptionPreConditionBase_Union.ITalkOptionPreOption:
				return ITalkOptionPreOption.Pack(builder, _o.AsITalkOptionPreOption()).Value;
			case ITalkOptionPreConditionBase_Union.ITalkOptionCondition:
				return ITalkOptionCondition.Pack(builder, _o.AsITalkOptionCondition()).Value;
			case ITalkOptionPreConditionBase_Union.ITalkOptionFirstSelect:
				return ITalkOptionFirstSelect.Pack(builder, _o.AsITalkOptionFirstSelect()).Value;
			case ITalkOptionPreConditionBase_Union.ITalkOptionSystemCondition:
				return ITalkOptionSystemCondition.Pack(builder, _o.AsITalkOptionSystemCondition()).Value;
			default:
				return 0;
			}
		}
	}
}
