using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077BA RID: 30650
	public class TSwitchSubLevelsUnion
	{
		// Token: 0x1700E6BF RID: 59071
		// (get) Token: 0x060379C0 RID: 227776 RVA: 0x007859C6 File Offset: 0x00783BC6
		// (set) Token: 0x060379C1 RID: 227777 RVA: 0x007859CE File Offset: 0x00783BCE
		public TSwitchSubLevels Type { get; set; }

		// Token: 0x1700E6C0 RID: 59072
		// (get) Token: 0x060379C2 RID: 227778 RVA: 0x007859D7 File Offset: 0x00783BD7
		// (set) Token: 0x060379C3 RID: 227779 RVA: 0x007859DF File Offset: 0x00783BDF
		public object Value { get; set; }

		// Token: 0x060379C4 RID: 227780 RVA: 0x007859E8 File Offset: 0x00783BE8
		public TSwitchSubLevelsUnion()
		{
			this.Type = TSwitchSubLevels.NONE;
			this.Value = null;
		}

		// Token: 0x060379C5 RID: 227781 RVA: 0x007859FE File Offset: 0x00783BFE
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060379C6 RID: 227782 RVA: 0x00785A10 File Offset: 0x00783C10
		public IPreloadSubLevelsT AsIPreloadSubLevels()
		{
			return this.As<IPreloadSubLevelsT>();
		}

		// Token: 0x060379C7 RID: 227783 RVA: 0x00785A18 File Offset: 0x00783C18
		public static TSwitchSubLevelsUnion FromIPreloadSubLevels(IPreloadSubLevelsT _ipreloadsublevels)
		{
			return new TSwitchSubLevelsUnion
			{
				Type = TSwitchSubLevels.IPreloadSubLevels,
				Value = _ipreloadsublevels
			};
		}

		// Token: 0x060379C8 RID: 227784 RVA: 0x00785A2D File Offset: 0x00783C2D
		public ISwitchPermissionT AsISwitchPermission()
		{
			return this.As<ISwitchPermissionT>();
		}

		// Token: 0x060379C9 RID: 227785 RVA: 0x00785A35 File Offset: 0x00783C35
		public static TSwitchSubLevelsUnion FromISwitchPermission(ISwitchPermissionT _iswitchpermission)
		{
			return new TSwitchSubLevelsUnion
			{
				Type = TSwitchSubLevels.ISwitchPermission,
				Value = _iswitchpermission
			};
		}

		// Token: 0x060379CA RID: 227786 RVA: 0x00785A4A File Offset: 0x00783C4A
		public ISwitchSubLevelsDirectlyT AsISwitchSubLevelsDirectly()
		{
			return this.As<ISwitchSubLevelsDirectlyT>();
		}

		// Token: 0x060379CB RID: 227787 RVA: 0x00785A52 File Offset: 0x00783C52
		public static TSwitchSubLevelsUnion FromISwitchSubLevelsDirectly(ISwitchSubLevelsDirectlyT _iswitchsublevelsdirectly)
		{
			return new TSwitchSubLevelsUnion
			{
				Type = TSwitchSubLevels.ISwitchSubLevelsDirectly,
				Value = _iswitchsublevelsdirectly
			};
		}

		// Token: 0x060379CC RID: 227788 RVA: 0x00785A68 File Offset: 0x00783C68
		public static int Pack(FlatBufferBuilder builder, TSwitchSubLevelsUnion _o)
		{
			switch (_o.Type)
			{
			case TSwitchSubLevels.IPreloadSubLevels:
				return IPreloadSubLevels.Pack(builder, _o.AsIPreloadSubLevels()).Value;
			case TSwitchSubLevels.ISwitchPermission:
				return ISwitchPermission.Pack(builder, _o.AsISwitchPermission()).Value;
			case TSwitchSubLevels.ISwitchSubLevelsDirectly:
				return ISwitchSubLevelsDirectly.Pack(builder, _o.AsISwitchSubLevelsDirectly()).Value;
			default:
				return 0;
			}
		}
	}
}
