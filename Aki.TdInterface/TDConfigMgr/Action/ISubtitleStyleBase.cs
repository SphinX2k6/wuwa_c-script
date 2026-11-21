using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200211E RID: 8478
	public class ISubtitleStyleBase
	{
		// Token: 0x0600B408 RID: 46088 RVA: 0x00193B04 File Offset: 0x00191D04
		private ISubtitleStyleBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISubtitleStyleBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISubtitleStyleBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISubtitleStyleBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600B409 RID: 46089 RVA: 0x00193B3C File Offset: 0x00191D3C
		public static ISubtitleStyleBase Create([Nullable(2)] ISubtitleStyleBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISubtitleStyleBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B40A RID: 46090 RVA: 0x00193B4F File Offset: 0x00191D4F
		public static ISubtitleStyleBase CreateFromSetValue([Nullable(2)] ISubtitleStyleBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISubtitleStyleBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B40B RID: 46091 RVA: 0x00193B62 File Offset: 0x00191D62
		public ISubtitleStyleBase_SetValue ToSetValue()
		{
			return new ISubtitleStyleBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003666 RID: 13926
		// (get) Token: 0x0600B40C RID: 46092 RVA: 0x00193B75 File Offset: 0x00191D75
		// (set) Token: 0x0600B40D RID: 46093 RVA: 0x00193BA0 File Offset: 0x00191DA0
		public virtual ESubtitleStyle Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESubtitleStyle.LevelA;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006AA5 RID: 27301
		[Nullable(2)]
		protected ISubtitleStyleBase FbInstance;

		// Token: 0x04006AA6 RID: 27302
		[Nullable(2)]
		protected ISubtitleStyleBase_SetValue PocoInterface;
	}
}
