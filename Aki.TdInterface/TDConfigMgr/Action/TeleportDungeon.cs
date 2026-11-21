using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200249D RID: 9373
	public class TeleportDungeon : ActionParams
	{
		// Token: 0x0600CBD4 RID: 52180 RVA: 0x001D0C60 File Offset: 0x001CEE60
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

		// Token: 0x0600CBD5 RID: 52181 RVA: 0x001D0C98 File Offset: 0x001CEE98
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

		// Token: 0x0600CBD6 RID: 52182 RVA: 0x001D0CAB File Offset: 0x001CEEAB
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

		// Token: 0x0600CBD7 RID: 52183 RVA: 0x001D0CC0 File Offset: 0x001CEEC0
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

		// Token: 0x17003D20 RID: 15648
		// (get) Token: 0x0600CBD8 RID: 52184 RVA: 0x001D0D32 File Offset: 0x001CEF32
		// (set) Token: 0x0600CBD9 RID: 52185 RVA: 0x001D0D5D File Offset: 0x001CEF5D
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

		// Token: 0x17003D21 RID: 15649
		// (get) Token: 0x0600CBDA RID: 52186 RVA: 0x001D0D6B File Offset: 0x001CEF6B
		// (set) Token: 0x0600CBDB RID: 52187 RVA: 0x001D0D96 File Offset: 0x001CEF96
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

		// Token: 0x17003D22 RID: 15650
		// (get) Token: 0x0600CBDC RID: 52188 RVA: 0x001D0DA4 File Offset: 0x001CEFA4
		// (set) Token: 0x0600CBDD RID: 52189 RVA: 0x001D0DDE File Offset: 0x001CEFDE
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

		// Token: 0x17003D23 RID: 15651
		// (get) Token: 0x0600CBDE RID: 52190 RVA: 0x001D0DEC File Offset: 0x001CEFEC
		// (set) Token: 0x0600CBDF RID: 52191 RVA: 0x001D0E13 File Offset: 0x001CF013
		[Nullable(2)]
		public virtual ITeleportTransitionType TransitionOption
		{
			[NullableContext(2)]
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
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().TransitionOption = value;
			}
		}

		// Token: 0x17003D24 RID: 15652
		// (get) Token: 0x0600CBE0 RID: 52192 RVA: 0x001D0E24 File Offset: 0x001CF024
		// (set) Token: 0x0600CBE1 RID: 52193 RVA: 0x001D0E5E File Offset: 0x001CF05E
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

		// Token: 0x17003D25 RID: 15653
		// (get) Token: 0x0600CBE2 RID: 52194 RVA: 0x001D0E6C File Offset: 0x001CF06C
		// (set) Token: 0x0600CBE3 RID: 52195 RVA: 0x001D0EA6 File Offset: 0x001CF0A6
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

		// Token: 0x17003D26 RID: 15654
		// (get) Token: 0x0600CBE4 RID: 52196 RVA: 0x001D0EB4 File Offset: 0x001CF0B4
		// (set) Token: 0x0600CBE5 RID: 52197 RVA: 0x001D0EEE File Offset: 0x001CF0EE
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

		// Token: 0x17003D27 RID: 15655
		// (get) Token: 0x0600CBE6 RID: 52198 RVA: 0x001D0EFC File Offset: 0x001CF0FC
		// (set) Token: 0x0600CBE7 RID: 52199 RVA: 0x001D0F36 File Offset: 0x001CF136
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

		// Token: 0x040078D6 RID: 30934
		[Nullable(2)]
		protected new TeleportDungeon FbInstance;

		// Token: 0x040078D7 RID: 30935
		[Nullable(2)]
		protected TeleportDungeon_SetValue PocoInterface;
	}
}
