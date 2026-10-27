using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.LevelGamePlay.WriteLetter
{
	// Token: 0x020069B5 RID: 27061
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class WriteLetterModel : ModelBase
	{
		// Token: 0x06043542 RID: 275778 RVA: 0x010731D8 File Offset: 0x010713D8
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

		// Token: 0x06043543 RID: 275779 RVA: 0x01073288 File Offset: 0x01071488
		public void ResetLetterContent(int letterId)
		{
			this.LetterContents.Remove(letterId);
		}

		// Token: 0x06043544 RID: 275780 RVA: 0x01073298 File Offset: 0x01071498
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

		// Token: 0x06043545 RID: 275781 RVA: 0x010732D4 File Offset: 0x010714D4
		public bool HasLetterContent(int letterId)
		{
			HashSet<string> hashSet;
			return this.LetterContents.TryGetValue(letterId, out hashSet) && hashSet != null && hashSet.Count > 0;
		}

		// Token: 0x06043546 RID: 275782 RVA: 0x01073304 File Offset: 0x01071504
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

		// Token: 0x06043547 RID: 275783 RVA: 0x01073324 File Offset: 0x01071524
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

		// Token: 0x06043548 RID: 275784 RVA: 0x010733A4 File Offset: 0x010715A4
		protected override bool OnClear()
		{
			this.LetterContents.Clear();
			return true;
		}

		// Token: 0x06043549 RID: 275785 RVA: 0x010733B4 File Offset: 0x010715B4
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

		// Token: 0x1700985A RID: 39002
		// (get) Token: 0x0604354A RID: 275786 RVA: 0x010733E8 File Offset: 0x010715E8
		public static WriteLetterModel Instance
		{
			get
			{
				return WriteLetterModel._Instance;
			}
		}

		// Token: 0x0604354B RID: 275787 RVA: 0x010733EF File Offset: 0x010715EF
		public static WriteLetterModel GetOrCreateInstance()
		{
			if (WriteLetterModel._Instance == null)
			{
				WriteLetterModel.CreateInstance();
			}
			return WriteLetterModel._Instance;
		}

		// Token: 0x0604354C RID: 275788 RVA: 0x01073403 File Offset: 0x01071603
		public static bool CreateInstance()
		{
			if (WriteLetterModel._Instance != null)
			{
				return true;
			}
			WriteLetterModel._Instance = new WriteLetterModel();
			return true;
		}

		// Token: 0x0604354D RID: 275789 RVA: 0x01073419 File Offset: 0x01071619
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0604354E RID: 275790 RVA: 0x0107341B File Offset: 0x0107161B
		public static void ResetStaticDefaultValue()
		{
			WriteLetterModel._Instance = null;
		}

		// Token: 0x0604354F RID: 275791 RVA: 0x01073423 File Offset: 0x01071623
		static WriteLetterModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(WriteLetterModel.CreateStaticDefaultValue), new Action(WriteLetterModel.ResetStaticDefaultValue));
		}

		// Token: 0x040231FE RID: 143870
		private readonly Dictionary<int, HashSet<string>> LetterContents = new Dictionary<int, HashSet<string>>();

		// Token: 0x040231FF RID: 143871
		[Nullable(2)]
		private static WriteLetterModel _Instance;
	}
}
