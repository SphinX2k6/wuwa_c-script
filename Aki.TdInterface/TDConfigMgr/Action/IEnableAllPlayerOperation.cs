using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B6D RID: 7021
	[JsonConverter(typeof(IEnableAllPlayerOperationConverter))]
	public class IEnableAllPlayerOperation : SetPlayerOperationRestriction
	{
		// Token: 0x0600951F RID: 38175 RVA: 0x0015BCF4 File Offset: 0x00159EF4
		private IEnableAllPlayerOperation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEnableAllPlayerOperation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEnableAllPlayerOperation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEnableAllPlayerOperation_SetValue());
			}
			return result;
		}

		// Token: 0x06009520 RID: 38176 RVA: 0x0015BD2C File Offset: 0x00159F2C
		public static IEnableAllPlayerOperation Create([Nullable(2)] IEnableAllPlayerOperation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnableAllPlayerOperation
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009521 RID: 38177 RVA: 0x0015BD3F File Offset: 0x00159F3F
		public static IEnableAllPlayerOperation CreateFromSetValue([Nullable(2)] IEnableAllPlayerOperation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEnableAllPlayerOperation
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009522 RID: 38178 RVA: 0x0015BD52 File Offset: 0x00159F52
		public new IEnableAllPlayerOperation_SetValue ToSetValue()
		{
			return new IEnableAllPlayerOperation_SetValue
			{
				Type = this.Type,
				IsUiFadeEffect = this.IsUiFadeEffect
			};
		}

		// Token: 0x17002F78 RID: 12152
		// (get) Token: 0x06009523 RID: 38179 RVA: 0x0015BD71 File Offset: 0x00159F71
		// (set) Token: 0x06009524 RID: 38180 RVA: 0x0015BD9C File Offset: 0x00159F9C
		public override EPlayerOperationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPlayerOperationType.EnableAll;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002F79 RID: 12153
		// (get) Token: 0x06009525 RID: 38181 RVA: 0x0015BDAC File Offset: 0x00159FAC
		// (set) Token: 0x06009526 RID: 38182 RVA: 0x0015BDE6 File Offset: 0x00159FE6
		public virtual bool? IsUiFadeEffect
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsUiFadeEffect;
				}
				IEnableAllPlayerOperation_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsUiFadeEffect;
			}
			set
			{
				this.GetOrCreatePoco().IsUiFadeEffect = value;
			}
		}

		// Token: 0x04005C63 RID: 23651
		[Nullable(2)]
		protected new IEnableAllPlayerOperation FbInstance;

		// Token: 0x04005C64 RID: 23652
		[Nullable(2)]
		protected new IEnableAllPlayerOperation_SetValue PocoInterface;
	}
}
