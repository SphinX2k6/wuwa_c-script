using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200243D RID: 9277
	public class SetPosA : ActionParams
	{
		// Token: 0x0600CA05 RID: 51717 RVA: 0x001CD974 File Offset: 0x001CBB74
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

		// Token: 0x0600CA06 RID: 51718 RVA: 0x001CD9AC File Offset: 0x001CBBAC
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

		// Token: 0x0600CA07 RID: 51719 RVA: 0x001CD9BF File Offset: 0x001CBBBF
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

		// Token: 0x0600CA08 RID: 51720 RVA: 0x001CD9D2 File Offset: 0x001CBBD2
		public SetPosA_SetValue ToSetValue()
		{
			return new SetPosA_SetValue
			{
				Pos = this.Pos
			};
		}

		// Token: 0x17003CC0 RID: 15552
		// (get) Token: 0x0600CA09 RID: 51721 RVA: 0x001CD9E8 File Offset: 0x001CBBE8
		// (set) Token: 0x0600CA0A RID: 51722 RVA: 0x001CDA49 File Offset: 0x001CBC49
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

		// Token: 0x040077DC RID: 30684
		[Nullable(2)]
		protected new SetPosA FbInstance;

		// Token: 0x040077DD RID: 30685
		[Nullable(2)]
		protected SetPosA_SetValue PocoInterface;

		// Token: 0x040077DE RID: 30686
		private PosA _PosCache;

		// Token: 0x040077DF RID: 30687
		private bool _PosInited;
	}
}
