using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001FD RID: 509
	[NullableContext(1)]
	[Nullable(0)]
	public class IBoxAkEvent : IAkEventTypeConfig
	{
		// Token: 0x06000866 RID: 2150 RVA: 0x00026BFC File Offset: 0x00024DFC
		private IBoxAkEvent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBoxAkEvent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBoxAkEvent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBoxAkEvent_SetValue());
			}
			return result;
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x00026C34 File Offset: 0x00024E34
		public static IBoxAkEvent Create([Nullable(2)] IBoxAkEvent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBoxAkEvent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x00026C47 File Offset: 0x00024E47
		public static IBoxAkEvent CreateFromSetValue([Nullable(2)] IBoxAkEvent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBoxAkEvent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x00026C5A File Offset: 0x00024E5A
		public new IBoxAkEvent_SetValue ToSetValue()
		{
			return new IBoxAkEvent_SetValue
			{
				Type = this.Type,
				AudioType = this.AudioType,
				Priority = this.Priority
			};
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x0600086A RID: 2154 RVA: 0x00026C85 File Offset: 0x00024E85
		// (set) Token: 0x0600086B RID: 2155 RVA: 0x00026CB0 File Offset: 0x00024EB0
		public override EAkEventType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EAkEventType.Point;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x0600086C RID: 2156 RVA: 0x00026CBE File Offset: 0x00024EBE
		// (set) Token: 0x0600086D RID: 2157 RVA: 0x00026CE9 File Offset: 0x00024EE9
		public virtual EAudioType AudioType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AudioType;
				}
				if (this.PocoInterface == null)
				{
					return EAudioType.AudioAMB;
				}
				return this.PocoInterface.AudioType;
			}
			set
			{
				this.GetOrCreatePoco().AudioType = value;
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x0600086E RID: 2158 RVA: 0x00026CF7 File Offset: 0x00024EF7
		// (set) Token: 0x0600086F RID: 2159 RVA: 0x00026D22 File Offset: 0x00024F22
		public virtual int Priority
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Priority;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Priority;
			}
			set
			{
				this.GetOrCreatePoco().Priority = value;
			}
		}

		// Token: 0x0400091F RID: 2335
		[Nullable(2)]
		protected new IBoxAkEvent FbInstance;

		// Token: 0x04000920 RID: 2336
		[Nullable(2)]
		protected new IBoxAkEvent_SetValue PocoInterface;
	}
}
