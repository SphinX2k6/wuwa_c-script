using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050A0 RID: 20640
	public struct ICompareMinAlertValue : IFlatbufferObject
	{
		// Token: 0x170093D2 RID: 37842
		// (get) Token: 0x060204D2 RID: 132306 RVA: 0x00479695 File Offset: 0x00477895
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060204D3 RID: 132307 RVA: 0x004796A2 File Offset: 0x004778A2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060204D4 RID: 132308 RVA: 0x004796AC File Offset: 0x004778AC
		public static ICompareMinAlertValue GetRootAsICompareMinAlertValue(ByteBuffer _bb)
		{
			return ICompareMinAlertValue.GetRootAsICompareMinAlertValue(_bb, default(ICompareMinAlertValue));
		}

		// Token: 0x060204D5 RID: 132309 RVA: 0x004796C8 File Offset: 0x004778C8
		public static ICompareMinAlertValue GetRootAsICompareMinAlertValue(ByteBuffer _bb, ICompareMinAlertValue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060204D6 RID: 132310 RVA: 0x004796E5 File Offset: 0x004778E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060204D7 RID: 132311 RVA: 0x004796F4 File Offset: 0x004778F4
		public ICompareMinAlertValue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170093D3 RID: 37843
		// (get) Token: 0x060204D8 RID: 132312 RVA: 0x00479704 File Offset: 0x00477904
		public EComparedAlertValueType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EComparedAlertValueType.Min;
				}
				return (EComparedAlertValueType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060204D9 RID: 132313 RVA: 0x00479740 File Offset: 0x00477940
		public static Offset<ICompareMinAlertValue> CreateICompareMinAlertValue(FlatBufferBuilder builder, EComparedAlertValueType Type = EComparedAlertValueType.Min)
		{
			builder.StartTable(1);
			ICompareMinAlertValue.AddType(builder, Type);
			return ICompareMinAlertValue.EndICompareMinAlertValue(builder);
		}

		// Token: 0x060204DA RID: 132314 RVA: 0x00479756 File Offset: 0x00477956
		public static void StartICompareMinAlertValue(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060204DB RID: 132315 RVA: 0x0047975F File Offset: 0x0047795F
		public static void AddType(FlatBufferBuilder builder, EComparedAlertValueType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060204DC RID: 132316 RVA: 0x0047976A File Offset: 0x0047796A
		public static Offset<ICompareMinAlertValue> EndICompareMinAlertValue(FlatBufferBuilder builder)
		{
			return new Offset<ICompareMinAlertValue>(builder.EndTable());
		}

		// Token: 0x060204DD RID: 132317 RVA: 0x00479778 File Offset: 0x00477978
		public ICompareMinAlertValueT UnPack()
		{
			ICompareMinAlertValueT compareMinAlertValueT = new ICompareMinAlertValueT();
			this.UnPackTo(compareMinAlertValueT);
			return compareMinAlertValueT;
		}

		// Token: 0x060204DE RID: 132318 RVA: 0x00479793 File Offset: 0x00477993
		public void UnPackTo(ICompareMinAlertValueT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060204DF RID: 132319 RVA: 0x004797A4 File Offset: 0x004779A4
		public static Offset<ICompareMinAlertValue> Pack(FlatBufferBuilder builder, ICompareMinAlertValueT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICompareMinAlertValue>);
			}
			return ICompareMinAlertValue.CreateICompareMinAlertValue(builder, _o.Type);
		}

		// Token: 0x0400DFA0 RID: 57248
		private Table __p;
	}
}
