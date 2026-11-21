using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200044D RID: 1101
	public class IGroupAiMonsterEcology : IGroupAiMode
	{
		// Token: 0x060015F7 RID: 5623 RVA: 0x00044F24 File Offset: 0x00043124
		private IGroupAiMonsterEcology_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IGroupAiMonsterEcology 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IGroupAiMonsterEcology_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IGroupAiMonsterEcology_SetValue());
			}
			return result;
		}

		// Token: 0x060015F8 RID: 5624 RVA: 0x00044F5C File Offset: 0x0004315C
		public static IGroupAiMonsterEcology Create([Nullable(2)] IGroupAiMonsterEcology instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGroupAiMonsterEcology
			{
				FbInstance = instance
			};
		}

		// Token: 0x060015F9 RID: 5625 RVA: 0x00044F6F File Offset: 0x0004316F
		public static IGroupAiMonsterEcology CreateFromSetValue([Nullable(2)] IGroupAiMonsterEcology_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IGroupAiMonsterEcology
			{
				PocoInterface = value
			};
		}

		// Token: 0x060015FA RID: 5626 RVA: 0x00044F82 File Offset: 0x00043182
		public new IGroupAiMonsterEcology_SetValue ToSetValue()
		{
			return new IGroupAiMonsterEcology_SetValue
			{
				Type = this.Type,
				Leader = this.Leader,
				Members = this.Members
			};
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x060015FB RID: 5627 RVA: 0x00044FAD File Offset: 0x000431AD
		// (set) Token: 0x060015FC RID: 5628 RVA: 0x00044FD8 File Offset: 0x000431D8
		public override EGroupAiMode Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EGroupAiMode.Default;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x060015FD RID: 5629 RVA: 0x00044FE6 File Offset: 0x000431E6
		// (set) Token: 0x060015FE RID: 5630 RVA: 0x00045011 File Offset: 0x00043211
		public virtual int Leader
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Leader;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Leader;
			}
			set
			{
				this.GetOrCreatePoco().Leader = value;
			}
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x060015FF RID: 5631 RVA: 0x00045020 File Offset: 0x00043220
		// (set) Token: 0x06001600 RID: 5632 RVA: 0x000450B3 File Offset: 0x000432B3
		public virtual List<IGroupAiMonsterMember> Members
		{
			get
			{
				if (this._MembersInited)
				{
					return this._MembersCache;
				}
				this._MembersInited = true;
				if (this.FbInstance != null)
				{
					List<IGroupAiMonsterMember> members = this.FbInstance.Members;
					if (members != null)
					{
						this._MembersCache = new List<IGroupAiMonsterMember>(members.Count);
						for (int i = 0; i < members.Count; i++)
						{
							this._MembersCache.Add(IGroupAiMonsterMember.Create(members[i]));
						}
					}
				}
				else
				{
					IGroupAiMonsterEcology_SetValue pocoInterface = this.PocoInterface;
					this._MembersCache = ((pocoInterface != null) ? pocoInterface.Members : null);
				}
				return this._MembersCache;
			}
			set
			{
				this.GetOrCreatePoco().Members = value;
				this._MembersInited = false;
			}
		}

		// Token: 0x04001127 RID: 4391
		[Nullable(2)]
		protected new IGroupAiMonsterEcology FbInstance;

		// Token: 0x04001128 RID: 4392
		[Nullable(2)]
		protected new IGroupAiMonsterEcology_SetValue PocoInterface;

		// Token: 0x04001129 RID: 4393
		private List<IGroupAiMonsterMember> _MembersCache;

		// Token: 0x0400112A RID: 4394
		private bool _MembersInited;
	}
}
