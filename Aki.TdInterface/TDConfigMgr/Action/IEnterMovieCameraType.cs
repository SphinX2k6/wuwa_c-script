using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019FC RID: 6652
	[NullableContext(1)]
	[Nullable(0)]
	public class IEnterMovieCameraType
	{
		// Token: 0x06008E85 RID: 36485 RVA: 0x0014D51C File Offset: 0x0014B71C
		private IEnterMovieCameraType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEnterMovieCameraType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEnterMovieCameraType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEnterMovieCameraType_SetValue());
			}
			return result;
		}

		// Token: 0x06008E86 RID: 36486 RVA: 0x0014D554 File Offset: 0x0014B754
		public static IEnterMovieCameraType Create([Nullable(2)] IEnterMovieCameraType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnterMovieCameraType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008E87 RID: 36487 RVA: 0x0014D567 File Offset: 0x0014B767
		public static IEnterMovieCameraType CreateFromSetValue([Nullable(2)] IEnterMovieCameraType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEnterMovieCameraType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008E88 RID: 36488 RVA: 0x0014D57A File Offset: 0x0014B77A
		public IEnterMovieCameraType_SetValue ToSetValue()
		{
			return new IEnterMovieCameraType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002D9D RID: 11677
		// (get) Token: 0x06008E89 RID: 36489 RVA: 0x0014D58D File Offset: 0x0014B78D
		// (set) Token: 0x06008E8A RID: 36490 RVA: 0x0014D5B8 File Offset: 0x0014B7B8
		public virtual EMovieCameraType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMovieCameraType.Common;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005854 RID: 22612
		[Nullable(2)]
		protected IEnterMovieCameraType FbInstance;

		// Token: 0x04005855 RID: 22613
		[Nullable(2)]
		protected IEnterMovieCameraType_SetValue PocoInterface;
	}
}
