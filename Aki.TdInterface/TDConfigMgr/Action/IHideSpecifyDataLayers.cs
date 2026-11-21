using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CB2 RID: 7346
	public class IHideSpecifyDataLayers : IHideGroupType
	{
		// Token: 0x06009BFC RID: 39932 RVA: 0x00167F30 File Offset: 0x00166130
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

		// Token: 0x06009BFD RID: 39933 RVA: 0x00167F68 File Offset: 0x00166168
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

		// Token: 0x06009BFE RID: 39934 RVA: 0x00167F7B File Offset: 0x0016617B
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

		// Token: 0x06009BFF RID: 39935 RVA: 0x00167F8E File Offset: 0x0016618E
		public new IHideSpecifyDataLayers_SetValue ToSetValue()
		{
			return new IHideSpecifyDataLayers_SetValue
			{
				Type = this.Type,
				DataLayers = this.DataLayers
			};
		}

		// Token: 0x17003100 RID: 12544
		// (get) Token: 0x06009C00 RID: 39936 RVA: 0x00167FAD File Offset: 0x001661AD
		// (set) Token: 0x06009C01 RID: 39937 RVA: 0x00167FD8 File Offset: 0x001661D8
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

		// Token: 0x17003101 RID: 12545
		// (get) Token: 0x06009C02 RID: 39938 RVA: 0x00167FE6 File Offset: 0x001661E6
		// (set) Token: 0x06009C03 RID: 39939 RVA: 0x0016800D File Offset: 0x0016620D
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

		// Token: 0x04005F79 RID: 24441
		[Nullable(2)]
		protected new IHideSpecifyDataLayers FbInstance;

		// Token: 0x04005F7A RID: 24442
		[Nullable(2)]
		protected new IHideSpecifyDataLayers_SetValue PocoInterface;
	}
}
