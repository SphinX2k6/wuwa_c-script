using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CB3 RID: 27827
	public struct IEnableAlertArea : IFlatbufferObject
	{
		// Token: 0x1700CC1D RID: 52253
		// (get) Token: 0x0602FF4C RID: 196428 RVA: 0x00687047 File Offset: 0x00685247
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FF4D RID: 196429 RVA: 0x00687054 File Offset: 0x00685254
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FF4E RID: 196430 RVA: 0x0068705C File Offset: 0x0068525C
		public static IEnableAlertArea GetRootAsIEnableAlertArea(ByteBuffer _bb)
		{
			return IEnableAlertArea.GetRootAsIEnableAlertArea(_bb, default(IEnableAlertArea));
		}

		// Token: 0x0602FF4F RID: 196431 RVA: 0x00687078 File Offset: 0x00685278
		public static IEnableAlertArea GetRootAsIEnableAlertArea(ByteBuffer _bb, IEnableAlertArea obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FF50 RID: 196432 RVA: 0x00687095 File Offset: 0x00685295
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FF51 RID: 196433 RVA: 0x006870A4 File Offset: 0x006852A4
		public IEnableAlertArea __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CC1E RID: 52254
		// (get) Token: 0x0602FF52 RID: 196434 RVA: 0x006870B4 File Offset: 0x006852B4
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

		// Token: 0x1700CC1F RID: 52255
		// (get) Token: 0x0602FF53 RID: 196435 RVA: 0x006870F0 File Offset: 0x006852F0
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

		// Token: 0x1700CC20 RID: 52256
		// (get) Token: 0x0602FF54 RID: 196436 RVA: 0x0068712C File Offset: 0x0068532C
		public bool IsEnable
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CC21 RID: 52257
		// (get) Token: 0x0602FF55 RID: 196437 RVA: 0x0068716C File Offset: 0x0068536C
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

		// Token: 0x0602FF56 RID: 196438 RVA: 0x006871AC File Offset: 0x006853AC
		public TTable? AutoDisableCondition<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602FF57 RID: 196439 RVA: 0x006871F4 File Offset: 0x006853F4
		public IDisableAlertAreaDungeonCondition AutoDisableConditionAsIDisableAlertAreaDungeonCondition()
		{
			return this.AutoDisableCondition<IDisableAlertAreaDungeonCondition>().Value;
		}

		// Token: 0x0602FF58 RID: 196440 RVA: 0x00687210 File Offset: 0x00685410
		public IDisableAlertAreaQuestCondition AutoDisableConditionAsIDisableAlertAreaQuestCondition()
		{
			return this.AutoDisableCondition<IDisableAlertAreaQuestCondition>().Value;
		}

		// Token: 0x0602FF59 RID: 196441 RVA: 0x0068722B File Offset: 0x0068542B
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

		// Token: 0x0602FF5A RID: 196442 RVA: 0x0068725F File Offset: 0x0068545F
		public static void StartIEnableAlertArea(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602FF5B RID: 196443 RVA: 0x00687268 File Offset: 0x00685468
		public static void AddType(FlatBufferBuilder builder, EAlertSystemOption type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FF5C RID: 196444 RVA: 0x00687273 File Offset: 0x00685473
		public static void AddAreaId(FlatBufferBuilder builder, int areaId)
		{
			builder.AddInt(1, areaId, 0);
		}

		// Token: 0x0602FF5D RID: 196445 RVA: 0x0068727E File Offset: 0x0068547E
		public static void AddIsEnable(FlatBufferBuilder builder, bool isEnable)
		{
			builder.AddBool(2, isEnable, false);
		}

		// Token: 0x0602FF5E RID: 196446 RVA: 0x00687289 File Offset: 0x00685489
		public static void AddAutoDisableConditionType(FlatBufferBuilder builder, TDisableAlertCondition autoDisableConditionType)
		{
			builder.AddByte(3, (byte)autoDisableConditionType, 0);
		}

		// Token: 0x0602FF5F RID: 196447 RVA: 0x00687294 File Offset: 0x00685494
		public static void AddAutoDisableCondition(FlatBufferBuilder builder, int autoDisableConditionOffset)
		{
			builder.AddOffset(4, autoDisableConditionOffset, 0);
		}

		// Token: 0x0602FF60 RID: 196448 RVA: 0x0068729F File Offset: 0x0068549F
		public static Offset<IEnableAlertArea> EndIEnableAlertArea(FlatBufferBuilder builder)
		{
			return new Offset<IEnableAlertArea>(builder.EndTable());
		}

		// Token: 0x0602FF61 RID: 196449 RVA: 0x006872AC File Offset: 0x006854AC
		public IEnableAlertAreaT UnPack()
		{
			IEnableAlertAreaT enableAlertAreaT = new IEnableAlertAreaT();
			this.UnPackTo(enableAlertAreaT);
			return enableAlertAreaT;
		}

		// Token: 0x0602FF62 RID: 196450 RVA: 0x006872C8 File Offset: 0x006854C8
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

		// Token: 0x0602FF63 RID: 196451 RVA: 0x00687390 File Offset: 0x00685590
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

		// Token: 0x04011AF8 RID: 72440
		private Table __p;
	}
}
