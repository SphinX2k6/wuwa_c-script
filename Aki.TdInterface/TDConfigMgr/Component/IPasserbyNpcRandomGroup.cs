using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200064F RID: 1615
	public class IPasserbyNpcRandomGroup
	{
		// Token: 0x060021EC RID: 8684 RVA: 0x0005DFD0 File Offset: 0x0005C1D0
		private IPasserbyNpcRandomGroup_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPasserbyNpcRandomGroup 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPasserbyNpcRandomGroup_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPasserbyNpcRandomGroup_SetValue());
			}
			return result;
		}

		// Token: 0x060021ED RID: 8685 RVA: 0x0005E008 File Offset: 0x0005C208
		public static IPasserbyNpcRandomGroup Create([Nullable(2)] IPasserbyNpcRandomGroup instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPasserbyNpcRandomGroup
			{
				FbInstance = instance
			};
		}

		// Token: 0x060021EE RID: 8686 RVA: 0x0005E01B File Offset: 0x0005C21B
		public static IPasserbyNpcRandomGroup CreateFromSetValue([Nullable(2)] IPasserbyNpcRandomGroup_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPasserbyNpcRandomGroup
			{
				PocoInterface = value
			};
		}

		// Token: 0x060021EF RID: 8687 RVA: 0x0005E02E File Offset: 0x0005C22E
		public IPasserbyNpcRandomGroup_SetValue ToSetValue()
		{
			return new IPasserbyNpcRandomGroup_SetValue
			{
				Weight = this.Weight,
				NpcCount = this.NpcCount,
				StandPositions = this.StandPositions
			};
		}

		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x060021F0 RID: 8688 RVA: 0x0005E059 File Offset: 0x0005C259
		// (set) Token: 0x060021F1 RID: 8689 RVA: 0x0005E084 File Offset: 0x0005C284
		public virtual int Weight
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Weight;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Weight;
			}
			set
			{
				this.GetOrCreatePoco().Weight = value;
			}
		}

		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x060021F2 RID: 8690 RVA: 0x0005E092 File Offset: 0x0005C292
		// (set) Token: 0x060021F3 RID: 8691 RVA: 0x0005E0BD File Offset: 0x0005C2BD
		public virtual int NpcCount
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.NpcCount;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.NpcCount;
			}
			set
			{
				this.GetOrCreatePoco().NpcCount = value;
			}
		}

		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x060021F4 RID: 8692 RVA: 0x0005E0CC File Offset: 0x0005C2CC
		// (set) Token: 0x060021F5 RID: 8693 RVA: 0x0005E15F File Offset: 0x0005C35F
		public virtual List<IPasserbyNpcStandPos> StandPositions
		{
			get
			{
				if (this._StandPositionsInited)
				{
					return this._StandPositionsCache;
				}
				this._StandPositionsInited = true;
				if (this.FbInstance != null)
				{
					List<IPasserbyNpcStandPos> standPositions = this.FbInstance.StandPositions;
					if (standPositions != null)
					{
						this._StandPositionsCache = new List<IPasserbyNpcStandPos>(standPositions.Count);
						for (int i = 0; i < standPositions.Count; i++)
						{
							this._StandPositionsCache.Add(IPasserbyNpcStandPos.Create(standPositions[i]));
						}
					}
				}
				else
				{
					IPasserbyNpcRandomGroup_SetValue pocoInterface = this.PocoInterface;
					this._StandPositionsCache = ((pocoInterface != null) ? pocoInterface.StandPositions : null);
				}
				return this._StandPositionsCache;
			}
			set
			{
				this.GetOrCreatePoco().StandPositions = value;
				this._StandPositionsInited = false;
			}
		}

		// Token: 0x040017E3 RID: 6115
		[Nullable(2)]
		protected IPasserbyNpcRandomGroup FbInstance;

		// Token: 0x040017E4 RID: 6116
		[Nullable(2)]
		protected IPasserbyNpcRandomGroup_SetValue PocoInterface;

		// Token: 0x040017E5 RID: 6117
		private List<IPasserbyNpcStandPos> _StandPositionsCache;

		// Token: 0x040017E6 RID: 6118
		private bool _StandPositionsInited;
	}
}
