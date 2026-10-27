using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using UnrealEngine;

namespace CSharpScript.Game.Utils
{
	// Token: 0x0200454A RID: 17738
	[NullableContext(1)]
	[Nullable(0)]
	public class ConfigCurveUtils
	{
		// Token: 0x0602DD7A RID: 187770 RVA: 0x00A8A16C File Offset: 0x00A8836C
		public static CurveBase CreateCurveByBaseCurve(IBaseCurve baseCurve, [Nullable(2)] UCurveFloat preloadedCurveAsset = null)
		{
			return CurveUtils.CreateCurveByStruct(ConfigCurveUtils.ConvertToBaseCurve(baseCurve, preloadedCurveAsset));
		}

		// Token: 0x0602DD7B RID: 187771 RVA: 0x00A8A17C File Offset: 0x00A8837C
		private static SBaseCurve ConvertToBaseCurve(IBaseCurve baseCurve, [Nullable(2)] UCurveFloat preloadedCurveAsset)
		{
			SBaseCurve sbaseCurve = new SBaseCurve();
			Aki.TDConfigMgr.Action.EBaseCurveType type = baseCurve.Type;
			switch (type)
			{
			case Aki.TDConfigMgr.Action.EBaseCurveType.CurveType1:
				sbaseCurve.CurveType = AkiClient.Game.Aki.Character.BaseCharacter.Camera.EBaseCurveType.二阶_凹函数;
				break;
			case Aki.TDConfigMgr.Action.EBaseCurveType.CurveType2:
				sbaseCurve.CurveType = AkiClient.Game.Aki.Character.BaseCharacter.Camera.EBaseCurveType.二阶_凸函数;
				break;
			case Aki.TDConfigMgr.Action.EBaseCurveType.CurveType3:
				sbaseCurve.CurveType = AkiClient.Game.Aki.Character.BaseCharacter.Camera.EBaseCurveType.三阶_凹函数;
				break;
			case Aki.TDConfigMgr.Action.EBaseCurveType.CurveType4:
				sbaseCurve.CurveType = AkiClient.Game.Aki.Character.BaseCharacter.Camera.EBaseCurveType.三阶_凸函数;
				break;
			case Aki.TDConfigMgr.Action.EBaseCurveType.CurveType5:
				sbaseCurve.CurveType = AkiClient.Game.Aki.Character.BaseCharacter.Camera.EBaseCurveType.三阶_S函数;
				break;
			case Aki.TDConfigMgr.Action.EBaseCurveType.CurveType6:
				sbaseCurve.CurveType = AkiClient.Game.Aki.Character.BaseCharacter.Camera.EBaseCurveType.三阶_反S函数;
				break;
			default:
				if (type != Aki.TDConfigMgr.Action.EBaseCurveType.CurveAsset)
				{
					sbaseCurve.CurveType = AkiClient.Game.Aki.Character.BaseCharacter.Camera.EBaseCurveType.线性;
				}
				else
				{
					sbaseCurve.CurveType = AkiClient.Game.Aki.Character.BaseCharacter.Camera.EBaseCurveType.资产曲线;
					if (preloadedCurveAsset != null)
					{
						sbaseCurve.FloatCurve = preloadedCurveAsset;
					}
					else if (!string.IsNullOrEmpty(baseCurve.CurveAsset))
					{
						global::Log instance = global::Log.Instance;
						ELogModule module = ELogModule.Game;
						ELogAuthor author = ELogAuthor.ZJL;
						string message = "ConfigCurveUtils 资产曲线未预加载,回退到默认线性曲线";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Path", baseCurve.CurveAsset);
						instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
						sbaseCurve.CurveType = AkiClient.Game.Aki.Character.BaseCharacter.Camera.EBaseCurveType.线性;
					}
				}
				break;
			}
			sbaseCurve.N = baseCurve.N;
			return sbaseCurve;
		}
	}
}
