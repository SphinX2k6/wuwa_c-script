using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Render.DebugDraw
{
	// Token: 0x020045F7 RID: 17911
	public class DebugDrawManager : IStaticVariableResetter
	{
		// Token: 0x0602E313 RID: 189203 RVA: 0x00AAE064 File Offset: 0x00AAC264
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

		// Token: 0x0602E314 RID: 189204 RVA: 0x00AAE094 File Offset: 0x00AAC294
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

		// Token: 0x0602E315 RID: 189205 RVA: 0x00AAE110 File Offset: 0x00AAC310
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

		// Token: 0x0602E316 RID: 189206 RVA: 0x00AAE191 File Offset: 0x00AAC391
		public static void RemoveDebugDraw(int index)
		{
			if (DebugDrawManager.Instance == null)
			{
				return;
			}
			DebugDrawManager.Instance.DebugDrawMap.Remove(index);
		}

		// Token: 0x0602E317 RID: 189207 RVA: 0x00AAE1AC File Offset: 0x00AAC3AC
		public static void ClearDebugDraw()
		{
			if (DebugDrawManager.Instance == null)
			{
				return;
			}
			DebugDrawManager.Instance.DebugDrawMap.Clear();
		}

		// Token: 0x0602E318 RID: 189208 RVA: 0x00AAE1C5 File Offset: 0x00AAC3C5
		public static void Initialize()
		{
		}

		// Token: 0x0602E319 RID: 189209 RVA: 0x00AAE1C8 File Offset: 0x00AAC3C8
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

		// Token: 0x0602E31A RID: 189210 RVA: 0x00AAE340 File Offset: 0x00AAC540
		public static void Destroy()
		{
			if (DebugDrawManager.Instance == null)
			{
				return;
			}
			DebugDrawManager.Instance = null;
		}

		// Token: 0x0602E31B RID: 189211 RVA: 0x00AAE350 File Offset: 0x00AAC550
		static DebugDrawManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(DebugDrawManager.CreateStaticDefaultValue), new Action(DebugDrawManager.ResetStaticDefaultValue));
		}

		// Token: 0x0602E31C RID: 189212 RVA: 0x00AAE36F File Offset: 0x00AAC56F
		public static void CreateStaticDefaultValue()
		{
			DebugDrawManager.Instance = null;
		}

		// Token: 0x0602E31D RID: 189213 RVA: 0x00AAE377 File Offset: 0x00AAC577
		public static void ResetStaticDefaultValue()
		{
			DebugDrawManager.Instance = null;
		}

		// Token: 0x04018CA3 RID: 101539
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected Dictionary<int, DebugDrawManager.EffectDebugDrawInfo> DebugDrawMap;

		// Token: 0x04018CA4 RID: 101540
		protected int Counter;

		// Token: 0x04018CA5 RID: 101541
		[Nullable(2)]
		protected static DebugDrawManager Instance;

		// Token: 0x0200A843 RID: 43075
		public enum EEffectDebugDrawType
		{
			// Token: 0x0403339A RID: 209818
			LineFromPlayer,
			// Token: 0x0403339B RID: 209819
			Box
		}

		// Token: 0x0200A844 RID: 43076
		public class EffectDebugDrawInfo
		{
			// Token: 0x0403339C RID: 209820
			public int Index;

			// Token: 0x0403339D RID: 209821
			public DebugDrawManager.EEffectDebugDrawType? Type;

			// Token: 0x0403339E RID: 209822
			[Nullable(2)]
			public Vector VectorA;

			// Token: 0x0403339F RID: 209823
			public FLinearColor? ColorA;

			// Token: 0x040333A0 RID: 209824
			public float NumberA;

			// Token: 0x040333A1 RID: 209825
			public FBox? BoxA;
		}
	}
}
