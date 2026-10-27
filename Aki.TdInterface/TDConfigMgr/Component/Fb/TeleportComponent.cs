using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B76 RID: 2934
	[NullableContext(2)]
	[Nullable(0)]
	public class TeleportComponent : IComponentBase
	{
		// Token: 0x0600439A RID: 17306 RVA: 0x000AC42C File Offset: 0x000AA62C
		[NullableContext(1)]
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

		// Token: 0x1700126B RID: 4715
		// (get) Token: 0x0600439B RID: 17307 RVA: 0x000AC44C File Offset: 0x000AA64C
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

		// Token: 0x1700126C RID: 4716
		// (get) Token: 0x0600439C RID: 17308 RVA: 0x000AC484 File Offset: 0x000AA684
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700126D RID: 4717
		// (get) Token: 0x0600439D RID: 17309 RVA: 0x000AC49A File Offset: 0x000AA69A
		public virtual int TeleporterId
		{
			get
			{
				return this.Instance.TeleporterId;
			}
		}

		// Token: 0x1700126E RID: 4718
		// (get) Token: 0x0600439E RID: 17310 RVA: 0x000AC4A7 File Offset: 0x000AA6A7
		[Nullable(1)]
		public virtual PosA TeleportPos
		{
			[NullableContext(1)]
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

		// Token: 0x1700126F RID: 4719
		// (get) Token: 0x0600439F RID: 17311 RVA: 0x000AC4DB File Offset: 0x000AA6DB
		public virtual IGravityFlipTeleportConfig GravityConfig
		{
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

		// Token: 0x04002623 RID: 9763
		private ITeleportComponent Instance;

		// Token: 0x04002624 RID: 9764
		private PosA _TeleportPosCache;

		// Token: 0x04002625 RID: 9765
		private bool _TeleportPosInited;

		// Token: 0x04002626 RID: 9766
		private IGravityFlipTeleportConfig _GravityConfigCache;

		// Token: 0x04002627 RID: 9767
		private bool _GravityConfigInited;
	}
}
