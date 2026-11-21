using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A0B RID: 6667
	public class ICharacterLookAtData
	{
		// Token: 0x06008DE9 RID: 36329 RVA: 0x0014F694 File Offset: 0x0014D894
		private ICharacterLookAtData_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICharacterLookAtData 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICharacterLookAtData_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICharacterLookAtData_SetValue());
			}
			return result;
		}

		// Token: 0x06008DEA RID: 36330 RVA: 0x0014F6CC File Offset: 0x0014D8CC
		public static ICharacterLookAtData Create([Nullable(2)] ICharacterLookAtData instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICharacterLookAtData
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008DEB RID: 36331 RVA: 0x0014F6DF File Offset: 0x0014D8DF
		public static ICharacterLookAtData CreateFromSetValue([Nullable(2)] ICharacterLookAtData_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICharacterLookAtData
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008DEC RID: 36332 RVA: 0x0014F6F2 File Offset: 0x0014D8F2
		public ICharacterLookAtData_SetValue ToSetValue()
		{
			return new ICharacterLookAtData_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002DF0 RID: 11760
		// (get) Token: 0x06008DED RID: 36333 RVA: 0x0014F705 File Offset: 0x0014D905
		// (set) Token: 0x06008DEE RID: 36334 RVA: 0x0014F730 File Offset: 0x0014D930
		public virtual ECharacterLookAt Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECharacterLookAt.Empty;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400593B RID: 22843
		[Nullable(2)]
		protected ICharacterLookAtData FbInstance;

		// Token: 0x0400593C RID: 22844
		[Nullable(2)]
		protected ICharacterLookAtData_SetValue PocoInterface;
	}
}
