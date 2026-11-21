using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B63 RID: 27491
	public struct ICustomAlertValueChangeSpeed : IFlatbufferObject
	{
		// Token: 0x1700C9CB RID: 51659
		// (get) Token: 0x0602F4E9 RID: 193769 RVA: 0x006750FA File Offset: 0x006732FA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F4EA RID: 193770 RVA: 0x00675107 File Offset: 0x00673307
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F4EB RID: 193771 RVA: 0x00675110 File Offset: 0x00673310
		public static ICustomAlertValueChangeSpeed GetRootAsICustomAlertValueChangeSpeed(ByteBuffer _bb)
		{
			return ICustomAlertValueChangeSpeed.GetRootAsICustomAlertValueChangeSpeed(_bb, default(ICustomAlertValueChangeSpeed));
		}

		// Token: 0x0602F4EC RID: 193772 RVA: 0x0067512C File Offset: 0x0067332C
		public static ICustomAlertValueChangeSpeed GetRootAsICustomAlertValueChangeSpeed(ByteBuffer _bb, ICustomAlertValueChangeSpeed obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F4ED RID: 193773 RVA: 0x00675149 File Offset: 0x00673349
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F4EE RID: 193774 RVA: 0x00675158 File Offset: 0x00673358
		public ICustomAlertValueChangeSpeed __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C9CC RID: 51660
		// (get) Token: 0x0602F4EF RID: 193775 RVA: 0x00675168 File Offset: 0x00673368
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

		// Token: 0x1700C9CD RID: 51661
		// (get) Token: 0x0602F4F0 RID: 193776 RVA: 0x006751A4 File Offset: 0x006733A4
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

		// Token: 0x0602F4F1 RID: 193777 RVA: 0x006751E4 File Offset: 0x006733E4
		public static Offset<ICustomAlertValueChangeSpeed> CreateICustomAlertValueChangeSpeed(FlatBufferBuilder builder, EValueChangeType Type = EValueChangeType.AddOrSub, float CustomValue = 0f)
		{
			builder.StartTable(2);
			ICustomAlertValueChangeSpeed.AddCustomValue(builder, CustomValue);
			ICustomAlertValueChangeSpeed.AddType(builder, Type);
			return ICustomAlertValueChangeSpeed.EndICustomAlertValueChangeSpeed(builder);
		}

		// Token: 0x0602F4F2 RID: 193778 RVA: 0x00675201 File Offset: 0x00673401
		public static void StartICustomAlertValueChangeSpeed(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602F4F3 RID: 193779 RVA: 0x0067520A File Offset: 0x0067340A
		public static void AddType(FlatBufferBuilder builder, EValueChangeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F4F4 RID: 193780 RVA: 0x00675215 File Offset: 0x00673415
		public static void AddCustomValue(FlatBufferBuilder builder, float customValue)
		{
			builder.AddFloat(1, customValue, 0.0);
		}

		// Token: 0x0602F4F5 RID: 193781 RVA: 0x00675228 File Offset: 0x00673428
		public static Offset<ICustomAlertValueChangeSpeed> EndICustomAlertValueChangeSpeed(FlatBufferBuilder builder)
		{
			return new Offset<ICustomAlertValueChangeSpeed>(builder.EndTable());
		}

		// Token: 0x0602F4F6 RID: 193782 RVA: 0x00675238 File Offset: 0x00673438
		public ICustomAlertValueChangeSpeedT UnPack()
		{
			ICustomAlertValueChangeSpeedT customAlertValueChangeSpeedT = new ICustomAlertValueChangeSpeedT();
			this.UnPackTo(customAlertValueChangeSpeedT);
			return customAlertValueChangeSpeedT;
		}

		// Token: 0x0602F4F7 RID: 193783 RVA: 0x00675253 File Offset: 0x00673453
		public void UnPackTo(ICustomAlertValueChangeSpeedT _o)
		{
			_o.Type = this.Type;
			_o.CustomValue = this.CustomValue;
		}

		// Token: 0x0602F4F8 RID: 193784 RVA: 0x00675270 File Offset: 0x00673470
		public static Offset<ICustomAlertValueChangeSpeed> Pack(FlatBufferBuilder builder, ICustomAlertValueChangeSpeedT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICustomAlertValueChangeSpeed>);
			}
			return ICustomAlertValueChangeSpeed.CreateICustomAlertValueChangeSpeed(builder, _o.Type, _o.CustomValue);
		}

		// Token: 0x04011950 RID: 72016
		private Table __p;
	}
}
