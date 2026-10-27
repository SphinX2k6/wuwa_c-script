using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200200E RID: 8206
	[NullableContext(1)]
	[Nullable(0)]
	public class IUiGame
	{
		// Token: 0x0600B47A RID: 46202 RVA: 0x001A3A74 File Offset: 0x001A1C74
		private IUiGame_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IUiGame 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IUiGame_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IUiGame_SetValue());
			}
			return result;
		}

		// Token: 0x0600B47B RID: 46203 RVA: 0x001A3AAC File Offset: 0x001A1CAC
		public static IUiGame Create([Nullable(2)] IUiGame instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUiGame
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B47C RID: 46204 RVA: 0x001A3ABF File Offset: 0x001A1CBF
		public static IUiGame CreateFromSetValue([Nullable(2)] IUiGame_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IUiGame
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B47D RID: 46205 RVA: 0x001A3AD2 File Offset: 0x001A1CD2
		public IUiGame_SetValue ToSetValue()
		{
			return new IUiGame_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003780 RID: 14208
		// (get) Token: 0x0600B47E RID: 46206 RVA: 0x001A3AE5 File Offset: 0x001A1CE5
		// (set) Token: 0x0600B47F RID: 46207 RVA: 0x001A3B10 File Offset: 0x001A1D10
		public virtual ESimpleGameplayType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESimpleGameplayType.Cipher;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006CC3 RID: 27843
		[Nullable(2)]
		protected IUiGame FbInstance;

		// Token: 0x04006CC4 RID: 27844
		[Nullable(2)]
		protected IUiGame_SetValue PocoInterface;
	}
}
