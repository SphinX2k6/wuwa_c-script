using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C5C RID: 19548
	public class IMusicBeatsConditionBase_UnionUnion
	{
		// Token: 0x17008E03 RID: 36355
		// (get) Token: 0x0601EFE7 RID: 126951 RVA: 0x00455A59 File Offset: 0x00453C59
		// (set) Token: 0x0601EFE8 RID: 126952 RVA: 0x00455A61 File Offset: 0x00453C61
		public IMusicBeatsConditionBase_Union Type { get; set; }

		// Token: 0x17008E04 RID: 36356
		// (get) Token: 0x0601EFE9 RID: 126953 RVA: 0x00455A6A File Offset: 0x00453C6A
		// (set) Token: 0x0601EFEA RID: 126954 RVA: 0x00455A72 File Offset: 0x00453C72
		public object Value { get; set; }

		// Token: 0x0601EFEB RID: 126955 RVA: 0x00455A7B File Offset: 0x00453C7B
		public IMusicBeatsConditionBase_UnionUnion()
		{
			this.Type = IMusicBeatsConditionBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601EFEC RID: 126956 RVA: 0x00455A91 File Offset: 0x00453C91
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601EFED RID: 126957 RVA: 0x00455AA3 File Offset: 0x00453CA3
		public IMusicBeatsConditionBaseT AsIMusicBeatsConditionBase()
		{
			return this.As<IMusicBeatsConditionBaseT>();
		}

		// Token: 0x0601EFEE RID: 126958 RVA: 0x00455AAB File Offset: 0x00453CAB
		public static IMusicBeatsConditionBase_UnionUnion FromIMusicBeatsConditionBase(IMusicBeatsConditionBaseT _imusicbeatsconditionbase)
		{
			return new IMusicBeatsConditionBase_UnionUnion
			{
				Type = IMusicBeatsConditionBase_Union.IMusicBeatsConditionBase,
				Value = _imusicbeatsconditionbase
			};
		}

		// Token: 0x0601EFEF RID: 126959 RVA: 0x00455AC0 File Offset: 0x00453CC0
		public ICheckHcMusicBeatsT AsICheckHcMusicBeats()
		{
			return this.As<ICheckHcMusicBeatsT>();
		}

		// Token: 0x0601EFF0 RID: 126960 RVA: 0x00455AC8 File Offset: 0x00453CC8
		public static IMusicBeatsConditionBase_UnionUnion FromICheckHcMusicBeats(ICheckHcMusicBeatsT _icheckhcmusicbeats)
		{
			return new IMusicBeatsConditionBase_UnionUnion
			{
				Type = IMusicBeatsConditionBase_Union.ICheckHcMusicBeats,
				Value = _icheckhcmusicbeats
			};
		}

		// Token: 0x0601EFF1 RID: 126961 RVA: 0x00455ADD File Offset: 0x00453CDD
		public ICheckFlForestMusicBeatsT AsICheckFlForestMusicBeats()
		{
			return this.As<ICheckFlForestMusicBeatsT>();
		}

		// Token: 0x0601EFF2 RID: 126962 RVA: 0x00455AE5 File Offset: 0x00453CE5
		public static IMusicBeatsConditionBase_UnionUnion FromICheckFlForestMusicBeats(ICheckFlForestMusicBeatsT _icheckflforestmusicbeats)
		{
			return new IMusicBeatsConditionBase_UnionUnion
			{
				Type = IMusicBeatsConditionBase_Union.ICheckFlForestMusicBeats,
				Value = _icheckflforestmusicbeats
			};
		}

		// Token: 0x0601EFF3 RID: 126963 RVA: 0x00455AFC File Offset: 0x00453CFC
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
