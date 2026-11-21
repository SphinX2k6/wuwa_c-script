using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005155 RID: 20821
	public class IMusicBeatsConditionBase_UnionUnion
	{
		// Token: 0x17009531 RID: 38193
		// (get) Token: 0x06020C09 RID: 134153 RVA: 0x004895A9 File Offset: 0x004877A9
		// (set) Token: 0x06020C0A RID: 134154 RVA: 0x004895B1 File Offset: 0x004877B1
		public IMusicBeatsConditionBase_Union Type { get; set; }

		// Token: 0x17009532 RID: 38194
		// (get) Token: 0x06020C0B RID: 134155 RVA: 0x004895BA File Offset: 0x004877BA
		// (set) Token: 0x06020C0C RID: 134156 RVA: 0x004895C2 File Offset: 0x004877C2
		public object Value { get; set; }

		// Token: 0x06020C0D RID: 134157 RVA: 0x004895CB File Offset: 0x004877CB
		public IMusicBeatsConditionBase_UnionUnion()
		{
			this.Type = IMusicBeatsConditionBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06020C0E RID: 134158 RVA: 0x004895E1 File Offset: 0x004877E1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06020C0F RID: 134159 RVA: 0x004895F3 File Offset: 0x004877F3
		public IMusicBeatsConditionBaseT AsIMusicBeatsConditionBase()
		{
			return this.As<IMusicBeatsConditionBaseT>();
		}

		// Token: 0x06020C10 RID: 134160 RVA: 0x004895FB File Offset: 0x004877FB
		public static IMusicBeatsConditionBase_UnionUnion FromIMusicBeatsConditionBase(IMusicBeatsConditionBaseT _imusicbeatsconditionbase)
		{
			return new IMusicBeatsConditionBase_UnionUnion
			{
				Type = IMusicBeatsConditionBase_Union.IMusicBeatsConditionBase,
				Value = _imusicbeatsconditionbase
			};
		}

		// Token: 0x06020C11 RID: 134161 RVA: 0x00489610 File Offset: 0x00487810
		public ICheckHcMusicBeatsT AsICheckHcMusicBeats()
		{
			return this.As<ICheckHcMusicBeatsT>();
		}

		// Token: 0x06020C12 RID: 134162 RVA: 0x00489618 File Offset: 0x00487818
		public static IMusicBeatsConditionBase_UnionUnion FromICheckHcMusicBeats(ICheckHcMusicBeatsT _icheckhcmusicbeats)
		{
			return new IMusicBeatsConditionBase_UnionUnion
			{
				Type = IMusicBeatsConditionBase_Union.ICheckHcMusicBeats,
				Value = _icheckhcmusicbeats
			};
		}

		// Token: 0x06020C13 RID: 134163 RVA: 0x0048962D File Offset: 0x0048782D
		public ICheckFlForestMusicBeatsT AsICheckFlForestMusicBeats()
		{
			return this.As<ICheckFlForestMusicBeatsT>();
		}

		// Token: 0x06020C14 RID: 134164 RVA: 0x00489635 File Offset: 0x00487835
		public static IMusicBeatsConditionBase_UnionUnion FromICheckFlForestMusicBeats(ICheckFlForestMusicBeatsT _icheckflforestmusicbeats)
		{
			return new IMusicBeatsConditionBase_UnionUnion
			{
				Type = IMusicBeatsConditionBase_Union.ICheckFlForestMusicBeats,
				Value = _icheckflforestmusicbeats
			};
		}

		// Token: 0x06020C15 RID: 134165 RVA: 0x0048964C File Offset: 0x0048784C
		public static int Pack(FlatBufferBuilder builder, IMusicBeatsConditionBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IMusicBeatsConditionBase_Union.IMusicBeatsConditionBase:
				return IMusicBeatsConditionBase.Pack(builder, _o.AsIMusicBeatsConditionBase()).Value;
			case IMusicBeatsConditionBase_Union.ICheckHcMusicBeats:
				return ICheckHcMusicBeats.Pack(builder, _o.AsICheckHcMusicBeats()).Value;
			case IMusicBeatsConditionBase_Union.ICheckFlForestMusicBeats:
				return ICheckFlForestMusicBeats.Pack(builder, _o.AsICheckFlForestMusicBeats()).Value;
			default:
				return 0;
			}
		}
	}
}
