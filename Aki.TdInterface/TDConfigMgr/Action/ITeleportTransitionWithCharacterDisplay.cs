using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021ED RID: 8685
	public class ITeleportTransitionWithCharacterDisplay : ITeleportTransitionType
	{
		// Token: 0x0600BD44 RID: 48452 RVA: 0x001B5B28 File Offset: 0x001B3D28
		private ITeleportTransitionWithCharacterDisplay_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITeleportTransitionWithCharacterDisplay 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITeleportTransitionWithCharacterDisplay_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITeleportTransitionWithCharacterDisplay_SetValue());
			}
			return result;
		}

		// Token: 0x0600BD45 RID: 48453 RVA: 0x001B5B60 File Offset: 0x001B3D60
		public static ITeleportTransitionWithCharacterDisplay Create([Nullable(2)] ITeleportTransitionWithCharacterDisplay instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeleportTransitionWithCharacterDisplay
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BD46 RID: 48454 RVA: 0x001B5B73 File Offset: 0x001B3D73
		public static ITeleportTransitionWithCharacterDisplay CreateFromSetValue([Nullable(2)] ITeleportTransitionWithCharacterDisplay_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITeleportTransitionWithCharacterDisplay
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BD47 RID: 48455 RVA: 0x001B5B86 File Offset: 0x001B3D86
		public new ITeleportTransitionWithCharacterDisplay_SetValue ToSetValue()
		{
			return new ITeleportTransitionWithCharacterDisplay_SetValue
			{
				Type = this.Type,
				StyleId = this.StyleId
			};
		}

		// Token: 0x170039CE RID: 14798
		// (get) Token: 0x0600BD48 RID: 48456 RVA: 0x001B5BA5 File Offset: 0x001B3DA5
		// (set) Token: 0x0600BD49 RID: 48457 RVA: 0x001B5BD0 File Offset: 0x001B3DD0
		public override ETeleportTransitionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETeleportTransitionType.PlayMp4;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170039CF RID: 14799
		// (get) Token: 0x0600BD4A RID: 48458 RVA: 0x001B5BDE File Offset: 0x001B3DDE
		// (set) Token: 0x0600BD4B RID: 48459 RVA: 0x001B5C09 File Offset: 0x001B3E09
		public virtual int StyleId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StyleId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.StyleId;
			}
			set
			{
				this.GetOrCreatePoco().StyleId = value;
			}
		}

		// Token: 0x040071A3 RID: 29091
		[Nullable(2)]
		protected new ITeleportTransitionWithCharacterDisplay FbInstance;

		// Token: 0x040071A4 RID: 29092
		[Nullable(2)]
		protected new ITeleportTransitionWithCharacterDisplay_SetValue PocoInterface;
	}
}
