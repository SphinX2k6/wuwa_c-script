using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006486 RID: 25734
	public struct ICommonTip2Type : IFlatbufferObject
	{
		// Token: 0x1700BF88 RID: 49032
		// (get) Token: 0x0602C992 RID: 182674 RVA: 0x00620020 File Offset: 0x0061E220
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C993 RID: 182675 RVA: 0x0062002D File Offset: 0x0061E22D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C994 RID: 182676 RVA: 0x00620034 File Offset: 0x0061E234
		public static ICommonTip2Type GetRootAsICommonTip2Type(ByteBuffer _bb)
		{
			return ICommonTip2Type.GetRootAsICommonTip2Type(_bb, default(ICommonTip2Type));
		}

		// Token: 0x0602C995 RID: 182677 RVA: 0x00620050 File Offset: 0x0061E250
		public static ICommonTip2Type GetRootAsICommonTip2Type(ByteBuffer _bb, ICommonTip2Type obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C996 RID: 182678 RVA: 0x0062006D File Offset: 0x0061E26D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C997 RID: 182679 RVA: 0x0062007C File Offset: 0x0061E27C
		public ICommonTip2Type __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BF89 RID: 49033
		// (get) Token: 0x0602C998 RID: 182680 RVA: 0x0062008C File Offset: 0x0061E28C
		public ECommonTip2Type Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECommonTip2Type.PrepareCountdown;
				}
				return (ECommonTip2Type)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602C999 RID: 182681 RVA: 0x006200C8 File Offset: 0x0061E2C8
		public static Offset<ICommonTip2Type> CreateICommonTip2Type(FlatBufferBuilder builder, ECommonTip2Type Type = ECommonTip2Type.PrepareCountdown)
		{
			builder.StartTable(1);
			ICommonTip2Type.AddType(builder, Type);
			return ICommonTip2Type.EndICommonTip2Type(builder);
		}

		// Token: 0x0602C99A RID: 182682 RVA: 0x006200DE File Offset: 0x0061E2DE
		public static void StartICommonTip2Type(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602C99B RID: 182683 RVA: 0x006200E7 File Offset: 0x0061E2E7
		public static void AddType(FlatBufferBuilder builder, ECommonTip2Type type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C99C RID: 182684 RVA: 0x006200F2 File Offset: 0x0061E2F2
		public static Offset<ICommonTip2Type> EndICommonTip2Type(FlatBufferBuilder builder)
		{
			return new Offset<ICommonTip2Type>(builder.EndTable());
		}

		// Token: 0x0602C99D RID: 182685 RVA: 0x00620100 File Offset: 0x0061E300
		public ICommonTip2TypeT UnPack()
		{
			ICommonTip2TypeT commonTip2TypeT = new ICommonTip2TypeT();
			this.UnPackTo(commonTip2TypeT);
			return commonTip2TypeT;
		}

		// Token: 0x0602C99E RID: 182686 RVA: 0x0062011B File Offset: 0x0061E31B
		public void UnPackTo(ICommonTip2TypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602C99F RID: 182687 RVA: 0x0062012C File Offset: 0x0061E32C
		public static Offset<ICommonTip2Type> Pack(FlatBufferBuilder builder, ICommonTip2TypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonTip2Type>);
			}
			return ICommonTip2Type.CreateICommonTip2Type(builder, _o.Type);
		}

		// Token: 0x04010A90 RID: 68240
		private Table __p;
	}
}
