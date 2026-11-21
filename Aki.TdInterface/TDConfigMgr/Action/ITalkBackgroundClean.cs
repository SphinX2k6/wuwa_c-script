using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002151 RID: 8529
	public class ITalkBackgroundClean : ITalkBackground
	{
		// Token: 0x0600B504 RID: 46340 RVA: 0x00195580 File Offset: 0x00193780
		private ITalkBackgroundClean_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITalkBackgroundClean 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITalkBackgroundClean_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkBackgroundClean_SetValue());
			}
			return result;
		}

		// Token: 0x0600B505 RID: 46341 RVA: 0x001955B8 File Offset: 0x001937B8
		public static ITalkBackgroundClean Create([Nullable(2)] ITalkBackgroundClean instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkBackgroundClean
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B506 RID: 46342 RVA: 0x001955CB File Offset: 0x001937CB
		public static ITalkBackgroundClean CreateFromSetValue([Nullable(2)] ITalkBackgroundClean_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkBackgroundClean
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B507 RID: 46343 RVA: 0x001955DE File Offset: 0x001937DE
		public new ITalkBackgroundClean_SetValue ToSetValue()
		{
			return new ITalkBackgroundClean_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003698 RID: 13976
		// (get) Token: 0x0600B508 RID: 46344 RVA: 0x001955F1 File Offset: 0x001937F1
		// (set) Token: 0x0600B509 RID: 46345 RVA: 0x0019561C File Offset: 0x0019381C
		public override ETalkBackgroundType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETalkBackgroundType.Clean;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006B10 RID: 27408
		[Nullable(2)]
		protected new ITalkBackgroundClean FbInstance;

		// Token: 0x04006B11 RID: 27409
		[Nullable(2)]
		protected new ITalkBackgroundClean_SetValue PocoInterface;
	}
}
