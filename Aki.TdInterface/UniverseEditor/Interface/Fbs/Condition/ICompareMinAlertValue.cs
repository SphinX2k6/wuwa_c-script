using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BB6 RID: 19382
	public struct ICompareMinAlertValue : IFlatbufferObject
	{
		// Token: 0x17008CB9 RID: 36025
		// (get) Token: 0x0601E926 RID: 125222 RVA: 0x00446B31 File Offset: 0x00444D31
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E927 RID: 125223 RVA: 0x00446B3E File Offset: 0x00444D3E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E928 RID: 125224 RVA: 0x00446B48 File Offset: 0x00444D48
		public static ICompareMinAlertValue GetRootAsICompareMinAlertValue(ByteBuffer _bb)
		{
			return ICompareMinAlertValue.GetRootAsICompareMinAlertValue(_bb, default(ICompareMinAlertValue));
		}

		// Token: 0x0601E929 RID: 125225 RVA: 0x00446B64 File Offset: 0x00444D64
		public static ICompareMinAlertValue GetRootAsICompareMinAlertValue(ByteBuffer _bb, ICompareMinAlertValue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E92A RID: 125226 RVA: 0x00446B81 File Offset: 0x00444D81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E92B RID: 125227 RVA: 0x00446B90 File Offset: 0x00444D90
		public ICompareMinAlertValue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008CBA RID: 36026
		// (get) Token: 0x0601E92C RID: 125228 RVA: 0x00446BA0 File Offset: 0x00444DA0
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

		// Token: 0x0601E92D RID: 125229 RVA: 0x00446BDC File Offset: 0x00444DDC
		public static Offset<ICompareMinAlertValue> CreateICompareMinAlertValue(FlatBufferBuilder builder, EComparedAlertValueType Type = EComparedAlertValueType.Min)
		{
			builder.StartTable(1);
			ICompareMinAlertValue.AddType(builder, Type);
			return ICompareMinAlertValue.EndICompareMinAlertValue(builder);
		}

		// Token: 0x0601E92E RID: 125230 RVA: 0x00446BF2 File Offset: 0x00444DF2
		public static void StartICompareMinAlertValue(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601E92F RID: 125231 RVA: 0x00446BFB File Offset: 0x00444DFB
		public static void AddType(FlatBufferBuilder builder, EComparedAlertValueType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E930 RID: 125232 RVA: 0x00446C06 File Offset: 0x00444E06
		public static Offset<ICompareMinAlertValue> EndICompareMinAlertValue(FlatBufferBuilder builder)
		{
			return new Offset<ICompareMinAlertValue>(builder.EndTable());
		}

		// Token: 0x0601E931 RID: 125233 RVA: 0x00446C14 File Offset: 0x00444E14
		public ICompareMinAlertValueT UnPack()
		{
			ICompareMinAlertValueT compareMinAlertValueT = new ICompareMinAlertValueT();
			this.UnPackTo(compareMinAlertValueT);
			return compareMinAlertValueT;
		}

		// Token: 0x0601E932 RID: 125234 RVA: 0x00446C2F File Offset: 0x00444E2F
		public void UnPackTo(ICompareMinAlertValueT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601E933 RID: 125235 RVA: 0x00446C40 File Offset: 0x00444E40
		public static Offset<ICompareMinAlertValue> Pack(FlatBufferBuilder builder, ICompareMinAlertValueT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICompareMinAlertValue>);
			}
			return ICompareMinAlertValue.CreateICompareMinAlertValue(builder, _o.Type);
		}

		// Token: 0x0400D49B RID: 54427
		private Table __p;
	}
}
