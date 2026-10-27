using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Common.Component;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle.MotorcycleRailMove
{
	// Token: 0x02007043 RID: 28739
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class MotorcycleRailMoveDataBase
	{
		// Token: 0x06045F62 RID: 286562 RVA: 0x0116EE40 File Offset: 0x0116D040
		protected MotorcycleRailMoveDataBase(EMotorcycleRailMoveDataType type, Entity ownerEntity, [Nullable(2)] MotorcycleRailComponent relatedRail)
		{
		}

		// Token: 0x06045F63 RID: 286563 RVA: 0x0116EE60 File Offset: 0x0116D060
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

		// Token: 0x06045F64 RID: 286564 RVA: 0x0116EEA8 File Offset: 0x0116D0A8
		[NullableContext(2)]
		public virtual bool OnEnter(MotorcycleRailMoveDataBase lastRailMoveData)
		{
			return true;
		}

		// Token: 0x06045F65 RID: 286565 RVA: 0x0116EEAC File Offset: 0x0116D0AC
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

		// Token: 0x06045F66 RID: 286566 RVA: 0x0116EEF3 File Offset: 0x0116D0F3
		public virtual void OnExit()
		{
		}

		// Token: 0x06045F67 RID: 286567 RVA: 0x0116EEF5 File Offset: 0x0116D0F5
		public void Tick(float deltaSeconds)
		{
			this.OnTick(deltaSeconds);
		}

		// Token: 0x06045F68 RID: 286568 RVA: 0x0116EEFE File Offset: 0x0116D0FE
		public virtual void OnTick(float deltaSeconds)
		{
		}

		// Token: 0x06045F69 RID: 286569 RVA: 0x0116EF00 File Offset: 0x0116D100
		public virtual bool GetVelocity(Vector outVelocity)
		{
			return false;
		}

		// Token: 0x040249B6 RID: 149942
		public EMotorcycleRailMoveDataType Type = type;

		// Token: 0x040249B7 RID: 149943
		public Entity OwnerEntity = ownerEntity;

		// Token: 0x040249B8 RID: 149944
		[Nullable(2)]
		public MotorcycleRailComponent RelatedRail = relatedRail;

		// Token: 0x040249B9 RID: 149945
		public bool IsFinishMove;

		// Token: 0x040249BA RID: 149946
		public bool IsFinishMoveOnFailure;
	}
}
