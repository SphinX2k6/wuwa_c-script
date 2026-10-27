using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064F2 RID: 25842
	public struct ICustomAlertValue : IFlatbufferObject
	{
		// Token: 0x1700C036 RID: 49206
		// (get) Token: 0x0602CD3D RID: 183613 RVA: 0x00628C49 File Offset: 0x00626E49
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CD3E RID: 183614 RVA: 0x00628C56 File Offset: 0x00626E56
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CD3F RID: 183615 RVA: 0x00628C60 File Offset: 0x00626E60
		public static ICustomAlertValue GetRootAsICustomAlertValue(ByteBuffer _bb)
		{
			return ICustomAlertValue.GetRootAsICustomAlertValue(_bb, default(ICustomAlertValue));
		}

		// Token: 0x0602CD40 RID: 183616 RVA: 0x00628C7C File Offset: 0x00626E7C
		public static ICustomAlertValue GetRootAsICustomAlertValue(ByteBuffer _bb, ICustomAlertValue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CD41 RID: 183617 RVA: 0x00628C99 File Offset: 0x00626E99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CD42 RID: 183618 RVA: 0x00628CA8 File Offset: 0x00626EA8
		public ICustomAlertValue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C037 RID: 49207
		// (get) Token: 0x0602CD43 RID: 183619 RVA: 0x00628CB8 File Offset: 0x00626EB8
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

		// Token: 0x1700C038 RID: 49208
		// (get) Token: 0x0602CD44 RID: 183620 RVA: 0x00628CF4 File Offset: 0x00626EF4
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

		// Token: 0x0602CD45 RID: 183621 RVA: 0x00628D34 File Offset: 0x00626F34
		public static Offset<ICustomAlertValue> CreateICustomAlertValue(FlatBufferBuilder builder, EValueChangeType Type = EValueChangeType.AddOrSub, float CustomValue = 0f)
		{
			builder.StartTable(2);
			ICustomAlertValue.AddCustomValue(builder, CustomValue);
			ICustomAlertValue.AddType(builder, Type);
			return ICustomAlertValue.EndICustomAlertValue(builder);
		}

		// Token: 0x0602CD46 RID: 183622 RVA: 0x00628D51 File Offset: 0x00626F51
		public static void StartICustomAlertValue(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602CD47 RID: 183623 RVA: 0x00628D5A File Offset: 0x00626F5A
		public static void AddType(FlatBufferBuilder builder, EValueChangeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CD48 RID: 183624 RVA: 0x00628D65 File Offset: 0x00626F65
		public static void AddCustomValue(FlatBufferBuilder builder, float customValue)
		{
			builder.AddFloat(1, customValue, 0.0);
		}

		// Token: 0x0602CD49 RID: 183625 RVA: 0x00628D78 File Offset: 0x00626F78
		public static Offset<ICustomAlertValue> EndICustomAlertValue(FlatBufferBuilder builder)
		{
			return new Offset<ICustomAlertValue>(builder.EndTable());
		}

		// Token: 0x0602CD4A RID: 183626 RVA: 0x00628D88 File Offset: 0x00626F88
		public ICustomAlertValueT UnPack()
		{
			ICustomAlertValueT customAlertValueT = new ICustomAlertValueT();
			this.UnPackTo(customAlertValueT);
			return customAlertValueT;
		}

		// Token: 0x0602CD4B RID: 183627 RVA: 0x00628DA3 File Offset: 0x00626FA3
		public void UnPackTo(ICustomAlertValueT _o)
		{
			_o.Type = this.Type;
			_o.CustomValue = this.CustomValue;
		}

		// Token: 0x0602CD4C RID: 183628 RVA: 0x00628DC0 File Offset: 0x00626FC0
		public static Offset<ICustomAlertValue> Pack(FlatBufferBuilder builder, ICustomAlertValueT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICustomAlertValue>);
			}
			return ICustomAlertValue.CreateICustomAlertValue(builder, _o.Type, _o.CustomValue);
		}

		// Token: 0x04010B35 RID: 68405
		private Table __p;
	}
}
