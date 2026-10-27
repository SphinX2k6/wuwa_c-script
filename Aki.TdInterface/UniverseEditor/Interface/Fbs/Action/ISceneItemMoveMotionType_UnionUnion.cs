using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F3D RID: 28477
	public class ISceneItemMoveMotionType_UnionUnion
	{
		// Token: 0x1700D39F RID: 54175
		// (get) Token: 0x060324F1 RID: 206065 RVA: 0x006CB69D File Offset: 0x006C989D
		// (set) Token: 0x060324F2 RID: 206066 RVA: 0x006CB6A5 File Offset: 0x006C98A5
		public ISceneItemMoveMotionType_Union Type { get; set; }

		// Token: 0x1700D3A0 RID: 54176
		// (get) Token: 0x060324F3 RID: 206067 RVA: 0x006CB6AE File Offset: 0x006C98AE
		// (set) Token: 0x060324F4 RID: 206068 RVA: 0x006CB6B6 File Offset: 0x006C98B6
		public object Value { get; set; }

		// Token: 0x060324F5 RID: 206069 RVA: 0x006CB6BF File Offset: 0x006C98BF
		public ISceneItemMoveMotionType_UnionUnion()
		{
			this.Type = ISceneItemMoveMotionType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060324F6 RID: 206070 RVA: 0x006CB6D5 File Offset: 0x006C98D5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060324F7 RID: 206071 RVA: 0x006CB6E7 File Offset: 0x006C98E7
		public ISceneItemMoveMotionTypeT AsISceneItemMoveMotionType()
		{
			return this.As<ISceneItemMoveMotionTypeT>();
		}

		// Token: 0x060324F8 RID: 206072 RVA: 0x006CB6EF File Offset: 0x006C98EF
		public static ISceneItemMoveMotionType_UnionUnion FromISceneItemMoveMotionType(ISceneItemMoveMotionTypeT _isceneitemmovemotiontype)
		{
			return new ISceneItemMoveMotionType_UnionUnion
			{
				Type = ISceneItemMoveMotionType_Union.ISceneItemMoveMotionType,
				Value = _isceneitemmovemotiontype
			};
		}

		// Token: 0x060324F9 RID: 206073 RVA: 0x006CB704 File Offset: 0x006C9904
		public IUniformMotionT AsIUniformMotion()
		{
			return this.As<IUniformMotionT>();
		}

		// Token: 0x060324FA RID: 206074 RVA: 0x006CB70C File Offset: 0x006C990C
		public static ISceneItemMoveMotionType_UnionUnion FromIUniformMotion(IUniformMotionT _iuniformmotion)
		{
			return new ISceneItemMoveMotionType_UnionUnion
			{
				Type = ISceneItemMoveMotionType_Union.IUniformMotion,
				Value = _iuniformmotion
			};
		}

		// Token: 0x060324FB RID: 206075 RVA: 0x006CB721 File Offset: 0x006C9921
		public IVariableMotionT AsIVariableMotion()
		{
			return this.As<IVariableMotionT>();
		}

		// Token: 0x060324FC RID: 206076 RVA: 0x006CB729 File Offset: 0x006C9929
		public static ISceneItemMoveMotionType_UnionUnion FromIVariableMotion(IVariableMotionT _ivariablemotion)
		{
			return new ISceneItemMoveMotionType_UnionUnion
			{
				Type = ISceneItemMoveMotionType_Union.IVariableMotion,
				Value = _ivariablemotion
			};
		}

		// Token: 0x060324FD RID: 206077 RVA: 0x006CB740 File Offset: 0x006C9940
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
