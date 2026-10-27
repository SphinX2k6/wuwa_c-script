using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002932 RID: 10546
[NullableContext(1)]
[Nullable(0)]
public class AngleCalculator : IStaticVariableResetter
{
	// Token: 0x06015C21 RID: 89121 RVA: 0x0057D02A File Offset: 0x0057B22A
	static AngleCalculator()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AngleCalculator.CreateStaticDefaultValue), new Action(AngleCalculator.ResetStaticDefaultValue));
	}

	// Token: 0x06015C22 RID: 89122 RVA: 0x0057D049 File Offset: 0x0057B249
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

	// Token: 0x06015C23 RID: 89123 RVA: 0x0057D062 File Offset: 0x0057B262
	public static void ResetStaticDefaultValue()
	{
		AngleCalculator.AngleList = null;
	}

	// Token: 0x06015C24 RID: 89124 RVA: 0x0057D06C File Offset: 0x0057B26C
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

	// Token: 0x06015C25 RID: 89125 RVA: 0x0057D0C4 File Offset: 0x0057B2C4
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

	// Token: 0x06015C26 RID: 89126 RVA: 0x0057D114 File Offset: 0x0057B314
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

	// Token: 0x0400A21A RID: 41498
	public static double[] AngleList;
}
