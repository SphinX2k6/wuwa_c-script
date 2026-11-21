using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000485 RID: 1157
	public class IHitLogicType
	{
		// Token: 0x06001721 RID: 5921 RVA: 0x00047368 File Offset: 0x00045568
		private IHitLogicType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHitLogicType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHitLogicType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHitLogicType_SetValue());
			}
			return result;
		}

		// Token: 0x06001722 RID: 5922 RVA: 0x000473A0 File Offset: 0x000455A0
		public static IHitLogicType Create([Nullable(2)] IHitLogicType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHitLogicType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001723 RID: 5923 RVA: 0x000473B3 File Offset: 0x000455B3
		public static IHitLogicType CreateFromSetValue([Nullable(2)] IHitLogicType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHitLogicType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001724 RID: 5924 RVA: 0x000473C6 File Offset: 0x000455C6
		public IHitLogicType_SetValue ToSetValue()
		{
			return new IHitLogicType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x06001725 RID: 5925 RVA: 0x000473D9 File Offset: 0x000455D9
		// (set) Token: 0x06001726 RID: 5926 RVA: 0x00047404 File Offset: 0x00045604
		public virtual EHitLogicType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EHitLogicType.ChangeNextState;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040011C2 RID: 4546
		[Nullable(2)]
		protected IHitLogicType FbInstance;

		// Token: 0x040011C3 RID: 4547
		[Nullable(2)]
		protected IHitLogicType_SetValue PocoInterface;
	}
}
