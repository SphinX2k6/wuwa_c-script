using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A47 RID: 31303
	public class ISwitchSubLevels_UnionUnion
	{
		// Token: 0x1700E55C RID: 58716
		// (get) Token: 0x060372AC RID: 225964 RVA: 0x0075EAB8 File Offset: 0x0075CCB8
		// (set) Token: 0x060372AD RID: 225965 RVA: 0x0075EAC0 File Offset: 0x0075CCC0
		public ISwitchSubLevels_Union Type { get; set; }

		// Token: 0x1700E55D RID: 58717
		// (get) Token: 0x060372AE RID: 225966 RVA: 0x0075EAC9 File Offset: 0x0075CCC9
		// (set) Token: 0x060372AF RID: 225967 RVA: 0x0075EAD1 File Offset: 0x0075CCD1
		public object Value { get; set; }

		// Token: 0x060372B0 RID: 225968 RVA: 0x0075EADA File Offset: 0x0075CCDA
		public ISwitchSubLevels_UnionUnion()
		{
			this.Type = ISwitchSubLevels_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060372B1 RID: 225969 RVA: 0x0075EAF0 File Offset: 0x0075CCF0
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060372B2 RID: 225970 RVA: 0x0075EB02 File Offset: 0x0075CD02
		public ISwitchSubLevelsT AsISwitchSubLevels()
		{
			return this.As<ISwitchSubLevelsT>();
		}

		// Token: 0x060372B3 RID: 225971 RVA: 0x0075EB0A File Offset: 0x0075CD0A
		public static ISwitchSubLevels_UnionUnion FromISwitchSubLevels(ISwitchSubLevelsT _iswitchsublevels)
		{
			return new ISwitchSubLevels_UnionUnion
			{
				Type = ISwitchSubLevels_Union.ISwitchSubLevels,
				Value = _iswitchsublevels
			};
		}

		// Token: 0x060372B4 RID: 225972 RVA: 0x0075EB1F File Offset: 0x0075CD1F
		public ISwitchSubLevelsDirectlyT AsISwitchSubLevelsDirectly()
		{
			return this.As<ISwitchSubLevelsDirectlyT>();
		}

		// Token: 0x060372B5 RID: 225973 RVA: 0x0075EB27 File Offset: 0x0075CD27
		public static ISwitchSubLevels_UnionUnion FromISwitchSubLevelsDirectly(ISwitchSubLevelsDirectlyT _iswitchsublevelsdirectly)
		{
			return new ISwitchSubLevels_UnionUnion
			{
				Type = ISwitchSubLevels_Union.ISwitchSubLevelsDirectly,
				Value = _iswitchsublevelsdirectly
			};
		}

		// Token: 0x060372B6 RID: 225974 RVA: 0x0075EB3C File Offset: 0x0075CD3C
		public IPreloadSubLevelsT AsIPreloadSubLevels()
		{
			return this.As<IPreloadSubLevelsT>();
		}

		// Token: 0x060372B7 RID: 225975 RVA: 0x0075EB44 File Offset: 0x0075CD44
		public static ISwitchSubLevels_UnionUnion FromIPreloadSubLevels(IPreloadSubLevelsT _ipreloadsublevels)
		{
			return new ISwitchSubLevels_UnionUnion
			{
				Type = ISwitchSubLevels_Union.IPreloadSubLevels,
				Value = _ipreloadsublevels
			};
		}

		// Token: 0x060372B8 RID: 225976 RVA: 0x0075EB59 File Offset: 0x0075CD59
		public ISwitchPermissionT AsISwitchPermission()
		{
			return this.As<ISwitchPermissionT>();
		}

		// Token: 0x060372B9 RID: 225977 RVA: 0x0075EB61 File Offset: 0x0075CD61
		public static ISwitchSubLevels_UnionUnion FromISwitchPermission(ISwitchPermissionT _iswitchpermission)
		{
			return new ISwitchSubLevels_UnionUnion
			{
				Type = ISwitchSubLevels_Union.ISwitchPermission,
				Value = _iswitchpermission
			};
		}

		// Token: 0x060372BA RID: 225978 RVA: 0x0075EB78 File Offset: 0x0075CD78
		public static int Pack(FlatBufferBuilder builder, ISwitchSubLevels_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ISwitchSubLevels_Union.ISwitchSubLevels:
				return ISwitchSubLevels.Pack(builder, _o.AsISwitchSubLevels()).Value;
			case ISwitchSubLevels_Union.ISwitchSubLevelsDirectly:
				return ISwitchSubLevelsDirectly.Pack(builder, _o.AsISwitchSubLevelsDirectly()).Value;
			case ISwitchSubLevels_Union.IPreloadSubLevels:
				return IPreloadSubLevels.Pack(builder, _o.AsIPreloadSubLevels()).Value;
			case ISwitchSubLevels_Union.ISwitchPermission:
				return ISwitchPermission.Pack(builder, _o.AsISwitchPermission()).Value;
			default:
				return 0;
			}
		}
	}
}
