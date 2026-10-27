using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E75 RID: 7797
	[NullableContext(1)]
	[Nullable(0)]
	public class ISitOnGround : ILeisureInteractType
	{
		// Token: 0x0600A6E2 RID: 42722 RVA: 0x00179830 File Offset: 0x00177A30
		private ISitOnGround_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISitOnGround 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISitOnGround_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISitOnGround_SetValue());
			}
			return result;
		}

		// Token: 0x0600A6E3 RID: 42723 RVA: 0x00179868 File Offset: 0x00177A68
		public static ISitOnGround Create([Nullable(2)] ISitOnGround instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISitOnGround
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A6E4 RID: 42724 RVA: 0x0017987B File Offset: 0x00177A7B
		public static ISitOnGround CreateFromSetValue([Nullable(2)] ISitOnGround_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISitOnGround
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A6E5 RID: 42725 RVA: 0x0017988E File Offset: 0x00177A8E
		public new ISitOnGround_SetValue ToSetValue()
		{
			return new ISitOnGround_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003319 RID: 13081
		// (get) Token: 0x0600A6E6 RID: 42726 RVA: 0x001798A1 File Offset: 0x00177AA1
		// (set) Token: 0x0600A6E7 RID: 42727 RVA: 0x001798CC File Offset: 0x00177ACC
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

		// Token: 0x040063A4 RID: 25508
		[Nullable(2)]
		protected new ISitOnGround FbInstance;

		// Token: 0x040063A5 RID: 25509
		[Nullable(2)]
		protected new ISitOnGround_SetValue PocoInterface;
	}
}
