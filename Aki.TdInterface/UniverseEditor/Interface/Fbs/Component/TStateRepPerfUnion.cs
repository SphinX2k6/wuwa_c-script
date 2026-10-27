using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CAF RID: 23727
	public class TStateRepPerfUnion
	{
		// Token: 0x1700B252 RID: 45650
		// (get) Token: 0x060289FF RID: 166399 RVA: 0x005953A7 File Offset: 0x005935A7
		// (set) Token: 0x06028A00 RID: 166400 RVA: 0x005953AF File Offset: 0x005935AF
		public TStateRepPerf Type { get; set; }

		// Token: 0x1700B253 RID: 45651
		// (get) Token: 0x06028A01 RID: 166401 RVA: 0x005953B8 File Offset: 0x005935B8
		// (set) Token: 0x06028A02 RID: 166402 RVA: 0x005953C0 File Offset: 0x005935C0
		public object Value { get; set; }

		// Token: 0x06028A03 RID: 166403 RVA: 0x005953C9 File Offset: 0x005935C9
		public TStateRepPerfUnion()
		{
			this.Type = TStateRepPerf.NONE;
			this.Value = null;
		}

		// Token: 0x06028A04 RID: 166404 RVA: 0x005953DF File Offset: 0x005935DF
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06028A05 RID: 166405 RVA: 0x005953F1 File Offset: 0x005935F1
		public IStateRepPerfEffectsT AsIStateRepPerfEffects()
		{
			return this.As<IStateRepPerfEffectsT>();
		}

		// Token: 0x06028A06 RID: 166406 RVA: 0x005953F9 File Offset: 0x005935F9
		public static TStateRepPerfUnion FromIStateRepPerfEffects(IStateRepPerfEffectsT _istaterepperfeffects)
		{
			return new TStateRepPerfUnion
			{
				Type = TStateRepPerf.IStateRepPerfEffects,
				Value = _istaterepperfeffects
			};
		}

		// Token: 0x06028A07 RID: 166407 RVA: 0x0059540E File Offset: 0x0059360E
		public IStateRepPerfMontagePathT AsIStateRepPerfMontagePath()
		{
			return this.As<IStateRepPerfMontagePathT>();
		}

		// Token: 0x06028A08 RID: 166408 RVA: 0x00595416 File Offset: 0x00593616
		public static TStateRepPerfUnion FromIStateRepPerfMontagePath(IStateRepPerfMontagePathT _istaterepperfmontagepath)
		{
			return new TStateRepPerfUnion
			{
				Type = TStateRepPerf.IStateRepPerfMontagePath,
				Value = _istaterepperfmontagepath
			};
		}

		// Token: 0x06028A09 RID: 166409 RVA: 0x0059542B File Offset: 0x0059362B
		public IStateRepPerfSkillIdT AsIStateRepPerfSkillId()
		{
			return this.As<IStateRepPerfSkillIdT>();
		}

		// Token: 0x06028A0A RID: 166410 RVA: 0x00595433 File Offset: 0x00593633
		public static TStateRepPerfUnion FromIStateRepPerfSkillId(IStateRepPerfSkillIdT _istaterepperfskillid)
		{
			return new TStateRepPerfUnion
			{
				Type = TStateRepPerf.IStateRepPerfSkillId,
				Value = _istaterepperfskillid
			};
		}

		// Token: 0x06028A0B RID: 166411 RVA: 0x00595448 File Offset: 0x00593648
		public static int Pack(FlatBufferBuilder builder, TStateRepPerfUnion _o)
		{
			switch (_o.Type)
			{
			case TStateRepPerf.IStateRepPerfEffects:
				return IStateRepPerfEffects.Pack(builder, _o.AsIStateRepPerfEffects()).Value;
			case TStateRepPerf.IStateRepPerfMontagePath:
				return IStateRepPerfMontagePath.Pack(builder, _o.AsIStateRepPerfMontagePath()).Value;
			case TStateRepPerf.IStateRepPerfSkillId:
				return IStateRepPerfSkillId.Pack(builder, _o.AsIStateRepPerfSkillId()).Value;
			default:
				return 0;
			}
		}
	}
}
