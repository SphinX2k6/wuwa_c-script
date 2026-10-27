using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064F5 RID: 25845
	public struct ICustomAlertValueChangeSpeed : IFlatbufferObject
	{
		// Token: 0x1700C03B RID: 49211
		// (get) Token: 0x0602CD53 RID: 183635 RVA: 0x00628E5A File Offset: 0x0062705A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CD54 RID: 183636 RVA: 0x00628E67 File Offset: 0x00627067
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CD55 RID: 183637 RVA: 0x00628E70 File Offset: 0x00627070
		public static ICustomAlertValueChangeSpeed GetRootAsICustomAlertValueChangeSpeed(ByteBuffer _bb)
		{
			return ICustomAlertValueChangeSpeed.GetRootAsICustomAlertValueChangeSpeed(_bb, default(ICustomAlertValueChangeSpeed));
		}

		// Token: 0x0602CD56 RID: 183638 RVA: 0x00628E8C File Offset: 0x0062708C
		public static ICustomAlertValueChangeSpeed GetRootAsICustomAlertValueChangeSpeed(ByteBuffer _bb, ICustomAlertValueChangeSpeed obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CD57 RID: 183639 RVA: 0x00628EA9 File Offset: 0x006270A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CD58 RID: 183640 RVA: 0x00628EB8 File Offset: 0x006270B8
		public ICustomAlertValueChangeSpeed __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C03C RID: 49212
		// (get) Token: 0x0602CD59 RID: 183641 RVA: 0x00628EC8 File Offset: 0x006270C8
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

		// Token: 0x1700C03D RID: 49213
		// (get) Token: 0x0602CD5A RID: 183642 RVA: 0x00628F04 File Offset: 0x00627104
		public float CustomValue
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

		// Token: 0x0602CD5B RID: 183643 RVA: 0x00628F44 File Offset: 0x00627144
		public static Offset<ICustomAlertValueChangeSpeed> CreateICustomAlertValueChangeSpeed(FlatBufferBuilder builder, EValueChangeType Type = EValueChangeType.AddOrSub, float CustomValue = 0f)
		{
			builder.StartTable(2);
			ICustomAlertValueChangeSpeed.AddCustomValue(builder, CustomValue);
			ICustomAlertValueChangeSpeed.AddType(builder, Type);
			return ICustomAlertValueChangeSpeed.EndICustomAlertValueChangeSpeed(builder);
		}

		// Token: 0x0602CD5C RID: 183644 RVA: 0x00628F61 File Offset: 0x00627161
		public static void StartICustomAlertValueChangeSpeed(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602CD5D RID: 183645 RVA: 0x00628F6A File Offset: 0x0062716A
		public static void AddType(FlatBufferBuilder builder, EValueChangeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CD5E RID: 183646 RVA: 0x00628F75 File Offset: 0x00627175
		public static void AddCustomValue(FlatBufferBuilder builder, float customValue)
		{
			builder.AddFloat(1, customValue, 0.0);
		}

		// Token: 0x0602CD5F RID: 183647 RVA: 0x00628F88 File Offset: 0x00627188
		public static Offset<ICustomAlertValueChangeSpeed> EndICustomAlertValueChangeSpeed(FlatBufferBuilder builder)
		{
			return new Offset<ICustomAlertValueChangeSpeed>(builder.EndTable());
		}

		// Token: 0x0602CD60 RID: 183648 RVA: 0x00628F98 File Offset: 0x00627198
		public ICustomAlertValueChangeSpeedT UnPack()
		{
			ICustomAlertValueChangeSpeedT customAlertValueChangeSpeedT = new ICustomAlertValueChangeSpeedT();
			this.UnPackTo(customAlertValueChangeSpeedT);
			return customAlertValueChangeSpeedT;
		}

		// Token: 0x0602CD61 RID: 183649 RVA: 0x00628FB3 File Offset: 0x006271B3
		public void UnPackTo(ICustomAlertValueChangeSpeedT _o)
		{
			_o.Type = this.Type;
			_o.CustomValue = this.CustomValue;
		}

		// Token: 0x0602CD62 RID: 183650 RVA: 0x00628FD0 File Offset: 0x006271D0
		public static Offset<ICustomAlertValueChangeSpeed> Pack(FlatBufferBuilder builder, ICustomAlertValueChangeSpeedT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICustomAlertValueChangeSpeed>);
			}
			return ICustomAlertValueChangeSpeed.CreateICustomAlertValueChangeSpeed(builder, _o.Type, _o.CustomValue);
		}

		// Token: 0x04010B38 RID: 68408
		private Table __p;
	}
}
