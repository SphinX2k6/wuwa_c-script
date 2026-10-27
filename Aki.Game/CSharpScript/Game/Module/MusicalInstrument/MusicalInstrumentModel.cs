using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using CSharpScript.Core.Common;

namespace CSharpScript.Game.Module.MusicalInstrument
{
	// Token: 0x02005379 RID: 21369
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class MusicalInstrumentModel : ModelBase
	{
		// Token: 0x1700835E RID: 33630
		// (get) Token: 0x06036961 RID: 223585 RVA: 0x00CECBE4 File Offset: 0x00CEADE4
		public bool IsAnyInputRestricted
		{
			get
			{
				using (Dictionary<EInstrumentType, MusicalInstrumentSubModel>.ValueCollection.Enumerator enumerator = this.SubModels.Values.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current.IsInputRestricted)
						{
							return true;
						}
					}
				}
				return false;
			}
		}

		// Token: 0x06036962 RID: 223586 RVA: 0x00CECC44 File Offset: 0x00CEAE44
		protected override bool OnInit()
		{
			this.Register(new GuqinSubModel());
			return true;
		}

		// Token: 0x06036963 RID: 223587 RVA: 0x00CECC52 File Offset: 0x00CEAE52
		private void Register(MusicalInstrumentSubModel subModel)
		{
			subModel.OnRegister();
			this.SubModels[subModel.GetType()] = subModel;
		}

		// Token: 0x06036964 RID: 223588 RVA: 0x00CECC6C File Offset: 0x00CEAE6C
		[NullableContext(2)]
		public MusicalInstrumentSubModel GetSubModel(EInstrumentType type)
		{
			return this.SubModels.GetValueOrDefault(type);
		}

		// Token: 0x06036965 RID: 223589 RVA: 0x00CECC7C File Offset: 0x00CEAE7C
		public MusicalInstrumentQteData ParseQteData(MusicalInstrumentQteConfig config)
		{
			List<MusicalInstrumentQteItemData> list = new List<MusicalInstrumentQteItemData>();
			foreach (List<int> list2 in Json.Parse<List<List<int>>>(config.QteSequence, null))
			{
				list.Add(new MusicalInstrumentQteItemData
				{
					RowIndex = list2[0],
					ColumnIndex = list2[1],
					Finished = false,
					IsFocus = false
				});
			}
			list[0].IsFocus = true;
			return new MusicalInstrumentQteData
			{
				InstrumentType = (EInstrumentType)config.InstrumentType,
				QteId = config.Id,
				ItemDataList = list,
				AudioEvent = AudioSystem.Instance.parseAudioEventPath(config.PreludeAsset)
			};
		}

		// Token: 0x06036966 RID: 223590 RVA: 0x00CECD54 File Offset: 0x00CEAF54
		protected override bool OnClear()
		{
			foreach (MusicalInstrumentSubModel musicalInstrumentSubModel in this.SubModels.Values)
			{
				musicalInstrumentSubModel.OnClear();
				musicalInstrumentSubModel.IsInputRestricted = false;
			}
			this.SubModels.Clear();
			return true;
		}

		// Token: 0x1700835F RID: 33631
		// (get) Token: 0x06036967 RID: 223591 RVA: 0x00CECDBC File Offset: 0x00CEAFBC
		public static MusicalInstrumentModel Instance
		{
			get
			{
				return MusicalInstrumentModel._Instance;
			}
		}

		// Token: 0x06036968 RID: 223592 RVA: 0x00CECDC3 File Offset: 0x00CEAFC3
		public static MusicalInstrumentModel GetOrCreateInstance()
		{
			if (MusicalInstrumentModel._Instance == null)
			{
				MusicalInstrumentModel.CreateInstance();
			}
			return MusicalInstrumentModel._Instance;
		}

		// Token: 0x06036969 RID: 223593 RVA: 0x00CECDD7 File Offset: 0x00CEAFD7
		public static bool CreateInstance()
		{
			if (MusicalInstrumentModel._Instance != null)
			{
				return true;
			}
			MusicalInstrumentModel._Instance = new MusicalInstrumentModel();
			return true;
		}

		// Token: 0x0603696A RID: 223594 RVA: 0x00CECDED File Offset: 0x00CEAFED
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603696B RID: 223595 RVA: 0x00CECDEF File Offset: 0x00CEAFEF
		public static void ResetStaticDefaultValue()
		{
			MusicalInstrumentModel._Instance = null;
		}

		// Token: 0x0603696C RID: 223596 RVA: 0x00CECDF7 File Offset: 0x00CEAFF7
		static MusicalInstrumentModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MusicalInstrumentModel.CreateStaticDefaultValue), new Action(MusicalInstrumentModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401CDA9 RID: 118185
		private readonly Dictionary<EInstrumentType, MusicalInstrumentSubModel> SubModels = new Dictionary<EInstrumentType, MusicalInstrumentSubModel>();

		// Token: 0x0401CDAA RID: 118186
		[Nullable(2)]
		private static MusicalInstrumentModel _Instance;
	}
}
