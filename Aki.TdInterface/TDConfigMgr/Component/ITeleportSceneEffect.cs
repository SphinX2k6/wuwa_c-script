using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007F9 RID: 2041
	[NullableContext(2)]
	[Nullable(0)]
	public class ITeleportSceneEffect
	{
		// Token: 0x06002BB5 RID: 11189 RVA: 0x0007270C File Offset: 0x0007090C
		[NullableContext(0)]
		private ITeleportSceneEffect_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITeleportSceneEffect 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITeleportSceneEffect_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITeleportSceneEffect_SetValue());
			}
			return result;
		}

		// Token: 0x06002BB6 RID: 11190 RVA: 0x00072744 File Offset: 0x00070944
		[NullableContext(0)]
		public static ITeleportSceneEffect Create([Nullable(2)] ITeleportSceneEffect instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeleportSceneEffect
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002BB7 RID: 11191 RVA: 0x00072757 File Offset: 0x00070957
		[NullableContext(0)]
		public static ITeleportSceneEffect CreateFromSetValue([Nullable(2)] ITeleportSceneEffect_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITeleportSceneEffect
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002BB8 RID: 11192 RVA: 0x0007276A File Offset: 0x0007096A
		[NullableContext(0)]
		public ITeleportSceneEffect_SetValue ToSetValue()
		{
			return new ITeleportSceneEffect_SetValue
			{
				WorldEffectPath = this.WorldEffectPath,
				ScreenEffectPath = this.ScreenEffectPath
			};
		}

		// Token: 0x17000B65 RID: 2917
		// (get) Token: 0x06002BB9 RID: 11193 RVA: 0x00072789 File Offset: 0x00070989
		// (set) Token: 0x06002BBA RID: 11194 RVA: 0x000727B0 File Offset: 0x000709B0
		public virtual string WorldEffectPath
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.WorldEffectPath;
				}
				ITeleportSceneEffect_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.WorldEffectPath;
			}
			set
			{
				this.GetOrCreatePoco().WorldEffectPath = value;
			}
		}

		// Token: 0x17000B66 RID: 2918
		// (get) Token: 0x06002BBB RID: 11195 RVA: 0x000727BE File Offset: 0x000709BE
		// (set) Token: 0x06002BBC RID: 11196 RVA: 0x000727E5 File Offset: 0x000709E5
		public virtual string ScreenEffectPath
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ScreenEffectPath;
				}
				ITeleportSceneEffect_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ScreenEffectPath;
			}
			set
			{
				this.GetOrCreatePoco().ScreenEffectPath = value;
			}
		}

		// Token: 0x04001D47 RID: 7495
		protected ITeleportSceneEffect FbInstance;

		// Token: 0x04001D48 RID: 7496
		protected ITeleportSceneEffect_SetValue PocoInterface;
	}
}
