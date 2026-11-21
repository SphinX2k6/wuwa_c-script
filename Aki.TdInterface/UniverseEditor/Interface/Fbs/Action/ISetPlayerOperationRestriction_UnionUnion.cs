using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200781F RID: 30751
	public class ISetPlayerOperationRestriction_UnionUnion
	{
		// Token: 0x1700E175 RID: 57717
		// (get) Token: 0x060360C2 RID: 221378 RVA: 0x0073D4B1 File Offset: 0x0073B6B1
		// (set) Token: 0x060360C3 RID: 221379 RVA: 0x0073D4B9 File Offset: 0x0073B6B9
		public ISetPlayerOperationRestriction_Union Type { get; set; }

		// Token: 0x1700E176 RID: 57718
		// (get) Token: 0x060360C4 RID: 221380 RVA: 0x0073D4C2 File Offset: 0x0073B6C2
		// (set) Token: 0x060360C5 RID: 221381 RVA: 0x0073D4CA File Offset: 0x0073B6CA
		public object Value { get; set; }

		// Token: 0x060360C6 RID: 221382 RVA: 0x0073D4D3 File Offset: 0x0073B6D3
		public ISetPlayerOperationRestriction_UnionUnion()
		{
			this.Type = ISetPlayerOperationRestriction_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060360C7 RID: 221383 RVA: 0x0073D4E9 File Offset: 0x0073B6E9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060360C8 RID: 221384 RVA: 0x0073D4FB File Offset: 0x0073B6FB
		public ISetPlayerOperationRestrictionT AsISetPlayerOperationRestriction()
		{
			return this.As<ISetPlayerOperationRestrictionT>();
		}

		// Token: 0x060360C9 RID: 221385 RVA: 0x0073D503 File Offset: 0x0073B703
		public static ISetPlayerOperationRestriction_UnionUnion FromISetPlayerOperationRestriction(ISetPlayerOperationRestrictionT _isetplayeroperationrestriction)
		{
			return new ISetPlayerOperationRestriction_UnionUnion
			{
				Type = ISetPlayerOperationRestriction_Union.ISetPlayerOperationRestriction,
				Value = _isetplayeroperationrestriction
			};
		}

		// Token: 0x060360CA RID: 221386 RVA: 0x0073D518 File Offset: 0x0073B718
		public IEnableAllPlayerOperationT AsIEnableAllPlayerOperation()
		{
			return this.As<IEnableAllPlayerOperationT>();
		}

		// Token: 0x060360CB RID: 221387 RVA: 0x0073D520 File Offset: 0x0073B720
		public static ISetPlayerOperationRestriction_UnionUnion FromIEnableAllPlayerOperation(IEnableAllPlayerOperationT _ienableallplayeroperation)
		{
			return new ISetPlayerOperationRestriction_UnionUnion
			{
				Type = ISetPlayerOperationRestriction_Union.IEnableAllPlayerOperation,
				Value = _ienableallplayeroperation
			};
		}

		// Token: 0x060360CC RID: 221388 RVA: 0x0073D535 File Offset: 0x0073B735
		public IDisableAllPlayerOperationT AsIDisableAllPlayerOperation()
		{
			return this.As<IDisableAllPlayerOperationT>();
		}

		// Token: 0x060360CD RID: 221389 RVA: 0x0073D53D File Offset: 0x0073B73D
		public static ISetPlayerOperationRestriction_UnionUnion FromIDisableAllPlayerOperation(IDisableAllPlayerOperationT _idisableallplayeroperation)
		{
			return new ISetPlayerOperationRestriction_UnionUnion
			{
				Type = ISetPlayerOperationRestriction_Union.IDisableAllPlayerOperation,
				Value = _idisableallplayeroperation
			};
		}

		// Token: 0x060360CE RID: 221390 RVA: 0x0073D552 File Offset: 0x0073B752
		public IDisableModulePlayerOperationT AsIDisableModulePlayerOperation()
		{
			return this.As<IDisableModulePlayerOperationT>();
		}

		// Token: 0x060360CF RID: 221391 RVA: 0x0073D55A File Offset: 0x0073B75A
		public static ISetPlayerOperationRestriction_UnionUnion FromIDisableModulePlayerOperation(IDisableModulePlayerOperationT _idisablemoduleplayeroperation)
		{
			return new ISetPlayerOperationRestriction_UnionUnion
			{
				Type = ISetPlayerOperationRestriction_Union.IDisableModulePlayerOperation,
				Value = _idisablemoduleplayeroperation
			};
		}

		// Token: 0x060360D0 RID: 221392 RVA: 0x0073D570 File Offset: 0x0073B770
		public static int Pack(FlatBufferBuilder builder, ISetPlayerOperationRestriction_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ISetPlayerOperationRestriction_Union.ISetPlayerOperationRestriction:
				return ISetPlayerOperationRestriction.Pack(builder, _o.AsISetPlayerOperationRestriction()).Value;
			case ISetPlayerOperationRestriction_Union.IEnableAllPlayerOperation:
				return IEnableAllPlayerOperation.Pack(builder, _o.AsIEnableAllPlayerOperation()).Value;
			case ISetPlayerOperationRestriction_Union.IDisableAllPlayerOperation:
				return IDisableAllPlayerOperation.Pack(builder, _o.AsIDisableAllPlayerOperation()).Value;
			case ISetPlayerOperationRestriction_Union.IDisableModulePlayerOperation:
				return IDisableModulePlayerOperation.Pack(builder, _o.AsIDisableModulePlayerOperation()).Value;
			default:
				return 0;
			}
		}
	}
}
