using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200108F RID: 4239
[NullableContext(1)]
[Nullable(0)]
public class SlotExtensionRegistry
{
	// Token: 0x0600A866 RID: 43110 RVA: 0x00318E14 File Offset: 0x00317014
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

	// Token: 0x0600A867 RID: 43111 RVA: 0x00318E60 File Offset: 0x00317060
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

	// Token: 0x0600A868 RID: 43112 RVA: 0x00318EB4 File Offset: 0x003170B4
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

	// Token: 0x0600A869 RID: 43113 RVA: 0x00318F38 File Offset: 0x00317138
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

	// Token: 0x0600A86A RID: 43114 RVA: 0x00318FC0 File Offset: 0x003171C0
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

	// Token: 0x0600A86B RID: 43115 RVA: 0x00319018 File Offset: 0x00317218
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

	// Token: 0x0600A86C RID: 43116 RVA: 0x0031909C File Offset: 0x0031729C
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
