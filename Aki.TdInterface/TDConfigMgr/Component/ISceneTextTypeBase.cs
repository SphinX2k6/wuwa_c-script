using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000757 RID: 1879
	public class ISceneTextTypeBase
	{
		// Token: 0x06002806 RID: 10246 RVA: 0x0006AB7C File Offset: 0x00068D7C
		private ISceneTextTypeBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISceneTextTypeBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISceneTextTypeBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISceneTextTypeBase_SetValue());
			}
			return result;
		}

		// Token: 0x06002807 RID: 10247 RVA: 0x0006ABB4 File Offset: 0x00068DB4
		public static ISceneTextTypeBase Create([Nullable(2)] ISceneTextTypeBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneTextTypeBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002808 RID: 10248 RVA: 0x0006ABC7 File Offset: 0x00068DC7
		public static ISceneTextTypeBase CreateFromSetValue([Nullable(2)] ISceneTextTypeBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISceneTextTypeBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002809 RID: 10249 RVA: 0x0006ABDA File Offset: 0x00068DDA
		public ISceneTextTypeBase_SetValue ToSetValue()
		{
			return new ISceneTextTypeBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000A7F RID: 2687
		// (get) Token: 0x0600280A RID: 10250 RVA: 0x0006ABED File Offset: 0x00068DED
		// (set) Token: 0x0600280B RID: 10251 RVA: 0x0006AC18 File Offset: 0x00068E18
		public virtual ESceneTextType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESceneTextType.SubtitleWithVoice;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001B44 RID: 6980
		[Nullable(2)]
		protected ISceneTextTypeBase FbInstance;

		// Token: 0x04001B45 RID: 6981
		[Nullable(2)]
		protected ISceneTextTypeBase_SetValue PocoInterface;
	}
}
