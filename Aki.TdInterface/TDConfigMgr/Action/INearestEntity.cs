using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C56 RID: 7254
	[NullableContext(1)]
	[Nullable(0)]
	public class INearestEntity : ITeleportConfig
	{
		// Token: 0x06009B97 RID: 39831 RVA: 0x001654B8 File Offset: 0x001636B8
		private INearestEntity_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INearestEntity 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INearestEntity_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INearestEntity_SetValue());
			}
			return result;
		}

		// Token: 0x06009B98 RID: 39832 RVA: 0x001654F0 File Offset: 0x001636F0
		public static INearestEntity Create([Nullable(2)] INearestEntity instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INearestEntity
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009B99 RID: 39833 RVA: 0x00165503 File Offset: 0x00163703
		public static INearestEntity CreateFromSetValue([Nullable(2)] INearestEntity_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INearestEntity
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009B9A RID: 39834 RVA: 0x00165516 File Offset: 0x00163716
		public new INearestEntity_SetValue ToSetValue()
		{
			return new INearestEntity_SetValue
			{
				Type = this.Type,
				EntityIds = this.EntityIds
			};
		}

		// Token: 0x170030A1 RID: 12449
		// (get) Token: 0x06009B9B RID: 39835 RVA: 0x00165535 File Offset: 0x00163735
		// (set) Token: 0x06009B9C RID: 39836 RVA: 0x00165560 File Offset: 0x00163760
		public override ETeleportType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETeleportType.FixedPos;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170030A2 RID: 12450
		// (get) Token: 0x06009B9D RID: 39837 RVA: 0x0016556E File Offset: 0x0016376E
		// (set) Token: 0x06009B9E RID: 39838 RVA: 0x00165595 File Offset: 0x00163795
		public virtual List<int> EntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityIds;
				}
				INearestEntity_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EntityIds;
			}
			set
			{
				this.GetOrCreatePoco().EntityIds = value;
			}
		}

		// Token: 0x04005E7A RID: 24186
		[Nullable(2)]
		protected new INearestEntity FbInstance;

		// Token: 0x04005E7B RID: 24187
		[Nullable(2)]
		protected new INearestEntity_SetValue PocoInterface;
	}
}
