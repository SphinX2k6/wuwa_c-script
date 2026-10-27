using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005880 RID: 22656
	public class IRoleMotionInteractType_UnionUnion
	{
		// Token: 0x1700A970 RID: 43376
		// (get) Token: 0x060262C4 RID: 156356 RVA: 0x00543435 File Offset: 0x00541635
		// (set) Token: 0x060262C5 RID: 156357 RVA: 0x0054343D File Offset: 0x0054163D
		public IRoleMotionInteractType_Union Type { get; set; }

		// Token: 0x1700A971 RID: 43377
		// (get) Token: 0x060262C6 RID: 156358 RVA: 0x00543446 File Offset: 0x00541646
		// (set) Token: 0x060262C7 RID: 156359 RVA: 0x0054344E File Offset: 0x0054164E
		public object Value { get; set; }

		// Token: 0x060262C8 RID: 156360 RVA: 0x00543457 File Offset: 0x00541657
		public IRoleMotionInteractType_UnionUnion()
		{
			this.Type = IRoleMotionInteractType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060262C9 RID: 156361 RVA: 0x0054346D File Offset: 0x0054166D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060262CA RID: 156362 RVA: 0x0054347F File Offset: 0x0054167F
		public IRoleMotionInteractTypeT AsIRoleMotionInteractType()
		{
			return this.As<IRoleMotionInteractTypeT>();
		}

		// Token: 0x060262CB RID: 156363 RVA: 0x00543487 File Offset: 0x00541687
		public static IRoleMotionInteractType_UnionUnion FromIRoleMotionInteractType(IRoleMotionInteractTypeT _irolemotioninteracttype)
		{
			return new IRoleMotionInteractType_UnionUnion
			{
				Type = IRoleMotionInteractType_Union.IRoleMotionInteractType,
				Value = _irolemotioninteracttype
			};
		}

		// Token: 0x060262CC RID: 156364 RVA: 0x0054349C File Offset: 0x0054169C
		public IPetalGrabRoleMotionInteractT AsIPetalGrabRoleMotionInteract()
		{
			return this.As<IPetalGrabRoleMotionInteractT>();
		}

		// Token: 0x060262CD RID: 156365 RVA: 0x005434A4 File Offset: 0x005416A4
		public static IRoleMotionInteractType_UnionUnion FromIPetalGrabRoleMotionInteract(IPetalGrabRoleMotionInteractT _ipetalgrabrolemotioninteract)
		{
			return new IRoleMotionInteractType_UnionUnion
			{
				Type = IRoleMotionInteractType_Union.IPetalGrabRoleMotionInteract,
				Value = _ipetalgrabrolemotioninteract
			};
		}

		// Token: 0x060262CE RID: 156366 RVA: 0x005434BC File Offset: 0x005416BC
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
