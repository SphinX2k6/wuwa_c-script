using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006796 RID: 26518
	public struct IAddOrSubAlertValueChangeSpeed : IFlatbufferObject
	{
		// Token: 0x1700C0D1 RID: 49361
		// (get) Token: 0x0602CF7E RID: 184190 RVA: 0x0062569A File Offset: 0x0062389A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CF7F RID: 184191 RVA: 0x006256A7 File Offset: 0x006238A7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CF80 RID: 184192 RVA: 0x006256B0 File Offset: 0x006238B0
		public static IAddOrSubAlertValueChangeSpeed GetRootAsIAddOrSubAlertValueChangeSpeed(ByteBuffer _bb)
		{
			return IAddOrSubAlertValueChangeSpeed.GetRootAsIAddOrSubAlertValueChangeSpeed(_bb, default(IAddOrSubAlertValueChangeSpeed));
		}

		// Token: 0x0602CF81 RID: 184193 RVA: 0x006256CC File Offset: 0x006238CC
		public static IAddOrSubAlertValueChangeSpeed GetRootAsIAddOrSubAlertValueChangeSpeed(ByteBuffer _bb, IAddOrSubAlertValueChangeSpeed obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CF82 RID: 184194 RVA: 0x006256E9 File Offset: 0x006238E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CF83 RID: 184195 RVA: 0x006256F8 File Offset: 0x006238F8
		public IAddOrSubAlertValueChangeSpeed __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C0D2 RID: 49362
		// (get) Token: 0x0602CF84 RID: 184196 RVA: 0x00625708 File Offset: 0x00623908
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

		// Token: 0x1700C0D3 RID: 49363
		// (get) Token: 0x0602CF85 RID: 184197 RVA: 0x00625744 File Offset: 0x00623944
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

		// Token: 0x0602CF86 RID: 184198 RVA: 0x00625784 File Offset: 0x00623984
		public static Offset<IAddOrSubAlertValueChangeSpeed> CreateIAddOrSubAlertValueChangeSpeed(FlatBufferBuilder builder, EValueChangeType Type = EValueChangeType.AddOrSub, float DeltaValue = 0f)
		{
			builder.StartTable(2);
			IAddOrSubAlertValueChangeSpeed.AddDeltaValue(builder, DeltaValue);
			IAddOrSubAlertValueChangeSpeed.AddType(builder, Type);
			return IAddOrSubAlertValueChangeSpeed.EndIAddOrSubAlertValueChangeSpeed(builder);
		}

		// Token: 0x0602CF87 RID: 184199 RVA: 0x006257A1 File Offset: 0x006239A1
		public static void StartIAddOrSubAlertValueChangeSpeed(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602CF88 RID: 184200 RVA: 0x006257AA File Offset: 0x006239AA
		public static void AddType(FlatBufferBuilder builder, EValueChangeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CF89 RID: 184201 RVA: 0x006257B5 File Offset: 0x006239B5
		public static void AddDeltaValue(FlatBufferBuilder builder, float deltaValue)
		{
			builder.AddFloat(1, deltaValue, 0.0);
		}

		// Token: 0x0602CF8A RID: 184202 RVA: 0x006257C8 File Offset: 0x006239C8
		public static Offset<IAddOrSubAlertValueChangeSpeed> EndIAddOrSubAlertValueChangeSpeed(FlatBufferBuilder builder)
		{
			return new Offset<IAddOrSubAlertValueChangeSpeed>(builder.EndTable());
		}

		// Token: 0x0602CF8B RID: 184203 RVA: 0x006257D8 File Offset: 0x006239D8
		public IAddOrSubAlertValueChangeSpeedT UnPack()
		{
			IAddOrSubAlertValueChangeSpeedT addOrSubAlertValueChangeSpeedT = new IAddOrSubAlertValueChangeSpeedT();
			this.UnPackTo(addOrSubAlertValueChangeSpeedT);
			return addOrSubAlertValueChangeSpeedT;
		}

		// Token: 0x0602CF8C RID: 184204 RVA: 0x006257F3 File Offset: 0x006239F3
		public void UnPackTo(IAddOrSubAlertValueChangeSpeedT _o)
		{
			_o.Type = this.Type;
			_o.DeltaValue = this.DeltaValue;
		}

		// Token: 0x0602CF8D RID: 184205 RVA: 0x00625810 File Offset: 0x00623A10
		public static Offset<IAddOrSubAlertValueChangeSpeed> Pack(FlatBufferBuilder builder, IAddOrSubAlertValueChangeSpeedT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAddOrSubAlertValueChangeSpeed>);
			}
			return IAddOrSubAlertValueChangeSpeed.CreateIAddOrSubAlertValueChangeSpeed(builder, _o.Type, _o.DeltaValue);
		}

		// Token: 0x0401130D RID: 70413
		private Table __p;
	}
}
