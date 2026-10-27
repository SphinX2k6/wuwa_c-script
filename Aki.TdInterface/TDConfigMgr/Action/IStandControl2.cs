using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EB3 RID: 7859
	[NullableContext(1)]
	[Nullable(0)]
	public class IStandControl2 : ILeisureInteractType
	{
		// Token: 0x0600A81A RID: 43034 RVA: 0x0017BA68 File Offset: 0x00179C68
		private IStandControl2_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IStandControl2 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IStandControl2_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IStandControl2_SetValue());
			}
			return result;
		}

		// Token: 0x0600A81B RID: 43035 RVA: 0x0017BAA0 File Offset: 0x00179CA0
		public static IStandControl2 Create([Nullable(2)] IStandControl2 instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStandControl2
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A81C RID: 43036 RVA: 0x0017BAB3 File Offset: 0x00179CB3
		public static IStandControl2 CreateFromSetValue([Nullable(2)] IStandControl2_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IStandControl2
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A81D RID: 43037 RVA: 0x0017BAC6 File Offset: 0x00179CC6
		public new IStandControl2_SetValue ToSetValue()
		{
			return new IStandControl2_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003358 RID: 13144
		// (get) Token: 0x0600A81E RID: 43038 RVA: 0x0017BAD9 File Offset: 0x00179CD9
		// (set) Token: 0x0600A81F RID: 43039 RVA: 0x0017BB04 File Offset: 0x00179D04
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

		// Token: 0x0400642F RID: 25647
		[Nullable(2)]
		protected new IStandControl2 FbInstance;

		// Token: 0x04006430 RID: 25648
		[Nullable(2)]
		protected new IStandControl2_SetValue PocoInterface;
	}
}
