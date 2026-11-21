using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F87 RID: 8071
	public class IQiuyuanQinggongHovering : ILeisureInteractType
	{
		// Token: 0x0600AB95 RID: 43925 RVA: 0x00184560 File Offset: 0x00182760
		private IQiuyuanQinggongHovering_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IQiuyuanQinggongHovering 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IQiuyuanQinggongHovering_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IQiuyuanQinggongHovering_SetValue());
			}
			return result;
		}

		// Token: 0x0600AB96 RID: 43926 RVA: 0x00184598 File Offset: 0x00182798
		public static IQiuyuanQinggongHovering Create([Nullable(2)] IQiuyuanQinggongHovering instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQiuyuanQinggongHovering
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AB97 RID: 43927 RVA: 0x001845AB File Offset: 0x001827AB
		public static IQiuyuanQinggongHovering CreateFromSetValue([Nullable(2)] IQiuyuanQinggongHovering_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IQiuyuanQinggongHovering
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AB98 RID: 43928 RVA: 0x001845BE File Offset: 0x001827BE
		public new IQiuyuanQinggongHovering_SetValue ToSetValue()
		{
			return new IQiuyuanQinggongHovering_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700348E RID: 13454
		// (get) Token: 0x0600AB99 RID: 43929 RVA: 0x001845D1 File Offset: 0x001827D1
		// (set) Token: 0x0600AB9A RID: 43930 RVA: 0x001845FC File Offset: 0x001827FC
		public override ELeisureInteract Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELeisureInteract.CustomSkill;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040066B5 RID: 26293
		[Nullable(2)]
		protected new IQiuyuanQinggongHovering FbInstance;

		// Token: 0x040066B6 RID: 26294
		[Nullable(2)]
		protected new IQiuyuanQinggongHovering_SetValue PocoInterface;
	}
}
