using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200190A RID: 6410
	[NullableContext(1)]
	[Nullable(0)]
	public class ICommonConfirmBox : IInteractionConfirmBoxType
	{
		// Token: 0x0600895B RID: 35163 RVA: 0x001444E4 File Offset: 0x001426E4
		private ICommonConfirmBox_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICommonConfirmBox 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICommonConfirmBox_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICommonConfirmBox_SetValue());
			}
			return result;
		}

		// Token: 0x0600895C RID: 35164 RVA: 0x0014451C File Offset: 0x0014271C
		public static ICommonConfirmBox Create([Nullable(2)] ICommonConfirmBox instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonConfirmBox
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600895D RID: 35165 RVA: 0x0014452F File Offset: 0x0014272F
		public static ICommonConfirmBox CreateFromSetValue([Nullable(2)] ICommonConfirmBox_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICommonConfirmBox
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600895E RID: 35166 RVA: 0x00144542 File Offset: 0x00142742
		public new ICommonConfirmBox_SetValue ToSetValue()
		{
			return new ICommonConfirmBox_SetValue
			{
				Type = this.Type,
				Id = this.Id
			};
		}

		// Token: 0x17002C73 RID: 11379
		// (get) Token: 0x0600895F RID: 35167 RVA: 0x00144561 File Offset: 0x00142761
		// (set) Token: 0x06008960 RID: 35168 RVA: 0x0014458C File Offset: 0x0014278C
		public override EInteractionConfirmBoxType Type
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

		// Token: 0x17002C74 RID: 11380
		// (get) Token: 0x06008961 RID: 35169 RVA: 0x0014459A File Offset: 0x0014279A
		// (set) Token: 0x06008962 RID: 35170 RVA: 0x001445C5 File Offset: 0x001427C5
		public virtual int Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x04005614 RID: 22036
		[Nullable(2)]
		protected new ICommonConfirmBox FbInstance;

		// Token: 0x04005615 RID: 22037
		[Nullable(2)]
		protected new ICommonConfirmBox_SetValue PocoInterface;
	}
}
