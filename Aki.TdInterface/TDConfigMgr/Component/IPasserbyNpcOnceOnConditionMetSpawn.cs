using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000649 RID: 1609
	public class IPasserbyNpcOnceOnConditionMetSpawn : IPasserbyNpcSpawnBase
	{
		// Token: 0x060021C8 RID: 8648 RVA: 0x0005DB70 File Offset: 0x0005BD70
		private IPasserbyNpcOnceOnConditionMetSpawn_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPasserbyNpcOnceOnConditionMetSpawn 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPasserbyNpcOnceOnConditionMetSpawn_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPasserbyNpcOnceOnConditionMetSpawn_SetValue());
			}
			return result;
		}

		// Token: 0x060021C9 RID: 8649 RVA: 0x0005DBA8 File Offset: 0x0005BDA8
		public static IPasserbyNpcOnceOnConditionMetSpawn Create([Nullable(2)] IPasserbyNpcOnceOnConditionMetSpawn instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPasserbyNpcOnceOnConditionMetSpawn
			{
				FbInstance = instance
			};
		}

		// Token: 0x060021CA RID: 8650 RVA: 0x0005DBBB File Offset: 0x0005BDBB
		public static IPasserbyNpcOnceOnConditionMetSpawn CreateFromSetValue([Nullable(2)] IPasserbyNpcOnceOnConditionMetSpawn_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPasserbyNpcOnceOnConditionMetSpawn
			{
				PocoInterface = value
			};
		}

		// Token: 0x060021CB RID: 8651 RVA: 0x0005DBCE File Offset: 0x0005BDCE
		public new IPasserbyNpcOnceOnConditionMetSpawn_SetValue ToSetValue()
		{
			return new IPasserbyNpcOnceOnConditionMetSpawn_SetValue
			{
				Type = this.Type,
				MaxSpawnCount = this.MaxSpawnCount,
				MinDistance = this.MinDistance,
				SpawnPos = this.SpawnPos
			};
		}

		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x060021CC RID: 8652 RVA: 0x0005DC05 File Offset: 0x0005BE05
		// (set) Token: 0x060021CD RID: 8653 RVA: 0x0005DC30 File Offset: 0x0005BE30
		public override EPasserbyNpcSpawnType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPasserbyNpcSpawnType.FixInterval;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x060021CE RID: 8654 RVA: 0x0005DC3E File Offset: 0x0005BE3E
		// (set) Token: 0x060021CF RID: 8655 RVA: 0x0005DC69 File Offset: 0x0005BE69
		public override int MaxSpawnCount
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxSpawnCount;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.MaxSpawnCount;
			}
			set
			{
				this.GetOrCreatePoco().MaxSpawnCount = value;
			}
		}

		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x060021D0 RID: 8656 RVA: 0x0005DC78 File Offset: 0x0005BE78
		// (set) Token: 0x060021D1 RID: 8657 RVA: 0x0005DCB2 File Offset: 0x0005BEB2
		public override int? MinDistance
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MinDistance;
				}
				IPasserbyNpcOnceOnConditionMetSpawn_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MinDistance;
			}
			set
			{
				this.GetOrCreatePoco().MinDistance = value;
			}
		}

		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x060021D2 RID: 8658 RVA: 0x0005DCC0 File Offset: 0x0005BEC0
		// (set) Token: 0x060021D3 RID: 8659 RVA: 0x0005DD21 File Offset: 0x0005BF21
		public virtual IPasserbyNpcRandomStandGenerate SpawnPos
		{
			get
			{
				if (this._SpawnPosInited)
				{
					return this._SpawnPosCache;
				}
				this._SpawnPosInited = true;
				if (this.FbInstance != null)
				{
					this._SpawnPosCache = IPasserbyNpcRandomStandGenerate.Create(this.FbInstance.SpawnPos);
				}
				else
				{
					IPasserbyNpcOnceOnConditionMetSpawn_SetValue pocoInterface = this.PocoInterface;
					this._SpawnPosCache = ((pocoInterface != null) ? pocoInterface.SpawnPos : null);
				}
				return this._SpawnPosCache;
			}
			set
			{
				this.GetOrCreatePoco().SpawnPos = value;
				this._SpawnPosInited = false;
			}
		}

		// Token: 0x040017D0 RID: 6096
		[Nullable(2)]
		protected new IPasserbyNpcOnceOnConditionMetSpawn FbInstance;

		// Token: 0x040017D1 RID: 6097
		[Nullable(2)]
		protected new IPasserbyNpcOnceOnConditionMetSpawn_SetValue PocoInterface;

		// Token: 0x040017D2 RID: 6098
		private IPasserbyNpcRandomStandGenerate _SpawnPosCache;

		// Token: 0x040017D3 RID: 6099
		private bool _SpawnPosInited;
	}
}
