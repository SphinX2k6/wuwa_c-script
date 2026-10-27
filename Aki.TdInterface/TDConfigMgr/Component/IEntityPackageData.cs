using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200032F RID: 815
	[NullableContext(1)]
	[Nullable(0)]
	public class IEntityPackageData
	{
		// Token: 0x06001008 RID: 4104 RVA: 0x00037F28 File Offset: 0x00036128
		private IEntityPackageData_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEntityPackageData 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEntityPackageData_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEntityPackageData_SetValue());
			}
			return result;
		}

		// Token: 0x06001009 RID: 4105 RVA: 0x00037F60 File Offset: 0x00036160
		public static IEntityPackageData Create([Nullable(2)] IEntityPackageData instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityPackageData
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600100A RID: 4106 RVA: 0x00037F73 File Offset: 0x00036173
		public static IEntityPackageData CreateFromSetValue([Nullable(2)] IEntityPackageData_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEntityPackageData
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600100B RID: 4107 RVA: 0x00037F86 File Offset: 0x00036186
		public IEntityPackageData_SetValue ToSetValue()
		{
			return new IEntityPackageData_SetValue
			{
				PackagedLevelId = this.PackagedLevelId,
				PackageEntityId = this.PackageEntityId,
				PackageTree = this.PackageTree
			};
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x0600100C RID: 4108 RVA: 0x00037FB4 File Offset: 0x000361B4
		// (set) Token: 0x0600100D RID: 4109 RVA: 0x00037FEE File Offset: 0x000361EE
		public virtual int? PackagedLevelId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PackagedLevelId;
				}
				IEntityPackageData_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PackagedLevelId;
			}
			set
			{
				this.GetOrCreatePoco().PackagedLevelId = value;
			}
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x0600100E RID: 4110 RVA: 0x00037FFC File Offset: 0x000361FC
		// (set) Token: 0x0600100F RID: 4111 RVA: 0x00038036 File Offset: 0x00036236
		public virtual int? PackageEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PackageEntityId;
				}
				IEntityPackageData_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PackageEntityId;
			}
			set
			{
				this.GetOrCreatePoco().PackageEntityId = value;
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06001010 RID: 4112 RVA: 0x00038044 File Offset: 0x00036244
		// (set) Token: 0x06001011 RID: 4113 RVA: 0x000380D7 File Offset: 0x000362D7
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IEntityPackageNode> PackageTree
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._PackageTreeInited)
				{
					return this._PackageTreeCache;
				}
				this._PackageTreeInited = true;
				if (this.FbInstance != null)
				{
					List<IEntityPackageNode> packageTree = this.FbInstance.PackageTree;
					if (packageTree != null)
					{
						this._PackageTreeCache = new List<IEntityPackageNode>(packageTree.Count);
						for (int i = 0; i < packageTree.Count; i++)
						{
							this._PackageTreeCache.Add(IEntityPackageNode.Create(packageTree[i]));
						}
					}
				}
				else
				{
					IEntityPackageData_SetValue pocoInterface = this.PocoInterface;
					this._PackageTreeCache = ((pocoInterface != null) ? pocoInterface.PackageTree : null);
				}
				return this._PackageTreeCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().PackageTree = value;
				this._PackageTreeInited = false;
			}
		}

		// Token: 0x04000D8D RID: 3469
		[Nullable(2)]
		protected IEntityPackageData FbInstance;

		// Token: 0x04000D8E RID: 3470
		[Nullable(2)]
		protected IEntityPackageData_SetValue PocoInterface;

		// Token: 0x04000D8F RID: 3471
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IEntityPackageNode> _PackageTreeCache;

		// Token: 0x04000D90 RID: 3472
		private bool _PackageTreeInited;
	}
}
