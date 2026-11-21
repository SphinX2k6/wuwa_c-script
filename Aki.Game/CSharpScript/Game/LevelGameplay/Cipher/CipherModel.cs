using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.Cipher
{
	// Token: 0x020060B8 RID: 24760
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class CipherModel : ModelBase
	{
		// Token: 0x0603B5E7 RID: 243175 RVA: 0x010CCF54 File Offset: 0x010CB154
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

		// Token: 0x0603B5E8 RID: 243176 RVA: 0x010CD04C File Offset: 0x010CB24C
		public CipherGameplay? GetCipherConfig(string inRow)
		{
			return ConfigCipherGameplayById.GetConfig(inRow, true);
		}

		// Token: 0x0603B5E9 RID: 243177 RVA: 0x010CD058 File Offset: 0x010CB258
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

		// Token: 0x0603B5EA RID: 243178 RVA: 0x010CD0BC File Offset: 0x010CB2BC
		public bool GetCheckResultByIndex(int inValue)
		{
			bool flag;
			return this.CheckMap.TryGetValue(inValue, out flag) && flag;
		}

		// Token: 0x0603B5EB RID: 243179 RVA: 0x010CD0DC File Offset: 0x010CB2DC
		public void SetCurPassword(int index, int value)
		{
			if (index >= this.CurPasswords.Count)
			{
				return;
			}
			this.CurPasswords[index] = value;
		}

		// Token: 0x0603B5EC RID: 243180 RVA: 0x010CD0FA File Offset: 0x010CB2FA
		public string GetCipherConfigId()
		{
			return this.CipherId;
		}

		// Token: 0x17007060 RID: 28768
		// (get) Token: 0x0603B5ED RID: 243181 RVA: 0x010CD102 File Offset: 0x010CB302
		public static CipherModel Instance
		{
			get
			{
				return CipherModel._Instance;
			}
		}

		// Token: 0x0603B5EE RID: 243182 RVA: 0x010CD109 File Offset: 0x010CB309
		public static CipherModel GetOrCreateInstance()
		{
			if (CipherModel._Instance == null)
			{
				CipherModel.CreateInstance();
			}
			return CipherModel._Instance;
		}

		// Token: 0x0603B5EF RID: 243183 RVA: 0x010CD11D File Offset: 0x010CB31D
		public static bool CreateInstance()
		{
			if (CipherModel._Instance != null)
			{
				return true;
			}
			CipherModel._Instance = new CipherModel();
			return true;
		}

		// Token: 0x0603B5F0 RID: 243184 RVA: 0x010CD133 File Offset: 0x010CB333
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603B5F1 RID: 243185 RVA: 0x010CD135 File Offset: 0x010CB335
		public static void ResetStaticDefaultValue()
		{
			CipherModel._Instance = null;
		}

		// Token: 0x0603B5F2 RID: 243186 RVA: 0x010CD13D File Offset: 0x010CB33D
		static CipherModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CipherModel.CreateStaticDefaultValue), new Action(CipherModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401F488 RID: 128136
		private const int LEN = 4;

		// Token: 0x0401F489 RID: 128137
		private const int INVLID = -1;

		// Token: 0x0401F48A RID: 128138
		private string CipherId = "";

		// Token: 0x0401F48B RID: 128139
		[Nullable(2)]
		private List<int> Passwords;

		// Token: 0x0401F48C RID: 128140
		[Nullable(2)]
		private List<int> CurPasswords;

		// Token: 0x0401F48D RID: 128141
		[Nullable(2)]
		private Dictionary<int, bool> CheckMap;

		// Token: 0x0401F48E RID: 128142
		[Nullable(2)]
		private static CipherModel _Instance;
	}
}
