using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.SceneItem.Model
{
	// Token: 0x0200628B RID: 25227
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class RangeItemModel : ModelBase
	{
		// Token: 0x0603CE2C RID: 249388 RVA: 0x0117D003 File Offset: 0x0117B203
		protected override bool OnInit()
		{
			this.BoxRangeCache = new Dictionary<string, TsBoxRangeItem>();
			return true;
		}

		// Token: 0x0603CE2D RID: 249389 RVA: 0x0117D014 File Offset: 0x0117B214
		public void AddBoxRange(string rangeId, TsBoxRangeItem range)
		{
			if (this.BoxRangeCache.ContainsKey(rangeId))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneGameplay;
				ELogAuthor author = ELogAuthor.CJH;
				string message = "[RangeItemModel] Box Range Id 重复";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("BoxRangeItem", range);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			this.BoxRangeCache[rangeId] = range;
		}

		// Token: 0x0603CE2E RID: 249390 RVA: 0x0117D063 File Offset: 0x0117B263
		public void RemoveBoxRange(string rangeId)
		{
			this.BoxRangeCache.Remove(rangeId);
		}

		// Token: 0x0603CE2F RID: 249391 RVA: 0x0117D072 File Offset: 0x0117B272
		public TsBoxRangeItem GetBoxRange(string rangeId)
		{
			return this.BoxRangeCache[rangeId];
		}

		// Token: 0x0603CE30 RID: 249392 RVA: 0x0117D080 File Offset: 0x0117B280
		protected override bool OnClear()
		{
			this.BoxRangeCache = null;
			return true;
		}

		// Token: 0x17007347 RID: 29511
		// (get) Token: 0x0603CE31 RID: 249393 RVA: 0x0117D08A File Offset: 0x0117B28A
		public static RangeItemModel Instance
		{
			get
			{
				return RangeItemModel._Instance;
			}
		}

		// Token: 0x0603CE32 RID: 249394 RVA: 0x0117D091 File Offset: 0x0117B291
		public static RangeItemModel GetOrCreateInstance()
		{
			if (RangeItemModel._Instance == null)
			{
				RangeItemModel.CreateInstance();
			}
			return RangeItemModel._Instance;
		}

		// Token: 0x0603CE33 RID: 249395 RVA: 0x0117D0A5 File Offset: 0x0117B2A5
		public static bool CreateInstance()
		{
			if (RangeItemModel._Instance != null)
			{
				return true;
			}
			RangeItemModel._Instance = new RangeItemModel();
			return true;
		}

		// Token: 0x0603CE34 RID: 249396 RVA: 0x0117D0BB File Offset: 0x0117B2BB
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603CE35 RID: 249397 RVA: 0x0117D0BD File Offset: 0x0117B2BD
		public static void ResetStaticDefaultValue()
		{
			RangeItemModel._Instance = null;
		}

		// Token: 0x0603CE36 RID: 249398 RVA: 0x0117D0C5 File Offset: 0x0117B2C5
		static RangeItemModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RangeItemModel.CreateStaticDefaultValue), new Action(RangeItemModel.ResetStaticDefaultValue));
		}

		// Token: 0x0402047A RID: 132218
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Dictionary<string, TsBoxRangeItem> BoxRangeCache;

		// Token: 0x0402047B RID: 132219
		[Nullable(2)]
		private static RangeItemModel _Instance;
	}
}
