using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001631 RID: 5681
	public class ChangeLiftTarget : ActionParams
	{
		// Token: 0x06008045 RID: 32837 RVA: 0x001317A4 File Offset: 0x0012F9A4
		private ChangeLiftTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ChangeLiftTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ChangeLiftTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ChangeLiftTarget_SetValue());
			}
			return result;
		}

		// Token: 0x06008046 RID: 32838 RVA: 0x001317DC File Offset: 0x0012F9DC
		public static ChangeLiftTarget Create([Nullable(2)] ChangeLiftTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ChangeLiftTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008047 RID: 32839 RVA: 0x001317EF File Offset: 0x0012F9EF
		public static ChangeLiftTarget CreateFromSetValue([Nullable(2)] ChangeLiftTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ChangeLiftTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008048 RID: 32840 RVA: 0x00131802 File Offset: 0x0012FA02
		public ChangeLiftTarget_SetValue ToSetValue()
		{
			return new ChangeLiftTarget_SetValue
			{
				IsSelf = this.IsSelf,
				MoveType = this.MoveType,
				EntityId = this.EntityId,
				Location = this.Location
			};
		}

		// Token: 0x17002A98 RID: 10904
		// (get) Token: 0x06008049 RID: 32841 RVA: 0x00131839 File Offset: 0x0012FA39
		// (set) Token: 0x0600804A RID: 32842 RVA: 0x00131864 File Offset: 0x0012FA64
		public virtual bool IsSelf
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsSelf;
				}
				return this.PocoInterface != null && this.PocoInterface.IsSelf;
			}
			set
			{
				this.GetOrCreatePoco().IsSelf = value;
			}
		}

		// Token: 0x17002A99 RID: 10905
		// (get) Token: 0x0600804B RID: 32843 RVA: 0x00131872 File Offset: 0x0012FA72
		// (set) Token: 0x0600804C RID: 32844 RVA: 0x00131899 File Offset: 0x0012FA99
		[Nullable(2)]
		public virtual ILiftMoveType MoveType
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MoveType;
				}
				ChangeLiftTarget_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MoveType;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().MoveType = value;
			}
		}

		// Token: 0x17002A9A RID: 10906
		// (get) Token: 0x0600804D RID: 32845 RVA: 0x001318A8 File Offset: 0x0012FAA8
		// (set) Token: 0x0600804E RID: 32846 RVA: 0x001318E2 File Offset: 0x0012FAE2
		public virtual int? EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				ChangeLiftTarget_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x17002A9B RID: 10907
		// (get) Token: 0x0600804F RID: 32847 RVA: 0x001318F0 File Offset: 0x0012FAF0
		// (set) Token: 0x06008050 RID: 32848 RVA: 0x0013191B File Offset: 0x0012FB1B
		public virtual int Location
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Location;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Location;
			}
			set
			{
				this.GetOrCreatePoco().Location = value;
			}
		}

		// Token: 0x04004A18 RID: 18968
		[Nullable(2)]
		protected new ChangeLiftTarget FbInstance;

		// Token: 0x04004A19 RID: 18969
		[Nullable(2)]
		protected ChangeLiftTarget_SetValue PocoInterface;
	}
}
