using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E93 RID: 7827
	[NullableContext(1)]
	[Nullable(0)]
	public class ISoar2 : ILeisureInteractType
	{
		// Token: 0x0600A77A RID: 42874 RVA: 0x0017A820 File Offset: 0x00178A20
		private ISoar2_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISoar2 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISoar2_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISoar2_SetValue());
			}
			return result;
		}

		// Token: 0x0600A77B RID: 42875 RVA: 0x0017A858 File Offset: 0x00178A58
		public static ISoar2 Create([Nullable(2)] ISoar2 instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISoar2
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A77C RID: 42876 RVA: 0x0017A86B File Offset: 0x00178A6B
		public static ISoar2 CreateFromSetValue([Nullable(2)] ISoar2_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISoar2
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A77D RID: 42877 RVA: 0x0017A87E File Offset: 0x00178A7E
		public new ISoar2_SetValue ToSetValue()
		{
			return new ISoar2_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003338 RID: 13112
		// (get) Token: 0x0600A77E RID: 42878 RVA: 0x0017A891 File Offset: 0x00178A91
		// (set) Token: 0x0600A77F RID: 42879 RVA: 0x0017A8BC File Offset: 0x00178ABC
		public override ELeisureInteract Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELeisureInteract.CustomSkill;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040063E3 RID: 25571
		[Nullable(2)]
		protected new ISoar2 FbInstance;

		// Token: 0x040063E4 RID: 25572
		[Nullable(2)]
		protected new ISoar2_SetValue PocoInterface;
	}
}
