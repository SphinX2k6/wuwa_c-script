using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021D2 RID: 8658
	[NullableContext(1)]
	[Nullable(0)]
	public class SetPosA : ActionParams
	{
		// Token: 0x0600BE49 RID: 48713 RVA: 0x001B62E8 File Offset: 0x001B44E8
		private SetPosA_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SetPosA 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SetPosA_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SetPosA_SetValue());
			}
			return result;
		}

		// Token: 0x0600BE4A RID: 48714 RVA: 0x001B6320 File Offset: 0x001B4520
		public static SetPosA Create([Nullable(2)] SetPosA instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetPosA
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BE4B RID: 48715 RVA: 0x001B6333 File Offset: 0x001B4533
		public static SetPosA CreateFromSetValue([Nullable(2)] SetPosA_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SetPosA
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BE4C RID: 48716 RVA: 0x001B6346 File Offset: 0x001B4546
		public SetPosA_SetValue ToSetValue()
		{
			return new SetPosA_SetValue
			{
				Pos = this.Pos
			};
		}

		// Token: 0x170039CB RID: 14795
		// (get) Token: 0x0600BE4D RID: 48717 RVA: 0x001B635C File Offset: 0x001B455C
		// (set) Token: 0x0600BE4E RID: 48718 RVA: 0x001B63BD File Offset: 0x001B45BD
		public virtual PosA Pos
		{
			get
			{
				if (this._PosInited)
				{
					return this._PosCache;
				}
				this._PosInited = true;
				if (this.FbInstance != null)
				{
					this._PosCache = PosA.Create(this.FbInstance.Pos);
				}
				else
				{
					SetPosA_SetValue pocoInterface = this.PocoInterface;
					this._PosCache = ((pocoInterface != null) ? pocoInterface.Pos : null);
				}
				return this._PosCache;
			}
			set
			{
				this.GetOrCreatePoco().Pos = value;
				this._PosInited = false;
			}
		}

		// Token: 0x04007193 RID: 29075
		[Nullable(2)]
		protected new SetPosA FbInstance;

		// Token: 0x04007194 RID: 29076
		[Nullable(2)]
		protected SetPosA_SetValue PocoInterface;

		// Token: 0x04007195 RID: 29077
		private PosA _PosCache;

		// Token: 0x04007196 RID: 29078
		private bool _PosInited;
	}
}
