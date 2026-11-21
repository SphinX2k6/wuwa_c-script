using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02004F7F RID: 20351
	[NullableContext(1)]
	[Nullable(0)]
	public class TotalTopUpViewDefine : Singleton
	{
		// Token: 0x170063BB RID: 25531
		// (get) Token: 0x060330CA RID: 209098 RVA: 0x00E4E8B3 File Offset: 0x00E4CAB3
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

		// Token: 0x060330CB RID: 209099 RVA: 0x00E4E8D6 File Offset: 0x00E4CAD6
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060330CC RID: 209100 RVA: 0x00E4E8D8 File Offset: 0x00E4CAD8
		public static void ResetStaticDefaultValue()
		{
			TotalTopUpViewDefine instance = TotalTopUpViewDefine._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			TotalTopUpViewDefine._instance = null;
		}

		// Token: 0x060330CD RID: 209101 RVA: 0x00E4E8F1 File Offset: 0x00E4CAF1
		static TotalTopUpViewDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TotalTopUpViewDefine.CreateStaticDefaultValue), new Action(TotalTopUpViewDefine.ResetStaticDefaultValue));
		}

		// Token: 0x060330CE RID: 209102 RVA: 0x00E4E910 File Offset: 0x00E4CB10
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

		// Token: 0x0401B189 RID: 110985
		public Dictionary<ETotalTopUpPreviewFunction, Func<TotalTopUpPreviewSubView>> TotalTopUpPreviewSubViewConstructorMap;

		// Token: 0x0401B18A RID: 110986
		[Nullable(2)]
		private static TotalTopUpViewDefine _instance;
	}
}
