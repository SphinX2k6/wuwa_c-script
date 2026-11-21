using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.NewWorld.SceneItem;

namespace CSharpScript.Game.Module.MechanismTimeline.MechanismEvent
{
	// Token: 0x02004466 RID: 17510
	[NullableContext(1)]
	[Nullable(0)]
	public class MechanismEventFireBullet : MechanismEventBase
	{
		// Token: 0x0602C283 RID: 180867 RVA: 0x00C65F9E File Offset: 0x00C6419E
		public MechanismEventFireBullet(IMechanismEventInfo eventInfo, MechanismEventContext context, SceneItemEventListenerComponent eventListenerComponent, bool isServerAction) : base(eventInfo, context, eventListenerComponent, isServerAction)
		{
		}

		// Token: 0x0602C284 RID: 180868 RVA: 0x00C65FAC File Offset: 0x00C641AC
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

		// Token: 0x0602C285 RID: 180869 RVA: 0x00C6603C File Offset: 0x00C6423C
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

		// Token: 0x0602C286 RID: 180870 RVA: 0x00C660C9 File Offset: 0x00C642C9
		protected override void OnEnd(ActionParams @params)
		{
			this.EventListenerComponent.DestroyBullet(this.BulletEntityId);
		}

		// Token: 0x04017C5E RID: 97374
		public int BulletEntityId;
	}
}
