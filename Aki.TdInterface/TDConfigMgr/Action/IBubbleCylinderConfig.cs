using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019A5 RID: 6565
	public class IBubbleCylinderConfig
	{
		// Token: 0x06008B91 RID: 35729 RVA: 0x0014AF60 File Offset: 0x00149160
		private IBubbleCylinderConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBubbleCylinderConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBubbleCylinderConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBubbleCylinderConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06008B92 RID: 35730 RVA: 0x0014AF98 File Offset: 0x00149198
		public static IBubbleCylinderConfig Create([Nullable(2)] IBubbleCylinderConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBubbleCylinderConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008B93 RID: 35731 RVA: 0x0014AFAB File Offset: 0x001491AB
		public static IBubbleCylinderConfig CreateFromSetValue([Nullable(2)] IBubbleCylinderConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBubbleCylinderConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008B94 RID: 35732 RVA: 0x0014AFBE File Offset: 0x001491BE
		public IBubbleCylinderConfig_SetValue ToSetValue()
		{
			return new IBubbleCylinderConfig_SetValue
			{
				Radius = this.Radius,
				Height = this.Height
			};
		}

		// Token: 0x17002D5D RID: 11613
		// (get) Token: 0x06008B95 RID: 35733 RVA: 0x0014AFDD File Offset: 0x001491DD
		// (set) Token: 0x06008B96 RID: 35734 RVA: 0x0014B00C File Offset: 0x0014920C
		public virtual float Radius
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Radius;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Radius;
			}
			set
			{
				this.GetOrCreatePoco().Radius = value;
			}
		}

		// Token: 0x17002D5E RID: 11614
		// (get) Token: 0x06008B97 RID: 35735 RVA: 0x0014B01A File Offset: 0x0014921A
		// (set) Token: 0x06008B98 RID: 35736 RVA: 0x0014B049 File Offset: 0x00149249
		public virtual float Height
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Height;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Height;
			}
			set
			{
				this.GetOrCreatePoco().Height = value;
			}
		}

		// Token: 0x0400581A RID: 22554
		[Nullable(2)]
		protected IBubbleCylinderConfig FbInstance;

		// Token: 0x0400581B RID: 22555
		[Nullable(2)]
		protected IBubbleCylinderConfig_SetValue PocoInterface;
	}
}
