using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012E0 RID: 4832
	[NullableContext(2)]
	[Nullable(0)]
	public class ITimerUiConfig
	{
		// Token: 0x06006CCB RID: 27851 RVA: 0x00103478 File Offset: 0x00101678
		[NullableContext(0)]
		private ITimerUiConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITimerUiConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITimerUiConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITimerUiConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06006CCC RID: 27852 RVA: 0x001034B0 File Offset: 0x001016B0
		[NullableContext(0)]
		public static ITimerUiConfig Create([Nullable(2)] ITimerUiConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITimerUiConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006CCD RID: 27853 RVA: 0x001034C3 File Offset: 0x001016C3
		[NullableContext(0)]
		public static ITimerUiConfig CreateFromSetValue([Nullable(2)] ITimerUiConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITimerUiConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006CCE RID: 27854 RVA: 0x001034D6 File Offset: 0x001016D6
		[NullableContext(0)]
		public ITimerUiConfig_SetValue ToSetValue()
		{
			return new ITimerUiConfig_SetValue
			{
				UiType = this.UiType,
				TidTitle = this.TidTitle,
				EdTidTitle = this.EdTidTitle
			};
		}

		// Token: 0x17002315 RID: 8981
		// (get) Token: 0x06006CCF RID: 27855 RVA: 0x00103501 File Offset: 0x00101701
		// (set) Token: 0x06006CD0 RID: 27856 RVA: 0x0010352C File Offset: 0x0010172C
		public virtual ETimerUiType UiType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.UiType;
				}
				if (this.PocoInterface == null)
				{
					return ETimerUiType.Default;
				}
				return this.PocoInterface.UiType;
			}
			set
			{
				this.GetOrCreatePoco().UiType = value;
			}
		}

		// Token: 0x17002316 RID: 8982
		// (get) Token: 0x06006CD1 RID: 27857 RVA: 0x0010353A File Offset: 0x0010173A
		// (set) Token: 0x06006CD2 RID: 27858 RVA: 0x00103561 File Offset: 0x00101761
		public virtual string TidTitle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidTitle;
				}
				ITimerUiConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TidTitle;
			}
			set
			{
				this.GetOrCreatePoco().TidTitle = value;
			}
		}

		// Token: 0x17002317 RID: 8983
		// (get) Token: 0x06006CD3 RID: 27859 RVA: 0x0010356F File Offset: 0x0010176F
		// (set) Token: 0x06006CD4 RID: 27860 RVA: 0x00103586 File Offset: 0x00101786
		public virtual string EdTidTitle
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTidTitle;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdTidTitle = value;
			}
		}

		// Token: 0x040040F5 RID: 16629
		protected ITimerUiConfig FbInstance;

		// Token: 0x040040F6 RID: 16630
		protected ITimerUiConfig_SetValue PocoInterface;
	}
}
