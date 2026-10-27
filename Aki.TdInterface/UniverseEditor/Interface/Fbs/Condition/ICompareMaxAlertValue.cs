using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BB3 RID: 19379
	public struct ICompareMaxAlertValue : IFlatbufferObject
	{
		// Token: 0x17008CB6 RID: 36022
		// (get) Token: 0x0601E914 RID: 125204 RVA: 0x004469BC File Offset: 0x00444BBC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E915 RID: 125205 RVA: 0x004469C9 File Offset: 0x00444BC9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E916 RID: 125206 RVA: 0x004469D0 File Offset: 0x00444BD0
		public static ICompareMaxAlertValue GetRootAsICompareMaxAlertValue(ByteBuffer _bb)
		{
			return ICompareMaxAlertValue.GetRootAsICompareMaxAlertValue(_bb, default(ICompareMaxAlertValue));
		}

		// Token: 0x0601E917 RID: 125207 RVA: 0x004469EC File Offset: 0x00444BEC
		public static ICompareMaxAlertValue GetRootAsICompareMaxAlertValue(ByteBuffer _bb, ICompareMaxAlertValue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E918 RID: 125208 RVA: 0x00446A09 File Offset: 0x00444C09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E919 RID: 125209 RVA: 0x00446A18 File Offset: 0x00444C18
		public ICompareMaxAlertValue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008CB7 RID: 36023
		// (get) Token: 0x0601E91A RID: 125210 RVA: 0x00446A28 File Offset: 0x00444C28
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

		// Token: 0x0601E91B RID: 125211 RVA: 0x00446A64 File Offset: 0x00444C64
		public static Offset<ICompareMaxAlertValue> CreateICompareMaxAlertValue(FlatBufferBuilder builder, EComparedAlertValueType Type = EComparedAlertValueType.Min)
		{
			builder.StartTable(1);
			ICompareMaxAlertValue.AddType(builder, Type);
			return ICompareMaxAlertValue.EndICompareMaxAlertValue(builder);
		}

		// Token: 0x0601E91C RID: 125212 RVA: 0x00446A7A File Offset: 0x00444C7A
		public static void StartICompareMaxAlertValue(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601E91D RID: 125213 RVA: 0x00446A83 File Offset: 0x00444C83
		public static void AddType(FlatBufferBuilder builder, EComparedAlertValueType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E91E RID: 125214 RVA: 0x00446A8E File Offset: 0x00444C8E
		public static Offset<ICompareMaxAlertValue> EndICompareMaxAlertValue(FlatBufferBuilder builder)
		{
			return new Offset<ICompareMaxAlertValue>(builder.EndTable());
		}

		// Token: 0x0601E91F RID: 125215 RVA: 0x00446A9C File Offset: 0x00444C9C
		public ICompareMaxAlertValueT UnPack()
		{
			ICompareMaxAlertValueT compareMaxAlertValueT = new ICompareMaxAlertValueT();
			this.UnPackTo(compareMaxAlertValueT);
			return compareMaxAlertValueT;
		}

		// Token: 0x0601E920 RID: 125216 RVA: 0x00446AB7 File Offset: 0x00444CB7
		public void UnPackTo(ICompareMaxAlertValueT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601E921 RID: 125217 RVA: 0x00446AC8 File Offset: 0x00444CC8
		public static Offset<ICompareMaxAlertValue> Pack(FlatBufferBuilder builder, ICompareMaxAlertValueT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICompareMaxAlertValue>);
			}
			return ICompareMaxAlertValue.CreateICompareMaxAlertValue(builder, _o.Type);
		}

		// Token: 0x0400D499 RID: 54425
		private Table __p;
	}
}
