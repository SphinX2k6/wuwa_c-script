using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.LevelGamePlay.RollBlock.ItemLogic
{
	// Token: 0x02005C0D RID: 23565
	public class RbItemLogicBase
	{
		// Token: 0x06039DE9 RID: 237033 RVA: 0x01044C24 File Offset: 0x01042E24
		[NullableContext(1)]
		public RbItemLogicBase(RbItemComponent owner)
		{
			this.Owner = owner;
			MethodInfo method = base.GetType().GetMethod("Update", BindingFlags.Instance | BindingFlags.Public);
			MethodInfo method2 = typeof(RbItemLogicBase).GetMethod("Update", BindingFlags.Instance | BindingFlags.Public);
			this.NeedUpdate = (method != null && method2 != null && method != method2);
		}

		// Token: 0x06039DEA RID: 237034 RVA: 0x01044C8A File Offset: 0x01042E8A
		public virtual void Start([Nullable(new byte[]
		{
			0,
			1,
			1
		})] OneOf<RbBreakableObstaclePbType, RbLaserEmitterPbType> info)
		{
		}

		// Token: 0x06039DEB RID: 237035 RVA: 0x01044C8C File Offset: 0x01042E8C
		public virtual void End()
		{
		}

		// Token: 0x06039DEC RID: 237036 RVA: 0x01044C8E File Offset: 0x01042E8E
		public virtual void Update(float delta)
		{
		}

		// Token: 0x06039DED RID: 237037 RVA: 0x01044C90 File Offset: 0x01042E90
		public virtual void OnRbItemUpdate([Nullable(new byte[]
		{
			0,
			1,
			1
		})] OneOf<RbBreakableObstaclePbType, RbLaserEmitterPbType> info)
		{
		}

		// Token: 0x06039DEE RID: 237038 RVA: 0x01044C92 File Offset: 0x01042E92
		public virtual void OnStateChange(int stateId)
		{
		}

		// Token: 0x0401E94C RID: 125260
		[Nullable(2)]
		protected RbItemComponent Owner;

		// Token: 0x0401E94D RID: 125261
		public bool NeedUpdate;
	}
}
