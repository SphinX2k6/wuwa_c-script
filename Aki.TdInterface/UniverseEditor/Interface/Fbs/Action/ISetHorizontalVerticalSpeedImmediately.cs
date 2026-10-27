using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007001 RID: 28673
	public struct ISetHorizontalVerticalSpeedImmediately : IFlatbufferObject
	{
		// Token: 0x1700D4F9 RID: 54521
		// (get) Token: 0x06032B7B RID: 207739 RVA: 0x006D7E48 File Offset: 0x006D6048
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032B7C RID: 207740 RVA: 0x006D7E55 File Offset: 0x006D6055
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032B7D RID: 207741 RVA: 0x006D7E5C File Offset: 0x006D605C
		public static ISetHorizontalVerticalSpeedImmediately GetRootAsISetHorizontalVerticalSpeedImmediately(ByteBuffer _bb)
		{
			return ISetHorizontalVerticalSpeedImmediately.GetRootAsISetHorizontalVerticalSpeedImmediately(_bb, default(ISetHorizontalVerticalSpeedImmediately));
		}

		// Token: 0x06032B7E RID: 207742 RVA: 0x006D7E78 File Offset: 0x006D6078
		public static ISetHorizontalVerticalSpeedImmediately GetRootAsISetHorizontalVerticalSpeedImmediately(ByteBuffer _bb, ISetHorizontalVerticalSpeedImmediately obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032B7F RID: 207743 RVA: 0x006D7E95 File Offset: 0x006D6095
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032B80 RID: 207744 RVA: 0x006D7EA4 File Offset: 0x006D60A4
		public ISetHorizontalVerticalSpeedImmediately __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D4FA RID: 54522
		// (get) Token: 0x06032B81 RID: 207745 RVA: 0x006D7EB4 File Offset: 0x006D60B4
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

		// Token: 0x1700D4FB RID: 54523
		// (get) Token: 0x06032B82 RID: 207746 RVA: 0x006D7EF0 File Offset: 0x006D60F0
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

		// Token: 0x06032B83 RID: 207747 RVA: 0x006D7F2C File Offset: 0x006D612C
		public TTable? HorizontalSpeed<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06032B84 RID: 207748 RVA: 0x006D7F70 File Offset: 0x006D6170
		public IProcessedValueConstant HorizontalSpeedAsIProcessedValueConstant()
		{
			return this.HorizontalSpeed<IProcessedValueConstant>().Value;
		}

		// Token: 0x06032B85 RID: 207749 RVA: 0x006D7F8C File Offset: 0x006D618C
		public IProcessedValueConstraint HorizontalSpeedAsIProcessedValueConstraint()
		{
			return this.HorizontalSpeed<IProcessedValueConstraint>().Value;
		}

		// Token: 0x1700D4FC RID: 54524
		// (get) Token: 0x06032B86 RID: 207750 RVA: 0x006D7FA8 File Offset: 0x006D61A8
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

		// Token: 0x06032B87 RID: 207751 RVA: 0x006D7FE8 File Offset: 0x006D61E8
		public TTable? VerticalSpeed<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06032B88 RID: 207752 RVA: 0x006D8030 File Offset: 0x006D6230
		public IProcessedValueConstant VerticalSpeedAsIProcessedValueConstant()
		{
			return this.VerticalSpeed<IProcessedValueConstant>().Value;
		}

		// Token: 0x06032B89 RID: 207753 RVA: 0x006D804C File Offset: 0x006D624C
		public IProcessedValueConstraint VerticalSpeedAsIProcessedValueConstraint()
		{
			return this.VerticalSpeed<IProcessedValueConstraint>().Value;
		}

		// Token: 0x06032B8A RID: 207754 RVA: 0x006D8067 File Offset: 0x006D6267
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

		// Token: 0x06032B8B RID: 207755 RVA: 0x006D809B File Offset: 0x006D629B
		public static void StartISetHorizontalVerticalSpeedImmediately(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06032B8C RID: 207756 RVA: 0x006D80A4 File Offset: 0x006D62A4
		public static void AddType(FlatBufferBuilder builder, ESetVehicleSpeedImmediatelyType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032B8D RID: 207757 RVA: 0x006D80AF File Offset: 0x006D62AF
		public static void AddHorizontalSpeedType(FlatBufferBuilder builder, TProcessedValue horizontalSpeedType)
		{
			builder.AddByte(1, (byte)horizontalSpeedType, 0);
		}

		// Token: 0x06032B8E RID: 207758 RVA: 0x006D80BA File Offset: 0x006D62BA
		public static void AddHorizontalSpeed(FlatBufferBuilder builder, int horizontalSpeedOffset)
		{
			builder.AddOffset(2, horizontalSpeedOffset, 0);
		}

		// Token: 0x06032B8F RID: 207759 RVA: 0x006D80C5 File Offset: 0x006D62C5
		public static void AddVerticalSpeedType(FlatBufferBuilder builder, TProcessedValue verticalSpeedType)
		{
			builder.AddByte(3, (byte)verticalSpeedType, 0);
		}

		// Token: 0x06032B90 RID: 207760 RVA: 0x006D80D0 File Offset: 0x006D62D0
		public static void AddVerticalSpeed(FlatBufferBuilder builder, int verticalSpeedOffset)
		{
			builder.AddOffset(4, verticalSpeedOffset, 0);
		}

		// Token: 0x06032B91 RID: 207761 RVA: 0x006D80DB File Offset: 0x006D62DB
		public static Offset<ISetHorizontalVerticalSpeedImmediately> EndISetHorizontalVerticalSpeedImmediately(FlatBufferBuilder builder)
		{
			return new Offset<ISetHorizontalVerticalSpeedImmediately>(builder.EndTable());
		}

		// Token: 0x06032B92 RID: 207762 RVA: 0x006D80E8 File Offset: 0x006D62E8
		public ISetHorizontalVerticalSpeedImmediatelyT UnPack()
		{
			ISetHorizontalVerticalSpeedImmediatelyT setHorizontalVerticalSpeedImmediatelyT = new ISetHorizontalVerticalSpeedImmediatelyT();
			this.UnPackTo(setHorizontalVerticalSpeedImmediatelyT);
			return setHorizontalVerticalSpeedImmediatelyT;
		}

		// Token: 0x06032B93 RID: 207763 RVA: 0x006D8104 File Offset: 0x006D6304
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

		// Token: 0x06032B94 RID: 207764 RVA: 0x006D824C File Offset: 0x006D644C
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

		// Token: 0x04011A25 RID: 72229
		private Table __p;
	}
}
