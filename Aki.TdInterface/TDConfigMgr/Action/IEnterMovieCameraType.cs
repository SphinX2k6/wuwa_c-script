using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B8F RID: 7055
	public class IEnterMovieCameraType
	{
		// Token: 0x060095E7 RID: 38375 RVA: 0x0015D38C File Offset: 0x0015B58C
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

		// Token: 0x060095E8 RID: 38376 RVA: 0x0015D3C4 File Offset: 0x0015B5C4
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

		// Token: 0x060095E9 RID: 38377 RVA: 0x0015D3D7 File Offset: 0x0015B5D7
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

		// Token: 0x060095EA RID: 38378 RVA: 0x0015D3EA File Offset: 0x0015B5EA
		public IEnterMovieCameraType_SetValue ToSetValue()
		{
			return new IEnterMovieCameraType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002FA9 RID: 12201
		// (get) Token: 0x060095EB RID: 38379 RVA: 0x0015D3FD File Offset: 0x0015B5FD
		// (set) Token: 0x060095EC RID: 38380 RVA: 0x0015D428 File Offset: 0x0015B628
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

		// Token: 0x04005CB6 RID: 23734
		[Nullable(2)]
		protected IEnterMovieCameraType FbInstance;

		// Token: 0x04005CB7 RID: 23735
		[Nullable(2)]
		protected IEnterMovieCameraType_SetValue PocoInterface;
	}
}
