using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E5E RID: 7774
	[NullableContext(1)]
	[Nullable(0)]
	public class IShowTalkCameraMotion
	{
		// Token: 0x0600A663 RID: 42595 RVA: 0x00178864 File Offset: 0x00176A64
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

		// Token: 0x0600A664 RID: 42596 RVA: 0x0017889C File Offset: 0x00176A9C
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

		// Token: 0x0600A665 RID: 42597 RVA: 0x001788AF File Offset: 0x00176AAF
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

		// Token: 0x0600A666 RID: 42598 RVA: 0x001788C2 File Offset: 0x00176AC2
		public IShowTalkCameraMotion_SetValue ToSetValue()
		{
			return new IShowTalkCameraMotion_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170032FB RID: 13051
		// (get) Token: 0x0600A667 RID: 42599 RVA: 0x001788D5 File Offset: 0x00176AD5
		// (set) Token: 0x0600A668 RID: 42600 RVA: 0x00178900 File Offset: 0x00176B00
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

		// Token: 0x04006360 RID: 25440
		[Nullable(2)]
		protected IShowTalkCameraMotion FbInstance;

		// Token: 0x04006361 RID: 25441
		[Nullable(2)]
		protected IShowTalkCameraMotion_SetValue PocoInterface;
	}
}
