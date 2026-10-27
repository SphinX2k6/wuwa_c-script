using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050F4 RID: 20724
	public class IDynamicPortalCreateMode_UnionUnion
	{
		// Token: 0x170096EF RID: 38639
		// (get) Token: 0x060215F3 RID: 136691 RVA: 0x004A2653 File Offset: 0x004A0853
		// (set) Token: 0x060215F4 RID: 136692 RVA: 0x004A265B File Offset: 0x004A085B
		public IDynamicPortalCreateMode_Union Type { get; set; }

		// Token: 0x170096F0 RID: 38640
		// (get) Token: 0x060215F5 RID: 136693 RVA: 0x004A2664 File Offset: 0x004A0864
		// (set) Token: 0x060215F6 RID: 136694 RVA: 0x004A266C File Offset: 0x004A086C
		public object Value { get; set; }

		// Token: 0x060215F7 RID: 136695 RVA: 0x004A2675 File Offset: 0x004A0875
		public IDynamicPortalCreateMode_UnionUnion()
		{
			this.Type = IDynamicPortalCreateMode_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060215F8 RID: 136696 RVA: 0x004A268B File Offset: 0x004A088B
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060215F9 RID: 136697 RVA: 0x004A269D File Offset: 0x004A089D
		public IDynamicPortalCreateModeT AsIDynamicPortalCreateMode()
		{
			return this.As<IDynamicPortalCreateModeT>();
		}

		// Token: 0x060215FA RID: 136698 RVA: 0x004A26A5 File Offset: 0x004A08A5
		public static IDynamicPortalCreateMode_UnionUnion FromIDynamicPortalCreateMode(IDynamicPortalCreateModeT _idynamicportalcreatemode)
		{
			return new IDynamicPortalCreateMode_UnionUnion
			{
				Type = IDynamicPortalCreateMode_Union.IDynamicPortalCreateMode,
				Value = _idynamicportalcreatemode
			};
		}

		// Token: 0x060215FB RID: 136699 RVA: 0x004A26BA File Offset: 0x004A08BA
		public IDynamicPortalByBulletT AsIDynamicPortalByBullet()
		{
			return this.As<IDynamicPortalByBulletT>();
		}

		// Token: 0x060215FC RID: 136700 RVA: 0x004A26C2 File Offset: 0x004A08C2
		public static IDynamicPortalCreateMode_UnionUnion FromIDynamicPortalByBullet(IDynamicPortalByBulletT _idynamicportalbybullet)
		{
			return new IDynamicPortalCreateMode_UnionUnion
			{
				Type = IDynamicPortalCreateMode_Union.IDynamicPortalByBullet,
				Value = _idynamicportalbybullet
			};
		}

		// Token: 0x060215FD RID: 136701 RVA: 0x004A26D8 File Offset: 0x004A08D8
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
