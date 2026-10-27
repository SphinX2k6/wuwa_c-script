using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007053 RID: 28755
	public class ISetPlayerOperationRestriction_UnionUnion
	{
		// Token: 0x1700D594 RID: 54676
		// (get) Token: 0x06032E25 RID: 208421 RVA: 0x006DCF89 File Offset: 0x006DB189
		// (set) Token: 0x06032E26 RID: 208422 RVA: 0x006DCF91 File Offset: 0x006DB191
		public ISetPlayerOperationRestriction_Union Type { get; set; }

		// Token: 0x1700D595 RID: 54677
		// (get) Token: 0x06032E27 RID: 208423 RVA: 0x006DCF9A File Offset: 0x006DB19A
		// (set) Token: 0x06032E28 RID: 208424 RVA: 0x006DCFA2 File Offset: 0x006DB1A2
		public object Value { get; set; }

		// Token: 0x06032E29 RID: 208425 RVA: 0x006DCFAB File Offset: 0x006DB1AB
		public ISetPlayerOperationRestriction_UnionUnion()
		{
			this.Type = ISetPlayerOperationRestriction_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06032E2A RID: 208426 RVA: 0x006DCFC1 File Offset: 0x006DB1C1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06032E2B RID: 208427 RVA: 0x006DCFD3 File Offset: 0x006DB1D3
		public ISetPlayerOperationRestrictionT AsISetPlayerOperationRestriction()
		{
			return this.As<ISetPlayerOperationRestrictionT>();
		}

		// Token: 0x06032E2C RID: 208428 RVA: 0x006DCFDB File Offset: 0x006DB1DB
		public static ISetPlayerOperationRestriction_UnionUnion FromISetPlayerOperationRestriction(ISetPlayerOperationRestrictionT _isetplayeroperationrestriction)
		{
			return new ISetPlayerOperationRestriction_UnionUnion
			{
				Type = ISetPlayerOperationRestriction_Union.ISetPlayerOperationRestriction,
				Value = _isetplayeroperationrestriction
			};
		}

		// Token: 0x06032E2D RID: 208429 RVA: 0x006DCFF0 File Offset: 0x006DB1F0
		public IEnableAllPlayerOperationT AsIEnableAllPlayerOperation()
		{
			return this.As<IEnableAllPlayerOperationT>();
		}

		// Token: 0x06032E2E RID: 208430 RVA: 0x006DCFF8 File Offset: 0x006DB1F8
		public static ISetPlayerOperationRestriction_UnionUnion FromIEnableAllPlayerOperation(IEnableAllPlayerOperationT _ienableallplayeroperation)
		{
			return new ISetPlayerOperationRestriction_UnionUnion
			{
				Type = ISetPlayerOperationRestriction_Union.IEnableAllPlayerOperation,
				Value = _ienableallplayeroperation
			};
		}

		// Token: 0x06032E2F RID: 208431 RVA: 0x006DD00D File Offset: 0x006DB20D
		public IDisableAllPlayerOperationT AsIDisableAllPlayerOperation()
		{
			return this.As<IDisableAllPlayerOperationT>();
		}

		// Token: 0x06032E30 RID: 208432 RVA: 0x006DD015 File Offset: 0x006DB215
		public static ISetPlayerOperationRestriction_UnionUnion FromIDisableAllPlayerOperation(IDisableAllPlayerOperationT _idisableallplayeroperation)
		{
			return new ISetPlayerOperationRestriction_UnionUnion
			{
				Type = ISetPlayerOperationRestriction_Union.IDisableAllPlayerOperation,
				Value = _idisableallplayeroperation
			};
		}

		// Token: 0x06032E31 RID: 208433 RVA: 0x006DD02A File Offset: 0x006DB22A
		public IDisableModulePlayerOperationT AsIDisableModulePlayerOperation()
		{
			return this.As<IDisableModulePlayerOperationT>();
		}

		// Token: 0x06032E32 RID: 208434 RVA: 0x006DD032 File Offset: 0x006DB232
		public static ISetPlayerOperationRestriction_UnionUnion FromIDisableModulePlayerOperation(IDisableModulePlayerOperationT _idisablemoduleplayeroperation)
		{
			return new ISetPlayerOperationRestriction_UnionUnion
			{
				Type = ISetPlayerOperationRestriction_Union.IDisableModulePlayerOperation,
				Value = _idisablemoduleplayeroperation
			};
		}

		// Token: 0x06032E33 RID: 208435 RVA: 0x006DD048 File Offset: 0x006DB248
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
