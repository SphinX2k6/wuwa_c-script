using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F37 RID: 28471
	public class ISceneInteractionOperationType_UnionUnion
	{
		// Token: 0x1700D39A RID: 54170
		// (get) Token: 0x060324D1 RID: 206033 RVA: 0x006CB3DD File Offset: 0x006C95DD
		// (set) Token: 0x060324D2 RID: 206034 RVA: 0x006CB3E5 File Offset: 0x006C95E5
		public ISceneInteractionOperationType_Union Type { get; set; }

		// Token: 0x1700D39B RID: 54171
		// (get) Token: 0x060324D3 RID: 206035 RVA: 0x006CB3EE File Offset: 0x006C95EE
		// (set) Token: 0x060324D4 RID: 206036 RVA: 0x006CB3F6 File Offset: 0x006C95F6
		public object Value { get; set; }

		// Token: 0x060324D5 RID: 206037 RVA: 0x006CB3FF File Offset: 0x006C95FF
		public ISceneInteractionOperationType_UnionUnion()
		{
			this.Type = ISceneInteractionOperationType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060324D6 RID: 206038 RVA: 0x006CB415 File Offset: 0x006C9615
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060324D7 RID: 206039 RVA: 0x006CB427 File Offset: 0x006C9627
		public ISceneInteractionOperationTypeT AsISceneInteractionOperationType()
		{
			return this.As<ISceneInteractionOperationTypeT>();
		}

		// Token: 0x060324D8 RID: 206040 RVA: 0x006CB42F File Offset: 0x006C962F
		public static ISceneInteractionOperationType_UnionUnion FromISceneInteractionOperationType(ISceneInteractionOperationTypeT _isceneinteractionoperationtype)
		{
			return new ISceneInteractionOperationType_UnionUnion
			{
				Type = ISceneInteractionOperationType_Union.ISceneInteractionOperationType,
				Value = _isceneinteractionoperationtype
			};
		}

		// Token: 0x060324D9 RID: 206041 RVA: 0x006CB444 File Offset: 0x006C9644
		public IEnableSceneInteractionOperationT AsIEnableSceneInteractionOperation()
		{
			return this.As<IEnableSceneInteractionOperationT>();
		}

		// Token: 0x060324DA RID: 206042 RVA: 0x006CB44C File Offset: 0x006C964C
		public static ISceneInteractionOperationType_UnionUnion FromIEnableSceneInteractionOperation(IEnableSceneInteractionOperationT _ienablesceneinteractionoperation)
		{
			return new ISceneInteractionOperationType_UnionUnion
			{
				Type = ISceneInteractionOperationType_Union.IEnableSceneInteractionOperation,
				Value = _ienablesceneinteractionoperation
			};
		}

		// Token: 0x060324DB RID: 206043 RVA: 0x006CB461 File Offset: 0x006C9661
		public IDisableSceneInteractionOperationT AsIDisableSceneInteractionOperation()
		{
			return this.As<IDisableSceneInteractionOperationT>();
		}

		// Token: 0x060324DC RID: 206044 RVA: 0x006CB469 File Offset: 0x006C9669
		public static ISceneInteractionOperationType_UnionUnion FromIDisableSceneInteractionOperation(IDisableSceneInteractionOperationT _idisablesceneinteractionoperation)
		{
			return new ISceneInteractionOperationType_UnionUnion
			{
				Type = ISceneInteractionOperationType_Union.IDisableSceneInteractionOperation,
				Value = _idisablesceneinteractionoperation
			};
		}

		// Token: 0x060324DD RID: 206045 RVA: 0x006CB480 File Offset: 0x006C9680
		public static int Pack(FlatBufferBuilder builder, ISceneInteractionOperationType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ISceneInteractionOperationType_Union.ISceneInteractionOperationType:
				return ISceneInteractionOperationType.Pack(builder, _o.AsISceneInteractionOperationType()).Value;
			case ISceneInteractionOperationType_Union.IEnableSceneInteractionOperation:
				return IEnableSceneInteractionOperation.Pack(builder, _o.AsIEnableSceneInteractionOperation()).Value;
			case ISceneInteractionOperationType_Union.IDisableSceneInteractionOperation:
				return IDisableSceneInteractionOperation.Pack(builder, _o.AsIDisableSceneInteractionOperation()).Value;
			default:
				return 0;
			}
		}
	}
}
