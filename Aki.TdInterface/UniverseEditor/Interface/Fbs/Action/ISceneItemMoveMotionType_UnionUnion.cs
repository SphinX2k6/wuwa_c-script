using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076C4 RID: 30404
	public class ISceneItemMoveMotionType_UnionUnion
	{
		// Token: 0x1700DEFB RID: 57083
		// (get) Token: 0x06035549 RID: 218441 RVA: 0x00727605 File Offset: 0x00725805
		// (set) Token: 0x0603554A RID: 218442 RVA: 0x0072760D File Offset: 0x0072580D
		public ISceneItemMoveMotionType_Union Type { get; set; }

		// Token: 0x1700DEFC RID: 57084
		// (get) Token: 0x0603554B RID: 218443 RVA: 0x00727616 File Offset: 0x00725816
		// (set) Token: 0x0603554C RID: 218444 RVA: 0x0072761E File Offset: 0x0072581E
		public object Value { get; set; }

		// Token: 0x0603554D RID: 218445 RVA: 0x00727627 File Offset: 0x00725827
		public ISceneItemMoveMotionType_UnionUnion()
		{
			this.Type = ISceneItemMoveMotionType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0603554E RID: 218446 RVA: 0x0072763D File Offset: 0x0072583D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603554F RID: 218447 RVA: 0x0072764F File Offset: 0x0072584F
		public ISceneItemMoveMotionTypeT AsISceneItemMoveMotionType()
		{
			return this.As<ISceneItemMoveMotionTypeT>();
		}

		// Token: 0x06035550 RID: 218448 RVA: 0x00727657 File Offset: 0x00725857
		public static ISceneItemMoveMotionType_UnionUnion FromISceneItemMoveMotionType(ISceneItemMoveMotionTypeT _isceneitemmovemotiontype)
		{
			return new ISceneItemMoveMotionType_UnionUnion
			{
				Type = ISceneItemMoveMotionType_Union.ISceneItemMoveMotionType,
				Value = _isceneitemmovemotiontype
			};
		}

		// Token: 0x06035551 RID: 218449 RVA: 0x0072766C File Offset: 0x0072586C
		public IUniformMotionT AsIUniformMotion()
		{
			return this.As<IUniformMotionT>();
		}

		// Token: 0x06035552 RID: 218450 RVA: 0x00727674 File Offset: 0x00725874
		public static ISceneItemMoveMotionType_UnionUnion FromIUniformMotion(IUniformMotionT _iuniformmotion)
		{
			return new ISceneItemMoveMotionType_UnionUnion
			{
				Type = ISceneItemMoveMotionType_Union.IUniformMotion,
				Value = _iuniformmotion
			};
		}

		// Token: 0x06035553 RID: 218451 RVA: 0x00727689 File Offset: 0x00725889
		public IVariableMotionT AsIVariableMotion()
		{
			return this.As<IVariableMotionT>();
		}

		// Token: 0x06035554 RID: 218452 RVA: 0x00727691 File Offset: 0x00725891
		public static ISceneItemMoveMotionType_UnionUnion FromIVariableMotion(IVariableMotionT _ivariablemotion)
		{
			return new ISceneItemMoveMotionType_UnionUnion
			{
				Type = ISceneItemMoveMotionType_Union.IVariableMotion,
				Value = _ivariablemotion
			};
		}

		// Token: 0x06035555 RID: 218453 RVA: 0x007276A8 File Offset: 0x007258A8
		public static int Pack(FlatBufferBuilder builder, ISceneItemMoveMotionType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ISceneItemMoveMotionType_Union.ISceneItemMoveMotionType:
				return ISceneItemMoveMotionType.Pack(builder, _o.AsISceneItemMoveMotionType()).Value;
			case ISceneItemMoveMotionType_Union.IUniformMotion:
				return IUniformMotion.Pack(builder, _o.AsIUniformMotion()).Value;
			case ISceneItemMoveMotionType_Union.IVariableMotion:
				return IVariableMotion.Pack(builder, _o.AsIVariableMotion()).Value;
			default:
				return 0;
			}
		}
	}
}
