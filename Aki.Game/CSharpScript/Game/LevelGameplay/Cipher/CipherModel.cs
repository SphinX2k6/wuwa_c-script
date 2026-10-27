using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.Cipher
{
	// Token: 0x02006F37 RID: 28471
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class CipherModel : ModelBase
	{
		// Token: 0x06045439 RID: 283705 RVA: 0x01122FA8 File Offset: 0x011211A8
		public void InitCipherConfig(string inRow)
		{
			this.CipherId = inRow;
			if (this.GetCipherConfig(inRow) == null)
			{
				return;
			}
			if (this.Passwords == null)
			{
				this.Passwords = new List<int>();
			}
			if (this.CurPasswords == null)
			{
				this.CurPasswords = new List<int>();
			}
			if (this.CheckMap == null)
			{
				this.CheckMap = new Dictionary<int, bool>();
			}
			this.Passwords.Clear();
			this.CurPasswords.Clear();
			this.CheckMap.Clear();
			string text = this.GetCipherConfig(inRow).Value.Password.ToString().PadLeft(4, '0');
			for (int i = 0; i < 4; i++)
			{
				int num = UKismetStringLibrary.Conv_StringToInt(text[i].ToString());
				this.Passwords.Add(num);
				this.CurPasswords.Add(-1);
				this.CheckMap[num] = false;
			}
		}

		// Token: 0x0604543A RID: 283706 RVA: 0x011230A0 File Offset: 0x011212A0
		public CipherGameplay? GetCipherConfig(string inRow)
		{
			return ConfigCipherGameplayById.GetConfig(inRow, true);
		}

		// Token: 0x0604543B RID: 283707 RVA: 0x011230AC File Offset: 0x011212AC
		public bool IsPasswordCorrect()
		{
			for (int i = 0; i < 4; i++)
			{
				this.CheckMap[i] = (this.Passwords[i] == this.CurPasswords[i]);
			}
			for (int j = 0; j < 4; j++)
			{
				bool flag;
				if (!this.CheckMap.TryGetValue(j, out flag) || !flag)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0604543C RID: 283708 RVA: 0x01123110 File Offset: 0x01121310
		public bool GetCheckResultByIndex(int inValue)
		{
			bool flag;
			return this.CheckMap.TryGetValue(inValue, out flag) && flag;
		}

		// Token: 0x0604543D RID: 283709 RVA: 0x01123130 File Offset: 0x01121330
		public void SetCurPassword(int index, int value)
		{
			if (index >= this.CurPasswords.Count)
			{
				return;
			}
			this.CurPasswords[index] = value;
		}

		// Token: 0x0604543E RID: 283710 RVA: 0x0112314E File Offset: 0x0112134E
		public string GetCipherConfigId()
		{
			return this.CipherId;
		}

		// Token: 0x17009B21 RID: 39713
		// (get) Token: 0x0604543F RID: 283711 RVA: 0x01123156 File Offset: 0x01121356
		public static CipherModel Instance
		{
			get
			{
				return CipherModel._Instance;
			}
		}

		// Token: 0x06045440 RID: 283712 RVA: 0x0112315D File Offset: 0x0112135D
		public static CipherModel GetOrCreateInstance()
		{
			if (CipherModel._Instance == null)
			{
				CipherModel.CreateInstance();
			}
			return CipherModel._Instance;
		}

		// Token: 0x06045441 RID: 283713 RVA: 0x01123171 File Offset: 0x01121371
		public static bool CreateInstance()
		{
			if (CipherModel._Instance != null)
			{
				return true;
			}
			CipherModel._Instance = new CipherModel();
			return true;
		}

		// Token: 0x06045442 RID: 283714 RVA: 0x01123187 File Offset: 0x01121387
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06045443 RID: 283715 RVA: 0x01123189 File Offset: 0x01121389
		public static void ResetStaticDefaultValue()
		{
			CipherModel._Instance = null;
		}

		// Token: 0x06045444 RID: 283716 RVA: 0x01123191 File Offset: 0x01121391
		static CipherModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CipherModel.CreateStaticDefaultValue), new Action(CipherModel.ResetStaticDefaultValue));
		}

		// Token: 0x040241D3 RID: 147923
		private const int LEN = 4;

		// Token: 0x040241D4 RID: 147924
		private const int INVLID = -1;

		// Token: 0x040241D5 RID: 147925
		private string CipherId = "";

		// Token: 0x040241D6 RID: 147926
		[Nullable(2)]
		private List<int> Passwords;

		// Token: 0x040241D7 RID: 147927
		[Nullable(2)]
		private List<int> CurPasswords;

		// Token: 0x040241D8 RID: 147928
		[Nullable(2)]
		private Dictionary<int, bool> CheckMap;

		// Token: 0x040241D9 RID: 147929
		[Nullable(2)]
		private static CipherModel _Instance;
	}
}
