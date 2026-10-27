using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BBC RID: 7100
	[NullableContext(1)]
	[Nullable(0)]
	public class IManipulate : ILeisureInteractType
	{
		// Token: 0x06009809 RID: 38921 RVA: 0x0015E8D0 File Offset: 0x0015CAD0
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

		// Token: 0x0600980A RID: 38922 RVA: 0x0015E908 File Offset: 0x0015CB08
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

		// Token: 0x0600980B RID: 38923 RVA: 0x0015E91B File Offset: 0x0015CB1B
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

		// Token: 0x0600980C RID: 38924 RVA: 0x0015E92E File Offset: 0x0015CB2E
		public new IManipulate_SetValue ToSetValue()
		{
			return new IManipulate_SetValue
			{
				Type = this.Type,
				TargetEntityId = this.TargetEntityId
			};
		}

		// Token: 0x17002FC1 RID: 12225
		// (get) Token: 0x0600980D RID: 38925 RVA: 0x0015E94D File Offset: 0x0015CB4D
		// (set) Token: 0x0600980E RID: 38926 RVA: 0x0015E978 File Offset: 0x0015CB78
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

		// Token: 0x17002FC2 RID: 12226
		// (get) Token: 0x0600980F RID: 38927 RVA: 0x0015E986 File Offset: 0x0015CB86
		// (set) Token: 0x06009810 RID: 38928 RVA: 0x0015E9B1 File Offset: 0x0015CBB1
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

		// Token: 0x04005CC6 RID: 23750
		[Nullable(2)]
		protected new IManipulate FbInstance;

		// Token: 0x04005CC7 RID: 23751
		[Nullable(2)]
		protected new IManipulate_SetValue PocoInterface;
	}
}
