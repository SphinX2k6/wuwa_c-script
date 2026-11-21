using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FE3 RID: 8163
	public class IRoleSceneVoice : IAudioTypeBase
	{
		// Token: 0x0600AD65 RID: 44389 RVA: 0x001876E0 File Offset: 0x001858E0
		private IRoleSceneVoice_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRoleSceneVoice 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRoleSceneVoice_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRoleSceneVoice_SetValue());
			}
			return result;
		}

		// Token: 0x0600AD66 RID: 44390 RVA: 0x00187718 File Offset: 0x00185918
		public static IRoleSceneVoice Create([Nullable(2)] IRoleSceneVoice instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRoleSceneVoice
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AD67 RID: 44391 RVA: 0x0018772B File Offset: 0x0018592B
		public static IRoleSceneVoice CreateFromSetValue([Nullable(2)] IRoleSceneVoice_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRoleSceneVoice
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AD68 RID: 44392 RVA: 0x0018773E File Offset: 0x0018593E
		public new IRoleSceneVoice_SetValue ToSetValue()
		{
			return new IRoleSceneVoice_SetValue
			{
				Type = this.Type,
				VoiceGroupData = this.VoiceGroupData
			};
		}

		// Token: 0x170034EC RID: 13548
		// (get) Token: 0x0600AD69 RID: 44393 RVA: 0x0018775D File Offset: 0x0018595D
		// (set) Token: 0x0600AD6A RID: 44394 RVA: 0x00187788 File Offset: 0x00185988
		public override EAudioType Type
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

		// Token: 0x170034ED RID: 13549
		// (get) Token: 0x0600AD6B RID: 44395 RVA: 0x00187796 File Offset: 0x00185996
		// (set) Token: 0x0600AD6C RID: 44396 RVA: 0x001877C1 File Offset: 0x001859C1
		public virtual int VoiceGroupData
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.VoiceGroupData;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.VoiceGroupData;
			}
			set
			{
				this.GetOrCreatePoco().VoiceGroupData = value;
			}
		}

		// Token: 0x0400677D RID: 26493
		[Nullable(2)]
		protected new IRoleSceneVoice FbInstance;

		// Token: 0x0400677E RID: 26494
		[Nullable(2)]
		protected new IRoleSceneVoice_SetValue PocoInterface;
	}
}
