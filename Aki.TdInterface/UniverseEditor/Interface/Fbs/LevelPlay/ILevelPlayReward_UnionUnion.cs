using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004519 RID: 17689
	public class ILevelPlayReward_UnionUnion
	{
		// Token: 0x17007D62 RID: 32098
		// (get) Token: 0x0601A947 RID: 108871 RVA: 0x003CB989 File Offset: 0x003C9B89
		// (set) Token: 0x0601A948 RID: 108872 RVA: 0x003CB991 File Offset: 0x003C9B91
		public ILevelPlayReward_Union Type { get; set; }

		// Token: 0x17007D63 RID: 32099
		// (get) Token: 0x0601A949 RID: 108873 RVA: 0x003CB99A File Offset: 0x003C9B9A
		// (set) Token: 0x0601A94A RID: 108874 RVA: 0x003CB9A2 File Offset: 0x003C9BA2
		public object Value { get; set; }

		// Token: 0x0601A94B RID: 108875 RVA: 0x003CB9AB File Offset: 0x003C9BAB
		public ILevelPlayReward_UnionUnion()
		{
			this.Type = ILevelPlayReward_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601A94C RID: 108876 RVA: 0x003CB9C1 File Offset: 0x003C9BC1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601A94D RID: 108877 RVA: 0x003CB9D3 File Offset: 0x003C9BD3
		public ILevelPlayRewardT AsILevelPlayReward()
		{
			return this.As<ILevelPlayRewardT>();
		}

		// Token: 0x0601A94E RID: 108878 RVA: 0x003CB9DB File Offset: 0x003C9BDB
		public static ILevelPlayReward_UnionUnion FromILevelPlayReward(ILevelPlayRewardT _ilevelplayreward)
		{
			return new ILevelPlayReward_UnionUnion
			{
				Type = ILevelPlayReward_Union.ILevelPlayReward,
				Value = _ilevelplayreward
			};
		}

		// Token: 0x0601A94F RID: 108879 RVA: 0x003CB9F0 File Offset: 0x003C9BF0
		public INoneRewardParamT AsINoneRewardParam()
		{
			return this.As<INoneRewardParamT>();
		}

		// Token: 0x0601A950 RID: 108880 RVA: 0x003CB9F8 File Offset: 0x003C9BF8
		public static ILevelPlayReward_UnionUnion FromINoneRewardParam(INoneRewardParamT _inonerewardparam)
		{
			return new ILevelPlayReward_UnionUnion
			{
				Type = ILevelPlayReward_Union.INoneRewardParam,
				Value = _inonerewardparam
			};
		}

		// Token: 0x0601A951 RID: 108881 RVA: 0x003CBA0D File Offset: 0x003C9C0D
		public IAutomaticRewardParamT AsIAutomaticRewardParam()
		{
			return this.As<IAutomaticRewardParamT>();
		}

		// Token: 0x0601A952 RID: 108882 RVA: 0x003CBA15 File Offset: 0x003C9C15
		public static ILevelPlayReward_UnionUnion FromIAutomaticRewardParam(IAutomaticRewardParamT _iautomaticrewardparam)
		{
			return new ILevelPlayReward_UnionUnion
			{
				Type = ILevelPlayReward_Union.IAutomaticRewardParam,
				Value = _iautomaticrewardparam
			};
		}

		// Token: 0x0601A953 RID: 108883 RVA: 0x003CBA2A File Offset: 0x003C9C2A
		public IVariableRewardParamT AsIVariableRewardParam()
		{
			return this.As<IVariableRewardParamT>();
		}

		// Token: 0x0601A954 RID: 108884 RVA: 0x003CBA32 File Offset: 0x003C9C32
		public static ILevelPlayReward_UnionUnion FromIVariableRewardParam(IVariableRewardParamT _ivariablerewardparam)
		{
			return new ILevelPlayReward_UnionUnion
			{
				Type = ILevelPlayReward_Union.IVariableRewardParam,
				Value = _ivariablerewardparam
			};
		}

		// Token: 0x0601A955 RID: 108885 RVA: 0x003CBA47 File Offset: 0x003C9C47
		public IInteractRewardParamT AsIInteractRewardParam()
		{
			return this.As<IInteractRewardParamT>();
		}

		// Token: 0x0601A956 RID: 108886 RVA: 0x003CBA4F File Offset: 0x003C9C4F
		public static ILevelPlayReward_UnionUnion FromIInteractRewardParam(IInteractRewardParamT _iinteractrewardparam)
		{
			return new ILevelPlayReward_UnionUnion
			{
				Type = ILevelPlayReward_Union.IInteractRewardParam,
				Value = _iinteractrewardparam
			};
		}

		// Token: 0x0601A957 RID: 108887 RVA: 0x003CBA64 File Offset: 0x003C9C64
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
