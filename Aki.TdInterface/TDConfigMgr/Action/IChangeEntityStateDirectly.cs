using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019F9 RID: 6649
	public class IChangeEntityStateDirectly : ChangeEntityState
	{
		// Token: 0x06008D87 RID: 36231 RVA: 0x0014EBB4 File Offset: 0x0014CDB4
		private IChangeEntityStateDirectly_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IChangeEntityStateDirectly 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IChangeEntityStateDirectly_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IChangeEntityStateDirectly_SetValue());
			}
			return result;
		}

		// Token: 0x06008D88 RID: 36232 RVA: 0x0014EBEC File Offset: 0x0014CDEC
		public static IChangeEntityStateDirectly Create([Nullable(2)] IChangeEntityStateDirectly instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IChangeEntityStateDirectly
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008D89 RID: 36233 RVA: 0x0014EBFF File Offset: 0x0014CDFF
		public static IChangeEntityStateDirectly CreateFromSetValue([Nullable(2)] IChangeEntityStateDirectly_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IChangeEntityStateDirectly
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008D8A RID: 36234 RVA: 0x0014EC12 File Offset: 0x0014CE12
		public new IChangeEntityStateDirectly_SetValue ToSetValue()
		{
			return new IChangeEntityStateDirectly_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId,
				State = this.State,
				DelayChange = this.DelayChange
			};
		}

		// Token: 0x17002DDA RID: 11738
		// (get) Token: 0x06008D8B RID: 36235 RVA: 0x0014EC49 File Offset: 0x0014CE49
		// (set) Token: 0x06008D8C RID: 36236 RVA: 0x0014EC74 File Offset: 0x0014CE74
		public override EChangeEntityState Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EChangeEntityState.Directly;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002DDB RID: 11739
		// (get) Token: 0x06008D8D RID: 36237 RVA: 0x0014EC82 File Offset: 0x0014CE82
		// (set) Token: 0x06008D8E RID: 36238 RVA: 0x0014ECAD File Offset: 0x0014CEAD
		public override int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x17002DDC RID: 11740
		// (get) Token: 0x06008D8F RID: 36239 RVA: 0x0014ECBB File Offset: 0x0014CEBB
		// (set) Token: 0x06008D90 RID: 36240 RVA: 0x0014ECE6 File Offset: 0x0014CEE6
		public virtual string State
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.State;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.State;
			}
			set
			{
				this.GetOrCreatePoco().State = value;
			}
		}

		// Token: 0x17002DDD RID: 11741
		// (get) Token: 0x06008D91 RID: 36241 RVA: 0x0014ECF4 File Offset: 0x0014CEF4
		// (set) Token: 0x06008D92 RID: 36242 RVA: 0x0014ED2E File Offset: 0x0014CF2E
		public virtual bool? DelayChange
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DelayChange;
				}
				IChangeEntityStateDirectly_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DelayChange;
			}
			set
			{
				this.GetOrCreatePoco().DelayChange = value;
			}
		}

		// Token: 0x0400590F RID: 22799
		[Nullable(2)]
		protected new IChangeEntityStateDirectly FbInstance;

		// Token: 0x04005910 RID: 22800
		[Nullable(2)]
		protected new IChangeEntityStateDirectly_SetValue PocoInterface;
	}
}
