using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.LevelGamePlay.WriteLetter
{
	// Token: 0x02005B11 RID: 23313
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class WriteLetterModel : ModelBase
	{
		// Token: 0x0603957A RID: 234874 RVA: 0x01017620 File Offset: 0x01015820
		public void SetLetterContentsFromProto([Nullable(new byte[]
		{
			2,
			1
		})] IReadOnlyList<MiniLetterContentPb> contents)
		{
			this.LetterContents.Clear();
			if (contents == null)
			{
				return;
			}
			foreach (MiniLetterContentPb miniLetterContentPb in contents)
			{
				int letterId = miniLetterContentPb.LetterId;
				HashSet<string> orCreateSet = this.GetOrCreateSet(letterId);
				RepeatedField<string> contentKey = miniLetterContentPb.ContentKey;
				if (contentKey != null)
				{
					foreach (string text in contentKey)
					{
						if (!string.IsNullOrEmpty(text))
						{
							orCreateSet.Add(text);
						}
					}
				}
			}
		}

		// Token: 0x0603957B RID: 234875 RVA: 0x010176D0 File Offset: 0x010158D0
		public void ResetLetterContent(int letterId)
		{
			this.LetterContents.Remove(letterId);
		}

		// Token: 0x0603957C RID: 234876 RVA: 0x010176E0 File Offset: 0x010158E0
		public bool RecordLetterContent(int letterId, ITalkItem talkItem)
		{
			string tidTalk = talkItem.TidTalk;
			if (string.IsNullOrEmpty(tidTalk))
			{
				return false;
			}
			HashSet<string> orCreateSet = this.GetOrCreateSet(letterId);
			if (orCreateSet.Contains(tidTalk))
			{
				return false;
			}
			orCreateSet.Add(tidTalk);
			return true;
		}

		// Token: 0x0603957D RID: 234877 RVA: 0x0101771C File Offset: 0x0101591C
		public bool HasLetterContent(int letterId)
		{
			HashSet<string> hashSet;
			return this.LetterContents.TryGetValue(letterId, out hashSet) && hashSet != null && hashSet.Count > 0;
		}

		// Token: 0x0603957E RID: 234878 RVA: 0x0101774C File Offset: 0x0101594C
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public IReadOnlySet<string> GetLetterContentKeys(int letterId)
		{
			HashSet<string> result;
			if (this.LetterContents.TryGetValue(letterId, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x0603957F RID: 234879 RVA: 0x0101776C File Offset: 0x0101596C
		[NullableContext(2)]
		public MiniLetterContentPb GetLetterContentPb(int letterId)
		{
			HashSet<string> hashSet;
			if (!this.LetterContents.TryGetValue(letterId, out hashSet) || hashSet == null || hashSet.Count == 0)
			{
				return null;
			}
			MiniLetterContentPb miniLetterContentPb = MiniLetterContentPb.Create();
			miniLetterContentPb.LetterId = letterId;
			foreach (string item in hashSet)
			{
				miniLetterContentPb.ContentKey.Add(item);
			}
			return miniLetterContentPb;
		}

		// Token: 0x06039580 RID: 234880 RVA: 0x010177EC File Offset: 0x010159EC
		protected override bool OnClear()
		{
			this.LetterContents.Clear();
			return true;
		}

		// Token: 0x06039581 RID: 234881 RVA: 0x010177FC File Offset: 0x010159FC
		private HashSet<string> GetOrCreateSet(int letterId)
		{
			HashSet<string> hashSet;
			if (!this.LetterContents.TryGetValue(letterId, out hashSet) || hashSet == null)
			{
				hashSet = new HashSet<string>();
				this.LetterContents[letterId] = hashSet;
			}
			return hashSet;
		}

		// Token: 0x17006D3A RID: 27962
		// (get) Token: 0x06039582 RID: 234882 RVA: 0x01017830 File Offset: 0x01015A30
		public static WriteLetterModel Instance
		{
			get
			{
				return WriteLetterModel._Instance;
			}
		}

		// Token: 0x06039583 RID: 234883 RVA: 0x01017837 File Offset: 0x01015A37
		public static WriteLetterModel GetOrCreateInstance()
		{
			if (WriteLetterModel._Instance == null)
			{
				WriteLetterModel.CreateInstance();
			}
			return WriteLetterModel._Instance;
		}

		// Token: 0x06039584 RID: 234884 RVA: 0x0101784B File Offset: 0x01015A4B
		public static bool CreateInstance()
		{
			if (WriteLetterModel._Instance != null)
			{
				return true;
			}
			WriteLetterModel._Instance = new WriteLetterModel();
			return true;
		}

		// Token: 0x06039585 RID: 234885 RVA: 0x01017861 File Offset: 0x01015A61
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06039586 RID: 234886 RVA: 0x01017863 File Offset: 0x01015A63
		public static void ResetStaticDefaultValue()
		{
			WriteLetterModel._Instance = null;
		}

		// Token: 0x06039587 RID: 234887 RVA: 0x0101786B File Offset: 0x01015A6B
		static WriteLetterModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(WriteLetterModel.CreateStaticDefaultValue), new Action(WriteLetterModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401E3ED RID: 123885
		private readonly Dictionary<int, HashSet<string>> LetterContents = new Dictionary<int, HashSet<string>>();

		// Token: 0x0401E3EE RID: 123886
		[Nullable(2)]
		private static WriteLetterModel _Instance;
	}
}
