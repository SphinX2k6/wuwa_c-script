using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Structures;
using CSharpScript.Game.Input;

// Token: 0x020030CA RID: 12490
[NullableContext(2)]
[Nullable(0)]
public class PanoramicInputLayer : InputLayer
{
	// Token: 0x0601ABF4 RID: 109556 RVA: 0x00735A2F File Offset: 0x00733C2F
	public void Init()
	{
	}

	// Token: 0x0601ABF5 RID: 109557 RVA: 0x00735A31 File Offset: 0x00733C31
	public override EInputLayer GetLayerType()
	{
		return EInputLayer.Panoramic;
	}

	// Token: 0x0601ABF6 RID: 109558 RVA: 0x00735A38 File Offset: 0x00733C38
	public override SInputCommand HandleRelease(EInputAction action, float time)
	{
		if (action == 13)
		{
			Log.Instance.Info(ELogModule.Panoramic, ELogAuthor.JYS, "[环视] HandleRelease1 锁定目标 HandleRelease", default(ReadOnlySpan<ValueTuple<string, object>>));
			return InputLayer.GetSwallowCommand();
		}
		return null;
	}

	// Token: 0x0601ABF7 RID: 109559 RVA: 0x00735A75 File Offset: 0x00733C75
	public override SInputCommand HandlePress(EInputAction action, float time)
	{
		if (action == 13)
		{
			PanoramicController.Instance.InteractPawn();
			return InputLayer.GetSwallowCommand();
		}
		return null;
	}

	// Token: 0x0601ABF8 RID: 109560 RVA: 0x00735A92 File Offset: 0x00733C92
	public override SInputCommand HandleHold(EInputAction action, float time)
	{
		if (action == 13)
		{
			return InputLayer.GetSwallowCommand();
		}
		return null;
	}

	// Token: 0x0601ABF9 RID: 109561 RVA: 0x00735AA8 File Offset: 0x00733CA8
	public override bool CheckBlockDispatchEvent(EInputAction action)
	{
		bool result = false;
		if (action == 13)
		{
			result = true;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Panoramic;
		ELogAuthor author = ELogAuthor.JYS;
		string message = "[环视] 忽略DispatchEvent事件";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("action", action);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return result;
	}
}
