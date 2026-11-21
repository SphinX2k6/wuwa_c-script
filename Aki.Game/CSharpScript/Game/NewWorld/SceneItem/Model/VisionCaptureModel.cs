using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.SceneItem.Model
{
	// Token: 0x02006290 RID: 25232
	[NullableContext(2)]
	[Nullable(0)]
	[Model(0)]
	public class VisionCaptureModel : ModelBase
	{
		// Token: 0x0603CE64 RID: 249444 RVA: 0x0117D664 File Offset: 0x0117B864
		protected override bool OnInit()
		{
			this.VisionCache = new Dictionary<int, int>();
			this.VisionFinishCache = new Dictionary<int, int>();
			this.VisionEntityIdsCache = new Dictionary<int, bool>();
			return true;
		}

		// Token: 0x0603CE65 RID: 249445 RVA: 0x0117D688 File Offset: 0x0117B888
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

		// Token: 0x0603CE66 RID: 249446 RVA: 0x0117D6EB File Offset: 0x0117B8EB
		public void AddVisionCaptureFinish(int ownerId, int entityId)
		{
			if (ownerId != 0)
			{
				this.VisionFinishCache[ownerId] = entityId;
			}
		}

		// Token: 0x0603CE67 RID: 249447 RVA: 0x0117D6FD File Offset: 0x0117B8FD
		public void RemoveVisionCapture(int ownerId, int entityId = 0)
		{
			if (ownerId != 0)
			{
				this.VisionCache.Remove(ownerId);
				this.VisionFinishCache.Remove(ownerId);
			}
			this.VisionEntityIdsCache.Remove(entityId);
		}

		// Token: 0x0603CE68 RID: 249448 RVA: 0x0117D729 File Offset: 0x0117B929
		public int GetVisionCapture(int ownerId)
		{
			return this.VisionCache[ownerId];
		}

		// Token: 0x0603CE69 RID: 249449 RVA: 0x0117D737 File Offset: 0x0117B937
		[NullableContext(1)]
		public Dictionary<int, int> GetVisionFinish()
		{
			return this.VisionFinishCache;
		}

		// Token: 0x1700734C RID: 29516
		// (get) Token: 0x0603CE6A RID: 249450 RVA: 0x0117D73F File Offset: 0x0117B93F
		public Dictionary<int, bool> AllVisionEntityIds
		{
			get
			{
				return this.VisionEntityIdsCache;
			}
		}

		// Token: 0x0603CE6B RID: 249451 RVA: 0x0117D747 File Offset: 0x0117B947
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

		// Token: 0x1700734D RID: 29517
		// (get) Token: 0x0603CE6C RID: 249452 RVA: 0x0117D781 File Offset: 0x0117B981
		[Nullable(1)]
		public static VisionCaptureModel Instance
		{
			[NullableContext(1)]
			get
			{
				return VisionCaptureModel._Instance;
			}
		}

		// Token: 0x0603CE6D RID: 249453 RVA: 0x0117D788 File Offset: 0x0117B988
		[NullableContext(1)]
		public static VisionCaptureModel GetOrCreateInstance()
		{
			if (VisionCaptureModel._Instance == null)
			{
				VisionCaptureModel.CreateInstance();
			}
			return VisionCaptureModel._Instance;
		}

		// Token: 0x0603CE6E RID: 249454 RVA: 0x0117D79C File Offset: 0x0117B99C
		public static bool CreateInstance()
		{
			if (VisionCaptureModel._Instance != null)
			{
				return true;
			}
			VisionCaptureModel._Instance = new VisionCaptureModel();
			return true;
		}

		// Token: 0x0603CE6F RID: 249455 RVA: 0x0117D7B2 File Offset: 0x0117B9B2
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603CE70 RID: 249456 RVA: 0x0117D7B4 File Offset: 0x0117B9B4
		public static void ResetStaticDefaultValue()
		{
			VisionCaptureModel._Instance = null;
		}

		// Token: 0x0603CE71 RID: 249457 RVA: 0x0117D7BC File Offset: 0x0117B9BC
		static VisionCaptureModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(VisionCaptureModel.CreateStaticDefaultValue), new Action(VisionCaptureModel.ResetStaticDefaultValue));
		}

		// Token: 0x04020484 RID: 132228
		private Dictionary<int, int> VisionCache;

		// Token: 0x04020485 RID: 132229
		private Dictionary<int, int> VisionFinishCache;

		// Token: 0x04020486 RID: 132230
		private Dictionary<int, bool> VisionEntityIdsCache;

		// Token: 0x04020487 RID: 132231
		private static VisionCaptureModel _Instance;
	}
}
