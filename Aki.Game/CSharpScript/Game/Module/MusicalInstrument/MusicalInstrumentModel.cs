using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.MusicalInstrument
{
	// Token: 0x0200435C RID: 17244
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class MusicalInstrumentModel : ModelBase
	{
		// Token: 0x1700572A RID: 22314
		// (get) Token: 0x0602B8A8 RID: 178344 RVA: 0x00C3BBB4 File Offset: 0x00C39DB4
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

		// Token: 0x0602B8A9 RID: 178345 RVA: 0x00C3BC14 File Offset: 0x00C39E14
		protected override bool OnInit()
		{
			this.Register(new GuqinSubModel());
			return true;
		}

		// Token: 0x0602B8AA RID: 178346 RVA: 0x00C3BC22 File Offset: 0x00C39E22
		private void Register(MusicalInstrumentSubModel subModel)
		{
			subModel.OnRegister();
			this.SubModels[subModel.GetType()] = subModel;
		}

		// Token: 0x0602B8AB RID: 178347 RVA: 0x00C3BC3C File Offset: 0x00C39E3C
		[NullableContext(2)]
		public MusicalInstrumentSubModel GetSubModel(EInstrumentType type)
		{
			return this.SubModels.GetValueOrDefault(type);
		}

		// Token: 0x0602B8AC RID: 178348 RVA: 0x00C3BC4C File Offset: 0x00C39E4C
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

		// Token: 0x1700572B RID: 22315
		// (get) Token: 0x0602B8AD RID: 178349 RVA: 0x00C3BCB4 File Offset: 0x00C39EB4
		public static MusicalInstrumentModel Instance
		{
			get
			{
				return MusicalInstrumentModel._Instance;
			}
		}

		// Token: 0x0602B8AE RID: 178350 RVA: 0x00C3BCBB File Offset: 0x00C39EBB
		public static MusicalInstrumentModel GetOrCreateInstance()
		{
			if (MusicalInstrumentModel._Instance == null)
			{
				MusicalInstrumentModel.CreateInstance();
			}
			return MusicalInstrumentModel._Instance;
		}

		// Token: 0x0602B8AF RID: 178351 RVA: 0x00C3BCCF File Offset: 0x00C39ECF
		public static bool CreateInstance()
		{
			if (MusicalInstrumentModel._Instance != null)
			{
				return true;
			}
			MusicalInstrumentModel._Instance = new MusicalInstrumentModel();
			return true;
		}

		// Token: 0x0602B8B0 RID: 178352 RVA: 0x00C3BCE5 File Offset: 0x00C39EE5
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602B8B1 RID: 178353 RVA: 0x00C3BCE7 File Offset: 0x00C39EE7
		public static void ResetStaticDefaultValue()
		{
			MusicalInstrumentModel._Instance = null;
		}

		// Token: 0x0602B8B2 RID: 178354 RVA: 0x00C3BCEF File Offset: 0x00C39EEF
		static MusicalInstrumentModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MusicalInstrumentModel.CreateStaticDefaultValue), new Action(MusicalInstrumentModel.ResetStaticDefaultValue));
		}

		// Token: 0x04017841 RID: 96321
		private readonly Dictionary<EInstrumentType, MusicalInstrumentSubModel> SubModels = new Dictionary<EInstrumentType, MusicalInstrumentSubModel>();

		// Token: 0x04017842 RID: 96322
		[Nullable(2)]
		private static MusicalInstrumentModel _Instance;
	}
}
