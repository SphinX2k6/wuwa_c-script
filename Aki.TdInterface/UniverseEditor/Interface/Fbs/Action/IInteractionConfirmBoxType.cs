using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200703D RID: 28733
	public struct IInteractionConfirmBoxType : IFlatbufferObject
	{
		// Token: 0x1700D260 RID: 53856
		// (get) Token: 0x06031CC6 RID: 203974 RVA: 0x006BDB00 File Offset: 0x006BBD00
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031CC7 RID: 203975 RVA: 0x006BDB0D File Offset: 0x006BBD0D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031CC8 RID: 203976 RVA: 0x006BDB14 File Offset: 0x006BBD14
		public static IInteractionConfirmBoxType GetRootAsIInteractionConfirmBoxType(ByteBuffer _bb)
		{
			return IInteractionConfirmBoxType.GetRootAsIInteractionConfirmBoxType(_bb, default(IInteractionConfirmBoxType));
		}

		// Token: 0x06031CC9 RID: 203977 RVA: 0x006BDB30 File Offset: 0x006BBD30
		public static IInteractionConfirmBoxType GetRootAsIInteractionConfirmBoxType(ByteBuffer _bb, IInteractionConfirmBoxType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031CCA RID: 203978 RVA: 0x006BDB4D File Offset: 0x006BBD4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031CCB RID: 203979 RVA: 0x006BDB5C File Offset: 0x006BBD5C
		public IInteractionConfirmBoxType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D261 RID: 53857
		// (get) Token: 0x06031CCC RID: 203980 RVA: 0x006BDB6C File Offset: 0x006BBD6C
		public EInteractionConfirmBoxType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInteractionConfirmBoxType.Common;
				}
				return (EInteractionConfirmBoxType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031CCD RID: 203981 RVA: 0x006BDBA8 File Offset: 0x006BBDA8
		public static Offset<IInteractionConfirmBoxType> CreateIInteractionConfirmBoxType(FlatBufferBuilder builder, EInteractionConfirmBoxType Type = EInteractionConfirmBoxType.Common)
		{
			builder.StartTable(1);
			IInteractionConfirmBoxType.AddType(builder, Type);
			return IInteractionConfirmBoxType.EndIInteractionConfirmBoxType(builder);
		}

		// Token: 0x06031CCE RID: 203982 RVA: 0x006BDBBE File Offset: 0x006BBDBE
		public static void StartIInteractionConfirmBoxType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031CCF RID: 203983 RVA: 0x006BDBC7 File Offset: 0x006BBDC7
		public static void AddType(FlatBufferBuilder builder, EInteractionConfirmBoxType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031CD0 RID: 203984 RVA: 0x006BDBD2 File Offset: 0x006BBDD2
		public static Offset<IInteractionConfirmBoxType> EndIInteractionConfirmBoxType(FlatBufferBuilder builder)
		{
			return new Offset<IInteractionConfirmBoxType>(builder.EndTable());
		}

		// Token: 0x06031CD1 RID: 203985 RVA: 0x006BDBE0 File Offset: 0x006BBDE0
		public IInteractionConfirmBoxTypeT UnPack()
		{
			IInteractionConfirmBoxTypeT interactionConfirmBoxTypeT = new IInteractionConfirmBoxTypeT();
			this.UnPackTo(interactionConfirmBoxTypeT);
			return interactionConfirmBoxTypeT;
		}

		// Token: 0x06031CD2 RID: 203986 RVA: 0x006BDBFB File Offset: 0x006BBDFB
		public void UnPackTo(IInteractionConfirmBoxTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06031CD3 RID: 203987 RVA: 0x006BDC0C File Offset: 0x006BBE0C
		public static Offset<IInteractionConfirmBoxType> Pack(FlatBufferBuilder builder, IInteractionConfirmBoxTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInteractionConfirmBoxType>);
			}
			return IInteractionConfirmBoxType.CreateIInteractionConfirmBoxType(builder, _o.Type);
		}

		// Token: 0x04011F84 RID: 73604
		private Table __p;
	}
}
