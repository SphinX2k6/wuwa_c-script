using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002093 RID: 8339
	public class IShowTalkCameraMotion
	{
		// Token: 0x0600B11B RID: 45339 RVA: 0x0018E564 File Offset: 0x0018C764
		private IShowTalkCameraMotion_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IShowTalkCameraMotion 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IShowTalkCameraMotion_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IShowTalkCameraMotion_SetValue());
			}
			return result;
		}

		// Token: 0x0600B11C RID: 45340 RVA: 0x0018E59C File Offset: 0x0018C79C
		public static IShowTalkCameraMotion Create([Nullable(2)] IShowTalkCameraMotion instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IShowTalkCameraMotion
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B11D RID: 45341 RVA: 0x0018E5AF File Offset: 0x0018C7AF
		public static IShowTalkCameraMotion CreateFromSetValue([Nullable(2)] IShowTalkCameraMotion_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IShowTalkCameraMotion
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B11E RID: 45342 RVA: 0x0018E5C2 File Offset: 0x0018C7C2
		public IShowTalkCameraMotion_SetValue ToSetValue()
		{
			return new IShowTalkCameraMotion_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170035BF RID: 13759
		// (get) Token: 0x0600B11F RID: 45343 RVA: 0x0018E5D5 File Offset: 0x0018C7D5
		// (set) Token: 0x0600B120 RID: 45344 RVA: 0x0018E600 File Offset: 0x0018C800
		public virtual EShowTalkCameraMotionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EShowTalkCameraMotionType.Preset;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006944 RID: 26948
		[Nullable(2)]
		protected IShowTalkCameraMotion FbInstance;

		// Token: 0x04006945 RID: 26949
		[Nullable(2)]
		protected IShowTalkCameraMotion_SetValue PocoInterface;
	}
}
