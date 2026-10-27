using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060C6 RID: 24774
	public class IActorFxEmoteType_UnionUnion
	{
		// Token: 0x1700B68B RID: 46731
		// (get) Token: 0x0602A4BA RID: 173242 RVA: 0x005D4575 File Offset: 0x005D2775
		// (set) Token: 0x0602A4BB RID: 173243 RVA: 0x005D457D File Offset: 0x005D277D
		public IActorFxEmoteType_Union Type { get; set; }

		// Token: 0x1700B68C RID: 46732
		// (get) Token: 0x0602A4BC RID: 173244 RVA: 0x005D4586 File Offset: 0x005D2786
		// (set) Token: 0x0602A4BD RID: 173245 RVA: 0x005D458E File Offset: 0x005D278E
		public object Value { get; set; }

		// Token: 0x0602A4BE RID: 173246 RVA: 0x005D4597 File Offset: 0x005D2797
		public IActorFxEmoteType_UnionUnion()
		{
			this.Type = IActorFxEmoteType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602A4BF RID: 173247 RVA: 0x005D45AD File Offset: 0x005D27AD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602A4C0 RID: 173248 RVA: 0x005D45BF File Offset: 0x005D27BF
		public IActorFxEmoteTypeT AsIActorFxEmoteType()
		{
			return this.As<IActorFxEmoteTypeT>();
		}

		// Token: 0x0602A4C1 RID: 173249 RVA: 0x005D45C7 File Offset: 0x005D27C7
		public static IActorFxEmoteType_UnionUnion FromIActorFxEmoteType(IActorFxEmoteTypeT _iactorfxemotetype)
		{
			return new IActorFxEmoteType_UnionUnion
			{
				Type = IActorFxEmoteType_Union.IActorFxEmoteType,
				Value = _iactorfxemotetype
			};
		}

		// Token: 0x0602A4C2 RID: 173250 RVA: 0x005D45DC File Offset: 0x005D27DC
		public IActorFxEmotePlayT AsIActorFxEmotePlay()
		{
			return this.As<IActorFxEmotePlayT>();
		}

		// Token: 0x0602A4C3 RID: 173251 RVA: 0x005D45E4 File Offset: 0x005D27E4
		public static IActorFxEmoteType_UnionUnion FromIActorFxEmotePlay(IActorFxEmotePlayT _iactorfxemoteplay)
		{
			return new IActorFxEmoteType_UnionUnion
			{
				Type = IActorFxEmoteType_Union.IActorFxEmotePlay,
				Value = _iactorfxemoteplay
			};
		}

		// Token: 0x0602A4C4 RID: 173252 RVA: 0x005D45F9 File Offset: 0x005D27F9
		public IActorFxEmoteStopT AsIActorFxEmoteStop()
		{
			return this.As<IActorFxEmoteStopT>();
		}

		// Token: 0x0602A4C5 RID: 173253 RVA: 0x005D4601 File Offset: 0x005D2801
		public static IActorFxEmoteType_UnionUnion FromIActorFxEmoteStop(IActorFxEmoteStopT _iactorfxemotestop)
		{
			return new IActorFxEmoteType_UnionUnion
			{
				Type = IActorFxEmoteType_Union.IActorFxEmoteStop,
				Value = _iactorfxemotestop
			};
		}

		// Token: 0x0602A4C6 RID: 173254 RVA: 0x005D4618 File Offset: 0x005D2818
		public static int Pack(FlatBufferBuilder builder, IActorFxEmoteType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IActorFxEmoteType_Union.IActorFxEmoteType:
				return IActorFxEmoteType.Pack(builder, _o.AsIActorFxEmoteType()).Value;
			case IActorFxEmoteType_Union.IActorFxEmotePlay:
				return IActorFxEmotePlay.Pack(builder, _o.AsIActorFxEmotePlay()).Value;
			case IActorFxEmoteType_Union.IActorFxEmoteStop:
				return IActorFxEmoteStop.Pack(builder, _o.AsIActorFxEmoteStop()).Value;
			default:
				return 0;
			}
		}
	}
}
