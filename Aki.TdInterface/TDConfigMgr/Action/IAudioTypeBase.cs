using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001973 RID: 6515
	public class IAudioTypeBase
	{
		// Token: 0x06008A99 RID: 35481 RVA: 0x001495DC File Offset: 0x001477DC
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

		// Token: 0x06008A9A RID: 35482 RVA: 0x00149614 File Offset: 0x00147814
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

		// Token: 0x06008A9B RID: 35483 RVA: 0x00149627 File Offset: 0x00147827
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

		// Token: 0x06008A9C RID: 35484 RVA: 0x0014963A File Offset: 0x0014783A
		public IAudioTypeBase_SetValue ToSetValue()
		{
			return new IAudioTypeBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002D2C RID: 11564
		// (get) Token: 0x06008A9D RID: 35485 RVA: 0x0014964D File Offset: 0x0014784D
		// (set) Token: 0x06008A9E RID: 35486 RVA: 0x00149678 File Offset: 0x00147878
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

		// Token: 0x040057B5 RID: 22453
		[Nullable(2)]
		protected IAudioTypeBase FbInstance;

		// Token: 0x040057B6 RID: 22454
		[Nullable(2)]
		protected IAudioTypeBase_SetValue PocoInterface;
	}
}
