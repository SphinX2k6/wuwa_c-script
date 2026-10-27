using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007395 RID: 29589
	public class ITeleportToLatestResetPointType_UnionUnion
	{
		// Token: 0x1700E098 RID: 57496
		// (get) Token: 0x06035B43 RID: 219971 RVA: 0x0074FAC5 File Offset: 0x0074DCC5
		// (set) Token: 0x06035B44 RID: 219972 RVA: 0x0074FACD File Offset: 0x0074DCCD
		public ITeleportToLatestResetPointType_Union Type { get; set; }

		// Token: 0x1700E099 RID: 57497
		// (get) Token: 0x06035B45 RID: 219973 RVA: 0x0074FAD6 File Offset: 0x0074DCD6
		// (set) Token: 0x06035B46 RID: 219974 RVA: 0x0074FADE File Offset: 0x0074DCDE
		public object Value { get; set; }

		// Token: 0x06035B47 RID: 219975 RVA: 0x0074FAE7 File Offset: 0x0074DCE7
		public ITeleportToLatestResetPointType_UnionUnion()
		{
			this.Type = ITeleportToLatestResetPointType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06035B48 RID: 219976 RVA: 0x0074FAFD File Offset: 0x0074DCFD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06035B49 RID: 219977 RVA: 0x0074FB0F File Offset: 0x0074DD0F
		public ITeleportToLatestResetPointTypeT AsITeleportToLatestResetPointType()
		{
			return this.As<ITeleportToLatestResetPointTypeT>();
		}

		// Token: 0x06035B4A RID: 219978 RVA: 0x0074FB17 File Offset: 0x0074DD17
		public static ITeleportToLatestResetPointType_UnionUnion FromITeleportToLatestResetPointType(ITeleportToLatestResetPointTypeT _iteleporttolatestresetpointtype)
		{
			return new ITeleportToLatestResetPointType_UnionUnion
			{
				Type = ITeleportToLatestResetPointType_Union.ITeleportToLatestResetPointType,
				Value = _iteleporttolatestresetpointtype
			};
		}

		// Token: 0x06035B4B RID: 219979 RVA: 0x0074FB2C File Offset: 0x0074DD2C
		public ITeleportToLatestResetPointDirectlyT AsITeleportToLatestResetPointDirectly()
		{
			return this.As<ITeleportToLatestResetPointDirectlyT>();
		}

		// Token: 0x06035B4C RID: 219980 RVA: 0x0074FB34 File Offset: 0x0074DD34
		public static ITeleportToLatestResetPointType_UnionUnion FromITeleportToLatestResetPointDirectly(ITeleportToLatestResetPointDirectlyT _iteleporttolatestresetpointdirectly)
		{
			return new ITeleportToLatestResetPointType_UnionUnion
			{
				Type = ITeleportToLatestResetPointType_Union.ITeleportToLatestResetPointDirectly,
				Value = _iteleporttolatestresetpointdirectly
			};
		}

		// Token: 0x06035B4D RID: 219981 RVA: 0x0074FB4C File Offset: 0x0074DD4C
		public static int Pack(FlatBufferBuilder builder, ITeleportToLatestResetPointType_UnionUnion _o)
		{
			ITeleportToLatestResetPointType_Union type = _o.Type;
			if (type == ITeleportToLatestResetPointType_Union.ITeleportToLatestResetPointType)
			{
				return ITeleportToLatestResetPointType.Pack(builder, _o.AsITeleportToLatestResetPointType()).Value;
			}
			if (type != ITeleportToLatestResetPointType_Union.ITeleportToLatestResetPointDirectly)
			{
				return 0;
			}
			return ITeleportToLatestResetPointDirectly.Pack(builder, _o.AsITeleportToLatestResetPointDirectly()).Value;
		}
	}
}
