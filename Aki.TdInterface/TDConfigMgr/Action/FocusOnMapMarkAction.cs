using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001731 RID: 5937
	[NullableContext(1)]
	[Nullable(0)]
	public class FocusOnMapMarkAction : ActionParams
	{
		// Token: 0x06007DAD RID: 32173 RVA: 0x0012D5BC File Offset: 0x0012B7BC
		private FocusOnMapMarkAction_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("FocusOnMapMarkAction 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			FocusOnMapMarkAction_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new FocusOnMapMarkAction_SetValue());
			}
			return result;
		}

		// Token: 0x06007DAE RID: 32174 RVA: 0x0012D5F4 File Offset: 0x0012B7F4
		public static FocusOnMapMarkAction Create([Nullable(2)] FocusOnMapMarkAction instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new FocusOnMapMarkAction
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007DAF RID: 32175 RVA: 0x0012D607 File Offset: 0x0012B807
		public static FocusOnMapMarkAction CreateFromSetValue([Nullable(2)] FocusOnMapMarkAction_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new FocusOnMapMarkAction
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007DB0 RID: 32176 RVA: 0x0012D61A File Offset: 0x0012B81A
		public FocusOnMapMarkAction_SetValue ToSetValue()
		{
			return new FocusOnMapMarkAction_SetValue
			{
				MapMarkType = this.MapMarkType
			};
		}

		// Token: 0x17002960 RID: 10592
		// (get) Token: 0x06007DB1 RID: 32177 RVA: 0x0012D62D File Offset: 0x0012B82D
		// (set) Token: 0x06007DB2 RID: 32178 RVA: 0x0012D654 File Offset: 0x0012B854
		public virtual IFocusOnMapMark MapMarkType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MapMarkType;
				}
				FocusOnMapMarkAction_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MapMarkType;
			}
			set
			{
				this.GetOrCreatePoco().MapMarkType = value;
			}
		}

		// Token: 0x0400502A RID: 20522
		[Nullable(2)]
		protected new FocusOnMapMarkAction FbInstance;

		// Token: 0x0400502B RID: 20523
		[Nullable(2)]
		protected FocusOnMapMarkAction_SetValue PocoInterface;
	}
}
