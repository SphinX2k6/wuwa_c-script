using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C44 RID: 3140
	public class TeleportComponent : IComponentBase
	{
		// Token: 0x060047F3 RID: 18419 RVA: 0x000B64F0 File Offset: 0x000B46F0
		public static TeleportComponent Create(ITeleportComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TeleportComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001366 RID: 4966
		// (get) Token: 0x060047F4 RID: 18420 RVA: 0x000B6510 File Offset: 0x000B4710
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

		// Token: 0x17001367 RID: 4967
		// (get) Token: 0x060047F5 RID: 18421 RVA: 0x000B6548 File Offset: 0x000B4748
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001368 RID: 4968
		// (get) Token: 0x060047F6 RID: 18422 RVA: 0x000B655E File Offset: 0x000B475E
		public virtual int TeleporterId
		{
			get
			{
				return this.Instance.TeleporterId;
			}
		}

		// Token: 0x17001369 RID: 4969
		// (get) Token: 0x060047F7 RID: 18423 RVA: 0x000B656B File Offset: 0x000B476B
		public virtual PosA TeleportPos
		{
			get
			{
				if (this._TeleportPosInited)
				{
					return this._TeleportPosCache;
				}
				this._TeleportPosInited = true;
				this._TeleportPosCache = PosA.Create(this.Instance.TeleportPos);
				return this._TeleportPosCache;
			}
		}

		// Token: 0x1700136A RID: 4970
		// (get) Token: 0x060047F8 RID: 18424 RVA: 0x000B659F File Offset: 0x000B479F
		[Nullable(2)]
		public virtual IGravityFlipTeleportConfig GravityConfig
		{
			[NullableContext(2)]
			get
			{
				if (this._GravityConfigInited)
				{
					return this._GravityConfigCache;
				}
				this._GravityConfigInited = true;
				this._GravityConfigCache = IGravityFlipTeleportConfig.Create(this.Instance.GravityConfig);
				return this._GravityConfigCache;
			}
		}

		// Token: 0x0400286B RID: 10347
		private ITeleportComponent Instance;

		// Token: 0x0400286C RID: 10348
		[Nullable(2)]
		private PosA _TeleportPosCache;

		// Token: 0x0400286D RID: 10349
		private bool _TeleportPosInited;

		// Token: 0x0400286E RID: 10350
		[Nullable(2)]
		private IGravityFlipTeleportConfig _GravityConfigCache;

		// Token: 0x0400286F RID: 10351
		private bool _GravityConfigInited;
	}
}
