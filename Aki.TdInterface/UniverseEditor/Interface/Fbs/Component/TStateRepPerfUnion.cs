using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062E0 RID: 25312
	public class TStateRepPerfUnion
	{
		// Token: 0x1700BBAC RID: 48044
		// (get) Token: 0x0602B047 RID: 176199 RVA: 0x005DDB1B File Offset: 0x005DBD1B
		// (set) Token: 0x0602B048 RID: 176200 RVA: 0x005DDB23 File Offset: 0x005DBD23
		public TStateRepPerf Type { get; set; }

		// Token: 0x1700BBAD RID: 48045
		// (get) Token: 0x0602B049 RID: 176201 RVA: 0x005DDB2C File Offset: 0x005DBD2C
		// (set) Token: 0x0602B04A RID: 176202 RVA: 0x005DDB34 File Offset: 0x005DBD34
		public object Value { get; set; }

		// Token: 0x0602B04B RID: 176203 RVA: 0x005DDB3D File Offset: 0x005DBD3D
		public TStateRepPerfUnion()
		{
			this.Type = TStateRepPerf.NONE;
			this.Value = null;
		}

		// Token: 0x0602B04C RID: 176204 RVA: 0x005DDB53 File Offset: 0x005DBD53
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602B04D RID: 176205 RVA: 0x005DDB65 File Offset: 0x005DBD65
		public IStateRepPerfEffectsT AsIStateRepPerfEffects()
		{
			return this.As<IStateRepPerfEffectsT>();
		}

		// Token: 0x0602B04E RID: 176206 RVA: 0x005DDB6D File Offset: 0x005DBD6D
		public static TStateRepPerfUnion FromIStateRepPerfEffects(IStateRepPerfEffectsT _istaterepperfeffects)
		{
			return new TStateRepPerfUnion
			{
				Type = TStateRepPerf.IStateRepPerfEffects,
				Value = _istaterepperfeffects
			};
		}

		// Token: 0x0602B04F RID: 176207 RVA: 0x005DDB82 File Offset: 0x005DBD82
		public IStateRepPerfMontagePathT AsIStateRepPerfMontagePath()
		{
			return this.As<IStateRepPerfMontagePathT>();
		}

		// Token: 0x0602B050 RID: 176208 RVA: 0x005DDB8A File Offset: 0x005DBD8A
		public static TStateRepPerfUnion FromIStateRepPerfMontagePath(IStateRepPerfMontagePathT _istaterepperfmontagepath)
		{
			return new TStateRepPerfUnion
			{
				Type = TStateRepPerf.IStateRepPerfMontagePath,
				Value = _istaterepperfmontagepath
			};
		}

		// Token: 0x0602B051 RID: 176209 RVA: 0x005DDB9F File Offset: 0x005DBD9F
		public IStateRepPerfSkillIdT AsIStateRepPerfSkillId()
		{
			return this.As<IStateRepPerfSkillIdT>();
		}

		// Token: 0x0602B052 RID: 176210 RVA: 0x005DDBA7 File Offset: 0x005DBDA7
		public static TStateRepPerfUnion FromIStateRepPerfSkillId(IStateRepPerfSkillIdT _istaterepperfskillid)
		{
			return new TStateRepPerfUnion
			{
				Type = TStateRepPerf.IStateRepPerfSkillId,
				Value = _istaterepperfskillid
			};
		}

		// Token: 0x0602B053 RID: 176211 RVA: 0x005DDBBC File Offset: 0x005DBDBC
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
