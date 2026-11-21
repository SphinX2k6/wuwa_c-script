using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A36 RID: 27190
	public class IClientExecEntityPrefabOption_UnionUnion
	{
		// Token: 0x1700C7D0 RID: 51152
		// (get) Token: 0x0602EA35 RID: 191029 RVA: 0x0065BC6D File Offset: 0x00659E6D
		// (set) Token: 0x0602EA36 RID: 191030 RVA: 0x0065BC75 File Offset: 0x00659E75
		public IClientExecEntityPrefabOption_Union Type { get; set; }

		// Token: 0x1700C7D1 RID: 51153
		// (get) Token: 0x0602EA37 RID: 191031 RVA: 0x0065BC7E File Offset: 0x00659E7E
		// (set) Token: 0x0602EA38 RID: 191032 RVA: 0x0065BC86 File Offset: 0x00659E86
		public object Value { get; set; }

		// Token: 0x0602EA39 RID: 191033 RVA: 0x0065BC8F File Offset: 0x00659E8F
		public IClientExecEntityPrefabOption_UnionUnion()
		{
			this.Type = IClientExecEntityPrefabOption_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602EA3A RID: 191034 RVA: 0x0065BCA5 File Offset: 0x00659EA5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602EA3B RID: 191035 RVA: 0x0065BCB7 File Offset: 0x00659EB7
		public IClientExecEntityPrefabOptionT AsIClientExecEntityPrefabOption()
		{
			return this.As<IClientExecEntityPrefabOptionT>();
		}

		// Token: 0x0602EA3C RID: 191036 RVA: 0x0065BCBF File Offset: 0x00659EBF
		public static IClientExecEntityPrefabOption_UnionUnion FromIClientExecEntityPrefabOption(IClientExecEntityPrefabOptionT _iclientexecentityprefaboption)
		{
			return new IClientExecEntityPrefabOption_UnionUnion
			{
				Type = IClientExecEntityPrefabOption_Union.IClientExecEntityPrefabOption,
				Value = _iclientexecentityprefaboption
			};
		}

		// Token: 0x0602EA3D RID: 191037 RVA: 0x0065BCD4 File Offset: 0x00659ED4
		public IClientModifyEntityPrefabParamsT AsIClientModifyEntityPrefabParams()
		{
			return this.As<IClientModifyEntityPrefabParamsT>();
		}

		// Token: 0x0602EA3E RID: 191038 RVA: 0x0065BCDC File Offset: 0x00659EDC
		public static IClientExecEntityPrefabOption_UnionUnion FromIClientModifyEntityPrefabParams(IClientModifyEntityPrefabParamsT _iclientmodifyentityprefabparams)
		{
			return new IClientExecEntityPrefabOption_UnionUnion
			{
				Type = IClientExecEntityPrefabOption_Union.IClientModifyEntityPrefabParams,
				Value = _iclientmodifyentityprefabparams
			};
		}

		// Token: 0x0602EA3F RID: 191039 RVA: 0x0065BCF4 File Offset: 0x00659EF4
		public static int Pack(FlatBufferBuilder builder, IClientExecEntityPrefabOption_UnionUnion _o)
		{
			IClientExecEntityPrefabOption_Union type = _o.Type;
			if (type == IClientExecEntityPrefabOption_Union.IClientExecEntityPrefabOption)
			{
				return IClientExecEntityPrefabOption.Pack(builder, _o.AsIClientExecEntityPrefabOption()).Value;
			}
			if (type != IClientExecEntityPrefabOption_Union.IClientModifyEntityPrefabParams)
			{
				return 0;
			}
			return IClientModifyEntityPrefabParams.Pack(builder, _o.AsIClientModifyEntityPrefabParams()).Value;
		}
	}
}
