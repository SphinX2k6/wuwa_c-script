using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020BB RID: 8379
	[NullableContext(1)]
	[Nullable(0)]
	public class IWindProtagonistParkour3 : ILeisureInteractType
	{
		// Token: 0x0600B83C RID: 47164 RVA: 0x001AA78C File Offset: 0x001A898C
		private IWindProtagonistParkour3_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWindProtagonistParkour3 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWindProtagonistParkour3_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWindProtagonistParkour3_SetValue());
			}
			return result;
		}

		// Token: 0x0600B83D RID: 47165 RVA: 0x001AA7C4 File Offset: 0x001A89C4
		public static IWindProtagonistParkour3 Create([Nullable(2)] IWindProtagonistParkour3 instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWindProtagonistParkour3
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B83E RID: 47166 RVA: 0x001AA7D7 File Offset: 0x001A89D7
		public static IWindProtagonistParkour3 CreateFromSetValue([Nullable(2)] IWindProtagonistParkour3_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWindProtagonistParkour3
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B83F RID: 47167 RVA: 0x001AA7EA File Offset: 0x001A89EA
		public new IWindProtagonistParkour3_SetValue ToSetValue()
		{
			return new IWindProtagonistParkour3_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700385E RID: 14430
		// (get) Token: 0x0600B840 RID: 47168 RVA: 0x001AA7FD File Offset: 0x001A89FD
		// (set) Token: 0x0600B841 RID: 47169 RVA: 0x001AA828 File Offset: 0x001A8A28
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

		// Token: 0x04006E77 RID: 28279
		[Nullable(2)]
		protected new IWindProtagonistParkour3 FbInstance;

		// Token: 0x04006E78 RID: 28280
		[Nullable(2)]
		protected new IWindProtagonistParkour3_SetValue PocoInterface;
	}
}
