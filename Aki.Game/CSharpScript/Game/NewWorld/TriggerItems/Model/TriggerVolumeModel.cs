using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.TriggerItems.Model
{
	// Token: 0x02007056 RID: 28758
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class TriggerVolumeModel : ModelBase
	{
		// Token: 0x06045FDB RID: 286683 RVA: 0x011725E5 File Offset: 0x011707E5
		protected override bool OnInit()
		{
			this.TriggerVolumeCache = new Dictionary<int, Dictionary<int, TsTriggerVolume>>();
			return true;
		}

		// Token: 0x06045FDC RID: 286684 RVA: 0x011725F4 File Offset: 0x011707F4
		public void AddTriggerVolume(int groupId, int index, TsTriggerVolume tsTriggerVolume)
		{
			Dictionary<int, TsTriggerVolume> dictionary;
			if (!this.TriggerVolumeCache.TryGetValue(groupId, out dictionary))
			{
				dictionary = new Dictionary<int, TsTriggerVolume>();
				this.TriggerVolumeCache[groupId] = dictionary;
			}
			dictionary[index] = tsTriggerVolume;
		}

		// Token: 0x06045FDD RID: 286685 RVA: 0x0117262C File Offset: 0x0117082C
		public void RemoveTriggerVolume(int groupId, int index)
		{
			Dictionary<int, TsTriggerVolume> dictionary;
			if (!this.TriggerVolumeCache.TryGetValue(groupId, out dictionary))
			{
				return;
			}
			dictionary.Remove(index);
		}

		// Token: 0x06045FDE RID: 286686 RVA: 0x01172654 File Offset: 0x01170854
		[NullableContext(2)]
		public TsTriggerVolume GetTriggerVolume(int groupId, int index)
		{
			Dictionary<int, TsTriggerVolume> dictionary;
			if (!this.TriggerVolumeCache.TryGetValue(groupId, out dictionary))
			{
				return null;
			}
			TsTriggerVolume result;
			if (!dictionary.TryGetValue(index, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06045FDF RID: 286687 RVA: 0x01172681 File Offset: 0x01170881
		protected override bool OnClear()
		{
			this.TriggerVolumeCache = null;
			return true;
		}

		// Token: 0x17009BF1 RID: 39921
		// (get) Token: 0x06045FE0 RID: 286688 RVA: 0x0117268B File Offset: 0x0117088B
		public static TriggerVolumeModel Instance
		{
			get
			{
				return TriggerVolumeModel._Instance;
			}
		}

		// Token: 0x06045FE1 RID: 286689 RVA: 0x01172692 File Offset: 0x01170892
		public static TriggerVolumeModel GetOrCreateInstance()
		{
			if (TriggerVolumeModel._Instance == null)
			{
				TriggerVolumeModel.CreateInstance();
			}
			return TriggerVolumeModel._Instance;
		}

		// Token: 0x06045FE2 RID: 286690 RVA: 0x011726A6 File Offset: 0x011708A6
		public static bool CreateInstance()
		{
			if (TriggerVolumeModel._Instance != null)
			{
				return true;
			}
			TriggerVolumeModel._Instance = new TriggerVolumeModel();
			return true;
		}

		// Token: 0x06045FE3 RID: 286691 RVA: 0x011726BC File Offset: 0x011708BC
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06045FE4 RID: 286692 RVA: 0x011726BE File Offset: 0x011708BE
		public static void ResetStaticDefaultValue()
		{
			TriggerVolumeModel._Instance = null;
		}

		// Token: 0x06045FE5 RID: 286693 RVA: 0x011726C6 File Offset: 0x011708C6
		static TriggerVolumeModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TriggerVolumeModel.CreateStaticDefaultValue), new Action(TriggerVolumeModel.ResetStaticDefaultValue));
		}

		// Token: 0x04024A37 RID: 150071
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Dictionary<int, Dictionary<int, TsTriggerVolume>> TriggerVolumeCache;

		// Token: 0x04024A38 RID: 150072
		[Nullable(2)]
		private static TriggerVolumeModel _Instance;
	}
}
