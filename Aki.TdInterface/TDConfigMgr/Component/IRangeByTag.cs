using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200065C RID: 1628
	[NullableContext(1)]
	[Nullable(0)]
	public class IRangeByTag
	{
		// Token: 0x060022D8 RID: 8920 RVA: 0x0005FAC8 File Offset: 0x0005DCC8
		private IRangeByTag_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRangeByTag 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRangeByTag_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRangeByTag_SetValue());
			}
			return result;
		}

		// Token: 0x060022D9 RID: 8921 RVA: 0x0005FB00 File Offset: 0x0005DD00
		public static IRangeByTag Create([Nullable(2)] IRangeByTag instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRangeByTag
			{
				FbInstance = instance
			};
		}

		// Token: 0x060022DA RID: 8922 RVA: 0x0005FB13 File Offset: 0x0005DD13
		public static IRangeByTag CreateFromSetValue([Nullable(2)] IRangeByTag_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRangeByTag
			{
				PocoInterface = value
			};
		}

		// Token: 0x060022DB RID: 8923 RVA: 0x0005FB26 File Offset: 0x0005DD26
		public IRangeByTag_SetValue ToSetValue()
		{
			return new IRangeByTag_SetValue
			{
				Tag = this.Tag,
				Range = this.Range,
				ExitRange = this.ExitRange
			};
		}

		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x060022DC RID: 8924 RVA: 0x0005FB51 File Offset: 0x0005DD51
		// (set) Token: 0x060022DD RID: 8925 RVA: 0x0005FB7C File Offset: 0x0005DD7C
		public virtual int Tag
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Tag;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Tag;
			}
			set
			{
				this.GetOrCreatePoco().Tag = value;
			}
		}

		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x060022DE RID: 8926 RVA: 0x0005FB8A File Offset: 0x0005DD8A
		// (set) Token: 0x060022DF RID: 8927 RVA: 0x0005FBB9 File Offset: 0x0005DDB9
		public virtual float Range
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Range;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Range;
			}
			set
			{
				this.GetOrCreatePoco().Range = value;
			}
		}

		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x060022E0 RID: 8928 RVA: 0x0005FBC8 File Offset: 0x0005DDC8
		// (set) Token: 0x060022E1 RID: 8929 RVA: 0x0005FC02 File Offset: 0x0005DE02
		public virtual float? ExitRange
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ExitRange;
				}
				IRangeByTag_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ExitRange;
			}
			set
			{
				this.GetOrCreatePoco().ExitRange = value;
			}
		}

		// Token: 0x04001833 RID: 6195
		[Nullable(2)]
		protected IRangeByTag FbInstance;

		// Token: 0x04001834 RID: 6196
		[Nullable(2)]
		protected IRangeByTag_SetValue PocoInterface;
	}
}
