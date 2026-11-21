using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Structures;
using CSharpScript.Game.Input;

// Token: 0x02002622 RID: 9762
[NullableContext(2)]
[Nullable(0)]
public class PanoramicInputLayer : InputLayer
{
	// Token: 0x06018608 RID: 99848 RVA: 0x0075B6CB File Offset: 0x007598CB
	public void Init()
	{
	}

	// Token: 0x06018609 RID: 99849 RVA: 0x0075B6CD File Offset: 0x007598CD
	public override EInputLayer GetLayerType()
	{
		return EInputLayer.Panoramic;
	}

	// Token: 0x0601860A RID: 99850 RVA: 0x0075B6D4 File Offset: 0x007598D4
	public override SInputCommand HandleRelease(EInputAction action, float time)
	{
		if (action == 13)
		{
			Log.Instance.Info(ELogModule.Panoramic, ELogAuthor.JYS, "[环视] HandleRelease1 锁定目标 HandleRelease", default(ReadOnlySpan<ValueTuple<string, object>>));
			return InputLayer.GetSwallowCommand();
		}
		return null;
	}

	// Token: 0x0601860B RID: 99851 RVA: 0x0075B711 File Offset: 0x00759911
	public override SInputCommand HandlePress(EInputAction action, float time)
	{
		if (action == 13)
		{
			PanoramicController.Instance.InteractPawn();
			return InputLayer.GetSwallowCommand();
		}
		return null;
	}

	// Token: 0x0601860C RID: 99852 RVA: 0x0075B72E File Offset: 0x0075992E
	public override SInputCommand HandleHold(EInputAction action, float time)
	{
		if (action == 13)
		{
			return InputLayer.GetSwallowCommand();
		}
		return null;
	}

	// Token: 0x0601860D RID: 99853 RVA: 0x0075B744 File Offset: 0x00759944
	public override bool DispatchPressEvent(EInputAction action, float time)
	{
		if (action == 13)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Panoramic;
			ELogAuthor author = ELogAuthor.WWJ;
			string message = "[环视] 忽略DispatchPressEvent事件";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("action", action);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return true;
		}
		return false;
	}

	// Token: 0x0601860E RID: 99854 RVA: 0x0075B790 File Offset: 0x00759990
	public override bool DispatchReleaseEvent(EInputAction action, float time)
	{
		if (action == 13)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Panoramic;
			ELogAuthor author = ELogAuthor.WWJ;
			string message = "[环视] 忽略DispatchReleaseEvent事件";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("action", action);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return true;
		}
		return false;
	}
}
