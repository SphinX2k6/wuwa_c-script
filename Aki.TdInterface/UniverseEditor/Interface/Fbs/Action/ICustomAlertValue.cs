using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B60 RID: 27488
	public struct ICustomAlertValue : IFlatbufferObject
	{
		// Token: 0x1700C9C6 RID: 51654
		// (get) Token: 0x0602F4D3 RID: 193747 RVA: 0x00674EE9 File Offset: 0x006730E9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F4D4 RID: 193748 RVA: 0x00674EF6 File Offset: 0x006730F6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F4D5 RID: 193749 RVA: 0x00674F00 File Offset: 0x00673100
		public static ICustomAlertValue GetRootAsICustomAlertValue(ByteBuffer _bb)
		{
			return ICustomAlertValue.GetRootAsICustomAlertValue(_bb, default(ICustomAlertValue));
		}

		// Token: 0x0602F4D6 RID: 193750 RVA: 0x00674F1C File Offset: 0x0067311C
		public static ICustomAlertValue GetRootAsICustomAlertValue(ByteBuffer _bb, ICustomAlertValue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F4D7 RID: 193751 RVA: 0x00674F39 File Offset: 0x00673139
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F4D8 RID: 193752 RVA: 0x00674F48 File Offset: 0x00673148
		public ICustomAlertValue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C9C7 RID: 51655
		// (get) Token: 0x0602F4D9 RID: 193753 RVA: 0x00674F58 File Offset: 0x00673158
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

		// Token: 0x1700C9C8 RID: 51656
		// (get) Token: 0x0602F4DA RID: 193754 RVA: 0x00674F94 File Offset: 0x00673194
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

		// Token: 0x0602F4DB RID: 193755 RVA: 0x00674FD4 File Offset: 0x006731D4
		public static Offset<ICustomAlertValue> CreateICustomAlertValue(FlatBufferBuilder builder, EValueChangeType Type = EValueChangeType.AddOrSub, float CustomValue = 0f)
		{
			builder.StartTable(2);
			ICustomAlertValue.AddCustomValue(builder, CustomValue);
			ICustomAlertValue.AddType(builder, Type);
			return ICustomAlertValue.EndICustomAlertValue(builder);
		}

		// Token: 0x0602F4DC RID: 193756 RVA: 0x00674FF1 File Offset: 0x006731F1
		public static void StartICustomAlertValue(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602F4DD RID: 193757 RVA: 0x00674FFA File Offset: 0x006731FA
		public static void AddType(FlatBufferBuilder builder, EValueChangeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F4DE RID: 193758 RVA: 0x00675005 File Offset: 0x00673205
		public static void AddCustomValue(FlatBufferBuilder builder, float customValue)
		{
			builder.AddFloat(1, customValue, 0.0);
		}

		// Token: 0x0602F4DF RID: 193759 RVA: 0x00675018 File Offset: 0x00673218
		public static Offset<ICustomAlertValue> EndICustomAlertValue(FlatBufferBuilder builder)
		{
			return new Offset<ICustomAlertValue>(builder.EndTable());
		}

		// Token: 0x0602F4E0 RID: 193760 RVA: 0x00675028 File Offset: 0x00673228
		public ICustomAlertValueT UnPack()
		{
			ICustomAlertValueT customAlertValueT = new ICustomAlertValueT();
			this.UnPackTo(customAlertValueT);
			return customAlertValueT;
		}

		// Token: 0x0602F4E1 RID: 193761 RVA: 0x00675043 File Offset: 0x00673243
		public void UnPackTo(ICustomAlertValueT _o)
		{
			_o.Type = this.Type;
			_o.CustomValue = this.CustomValue;
		}

		// Token: 0x0602F4E2 RID: 193762 RVA: 0x00675060 File Offset: 0x00673260
		public static Offset<ICustomAlertValue> Pack(FlatBufferBuilder builder, ICustomAlertValueT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICustomAlertValue>);
			}
			return ICustomAlertValue.CreateICustomAlertValue(builder, _o.Type, _o.CustomValue);
		}

		// Token: 0x0401194D RID: 72013
		private Table __p;
	}
}
