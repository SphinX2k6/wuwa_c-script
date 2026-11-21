using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077CA RID: 30666
	public struct ISetHorizontalVerticalSpeedImmediately : IFlatbufferObject
	{
		// Token: 0x1700E0CD RID: 57549
		// (get) Token: 0x06035DE1 RID: 220641 RVA: 0x00737A8C File Offset: 0x00735C8C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035DE2 RID: 220642 RVA: 0x00737A99 File Offset: 0x00735C99
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035DE3 RID: 220643 RVA: 0x00737AA0 File Offset: 0x00735CA0
		public static ISetHorizontalVerticalSpeedImmediately GetRootAsISetHorizontalVerticalSpeedImmediately(ByteBuffer _bb)
		{
			return ISetHorizontalVerticalSpeedImmediately.GetRootAsISetHorizontalVerticalSpeedImmediately(_bb, default(ISetHorizontalVerticalSpeedImmediately));
		}

		// Token: 0x06035DE4 RID: 220644 RVA: 0x00737ABC File Offset: 0x00735CBC
		public static ISetHorizontalVerticalSpeedImmediately GetRootAsISetHorizontalVerticalSpeedImmediately(ByteBuffer _bb, ISetHorizontalVerticalSpeedImmediately obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035DE5 RID: 220645 RVA: 0x00737AD9 File Offset: 0x00735CD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035DE6 RID: 220646 RVA: 0x00737AE8 File Offset: 0x00735CE8
		public ISetHorizontalVerticalSpeedImmediately __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E0CE RID: 57550
		// (get) Token: 0x06035DE7 RID: 220647 RVA: 0x00737AF8 File Offset: 0x00735CF8
		public ESetVehicleSpeedImmediatelyType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESetVehicleSpeedImmediatelyType.TotalSpeed;
				}
				return (ESetVehicleSpeedImmediatelyType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E0CF RID: 57551
		// (get) Token: 0x06035DE8 RID: 220648 RVA: 0x00737B34 File Offset: 0x00735D34
		public TProcessedValue HorizontalSpeedType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TProcessedValue.NONE;
				}
				return (TProcessedValue)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035DE9 RID: 220649 RVA: 0x00737B70 File Offset: 0x00735D70
		public TTable? HorizontalSpeed<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06035DEA RID: 220650 RVA: 0x00737BB4 File Offset: 0x00735DB4
		public IProcessedValueConstant HorizontalSpeedAsIProcessedValueConstant()
		{
			return this.HorizontalSpeed<IProcessedValueConstant>().Value;
		}

		// Token: 0x06035DEB RID: 220651 RVA: 0x00737BD0 File Offset: 0x00735DD0
		public IProcessedValueConstraint HorizontalSpeedAsIProcessedValueConstraint()
		{
			return this.HorizontalSpeed<IProcessedValueConstraint>().Value;
		}

		// Token: 0x1700E0D0 RID: 57552
		// (get) Token: 0x06035DEC RID: 220652 RVA: 0x00737BEC File Offset: 0x00735DEC
		public TProcessedValue VerticalSpeedType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return TProcessedValue.NONE;
				}
				return (TProcessedValue)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035DED RID: 220653 RVA: 0x00737C2C File Offset: 0x00735E2C
		public TTable? VerticalSpeed<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06035DEE RID: 220654 RVA: 0x00737C74 File Offset: 0x00735E74
		public IProcessedValueConstant VerticalSpeedAsIProcessedValueConstant()
		{
			return this.VerticalSpeed<IProcessedValueConstant>().Value;
		}

		// Token: 0x06035DEF RID: 220655 RVA: 0x00737C90 File Offset: 0x00735E90
		public IProcessedValueConstraint VerticalSpeedAsIProcessedValueConstraint()
		{
			return this.VerticalSpeed<IProcessedValueConstraint>().Value;
		}

		// Token: 0x06035DF0 RID: 220656 RVA: 0x00737CAB File Offset: 0x00735EAB
		public static Offset<ISetHorizontalVerticalSpeedImmediately> CreateISetHorizontalVerticalSpeedImmediately(FlatBufferBuilder builder, ESetVehicleSpeedImmediatelyType Type = ESetVehicleSpeedImmediatelyType.TotalSpeed, TProcessedValue HorizontalSpeed_type = TProcessedValue.NONE, int HorizontalSpeedOffset = 0, TProcessedValue VerticalSpeed_type = TProcessedValue.NONE, int VerticalSpeedOffset = 0)
		{
			builder.StartTable(5);
			ISetHorizontalVerticalSpeedImmediately.AddVerticalSpeed(builder, VerticalSpeedOffset);
			ISetHorizontalVerticalSpeedImmediately.AddHorizontalSpeed(builder, HorizontalSpeedOffset);
			ISetHorizontalVerticalSpeedImmediately.AddVerticalSpeedType(builder, VerticalSpeed_type);
			ISetHorizontalVerticalSpeedImmediately.AddHorizontalSpeedType(builder, HorizontalSpeed_type);
			ISetHorizontalVerticalSpeedImmediately.AddType(builder, Type);
			return ISetHorizontalVerticalSpeedImmediately.EndISetHorizontalVerticalSpeedImmediately(builder);
		}

		// Token: 0x06035DF1 RID: 220657 RVA: 0x00737CDF File Offset: 0x00735EDF
		public static void StartISetHorizontalVerticalSpeedImmediately(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06035DF2 RID: 220658 RVA: 0x00737CE8 File Offset: 0x00735EE8
		public static void AddType(FlatBufferBuilder builder, ESetVehicleSpeedImmediatelyType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035DF3 RID: 220659 RVA: 0x00737CF3 File Offset: 0x00735EF3
		public static void AddHorizontalSpeedType(FlatBufferBuilder builder, TProcessedValue horizontalSpeedType)
		{
			builder.AddByte(1, (byte)horizontalSpeedType, 0);
		}

		// Token: 0x06035DF4 RID: 220660 RVA: 0x00737CFE File Offset: 0x00735EFE
		public static void AddHorizontalSpeed(FlatBufferBuilder builder, int horizontalSpeedOffset)
		{
			builder.AddOffset(2, horizontalSpeedOffset, 0);
		}

		// Token: 0x06035DF5 RID: 220661 RVA: 0x00737D09 File Offset: 0x00735F09
		public static void AddVerticalSpeedType(FlatBufferBuilder builder, TProcessedValue verticalSpeedType)
		{
			builder.AddByte(3, (byte)verticalSpeedType, 0);
		}

		// Token: 0x06035DF6 RID: 220662 RVA: 0x00737D14 File Offset: 0x00735F14
		public static void AddVerticalSpeed(FlatBufferBuilder builder, int verticalSpeedOffset)
		{
			builder.AddOffset(4, verticalSpeedOffset, 0);
		}

		// Token: 0x06035DF7 RID: 220663 RVA: 0x00737D1F File Offset: 0x00735F1F
		public static Offset<ISetHorizontalVerticalSpeedImmediately> EndISetHorizontalVerticalSpeedImmediately(FlatBufferBuilder builder)
		{
			return new Offset<ISetHorizontalVerticalSpeedImmediately>(builder.EndTable());
		}

		// Token: 0x06035DF8 RID: 220664 RVA: 0x00737D2C File Offset: 0x00735F2C
		public ISetHorizontalVerticalSpeedImmediatelyT UnPack()
		{
			ISetHorizontalVerticalSpeedImmediatelyT setHorizontalVerticalSpeedImmediatelyT = new ISetHorizontalVerticalSpeedImmediatelyT();
			this.UnPackTo(setHorizontalVerticalSpeedImmediatelyT);
			return setHorizontalVerticalSpeedImmediatelyT;
		}

		// Token: 0x06035DF9 RID: 220665 RVA: 0x00737D48 File Offset: 0x00735F48
		public void UnPackTo(ISetHorizontalVerticalSpeedImmediatelyT _o)
		{
			_o.Type = this.Type;
			_o.HorizontalSpeed = new TProcessedValueUnion();
			_o.HorizontalSpeed.Type = this.HorizontalSpeedType;
			TProcessedValue tprocessedValue = this.HorizontalSpeedType;
			if (tprocessedValue != TProcessedValue.IProcessedValueConstant)
			{
				if (tprocessedValue == TProcessedValue.IProcessedValueConstraint)
				{
					_o.HorizontalSpeed.Value = ((this.HorizontalSpeed<IProcessedValueConstraint>() != null) ? this.HorizontalSpeed<IProcessedValueConstraint>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.HorizontalSpeed.Value = ((this.HorizontalSpeed<IProcessedValueConstant>() != null) ? this.HorizontalSpeed<IProcessedValueConstant>().Value.UnPack() : null);
			}
			_o.VerticalSpeed = new TProcessedValueUnion();
			_o.VerticalSpeed.Type = this.VerticalSpeedType;
			tprocessedValue = this.VerticalSpeedType;
			if (tprocessedValue == TProcessedValue.IProcessedValueConstant)
			{
				_o.VerticalSpeed.Value = ((this.VerticalSpeed<IProcessedValueConstant>() != null) ? this.VerticalSpeed<IProcessedValueConstant>().Value.UnPack() : null);
				return;
			}
			if (tprocessedValue != TProcessedValue.IProcessedValueConstraint)
			{
				return;
			}
			_o.VerticalSpeed.Value = ((this.VerticalSpeed<IProcessedValueConstraint>() != null) ? this.VerticalSpeed<IProcessedValueConstraint>().Value.UnPack() : null);
		}

		// Token: 0x06035DFA RID: 220666 RVA: 0x00737E90 File Offset: 0x00736090
		public static Offset<ISetHorizontalVerticalSpeedImmediately> Pack(FlatBufferBuilder builder, ISetHorizontalVerticalSpeedImmediatelyT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetHorizontalVerticalSpeedImmediately>);
			}
			TProcessedValue horizontalSpeed_type = (_o.HorizontalSpeed == null) ? TProcessedValue.NONE : _o.HorizontalSpeed.Type;
			int horizontalSpeedOffset = (_o.HorizontalSpeed == null) ? 0 : TProcessedValueUnion.Pack(builder, _o.HorizontalSpeed);
			TProcessedValue verticalSpeed_type = (_o.VerticalSpeed == null) ? TProcessedValue.NONE : _o.VerticalSpeed.Type;
			int verticalSpeedOffset = (_o.VerticalSpeed == null) ? 0 : TProcessedValueUnion.Pack(builder, _o.VerticalSpeed);
			return ISetHorizontalVerticalSpeedImmediately.CreateISetHorizontalVerticalSpeedImmediately(builder, _o.Type, horizontalSpeed_type, horizontalSpeedOffset, verticalSpeed_type, verticalSpeedOffset);
		}

		// Token: 0x04012A0A RID: 76298
		private Table __p;
	}
}
