using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007B4 RID: 1972
	public class IStateRepPerfEffects : IStateRepPerfBase
	{
		// Token: 0x06002A13 RID: 10771 RVA: 0x0006EE38 File Offset: 0x0006D038
		private IStateRepPerfEffects_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IStateRepPerfEffects 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IStateRepPerfEffects_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IStateRepPerfEffects_SetValue());
			}
			return result;
		}

		// Token: 0x06002A14 RID: 10772 RVA: 0x0006EE70 File Offset: 0x0006D070
		public static IStateRepPerfEffects Create([Nullable(2)] IStateRepPerfEffects instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStateRepPerfEffects
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002A15 RID: 10773 RVA: 0x0006EE83 File Offset: 0x0006D083
		public static IStateRepPerfEffects CreateFromSetValue([Nullable(2)] IStateRepPerfEffects_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IStateRepPerfEffects
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002A16 RID: 10774 RVA: 0x0006EE96 File Offset: 0x0006D096
		public new IStateRepPerfEffects_SetValue ToSetValue()
		{
			return new IStateRepPerfEffects_SetValue
			{
				Type = this.Type,
				GamePlayCues = this.GamePlayCues
			};
		}

		// Token: 0x17000AFB RID: 2811
		// (get) Token: 0x06002A17 RID: 10775 RVA: 0x0006EEB5 File Offset: 0x0006D0B5
		// (set) Token: 0x06002A18 RID: 10776 RVA: 0x0006EEE0 File Offset: 0x0006D0E0
		public override EStateRepPerfType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EStateRepPerfType.SkillId;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000AFC RID: 2812
		// (get) Token: 0x06002A19 RID: 10777 RVA: 0x0006EEEE File Offset: 0x0006D0EE
		// (set) Token: 0x06002A1A RID: 10778 RVA: 0x0006EF15 File Offset: 0x0006D115
		public virtual List<int> GamePlayCues
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GamePlayCues;
				}
				IStateRepPerfEffects_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.GamePlayCues;
			}
			set
			{
				this.GetOrCreatePoco().GamePlayCues = value;
			}
		}

		// Token: 0x04001C52 RID: 7250
		[Nullable(2)]
		protected new IStateRepPerfEffects FbInstance;

		// Token: 0x04001C53 RID: 7251
		[Nullable(2)]
		protected new IStateRepPerfEffects_SetValue PocoInterface;
	}
}
