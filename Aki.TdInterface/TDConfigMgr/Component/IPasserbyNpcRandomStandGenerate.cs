using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000651 RID: 1617
	public class IPasserbyNpcRandomStandGenerate : IPasserbyNpcGenerateTypeBase
	{
		// Token: 0x060021F8 RID: 8696 RVA: 0x0005E184 File Offset: 0x0005C384
		private IPasserbyNpcRandomStandGenerate_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPasserbyNpcRandomStandGenerate 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPasserbyNpcRandomStandGenerate_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPasserbyNpcRandomStandGenerate_SetValue());
			}
			return result;
		}

		// Token: 0x060021F9 RID: 8697 RVA: 0x0005E1BC File Offset: 0x0005C3BC
		public static IPasserbyNpcRandomStandGenerate Create([Nullable(2)] IPasserbyNpcRandomStandGenerate instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPasserbyNpcRandomStandGenerate
			{
				FbInstance = instance
			};
		}

		// Token: 0x060021FA RID: 8698 RVA: 0x0005E1CF File Offset: 0x0005C3CF
		public static IPasserbyNpcRandomStandGenerate CreateFromSetValue([Nullable(2)] IPasserbyNpcRandomStandGenerate_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPasserbyNpcRandomStandGenerate
			{
				PocoInterface = value
			};
		}

		// Token: 0x060021FB RID: 8699 RVA: 0x0005E1E2 File Offset: 0x0005C3E2
		public new IPasserbyNpcRandomStandGenerate_SetValue ToSetValue()
		{
			return new IPasserbyNpcRandomStandGenerate_SetValue
			{
				Type = this.Type,
				SpawnCenterPos = this.SpawnCenterPos,
				Groups = this.Groups
			};
		}

		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x060021FC RID: 8700 RVA: 0x0005E20D File Offset: 0x0005C40D
		// (set) Token: 0x060021FD RID: 8701 RVA: 0x0005E238 File Offset: 0x0005C438
		public override EPasserbyNpcGenerateType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPasserbyNpcGenerateType.RandomStand;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x060021FE RID: 8702 RVA: 0x0005E248 File Offset: 0x0005C448
		// (set) Token: 0x060021FF RID: 8703 RVA: 0x0005E2A9 File Offset: 0x0005C4A9
		public virtual IPasserbyNpcSelfSpawnCenterPos SpawnCenterPos
		{
			get
			{
				if (this._SpawnCenterPosInited)
				{
					return this._SpawnCenterPosCache;
				}
				this._SpawnCenterPosInited = true;
				if (this.FbInstance != null)
				{
					this._SpawnCenterPosCache = IPasserbyNpcSelfSpawnCenterPos.Create(this.FbInstance.SpawnCenterPos);
				}
				else
				{
					IPasserbyNpcRandomStandGenerate_SetValue pocoInterface = this.PocoInterface;
					this._SpawnCenterPosCache = ((pocoInterface != null) ? pocoInterface.SpawnCenterPos : null);
				}
				return this._SpawnCenterPosCache;
			}
			set
			{
				this.GetOrCreatePoco().SpawnCenterPos = value;
				this._SpawnCenterPosInited = false;
			}
		}

		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x06002200 RID: 8704 RVA: 0x0005E2C0 File Offset: 0x0005C4C0
		// (set) Token: 0x06002201 RID: 8705 RVA: 0x0005E353 File Offset: 0x0005C553
		public virtual List<IPasserbyNpcRandomGroup> Groups
		{
			get
			{
				if (this._GroupsInited)
				{
					return this._GroupsCache;
				}
				this._GroupsInited = true;
				if (this.FbInstance != null)
				{
					List<IPasserbyNpcRandomGroup> groups = this.FbInstance.Groups;
					if (groups != null)
					{
						this._GroupsCache = new List<IPasserbyNpcRandomGroup>(groups.Count);
						for (int i = 0; i < groups.Count; i++)
						{
							this._GroupsCache.Add(IPasserbyNpcRandomGroup.Create(groups[i]));
						}
					}
				}
				else
				{
					IPasserbyNpcRandomStandGenerate_SetValue pocoInterface = this.PocoInterface;
					this._GroupsCache = ((pocoInterface != null) ? pocoInterface.Groups : null);
				}
				return this._GroupsCache;
			}
			set
			{
				this.GetOrCreatePoco().Groups = value;
				this._GroupsInited = false;
			}
		}

		// Token: 0x040017EA RID: 6122
		[Nullable(2)]
		protected new IPasserbyNpcRandomStandGenerate FbInstance;

		// Token: 0x040017EB RID: 6123
		[Nullable(2)]
		protected new IPasserbyNpcRandomStandGenerate_SetValue PocoInterface;

		// Token: 0x040017EC RID: 6124
		private IPasserbyNpcSelfSpawnCenterPos _SpawnCenterPosCache;

		// Token: 0x040017ED RID: 6125
		private bool _SpawnCenterPosInited;

		// Token: 0x040017EE RID: 6126
		private List<IPasserbyNpcRandomGroup> _GroupsCache;

		// Token: 0x040017EF RID: 6127
		private bool _GroupsInited;
	}
}
