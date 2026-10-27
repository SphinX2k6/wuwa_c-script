using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.NewWorld.SceneItem;

namespace CSharpScript.Game.Module.MechanismTimeline.MechanismEvent
{
	// Token: 0x02005483 RID: 21635
	[NullableContext(1)]
	[Nullable(0)]
	public class MechanismEventFireBullet : MechanismEventBase
	{
		// Token: 0x0603733A RID: 226106 RVA: 0x00D16B46 File Offset: 0x00D14D46
		public MechanismEventFireBullet(IMechanismEventInfo eventInfo, MechanismEventContext context, SceneItemEventListenerComponent eventListenerComponent, bool isServerAction) : base(eventInfo, context, eventListenerComponent, isServerAction)
		{
		}

		// Token: 0x0603733B RID: 226107 RVA: 0x00D16B54 File Offset: 0x00D14D54
		protected unsafe override void OnTrigger(ActionParams @params)
		{
			SeqEventFireBullet seqEventFireBullet = @params as SeqEventFireBullet;
			if (seqEventFireBullet == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.LevelEvent;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "MechanismEventFireBullet.参数类型错误";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("context", this.Context);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("eventName", base.EventName);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			this.BulletEntityId = this.EventListenerComponent.CreateBullet(seqEventFireBullet, base.EventName);
		}

		// Token: 0x0603733C RID: 226108 RVA: 0x00D16BE4 File Offset: 0x00D14DE4
		protected unsafe override void OnStart(ActionParams @params)
		{
			SeqEventFireBullet seqEventFireBullet = @params as SeqEventFireBullet;
			if (seqEventFireBullet == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.LevelEvent;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "MechanismEventFireBullet.参数类型错误";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("context", this.Context);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("eventName", base.EventName);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			this.BulletEntityId = this.EventListenerComponent.CreateBullet(seqEventFireBullet, base.EventName);
		}

		// Token: 0x0603733D RID: 226109 RVA: 0x00D16C71 File Offset: 0x00D14E71
		protected override void OnEnd(ActionParams @params)
		{
			this.EventListenerComponent.DestroyBullet(this.BulletEntityId);
		}

		// Token: 0x0401D1C5 RID: 119237
		public int BulletEntityId;
	}
}
