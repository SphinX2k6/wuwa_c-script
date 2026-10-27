using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200185E RID: 6238
	[NullableContext(1)]
	[Nullable(0)]
	public class ICenterTextShowType
	{
		// Token: 0x06008609 RID: 34313 RVA: 0x0013EA28 File Offset: 0x0013CC28
		private ICenterTextShowType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICenterTextShowType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICenterTextShowType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICenterTextShowType_SetValue());
			}
			return result;
		}

		// Token: 0x0600860A RID: 34314 RVA: 0x0013EA60 File Offset: 0x0013CC60
		public static ICenterTextShowType Create([Nullable(2)] ICenterTextShowType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICenterTextShowType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600860B RID: 34315 RVA: 0x0013EA73 File Offset: 0x0013CC73
		public static ICenterTextShowType CreateFromSetValue([Nullable(2)] ICenterTextShowType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICenterTextShowType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600860C RID: 34316 RVA: 0x0013EA86 File Offset: 0x0013CC86
		public ICenterTextShowType_SetValue ToSetValue()
		{
			return new ICenterTextShowType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002BCC RID: 11212
		// (get) Token: 0x0600860D RID: 34317 RVA: 0x0013EA99 File Offset: 0x0013CC99
		// (set) Token: 0x0600860E RID: 34318 RVA: 0x0013EAC4 File Offset: 0x0013CCC4
		public virtual ECenterTextShowAnim Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECenterTextShowAnim.ShowAll;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400549D RID: 21661
		[Nullable(2)]
		protected ICenterTextShowType FbInstance;

		// Token: 0x0400549E RID: 21662
		[Nullable(2)]
		protected ICenterTextShowType_SetValue PocoInterface;
	}
}
