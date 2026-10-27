using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CAC RID: 3244
	[NullableContext(1)]
	[Nullable(0)]
	public class DynamicTeleportComponent : IComponentBase
	{
		// Token: 0x06004A45 RID: 19013 RVA: 0x000B9FDD File Offset: 0x000B81DD
		public static DynamicTeleportComponent Create(IDynamicTeleportComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DynamicTeleportComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170016AA RID: 5802
		// (get) Token: 0x06004A46 RID: 19014 RVA: 0x000B9FFC File Offset: 0x000B81FC
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x170016AB RID: 5803
		// (get) Token: 0x06004A47 RID: 19015 RVA: 0x000BA034 File Offset: 0x000B8234
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170016AC RID: 5804
		// (get) Token: 0x06004A48 RID: 19016 RVA: 0x000BA04A File Offset: 0x000B824A
		public virtual PosA Offset
		{
			get
			{
				if (this._OffsetInited)
				{
					return this._OffsetCache;
				}
				this._OffsetInited = true;
				this._OffsetCache = PosA.Create(this.Instance.Offset);
				return this._OffsetCache;
			}
		}

		// Token: 0x170016AD RID: 5805
		// (get) Token: 0x06004A49 RID: 19017 RVA: 0x000BA07E File Offset: 0x000B827E
		public virtual int PhantomSkillId
		{
			get
			{
				return this.Instance.PhantomSkillId;
			}
		}

		// Token: 0x04002A63 RID: 10851
		private IDynamicTeleportComponent Instance;

		// Token: 0x04002A64 RID: 10852
		[Nullable(2)]
		private PosA _OffsetCache;

		// Token: 0x04002A65 RID: 10853
		private bool _OffsetInited;
	}
}
