using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000F52 RID: 3922
	[NullableContext(1)]
	[Nullable(0)]
	public static class IEnableSystemConfigExtensions
	{
		// Token: 0x06005732 RID: 22322 RVA: 0x000D5510 File Offset: 0x000D3710
		public static IReadOnlyList<object> GetSystemVars(this IEnableSystemConfig p)
		{
			IMotorRacingSystemConfig motorRacingSystemConfig = p as IMotorRacingSystemConfig;
			IReadOnlyList<object> systemVars;
			if (motorRacingSystemConfig == null)
			{
				INightmareSettlementSystemConfig nightmareSettlementSystemConfig = p as INightmareSettlementSystemConfig;
				if (nightmareSettlementSystemConfig == null)
				{
					throw new NotImplementedException("获取类型:" + p.GetType().Name + "的SystemVars的字段失败");
				}
				systemVars = nightmareSettlementSystemConfig.SystemVars;
			}
			else
			{
				systemVars = motorRacingSystemConfig.SystemVars;
			}
			return systemVars;
		}

		// Token: 0x06005733 RID: 22323 RVA: 0x000D5568 File Offset: 0x000D3768
		public static IReadOnlyList<object> GetVars(this IEnableSystemConfig p)
		{
			IGradingSystemConfig gradingSystemConfig = p as IGradingSystemConfig;
			IReadOnlyList<object> vars;
			if (gradingSystemConfig == null)
			{
				ITrapDefenseSystemConfig trapDefenseSystemConfig = p as ITrapDefenseSystemConfig;
				if (trapDefenseSystemConfig == null)
				{
					ISurvivorsRougeSystemConfig survivorsRougeSystemConfig = p as ISurvivorsRougeSystemConfig;
					if (survivorsRougeSystemConfig == null)
					{
						IKurotatoSystemConfig kurotatoSystemConfig = p as IKurotatoSystemConfig;
						if (kurotatoSystemConfig == null)
						{
							IRoleTowerSystemConfig roleTowerSystemConfig = p as IRoleTowerSystemConfig;
							if (roleTowerSystemConfig == null)
							{
								IMotorFightSystemConfig motorFightSystemConfig = p as IMotorFightSystemConfig;
								if (motorFightSystemConfig == null)
								{
									IFlagChallengeSystemConfig flagChallengeSystemConfig = p as IFlagChallengeSystemConfig;
									if (flagChallengeSystemConfig == null)
									{
										IFlipperSystemConfig flipperSystemConfig = p as IFlipperSystemConfig;
										if (flipperSystemConfig == null)
										{
											IRogueTowerTrialSystemConfig rogueTowerTrialSystemConfig = p as IRogueTowerTrialSystemConfig;
											if (rogueTowerTrialSystemConfig == null)
											{
												throw new NotImplementedException("获取类型:" + p.GetType().Name + "的Vars的字段失败");
											}
											vars = rogueTowerTrialSystemConfig.Vars;
										}
										else
										{
											vars = flipperSystemConfig.Vars;
										}
									}
									else
									{
										vars = flagChallengeSystemConfig.Vars;
									}
								}
								else
								{
									vars = motorFightSystemConfig.Vars;
								}
							}
							else
							{
								vars = roleTowerSystemConfig.Vars;
							}
						}
						else
						{
							vars = kurotatoSystemConfig.Vars;
						}
					}
					else
					{
						vars = survivorsRougeSystemConfig.Vars;
					}
				}
				else
				{
					vars = trapDefenseSystemConfig.Vars;
				}
			}
			else
			{
				vars = gradingSystemConfig.Vars;
			}
			return vars;
		}
	}
}
