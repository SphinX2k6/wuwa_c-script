using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000781 RID: 1921
	public class ISnapAngleConfig
	{
		// Token: 0x0600290E RID: 10510 RVA: 0x0006CF38 File Offset: 0x0006B138
		private ISnapAngleConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISnapAngleConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISnapAngleConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISnapAngleConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600290F RID: 10511 RVA: 0x0006CF70 File Offset: 0x0006B170
		public static ISnapAngleConfig Create([Nullable(2)] ISnapAngleConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISnapAngleConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002910 RID: 10512 RVA: 0x0006CF83 File Offset: 0x0006B183
		public static ISnapAngleConfig CreateFromSetValue([Nullable(2)] ISnapAngleConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISnapAngleConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002911 RID: 10513 RVA: 0x0006CF96 File Offset: 0x0006B196
		public ISnapAngleConfig_SetValue ToSetValue()
		{
			return new ISnapAngleConfig_SetValue
			{
				Angle = this.Angle,
				Range = this.Range
			};
		}

		// Token: 0x17000AC4 RID: 2756
		// (get) Token: 0x06002912 RID: 10514 RVA: 0x0006CFB5 File Offset: 0x0006B1B5
		// (set) Token: 0x06002913 RID: 10515 RVA: 0x0006CFE4 File Offset: 0x0006B1E4
		public virtual float Angle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Angle;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Angle;
			}
			set
			{
				this.GetOrCreatePoco().Angle = value;
			}
		}

		// Token: 0x17000AC5 RID: 2757
		// (get) Token: 0x06002914 RID: 10516 RVA: 0x0006CFF2 File Offset: 0x0006B1F2
		// (set) Token: 0x06002915 RID: 10517 RVA: 0x0006D021 File Offset: 0x0006B221
		public virtual float Range
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Range;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Range;
			}
			set
			{
				this.GetOrCreatePoco().Range = value;
			}
		}

		// Token: 0x04001BD7 RID: 7127
		[Nullable(2)]
		protected ISnapAngleConfig FbInstance;

		// Token: 0x04001BD8 RID: 7128
		[Nullable(2)]
		protected ISnapAngleConfig_SetValue PocoInterface;
	}
}
