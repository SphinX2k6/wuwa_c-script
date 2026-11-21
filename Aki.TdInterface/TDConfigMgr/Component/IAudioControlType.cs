using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001FA RID: 506
	public class IAudioControlType
	{
		// Token: 0x060007EA RID: 2026 RVA: 0x00026730 File Offset: 0x00024930
		private IAudioControlType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAudioControlType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAudioControlType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAudioControlType_SetValue());
			}
			return result;
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x00026768 File Offset: 0x00024968
		public static IAudioControlType Create([Nullable(2)] IAudioControlType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAudioControlType
			{
				FbInstance = instance
			};
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x0002677B File Offset: 0x0002497B
		public static IAudioControlType CreateFromSetValue([Nullable(2)] IAudioControlType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAudioControlType
			{
				PocoInterface = value
			};
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x0002678E File Offset: 0x0002498E
		public IAudioControlType_SetValue ToSetValue()
		{
			return new IAudioControlType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x060007EE RID: 2030 RVA: 0x000267A1 File Offset: 0x000249A1
		// (set) Token: 0x060007EF RID: 2031 RVA: 0x000267CC File Offset: 0x000249CC
		public virtual EAudioControlType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EAudioControlType.Gramophone;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400092E RID: 2350
		[Nullable(2)]
		protected IAudioControlType FbInstance;

		// Token: 0x0400092F RID: 2351
		[Nullable(2)]
		protected IAudioControlType_SetValue PocoInterface;
	}
}
