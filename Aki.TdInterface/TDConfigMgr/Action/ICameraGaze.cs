using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019C9 RID: 6601
	public class ICameraGaze
	{
		// Token: 0x06008C51 RID: 35921 RVA: 0x0014C508 File Offset: 0x0014A708
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

		// Token: 0x06008C52 RID: 35922 RVA: 0x0014C540 File Offset: 0x0014A740
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

		// Token: 0x06008C53 RID: 35923 RVA: 0x0014C553 File Offset: 0x0014A753
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

		// Token: 0x06008C54 RID: 35924 RVA: 0x0014C568 File Offset: 0x0014A768
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

		// Token: 0x17002D87 RID: 11655
		// (get) Token: 0x06008C55 RID: 35925 RVA: 0x0014C5C2 File Offset: 0x0014A7C2
		// (set) Token: 0x06008C56 RID: 35926 RVA: 0x0014C5F1 File Offset: 0x0014A7F1
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

		// Token: 0x17002D88 RID: 11656
		// (get) Token: 0x06008C57 RID: 35927 RVA: 0x0014C5FF File Offset: 0x0014A7FF
		// (set) Token: 0x06008C58 RID: 35928 RVA: 0x0014C62E File Offset: 0x0014A82E
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

		// Token: 0x17002D89 RID: 11657
		// (get) Token: 0x06008C59 RID: 35929 RVA: 0x0014C63C File Offset: 0x0014A83C
		// (set) Token: 0x06008C5A RID: 35930 RVA: 0x0014C676 File Offset: 0x0014A876
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

		// Token: 0x17002D8A RID: 11658
		// (get) Token: 0x06008C5B RID: 35931 RVA: 0x0014C684 File Offset: 0x0014A884
		// (set) Token: 0x06008C5C RID: 35932 RVA: 0x0014C6BE File Offset: 0x0014A8BE
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

		// Token: 0x17002D8B RID: 11659
		// (get) Token: 0x06008C5D RID: 35933 RVA: 0x0014C6CC File Offset: 0x0014A8CC
		// (set) Token: 0x06008C5E RID: 35934 RVA: 0x0014C6F7 File Offset: 0x0014A8F7
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

		// Token: 0x17002D8C RID: 11660
		// (get) Token: 0x06008C5F RID: 35935 RVA: 0x0014C708 File Offset: 0x0014A908
		// (set) Token: 0x06008C60 RID: 35936 RVA: 0x0014C742 File Offset: 0x0014A942
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

		// Token: 0x04005872 RID: 22642
		[Nullable(2)]
		protected ICameraGaze FbInstance;

		// Token: 0x04005873 RID: 22643
		[Nullable(2)]
		protected ICameraGaze_SetValue PocoInterface;
	}
}
