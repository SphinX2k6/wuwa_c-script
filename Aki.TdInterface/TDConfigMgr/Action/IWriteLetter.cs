using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020C1 RID: 8385
	[NullableContext(1)]
	[Nullable(0)]
	public class IWriteLetter : IUiGame
	{
		// Token: 0x0600B854 RID: 47188 RVA: 0x001AA9C0 File Offset: 0x001A8BC0
		private IWriteLetter_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWriteLetter 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWriteLetter_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWriteLetter_SetValue());
			}
			return result;
		}

		// Token: 0x0600B855 RID: 47189 RVA: 0x001AA9F8 File Offset: 0x001A8BF8
		public static IWriteLetter Create([Nullable(2)] IWriteLetter instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWriteLetter
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B856 RID: 47190 RVA: 0x001AAA0B File Offset: 0x001A8C0B
		public static IWriteLetter CreateFromSetValue([Nullable(2)] IWriteLetter_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWriteLetter
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B857 RID: 47191 RVA: 0x001AAA1E File Offset: 0x001A8C1E
		public new IWriteLetter_SetValue ToSetValue()
		{
			return new IWriteLetter_SetValue
			{
				Type = this.Type,
				Id = this.Id
			};
		}

		// Token: 0x17003861 RID: 14433
		// (get) Token: 0x0600B858 RID: 47192 RVA: 0x001AAA3D File Offset: 0x001A8C3D
		// (set) Token: 0x0600B859 RID: 47193 RVA: 0x001AAA68 File Offset: 0x001A8C68
		public override ESimpleGameplayType Type
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

		// Token: 0x17003862 RID: 14434
		// (get) Token: 0x0600B85A RID: 47194 RVA: 0x001AAA76 File Offset: 0x001A8C76
		// (set) Token: 0x0600B85B RID: 47195 RVA: 0x001AAAA1 File Offset: 0x001A8CA1
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

		// Token: 0x04006E80 RID: 28288
		[Nullable(2)]
		protected new IWriteLetter FbInstance;

		// Token: 0x04006E81 RID: 28289
		[Nullable(2)]
		protected new IWriteLetter_SetValue PocoInterface;
	}
}
