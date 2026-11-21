using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B85 RID: 7045
	public class IEnableSubLevelTransitionType
	{
		// Token: 0x060095B1 RID: 38321 RVA: 0x0015CDD4 File Offset: 0x0015AFD4
		private IEnableSubLevelTransitionType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEnableSubLevelTransitionType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEnableSubLevelTransitionType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEnableSubLevelTransitionType_SetValue());
			}
			return result;
		}

		// Token: 0x060095B2 RID: 38322 RVA: 0x0015CE0C File Offset: 0x0015B00C
		public static IEnableSubLevelTransitionType Create([Nullable(2)] IEnableSubLevelTransitionType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnableSubLevelTransitionType
			{
				FbInstance = instance
			};
		}

		// Token: 0x060095B3 RID: 38323 RVA: 0x0015CE1F File Offset: 0x0015B01F
		public static IEnableSubLevelTransitionType CreateFromSetValue([Nullable(2)] IEnableSubLevelTransitionType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEnableSubLevelTransitionType
			{
				PocoInterface = value
			};
		}

		// Token: 0x060095B4 RID: 38324 RVA: 0x0015CE32 File Offset: 0x0015B032
		public IEnableSubLevelTransitionType_SetValue ToSetValue()
		{
			return new IEnableSubLevelTransitionType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002F9D RID: 12189
		// (get) Token: 0x060095B5 RID: 38325 RVA: 0x0015CE45 File Offset: 0x0015B045
		// (set) Token: 0x060095B6 RID: 38326 RVA: 0x0015CE70 File Offset: 0x0015B070
		public virtual EEnableSubLevelTransitionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EEnableSubLevelTransitionType.SceneCapture;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005CA0 RID: 23712
		[Nullable(2)]
		protected IEnableSubLevelTransitionType FbInstance;

		// Token: 0x04005CA1 RID: 23713
		[Nullable(2)]
		protected IEnableSubLevelTransitionType_SetValue PocoInterface;
	}
}
