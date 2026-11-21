using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200164F RID: 5711
	public class ClearEntityVisibleTag : ActionParams
	{
		// Token: 0x060080D5 RID: 32981 RVA: 0x001326B8 File Offset: 0x001308B8
		private ClearEntityVisibleTag_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ClearEntityVisibleTag 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ClearEntityVisibleTag_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ClearEntityVisibleTag_SetValue());
			}
			return result;
		}

		// Token: 0x060080D6 RID: 32982 RVA: 0x001326F0 File Offset: 0x001308F0
		public static ClearEntityVisibleTag Create([Nullable(2)] ClearEntityVisibleTag instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ClearEntityVisibleTag
			{
				FbInstance = instance
			};
		}

		// Token: 0x060080D7 RID: 32983 RVA: 0x00132703 File Offset: 0x00130903
		public static ClearEntityVisibleTag CreateFromSetValue([Nullable(2)] ClearEntityVisibleTag_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ClearEntityVisibleTag
			{
				PocoInterface = value
			};
		}

		// Token: 0x060080D8 RID: 32984 RVA: 0x00132716 File Offset: 0x00130916
		public ClearEntityVisibleTag_SetValue ToSetValue()
		{
			return new ClearEntityVisibleTag_SetValue
			{
				EntityIds = this.EntityIds
			};
		}

		// Token: 0x17002AB4 RID: 10932
		// (get) Token: 0x060080D9 RID: 32985 RVA: 0x00132729 File Offset: 0x00130929
		// (set) Token: 0x060080DA RID: 32986 RVA: 0x00132750 File Offset: 0x00130950
		public virtual List<int> EntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityIds;
				}
				ClearEntityVisibleTag_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04004A58 RID: 19032
		[Nullable(2)]
		protected new ClearEntityVisibleTag FbInstance;

		// Token: 0x04004A59 RID: 19033
		[Nullable(2)]
		protected ClearEntityVisibleTag_SetValue PocoInterface;
	}
}
