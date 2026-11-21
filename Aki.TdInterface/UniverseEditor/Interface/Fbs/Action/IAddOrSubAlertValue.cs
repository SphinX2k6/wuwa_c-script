using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006793 RID: 26515
	public struct IAddOrSubAlertValue : IFlatbufferObject
	{
		// Token: 0x1700C0CC RID: 49356
		// (get) Token: 0x0602CF68 RID: 184168 RVA: 0x0062548C File Offset: 0x0062368C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CF69 RID: 184169 RVA: 0x00625499 File Offset: 0x00623699
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CF6A RID: 184170 RVA: 0x006254A0 File Offset: 0x006236A0
		public static IAddOrSubAlertValue GetRootAsIAddOrSubAlertValue(ByteBuffer _bb)
		{
			return IAddOrSubAlertValue.GetRootAsIAddOrSubAlertValue(_bb, default(IAddOrSubAlertValue));
		}

		// Token: 0x0602CF6B RID: 184171 RVA: 0x006254BC File Offset: 0x006236BC
		public static IAddOrSubAlertValue GetRootAsIAddOrSubAlertValue(ByteBuffer _bb, IAddOrSubAlertValue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CF6C RID: 184172 RVA: 0x006254D9 File Offset: 0x006236D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CF6D RID: 184173 RVA: 0x006254E8 File Offset: 0x006236E8
		public IAddOrSubAlertValue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C0CD RID: 49357
		// (get) Token: 0x0602CF6E RID: 184174 RVA: 0x006254F8 File Offset: 0x006236F8
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

		// Token: 0x1700C0CE RID: 49358
		// (get) Token: 0x0602CF6F RID: 184175 RVA: 0x00625534 File Offset: 0x00623734
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

		// Token: 0x0602CF70 RID: 184176 RVA: 0x00625574 File Offset: 0x00623774
		public static Offset<IAddOrSubAlertValue> CreateIAddOrSubAlertValue(FlatBufferBuilder builder, EValueChangeType Type = EValueChangeType.AddOrSub, float DeltaValue = 0f)
		{
			builder.StartTable(2);
			IAddOrSubAlertValue.AddDeltaValue(builder, DeltaValue);
			IAddOrSubAlertValue.AddType(builder, Type);
			return IAddOrSubAlertValue.EndIAddOrSubAlertValue(builder);
		}

		// Token: 0x0602CF71 RID: 184177 RVA: 0x00625591 File Offset: 0x00623791
		public static void StartIAddOrSubAlertValue(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602CF72 RID: 184178 RVA: 0x0062559A File Offset: 0x0062379A
		public static void AddType(FlatBufferBuilder builder, EValueChangeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CF73 RID: 184179 RVA: 0x006255A5 File Offset: 0x006237A5
		public static void AddDeltaValue(FlatBufferBuilder builder, float deltaValue)
		{
			builder.AddFloat(1, deltaValue, 0.0);
		}

		// Token: 0x0602CF74 RID: 184180 RVA: 0x006255B8 File Offset: 0x006237B8
		public static Offset<IAddOrSubAlertValue> EndIAddOrSubAlertValue(FlatBufferBuilder builder)
		{
			return new Offset<IAddOrSubAlertValue>(builder.EndTable());
		}

		// Token: 0x0602CF75 RID: 184181 RVA: 0x006255C8 File Offset: 0x006237C8
		public IAddOrSubAlertValueT UnPack()
		{
			IAddOrSubAlertValueT addOrSubAlertValueT = new IAddOrSubAlertValueT();
			this.UnPackTo(addOrSubAlertValueT);
			return addOrSubAlertValueT;
		}

		// Token: 0x0602CF76 RID: 184182 RVA: 0x006255E3 File Offset: 0x006237E3
		public void UnPackTo(IAddOrSubAlertValueT _o)
		{
			_o.Type = this.Type;
			_o.DeltaValue = this.DeltaValue;
		}

		// Token: 0x0602CF77 RID: 184183 RVA: 0x00625600 File Offset: 0x00623800
		public static Offset<IAddOrSubAlertValue> Pack(FlatBufferBuilder builder, IAddOrSubAlertValueT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAddOrSubAlertValue>);
			}
			return IAddOrSubAlertValue.CreateIAddOrSubAlertValue(builder, _o.Type, _o.DeltaValue);
		}

		// Token: 0x0401130A RID: 70410
		private Table __p;
	}
}
