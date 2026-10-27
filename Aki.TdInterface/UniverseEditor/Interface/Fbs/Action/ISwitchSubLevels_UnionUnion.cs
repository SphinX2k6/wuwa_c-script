using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007272 RID: 29298
	public class ISwitchSubLevels_UnionUnion
	{
		// Token: 0x1700D963 RID: 55651
		// (get) Token: 0x06033FAA RID: 212906 RVA: 0x006FD758 File Offset: 0x006FB958
		// (set) Token: 0x06033FAB RID: 212907 RVA: 0x006FD760 File Offset: 0x006FB960
		public ISwitchSubLevels_Union Type { get; set; }

		// Token: 0x1700D964 RID: 55652
		// (get) Token: 0x06033FAC RID: 212908 RVA: 0x006FD769 File Offset: 0x006FB969
		// (set) Token: 0x06033FAD RID: 212909 RVA: 0x006FD771 File Offset: 0x006FB971
		public object Value { get; set; }

		// Token: 0x06033FAE RID: 212910 RVA: 0x006FD77A File Offset: 0x006FB97A
		public ISwitchSubLevels_UnionUnion()
		{
			this.Type = ISwitchSubLevels_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06033FAF RID: 212911 RVA: 0x006FD790 File Offset: 0x006FB990
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06033FB0 RID: 212912 RVA: 0x006FD7A2 File Offset: 0x006FB9A2
		public ISwitchSubLevelsT AsISwitchSubLevels()
		{
			return this.As<ISwitchSubLevelsT>();
		}

		// Token: 0x06033FB1 RID: 212913 RVA: 0x006FD7AA File Offset: 0x006FB9AA
		public static ISwitchSubLevels_UnionUnion FromISwitchSubLevels(ISwitchSubLevelsT _iswitchsublevels)
		{
			return new ISwitchSubLevels_UnionUnion
			{
				Type = ISwitchSubLevels_Union.ISwitchSubLevels,
				Value = _iswitchsublevels
			};
		}

		// Token: 0x06033FB2 RID: 212914 RVA: 0x006FD7BF File Offset: 0x006FB9BF
		public ISwitchSubLevelsDirectlyT AsISwitchSubLevelsDirectly()
		{
			return this.As<ISwitchSubLevelsDirectlyT>();
		}

		// Token: 0x06033FB3 RID: 212915 RVA: 0x006FD7C7 File Offset: 0x006FB9C7
		public static ISwitchSubLevels_UnionUnion FromISwitchSubLevelsDirectly(ISwitchSubLevelsDirectlyT _iswitchsublevelsdirectly)
		{
			return new ISwitchSubLevels_UnionUnion
			{
				Type = ISwitchSubLevels_Union.ISwitchSubLevelsDirectly,
				Value = _iswitchsublevelsdirectly
			};
		}

		// Token: 0x06033FB4 RID: 212916 RVA: 0x006FD7DC File Offset: 0x006FB9DC
		public IPreloadSubLevelsT AsIPreloadSubLevels()
		{
			return this.As<IPreloadSubLevelsT>();
		}

		// Token: 0x06033FB5 RID: 212917 RVA: 0x006FD7E4 File Offset: 0x006FB9E4
		public static ISwitchSubLevels_UnionUnion FromIPreloadSubLevels(IPreloadSubLevelsT _ipreloadsublevels)
		{
			return new ISwitchSubLevels_UnionUnion
			{
				Type = ISwitchSubLevels_Union.IPreloadSubLevels,
				Value = _ipreloadsublevels
			};
		}

		// Token: 0x06033FB6 RID: 212918 RVA: 0x006FD7F9 File Offset: 0x006FB9F9
		public ISwitchPermissionT AsISwitchPermission()
		{
			return this.As<ISwitchPermissionT>();
		}

		// Token: 0x06033FB7 RID: 212919 RVA: 0x006FD801 File Offset: 0x006FBA01
		public static ISwitchSubLevels_UnionUnion FromISwitchPermission(ISwitchPermissionT _iswitchpermission)
		{
			return new ISwitchSubLevels_UnionUnion
			{
				Type = ISwitchSubLevels_Union.ISwitchPermission,
				Value = _iswitchpermission
			};
		}

		// Token: 0x06033FB8 RID: 212920 RVA: 0x006FD818 File Offset: 0x006FBA18
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
