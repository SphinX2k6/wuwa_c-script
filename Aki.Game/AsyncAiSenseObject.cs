using System;
using Aki.Config;
using CSharpScript.Core.Model;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020000FA RID: 250
public class AsyncAiSenseObject
{
	// Token: 0x17000265 RID: 613
	// (get) Token: 0x06000E1C RID: 3612 RVA: 0x000510A7 File Offset: 0x0004F2A7
	public static int Size
	{
		get
		{
			return sizeof(FAiSenseObject);
		}
	}

	// Token: 0x17000266 RID: 614
	// (get) Token: 0x06000E1D RID: 3613 RVA: 0x000510AF File Offset: 0x0004F2AF
	public static int MinAlignment
	{
		get
		{
			return 4;
		}
	}

	// Token: 0x06000E1E RID: 3614 RVA: 0x000510B4 File Offset: 0x0004F2B4
	public unsafe AsyncAiSenseObject(AiSense AiSense)
	{
		this.AiSenseObjectData = (FAiSenseObject*)BuiltinUtils.Malloc((UIntPtr)((IntPtr)AsyncAiSenseObject.Size), (uint)AsyncAiSenseObject.MinAlignment);
		this.AiSense = AiSense;
		this.AiSenseObjectData->AiSenseId = AiSense.Id;
		this.AiSenseObjectData->AiSenseHorizontalAngle = new FVector2D(AiSense.HorizontalAngle.Value.Min, AiSense.HorizontalAngle.Value.Max);
		this.AiSenseObjectData->AiSenseVerticalAngle = new FVector2D(AiSense.VerticalAngle.Value.Min, AiSense.VerticalAngle.Value.Max);
		this.AiSenseObjectData->AiSenseCantBeBlock = AiSense.CantBeBlock;
		this.AiSenseObjectData->AiSenseBlockType = AiSense.BlockType;
		this.AiSenseObjectData->WithAngleHorizontal = (AiSense.HorizontalAngle.Value.Min > -180f || AiSense.HorizontalAngle.Value.Max < 180f);
		this.AiSenseObjectData->WithAngleVertical = (AiSense.VerticalAngle.Value.Min > -90f || AiSense.VerticalAngle.Value.Max < 90f);
		this.AiSenseObjectData->SenseDistanceRangeMin = AiSense.SenseDistanceRange.Value.Min;
		this.AiSenseObjectData->SenseDistanceRangeMax = AiSense.SenseDistanceRange.Value.Max;
		this.AiSenseObjectData->SquaredWalkSenseRate = AiSense.WalkSenseRate * AiSense.WalkSenseRate;
		this.AiSenseObjectData->SquaredAirSenseRate = AiSense.AirSenseRate * AiSense.AirSenseRate;
	}

	// Token: 0x06000E1F RID: 3615 RVA: 0x000512A4 File Offset: 0x0004F4A4
	unsafe ~AsyncAiSenseObject()
	{
		if (this.AiSenseObjectData != null)
		{
			BuiltinUtils.Free((void*)this.AiSenseObjectData);
			this.AiSenseObjectData = null;
		}
	}

	// Token: 0x06000E20 RID: 3616 RVA: 0x000512E8 File Offset: 0x0004F4E8
	public unsafe void Clear()
	{
		if (this.AiPerceptionDataHandle != 0)
		{
			FKuroJsModelCSharpInterface.RemoveActivateAiSenseObjects(this.AiPerceptionDataHandle, (byte)this.AiSense.SenseTarget, (void*)this.AiSenseObjectData);
			this.AiPerceptionDataHandle = 0;
		}
	}

	// Token: 0x04000B7F RID: 2943
	public unsafe FAiSenseObject* AiSenseObjectData;

	// Token: 0x04000B80 RID: 2944
	public int AiPerceptionDataHandle;

	// Token: 0x04000B81 RID: 2945
	private const float MINUS_HALF = -180f;

	// Token: 0x04000B82 RID: 2946
	private const float MINUS_QUATER = -90f;

	// Token: 0x04000B83 RID: 2947
	public readonly AiSense AiSense;
}
