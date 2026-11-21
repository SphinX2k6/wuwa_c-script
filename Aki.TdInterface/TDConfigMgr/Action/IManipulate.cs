using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DA3 RID: 7587
	public class IManipulate : ILeisureInteractType
	{
		// Token: 0x0600A10D RID: 41229 RVA: 0x00171390 File Offset: 0x0016F590
		private IManipulate_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IManipulate 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IManipulate_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IManipulate_SetValue());
			}
			return result;
		}

		// Token: 0x0600A10E RID: 41230 RVA: 0x001713C8 File Offset: 0x0016F5C8
		public static IManipulate Create([Nullable(2)] IManipulate instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IManipulate
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A10F RID: 41231 RVA: 0x001713DB File Offset: 0x0016F5DB
		public static IManipulate CreateFromSetValue([Nullable(2)] IManipulate_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IManipulate
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A110 RID: 41232 RVA: 0x001713EE File Offset: 0x0016F5EE
		public new IManipulate_SetValue ToSetValue()
		{
			return new IManipulate_SetValue
			{
				Type = this.Type,
				TargetEntityId = this.TargetEntityId
			};
		}

		// Token: 0x17003220 RID: 12832
		// (get) Token: 0x0600A111 RID: 41233 RVA: 0x0017140D File Offset: 0x0016F60D
		// (set) Token: 0x0600A112 RID: 41234 RVA: 0x00171438 File Offset: 0x0016F638
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

		// Token: 0x17003221 RID: 12833
		// (get) Token: 0x0600A113 RID: 41235 RVA: 0x00171446 File Offset: 0x0016F646
		// (set) Token: 0x0600A114 RID: 41236 RVA: 0x00171471 File Offset: 0x0016F671
		public virtual int TargetEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TargetEntityId;
			}
			set
			{
				this.GetOrCreatePoco().TargetEntityId = value;
			}
		}

		// Token: 0x040061DB RID: 25051
		[Nullable(2)]
		protected new IManipulate FbInstance;

		// Token: 0x040061DC RID: 25052
		[Nullable(2)]
		protected new IManipulate_SetValue PocoInterface;
	}
}
