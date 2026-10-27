using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005058 RID: 20568
	public class ICustomBulletLogic_UnionUnion
	{
		// Token: 0x17009538 RID: 38200
		// (get) Token: 0x06020F53 RID: 134995 RVA: 0x00494AFD File Offset: 0x00492CFD
		// (set) Token: 0x06020F54 RID: 134996 RVA: 0x00494B05 File Offset: 0x00492D05
		public ICustomBulletLogic_Union Type { get; set; }

		// Token: 0x17009539 RID: 38201
		// (get) Token: 0x06020F55 RID: 134997 RVA: 0x00494B0E File Offset: 0x00492D0E
		// (set) Token: 0x06020F56 RID: 134998 RVA: 0x00494B16 File Offset: 0x00492D16
		public object Value { get; set; }

		// Token: 0x06020F57 RID: 134999 RVA: 0x00494B1F File Offset: 0x00492D1F
		public ICustomBulletLogic_UnionUnion()
		{
			this.Type = ICustomBulletLogic_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06020F58 RID: 135000 RVA: 0x00494B35 File Offset: 0x00492D35
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06020F59 RID: 135001 RVA: 0x00494B47 File Offset: 0x00492D47
		public ICustomBulletLogicT AsICustomBulletLogic()
		{
			return this.As<ICustomBulletLogicT>();
		}

		// Token: 0x06020F5A RID: 135002 RVA: 0x00494B4F File Offset: 0x00492D4F
		public static ICustomBulletLogic_UnionUnion FromICustomBulletLogic(ICustomBulletLogicT _icustombulletlogic)
		{
			return new ICustomBulletLogic_UnionUnion
			{
				Type = ICustomBulletLogic_Union.ICustomBulletLogic,
				Value = _icustombulletlogic
			};
		}

		// Token: 0x06020F5B RID: 135003 RVA: 0x00494B64 File Offset: 0x00492D64
		public ITrafficBulletLogicT AsITrafficBulletLogic()
		{
			return this.As<ITrafficBulletLogicT>();
		}

		// Token: 0x06020F5C RID: 135004 RVA: 0x00494B6C File Offset: 0x00492D6C
		public static ICustomBulletLogic_UnionUnion FromITrafficBulletLogic(ITrafficBulletLogicT _itrafficbulletlogic)
		{
			return new ICustomBulletLogic_UnionUnion
			{
				Type = ICustomBulletLogic_Union.ITrafficBulletLogic,
				Value = _itrafficbulletlogic
			};
		}

		// Token: 0x06020F5D RID: 135005 RVA: 0x00494B84 File Offset: 0x00492D84
		public static int Pack(FlatBufferBuilder builder, ICustomBulletLogic_UnionUnion _o)
		{
			ICustomBulletLogic_Union type = _o.Type;
			if (type == ICustomBulletLogic_Union.ICustomBulletLogic)
			{
				return ICustomBulletLogic.Pack(builder, _o.AsICustomBulletLogic()).Value;
			}
			if (type != ICustomBulletLogic_Union.ITrafficBulletLogic)
			{
				return 0;
			}
			return ITrafficBulletLogic.Pack(builder, _o.AsITrafficBulletLogic()).Value;
		}
	}
}
