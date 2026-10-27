using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E91 RID: 7825
	[NullableContext(1)]
	[Nullable(0)]
	public class ISoar : ILeisureInteractType
	{
		// Token: 0x0600A772 RID: 42866 RVA: 0x0017A764 File Offset: 0x00178964
		private ISoar_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISoar 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISoar_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISoar_SetValue());
			}
			return result;
		}

		// Token: 0x0600A773 RID: 42867 RVA: 0x0017A79C File Offset: 0x0017899C
		public static ISoar Create([Nullable(2)] ISoar instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISoar
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A774 RID: 42868 RVA: 0x0017A7AF File Offset: 0x001789AF
		public static ISoar CreateFromSetValue([Nullable(2)] ISoar_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISoar
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A775 RID: 42869 RVA: 0x0017A7C2 File Offset: 0x001789C2
		public new ISoar_SetValue ToSetValue()
		{
			return new ISoar_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003337 RID: 13111
		// (get) Token: 0x0600A776 RID: 42870 RVA: 0x0017A7D5 File Offset: 0x001789D5
		// (set) Token: 0x0600A777 RID: 42871 RVA: 0x0017A800 File Offset: 0x00178A00
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

		// Token: 0x040063E0 RID: 25568
		[Nullable(2)]
		protected new ISoar FbInstance;

		// Token: 0x040063E1 RID: 25569
		[Nullable(2)]
		protected new ISoar_SetValue PocoInterface;
	}
}
