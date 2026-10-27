using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003F4 RID: 1012
	[NullableContext(1)]
	[Nullable(0)]
	public class IGroupAiMonsterEcology : IGroupAiMode
	{
		// Token: 0x0600145D RID: 5213 RVA: 0x000411DC File Offset: 0x0003F3DC
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

		// Token: 0x0600145E RID: 5214 RVA: 0x00041214 File Offset: 0x0003F414
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

		// Token: 0x0600145F RID: 5215 RVA: 0x00041227 File Offset: 0x0003F427
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

		// Token: 0x06001460 RID: 5216 RVA: 0x0004123A File Offset: 0x0003F43A
		public new IGroupAiMonsterEcology_SetValue ToSetValue()
		{
			return new IGroupAiMonsterEcology_SetValue
			{
				Type = this.Type,
				Leader = this.Leader,
				Members = this.Members
			};
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06001461 RID: 5217 RVA: 0x00041265 File Offset: 0x0003F465
		// (set) Token: 0x06001462 RID: 5218 RVA: 0x00041290 File Offset: 0x0003F490
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

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06001463 RID: 5219 RVA: 0x0004129E File Offset: 0x0003F49E
		// (set) Token: 0x06001464 RID: 5220 RVA: 0x000412C9 File Offset: 0x0003F4C9
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

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06001465 RID: 5221 RVA: 0x000412D8 File Offset: 0x0003F4D8
		// (set) Token: 0x06001466 RID: 5222 RVA: 0x0004136B File Offset: 0x0003F56B
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

		// Token: 0x04001005 RID: 4101
		[Nullable(2)]
		protected new IGroupAiMonsterEcology FbInstance;

		// Token: 0x04001006 RID: 4102
		[Nullable(2)]
		protected new IGroupAiMonsterEcology_SetValue PocoInterface;

		// Token: 0x04001007 RID: 4103
		private List<IGroupAiMonsterMember> _MembersCache;

		// Token: 0x04001008 RID: 4104
		private bool _MembersInited;
	}
}
