using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001932 RID: 6450
	[NullableContext(2)]
	[Nullable(0)]
	public class IContinualGamepadShake : IGamepadShakeConfig
	{
		// Token: 0x06008A49 RID: 35401 RVA: 0x00145E00 File Offset: 0x00144000
		[NullableContext(1)]
		private IContinualGamepadShake_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IContinualGamepadShake 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IContinualGamepadShake_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IContinualGamepadShake_SetValue());
			}
			return result;
		}

		// Token: 0x06008A4A RID: 35402 RVA: 0x00145E38 File Offset: 0x00144038
		[NullableContext(1)]
		public static IContinualGamepadShake Create([Nullable(2)] IContinualGamepadShake instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IContinualGamepadShake
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008A4B RID: 35403 RVA: 0x00145E4B File Offset: 0x0014404B
		[NullableContext(1)]
		public static IContinualGamepadShake CreateFromSetValue([Nullable(2)] IContinualGamepadShake_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IContinualGamepadShake
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008A4C RID: 35404 RVA: 0x00145E60 File Offset: 0x00144060
		[NullableContext(1)]
		public new IContinualGamepadShake_SetValue ToSetValue()
		{
			return new IContinualGamepadShake_SetValue
			{
				Type = this.Type,
				IsIgnoreTimeDilation = this.IsIgnoreTimeDilation,
				Duration = this.Duration,
				IsLoop = this.IsLoop,
				GamepadShakeTag = this.GamepadShakeTag
			};
		}

		// Token: 0x17002CAE RID: 11438
		// (get) Token: 0x06008A4D RID: 35405 RVA: 0x00145EAE File Offset: 0x001440AE
		// (set) Token: 0x06008A4E RID: 35406 RVA: 0x00145ED9 File Offset: 0x001440D9
		public override EGamepadShakeType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EGamepadShakeType.Onetime;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002CAF RID: 11439
		// (get) Token: 0x06008A4F RID: 35407 RVA: 0x00145EE8 File Offset: 0x001440E8
		// (set) Token: 0x06008A50 RID: 35408 RVA: 0x00145F22 File Offset: 0x00144122
		public virtual bool? IsIgnoreTimeDilation
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsIgnoreTimeDilation;
				}
				IContinualGamepadShake_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsIgnoreTimeDilation;
			}
			set
			{
				this.GetOrCreatePoco().IsIgnoreTimeDilation = value;
			}
		}

		// Token: 0x17002CB0 RID: 11440
		// (get) Token: 0x06008A51 RID: 35409 RVA: 0x00145F30 File Offset: 0x00144130
		// (set) Token: 0x06008A52 RID: 35410 RVA: 0x00145F5F File Offset: 0x0014415F
		public virtual float Duration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Duration;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Duration;
			}
			set
			{
				this.GetOrCreatePoco().Duration = value;
			}
		}

		// Token: 0x17002CB1 RID: 11441
		// (get) Token: 0x06008A53 RID: 35411 RVA: 0x00145F6D File Offset: 0x0014416D
		// (set) Token: 0x06008A54 RID: 35412 RVA: 0x00145F98 File Offset: 0x00144198
		public virtual bool IsLoop
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsLoop;
				}
				return this.PocoInterface != null && this.PocoInterface.IsLoop;
			}
			set
			{
				this.GetOrCreatePoco().IsLoop = value;
			}
		}

		// Token: 0x17002CB2 RID: 11442
		// (get) Token: 0x06008A55 RID: 35413 RVA: 0x00145FA6 File Offset: 0x001441A6
		// (set) Token: 0x06008A56 RID: 35414 RVA: 0x00145FCD File Offset: 0x001441CD
		public virtual string GamepadShakeTag
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GamepadShakeTag;
				}
				IContinualGamepadShake_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.GamepadShakeTag;
			}
			set
			{
				this.GetOrCreatePoco().GamepadShakeTag = value;
			}
		}

		// Token: 0x0400567B RID: 22139
		protected new IContinualGamepadShake FbInstance;

		// Token: 0x0400567C RID: 22140
		protected new IContinualGamepadShake_SetValue PocoInterface;
	}
}
