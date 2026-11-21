using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B95 RID: 7061
	public class IEnterOrbitalCameraType
	{
		// Token: 0x06009609 RID: 38409 RVA: 0x0015D72C File Offset: 0x0015B92C
		private IEnterOrbitalCameraType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEnterOrbitalCameraType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEnterOrbitalCameraType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEnterOrbitalCameraType_SetValue());
			}
			return result;
		}

		// Token: 0x0600960A RID: 38410 RVA: 0x0015D764 File Offset: 0x0015B964
		public static IEnterOrbitalCameraType Create([Nullable(2)] IEnterOrbitalCameraType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnterOrbitalCameraType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600960B RID: 38411 RVA: 0x0015D777 File Offset: 0x0015B977
		public static IEnterOrbitalCameraType CreateFromSetValue([Nullable(2)] IEnterOrbitalCameraType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEnterOrbitalCameraType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600960C RID: 38412 RVA: 0x0015D78A File Offset: 0x0015B98A
		public IEnterOrbitalCameraType_SetValue ToSetValue()
		{
			return new IEnterOrbitalCameraType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002FB1 RID: 12209
		// (get) Token: 0x0600960D RID: 38413 RVA: 0x0015D79D File Offset: 0x0015B99D
		// (set) Token: 0x0600960E RID: 38414 RVA: 0x0015D7C8 File Offset: 0x0015B9C8
		public virtual EEnterOrbitalCameraType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EEnterOrbitalCameraType.ControlByMove;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005CC4 RID: 23748
		[Nullable(2)]
		protected IEnterOrbitalCameraType FbInstance;

		// Token: 0x04005CC5 RID: 23749
		[Nullable(2)]
		protected IEnterOrbitalCameraType_SetValue PocoInterface;
	}
}
