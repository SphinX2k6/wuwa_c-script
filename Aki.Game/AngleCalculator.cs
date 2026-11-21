using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001EAD RID: 7853
[NullableContext(1)]
[Nullable(0)]
public class AngleCalculator : IStaticVariableResetter
{
	// Token: 0x06013626 RID: 79398 RVA: 0x005A806A File Offset: 0x005A626A
	static AngleCalculator()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AngleCalculator.CreateStaticDefaultValue), new Action(AngleCalculator.ResetStaticDefaultValue));
	}

	// Token: 0x06013627 RID: 79399 RVA: 0x005A8089 File Offset: 0x005A6289
	public static void CreateStaticDefaultValue()
	{
		AngleCalculator.AngleList = new double[]
		{
			-180.0,
			-157.5,
			-112.5,
			-67.5,
			-22.5,
			22.5,
			67.5,
			112.5,
			157.5,
			180.0
		};
	}

	// Token: 0x06013628 RID: 79400 RVA: 0x005A80A2 File Offset: 0x005A62A2
	public static void ResetStaticDefaultValue()
	{
		AngleCalculator.AngleList = null;
	}

	// Token: 0x06013629 RID: 79401 RVA: 0x005A80AC File Offset: 0x005A62AC
	public static float GetVectorAngle(Vector aVector, Vector bVector)
	{
		Vector vector = Vector.Create();
		Vector.CrossProduct(aVector, bVector, vector);
		float num = UKismetMathLibrary.DegAcos((float)(MathUtils.Instance.DotProduct(aVector, bVector) / (aVector.Size() * bVector.Size())));
		if (vector.Z > 0.0)
		{
			return num * -1f;
		}
		return num;
	}

	// Token: 0x0601362A RID: 79402 RVA: 0x005A8104 File Offset: 0x005A6304
	public static int AngleToAreaIndex(double angle)
	{
		int num = AngleCalculator.AngleList.Length - 2;
		int i = 0;
		while (i < AngleCalculator.AngleList.Length - 1)
		{
			if (AngleCalculator.AngleList[i] <= angle && angle < AngleCalculator.AngleList[i + 1])
			{
				int num2 = num - i;
				if (num2 != 0)
				{
					return num2;
				}
				return num;
			}
			else
			{
				i++;
			}
		}
		return num;
	}

	// Token: 0x0601362B RID: 79403 RVA: 0x005A8154 File Offset: 0x005A6354
	public static Vector2D ConvertLguiPosToScreenPos(double x, double y)
	{
		UUIItem uiRootItem = UiLayer.Instance.UiRootItem;
		Vector2D vector2D = Vector2D.Create(x, y);
		ULGUICanvasScaler canvasScaler = UiLayer.Instance.UiRootItem.GetCanvasScaler();
		FVector2D fvector2D = vector2D.ToUeVector2D(false);
		FVector2D fvector2D2 = canvasScaler.ConvertPositionFromLGUICanvasToViewport(fvector2D);
		fvector2D2.X = MathCommon.Clamp(fvector2D2.X, 0f, uiRootItem.GetWidth());
		fvector2D2.Y = MathCommon.Clamp(fvector2D2.Y, 0f, uiRootItem.GetHeight());
		return new Vector2D((double)fvector2D2.X, (double)fvector2D2.Y);
	}

	// Token: 0x0400A605 RID: 42501
	public static double[] AngleList;
}
