using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AD5 RID: 23253
	public class IMechHookInteractType_UnionUnion
	{
		// Token: 0x1700A992 RID: 43410
		// (get) Token: 0x06026296 RID: 156310 RVA: 0x0053AB35 File Offset: 0x00538D35
		// (set) Token: 0x06026297 RID: 156311 RVA: 0x0053AB3D File Offset: 0x00538D3D
		public IMechHookInteractType_Union Type { get; set; }

		// Token: 0x1700A993 RID: 43411
		// (get) Token: 0x06026298 RID: 156312 RVA: 0x0053AB46 File Offset: 0x00538D46
		// (set) Token: 0x06026299 RID: 156313 RVA: 0x0053AB4E File Offset: 0x00538D4E
		public object Value { get; set; }

		// Token: 0x0602629A RID: 156314 RVA: 0x0053AB57 File Offset: 0x00538D57
		public IMechHookInteractType_UnionUnion()
		{
			this.Type = IMechHookInteractType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602629B RID: 156315 RVA: 0x0053AB6D File Offset: 0x00538D6D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602629C RID: 156316 RVA: 0x0053AB7F File Offset: 0x00538D7F
		public IMechHookInteractTypeT AsIMechHookInteractType()
		{
			return this.As<IMechHookInteractTypeT>();
		}

		// Token: 0x0602629D RID: 156317 RVA: 0x0053AB87 File Offset: 0x00538D87
		public static IMechHookInteractType_UnionUnion FromIMechHookInteractType(IMechHookInteractTypeT _imechhookinteracttype)
		{
			return new IMechHookInteractType_UnionUnion
			{
				Type = IMechHookInteractType_Union.IMechHookInteractType,
				Value = _imechhookinteracttype
			};
		}

		// Token: 0x0602629E RID: 156318 RVA: 0x0053AB9C File Offset: 0x00538D9C
		public IMechBurrowHookInteractT AsIMechBurrowHookInteract()
		{
			return this.As<IMechBurrowHookInteractT>();
		}

		// Token: 0x0602629F RID: 156319 RVA: 0x0053ABA4 File Offset: 0x00538DA4
		public static IMechHookInteractType_UnionUnion FromIMechBurrowHookInteract(IMechBurrowHookInteractT _imechburrowhookinteract)
		{
			return new IMechHookInteractType_UnionUnion
			{
				Type = IMechHookInteractType_Union.IMechBurrowHookInteract,
				Value = _imechburrowhookinteract
			};
		}

		// Token: 0x060262A0 RID: 156320 RVA: 0x0053ABB9 File Offset: 0x00538DB9
		public IMechFixedPointHookInteractT AsIMechFixedPointHookInteract()
		{
			return this.As<IMechFixedPointHookInteractT>();
		}

		// Token: 0x060262A1 RID: 156321 RVA: 0x0053ABC1 File Offset: 0x00538DC1
		public static IMechHookInteractType_UnionUnion FromIMechFixedPointHookInteract(IMechFixedPointHookInteractT _imechfixedpointhookinteract)
		{
			return new IMechHookInteractType_UnionUnion
			{
				Type = IMechHookInteractType_Union.IMechFixedPointHookInteract,
				Value = _imechfixedpointhookinteract
			};
		}

		// Token: 0x060262A2 RID: 156322 RVA: 0x0053ABD6 File Offset: 0x00538DD6
		public IMechPullHookInteractT AsIMechPullHookInteract()
		{
			return this.As<IMechPullHookInteractT>();
		}

		// Token: 0x060262A3 RID: 156323 RVA: 0x0053ABDE File Offset: 0x00538DDE
		public static IMechHookInteractType_UnionUnion FromIMechPullHookInteract(IMechPullHookInteractT _imechpullhookinteract)
		{
			return new IMechHookInteractType_UnionUnion
			{
				Type = IMechHookInteractType_Union.IMechPullHookInteract,
				Value = _imechpullhookinteract
			};
		}

		// Token: 0x060262A4 RID: 156324 RVA: 0x0053ABF4 File Offset: 0x00538DF4
		public static int Pack(FlatBufferBuilder builder, IMechHookInteractType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IMechHookInteractType_Union.IMechHookInteractType:
				return IMechHookInteractType.Pack(builder, _o.AsIMechHookInteractType()).Value;
			case IMechHookInteractType_Union.IMechBurrowHookInteract:
				return IMechBurrowHookInteract.Pack(builder, _o.AsIMechBurrowHookInteract()).Value;
			case IMechHookInteractType_Union.IMechFixedPointHookInteract:
				return IMechFixedPointHookInteract.Pack(builder, _o.AsIMechFixedPointHookInteract()).Value;
			case IMechHookInteractType_Union.IMechPullHookInteract:
				return IMechPullHookInteract.Pack(builder, _o.AsIMechPullHookInteract()).Value;
			default:
				return 0;
			}
		}
	}
}
