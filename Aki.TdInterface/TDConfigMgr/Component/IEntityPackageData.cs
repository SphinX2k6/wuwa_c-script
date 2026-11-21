using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000376 RID: 886
	public class IEntityPackageData
	{
		// Token: 0x0600113A RID: 4410 RVA: 0x0003AEF4 File Offset: 0x000390F4
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

		// Token: 0x0600113B RID: 4411 RVA: 0x0003AF2C File Offset: 0x0003912C
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

		// Token: 0x0600113C RID: 4412 RVA: 0x0003AF3F File Offset: 0x0003913F
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

		// Token: 0x0600113D RID: 4413 RVA: 0x0003AF52 File Offset: 0x00039152
		public IEntityPackageData_SetValue ToSetValue()
		{
			return new IEntityPackageData_SetValue
			{
				PackagedLevelId = this.PackagedLevelId,
				PackageEntityId = this.PackageEntityId,
				PackageTree = this.PackageTree
			};
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x0600113E RID: 4414 RVA: 0x0003AF80 File Offset: 0x00039180
		// (set) Token: 0x0600113F RID: 4415 RVA: 0x0003AFBA File Offset: 0x000391BA
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

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06001140 RID: 4416 RVA: 0x0003AFC8 File Offset: 0x000391C8
		// (set) Token: 0x06001141 RID: 4417 RVA: 0x0003B002 File Offset: 0x00039202
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

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06001142 RID: 4418 RVA: 0x0003B010 File Offset: 0x00039210
		// (set) Token: 0x06001143 RID: 4419 RVA: 0x0003B0A3 File Offset: 0x000392A3
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IEntityPackageNode> PackageTree
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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
				0
			})]
			set
			{
				this.GetOrCreatePoco().PackageTree = value;
				this._PackageTreeInited = false;
			}
		}

		// Token: 0x04000E78 RID: 3704
		[Nullable(2)]
		protected IEntityPackageData FbInstance;

		// Token: 0x04000E79 RID: 3705
		[Nullable(2)]
		protected IEntityPackageData_SetValue PocoInterface;

		// Token: 0x04000E7A RID: 3706
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IEntityPackageNode> _PackageTreeCache;

		// Token: 0x04000E7B RID: 3707
		private bool _PackageTreeInited;
	}
}
