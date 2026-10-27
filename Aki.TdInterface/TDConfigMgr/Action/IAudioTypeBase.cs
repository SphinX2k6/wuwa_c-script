using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017EA RID: 6122
	[NullableContext(1)]
	[Nullable(0)]
	public class IAudioTypeBase
	{
		// Token: 0x0600837D RID: 33661 RVA: 0x00139EF4 File Offset: 0x001380F4
		private IAudioTypeBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAudioTypeBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAudioTypeBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAudioTypeBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600837E RID: 33662 RVA: 0x00139F2C File Offset: 0x0013812C
		public static IAudioTypeBase Create([Nullable(2)] IAudioTypeBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAudioTypeBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600837F RID: 33663 RVA: 0x00139F3F File Offset: 0x0013813F
		public static IAudioTypeBase CreateFromSetValue([Nullable(2)] IAudioTypeBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAudioTypeBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008380 RID: 33664 RVA: 0x00139F52 File Offset: 0x00138152
		public IAudioTypeBase_SetValue ToSetValue()
		{
			return new IAudioTypeBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002B34 RID: 11060
		// (get) Token: 0x06008381 RID: 33665 RVA: 0x00139F65 File Offset: 0x00138165
		// (set) Token: 0x06008382 RID: 33666 RVA: 0x00139F90 File Offset: 0x00138190
		public virtual EAudioType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EAudioType.RoleSceneVoice;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400536D RID: 21357
		[Nullable(2)]
		protected IAudioTypeBase FbInstance;

		// Token: 0x0400536E RID: 21358
		[Nullable(2)]
		protected IAudioTypeBase_SetValue PocoInterface;
	}
}
