using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F5D RID: 8029
	public class IPreloadPhantomCharacterForSkill : IPreloadCharacterType
	{
		// Token: 0x0600AAD3 RID: 43731 RVA: 0x00183190 File Offset: 0x00181390
		private IPreloadPhantomCharacterForSkill_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPreloadPhantomCharacterForSkill 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPreloadPhantomCharacterForSkill_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPreloadPhantomCharacterForSkill_SetValue());
			}
			return result;
		}

		// Token: 0x0600AAD4 RID: 43732 RVA: 0x001831C8 File Offset: 0x001813C8
		public static IPreloadPhantomCharacterForSkill Create([Nullable(2)] IPreloadPhantomCharacterForSkill instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPreloadPhantomCharacterForSkill
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AAD5 RID: 43733 RVA: 0x001831DB File Offset: 0x001813DB
		public static IPreloadPhantomCharacterForSkill CreateFromSetValue([Nullable(2)] IPreloadPhantomCharacterForSkill_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPreloadPhantomCharacterForSkill
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AAD6 RID: 43734 RVA: 0x001831EE File Offset: 0x001813EE
		public new IPreloadPhantomCharacterForSkill_SetValue ToSetValue()
		{
			return new IPreloadPhantomCharacterForSkill_SetValue
			{
				Type = this.Type,
				Id = this.Id
			};
		}

		// Token: 0x1700346C RID: 13420
		// (get) Token: 0x0600AAD7 RID: 43735 RVA: 0x0018320D File Offset: 0x0018140D
		// (set) Token: 0x0600AAD8 RID: 43736 RVA: 0x00183238 File Offset: 0x00181438
		public override EPreloadObjectType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPreloadObjectType.PreloadTrialCharacterForSkill;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700346D RID: 13421
		// (get) Token: 0x0600AAD9 RID: 43737 RVA: 0x00183246 File Offset: 0x00181446
		// (set) Token: 0x0600AADA RID: 43738 RVA: 0x00183271 File Offset: 0x00181471
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

		// Token: 0x04006665 RID: 26213
		[Nullable(2)]
		protected new IPreloadPhantomCharacterForSkill FbInstance;

		// Token: 0x04006666 RID: 26214
		[Nullable(2)]
		protected new IPreloadPhantomCharacterForSkill_SetValue PocoInterface;
	}
}
