using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.SceneItem.Model
{
	// Token: 0x020071D6 RID: 29142
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class RangeItemModel : ModelBase
	{
		// Token: 0x0604752A RID: 292138 RVA: 0x012231CF File Offset: 0x012213CF
		protected override bool OnInit()
		{
			this.BoxRangeCache = new Dictionary<string, TsBoxRangeItem>();
			return true;
		}

		// Token: 0x0604752B RID: 292139 RVA: 0x012231E0 File Offset: 0x012213E0
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

		// Token: 0x0604752C RID: 292140 RVA: 0x0122322F File Offset: 0x0122142F
		public void RemoveBoxRange(string rangeId)
		{
			this.BoxRangeCache.Remove(rangeId);
		}

		// Token: 0x0604752D RID: 292141 RVA: 0x0122323E File Offset: 0x0122143E
		public TsBoxRangeItem GetBoxRange(string rangeId)
		{
			return this.BoxRangeCache[rangeId];
		}

		// Token: 0x0604752E RID: 292142 RVA: 0x0122324C File Offset: 0x0122144C
		protected override bool OnClear()
		{
			this.BoxRangeCache = null;
			return true;
		}

		// Token: 0x17009DF0 RID: 40432
		// (get) Token: 0x0604752F RID: 292143 RVA: 0x01223256 File Offset: 0x01221456
		public static RangeItemModel Instance
		{
			get
			{
				return RangeItemModel._Instance;
			}
		}

		// Token: 0x06047530 RID: 292144 RVA: 0x0122325D File Offset: 0x0122145D
		public static RangeItemModel GetOrCreateInstance()
		{
			if (RangeItemModel._Instance == null)
			{
				RangeItemModel.CreateInstance();
			}
			return RangeItemModel._Instance;
		}

		// Token: 0x06047531 RID: 292145 RVA: 0x01223271 File Offset: 0x01221471
		public static bool CreateInstance()
		{
			if (RangeItemModel._Instance != null)
			{
				return true;
			}
			RangeItemModel._Instance = new RangeItemModel();
			return true;
		}

		// Token: 0x06047532 RID: 292146 RVA: 0x01223287 File Offset: 0x01221487
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06047533 RID: 292147 RVA: 0x01223289 File Offset: 0x01221489
		public static void ResetStaticDefaultValue()
		{
			RangeItemModel._Instance = null;
		}

		// Token: 0x06047534 RID: 292148 RVA: 0x01223291 File Offset: 0x01221491
		static RangeItemModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RangeItemModel.CreateStaticDefaultValue), new Action(RangeItemModel.ResetStaticDefaultValue));
		}

		// Token: 0x0402580B RID: 153611
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Dictionary<string, TsBoxRangeItem> BoxRangeCache;

		// Token: 0x0402580C RID: 153612
		[Nullable(2)]
		private static RangeItemModel _Instance;
	}
}
