using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.LevelGamePlay.RollBlock.ItemLogic
{
	// Token: 0x02006AB0 RID: 27312
	public class RbItemLogicBase
	{
		// Token: 0x06043D92 RID: 277906 RVA: 0x010A051C File Offset: 0x0109E71C
		[NullableContext(1)]
		public RbItemLogicBase(RbItemComponent owner)
		{
			this.Owner = owner;
			MethodInfo method = base.GetType().GetMethod("Update", BindingFlags.Instance | BindingFlags.Public);
			MethodInfo method2 = typeof(RbItemLogicBase).GetMethod("Update", BindingFlags.Instance | BindingFlags.Public);
			this.NeedUpdate = (method != null && method2 != null && method != method2);
		}

		// Token: 0x06043D93 RID: 277907 RVA: 0x010A0582 File Offset: 0x0109E782
		public virtual void Start([Nullable(new byte[]
		{
			0,
			1,
			1
		})] OneOf<RbBreakableObstaclePbType, RbLaserEmitterPbType> info)
		{
		}

		// Token: 0x06043D94 RID: 277908 RVA: 0x010A0584 File Offset: 0x0109E784
		public virtual void End()
		{
		}

		// Token: 0x06043D95 RID: 277909 RVA: 0x010A0586 File Offset: 0x0109E786
		public virtual void Update(float delta)
		{
		}

		// Token: 0x06043D96 RID: 277910 RVA: 0x010A0588 File Offset: 0x0109E788
		public virtual void OnRbItemUpdate([Nullable(new byte[]
		{
			0,
			1,
			1
		})] OneOf<RbBreakableObstaclePbType, RbLaserEmitterPbType> info)
		{
		}

		// Token: 0x06043D97 RID: 277911 RVA: 0x010A058A File Offset: 0x0109E78A
		public virtual void OnStateChange(int stateId)
		{
		}

		// Token: 0x0402375A RID: 145242
		[Nullable(2)]
		protected RbItemComponent Owner;

		// Token: 0x0402375B RID: 145243
		public bool NeedUpdate;
	}
}
