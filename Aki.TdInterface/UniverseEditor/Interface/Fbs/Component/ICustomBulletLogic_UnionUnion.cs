using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055BA RID: 21946
	public class ICustomBulletLogic_UnionUnion
	{
		// Token: 0x17009D1E RID: 40222
		// (get) Token: 0x06022E8D RID: 142989 RVA: 0x004CE7B1 File Offset: 0x004CC9B1
		// (set) Token: 0x06022E8E RID: 142990 RVA: 0x004CE7B9 File Offset: 0x004CC9B9
		public ICustomBulletLogic_Union Type { get; set; }

		// Token: 0x17009D1F RID: 40223
		// (get) Token: 0x06022E8F RID: 142991 RVA: 0x004CE7C2 File Offset: 0x004CC9C2
		// (set) Token: 0x06022E90 RID: 142992 RVA: 0x004CE7CA File Offset: 0x004CC9CA
		public object Value { get; set; }

		// Token: 0x06022E91 RID: 142993 RVA: 0x004CE7D3 File Offset: 0x004CC9D3
		public ICustomBulletLogic_UnionUnion()
		{
			this.Type = ICustomBulletLogic_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06022E92 RID: 142994 RVA: 0x004CE7E9 File Offset: 0x004CC9E9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06022E93 RID: 142995 RVA: 0x004CE7FB File Offset: 0x004CC9FB
		public ICustomBulletLogicT AsICustomBulletLogic()
		{
			return this.As<ICustomBulletLogicT>();
		}

		// Token: 0x06022E94 RID: 142996 RVA: 0x004CE803 File Offset: 0x004CCA03
		public static ICustomBulletLogic_UnionUnion FromICustomBulletLogic(ICustomBulletLogicT _icustombulletlogic)
		{
			return new ICustomBulletLogic_UnionUnion
			{
				Type = ICustomBulletLogic_Union.ICustomBulletLogic,
				Value = _icustombulletlogic
			};
		}

		// Token: 0x06022E95 RID: 142997 RVA: 0x004CE818 File Offset: 0x004CCA18
		public ITrafficBulletLogicT AsITrafficBulletLogic()
		{
			return this.As<ITrafficBulletLogicT>();
		}

		// Token: 0x06022E96 RID: 142998 RVA: 0x004CE820 File Offset: 0x004CCA20
		public static ICustomBulletLogic_UnionUnion FromITrafficBulletLogic(ITrafficBulletLogicT _itrafficbulletlogic)
		{
			return new ICustomBulletLogic_UnionUnion
			{
				Type = ICustomBulletLogic_Union.ITrafficBulletLogic,
				Value = _itrafficbulletlogic
			};
		}

		// Token: 0x06022E97 RID: 142999 RVA: 0x004CE838 File Offset: 0x004CCA38
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
