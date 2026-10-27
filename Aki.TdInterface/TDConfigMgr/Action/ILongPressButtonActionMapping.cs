using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B9C RID: 7068
	[NullableContext(1)]
	[Nullable(0)]
	public class ILongPressButtonActionMapping
	{
		// Token: 0x06009751 RID: 38737 RVA: 0x0015D050 File Offset: 0x0015B250
		private ILongPressButtonActionMapping_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILongPressButtonActionMapping 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILongPressButtonActionMapping_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILongPressButtonActionMapping_SetValue());
			}
			return result;
		}

		// Token: 0x06009752 RID: 38738 RVA: 0x0015D088 File Offset: 0x0015B288
		public static ILongPressButtonActionMapping Create([Nullable(2)] ILongPressButtonActionMapping instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILongPressButtonActionMapping
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009753 RID: 38739 RVA: 0x0015D09B File Offset: 0x0015B29B
		public static ILongPressButtonActionMapping CreateFromSetValue([Nullable(2)] ILongPressButtonActionMapping_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILongPressButtonActionMapping
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009754 RID: 38740 RVA: 0x0015D0AE File Offset: 0x0015B2AE
		public ILongPressButtonActionMapping_SetValue ToSetValue()
		{
			return new ILongPressButtonActionMapping_SetValue
			{
				Id = this.Id,
				ActionName = this.ActionName
			};
		}

		// Token: 0x17002F95 RID: 12181
		// (get) Token: 0x06009755 RID: 38741 RVA: 0x0015D0CD File Offset: 0x0015B2CD
		// (set) Token: 0x06009756 RID: 38742 RVA: 0x0015D0F8 File Offset: 0x0015B2F8
		public virtual int Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x17002F96 RID: 12182
		// (get) Token: 0x06009757 RID: 38743 RVA: 0x0015D106 File Offset: 0x0015B306
		// (set) Token: 0x06009758 RID: 38744 RVA: 0x0015D131 File Offset: 0x0015B331
		public virtual string ActionName
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ActionName;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.ActionName;
			}
			set
			{
				this.GetOrCreatePoco().ActionName = value;
			}
		}

		// Token: 0x04005C5C RID: 23644
		[Nullable(2)]
		protected ILongPressButtonActionMapping FbInstance;

		// Token: 0x04005C5D RID: 23645
		[Nullable(2)]
		protected ILongPressButtonActionMapping_SetValue PocoInterface;
	}
}
