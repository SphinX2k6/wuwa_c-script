using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AE7 RID: 6887
	[NullableContext(1)]
	[Nullable(0)]
	public class IHandInHandInitiator
	{
		// Token: 0x06009392 RID: 37778 RVA: 0x001565E0 File Offset: 0x001547E0
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

		// Token: 0x06009393 RID: 37779 RVA: 0x00156618 File Offset: 0x00154818
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

		// Token: 0x06009394 RID: 37780 RVA: 0x0015662B File Offset: 0x0015482B
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

		// Token: 0x06009395 RID: 37781 RVA: 0x0015663E File Offset: 0x0015483E
		public IHandInHandInitiator_SetValue ToSetValue()
		{
			return new IHandInHandInitiator_SetValue
			{
				Initiator = this.Initiator,
				HandType = this.HandType
			};
		}

		// Token: 0x17002EC4 RID: 11972
		// (get) Token: 0x06009396 RID: 37782 RVA: 0x0015665D File Offset: 0x0015485D
		// (set) Token: 0x06009397 RID: 37783 RVA: 0x00156684 File Offset: 0x00154884
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

		// Token: 0x17002EC5 RID: 11973
		// (get) Token: 0x06009398 RID: 37784 RVA: 0x00156692 File Offset: 0x00154892
		// (set) Token: 0x06009399 RID: 37785 RVA: 0x001566BD File Offset: 0x001548BD
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

		// Token: 0x04005AA9 RID: 23209
		[Nullable(2)]
		protected IHandInHandInitiator FbInstance;

		// Token: 0x04005AAA RID: 23210
		[Nullable(2)]
		protected IHandInHandInitiator_SetValue PocoInterface;
	}
}
