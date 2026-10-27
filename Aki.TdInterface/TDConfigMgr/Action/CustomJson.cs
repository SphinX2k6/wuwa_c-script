using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001553 RID: 5459
	[NullableContext(1)]
	[Nullable(0)]
	public class CustomJson : ActionParams
	{
		// Token: 0x06007B6D RID: 31597 RVA: 0x00129780 File Offset: 0x00127980
		private CustomJson_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("CustomJson 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			CustomJson_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new CustomJson_SetValue());
			}
			return result;
		}

		// Token: 0x06007B6E RID: 31598 RVA: 0x001297B8 File Offset: 0x001279B8
		public static CustomJson Create([Nullable(2)] CustomJson instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new CustomJson
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007B6F RID: 31599 RVA: 0x001297CB File Offset: 0x001279CB
		public static CustomJson CreateFromSetValue([Nullable(2)] CustomJson_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new CustomJson
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007B70 RID: 31600 RVA: 0x001297DE File Offset: 0x001279DE
		public CustomJson_SetValue ToSetValue()
		{
			return new CustomJson_SetValue
			{
				Name = this.Name,
				JsonString = this.JsonString
			};
		}

		// Token: 0x170028F2 RID: 10482
		// (get) Token: 0x06007B71 RID: 31601 RVA: 0x001297FD File Offset: 0x001279FD
		// (set) Token: 0x06007B72 RID: 31602 RVA: 0x00129828 File Offset: 0x00127A28
		public virtual string Name
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Name;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Name;
			}
			set
			{
				this.GetOrCreatePoco().Name = value;
			}
		}

		// Token: 0x170028F3 RID: 10483
		// (get) Token: 0x06007B73 RID: 31603 RVA: 0x00129836 File Offset: 0x00127A36
		// (set) Token: 0x06007B74 RID: 31604 RVA: 0x00129861 File Offset: 0x00127A61
		public virtual string JsonString
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.JsonString;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.JsonString;
			}
			set
			{
				this.GetOrCreatePoco().JsonString = value;
			}
		}

		// Token: 0x04004719 RID: 18201
		[Nullable(2)]
		protected new CustomJson FbInstance;

		// Token: 0x0400471A RID: 18202
		[Nullable(2)]
		protected CustomJson_SetValue PocoInterface;
	}
}
