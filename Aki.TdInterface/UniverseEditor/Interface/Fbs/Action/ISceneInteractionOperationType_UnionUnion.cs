using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076BE RID: 30398
	public class ISceneInteractionOperationType_UnionUnion
	{
		// Token: 0x1700DEF6 RID: 57078
		// (get) Token: 0x06035529 RID: 218409 RVA: 0x00727345 File Offset: 0x00725545
		// (set) Token: 0x0603552A RID: 218410 RVA: 0x0072734D File Offset: 0x0072554D
		public ISceneInteractionOperationType_Union Type { get; set; }

		// Token: 0x1700DEF7 RID: 57079
		// (get) Token: 0x0603552B RID: 218411 RVA: 0x00727356 File Offset: 0x00725556
		// (set) Token: 0x0603552C RID: 218412 RVA: 0x0072735E File Offset: 0x0072555E
		public object Value { get; set; }

		// Token: 0x0603552D RID: 218413 RVA: 0x00727367 File Offset: 0x00725567
		public ISceneInteractionOperationType_UnionUnion()
		{
			this.Type = ISceneInteractionOperationType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0603552E RID: 218414 RVA: 0x0072737D File Offset: 0x0072557D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603552F RID: 218415 RVA: 0x0072738F File Offset: 0x0072558F
		public ISceneInteractionOperationTypeT AsISceneInteractionOperationType()
		{
			return this.As<ISceneInteractionOperationTypeT>();
		}

		// Token: 0x06035530 RID: 218416 RVA: 0x00727397 File Offset: 0x00725597
		public static ISceneInteractionOperationType_UnionUnion FromISceneInteractionOperationType(ISceneInteractionOperationTypeT _isceneinteractionoperationtype)
		{
			return new ISceneInteractionOperationType_UnionUnion
			{
				Type = ISceneInteractionOperationType_Union.ISceneInteractionOperationType,
				Value = _isceneinteractionoperationtype
			};
		}

		// Token: 0x06035531 RID: 218417 RVA: 0x007273AC File Offset: 0x007255AC
		public IEnableSceneInteractionOperationT AsIEnableSceneInteractionOperation()
		{
			return this.As<IEnableSceneInteractionOperationT>();
		}

		// Token: 0x06035532 RID: 218418 RVA: 0x007273B4 File Offset: 0x007255B4
		public static ISceneInteractionOperationType_UnionUnion FromIEnableSceneInteractionOperation(IEnableSceneInteractionOperationT _ienablesceneinteractionoperation)
		{
			return new ISceneInteractionOperationType_UnionUnion
			{
				Type = ISceneInteractionOperationType_Union.IEnableSceneInteractionOperation,
				Value = _ienablesceneinteractionoperation
			};
		}

		// Token: 0x06035533 RID: 218419 RVA: 0x007273C9 File Offset: 0x007255C9
		public IDisableSceneInteractionOperationT AsIDisableSceneInteractionOperation()
		{
			return this.As<IDisableSceneInteractionOperationT>();
		}

		// Token: 0x06035534 RID: 218420 RVA: 0x007273D1 File Offset: 0x007255D1
		public static ISceneInteractionOperationType_UnionUnion FromIDisableSceneInteractionOperation(IDisableSceneInteractionOperationT _idisablesceneinteractionoperation)
		{
			return new ISceneInteractionOperationType_UnionUnion
			{
				Type = ISceneInteractionOperationType_Union.IDisableSceneInteractionOperation,
				Value = _idisablesceneinteractionoperation
			};
		}

		// Token: 0x06035535 RID: 218421 RVA: 0x007273E8 File Offset: 0x007255E8
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
