using System;
using System.Collections.Generic;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200107C RID: 4220
	public static class IEnableSystemConfigExtensions
	{
		// Token: 0x06005D06 RID: 23814 RVA: 0x000E1F7C File Offset: 0x000E017C
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

		// Token: 0x06005D07 RID: 23815 RVA: 0x000E1FD4 File Offset: 0x000E01D4
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
