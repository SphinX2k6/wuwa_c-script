using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005659 RID: 22105
	public class IDynamicPortalCreateMode_UnionUnion
	{
		// Token: 0x17009EDC RID: 40668
		// (get) Token: 0x06023547 RID: 144711 RVA: 0x004DC5DF File Offset: 0x004DA7DF
		// (set) Token: 0x06023548 RID: 144712 RVA: 0x004DC5E7 File Offset: 0x004DA7E7
		public IDynamicPortalCreateMode_Union Type { get; set; }

		// Token: 0x17009EDD RID: 40669
		// (get) Token: 0x06023549 RID: 144713 RVA: 0x004DC5F0 File Offset: 0x004DA7F0
		// (set) Token: 0x0602354A RID: 144714 RVA: 0x004DC5F8 File Offset: 0x004DA7F8
		public object Value { get; set; }

		// Token: 0x0602354B RID: 144715 RVA: 0x004DC601 File Offset: 0x004DA801
		public IDynamicPortalCreateMode_UnionUnion()
		{
			this.Type = IDynamicPortalCreateMode_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602354C RID: 144716 RVA: 0x004DC617 File Offset: 0x004DA817
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602354D RID: 144717 RVA: 0x004DC629 File Offset: 0x004DA829
		public IDynamicPortalCreateModeT AsIDynamicPortalCreateMode()
		{
			return this.As<IDynamicPortalCreateModeT>();
		}

		// Token: 0x0602354E RID: 144718 RVA: 0x004DC631 File Offset: 0x004DA831
		public static IDynamicPortalCreateMode_UnionUnion FromIDynamicPortalCreateMode(IDynamicPortalCreateModeT _idynamicportalcreatemode)
		{
			return new IDynamicPortalCreateMode_UnionUnion
			{
				Type = IDynamicPortalCreateMode_Union.IDynamicPortalCreateMode,
				Value = _idynamicportalcreatemode
			};
		}

		// Token: 0x0602354F RID: 144719 RVA: 0x004DC646 File Offset: 0x004DA846
		public IDynamicPortalByBulletT AsIDynamicPortalByBullet()
		{
			return this.As<IDynamicPortalByBulletT>();
		}

		// Token: 0x06023550 RID: 144720 RVA: 0x004DC64E File Offset: 0x004DA84E
		public static IDynamicPortalCreateMode_UnionUnion FromIDynamicPortalByBullet(IDynamicPortalByBulletT _idynamicportalbybullet)
		{
			return new IDynamicPortalCreateMode_UnionUnion
			{
				Type = IDynamicPortalCreateMode_Union.IDynamicPortalByBullet,
				Value = _idynamicportalbybullet
			};
		}

		// Token: 0x06023551 RID: 144721 RVA: 0x004DC664 File Offset: 0x004DA864
		public static int Pack(FlatBufferBuilder builder, IDynamicPortalCreateMode_UnionUnion _o)
		{
			IDynamicPortalCreateMode_Union type = _o.Type;
			if (type == IDynamicPortalCreateMode_Union.IDynamicPortalCreateMode)
			{
				return IDynamicPortalCreateMode.Pack(builder, _o.AsIDynamicPortalCreateMode()).Value;
			}
			if (type != IDynamicPortalCreateMode_Union.IDynamicPortalByBullet)
			{
				return 0;
			}
			return IDynamicPortalByBullet.Pack(builder, _o.AsIDynamicPortalByBullet()).Value;
		}
	}
}
