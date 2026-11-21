using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001ADD RID: 6877
	public class ICustomScreenSpine : ICustomScreenTypeBase
	{
		// Token: 0x06009213 RID: 37395 RVA: 0x00156704 File Offset: 0x00154904
		private ICustomScreenSpine_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICustomScreenSpine 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICustomScreenSpine_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICustomScreenSpine_SetValue());
			}
			return result;
		}

		// Token: 0x06009214 RID: 37396 RVA: 0x0015673C File Offset: 0x0015493C
		public static ICustomScreenSpine Create([Nullable(2)] ICustomScreenSpine instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICustomScreenSpine
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009215 RID: 37397 RVA: 0x0015674F File Offset: 0x0015494F
		public static ICustomScreenSpine CreateFromSetValue([Nullable(2)] ICustomScreenSpine_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICustomScreenSpine
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009216 RID: 37398 RVA: 0x00156762 File Offset: 0x00154962
		public new ICustomScreenSpine_SetValue ToSetValue()
		{
			return new ICustomScreenSpine_SetValue
			{
				Type = this.Type,
				SpineId = this.SpineId
			};
		}

		// Token: 0x17002ECA RID: 11978
		// (get) Token: 0x06009217 RID: 37399 RVA: 0x00156781 File Offset: 0x00154981
		// (set) Token: 0x06009218 RID: 37400 RVA: 0x001567AC File Offset: 0x001549AC
		public override ECustomScreenType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECustomScreenType.Spine;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002ECB RID: 11979
		// (get) Token: 0x06009219 RID: 37401 RVA: 0x001567BA File Offset: 0x001549BA
		// (set) Token: 0x0600921A RID: 37402 RVA: 0x001567E5 File Offset: 0x001549E5
		public virtual int SpineId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SpineId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.SpineId;
			}
			set
			{
				this.GetOrCreatePoco().SpineId = value;
			}
		}

		// Token: 0x04005B0B RID: 23307
		[Nullable(2)]
		protected new ICustomScreenSpine FbInstance;

		// Token: 0x04005B0C RID: 23308
		[Nullable(2)]
		protected new ICustomScreenSpine_SetValue PocoInterface;
	}
}
