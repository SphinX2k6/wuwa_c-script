using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D8E RID: 3470
	public class DynamicTeleportComponent : IComponentBase
	{
		// Token: 0x06004EF3 RID: 20211 RVA: 0x000C49ED File Offset: 0x000C2BED
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

		// Token: 0x170017D2 RID: 6098
		// (get) Token: 0x06004EF4 RID: 20212 RVA: 0x000C4A0C File Offset: 0x000C2C0C
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

		// Token: 0x170017D3 RID: 6099
		// (get) Token: 0x06004EF5 RID: 20213 RVA: 0x000C4A44 File Offset: 0x000C2C44
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170017D4 RID: 6100
		// (get) Token: 0x06004EF6 RID: 20214 RVA: 0x000C4A5A File Offset: 0x000C2C5A
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

		// Token: 0x170017D5 RID: 6101
		// (get) Token: 0x06004EF7 RID: 20215 RVA: 0x000C4A8E File Offset: 0x000C2C8E
		public virtual int PhantomSkillId
		{
			get
			{
				return this.Instance.PhantomSkillId;
			}
		}

		// Token: 0x04002CDD RID: 11485
		private IDynamicTeleportComponent Instance;

		// Token: 0x04002CDE RID: 11486
		[Nullable(2)]
		private PosA _OffsetCache;

		// Token: 0x04002CDF RID: 11487
		private bool _OffsetInited;
	}
}
