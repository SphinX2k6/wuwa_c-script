using System;
using System.Collections.Generic;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007A1 RID: 1953
	public static class ISplineTypeExtensions
	{
		// Token: 0x060029B4 RID: 10676 RVA: 0x0006E1AC File Offset: 0x0006C3AC
		public static IReadOnlyList<IBaseSplinePointType> GetPoints(this ISplineType p)
		{
			ICommonSpline commonSpline = p as ICommonSpline;
			IReadOnlyList<IBaseSplinePointType> points;
			if (commonSpline == null)
			{
				IParkourSpline parkourSpline = p as IParkourSpline;
				if (parkourSpline == null)
				{
					IButterflySpline butterflySpline = p as IButterflySpline;
					if (butterflySpline == null)
					{
						IEffectSpline effectSpline = p as IEffectSpline;
						if (effectSpline == null)
						{
							IPatrolSpline patrolSpline = p as IPatrolSpline;
							if (patrolSpline == null)
							{
								ILevelAISpline levelAISpline = p as ILevelAISpline;
								if (levelAISpline == null)
								{
									IAirPassageSpline airPassageSpline = p as IAirPassageSpline;
									if (airPassageSpline == null)
									{
										IContinuesVariableSpeedMovementSpline continuesVariableSpeedMovementSpline = p as IContinuesVariableSpeedMovementSpline;
										if (continuesVariableSpeedMovementSpline == null)
										{
											ITimePatrolSpline timePatrolSpline = p as ITimePatrolSpline;
											if (timePatrolSpline == null)
											{
												IRangeSpline rangeSpline = p as IRangeSpline;
												if (rangeSpline == null)
												{
													IWaySpline waySpline = p as IWaySpline;
													if (waySpline == null)
													{
														IMotorSlideSpline motorSlideSpline = p as IMotorSlideSpline;
														if (motorSlideSpline == null)
														{
															ISwordRiderRailSpline swordRiderRailSpline = p as ISwordRiderRailSpline;
															if (swordRiderRailSpline == null)
															{
																throw new NotImplementedException("获取类型:" + p.GetType().Name + "的Points的字段失败");
															}
															points = swordRiderRailSpline.Points;
														}
														else
														{
															points = motorSlideSpline.Points;
														}
													}
													else
													{
														points = waySpline.Points;
													}
												}
												else
												{
													points = rangeSpline.Points;
												}
											}
											else
											{
												points = timePatrolSpline.Points;
											}
										}
										else
										{
											points = continuesVariableSpeedMovementSpline.Points;
										}
									}
									else
									{
										points = airPassageSpline.Points;
									}
								}
								else
								{
									points = levelAISpline.Points;
								}
							}
							else
							{
								points = patrolSpline.Points;
							}
						}
						else
						{
							points = effectSpline.Points;
						}
					}
					else
					{
						points = butterflySpline.Points;
					}
				}
				else
				{
					points = parkourSpline.Points;
				}
			}
			else
			{
				points = commonSpline.Points;
			}
			return points;
		}
	}
}
