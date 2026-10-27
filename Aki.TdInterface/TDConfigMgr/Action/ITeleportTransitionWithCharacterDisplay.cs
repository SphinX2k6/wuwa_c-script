using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FAA RID: 8106
	[NullableContext(1)]
	[Nullable(0)]
	public class ITeleportTransitionWithCharacterDisplay : ITeleportTransitionType
	{
		// Token: 0x0600B240 RID: 45632 RVA: 0x0019F778 File Offset: 0x0019D978
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

		// Token: 0x0600B241 RID: 45633 RVA: 0x0019F7B0 File Offset: 0x0019D9B0
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

		// Token: 0x0600B242 RID: 45634 RVA: 0x0019F7C3 File Offset: 0x0019D9C3
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

		// Token: 0x0600B243 RID: 45635 RVA: 0x0019F7D6 File Offset: 0x0019D9D6
		public new ITeleportTransitionWithCharacterDisplay_SetValue ToSetValue()
		{
			return new ITeleportTransitionWithCharacterDisplay_SetValue
			{
				Type = this.Type,
				StyleId = this.StyleId
			};
		}

		// Token: 0x170036F9 RID: 14073
		// (get) Token: 0x0600B244 RID: 45636 RVA: 0x0019F7F5 File Offset: 0x0019D9F5
		// (set) Token: 0x0600B245 RID: 45637 RVA: 0x0019F820 File Offset: 0x0019DA20
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

		// Token: 0x170036FA RID: 14074
		// (get) Token: 0x0600B246 RID: 45638 RVA: 0x0019F82E File Offset: 0x0019DA2E
		// (set) Token: 0x0600B247 RID: 45639 RVA: 0x0019F859 File Offset: 0x0019DA59
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

		// Token: 0x04006BA8 RID: 27560
		[Nullable(2)]
		protected new ITeleportTransitionWithCharacterDisplay FbInstance;

		// Token: 0x04006BA9 RID: 27561
		[Nullable(2)]
		protected new ITeleportTransitionWithCharacterDisplay_SetValue PocoInterface;
	}
}
