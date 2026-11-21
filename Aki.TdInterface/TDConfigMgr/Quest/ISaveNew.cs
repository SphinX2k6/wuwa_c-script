using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001252 RID: 4690
	public class ISaveNew : ISaveConfigType
	{
		// Token: 0x06006907 RID: 26887 RVA: 0x000FB3C8 File Offset: 0x000F95C8
		private ISaveNew_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISaveNew 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISaveNew_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISaveNew_SetValue());
			}
			return result;
		}

		// Token: 0x06006908 RID: 26888 RVA: 0x000FB400 File Offset: 0x000F9600
		public static ISaveNew Create([Nullable(2)] ISaveNew instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISaveNew
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006909 RID: 26889 RVA: 0x000FB413 File Offset: 0x000F9613
		public static ISaveNew CreateFromSetValue([Nullable(2)] ISaveNew_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISaveNew
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600690A RID: 26890 RVA: 0x000FB426 File Offset: 0x000F9626
		public new ISaveNew_SetValue ToSetValue()
		{
			return new ISaveNew_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002207 RID: 8711
		// (get) Token: 0x0600690B RID: 26891 RVA: 0x000FB439 File Offset: 0x000F9639
		// (set) Token: 0x0600690C RID: 26892 RVA: 0x000FB464 File Offset: 0x000F9664
		public override ESaveConfig Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESaveConfig.SaveNew;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04003EB1 RID: 16049
		[Nullable(2)]
		protected new ISaveNew FbInstance;

		// Token: 0x04003EB2 RID: 16050
		[Nullable(2)]
		protected new ISaveNew_SetValue PocoInterface;
	}
}
