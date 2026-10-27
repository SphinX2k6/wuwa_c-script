using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.NewWorld.SceneItem.CurveControl
{
	// Token: 0x02007209 RID: 29193
	[NullableContext(1)]
	[Nullable(0)]
	public class CurveControlBase
	{
		// Token: 0x17009E1B RID: 40475
		// (get) Token: 0x06047776 RID: 292726 RVA: 0x01233F43 File Offset: 0x01232143
		public ECurveControlStage CurStage
		{
			get
			{
				return this.Stage;
			}
		}

		// Token: 0x06047777 RID: 292727 RVA: 0x01233F4B File Offset: 0x0123214B
		public void SetAllTime(float startTime, float loopTime, float endTime)
		{
			this.StartTime = startTime;
			this.LoopTime = loopTime;
			this.EndTime = endTime;
		}

		// Token: 0x06047778 RID: 292728 RVA: 0x01233F62 File Offset: 0x01232162
		public void Init(Entity entity, CurveControlComponent config)
		{
			this.Stage = ECurveControlStage.Start;
			this.CurTime = 0f;
			this.Entity = entity;
			this.OnInit(config);
		}

		// Token: 0x06047779 RID: 292729 RVA: 0x01233F84 File Offset: 0x01232184
		public void Start()
		{
			this.Stage = ECurveControlStage.Start;
			this.CurTime = 0f;
			this.OnStart();
		}

		// Token: 0x0604777A RID: 292730 RVA: 0x01233FA0 File Offset: 0x012321A0
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

		// Token: 0x0604777B RID: 292731 RVA: 0x01234058 File Offset: 0x01232258
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

		// Token: 0x0604777C RID: 292732 RVA: 0x012340A8 File Offset: 0x012322A8
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

		// Token: 0x0604777D RID: 292733 RVA: 0x012341B4 File Offset: 0x012323B4
		protected virtual void TickStartStage()
		{
		}

		// Token: 0x0604777E RID: 292734 RVA: 0x012341B6 File Offset: 0x012323B6
		protected virtual void TickLoopStage()
		{
		}

		// Token: 0x0604777F RID: 292735 RVA: 0x012341B8 File Offset: 0x012323B8
		protected virtual void TickEndStage()
		{
		}

		// Token: 0x06047780 RID: 292736 RVA: 0x012341BA File Offset: 0x012323BA
		protected virtual void OnInit(CurveControlComponent config)
		{
		}

		// Token: 0x06047781 RID: 292737 RVA: 0x012341BC File Offset: 0x012323BC
		protected virtual void OnStart()
		{
		}

		// Token: 0x06047782 RID: 292738 RVA: 0x012341BE File Offset: 0x012323BE
		public bool IsStop()
		{
			return this.Stage == ECurveControlStage.End || this.Stage == ECurveControlStage.Stopped;
		}

		// Token: 0x04025970 RID: 153968
		private ECurveControlStage Stage;

		// Token: 0x04025971 RID: 153969
		[Nullable(2)]
		protected Entity Entity;

		// Token: 0x04025972 RID: 153970
		protected float StartTime;

		// Token: 0x04025973 RID: 153971
		protected float LoopTime;

		// Token: 0x04025974 RID: 153972
		protected float EndTime;

		// Token: 0x04025975 RID: 153973
		protected float CurTime;
	}
}
