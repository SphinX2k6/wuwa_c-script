using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002109 RID: 8457
	[NullableContext(1)]
	[Nullable(0)]
	public class PlayEffect : ActionParams
	{
		// Token: 0x0600BA0C RID: 47628 RVA: 0x001ADFF4 File Offset: 0x001AC1F4
		private PlayEffect_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("PlayEffect 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			PlayEffect_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new PlayEffect_SetValue());
			}
			return result;
		}

		// Token: 0x0600BA0D RID: 47629 RVA: 0x001AE02C File Offset: 0x001AC22C
		public static PlayEffect Create([Nullable(2)] PlayEffect instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PlayEffect
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BA0E RID: 47630 RVA: 0x001AE03F File Offset: 0x001AC23F
		public static PlayEffect CreateFromSetValue([Nullable(2)] PlayEffect_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new PlayEffect
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BA0F RID: 47631 RVA: 0x001AE052 File Offset: 0x001AC252
		public PlayEffect_SetValue ToSetValue()
		{
			return new PlayEffect_SetValue
			{
				Path = this.Path,
				Pos2 = this.Pos2
			};
		}

		// Token: 0x170038D2 RID: 14546
		// (get) Token: 0x0600BA10 RID: 47632 RVA: 0x001AE071 File Offset: 0x001AC271
		// (set) Token: 0x0600BA11 RID: 47633 RVA: 0x001AE09C File Offset: 0x001AC29C
		public virtual string Path
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Path;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Path;
			}
			set
			{
				this.GetOrCreatePoco().Path = value;
			}
		}

		// Token: 0x170038D3 RID: 14547
		// (get) Token: 0x0600BA12 RID: 47634 RVA: 0x001AE0AA File Offset: 0x001AC2AA
		// (set) Token: 0x0600BA13 RID: 47635 RVA: 0x001AE0D1 File Offset: 0x001AC2D1
		public virtual IBasePos2 Pos2
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Pos2;
				}
				PlayEffect_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Pos2;
			}
			set
			{
				this.GetOrCreatePoco().Pos2 = value;
			}
		}

		// Token: 0x04006F63 RID: 28515
		[Nullable(2)]
		protected new PlayEffect FbInstance;

		// Token: 0x04006F64 RID: 28516
		[Nullable(2)]
		protected PlayEffect_SetValue PocoInterface;
	}
}
