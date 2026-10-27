using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000713 RID: 1811
	[NullableContext(1)]
	[Nullable(0)]
	public class IStateRepPerfEffects : IStateRepPerfBase
	{
		// Token: 0x060026F3 RID: 9971 RVA: 0x00067DC8 File Offset: 0x00065FC8
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

		// Token: 0x060026F4 RID: 9972 RVA: 0x00067E00 File Offset: 0x00066000
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

		// Token: 0x060026F5 RID: 9973 RVA: 0x00067E13 File Offset: 0x00066013
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

		// Token: 0x060026F6 RID: 9974 RVA: 0x00067E26 File Offset: 0x00066026
		public new IStateRepPerfEffects_SetValue ToSetValue()
		{
			return new IStateRepPerfEffects_SetValue
			{
				Type = this.Type,
				GamePlayCues = this.GamePlayCues
			};
		}

		// Token: 0x17000A3D RID: 2621
		// (get) Token: 0x060026F7 RID: 9975 RVA: 0x00067E45 File Offset: 0x00066045
		// (set) Token: 0x060026F8 RID: 9976 RVA: 0x00067E70 File Offset: 0x00066070
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

		// Token: 0x17000A3E RID: 2622
		// (get) Token: 0x060026F9 RID: 9977 RVA: 0x00067E7E File Offset: 0x0006607E
		// (set) Token: 0x060026FA RID: 9978 RVA: 0x00067EA5 File Offset: 0x000660A5
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

		// Token: 0x04001A53 RID: 6739
		[Nullable(2)]
		protected new IStateRepPerfEffects FbInstance;

		// Token: 0x04001A54 RID: 6740
		[Nullable(2)]
		protected new IStateRepPerfEffects_SetValue PocoInterface;
	}
}
