using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D7D RID: 15741
	public class ICheckTrapDefenseEventBase_UnionUnion
	{
		// Token: 0x17006C04 RID: 27652
		// (get) Token: 0x06015CAB RID: 89259 RVA: 0x00324395 File Offset: 0x00322595
		// (set) Token: 0x06015CAC RID: 89260 RVA: 0x0032439D File Offset: 0x0032259D
		public ICheckTrapDefenseEventBase_Union Type { get; set; }

		// Token: 0x17006C05 RID: 27653
		// (get) Token: 0x06015CAD RID: 89261 RVA: 0x003243A6 File Offset: 0x003225A6
		// (set) Token: 0x06015CAE RID: 89262 RVA: 0x003243AE File Offset: 0x003225AE
		public object Value { get; set; }

		// Token: 0x06015CAF RID: 89263 RVA: 0x003243B7 File Offset: 0x003225B7
		public ICheckTrapDefenseEventBase_UnionUnion()
		{
			this.Type = ICheckTrapDefenseEventBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06015CB0 RID: 89264 RVA: 0x003243CD File Offset: 0x003225CD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06015CB1 RID: 89265 RVA: 0x003243DF File Offset: 0x003225DF
		public ICheckTrapDefenseEventBaseT AsICheckTrapDefenseEventBase()
		{
			return this.As<ICheckTrapDefenseEventBaseT>();
		}

		// Token: 0x06015CB2 RID: 89266 RVA: 0x003243E7 File Offset: 0x003225E7
		public static ICheckTrapDefenseEventBase_UnionUnion FromICheckTrapDefenseEventBase(ICheckTrapDefenseEventBaseT _ichecktrapdefenseeventbase)
		{
			return new ICheckTrapDefenseEventBase_UnionUnion
			{
				Type = ICheckTrapDefenseEventBase_Union.ICheckTrapDefenseEventBase,
				Value = _ichecktrapdefenseeventbase
			};
		}

		// Token: 0x06015CB3 RID: 89267 RVA: 0x003243FC File Offset: 0x003225FC
		public ICheckTrapDefenseEventMonsterKilledT AsICheckTrapDefenseEventMonsterKilled()
		{
			return this.As<ICheckTrapDefenseEventMonsterKilledT>();
		}

		// Token: 0x06015CB4 RID: 89268 RVA: 0x00324404 File Offset: 0x00322604
		public static ICheckTrapDefenseEventBase_UnionUnion FromICheckTrapDefenseEventMonsterKilled(ICheckTrapDefenseEventMonsterKilledT _ichecktrapdefenseeventmonsterkilled)
		{
			return new ICheckTrapDefenseEventBase_UnionUnion
			{
				Type = ICheckTrapDefenseEventBase_Union.ICheckTrapDefenseEventMonsterKilled,
				Value = _ichecktrapdefenseeventmonsterkilled
			};
		}

		// Token: 0x06015CB5 RID: 89269 RVA: 0x00324419 File Offset: 0x00322619
		public ICheckTrapDefenseBdBuffQualityUpT AsICheckTrapDefenseBdBuffQualityUp()
		{
			return this.As<ICheckTrapDefenseBdBuffQualityUpT>();
		}

		// Token: 0x06015CB6 RID: 89270 RVA: 0x00324421 File Offset: 0x00322621
		public static ICheckTrapDefenseEventBase_UnionUnion FromICheckTrapDefenseBdBuffQualityUp(ICheckTrapDefenseBdBuffQualityUpT _ichecktrapdefensebdbuffqualityup)
		{
			return new ICheckTrapDefenseEventBase_UnionUnion
			{
				Type = ICheckTrapDefenseEventBase_Union.ICheckTrapDefenseBdBuffQualityUp,
				Value = _ichecktrapdefensebdbuffqualityup
			};
		}

		// Token: 0x06015CB7 RID: 89271 RVA: 0x00324438 File Offset: 0x00322638
		public static int Pack(FlatBufferBuilder builder, ICheckTrapDefenseEventBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ICheckTrapDefenseEventBase_Union.ICheckTrapDefenseEventBase:
				return ICheckTrapDefenseEventBase.Pack(builder, _o.AsICheckTrapDefenseEventBase()).Value;
			case ICheckTrapDefenseEventBase_Union.ICheckTrapDefenseEventMonsterKilled:
				return ICheckTrapDefenseEventMonsterKilled.Pack(builder, _o.AsICheckTrapDefenseEventMonsterKilled()).Value;
			case ICheckTrapDefenseEventBase_Union.ICheckTrapDefenseBdBuffQualityUp:
				return ICheckTrapDefenseBdBuffQualityUp.Pack(builder, _o.AsICheckTrapDefenseBdBuffQualityUp()).Value;
			default:
				return 0;
			}
		}
	}
}
