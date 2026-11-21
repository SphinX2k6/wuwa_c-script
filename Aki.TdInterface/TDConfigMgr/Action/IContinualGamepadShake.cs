using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001ABB RID: 6843
	public class IContinualGamepadShake : IGamepadShakeConfig
	{
		// Token: 0x06009175 RID: 37237 RVA: 0x00155740 File Offset: 0x00153940
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

		// Token: 0x06009176 RID: 37238 RVA: 0x00155778 File Offset: 0x00153978
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

		// Token: 0x06009177 RID: 37239 RVA: 0x0015578B File Offset: 0x0015398B
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

		// Token: 0x06009178 RID: 37240 RVA: 0x001557A0 File Offset: 0x001539A0
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

		// Token: 0x17002EAE RID: 11950
		// (get) Token: 0x06009179 RID: 37241 RVA: 0x001557EE File Offset: 0x001539EE
		// (set) Token: 0x0600917A RID: 37242 RVA: 0x00155819 File Offset: 0x00153A19
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

		// Token: 0x17002EAF RID: 11951
		// (get) Token: 0x0600917B RID: 37243 RVA: 0x00155828 File Offset: 0x00153A28
		// (set) Token: 0x0600917C RID: 37244 RVA: 0x00155862 File Offset: 0x00153A62
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

		// Token: 0x17002EB0 RID: 11952
		// (get) Token: 0x0600917D RID: 37245 RVA: 0x00155870 File Offset: 0x00153A70
		// (set) Token: 0x0600917E RID: 37246 RVA: 0x0015589F File Offset: 0x00153A9F
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

		// Token: 0x17002EB1 RID: 11953
		// (get) Token: 0x0600917F RID: 37247 RVA: 0x001558AD File Offset: 0x00153AAD
		// (set) Token: 0x06009180 RID: 37248 RVA: 0x001558D8 File Offset: 0x00153AD8
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

		// Token: 0x17002EB2 RID: 11954
		// (get) Token: 0x06009181 RID: 37249 RVA: 0x001558E6 File Offset: 0x00153AE6
		// (set) Token: 0x06009182 RID: 37250 RVA: 0x0015590D File Offset: 0x00153B0D
		[Nullable(2)]
		public virtual string GamepadShakeTag
		{
			[NullableContext(2)]
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
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().GamepadShakeTag = value;
			}
		}

		// Token: 0x04005ACB RID: 23243
		[Nullable(2)]
		protected new IContinualGamepadShake FbInstance;

		// Token: 0x04005ACC RID: 23244
		[Nullable(2)]
		protected new IContinualGamepadShake_SetValue PocoInterface;
	}
}
