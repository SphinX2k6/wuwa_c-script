using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D76 RID: 7542
	[NullableContext(1)]
	[Nullable(0)]
	public class IQiuyuanQinggongHovering : ILeisureInteractType
	{
		// Token: 0x0600A1A9 RID: 41385 RVA: 0x0017013C File Offset: 0x0016E33C
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

		// Token: 0x0600A1AA RID: 41386 RVA: 0x00170174 File Offset: 0x0016E374
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

		// Token: 0x0600A1AB RID: 41387 RVA: 0x00170187 File Offset: 0x0016E387
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

		// Token: 0x0600A1AC RID: 41388 RVA: 0x0017019A File Offset: 0x0016E39A
		public new IQiuyuanQinggongHovering_SetValue ToSetValue()
		{
			return new IQiuyuanQinggongHovering_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170031FA RID: 12794
		// (get) Token: 0x0600A1AD RID: 41389 RVA: 0x001701AD File Offset: 0x0016E3AD
		// (set) Token: 0x0600A1AE RID: 41390 RVA: 0x001701D8 File Offset: 0x0016E3D8
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

		// Token: 0x04006139 RID: 24889
		[Nullable(2)]
		protected new IQiuyuanQinggongHovering FbInstance;

		// Token: 0x0400613A RID: 24890
		[Nullable(2)]
		protected new IQiuyuanQinggongHovering_SetValue PocoInterface;
	}
}
