using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.SceneItem.Model
{
	// Token: 0x020071DB RID: 29147
	[NullableContext(2)]
	[Nullable(0)]
	[Model(0)]
	public class VisionCaptureModel : ModelBase
	{
		// Token: 0x06047562 RID: 292194 RVA: 0x01223830 File Offset: 0x01221A30
		protected override bool OnInit()
		{
			this.VisionCache = new Dictionary<int, int>();
			this.VisionFinishCache = new Dictionary<int, int>();
			this.VisionEntityIdsCache = new Dictionary<int, bool>();
			return true;
		}

		// Token: 0x06047563 RID: 292195 RVA: 0x01223854 File Offset: 0x01221A54
		public void AddVisionCapture(int ownerId, int entityId)
		{
			if (ownerId != 0)
			{
				if (this.VisionCache.ContainsKey(ownerId))
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.SceneGameplay;
					ELogAuthor author = ELogAuthor.YZH;
					string message = "[VisionCaptureModel]重复添加收服声骸";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Capture Owner ID:", ownerId);
					instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				this.VisionCache[ownerId] = entityId;
			}
			this.VisionEntityIdsCache[entityId] = true;
		}

		// Token: 0x06047564 RID: 292196 RVA: 0x012238B7 File Offset: 0x01221AB7
		public void AddVisionCaptureFinish(int ownerId, int entityId)
		{
			if (ownerId != 0)
			{
				this.VisionFinishCache[ownerId] = entityId;
			}
		}

		// Token: 0x06047565 RID: 292197 RVA: 0x012238C9 File Offset: 0x01221AC9
		public void RemoveVisionCapture(int ownerId, int entityId = 0)
		{
			if (ownerId != 0)
			{
				this.VisionCache.Remove(ownerId);
				this.VisionFinishCache.Remove(ownerId);
			}
			this.VisionEntityIdsCache.Remove(entityId);
		}

		// Token: 0x06047566 RID: 292198 RVA: 0x012238F5 File Offset: 0x01221AF5
		public int GetVisionCapture(int ownerId)
		{
			return this.VisionCache[ownerId];
		}

		// Token: 0x06047567 RID: 292199 RVA: 0x01223903 File Offset: 0x01221B03
		[NullableContext(1)]
		public Dictionary<int, int> GetVisionFinish()
		{
			return this.VisionFinishCache;
		}

		// Token: 0x17009DF5 RID: 40437
		// (get) Token: 0x06047568 RID: 292200 RVA: 0x0122390B File Offset: 0x01221B0B
		public Dictionary<int, bool> AllVisionEntityIds
		{
			get
			{
				return this.VisionEntityIdsCache;
			}
		}

		// Token: 0x06047569 RID: 292201 RVA: 0x01223913 File Offset: 0x01221B13
		protected override bool OnClear()
		{
			this.VisionCache = null;
			Dictionary<int, int> visionFinishCache = this.VisionFinishCache;
			if (visionFinishCache != null)
			{
				visionFinishCache.Clear();
			}
			this.VisionFinishCache = null;
			Dictionary<int, bool> visionEntityIdsCache = this.VisionEntityIdsCache;
			if (visionEntityIdsCache != null)
			{
				visionEntityIdsCache.Clear();
			}
			this.VisionEntityIdsCache = null;
			return true;
		}

		// Token: 0x17009DF6 RID: 40438
		// (get) Token: 0x0604756A RID: 292202 RVA: 0x0122394D File Offset: 0x01221B4D
		[Nullable(1)]
		public static VisionCaptureModel Instance
		{
			[NullableContext(1)]
			get
			{
				return VisionCaptureModel._Instance;
			}
		}

		// Token: 0x0604756B RID: 292203 RVA: 0x01223954 File Offset: 0x01221B54
		[NullableContext(1)]
		public static VisionCaptureModel GetOrCreateInstance()
		{
			if (VisionCaptureModel._Instance == null)
			{
				VisionCaptureModel.CreateInstance();
			}
			return VisionCaptureModel._Instance;
		}

		// Token: 0x0604756C RID: 292204 RVA: 0x01223968 File Offset: 0x01221B68
		public static bool CreateInstance()
		{
			if (VisionCaptureModel._Instance != null)
			{
				return true;
			}
			VisionCaptureModel._Instance = new VisionCaptureModel();
			return true;
		}

		// Token: 0x0604756D RID: 292205 RVA: 0x0122397E File Offset: 0x01221B7E
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0604756E RID: 292206 RVA: 0x01223980 File Offset: 0x01221B80
		public static void ResetStaticDefaultValue()
		{
			VisionCaptureModel._Instance = null;
		}

		// Token: 0x0604756F RID: 292207 RVA: 0x01223988 File Offset: 0x01221B88
		static VisionCaptureModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(VisionCaptureModel.CreateStaticDefaultValue), new Action(VisionCaptureModel.ResetStaticDefaultValue));
		}

		// Token: 0x04025815 RID: 153621
		private Dictionary<int, int> VisionCache;

		// Token: 0x04025816 RID: 153622
		private Dictionary<int, int> VisionFinishCache;

		// Token: 0x04025817 RID: 153623
		private Dictionary<int, bool> VisionEntityIdsCache;

		// Token: 0x04025818 RID: 153624
		private static VisionCaptureModel _Instance;
	}
}
