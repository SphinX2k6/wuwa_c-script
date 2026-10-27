using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BA4 RID: 7076
	[NullableContext(1)]
	[Nullable(0)]
	public class ILongPressInteractStyleConfigDefault : ILongPressInteractStyleConfig
	{
		// Token: 0x0600978B RID: 38795 RVA: 0x0015D94C File Offset: 0x0015BB4C
		private ILongPressInteractStyleConfigDefault_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILongPressInteractStyleConfigDefault 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILongPressInteractStyleConfigDefault_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILongPressInteractStyleConfigDefault_SetValue());
			}
			return result;
		}

		// Token: 0x0600978C RID: 38796 RVA: 0x0015D984 File Offset: 0x0015BB84
		public static ILongPressInteractStyleConfigDefault Create([Nullable(2)] ILongPressInteractStyleConfigDefault instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILongPressInteractStyleConfigDefault
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600978D RID: 38797 RVA: 0x0015D997 File Offset: 0x0015BB97
		public static ILongPressInteractStyleConfigDefault CreateFromSetValue([Nullable(2)] ILongPressInteractStyleConfigDefault_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILongPressInteractStyleConfigDefault
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600978E RID: 38798 RVA: 0x0015D9AA File Offset: 0x0015BBAA
		public new ILongPressInteractStyleConfigDefault_SetValue ToSetValue()
		{
			return new ILongPressInteractStyleConfigDefault_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002FA6 RID: 12198
		// (get) Token: 0x0600978F RID: 38799 RVA: 0x0015D9BD File Offset: 0x0015BBBD
		// (set) Token: 0x06009790 RID: 38800 RVA: 0x0015D9E8 File Offset: 0x0015BBE8
		public override ELongPressInteractStyle Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELongPressInteractStyle.Default;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005C83 RID: 23683
		[Nullable(2)]
		protected new ILongPressInteractStyleConfigDefault FbInstance;

		// Token: 0x04005C84 RID: 23684
		[Nullable(2)]
		protected new ILongPressInteractStyleConfigDefault_SetValue PocoInterface;
	}
}
