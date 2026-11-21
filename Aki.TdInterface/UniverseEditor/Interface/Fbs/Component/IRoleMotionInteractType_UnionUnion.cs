using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E8D RID: 24205
	public class IRoleMotionInteractType_UnionUnion
	{
		// Token: 0x1700B2A0 RID: 45728
		// (get) Token: 0x06028826 RID: 165926 RVA: 0x00589F81 File Offset: 0x00588181
		// (set) Token: 0x06028827 RID: 165927 RVA: 0x00589F89 File Offset: 0x00588189
		public IRoleMotionInteractType_Union Type { get; set; }

		// Token: 0x1700B2A1 RID: 45729
		// (get) Token: 0x06028828 RID: 165928 RVA: 0x00589F92 File Offset: 0x00588192
		// (set) Token: 0x06028829 RID: 165929 RVA: 0x00589F9A File Offset: 0x0058819A
		public object Value { get; set; }

		// Token: 0x0602882A RID: 165930 RVA: 0x00589FA3 File Offset: 0x005881A3
		public IRoleMotionInteractType_UnionUnion()
		{
			this.Type = IRoleMotionInteractType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602882B RID: 165931 RVA: 0x00589FB9 File Offset: 0x005881B9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602882C RID: 165932 RVA: 0x00589FCB File Offset: 0x005881CB
		public IRoleMotionInteractTypeT AsIRoleMotionInteractType()
		{
			return this.As<IRoleMotionInteractTypeT>();
		}

		// Token: 0x0602882D RID: 165933 RVA: 0x00589FD3 File Offset: 0x005881D3
		public static IRoleMotionInteractType_UnionUnion FromIRoleMotionInteractType(IRoleMotionInteractTypeT _irolemotioninteracttype)
		{
			return new IRoleMotionInteractType_UnionUnion
			{
				Type = IRoleMotionInteractType_Union.IRoleMotionInteractType,
				Value = _irolemotioninteracttype
			};
		}

		// Token: 0x0602882E RID: 165934 RVA: 0x00589FE8 File Offset: 0x005881E8
		public IPetalGrabRoleMotionInteractT AsIPetalGrabRoleMotionInteract()
		{
			return this.As<IPetalGrabRoleMotionInteractT>();
		}

		// Token: 0x0602882F RID: 165935 RVA: 0x00589FF0 File Offset: 0x005881F0
		public static IRoleMotionInteractType_UnionUnion FromIPetalGrabRoleMotionInteract(IPetalGrabRoleMotionInteractT _ipetalgrabrolemotioninteract)
		{
			return new IRoleMotionInteractType_UnionUnion
			{
				Type = IRoleMotionInteractType_Union.IPetalGrabRoleMotionInteract,
				Value = _ipetalgrabrolemotioninteract
			};
		}

		// Token: 0x06028830 RID: 165936 RVA: 0x0058A008 File Offset: 0x00588208
		public static int Pack(FlatBufferBuilder builder, IRoleMotionInteractType_UnionUnion _o)
		{
			IRoleMotionInteractType_Union type = _o.Type;
			if (type == IRoleMotionInteractType_Union.IRoleMotionInteractType)
			{
				return IRoleMotionInteractType.Pack(builder, _o.AsIRoleMotionInteractType()).Value;
			}
			if (type != IRoleMotionInteractType_Union.IPetalGrabRoleMotionInteract)
			{
				return 0;
			}
			return IPetalGrabRoleMotionInteract.Pack(builder, _o.AsIPetalGrabRoleMotionInteract()).Value;
		}
	}
}
