using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200503C RID: 20540
	public struct ICountDownTextTip : IFlatbufferObject
	{
		// Token: 0x1700950C RID: 38156
		// (get) Token: 0x06020E8B RID: 134795 RVA: 0x0049364F File Offset: 0x0049184F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020E8C RID: 134796 RVA: 0x0049365C File Offset: 0x0049185C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020E8D RID: 134797 RVA: 0x00493664 File Offset: 0x00491864
		public static ICountDownTextTip GetRootAsICountDownTextTip(ByteBuffer _bb)
		{
			return ICountDownTextTip.GetRootAsICountDownTextTip(_bb, default(ICountDownTextTip));
		}

		// Token: 0x06020E8E RID: 134798 RVA: 0x00493680 File Offset: 0x00491880
		public static ICountDownTextTip GetRootAsICountDownTextTip(ByteBuffer _bb, ICountDownTextTip obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020E8F RID: 134799 RVA: 0x0049369D File Offset: 0x0049189D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020E90 RID: 134800 RVA: 0x004936AC File Offset: 0x004918AC
		public ICountDownTextTip __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700950D RID: 38157
		// (get) Token: 0x06020E91 RID: 134801 RVA: 0x004936BC File Offset: 0x004918BC
		public ETrampleTipType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETrampleTipType.CountDownTextTip;
				}
				return (ETrampleTipType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700950E RID: 38158
		// (get) Token: 0x06020E92 RID: 134802 RVA: 0x004936F8 File Offset: 0x004918F8
		public string TidCountDownTip
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020E93 RID: 134803 RVA: 0x0049372F File Offset: 0x0049192F
		public Span<byte> GetTidCountDownTipBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06020E94 RID: 134804 RVA: 0x0049373E File Offset: 0x0049193E
		public byte[] GetTidCountDownTipArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06020E95 RID: 134805 RVA: 0x0049374C File Offset: 0x0049194C
		public static Offset<ICountDownTextTip> CreateICountDownTextTip(FlatBufferBuilder builder, ETrampleTipType Type = ETrampleTipType.CountDownTextTip, StringOffset TidCountDownTipOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ICountDownTextTip.AddTidCountDownTip(builder, TidCountDownTipOffset);
			ICountDownTextTip.AddType(builder, Type);
			return ICountDownTextTip.EndICountDownTextTip(builder);
		}

		// Token: 0x06020E96 RID: 134806 RVA: 0x00493769 File Offset: 0x00491969
		public static void StartICountDownTextTip(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06020E97 RID: 134807 RVA: 0x00493772 File Offset: 0x00491972
		public static void AddType(FlatBufferBuilder builder, ETrampleTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020E98 RID: 134808 RVA: 0x0049377D File Offset: 0x0049197D
		public static void AddTidCountDownTip(FlatBufferBuilder builder, StringOffset tidCountDownTipOffset)
		{
			builder.AddOffset(1, tidCountDownTipOffset.Value, 0);
		}

		// Token: 0x06020E99 RID: 134809 RVA: 0x0049378D File Offset: 0x0049198D
		public static Offset<ICountDownTextTip> EndICountDownTextTip(FlatBufferBuilder builder)
		{
			return new Offset<ICountDownTextTip>(builder.EndTable());
		}

		// Token: 0x06020E9A RID: 134810 RVA: 0x0049379C File Offset: 0x0049199C
		public ICountDownTextTipT UnPack()
		{
			ICountDownTextTipT countDownTextTipT = new ICountDownTextTipT();
			this.UnPackTo(countDownTextTipT);
			return countDownTextTipT;
		}

		// Token: 0x06020E9B RID: 134811 RVA: 0x004937B7 File Offset: 0x004919B7
		public void UnPackTo(ICountDownTextTipT _o)
		{
			_o.Type = this.Type;
			_o.TidCountDownTip = this.TidCountDownTip;
		}

		// Token: 0x06020E9C RID: 134812 RVA: 0x004937D4 File Offset: 0x004919D4
		public static Offset<ICountDownTextTip> Pack(FlatBufferBuilder builder, ICountDownTextTipT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICountDownTextTip>);
			}
			StringOffset tidCountDownTipOffset = (_o.TidCountDownTip == null) ? default(StringOffset) : builder.CreateString(_o.TidCountDownTip);
			return ICountDownTextTip.CreateICountDownTextTip(builder, _o.Type, tidCountDownTipOffset);
		}

		// Token: 0x0400E02F RID: 57391
		private Table __p;
	}
}
