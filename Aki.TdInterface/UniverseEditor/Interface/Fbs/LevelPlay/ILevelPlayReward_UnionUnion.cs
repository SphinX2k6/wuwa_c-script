using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004981 RID: 18817
	public class ILevelPlayReward_UnionUnion
	{
		// Token: 0x170083A3 RID: 33699
		// (get) Token: 0x0601C11C RID: 114972 RVA: 0x003F7C25 File Offset: 0x003F5E25
		// (set) Token: 0x0601C11D RID: 114973 RVA: 0x003F7C2D File Offset: 0x003F5E2D
		public ILevelPlayReward_Union Type { get; set; }

		// Token: 0x170083A4 RID: 33700
		// (get) Token: 0x0601C11E RID: 114974 RVA: 0x003F7C36 File Offset: 0x003F5E36
		// (set) Token: 0x0601C11F RID: 114975 RVA: 0x003F7C3E File Offset: 0x003F5E3E
		public object Value { get; set; }

		// Token: 0x0601C120 RID: 114976 RVA: 0x003F7C47 File Offset: 0x003F5E47
		public ILevelPlayReward_UnionUnion()
		{
			this.Type = ILevelPlayReward_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601C121 RID: 114977 RVA: 0x003F7C5D File Offset: 0x003F5E5D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601C122 RID: 114978 RVA: 0x003F7C6F File Offset: 0x003F5E6F
		public ILevelPlayRewardT AsILevelPlayReward()
		{
			return this.As<ILevelPlayRewardT>();
		}

		// Token: 0x0601C123 RID: 114979 RVA: 0x003F7C77 File Offset: 0x003F5E77
		public static ILevelPlayReward_UnionUnion FromILevelPlayReward(ILevelPlayRewardT _ilevelplayreward)
		{
			return new ILevelPlayReward_UnionUnion
			{
				Type = ILevelPlayReward_Union.ILevelPlayReward,
				Value = _ilevelplayreward
			};
		}

		// Token: 0x0601C124 RID: 114980 RVA: 0x003F7C8C File Offset: 0x003F5E8C
		public INoneRewardParamT AsINoneRewardParam()
		{
			return this.As<INoneRewardParamT>();
		}

		// Token: 0x0601C125 RID: 114981 RVA: 0x003F7C94 File Offset: 0x003F5E94
		public static ILevelPlayReward_UnionUnion FromINoneRewardParam(INoneRewardParamT _inonerewardparam)
		{
			return new ILevelPlayReward_UnionUnion
			{
				Type = ILevelPlayReward_Union.INoneRewardParam,
				Value = _inonerewardparam
			};
		}

		// Token: 0x0601C126 RID: 114982 RVA: 0x003F7CA9 File Offset: 0x003F5EA9
		public IAutomaticRewardParamT AsIAutomaticRewardParam()
		{
			return this.As<IAutomaticRewardParamT>();
		}

		// Token: 0x0601C127 RID: 114983 RVA: 0x003F7CB1 File Offset: 0x003F5EB1
		public static ILevelPlayReward_UnionUnion FromIAutomaticRewardParam(IAutomaticRewardParamT _iautomaticrewardparam)
		{
			return new ILevelPlayReward_UnionUnion
			{
				Type = ILevelPlayReward_Union.IAutomaticRewardParam,
				Value = _iautomaticrewardparam
			};
		}

		// Token: 0x0601C128 RID: 114984 RVA: 0x003F7CC6 File Offset: 0x003F5EC6
		public IVariableRewardParamT AsIVariableRewardParam()
		{
			return this.As<IVariableRewardParamT>();
		}

		// Token: 0x0601C129 RID: 114985 RVA: 0x003F7CCE File Offset: 0x003F5ECE
		public static ILevelPlayReward_UnionUnion FromIVariableRewardParam(IVariableRewardParamT _ivariablerewardparam)
		{
			return new ILevelPlayReward_UnionUnion
			{
				Type = ILevelPlayReward_Union.IVariableRewardParam,
				Value = _ivariablerewardparam
			};
		}

		// Token: 0x0601C12A RID: 114986 RVA: 0x003F7CE3 File Offset: 0x003F5EE3
		public IInteractRewardParamT AsIInteractRewardParam()
		{
			return this.As<IInteractRewardParamT>();
		}

		// Token: 0x0601C12B RID: 114987 RVA: 0x003F7CEB File Offset: 0x003F5EEB
		public static ILevelPlayReward_UnionUnion FromIInteractRewardParam(IInteractRewardParamT _iinteractrewardparam)
		{
			return new ILevelPlayReward_UnionUnion
			{
				Type = ILevelPlayReward_Union.IInteractRewardParam,
				Value = _iinteractrewardparam
			};
		}

		// Token: 0x0601C12C RID: 114988 RVA: 0x003F7D00 File Offset: 0x003F5F00
		public static int Pack(FlatBufferBuilder builder, ILevelPlayReward_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ILevelPlayReward_Union.ILevelPlayReward:
				return ILevelPlayReward.Pack(builder, _o.AsILevelPlayReward()).Value;
			case ILevelPlayReward_Union.INoneRewardParam:
				return INoneRewardParam.Pack(builder, _o.AsINoneRewardParam()).Value;
			case ILevelPlayReward_Union.IAutomaticRewardParam:
				return IAutomaticRewardParam.Pack(builder, _o.AsIAutomaticRewardParam()).Value;
			case ILevelPlayReward_Union.IVariableRewardParam:
				return IVariableRewardParam.Pack(builder, _o.AsIVariableRewardParam()).Value;
			case ILevelPlayReward_Union.IInteractRewardParam:
				return IInteractRewardParam.Pack(builder, _o.AsIInteractRewardParam()).Value;
			default:
				return 0;
			}
		}
	}
}
