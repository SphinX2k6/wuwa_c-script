using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.Character.Input.Enum;
using CSharpScript.Game.Input;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B2C RID: 27436
	public class LevelEventFakePlayerInput : LevelEventBase
	{
		// Token: 0x06044115 RID: 278805 RVA: 0x010BC874 File Offset: 0x010BAA74
		public LevelEventFakePlayerInput(int id) : base(id)
		{
		}

		// Token: 0x06044116 RID: 278806 RVA: 0x010BC880 File Offset: 0x010BAA80
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			if (inParams == null)
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.CH, "[LevelEventFakePlayerInput] 参数配置错误", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			this.Params = (inParams as PlayerInput);
			CSharpScript.Game.Input.EInputAction einputAction = CSharpScript.Game.Input.EInputAction.None;
			switch (this.Params.Input)
			{
			case EPlayerInputType.跳跃:
				einputAction = CSharpScript.Game.Input.EInputAction.跳跃;
				break;
			case EPlayerInputType.攻击:
				einputAction = CSharpScript.Game.Input.EInputAction.攻击;
				break;
			case EPlayerInputType.闪避:
				einputAction = CSharpScript.Game.Input.EInputAction.闪避;
				break;
			case EPlayerInputType.技能1:
				einputAction = CSharpScript.Game.Input.EInputAction.技能1;
				break;
			case EPlayerInputType.幻象1:
				einputAction = CSharpScript.Game.Input.EInputAction.幻象1;
				break;
			case EPlayerInputType.大招:
				einputAction = CSharpScript.Game.Input.EInputAction.大招;
				break;
			case EPlayerInputType.幻象2:
				einputAction = CSharpScript.Game.Input.EInputAction.幻象2;
				break;
			}
			if (einputAction == CSharpScript.Game.Input.EInputAction.None)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.LevelEvent;
				ELogAuthor author = ELogAuthor.CH;
				string message = "[LevelEventFakePlayerInput] 未知的输入类型";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Input", this.Params.Input);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			InputController.Instance.InputAction(einputAction, EInputState.Press);
			InputController.Instance.InputAction(einputAction, EInputState.Release);
		}

		// Token: 0x040238FC RID: 145660
		[Nullable(2)]
		private PlayerInput Params;
	}
}
