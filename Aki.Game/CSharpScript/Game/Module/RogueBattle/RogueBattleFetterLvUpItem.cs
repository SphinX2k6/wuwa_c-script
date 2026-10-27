using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004E59 RID: 20057
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RogueBattleFetterLvUpItem : GridProxyAbstract<IRogueBattleRoleBondUpdateInfo>
	{
		// Token: 0x06033AD3 RID: 211667 RVA: 0x00C19624 File Offset: 0x00C17824
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x06033AD4 RID: 211668 RVA: 0x00C19680 File Offset: 0x00C17880
		protected override UniTask OnBeforeStartAsync()
		{
			RogueBattleFetterLvUpItem.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueBattleFetterLvUpItem.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033AD5 RID: 211669 RVA: 0x00C196C4 File Offset: 0x00C178C4
		[NullableContext(1)]
		public override void Refresh(IRogueBattleRoleBondUpdateInfo data, bool isSelected, int gridIndex)
		{
			RoleBondInfo oldRoleBondInfo = data.OldRoleBondInfo;
			RoleBondInfo newRoleBondInfo = data.NewRoleBondInfo;
			int configId = data.NewRoleBondInfo.ConfigId;
			RogueResBond? rogueResBond = RogueBattleConfig.Instance.GetRogueResBond(configId);
			if (rogueResBond != null)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(0), rogueResBond.Value.Name, Array.Empty<object>());
			}
			FetterData data2 = new FetterData
			{
				Id = configId,
				Lv = oldRoleBondInfo.Level,
				Star = oldRoleBondInfo.CurStar,
				IsLevelUp = false
			};
			this.FetterBefore.Refresh(data2);
			FetterData data3 = new FetterData
			{
				Id = configId,
				Lv = newRoleBondInfo.Level,
				Star = oldRoleBondInfo.CurStar + data.AddStar,
				IsLevelUp = (newRoleBondInfo.Level > oldRoleBondInfo.Level)
			};
			this.FetterAfter.Refresh(data3);
		}

		// Token: 0x0401B689 RID: 112265
		private FetterItem FetterBefore;

		// Token: 0x0401B68A RID: 112266
		private FetterItem FetterAfter;
	}
}
