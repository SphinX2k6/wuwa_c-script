using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.NewWorld.SceneItem.CurveControl
{
	// Token: 0x020062BE RID: 25278
	[NullableContext(1)]
	[Nullable(0)]
	public class CurveControlBase
	{
		// Token: 0x17007381 RID: 29569
		// (get) Token: 0x0603D087 RID: 249991 RVA: 0x0118D9D2 File Offset: 0x0118BBD2
		public ECurveControlStage CurStage
		{
			get
			{
				return this.Stage;
			}
		}

		// Token: 0x0603D088 RID: 249992 RVA: 0x0118D9DA File Offset: 0x0118BBDA
		public void SetAllTime(float startTime, float loopTime, float endTime)
		{
			this.StartTime = startTime;
			this.LoopTime = loopTime;
			this.EndTime = endTime;
		}

		// Token: 0x0603D089 RID: 249993 RVA: 0x0118D9F1 File Offset: 0x0118BBF1
		public void Init(Entity entity, CurveControlComponent config)
		{
			this.Stage = ECurveControlStage.Start;
			this.CurTime = 0f;
			this.Entity = entity;
			this.OnInit(config);
		}

		// Token: 0x0603D08A RID: 249994 RVA: 0x0118DA13 File Offset: 0x0118BC13
		public void Start()
		{
			this.Stage = ECurveControlStage.Start;
			this.CurTime = 0f;
			this.OnStart();
		}

		// Token: 0x0603D08B RID: 249995 RVA: 0x0118DA30 File Offset: 0x0118BC30
		public unsafe void Stop(bool immediately = false)
		{
			if (immediately)
			{
				this.Stage = ECurveControlStage.Stopped;
				this.CurTime = this.StartTime + this.LoopTime + this.EndTime;
			}
			else
			{
				this.Stage = ECurveControlStage.End;
				this.CurTime = this.StartTime + this.LoopTime;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SceneItemCurveControl;
			ELogAuthor author = ELogAuthor.CH;
			string message = "[CurveControlBase.Stop]";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Stage", this.Stage);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Time", this.CurTime);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}

		// Token: 0x0603D08C RID: 249996 RVA: 0x0118DAE8 File Offset: 0x0118BCE8
		public bool Tick(float delta)
		{
			if (!this.TickStage(delta))
			{
				return false;
			}
			switch (this.Stage)
			{
			case ECurveControlStage.Start:
				this.TickStartStage();
				break;
			case ECurveControlStage.Loop:
				this.TickLoopStage();
				break;
			case ECurveControlStage.End:
				this.TickEndStage();
				break;
			}
			return true;
		}

		// Token: 0x0603D08D RID: 249997 RVA: 0x0118DB38 File Offset: 0x0118BD38
		protected unsafe bool TickStage(float delta)
		{
			this.CurTime += delta;
			if (this.CurTime < this.StartTime)
			{
				this.Stage = ECurveControlStage.Start;
			}
			else if (this.CurTime > this.StartTime && this.CurTime < this.StartTime + this.LoopTime)
			{
				this.Stage = ECurveControlStage.Loop;
			}
			else
			{
				if (this.CurTime <= this.StartTime + this.LoopTime || this.CurTime >= this.StartTime + this.LoopTime + this.EndTime)
				{
					this.Stage = ECurveControlStage.Stopped;
					return false;
				}
				this.Stage = ECurveControlStage.End;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SceneItemCurveControl;
			ELogAuthor author = ELogAuthor.CH;
			string message = "[CurveControlBase.TickStage]";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Stage", this.Stage);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Time", this.CurTime);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return true;
		}

		// Token: 0x0603D08E RID: 249998 RVA: 0x0118DC44 File Offset: 0x0118BE44
		protected virtual void TickStartStage()
		{
		}

		// Token: 0x0603D08F RID: 249999 RVA: 0x0118DC46 File Offset: 0x0118BE46
		protected virtual void TickLoopStage()
		{
		}

		// Token: 0x0603D090 RID: 250000 RVA: 0x0118DC48 File Offset: 0x0118BE48
		protected virtual void TickEndStage()
		{
		}

		// Token: 0x0603D091 RID: 250001 RVA: 0x0118DC4A File Offset: 0x0118BE4A
		protected virtual void OnInit(CurveControlComponent config)
		{
		}

		// Token: 0x0603D092 RID: 250002 RVA: 0x0118DC4C File Offset: 0x0118BE4C
		protected virtual void OnStart()
		{
		}

		// Token: 0x0603D093 RID: 250003 RVA: 0x0118DC4E File Offset: 0x0118BE4E
		public bool IsStop()
		{
			return this.Stage == ECurveControlStage.End || this.Stage == ECurveControlStage.Stopped;
		}

		// Token: 0x040205DF RID: 132575
		private ECurveControlStage Stage;

		// Token: 0x040205E0 RID: 132576
		[Nullable(2)]
		protected Entity Entity;

		// Token: 0x040205E1 RID: 132577
		protected float StartTime;

		// Token: 0x040205E2 RID: 132578
		protected float LoopTime;

		// Token: 0x040205E3 RID: 132579
		protected float EndTime;

		// Token: 0x040205E4 RID: 132580
		protected float CurTime;
	}
}
