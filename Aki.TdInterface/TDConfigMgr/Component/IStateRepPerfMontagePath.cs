using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000717 RID: 1815
	[NullableContext(1)]
	[Nullable(0)]
	public class IStateRepPerfMontagePath : IStateRepPerfBase
	{
		// Token: 0x06002707 RID: 9991 RVA: 0x00067FC0 File Offset: 0x000661C0
		private IStateRepPerfMontagePath_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IStateRepPerfMontagePath 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IStateRepPerfMontagePath_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IStateRepPerfMontagePath_SetValue());
			}
			return result;
		}

		// Token: 0x06002708 RID: 9992 RVA: 0x00067FF8 File Offset: 0x000661F8
		public static IStateRepPerfMontagePath Create([Nullable(2)] IStateRepPerfMontagePath instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStateRepPerfMontagePath
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002709 RID: 9993 RVA: 0x0006800B File Offset: 0x0006620B
		public static IStateRepPerfMontagePath CreateFromSetValue([Nullable(2)] IStateRepPerfMontagePath_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IStateRepPerfMontagePath
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600270A RID: 9994 RVA: 0x0006801E File Offset: 0x0006621E
		public new IStateRepPerfMontagePath_SetValue ToSetValue()
		{
			return new IStateRepPerfMontagePath_SetValue
			{
				Type = this.Type,
				MontagePath = this.MontagePath,
				MontageName = this.MontageName
			};
		}

		// Token: 0x17000A41 RID: 2625
		// (get) Token: 0x0600270B RID: 9995 RVA: 0x00068049 File Offset: 0x00066249
		// (set) Token: 0x0600270C RID: 9996 RVA: 0x00068074 File Offset: 0x00066274
		public override EStateRepPerfType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EStateRepPerfType.SkillId;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000A42 RID: 2626
		// (get) Token: 0x0600270D RID: 9997 RVA: 0x00068082 File Offset: 0x00066282
		// (set) Token: 0x0600270E RID: 9998 RVA: 0x000680AD File Offset: 0x000662AD
		public virtual string MontagePath
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MontagePath;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.MontagePath;
			}
			set
			{
				this.GetOrCreatePoco().MontagePath = value;
			}
		}

		// Token: 0x17000A43 RID: 2627
		// (get) Token: 0x0600270F RID: 9999 RVA: 0x000680BB File Offset: 0x000662BB
		// (set) Token: 0x06002710 RID: 10000 RVA: 0x000680E6 File Offset: 0x000662E6
		public virtual string MontageName
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MontageName;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.MontageName;
			}
			set
			{
				this.GetOrCreatePoco().MontageName = value;
			}
		}

		// Token: 0x04001A5B RID: 6747
		[Nullable(2)]
		protected new IStateRepPerfMontagePath FbInstance;

		// Token: 0x04001A5C RID: 6748
		[Nullable(2)]
		protected new IStateRepPerfMontagePath_SetValue PocoInterface;
	}
}
