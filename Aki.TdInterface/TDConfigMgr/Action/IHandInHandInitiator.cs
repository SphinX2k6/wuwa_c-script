using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C94 RID: 7316
	public class IHandInHandInitiator
	{
		// Token: 0x06009B6C RID: 39788 RVA: 0x001670B4 File Offset: 0x001652B4
		private IHandInHandInitiator_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHandInHandInitiator 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHandInHandInitiator_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHandInHandInitiator_SetValue());
			}
			return result;
		}

		// Token: 0x06009B6D RID: 39789 RVA: 0x001670EC File Offset: 0x001652EC
		public static IHandInHandInitiator Create([Nullable(2)] IHandInHandInitiator instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHandInHandInitiator
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009B6E RID: 39790 RVA: 0x001670FF File Offset: 0x001652FF
		public static IHandInHandInitiator CreateFromSetValue([Nullable(2)] IHandInHandInitiator_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHandInHandInitiator
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009B6F RID: 39791 RVA: 0x00167112 File Offset: 0x00165312
		public IHandInHandInitiator_SetValue ToSetValue()
		{
			return new IHandInHandInitiator_SetValue
			{
				Initiator = this.Initiator,
				HandType = this.HandType
			};
		}

		// Token: 0x170030E5 RID: 12517
		// (get) Token: 0x06009B70 RID: 39792 RVA: 0x00167131 File Offset: 0x00165331
		// (set) Token: 0x06009B71 RID: 39793 RVA: 0x00167158 File Offset: 0x00165358
		public virtual IHandInHandInitiatorType Initiator
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Initiator;
				}
				IHandInHandInitiator_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Initiator;
			}
			set
			{
				this.GetOrCreatePoco().Initiator = value;
			}
		}

		// Token: 0x170030E6 RID: 12518
		// (get) Token: 0x06009B72 RID: 39794 RVA: 0x00167166 File Offset: 0x00165366
		// (set) Token: 0x06009B73 RID: 39795 RVA: 0x00167191 File Offset: 0x00165391
		public virtual EHandType HandType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HandType;
				}
				if (this.PocoInterface == null)
				{
					return EHandType.Left;
				}
				return this.PocoInterface.HandType;
			}
			set
			{
				this.GetOrCreatePoco().HandType = value;
			}
		}

		// Token: 0x04005F3E RID: 24382
		[Nullable(2)]
		protected IHandInHandInitiator FbInstance;

		// Token: 0x04005F3F RID: 24383
		[Nullable(2)]
		protected IHandInHandInitiator_SetValue PocoInterface;
	}
}
