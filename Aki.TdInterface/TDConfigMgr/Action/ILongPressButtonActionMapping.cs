using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D83 RID: 7555
	public class ILongPressButtonActionMapping
	{
		// Token: 0x0600A055 RID: 41045 RVA: 0x0016FB10 File Offset: 0x0016DD10
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

		// Token: 0x0600A056 RID: 41046 RVA: 0x0016FB48 File Offset: 0x0016DD48
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

		// Token: 0x0600A057 RID: 41047 RVA: 0x0016FB5B File Offset: 0x0016DD5B
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

		// Token: 0x0600A058 RID: 41048 RVA: 0x0016FB6E File Offset: 0x0016DD6E
		public ILongPressButtonActionMapping_SetValue ToSetValue()
		{
			return new ILongPressButtonActionMapping_SetValue
			{
				Id = this.Id,
				ActionName = this.ActionName
			};
		}

		// Token: 0x170031F4 RID: 12788
		// (get) Token: 0x0600A059 RID: 41049 RVA: 0x0016FB8D File Offset: 0x0016DD8D
		// (set) Token: 0x0600A05A RID: 41050 RVA: 0x0016FBB8 File Offset: 0x0016DDB8
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

		// Token: 0x170031F5 RID: 12789
		// (get) Token: 0x0600A05B RID: 41051 RVA: 0x0016FBC6 File Offset: 0x0016DDC6
		// (set) Token: 0x0600A05C RID: 41052 RVA: 0x0016FBF1 File Offset: 0x0016DDF1
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

		// Token: 0x04006171 RID: 24945
		[Nullable(2)]
		protected ILongPressButtonActionMapping FbInstance;

		// Token: 0x04006172 RID: 24946
		[Nullable(2)]
		protected ILongPressButtonActionMapping_SetValue PocoInterface;
	}
}
