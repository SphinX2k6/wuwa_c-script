using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Common.Component;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle.MotorcycleRailMove
{
	// Token: 0x020061C4 RID: 25028
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class MotorcycleRailMoveDataBase
	{
		// Token: 0x0603C148 RID: 246088 RVA: 0x01118BB8 File Offset: 0x01116DB8
		protected MotorcycleRailMoveDataBase(EMotorcycleRailMoveDataType type, Entity ownerEntity, [Nullable(2)] MotorcycleRailComponent relatedRail)
		{
		}

		// Token: 0x0603C149 RID: 246089 RVA: 0x01118BD8 File Offset: 0x01116DD8
		[NullableContext(2)]
		public bool Enter(MotorcycleRailMoveDataBase lastRailMoveData)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.MotorRailMove;
			ELogAuthor author = ELogAuthor.ZYL;
			string message = "[MotorcycleRailMoveData] MotorcycleRailMoveData.Enter";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", this.Type);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return this.OnEnter(lastRailMoveData);
		}

		// Token: 0x0603C14A RID: 246090 RVA: 0x01118C20 File Offset: 0x01116E20
		[NullableContext(2)]
		public virtual bool OnEnter(MotorcycleRailMoveDataBase lastRailMoveData)
		{
			return true;
		}

		// Token: 0x0603C14B RID: 246091 RVA: 0x01118C24 File Offset: 0x01116E24
		public void Exit()
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.MotorRailMove;
			ELogAuthor author = ELogAuthor.ZYL;
			string message = "[MotorcycleRailMoveData] MotorcycleRailMoveData.Exit";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", this.Type);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.OnExit();
		}

		// Token: 0x0603C14C RID: 246092 RVA: 0x01118C6B File Offset: 0x01116E6B
		public virtual void OnExit()
		{
		}

		// Token: 0x0603C14D RID: 246093 RVA: 0x01118C6D File Offset: 0x01116E6D
		public void Tick(float deltaSeconds)
		{
			this.OnTick(deltaSeconds);
		}

		// Token: 0x0603C14E RID: 246094 RVA: 0x01118C76 File Offset: 0x01116E76
		public virtual void OnTick(float deltaSeconds)
		{
		}

		// Token: 0x0603C14F RID: 246095 RVA: 0x01118C78 File Offset: 0x01116E78
		public virtual bool GetVelocity(Vector outVelocity)
		{
			return false;
		}

		// Token: 0x0401FC6C RID: 130156
		public EMotorcycleRailMoveDataType Type = type;

		// Token: 0x0401FC6D RID: 130157
		public Entity OwnerEntity = ownerEntity;

		// Token: 0x0401FC6E RID: 130158
		[Nullable(2)]
		public MotorcycleRailComponent RelatedRail = relatedRail;

		// Token: 0x0401FC6F RID: 130159
		public bool IsFinishMove;

		// Token: 0x0401FC70 RID: 130160
		public bool IsFinishMoveOnFailure;
	}
}
