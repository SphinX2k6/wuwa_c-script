using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Render.DebugDraw
{
	// Token: 0x02003520 RID: 13600
	public class DebugDrawManager : IStaticVariableResetter
	{
		// Token: 0x06022A08 RID: 141832 RVA: 0x009DA758 File Offset: 0x009D8958
		protected static void EnsureInstance()
		{
			if (DebugDrawManager.Instance != null)
			{
				return;
			}
			DebugDrawManager.Instance = new DebugDrawManager();
			DebugDrawManager.Instance.Counter = 0;
			DebugDrawManager.Instance.DebugDrawMap = new Dictionary<int, DebugDrawManager.EffectDebugDrawInfo>();
		}

		// Token: 0x06022A09 RID: 141833 RVA: 0x009DA788 File Offset: 0x009D8988
		[NullableContext(1)]
		public static int AddDebugLineFromPlayer(Vector toLocation, FLinearColor color, float width)
		{
			DebugDrawManager.EnsureInstance();
			DebugDrawManager.EffectDebugDrawInfo effectDebugDrawInfo = new DebugDrawManager.EffectDebugDrawInfo();
			effectDebugDrawInfo.Index = DebugDrawManager.Instance.Counter;
			effectDebugDrawInfo.Type = new DebugDrawManager.EEffectDebugDrawType?(DebugDrawManager.EEffectDebugDrawType.LineFromPlayer);
			effectDebugDrawInfo.VectorA = toLocation;
			effectDebugDrawInfo.ColorA = new FLinearColor?(color);
			effectDebugDrawInfo.NumberA = width;
			DebugDrawManager.Instance.DebugDrawMap.Add(effectDebugDrawInfo.Index, effectDebugDrawInfo);
			DebugDrawManager.Instance.Counter++;
			return effectDebugDrawInfo.Index;
		}

		// Token: 0x06022A0A RID: 141834 RVA: 0x009DA804 File Offset: 0x009D8A04
		public static int AddDebugBox(FBox box, FLinearColor color, float width)
		{
			DebugDrawManager.EnsureInstance();
			DebugDrawManager.EffectDebugDrawInfo effectDebugDrawInfo = new DebugDrawManager.EffectDebugDrawInfo();
			effectDebugDrawInfo.Index = DebugDrawManager.Instance.Counter;
			effectDebugDrawInfo.Type = new DebugDrawManager.EEffectDebugDrawType?(DebugDrawManager.EEffectDebugDrawType.Box);
			effectDebugDrawInfo.ColorA = new FLinearColor?(color);
			effectDebugDrawInfo.NumberA = width;
			effectDebugDrawInfo.BoxA = new FBox?(box);
			DebugDrawManager.Instance.DebugDrawMap.Add(effectDebugDrawInfo.Index, effectDebugDrawInfo);
			DebugDrawManager.Instance.Counter++;
			return effectDebugDrawInfo.Index;
		}

		// Token: 0x06022A0B RID: 141835 RVA: 0x009DA885 File Offset: 0x009D8A85
		public static void RemoveDebugDraw(int index)
		{
			if (DebugDrawManager.Instance == null)
			{
				return;
			}
			DebugDrawManager.Instance.DebugDrawMap.Remove(index);
		}

		// Token: 0x06022A0C RID: 141836 RVA: 0x009DA8A0 File Offset: 0x009D8AA0
		public static void ClearDebugDraw()
		{
			if (DebugDrawManager.Instance == null)
			{
				return;
			}
			DebugDrawManager.Instance.DebugDrawMap.Clear();
		}

		// Token: 0x06022A0D RID: 141837 RVA: 0x009DA8B9 File Offset: 0x009D8AB9
		public static void Initialize()
		{
		}

		// Token: 0x06022A0E RID: 141838 RVA: 0x009DA8BC File Offset: 0x009D8ABC
		public static void Tick(float delta)
		{
			if (DebugDrawManager.Instance == null)
			{
				return;
			}
			float duration = 0.01f;
			foreach (KeyValuePair<int, DebugDrawManager.EffectDebugDrawInfo> keyValuePair in DebugDrawManager.Instance.DebugDrawMap)
			{
				DebugDrawManager.EffectDebugDrawInfo value = keyValuePair.Value;
				DebugDrawManager.EEffectDebugDrawType value2 = value.Type.Value;
				if (value2 != DebugDrawManager.EEffectDebugDrawType.LineFromPlayer)
				{
					if (value2 == DebugDrawManager.EEffectDebugDrawType.Box)
					{
						UObject world = GlobalData.World;
						FVector fvector = value.BoxA.Value.Min + value.BoxA.Value.Max;
						FVectorDouble center = UKismetMathLibrary.Conv_VectorToVectorDouble(fvector / 2f);
						FVector fvector2 = value.BoxA.Value.Max - value.BoxA.Value.Min;
						UKismetSystemLibrary.D_DrawDebugBox(world, center, UKismetMathLibrary.Conv_VectorToVectorDouble(fvector2 / 2f), value.ColorA.Value, default(FRotator), duration, value.NumberA);
					}
				}
				else
				{
					UKismetSystemLibrary.D_DrawDebugLine(GlobalData.World, RenderDataManager.Instance.GetCurrentCharacterPosition().ToUeVector(false), value.VectorA.ToUeVector(false), value.ColorA.Value, duration, value.NumberA);
				}
			}
		}

		// Token: 0x06022A0F RID: 141839 RVA: 0x009DAA34 File Offset: 0x009D8C34
		public static void Destroy()
		{
			if (DebugDrawManager.Instance == null)
			{
				return;
			}
			DebugDrawManager.Instance = null;
		}

		// Token: 0x06022A10 RID: 141840 RVA: 0x009DAA44 File Offset: 0x009D8C44
		static DebugDrawManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(DebugDrawManager.CreateStaticDefaultValue), new Action(DebugDrawManager.ResetStaticDefaultValue));
		}

		// Token: 0x06022A11 RID: 141841 RVA: 0x009DAA63 File Offset: 0x009D8C63
		public static void CreateStaticDefaultValue()
		{
			DebugDrawManager.Instance = null;
		}

		// Token: 0x06022A12 RID: 141842 RVA: 0x009DAA6B File Offset: 0x009D8C6B
		public static void ResetStaticDefaultValue()
		{
			DebugDrawManager.Instance = null;
		}

		// Token: 0x040132E2 RID: 78562
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected Dictionary<int, DebugDrawManager.EffectDebugDrawInfo> DebugDrawMap;

		// Token: 0x040132E3 RID: 78563
		protected int Counter;

		// Token: 0x040132E4 RID: 78564
		[Nullable(2)]
		protected static DebugDrawManager Instance;

		// Token: 0x020091FB RID: 37371
		public enum EEffectDebugDrawType
		{
			// Token: 0x0402DB28 RID: 187176
			LineFromPlayer,
			// Token: 0x0402DB29 RID: 187177
			Box
		}

		// Token: 0x020091FC RID: 37372
		public class EffectDebugDrawInfo
		{
			// Token: 0x0402DB2A RID: 187178
			public int Index;

			// Token: 0x0402DB2B RID: 187179
			public DebugDrawManager.EEffectDebugDrawType? Type;

			// Token: 0x0402DB2C RID: 187180
			[Nullable(2)]
			public Vector VectorA;

			// Token: 0x0402DB2D RID: 187181
			public FLinearColor? ColorA;

			// Token: 0x0402DB2E RID: 187182
			public float NumberA;

			// Token: 0x0402DB2F RID: 187183
			public FBox? BoxA;
		}
	}
}
