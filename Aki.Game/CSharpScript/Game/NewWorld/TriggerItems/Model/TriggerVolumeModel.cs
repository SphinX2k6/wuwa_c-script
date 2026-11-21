using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.TriggerItems.Model
{
	// Token: 0x020061D7 RID: 25047
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class TriggerVolumeModel : ModelBase
	{
		// Token: 0x0603C1C9 RID: 246217 RVA: 0x0111C2A5 File Offset: 0x0111A4A5
		protected override bool OnInit()
		{
			this.TriggerVolumeCache = new Dictionary<int, Dictionary<int, TsTriggerVolume>>();
			return true;
		}

		// Token: 0x0603C1CA RID: 246218 RVA: 0x0111C2B4 File Offset: 0x0111A4B4
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

		// Token: 0x0603C1CB RID: 246219 RVA: 0x0111C2EC File Offset: 0x0111A4EC
		public void RemoveTriggerVolume(int groupId, int index)
		{
			Dictionary<int, TsTriggerVolume> dictionary;
			if (!this.TriggerVolumeCache.TryGetValue(groupId, out dictionary))
			{
				return;
			}
			dictionary.Remove(index);
		}

		// Token: 0x0603C1CC RID: 246220 RVA: 0x0111C314 File Offset: 0x0111A514
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

		// Token: 0x0603C1CD RID: 246221 RVA: 0x0111C341 File Offset: 0x0111A541
		protected override bool OnClear()
		{
			this.TriggerVolumeCache = null;
			return true;
		}

		// Token: 0x1700716A RID: 29034
		// (get) Token: 0x0603C1CE RID: 246222 RVA: 0x0111C34B File Offset: 0x0111A54B
		public static TriggerVolumeModel Instance
		{
			get
			{
				return TriggerVolumeModel._Instance;
			}
		}

		// Token: 0x0603C1CF RID: 246223 RVA: 0x0111C352 File Offset: 0x0111A552
		public static TriggerVolumeModel GetOrCreateInstance()
		{
			if (TriggerVolumeModel._Instance == null)
			{
				TriggerVolumeModel.CreateInstance();
			}
			return TriggerVolumeModel._Instance;
		}

		// Token: 0x0603C1D0 RID: 246224 RVA: 0x0111C366 File Offset: 0x0111A566
		public static bool CreateInstance()
		{
			if (TriggerVolumeModel._Instance != null)
			{
				return true;
			}
			TriggerVolumeModel._Instance = new TriggerVolumeModel();
			return true;
		}

		// Token: 0x0603C1D1 RID: 246225 RVA: 0x0111C37C File Offset: 0x0111A57C
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603C1D2 RID: 246226 RVA: 0x0111C37E File Offset: 0x0111A57E
		public static void ResetStaticDefaultValue()
		{
			TriggerVolumeModel._Instance = null;
		}

		// Token: 0x0603C1D3 RID: 246227 RVA: 0x0111C386 File Offset: 0x0111A586
		static TriggerVolumeModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TriggerVolumeModel.CreateStaticDefaultValue), new Action(TriggerVolumeModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401FCED RID: 130285
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Dictionary<int, Dictionary<int, TsTriggerVolume>> TriggerVolumeCache;

		// Token: 0x0401FCEE RID: 130286
		[Nullable(2)]
		private static TriggerVolumeModel _Instance;
	}
}
