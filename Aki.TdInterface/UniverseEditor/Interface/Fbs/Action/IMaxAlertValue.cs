using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A76 RID: 27254
	public struct IMaxAlertValue : IFlatbufferObject
	{
		// Token: 0x1700CA38 RID: 51768
		// (get) Token: 0x0602FBC7 RID: 195527 RVA: 0x0067EEB8 File Offset: 0x0067D0B8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FBC8 RID: 195528 RVA: 0x0067EEC5 File Offset: 0x0067D0C5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FBC9 RID: 195529 RVA: 0x0067EECC File Offset: 0x0067D0CC
		public static IMaxAlertValue GetRootAsIMaxAlertValue(ByteBuffer _bb)
		{
			return IMaxAlertValue.GetRootAsIMaxAlertValue(_bb, default(IMaxAlertValue));
		}

		// Token: 0x0602FBCA RID: 195530 RVA: 0x0067EEE8 File Offset: 0x0067D0E8
		public static IMaxAlertValue GetRootAsIMaxAlertValue(ByteBuffer _bb, IMaxAlertValue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FBCB RID: 195531 RVA: 0x0067EF05 File Offset: 0x0067D105
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FBCC RID: 195532 RVA: 0x0067EF14 File Offset: 0x0067D114
		public IMaxAlertValue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CA39 RID: 51769
		// (get) Token: 0x0602FBCD RID: 195533 RVA: 0x0067EF24 File Offset: 0x0067D124
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

		// Token: 0x0602FBCE RID: 195534 RVA: 0x0067EF60 File Offset: 0x0067D160
		public static Offset<IMaxAlertValue> CreateIMaxAlertValue(FlatBufferBuilder builder, EValueChangeType Type = EValueChangeType.AddOrSub)
		{
			builder.StartTable(1);
			IMaxAlertValue.AddType(builder, Type);
			return IMaxAlertValue.EndIMaxAlertValue(builder);
		}

		// Token: 0x0602FBCF RID: 195535 RVA: 0x0067EF76 File Offset: 0x0067D176
		public static void StartIMaxAlertValue(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602FBD0 RID: 195536 RVA: 0x0067EF7F File Offset: 0x0067D17F
		public static void AddType(FlatBufferBuilder builder, EValueChangeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FBD1 RID: 195537 RVA: 0x0067EF8A File Offset: 0x0067D18A
		public static Offset<IMaxAlertValue> EndIMaxAlertValue(FlatBufferBuilder builder)
		{
			return new Offset<IMaxAlertValue>(builder.EndTable());
		}

		// Token: 0x0602FBD2 RID: 195538 RVA: 0x0067EF98 File Offset: 0x0067D198
		public IMaxAlertValueT UnPack()
		{
			IMaxAlertValueT maxAlertValueT = new IMaxAlertValueT();
			this.UnPackTo(maxAlertValueT);
			return maxAlertValueT;
		}

		// Token: 0x0602FBD3 RID: 195539 RVA: 0x0067EFB3 File Offset: 0x0067D1B3
		public void UnPackTo(IMaxAlertValueT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602FBD4 RID: 195540 RVA: 0x0067EFC4 File Offset: 0x0067D1C4
		public static Offset<IMaxAlertValue> Pack(FlatBufferBuilder builder, IMaxAlertValueT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMaxAlertValue>);
			}
			return IMaxAlertValue.CreateIMaxAlertValue(builder, _o.Type);
		}

		// Token: 0x0401129E RID: 70302
		private Table __p;
	}
}
