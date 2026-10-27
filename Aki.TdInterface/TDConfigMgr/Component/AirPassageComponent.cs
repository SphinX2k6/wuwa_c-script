using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200001D RID: 29
	[NullableContext(1)]
	[Nullable(0)]
	public class AirPassageComponent : IComponentBase
	{
		// Token: 0x06000096 RID: 150 RVA: 0x00014EC8 File Offset: 0x000130C8
		private AirPassageComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("AirPassageComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			AirPassageComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new AirPassageComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00014F00 File Offset: 0x00013100
		public static AirPassageComponent Create([Nullable(2)] AirPassageComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new AirPassageComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00014F13 File Offset: 0x00013113
		public static AirPassageComponent CreateFromSetValue([Nullable(2)] AirPassageComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new AirPassageComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00014F26 File Offset: 0x00013126
		public new AirPassageComponent_SetValue ToSetValue()
		{
			return new AirPassageComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked
			};
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600009A RID: 154 RVA: 0x00014F48 File Offset: 0x00013148
		// (set) Token: 0x0600009B RID: 155 RVA: 0x00014F82 File Offset: 0x00013182
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				AirPassageComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00014F90 File Offset: 0x00013190
		// (set) Token: 0x0600009D RID: 157 RVA: 0x00014FBA File Offset: 0x000131BA
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x04000063 RID: 99
		[Nullable(2)]
		protected new AirPassageComponent FbInstance;

		// Token: 0x04000064 RID: 100
		[Nullable(2)]
		protected new AirPassageComponent_SetValue PocoInterface;
	}
}
