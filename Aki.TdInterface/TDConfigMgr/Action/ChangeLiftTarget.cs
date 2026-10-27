using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020014D8 RID: 5336
	[NullableContext(2)]
	[Nullable(0)]
	public class ChangeLiftTarget : ActionParams
	{
		// Token: 0x06007978 RID: 31096 RVA: 0x00122B58 File Offset: 0x00120D58
		[NullableContext(1)]
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

		// Token: 0x06007979 RID: 31097 RVA: 0x00122B90 File Offset: 0x00120D90
		[NullableContext(1)]
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

		// Token: 0x0600797A RID: 31098 RVA: 0x00122BA3 File Offset: 0x00120DA3
		[NullableContext(1)]
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

		// Token: 0x0600797B RID: 31099 RVA: 0x00122BB6 File Offset: 0x00120DB6
		[NullableContext(1)]
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

		// Token: 0x170028AE RID: 10414
		// (get) Token: 0x0600797C RID: 31100 RVA: 0x00122BED File Offset: 0x00120DED
		// (set) Token: 0x0600797D RID: 31101 RVA: 0x00122C18 File Offset: 0x00120E18
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

		// Token: 0x170028AF RID: 10415
		// (get) Token: 0x0600797E RID: 31102 RVA: 0x00122C26 File Offset: 0x00120E26
		// (set) Token: 0x0600797F RID: 31103 RVA: 0x00122C4D File Offset: 0x00120E4D
		public virtual ILiftMoveType MoveType
		{
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
			set
			{
				this.GetOrCreatePoco().MoveType = value;
			}
		}

		// Token: 0x170028B0 RID: 10416
		// (get) Token: 0x06007980 RID: 31104 RVA: 0x00122C5C File Offset: 0x00120E5C
		// (set) Token: 0x06007981 RID: 31105 RVA: 0x00122C96 File Offset: 0x00120E96
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

		// Token: 0x170028B1 RID: 10417
		// (get) Token: 0x06007982 RID: 31106 RVA: 0x00122CA4 File Offset: 0x00120EA4
		// (set) Token: 0x06007983 RID: 31107 RVA: 0x00122CCF File Offset: 0x00120ECF
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

		// Token: 0x0400467D RID: 18045
		protected new ChangeLiftTarget FbInstance;

		// Token: 0x0400467E RID: 18046
		protected ChangeLiftTarget_SetValue PocoInterface;
	}
}
