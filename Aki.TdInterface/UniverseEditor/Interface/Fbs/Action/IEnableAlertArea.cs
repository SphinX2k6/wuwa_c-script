using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006642 RID: 26178
	public struct IEnableAlertArea : IFlatbufferObject
	{
		// Token: 0x1700C27F RID: 49791
		// (get) Token: 0x0602D77B RID: 186235 RVA: 0x0063A4DF File Offset: 0x006386DF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D77C RID: 186236 RVA: 0x0063A4EC File Offset: 0x006386EC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D77D RID: 186237 RVA: 0x0063A4F4 File Offset: 0x006386F4
		public static IEnableAlertArea GetRootAsIEnableAlertArea(ByteBuffer _bb)
		{
			return IEnableAlertArea.GetRootAsIEnableAlertArea(_bb, default(IEnableAlertArea));
		}

		// Token: 0x0602D77E RID: 186238 RVA: 0x0063A510 File Offset: 0x00638710
		public static IEnableAlertArea GetRootAsIEnableAlertArea(ByteBuffer _bb, IEnableAlertArea obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D77F RID: 186239 RVA: 0x0063A52D File Offset: 0x0063872D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D780 RID: 186240 RVA: 0x0063A53C File Offset: 0x0063873C
		public IEnableAlertArea __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C280 RID: 49792
		// (get) Token: 0x0602D781 RID: 186241 RVA: 0x0063A54C File Offset: 0x0063874C
		public EAlertSystemOption Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAlertSystemOption.EnableAlertArea;
				}
				return (EAlertSystemOption)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C281 RID: 49793
		// (get) Token: 0x0602D782 RID: 186242 RVA: 0x0063A588 File Offset: 0x00638788
		public int AreaId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C282 RID: 49794
		// (get) Token: 0x0602D783 RID: 186243 RVA: 0x0063A5C4 File Offset: 0x006387C4
		public bool IsEnable
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C283 RID: 49795
		// (get) Token: 0x0602D784 RID: 186244 RVA: 0x0063A604 File Offset: 0x00638804
		public TDisableAlertCondition AutoDisableConditionType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return TDisableAlertCondition.NONE;
				}
				return (TDisableAlertCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D785 RID: 186245 RVA: 0x0063A644 File Offset: 0x00638844
		public TTable? AutoDisableCondition<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602D786 RID: 186246 RVA: 0x0063A68C File Offset: 0x0063888C
		public IDisableAlertAreaDungeonCondition AutoDisableConditionAsIDisableAlertAreaDungeonCondition()
		{
			return this.AutoDisableCondition<IDisableAlertAreaDungeonCondition>().Value;
		}

		// Token: 0x0602D787 RID: 186247 RVA: 0x0063A6A8 File Offset: 0x006388A8
		public IDisableAlertAreaQuestCondition AutoDisableConditionAsIDisableAlertAreaQuestCondition()
		{
			return this.AutoDisableCondition<IDisableAlertAreaQuestCondition>().Value;
		}

		// Token: 0x0602D788 RID: 186248 RVA: 0x0063A6C3 File Offset: 0x006388C3
		public static Offset<IEnableAlertArea> CreateIEnableAlertArea(FlatBufferBuilder builder, EAlertSystemOption Type = EAlertSystemOption.EnableAlertArea, int AreaId = 0, bool IsEnable = false, TDisableAlertCondition AutoDisableCondition_type = TDisableAlertCondition.NONE, int AutoDisableConditionOffset = 0)
		{
			builder.StartTable(5);
			IEnableAlertArea.AddAutoDisableCondition(builder, AutoDisableConditionOffset);
			IEnableAlertArea.AddAreaId(builder, AreaId);
			IEnableAlertArea.AddAutoDisableConditionType(builder, AutoDisableCondition_type);
			IEnableAlertArea.AddIsEnable(builder, IsEnable);
			IEnableAlertArea.AddType(builder, Type);
			return IEnableAlertArea.EndIEnableAlertArea(builder);
		}

		// Token: 0x0602D789 RID: 186249 RVA: 0x0063A6F7 File Offset: 0x006388F7
		public static void StartIEnableAlertArea(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602D78A RID: 186250 RVA: 0x0063A700 File Offset: 0x00638900
		public static void AddType(FlatBufferBuilder builder, EAlertSystemOption type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D78B RID: 186251 RVA: 0x0063A70B File Offset: 0x0063890B
		public static void AddAreaId(FlatBufferBuilder builder, int areaId)
		{
			builder.AddInt(1, areaId, 0);
		}

		// Token: 0x0602D78C RID: 186252 RVA: 0x0063A716 File Offset: 0x00638916
		public static void AddIsEnable(FlatBufferBuilder builder, bool isEnable)
		{
			builder.AddBool(2, isEnable, false);
		}

		// Token: 0x0602D78D RID: 186253 RVA: 0x0063A721 File Offset: 0x00638921
		public static void AddAutoDisableConditionType(FlatBufferBuilder builder, TDisableAlertCondition autoDisableConditionType)
		{
			builder.AddByte(3, (byte)autoDisableConditionType, 0);
		}

		// Token: 0x0602D78E RID: 186254 RVA: 0x0063A72C File Offset: 0x0063892C
		public static void AddAutoDisableCondition(FlatBufferBuilder builder, int autoDisableConditionOffset)
		{
			builder.AddOffset(4, autoDisableConditionOffset, 0);
		}

		// Token: 0x0602D78F RID: 186255 RVA: 0x0063A737 File Offset: 0x00638937
		public static Offset<IEnableAlertArea> EndIEnableAlertArea(FlatBufferBuilder builder)
		{
			return new Offset<IEnableAlertArea>(builder.EndTable());
		}

		// Token: 0x0602D790 RID: 186256 RVA: 0x0063A744 File Offset: 0x00638944
		public IEnableAlertAreaT UnPack()
		{
			IEnableAlertAreaT enableAlertAreaT = new IEnableAlertAreaT();
			this.UnPackTo(enableAlertAreaT);
			return enableAlertAreaT;
		}

		// Token: 0x0602D791 RID: 186257 RVA: 0x0063A760 File Offset: 0x00638960
		public void UnPackTo(IEnableAlertAreaT _o)
		{
			_o.Type = this.Type;
			_o.AreaId = this.AreaId;
			_o.IsEnable = this.IsEnable;
			_o.AutoDisableCondition = new TDisableAlertConditionUnion();
			_o.AutoDisableCondition.Type = this.AutoDisableConditionType;
			TDisableAlertCondition autoDisableConditionType = this.AutoDisableConditionType;
			if (autoDisableConditionType == TDisableAlertCondition.IDisableAlertAreaDungeonCondition)
			{
				_o.AutoDisableCondition.Value = ((this.AutoDisableCondition<IDisableAlertAreaDungeonCondition>() != null) ? this.AutoDisableCondition<IDisableAlertAreaDungeonCondition>().Value.UnPack() : null);
				return;
			}
			if (autoDisableConditionType != TDisableAlertCondition.IDisableAlertAreaQuestCondition)
			{
				return;
			}
			_o.AutoDisableCondition.Value = ((this.AutoDisableCondition<IDisableAlertAreaQuestCondition>() != null) ? this.AutoDisableCondition<IDisableAlertAreaQuestCondition>().Value.UnPack() : null);
		}

		// Token: 0x0602D792 RID: 186258 RVA: 0x0063A828 File Offset: 0x00638A28
		public static Offset<IEnableAlertArea> Pack(FlatBufferBuilder builder, IEnableAlertAreaT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnableAlertArea>);
			}
			TDisableAlertCondition autoDisableCondition_type = (_o.AutoDisableCondition == null) ? TDisableAlertCondition.NONE : _o.AutoDisableCondition.Type;
			int autoDisableConditionOffset = (_o.AutoDisableCondition == null) ? 0 : TDisableAlertConditionUnion.Pack(builder, _o.AutoDisableCondition);
			return IEnableAlertArea.CreateIEnableAlertArea(builder, _o.Type, _o.AreaId, _o.IsEnable, autoDisableCondition_type, autoDisableConditionOffset);
		}

		// Token: 0x04010CDD RID: 68829
		private Table __p;
	}
}
