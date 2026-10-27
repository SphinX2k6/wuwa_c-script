using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200733E RID: 29502
	public class ITalkOptionPreConditionBase_UnionUnion
	{
		// Token: 0x1700E00D RID: 57357
		// (get) Token: 0x06035894 RID: 219284 RVA: 0x0074ADBD File Offset: 0x00748FBD
		// (set) Token: 0x06035895 RID: 219285 RVA: 0x0074ADC5 File Offset: 0x00748FC5
		public ITalkOptionPreConditionBase_Union Type { get; set; }

		// Token: 0x1700E00E RID: 57358
		// (get) Token: 0x06035896 RID: 219286 RVA: 0x0074ADCE File Offset: 0x00748FCE
		// (set) Token: 0x06035897 RID: 219287 RVA: 0x0074ADD6 File Offset: 0x00748FD6
		public object Value { get; set; }

		// Token: 0x06035898 RID: 219288 RVA: 0x0074ADDF File Offset: 0x00748FDF
		public ITalkOptionPreConditionBase_UnionUnion()
		{
			this.Type = ITalkOptionPreConditionBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06035899 RID: 219289 RVA: 0x0074ADF5 File Offset: 0x00748FF5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603589A RID: 219290 RVA: 0x0074AE07 File Offset: 0x00749007
		public ITalkOptionPreConditionBaseT AsITalkOptionPreConditionBase()
		{
			return this.As<ITalkOptionPreConditionBaseT>();
		}

		// Token: 0x0603589B RID: 219291 RVA: 0x0074AE0F File Offset: 0x0074900F
		public static ITalkOptionPreConditionBase_UnionUnion FromITalkOptionPreConditionBase(ITalkOptionPreConditionBaseT _italkoptionpreconditionbase)
		{
			return new ITalkOptionPreConditionBase_UnionUnion
			{
				Type = ITalkOptionPreConditionBase_Union.ITalkOptionPreConditionBase,
				Value = _italkoptionpreconditionbase
			};
		}

		// Token: 0x0603589C RID: 219292 RVA: 0x0074AE24 File Offset: 0x00749024
		public ITalkOptionPreOptionT AsITalkOptionPreOption()
		{
			return this.As<ITalkOptionPreOptionT>();
		}

		// Token: 0x0603589D RID: 219293 RVA: 0x0074AE2C File Offset: 0x0074902C
		public static ITalkOptionPreConditionBase_UnionUnion FromITalkOptionPreOption(ITalkOptionPreOptionT _italkoptionpreoption)
		{
			return new ITalkOptionPreConditionBase_UnionUnion
			{
				Type = ITalkOptionPreConditionBase_Union.ITalkOptionPreOption,
				Value = _italkoptionpreoption
			};
		}

		// Token: 0x0603589E RID: 219294 RVA: 0x0074AE41 File Offset: 0x00749041
		public ITalkOptionConditionT AsITalkOptionCondition()
		{
			return this.As<ITalkOptionConditionT>();
		}

		// Token: 0x0603589F RID: 219295 RVA: 0x0074AE49 File Offset: 0x00749049
		public static ITalkOptionPreConditionBase_UnionUnion FromITalkOptionCondition(ITalkOptionConditionT _italkoptioncondition)
		{
			return new ITalkOptionPreConditionBase_UnionUnion
			{
				Type = ITalkOptionPreConditionBase_Union.ITalkOptionCondition,
				Value = _italkoptioncondition
			};
		}

		// Token: 0x060358A0 RID: 219296 RVA: 0x0074AE5E File Offset: 0x0074905E
		public ITalkOptionFirstSelectT AsITalkOptionFirstSelect()
		{
			return this.As<ITalkOptionFirstSelectT>();
		}

		// Token: 0x060358A1 RID: 219297 RVA: 0x0074AE66 File Offset: 0x00749066
		public static ITalkOptionPreConditionBase_UnionUnion FromITalkOptionFirstSelect(ITalkOptionFirstSelectT _italkoptionfirstselect)
		{
			return new ITalkOptionPreConditionBase_UnionUnion
			{
				Type = ITalkOptionPreConditionBase_Union.ITalkOptionFirstSelect,
				Value = _italkoptionfirstselect
			};
		}

		// Token: 0x060358A2 RID: 219298 RVA: 0x0074AE7B File Offset: 0x0074907B
		public ITalkOptionSystemConditionT AsITalkOptionSystemCondition()
		{
			return this.As<ITalkOptionSystemConditionT>();
		}

		// Token: 0x060358A3 RID: 219299 RVA: 0x0074AE83 File Offset: 0x00749083
		public static ITalkOptionPreConditionBase_UnionUnion FromITalkOptionSystemCondition(ITalkOptionSystemConditionT _italkoptionsystemcondition)
		{
			return new ITalkOptionPreConditionBase_UnionUnion
			{
				Type = ITalkOptionPreConditionBase_Union.ITalkOptionSystemCondition,
				Value = _italkoptionsystemcondition
			};
		}

		// Token: 0x060358A4 RID: 219300 RVA: 0x0074AE98 File Offset: 0x00749098
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
