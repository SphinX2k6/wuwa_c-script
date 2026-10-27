using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AF3 RID: 6899
	[NullableContext(1)]
	[Nullable(0)]
	public class IHeadStyleVoiceOnly : IHeadStyle
	{
		// Token: 0x060093C8 RID: 37832 RVA: 0x00156B10 File Offset: 0x00154D10
		private IHeadStyleVoiceOnly_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHeadStyleVoiceOnly 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHeadStyleVoiceOnly_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHeadStyleVoiceOnly_SetValue());
			}
			return result;
		}

		// Token: 0x060093C9 RID: 37833 RVA: 0x00156B48 File Offset: 0x00154D48
		public static IHeadStyleVoiceOnly Create([Nullable(2)] IHeadStyleVoiceOnly instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHeadStyleVoiceOnly
			{
				FbInstance = instance
			};
		}

		// Token: 0x060093CA RID: 37834 RVA: 0x00156B5B File Offset: 0x00154D5B
		public static IHeadStyleVoiceOnly CreateFromSetValue([Nullable(2)] IHeadStyleVoiceOnly_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHeadStyleVoiceOnly
			{
				PocoInterface = value
			};
		}

		// Token: 0x060093CB RID: 37835 RVA: 0x00156B6E File Offset: 0x00154D6E
		public new IHeadStyleVoiceOnly_SetValue ToSetValue()
		{
			return new IHeadStyleVoiceOnly_SetValue
			{
				Type = this.Type,
				WhoId = this.WhoId
			};
		}

		// Token: 0x17002ECD RID: 11981
		// (get) Token: 0x060093CC RID: 37836 RVA: 0x00156B8D File Offset: 0x00154D8D
		// (set) Token: 0x060093CD RID: 37837 RVA: 0x00156BB8 File Offset: 0x00154DB8
		public override EHeadStyle Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EHeadStyle.Normal;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002ECE RID: 11982
		// (get) Token: 0x060093CE RID: 37838 RVA: 0x00156BC6 File Offset: 0x00154DC6
		// (set) Token: 0x060093CF RID: 37839 RVA: 0x00156BF1 File Offset: 0x00154DF1
		public virtual int WhoId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.WhoId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.WhoId;
			}
			set
			{
				this.GetOrCreatePoco().WhoId = value;
			}
		}

		// Token: 0x04005ABE RID: 23230
		[Nullable(2)]
		protected new IHeadStyleVoiceOnly FbInstance;

		// Token: 0x04005ABF RID: 23231
		[Nullable(2)]
		protected new IHeadStyleVoiceOnly_SetValue PocoInterface;
	}
}
