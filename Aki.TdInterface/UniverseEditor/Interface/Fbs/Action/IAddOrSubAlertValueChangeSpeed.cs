using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006131 RID: 24881
	public struct IAddOrSubAlertValueChangeSpeed : IFlatbufferObject
	{
		// Token: 0x1700B761 RID: 46945
		// (get) Token: 0x0602A885 RID: 174213 RVA: 0x005DB4BE File Offset: 0x005D96BE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A886 RID: 174214 RVA: 0x005DB4CB File Offset: 0x005D96CB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A887 RID: 174215 RVA: 0x005DB4D4 File Offset: 0x005D96D4
		public static IAddOrSubAlertValueChangeSpeed GetRootAsIAddOrSubAlertValueChangeSpeed(ByteBuffer _bb)
		{
			return IAddOrSubAlertValueChangeSpeed.GetRootAsIAddOrSubAlertValueChangeSpeed(_bb, default(IAddOrSubAlertValueChangeSpeed));
		}

		// Token: 0x0602A888 RID: 174216 RVA: 0x005DB4F0 File Offset: 0x005D96F0
		public static IAddOrSubAlertValueChangeSpeed GetRootAsIAddOrSubAlertValueChangeSpeed(ByteBuffer _bb, IAddOrSubAlertValueChangeSpeed obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A889 RID: 174217 RVA: 0x005DB50D File Offset: 0x005D970D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A88A RID: 174218 RVA: 0x005DB51C File Offset: 0x005D971C
		public IAddOrSubAlertValueChangeSpeed __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B762 RID: 46946
		// (get) Token: 0x0602A88B RID: 174219 RVA: 0x005DB52C File Offset: 0x005D972C
		public EValueChangeType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EValueChangeType.AddOrSub;
				}
				return (EValueChangeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B763 RID: 46947
		// (get) Token: 0x0602A88C RID: 174220 RVA: 0x005DB568 File Offset: 0x005D9768
		public float DeltaValue
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602A88D RID: 174221 RVA: 0x005DB5A8 File Offset: 0x005D97A8
		public static Offset<IAddOrSubAlertValueChangeSpeed> CreateIAddOrSubAlertValueChangeSpeed(FlatBufferBuilder builder, EValueChangeType Type = EValueChangeType.AddOrSub, float DeltaValue = 0f)
		{
			builder.StartTable(2);
			IAddOrSubAlertValueChangeSpeed.AddDeltaValue(builder, DeltaValue);
			IAddOrSubAlertValueChangeSpeed.AddType(builder, Type);
			return IAddOrSubAlertValueChangeSpeed.EndIAddOrSubAlertValueChangeSpeed(builder);
		}

		// Token: 0x0602A88E RID: 174222 RVA: 0x005DB5C5 File Offset: 0x005D97C5
		public static void StartIAddOrSubAlertValueChangeSpeed(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602A88F RID: 174223 RVA: 0x005DB5CE File Offset: 0x005D97CE
		public static void AddType(FlatBufferBuilder builder, EValueChangeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A890 RID: 174224 RVA: 0x005DB5D9 File Offset: 0x005D97D9
		public static void AddDeltaValue(FlatBufferBuilder builder, float deltaValue)
		{
			builder.AddFloat(1, deltaValue, 0.0);
		}

		// Token: 0x0602A891 RID: 174225 RVA: 0x005DB5EC File Offset: 0x005D97EC
		public static Offset<IAddOrSubAlertValueChangeSpeed> EndIAddOrSubAlertValueChangeSpeed(FlatBufferBuilder builder)
		{
			return new Offset<IAddOrSubAlertValueChangeSpeed>(builder.EndTable());
		}

		// Token: 0x0602A892 RID: 174226 RVA: 0x005DB5FC File Offset: 0x005D97FC
		public IAddOrSubAlertValueChangeSpeedT UnPack()
		{
			IAddOrSubAlertValueChangeSpeedT addOrSubAlertValueChangeSpeedT = new IAddOrSubAlertValueChangeSpeedT();
			this.UnPackTo(addOrSubAlertValueChangeSpeedT);
			return addOrSubAlertValueChangeSpeedT;
		}

		// Token: 0x0602A893 RID: 174227 RVA: 0x005DB617 File Offset: 0x005D9817
		public void UnPackTo(IAddOrSubAlertValueChangeSpeedT _o)
		{
			_o.Type = this.Type;
			_o.DeltaValue = this.DeltaValue;
		}

		// Token: 0x0602A894 RID: 174228 RVA: 0x005DB634 File Offset: 0x005D9834
		public static Offset<IAddOrSubAlertValueChangeSpeed> Pack(FlatBufferBuilder builder, IAddOrSubAlertValueChangeSpeedT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAddOrSubAlertValueChangeSpeed>);
			}
			return IAddOrSubAlertValueChangeSpeed.CreateIAddOrSubAlertValueChangeSpeed(builder, _o.Type, _o.DeltaValue);
		}

		// Token: 0x04010506 RID: 66822
		private Table __p;
	}
}
