using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02005F98 RID: 24472
	[NullableContext(1)]
	[Nullable(0)]
	public class TotalTopUpViewDefine : Singleton
	{
		// Token: 0x17008FE9 RID: 36841
		// (get) Token: 0x0603E130 RID: 254256 RVA: 0x00EFCBFB File Offset: 0x00EFADFB
		public static TotalTopUpViewDefine Instance
		{
			get
			{
				if (TotalTopUpViewDefine._instance == null)
				{
					TotalTopUpViewDefine._instance = new TotalTopUpViewDefine();
					TotalTopUpViewDefine._instance.OnInit();
				}
				return TotalTopUpViewDefine._instance;
			}
		}

		// Token: 0x0603E131 RID: 254257 RVA: 0x00EFCC1E File Offset: 0x00EFAE1E
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603E132 RID: 254258 RVA: 0x00EFCC20 File Offset: 0x00EFAE20
		public static void ResetStaticDefaultValue()
		{
			TotalTopUpViewDefine instance = TotalTopUpViewDefine._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			TotalTopUpViewDefine._instance = null;
		}

		// Token: 0x0603E133 RID: 254259 RVA: 0x00EFCC39 File Offset: 0x00EFAE39
		static TotalTopUpViewDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TotalTopUpViewDefine.CreateStaticDefaultValue), new Action(TotalTopUpViewDefine.ResetStaticDefaultValue));
		}

		// Token: 0x0603E134 RID: 254260 RVA: 0x00EFCC58 File Offset: 0x00EFAE58
		public TotalTopUpViewDefine()
		{
			Dictionary<ETotalTopUpPreviewFunction, Func<TotalTopUpPreviewSubView>> dictionary = new Dictionary<ETotalTopUpPreviewFunction, Func<TotalTopUpPreviewSubView>>();
			dictionary.Add(ETotalTopUpPreviewFunction.RolePreview, () => new TotalTopUpPreviewRoleSubView());
			dictionary.Add(ETotalTopUpPreviewFunction.WeaponPreview, () => new TotalTopUpPreviewWeaponSubView());
			dictionary.Add(ETotalTopUpPreviewFunction.Personalized, () => new TotalTopUpPreviewPersonalizedSubView());
			dictionary.Add(ETotalTopUpPreviewFunction.Role37, () => new TotalTopUpPreviewRole37SubView());
			dictionary.Add(ETotalTopUpPreviewFunction.Weapon37, () => new TotalTopUpPreviewWeapon37SubView());
			dictionary.Add(ETotalTopUpPreviewFunction.Crown37, () => new TotalTopUpPreviewPersonalized37SubView());
			this.TotalTopUpPreviewSubViewConstructorMap = dictionary;
			base..ctor();
		}

		// Token: 0x040206B7 RID: 132791
		public Dictionary<ETotalTopUpPreviewFunction, Func<TotalTopUpPreviewSubView>> TotalTopUpPreviewSubViewConstructorMap;

		// Token: 0x040206B8 RID: 132792
		[Nullable(2)]
		private static TotalTopUpViewDefine _instance;
	}
}
