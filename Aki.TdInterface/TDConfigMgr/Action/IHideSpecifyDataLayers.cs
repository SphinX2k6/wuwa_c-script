using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B03 RID: 6915
	[NullableContext(1)]
	[Nullable(0)]
	public class IHideSpecifyDataLayers : IHideGroupType
	{
		// Token: 0x06009412 RID: 37906 RVA: 0x00157254 File Offset: 0x00155454
		private IHideSpecifyDataLayers_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHideSpecifyDataLayers 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHideSpecifyDataLayers_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHideSpecifyDataLayers_SetValue());
			}
			return result;
		}

		// Token: 0x06009413 RID: 37907 RVA: 0x0015728C File Offset: 0x0015548C
		public static IHideSpecifyDataLayers Create([Nullable(2)] IHideSpecifyDataLayers instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHideSpecifyDataLayers
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009414 RID: 37908 RVA: 0x0015729F File Offset: 0x0015549F
		public static IHideSpecifyDataLayers CreateFromSetValue([Nullable(2)] IHideSpecifyDataLayers_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHideSpecifyDataLayers
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009415 RID: 37909 RVA: 0x001572B2 File Offset: 0x001554B2
		public new IHideSpecifyDataLayers_SetValue ToSetValue()
		{
			return new IHideSpecifyDataLayers_SetValue
			{
				Type = this.Type,
				DataLayers = this.DataLayers
			};
		}

		// Token: 0x17002EDA RID: 11994
		// (get) Token: 0x06009416 RID: 37910 RVA: 0x001572D1 File Offset: 0x001554D1
		// (set) Token: 0x06009417 RID: 37911 RVA: 0x001572FC File Offset: 0x001554FC
		public override EHideType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EHideType.WorldMonsterAndMonsterTreasure;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002EDB RID: 11995
		// (get) Token: 0x06009418 RID: 37912 RVA: 0x0015730A File Offset: 0x0015550A
		// (set) Token: 0x06009419 RID: 37913 RVA: 0x00157331 File Offset: 0x00155531
		public virtual List<int> DataLayers
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DataLayers;
				}
				IHideSpecifyDataLayers_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DataLayers;
			}
			set
			{
				this.GetOrCreatePoco().DataLayers = value;
			}
		}

		// Token: 0x04005ADB RID: 23259
		[Nullable(2)]
		protected new IHideSpecifyDataLayers FbInstance;

		// Token: 0x04005ADC RID: 23260
		[Nullable(2)]
		protected new IHideSpecifyDataLayers_SetValue PocoInterface;
	}
}
