using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018AE RID: 6318
	public class FocusOnMapMarkAction : ActionParams
	{
		// Token: 0x0600848B RID: 33931 RVA: 0x0013C668 File Offset: 0x0013A868
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

		// Token: 0x0600848C RID: 33932 RVA: 0x0013C6A0 File Offset: 0x0013A8A0
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

		// Token: 0x0600848D RID: 33933 RVA: 0x0013C6B3 File Offset: 0x0013A8B3
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

		// Token: 0x0600848E RID: 33934 RVA: 0x0013C6C6 File Offset: 0x0013A8C6
		public FocusOnMapMarkAction_SetValue ToSetValue()
		{
			return new FocusOnMapMarkAction_SetValue
			{
				MapMarkType = this.MapMarkType
			};
		}

		// Token: 0x17002B4B RID: 11083
		// (get) Token: 0x0600848F RID: 33935 RVA: 0x0013C6D9 File Offset: 0x0013A8D9
		// (set) Token: 0x06008490 RID: 33936 RVA: 0x0013C700 File Offset: 0x0013A900
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

		// Token: 0x04005459 RID: 21593
		[Nullable(2)]
		protected new FocusOnMapMarkAction FbInstance;

		// Token: 0x0400545A RID: 21594
		[Nullable(2)]
		protected FocusOnMapMarkAction_SetValue PocoInterface;
	}
}
