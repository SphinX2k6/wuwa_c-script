using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001194 RID: 4500
	[NullableContext(1)]
	[Nullable(0)]
	public class ITetrisPlayModeEndless : ITetrisPlayModeBase
	{
		// Token: 0x0600662E RID: 26158 RVA: 0x000F5008 File Offset: 0x000F3208
		private ITetrisPlayModeEndless_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITetrisPlayModeEndless 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITetrisPlayModeEndless_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITetrisPlayModeEndless_SetValue());
			}
			return result;
		}

		// Token: 0x0600662F RID: 26159 RVA: 0x000F5040 File Offset: 0x000F3240
		public static ITetrisPlayModeEndless Create([Nullable(2)] ITetrisPlayModeEndless instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITetrisPlayModeEndless
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006630 RID: 26160 RVA: 0x000F5053 File Offset: 0x000F3253
		public static ITetrisPlayModeEndless CreateFromSetValue([Nullable(2)] ITetrisPlayModeEndless_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITetrisPlayModeEndless
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006631 RID: 26161 RVA: 0x000F5066 File Offset: 0x000F3266
		public new ITetrisPlayModeEndless_SetValue ToSetValue()
		{
			return new ITetrisPlayModeEndless_SetValue
			{
				Type = this.Type,
				SpeedLevel = this.SpeedLevel
			};
		}

		// Token: 0x1700213E RID: 8510
		// (get) Token: 0x06006632 RID: 26162 RVA: 0x000F5085 File Offset: 0x000F3285
		// (set) Token: 0x06006633 RID: 26163 RVA: 0x000F50B0 File Offset: 0x000F32B0
		public override ETetrisPlayMode Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETetrisPlayMode.Normal;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700213F RID: 8511
		// (get) Token: 0x06006634 RID: 26164 RVA: 0x000F50C0 File Offset: 0x000F32C0
		// (set) Token: 0x06006635 RID: 26165 RVA: 0x000F50FA File Offset: 0x000F32FA
		public virtual int? SpeedLevel
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SpeedLevel;
				}
				ITetrisPlayModeEndless_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SpeedLevel;
			}
			set
			{
				this.GetOrCreatePoco().SpeedLevel = value;
			}
		}

		// Token: 0x04003D55 RID: 15701
		[Nullable(2)]
		protected new ITetrisPlayModeEndless FbInstance;

		// Token: 0x04003D56 RID: 15702
		[Nullable(2)]
		protected new ITetrisPlayModeEndless_SetValue PocoInterface;
	}
}
