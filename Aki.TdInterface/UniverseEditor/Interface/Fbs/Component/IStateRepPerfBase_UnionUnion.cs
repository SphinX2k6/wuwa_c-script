using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059B1 RID: 22961
	public class IStateRepPerfBase_UnionUnion
	{
		// Token: 0x1700AC4E RID: 44110
		// (get) Token: 0x06026E5C RID: 159324 RVA: 0x0055A27D File Offset: 0x0055847D
		// (set) Token: 0x06026E5D RID: 159325 RVA: 0x0055A285 File Offset: 0x00558485
		public IStateRepPerfBase_Union Type { get; set; }

		// Token: 0x1700AC4F RID: 44111
		// (get) Token: 0x06026E5E RID: 159326 RVA: 0x0055A28E File Offset: 0x0055848E
		// (set) Token: 0x06026E5F RID: 159327 RVA: 0x0055A296 File Offset: 0x00558496
		public object Value { get; set; }

		// Token: 0x06026E60 RID: 159328 RVA: 0x0055A29F File Offset: 0x0055849F
		public IStateRepPerfBase_UnionUnion()
		{
			this.Type = IStateRepPerfBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06026E61 RID: 159329 RVA: 0x0055A2B5 File Offset: 0x005584B5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06026E62 RID: 159330 RVA: 0x0055A2C7 File Offset: 0x005584C7
		public IStateRepPerfBaseT AsIStateRepPerfBase()
		{
			return this.As<IStateRepPerfBaseT>();
		}

		// Token: 0x06026E63 RID: 159331 RVA: 0x0055A2CF File Offset: 0x005584CF
		public static IStateRepPerfBase_UnionUnion FromIStateRepPerfBase(IStateRepPerfBaseT _istaterepperfbase)
		{
			return new IStateRepPerfBase_UnionUnion
			{
				Type = IStateRepPerfBase_Union.IStateRepPerfBase,
				Value = _istaterepperfbase
			};
		}

		// Token: 0x06026E64 RID: 159332 RVA: 0x0055A2E4 File Offset: 0x005584E4
		public IStateRepPerfSkillIdT AsIStateRepPerfSkillId()
		{
			return this.As<IStateRepPerfSkillIdT>();
		}

		// Token: 0x06026E65 RID: 159333 RVA: 0x0055A2EC File Offset: 0x005584EC
		public static IStateRepPerfBase_UnionUnion FromIStateRepPerfSkillId(IStateRepPerfSkillIdT _istaterepperfskillid)
		{
			return new IStateRepPerfBase_UnionUnion
			{
				Type = IStateRepPerfBase_Union.IStateRepPerfSkillId,
				Value = _istaterepperfskillid
			};
		}

		// Token: 0x06026E66 RID: 159334 RVA: 0x0055A301 File Offset: 0x00558501
		public IStateRepPerfMontagePathT AsIStateRepPerfMontagePath()
		{
			return this.As<IStateRepPerfMontagePathT>();
		}

		// Token: 0x06026E67 RID: 159335 RVA: 0x0055A309 File Offset: 0x00558509
		public static IStateRepPerfBase_UnionUnion FromIStateRepPerfMontagePath(IStateRepPerfMontagePathT _istaterepperfmontagepath)
		{
			return new IStateRepPerfBase_UnionUnion
			{
				Type = IStateRepPerfBase_Union.IStateRepPerfMontagePath,
				Value = _istaterepperfmontagepath
			};
		}

		// Token: 0x06026E68 RID: 159336 RVA: 0x0055A31E File Offset: 0x0055851E
		public IStateRepPerfEffectsT AsIStateRepPerfEffects()
		{
			return this.As<IStateRepPerfEffectsT>();
		}

		// Token: 0x06026E69 RID: 159337 RVA: 0x0055A326 File Offset: 0x00558526
		public static IStateRepPerfBase_UnionUnion FromIStateRepPerfEffects(IStateRepPerfEffectsT _istaterepperfeffects)
		{
			return new IStateRepPerfBase_UnionUnion
			{
				Type = IStateRepPerfBase_Union.IStateRepPerfEffects,
				Value = _istaterepperfeffects
			};
		}

		// Token: 0x06026E6A RID: 159338 RVA: 0x0055A33C File Offset: 0x0055853C
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
