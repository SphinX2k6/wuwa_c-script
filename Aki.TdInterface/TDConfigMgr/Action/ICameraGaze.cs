using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200183E RID: 6206
	[NullableContext(1)]
	[Nullable(0)]
	public class ICameraGaze
	{
		// Token: 0x0600852B RID: 34091 RVA: 0x0013CD14 File Offset: 0x0013AF14
		private ICameraGaze_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICameraGaze 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICameraGaze_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICameraGaze_SetValue());
			}
			return result;
		}

		// Token: 0x0600852C RID: 34092 RVA: 0x0013CD4C File Offset: 0x0013AF4C
		public static ICameraGaze Create([Nullable(2)] ICameraGaze instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICameraGaze
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600852D RID: 34093 RVA: 0x0013CD5F File Offset: 0x0013AF5F
		public static ICameraGaze CreateFromSetValue([Nullable(2)] ICameraGaze_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICameraGaze
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600852E RID: 34094 RVA: 0x0013CD74 File Offset: 0x0013AF74
		public ICameraGaze_SetValue ToSetValue()
		{
			return new ICameraGaze_SetValue
			{
				FadeInTime = this.FadeInTime,
				StayTime = this.StayTime,
				FadeOutTime = this.FadeOutTime,
				LockCamera = this.LockCamera,
				LockPriority = this.LockPriority,
				GazeInHook = this.GazeInHook
			};
		}

		// Token: 0x17002B8D RID: 11149
		// (get) Token: 0x0600852F RID: 34095 RVA: 0x0013CDCE File Offset: 0x0013AFCE
		// (set) Token: 0x06008530 RID: 34096 RVA: 0x0013CDFD File Offset: 0x0013AFFD
		public virtual float FadeInTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FadeInTime;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.FadeInTime;
			}
			set
			{
				this.GetOrCreatePoco().FadeInTime = value;
			}
		}

		// Token: 0x17002B8E RID: 11150
		// (get) Token: 0x06008531 RID: 34097 RVA: 0x0013CE0B File Offset: 0x0013B00B
		// (set) Token: 0x06008532 RID: 34098 RVA: 0x0013CE3A File Offset: 0x0013B03A
		public virtual float StayTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StayTime;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.StayTime;
			}
			set
			{
				this.GetOrCreatePoco().StayTime = value;
			}
		}

		// Token: 0x17002B8F RID: 11151
		// (get) Token: 0x06008533 RID: 34099 RVA: 0x0013CE48 File Offset: 0x0013B048
		// (set) Token: 0x06008534 RID: 34100 RVA: 0x0013CE82 File Offset: 0x0013B082
		public virtual float? FadeOutTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FadeOutTime;
				}
				ICameraGaze_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FadeOutTime;
			}
			set
			{
				this.GetOrCreatePoco().FadeOutTime = value;
			}
		}

		// Token: 0x17002B90 RID: 11152
		// (get) Token: 0x06008535 RID: 34101 RVA: 0x0013CE90 File Offset: 0x0013B090
		// (set) Token: 0x06008536 RID: 34102 RVA: 0x0013CECA File Offset: 0x0013B0CA
		public virtual bool? LockCamera
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LockCamera;
				}
				ICameraGaze_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.LockCamera;
			}
			set
			{
				this.GetOrCreatePoco().LockCamera = value;
			}
		}

		// Token: 0x17002B91 RID: 11153
		// (get) Token: 0x06008537 RID: 34103 RVA: 0x0013CED8 File Offset: 0x0013B0D8
		// (set) Token: 0x06008538 RID: 34104 RVA: 0x0013CF03 File Offset: 0x0013B103
		public virtual int LockPriority
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LockPriority;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.LockPriority;
			}
			set
			{
				this.GetOrCreatePoco().LockPriority = value;
			}
		}

		// Token: 0x17002B92 RID: 11154
		// (get) Token: 0x06008539 RID: 34105 RVA: 0x0013CF14 File Offset: 0x0013B114
		// (set) Token: 0x0600853A RID: 34106 RVA: 0x0013CF4E File Offset: 0x0013B14E
		public virtual bool? GazeInHook
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GazeInHook;
				}
				ICameraGaze_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.GazeInHook;
			}
			set
			{
				this.GetOrCreatePoco().GazeInHook = value;
			}
		}

		// Token: 0x04005426 RID: 21542
		[Nullable(2)]
		protected ICameraGaze FbInstance;

		// Token: 0x04005427 RID: 21543
		[Nullable(2)]
		protected ICameraGaze_SetValue PocoInterface;
	}
}
