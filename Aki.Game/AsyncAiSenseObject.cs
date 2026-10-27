using System;
using Aki.Config;
using CSharpScript.Core.Model;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020000FA RID: 250
public class AsyncAiSenseObject
{
	// Token: 0x17000262 RID: 610
	// (get) Token: 0x06000E16 RID: 3606 RVA: 0x00050517 File Offset: 0x0004E717
	public static int Size
	{
		get
		{
			return sizeof(FAiSenseObject);
		}
	}

	// Token: 0x17000263 RID: 611
	// (get) Token: 0x06000E17 RID: 3607 RVA: 0x0005051F File Offset: 0x0004E71F
	public static int MinAlignment
	{
		get
		{
			return 4;
		}
	}

	// Token: 0x06000E18 RID: 3608 RVA: 0x00050524 File Offset: 0x0004E724
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

	// Token: 0x06000E19 RID: 3609 RVA: 0x00050714 File Offset: 0x0004E914
	unsafe ~AsyncAiSenseObject()
	{
		if (this.AiSenseObjectData != null)
		{
			BuiltinUtils.Free((void*)this.AiSenseObjectData);
			this.AiSenseObjectData = null;
		}
	}

	// Token: 0x06000E1A RID: 3610 RVA: 0x00050758 File Offset: 0x0004E958
	public unsafe void Clear()
	{
		if (this.AiPerceptionDataHandle != 0)
		{
			FKuroJsModelCSharpInterface.RemoveActivateAiSenseObjects(this.AiPerceptionDataHandle, (byte)this.AiSense.SenseTarget, (void*)this.AiSenseObjectData);
			this.AiPerceptionDataHandle = 0;
		}
	}

	// Token: 0x04000B77 RID: 2935
	public unsafe FAiSenseObject* AiSenseObjectData;

	// Token: 0x04000B78 RID: 2936
	public int AiPerceptionDataHandle;

	// Token: 0x04000B79 RID: 2937
	private const float MINUS_HALF = -180f;

	// Token: 0x04000B7A RID: 2938
	private const float MINUS_QUATER = -90f;

	// Token: 0x04000B7B RID: 2939
	public readonly AiSense AiSense;
}
