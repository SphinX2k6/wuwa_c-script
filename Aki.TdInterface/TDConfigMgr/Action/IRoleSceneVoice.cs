using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DCC RID: 7628
	[NullableContext(1)]
	[Nullable(0)]
	public class IRoleSceneVoice : IAudioTypeBase
	{
		// Token: 0x0600A35B RID: 41819 RVA: 0x00172FB8 File Offset: 0x001711B8
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

		// Token: 0x0600A35C RID: 41820 RVA: 0x00172FF0 File Offset: 0x001711F0
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

		// Token: 0x0600A35D RID: 41821 RVA: 0x00173003 File Offset: 0x00171203
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

		// Token: 0x0600A35E RID: 41822 RVA: 0x00173016 File Offset: 0x00171216
		public new IRoleSceneVoice_SetValue ToSetValue()
		{
			return new IRoleSceneVoice_SetValue
			{
				Type = this.Type,
				VoiceGroupData = this.VoiceGroupData
			};
		}

		// Token: 0x17003252 RID: 12882
		// (get) Token: 0x0600A35F RID: 41823 RVA: 0x00173035 File Offset: 0x00171235
		// (set) Token: 0x0600A360 RID: 41824 RVA: 0x00173060 File Offset: 0x00171260
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

		// Token: 0x17003253 RID: 12883
		// (get) Token: 0x0600A361 RID: 41825 RVA: 0x0017306E File Offset: 0x0017126E
		// (set) Token: 0x0600A362 RID: 41826 RVA: 0x00173099 File Offset: 0x00171299
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

		// Token: 0x040061F5 RID: 25077
		[Nullable(2)]
		protected new IRoleSceneVoice FbInstance;

		// Token: 0x040061F6 RID: 25078
		[Nullable(2)]
		protected new IRoleSceneVoice_SetValue PocoInterface;
	}
}
