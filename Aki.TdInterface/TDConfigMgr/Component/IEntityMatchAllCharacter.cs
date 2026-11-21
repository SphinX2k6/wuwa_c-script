using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200036C RID: 876
	public class IEntityMatchAllCharacter : IEntityMatchConfig
	{
		// Token: 0x0600110A RID: 4362 RVA: 0x0003A9C0 File Offset: 0x00038BC0
		private IEntityMatchAllCharacter_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEntityMatchAllCharacter 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEntityMatchAllCharacter_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEntityMatchAllCharacter_SetValue());
			}
			return result;
		}

		// Token: 0x0600110B RID: 4363 RVA: 0x0003A9F8 File Offset: 0x00038BF8
		public static IEntityMatchAllCharacter Create([Nullable(2)] IEntityMatchAllCharacter instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityMatchAllCharacter
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600110C RID: 4364 RVA: 0x0003AA0B File Offset: 0x00038C0B
		public static IEntityMatchAllCharacter CreateFromSetValue([Nullable(2)] IEntityMatchAllCharacter_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEntityMatchAllCharacter
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600110D RID: 4365 RVA: 0x0003AA1E File Offset: 0x00038C1E
		public new IEntityMatchAllCharacter_SetValue ToSetValue()
		{
			return new IEntityMatchAllCharacter_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x0600110E RID: 4366 RVA: 0x0003AA31 File Offset: 0x00038C31
		// (set) Token: 0x0600110F RID: 4367 RVA: 0x0003AA5C File Offset: 0x00038C5C
		public override EEntityMatchType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EEntityMatchType.Player;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04000E63 RID: 3683
		[Nullable(2)]
		protected new IEntityMatchAllCharacter FbInstance;

		// Token: 0x04000E64 RID: 3684
		[Nullable(2)]
		protected new IEntityMatchAllCharacter_SetValue PocoInterface;
	}
}
