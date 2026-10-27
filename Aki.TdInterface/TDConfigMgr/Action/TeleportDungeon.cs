using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002232 RID: 8754
	[NullableContext(2)]
	[Nullable(0)]
	public class TeleportDungeon : ActionParams
	{
		// Token: 0x0600C016 RID: 49174 RVA: 0x001B9594 File Offset: 0x001B7794
		[NullableContext(1)]
		private TeleportDungeon_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("TeleportDungeon 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			TeleportDungeon_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new TeleportDungeon_SetValue());
			}
			return result;
		}

		// Token: 0x0600C017 RID: 49175 RVA: 0x001B95CC File Offset: 0x001B77CC
		[NullableContext(1)]
		public static TeleportDungeon Create([Nullable(2)] TeleportDungeon instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TeleportDungeon
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C018 RID: 49176 RVA: 0x001B95DF File Offset: 0x001B77DF
		[NullableContext(1)]
		public static TeleportDungeon CreateFromSetValue([Nullable(2)] TeleportDungeon_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new TeleportDungeon
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C019 RID: 49177 RVA: 0x001B95F4 File Offset: 0x001B77F4
		[NullableContext(1)]
		public TeleportDungeon_SetValue ToSetValue()
		{
			return new TeleportDungeon_SetValue
			{
				DungeonId = this.DungeonId,
				IsRegroup = this.IsRegroup,
				LocationEntityId = this.LocationEntityId,
				TransitionOption = this.TransitionOption,
				IsNeedSecondaryConfirmation = this.IsNeedSecondaryConfirmation,
				UseLocationEntityGravity = this.UseLocationEntityGravity,
				ContinueSave = this.ContinueSave,
				IsBanMapSound = this.IsBanMapSound
			};
		}

		// Token: 0x17003A2A RID: 14890
		// (get) Token: 0x0600C01A RID: 49178 RVA: 0x001B9666 File Offset: 0x001B7866
		// (set) Token: 0x0600C01B RID: 49179 RVA: 0x001B9691 File Offset: 0x001B7891
		public virtual int DungeonId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DungeonId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.DungeonId;
			}
			set
			{
				this.GetOrCreatePoco().DungeonId = value;
			}
		}

		// Token: 0x17003A2B RID: 14891
		// (get) Token: 0x0600C01C RID: 49180 RVA: 0x001B969F File Offset: 0x001B789F
		// (set) Token: 0x0600C01D RID: 49181 RVA: 0x001B96CA File Offset: 0x001B78CA
		public virtual bool IsRegroup
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsRegroup;
				}
				return this.PocoInterface != null && this.PocoInterface.IsRegroup;
			}
			set
			{
				this.GetOrCreatePoco().IsRegroup = value;
			}
		}

		// Token: 0x17003A2C RID: 14892
		// (get) Token: 0x0600C01E RID: 49182 RVA: 0x001B96D8 File Offset: 0x001B78D8
		// (set) Token: 0x0600C01F RID: 49183 RVA: 0x001B9712 File Offset: 0x001B7912
		public virtual int? LocationEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LocationEntityId;
				}
				TeleportDungeon_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.LocationEntityId;
			}
			set
			{
				this.GetOrCreatePoco().LocationEntityId = value;
			}
		}

		// Token: 0x17003A2D RID: 14893
		// (get) Token: 0x0600C020 RID: 49184 RVA: 0x001B9720 File Offset: 0x001B7920
		// (set) Token: 0x0600C021 RID: 49185 RVA: 0x001B9747 File Offset: 0x001B7947
		public virtual ITeleportTransitionType TransitionOption
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TransitionOption;
				}
				TeleportDungeon_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TransitionOption;
			}
			set
			{
				this.GetOrCreatePoco().TransitionOption = value;
			}
		}

		// Token: 0x17003A2E RID: 14894
		// (get) Token: 0x0600C022 RID: 49186 RVA: 0x001B9758 File Offset: 0x001B7958
		// (set) Token: 0x0600C023 RID: 49187 RVA: 0x001B9792 File Offset: 0x001B7992
		public virtual bool? IsNeedSecondaryConfirmation
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsNeedSecondaryConfirmation;
				}
				TeleportDungeon_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsNeedSecondaryConfirmation;
			}
			set
			{
				this.GetOrCreatePoco().IsNeedSecondaryConfirmation = value;
			}
		}

		// Token: 0x17003A2F RID: 14895
		// (get) Token: 0x0600C024 RID: 49188 RVA: 0x001B97A0 File Offset: 0x001B79A0
		// (set) Token: 0x0600C025 RID: 49189 RVA: 0x001B97DA File Offset: 0x001B79DA
		public virtual bool? UseLocationEntityGravity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.UseLocationEntityGravity;
				}
				TeleportDungeon_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.UseLocationEntityGravity;
			}
			set
			{
				this.GetOrCreatePoco().UseLocationEntityGravity = value;
			}
		}

		// Token: 0x17003A30 RID: 14896
		// (get) Token: 0x0600C026 RID: 49190 RVA: 0x001B97E8 File Offset: 0x001B79E8
		// (set) Token: 0x0600C027 RID: 49191 RVA: 0x001B9822 File Offset: 0x001B7A22
		public virtual bool? ContinueSave
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ContinueSave;
				}
				TeleportDungeon_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ContinueSave;
			}
			set
			{
				this.GetOrCreatePoco().ContinueSave = value;
			}
		}

		// Token: 0x17003A31 RID: 14897
		// (get) Token: 0x0600C028 RID: 49192 RVA: 0x001B9830 File Offset: 0x001B7A30
		// (set) Token: 0x0600C029 RID: 49193 RVA: 0x001B986A File Offset: 0x001B7A6A
		public virtual bool? IsBanMapSound
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsBanMapSound;
				}
				TeleportDungeon_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsBanMapSound;
			}
			set
			{
				this.GetOrCreatePoco().IsBanMapSound = value;
			}
		}

		// Token: 0x0400728C RID: 29324
		protected new TeleportDungeon FbInstance;

		// Token: 0x0400728D RID: 29325
		protected TeleportDungeon_SetValue PocoInterface;
	}
}
