using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FBE RID: 24510
	public class IStateRepPerfBase_UnionUnion
	{
		// Token: 0x1700B582 RID: 46466
		// (get) Token: 0x060293C6 RID: 168902 RVA: 0x005A0EE9 File Offset: 0x0059F0E9
		// (set) Token: 0x060293C7 RID: 168903 RVA: 0x005A0EF1 File Offset: 0x0059F0F1
		public IStateRepPerfBase_Union Type { get; set; }

		// Token: 0x1700B583 RID: 46467
		// (get) Token: 0x060293C8 RID: 168904 RVA: 0x005A0EFA File Offset: 0x0059F0FA
		// (set) Token: 0x060293C9 RID: 168905 RVA: 0x005A0F02 File Offset: 0x0059F102
		public object Value { get; set; }

		// Token: 0x060293CA RID: 168906 RVA: 0x005A0F0B File Offset: 0x0059F10B
		public IStateRepPerfBase_UnionUnion()
		{
			this.Type = IStateRepPerfBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060293CB RID: 168907 RVA: 0x005A0F21 File Offset: 0x0059F121
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060293CC RID: 168908 RVA: 0x005A0F33 File Offset: 0x0059F133
		public IStateRepPerfBaseT AsIStateRepPerfBase()
		{
			return this.As<IStateRepPerfBaseT>();
		}

		// Token: 0x060293CD RID: 168909 RVA: 0x005A0F3B File Offset: 0x0059F13B
		public static IStateRepPerfBase_UnionUnion FromIStateRepPerfBase(IStateRepPerfBaseT _istaterepperfbase)
		{
			return new IStateRepPerfBase_UnionUnion
			{
				Type = IStateRepPerfBase_Union.IStateRepPerfBase,
				Value = _istaterepperfbase
			};
		}

		// Token: 0x060293CE RID: 168910 RVA: 0x005A0F50 File Offset: 0x0059F150
		public IStateRepPerfSkillIdT AsIStateRepPerfSkillId()
		{
			return this.As<IStateRepPerfSkillIdT>();
		}

		// Token: 0x060293CF RID: 168911 RVA: 0x005A0F58 File Offset: 0x0059F158
		public static IStateRepPerfBase_UnionUnion FromIStateRepPerfSkillId(IStateRepPerfSkillIdT _istaterepperfskillid)
		{
			return new IStateRepPerfBase_UnionUnion
			{
				Type = IStateRepPerfBase_Union.IStateRepPerfSkillId,
				Value = _istaterepperfskillid
			};
		}

		// Token: 0x060293D0 RID: 168912 RVA: 0x005A0F6D File Offset: 0x0059F16D
		public IStateRepPerfMontagePathT AsIStateRepPerfMontagePath()
		{
			return this.As<IStateRepPerfMontagePathT>();
		}

		// Token: 0x060293D1 RID: 168913 RVA: 0x005A0F75 File Offset: 0x0059F175
		public static IStateRepPerfBase_UnionUnion FromIStateRepPerfMontagePath(IStateRepPerfMontagePathT _istaterepperfmontagepath)
		{
			return new IStateRepPerfBase_UnionUnion
			{
				Type = IStateRepPerfBase_Union.IStateRepPerfMontagePath,
				Value = _istaterepperfmontagepath
			};
		}

		// Token: 0x060293D2 RID: 168914 RVA: 0x005A0F8A File Offset: 0x0059F18A
		public IStateRepPerfEffectsT AsIStateRepPerfEffects()
		{
			return this.As<IStateRepPerfEffectsT>();
		}

		// Token: 0x060293D3 RID: 168915 RVA: 0x005A0F92 File Offset: 0x0059F192
		public static IStateRepPerfBase_UnionUnion FromIStateRepPerfEffects(IStateRepPerfEffectsT _istaterepperfeffects)
		{
			return new IStateRepPerfBase_UnionUnion
			{
				Type = IStateRepPerfBase_Union.IStateRepPerfEffects,
				Value = _istaterepperfeffects
			};
		}

		// Token: 0x060293D4 RID: 168916 RVA: 0x005A0FA8 File Offset: 0x0059F1A8
		public static int Pack(FlatBufferBuilder builder, IStateRepPerfBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IStateRepPerfBase_Union.IStateRepPerfBase:
				return IStateRepPerfBase.Pack(builder, _o.AsIStateRepPerfBase()).Value;
			case IStateRepPerfBase_Union.IStateRepPerfSkillId:
				return IStateRepPerfSkillId.Pack(builder, _o.AsIStateRepPerfSkillId()).Value;
			case IStateRepPerfBase_Union.IStateRepPerfMontagePath:
				return IStateRepPerfMontagePath.Pack(builder, _o.AsIStateRepPerfMontagePath()).Value;
			case IStateRepPerfBase_Union.IStateRepPerfEffects:
				return IStateRepPerfEffects.Pack(builder, _o.AsIStateRepPerfEffects()).Value;
			default:
				return 0;
			}
		}
	}
}
