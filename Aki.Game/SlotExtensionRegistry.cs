using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001BD0 RID: 7120
[NullableContext(1)]
[Nullable(0)]
public class SlotExtensionRegistry
{
	// Token: 0x0600D454 RID: 54356 RVA: 0x0030DCA0 File Offset: 0x0030BEA0
	[return: Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public static UniTask<List<ISlotExtension>> AttachAll(ISlotMountPoint mount, int position)
	{
		SlotExtensionRegistry.<AttachAll>d__0 <AttachAll>d__;
		<AttachAll>d__.<>t__builder = AsyncUniTaskMethodBuilder<List<ISlotExtension>>.Create();
		<AttachAll>d__.mount = mount;
		<AttachAll>d__.position = position;
		<AttachAll>d__.<>1__state = -1;
		<AttachAll>d__.<>t__builder.Start<SlotExtensionRegistry.<AttachAll>d__0>(ref <AttachAll>d__);
		return <AttachAll>d__.<>t__builder.Task;
	}

	// Token: 0x0600D455 RID: 54357 RVA: 0x0030DCEC File Offset: 0x0030BEEC
	private static UniTask SafeAttach(ISlotExtension ext, ISlotMountPoint mount, int position)
	{
		SlotExtensionRegistry.<SafeAttach>d__1 <SafeAttach>d__;
		<SafeAttach>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SafeAttach>d__.ext = ext;
		<SafeAttach>d__.mount = mount;
		<SafeAttach>d__.position = position;
		<SafeAttach>d__.<>1__state = -1;
		<SafeAttach>d__.<>t__builder.Start<SlotExtensionRegistry.<SafeAttach>d__1>(ref <SafeAttach>d__);
		return <SafeAttach>d__.<>t__builder.Task;
	}

	// Token: 0x0600D456 RID: 54358 RVA: 0x0030DD40 File Offset: 0x0030BF40
	public static void DetachAll(List<ISlotExtension> extensions)
	{
		foreach (ISlotExtension slotExtension in extensions)
		{
			try
			{
				slotExtension.OnDetach();
			}
			catch (Exception item)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Formation;
				ELogAuthor author = ELogAuthor.SYB;
				string message = "[SlotExtensionRegistry.DetachAll] OnDetach failed";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("err", item);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}
	}

	// Token: 0x0600D457 RID: 54359 RVA: 0x0030DDC4 File Offset: 0x0030BFC4
	public static void InvokeRefresh(List<ISlotExtension> extensions, IRoleSlotDisplayData data)
	{
		foreach (ISlotExtension slotExtension in extensions)
		{
			try
			{
				slotExtension.OnRefresh(data);
			}
			catch (Exception item)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Formation;
				ELogAuthor author = ELogAuthor.SYB;
				string message = "[SlotExtensionRegistry.InvokeRefresh] OnRefresh failed";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("err", item);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}
	}

	// Token: 0x0600D458 RID: 54360 RVA: 0x0030DE4C File Offset: 0x0030C04C
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public static UUIItem[] QueryGuideItem(List<ISlotExtension> extensions, string[] configParams)
	{
		foreach (ISlotExtension slotExtension in extensions)
		{
			UUIItem[] array = slotExtension.QueryGuideItem(configParams);
			if (array != null)
			{
				return array;
			}
		}
		return null;
	}

	// Token: 0x0600D459 RID: 54361 RVA: 0x0030DEA4 File Offset: 0x0030C0A4
	public static void InvokeStartMove(List<ISlotExtension> extensions)
	{
		foreach (ISlotExtension slotExtension in extensions)
		{
			try
			{
				slotExtension.OnSlotStartMove();
			}
			catch (Exception item)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Formation;
				ELogAuthor author = ELogAuthor.SYB;
				string message = "[SlotExtensionRegistry.InvokeStartMove] OnSlotStartMove failed";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("err", item);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}
	}

	// Token: 0x0600D45A RID: 54362 RVA: 0x0030DF28 File Offset: 0x0030C128
	public static void InvokeStopMove(List<ISlotExtension> extensions)
	{
		foreach (ISlotExtension slotExtension in extensions)
		{
			try
			{
				slotExtension.OnSlotStopMove();
			}
			catch (Exception item)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Formation;
				ELogAuthor author = ELogAuthor.SYB;
				string message = "[SlotExtensionRegistry.InvokeStopMove] OnSlotStopMove failed";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("err", item);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}
	}
}
