using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018FD RID: 6397
	public class IActorLookAt : ActionParams
	{
		// Token: 0x06008637 RID: 34359 RVA: 0x0013F82C File Offset: 0x0013DA2C
		private IActorLookAt_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IActorLookAt 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IActorLookAt_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IActorLookAt_SetValue());
			}
			return result;
		}

		// Token: 0x06008638 RID: 34360 RVA: 0x0013F864 File Offset: 0x0013DA64
		public static IActorLookAt Create([Nullable(2)] IActorLookAt instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorLookAt
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008639 RID: 34361 RVA: 0x0013F877 File Offset: 0x0013DA77
		public static IActorLookAt CreateFromSetValue([Nullable(2)] IActorLookAt_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IActorLookAt
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600863A RID: 34362 RVA: 0x0013F88A File Offset: 0x0013DA8A
		public IActorLookAt_SetValue ToSetValue()
		{
			return new IActorLookAt_SetValue
			{
				ActorIndex = this.ActorIndex,
				Target = this.Target,
				DelayTime = this.DelayTime,
				LookAtSpeedRate = this.LookAtSpeedRate
			};
		}

		// Token: 0x17002BAC RID: 11180
		// (get) Token: 0x0600863B RID: 34363 RVA: 0x0013F8C1 File Offset: 0x0013DAC1
		// (set) Token: 0x0600863C RID: 34364 RVA: 0x0013F8EC File Offset: 0x0013DAEC
		public virtual int ActorIndex
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ActorIndex;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.ActorIndex;
			}
			set
			{
				this.GetOrCreatePoco().ActorIndex = value;
			}
		}

		// Token: 0x17002BAD RID: 11181
		// (get) Token: 0x0600863D RID: 34365 RVA: 0x0013F8FA File Offset: 0x0013DAFA
		// (set) Token: 0x0600863E RID: 34366 RVA: 0x0013F921 File Offset: 0x0013DB21
		public virtual IActorLookAtData Target
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Target;
				}
				IActorLookAt_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Target;
			}
			set
			{
				this.GetOrCreatePoco().Target = value;
			}
		}

		// Token: 0x17002BAE RID: 11182
		// (get) Token: 0x0600863F RID: 34367 RVA: 0x0013F930 File Offset: 0x0013DB30
		// (set) Token: 0x06008640 RID: 34368 RVA: 0x0013F96A File Offset: 0x0013DB6A
		public virtual float? DelayTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DelayTime;
				}
				IActorLookAt_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DelayTime;
			}
			set
			{
				this.GetOrCreatePoco().DelayTime = value;
			}
		}

		// Token: 0x17002BAF RID: 11183
		// (get) Token: 0x06008641 RID: 34369 RVA: 0x0013F978 File Offset: 0x0013DB78
		// (set) Token: 0x06008642 RID: 34370 RVA: 0x0013F9B2 File Offset: 0x0013DBB2
		public virtual float? LookAtSpeedRate
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LookAtSpeedRate;
				}
				IActorLookAt_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.LookAtSpeedRate;
			}
			set
			{
				this.GetOrCreatePoco().LookAtSpeedRate = value;
			}
		}

		// Token: 0x04005527 RID: 21799
		[Nullable(2)]
		protected new IActorLookAt FbInstance;

		// Token: 0x04005528 RID: 21800
		[Nullable(2)]
		protected IActorLookAt_SetValue PocoInterface;
	}
}
