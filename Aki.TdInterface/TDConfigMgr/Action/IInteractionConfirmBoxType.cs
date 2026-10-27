using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B4A RID: 6986
	[NullableContext(1)]
	[Nullable(0)]
	public class IInteractionConfirmBoxType
	{
		// Token: 0x0600957F RID: 38271 RVA: 0x0015999C File Offset: 0x00157B9C
		private IInteractionConfirmBoxType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInteractionConfirmBoxType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInteractionConfirmBoxType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInteractionConfirmBoxType_SetValue());
			}
			return result;
		}

		// Token: 0x06009580 RID: 38272 RVA: 0x001599D4 File Offset: 0x00157BD4
		public static IInteractionConfirmBoxType Create([Nullable(2)] IInteractionConfirmBoxType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractionConfirmBoxType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009581 RID: 38273 RVA: 0x001599E7 File Offset: 0x00157BE7
		public static IInteractionConfirmBoxType CreateFromSetValue([Nullable(2)] IInteractionConfirmBoxType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInteractionConfirmBoxType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009582 RID: 38274 RVA: 0x001599FA File Offset: 0x00157BFA
		public IInteractionConfirmBoxType_SetValue ToSetValue()
		{
			return new IInteractionConfirmBoxType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002F27 RID: 12071
		// (get) Token: 0x06009583 RID: 38275 RVA: 0x00159A0D File Offset: 0x00157C0D
		// (set) Token: 0x06009584 RID: 38276 RVA: 0x00159A38 File Offset: 0x00157C38
		public virtual EInteractionConfirmBoxType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInteractionConfirmBoxType.Common;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005B7A RID: 23418
		[Nullable(2)]
		protected IInteractionConfirmBoxType FbInstance;

		// Token: 0x04005B7B RID: 23419
		[Nullable(2)]
		protected IInteractionConfirmBoxType_SetValue PocoInterface;
	}
}
