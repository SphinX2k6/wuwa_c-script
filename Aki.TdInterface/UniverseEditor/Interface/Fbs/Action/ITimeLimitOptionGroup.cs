using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BC3 RID: 31683
	public struct ITimeLimitOptionGroup : IFlatbufferObject
	{
		// Token: 0x1700ED64 RID: 60772
		// (get) Token: 0x060391C0 RID: 233920 RVA: 0x007B7D89 File Offset: 0x007B5F89
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060391C1 RID: 233921 RVA: 0x007B7D96 File Offset: 0x007B5F96
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060391C2 RID: 233922 RVA: 0x007B7DA0 File Offset: 0x007B5FA0
		public static ITimeLimitOptionGroup GetRootAsITimeLimitOptionGroup(ByteBuffer _bb)
		{
			return ITimeLimitOptionGroup.GetRootAsITimeLimitOptionGroup(_bb, default(ITimeLimitOptionGroup));
		}

		// Token: 0x060391C3 RID: 233923 RVA: 0x007B7DBC File Offset: 0x007B5FBC
		public static ITimeLimitOptionGroup GetRootAsITimeLimitOptionGroup(ByteBuffer _bb, ITimeLimitOptionGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060391C4 RID: 233924 RVA: 0x007B7DD9 File Offset: 0x007B5FD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060391C5 RID: 233925 RVA: 0x007B7DE8 File Offset: 0x007B5FE8
		public ITimeLimitOptionGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ED65 RID: 60773
		// (get) Token: 0x060391C6 RID: 233926 RVA: 0x007B7DF8 File Offset: 0x007B5FF8
		public ITimeLimitOptionGroupDefault? Style
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new ITimeLimitOptionGroupDefault?(default(ITimeLimitOptionGroupDefault).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060391C7 RID: 233927 RVA: 0x007B7E55 File Offset: 0x007B6055
		public static Offset<ITimeLimitOptionGroup> CreateITimeLimitOptionGroup(FlatBufferBuilder builder, Offset<ITimeLimitOptionGroupDefault> StyleOffset = default(Offset<ITimeLimitOptionGroupDefault>))
		{
			builder.StartTable(1);
			ITimeLimitOptionGroup.AddStyle(builder, StyleOffset);
			return ITimeLimitOptionGroup.EndITimeLimitOptionGroup(builder);
		}

		// Token: 0x060391C8 RID: 233928 RVA: 0x007B7E6B File Offset: 0x007B606B
		public static void StartITimeLimitOptionGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060391C9 RID: 233929 RVA: 0x007B7E74 File Offset: 0x007B6074
		public static void AddStyle(FlatBufferBuilder builder, Offset<ITimeLimitOptionGroupDefault> styleOffset)
		{
			builder.AddOffset(0, styleOffset.Value, 0);
		}

		// Token: 0x060391CA RID: 233930 RVA: 0x007B7E84 File Offset: 0x007B6084
		public static Offset<ITimeLimitOptionGroup> EndITimeLimitOptionGroup(FlatBufferBuilder builder)
		{
			return new Offset<ITimeLimitOptionGroup>(builder.EndTable());
		}

		// Token: 0x060391CB RID: 233931 RVA: 0x007B7E94 File Offset: 0x007B6094
		public ITimeLimitOptionGroupT UnPack()
		{
			ITimeLimitOptionGroupT timeLimitOptionGroupT = new ITimeLimitOptionGroupT();
			this.UnPackTo(timeLimitOptionGroupT);
			return timeLimitOptionGroupT;
		}

		// Token: 0x060391CC RID: 233932 RVA: 0x007B7EB0 File Offset: 0x007B60B0
		public void UnPackTo(ITimeLimitOptionGroupT _o)
		{
			_o.Style = ((this.Style != null) ? this.Style.Value.UnPack() : null);
		}

		// Token: 0x060391CD RID: 233933 RVA: 0x007B7EEC File Offset: 0x007B60EC
		public static Offset<ITimeLimitOptionGroup> Pack(FlatBufferBuilder builder, ITimeLimitOptionGroupT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITimeLimitOptionGroup>);
			}
			Offset<ITimeLimitOptionGroupDefault> styleOffset = (_o.Style == null) ? default(Offset<ITimeLimitOptionGroupDefault>) : ITimeLimitOptionGroupDefault.Pack(builder, _o.Style);
			return ITimeLimitOptionGroup.CreateITimeLimitOptionGroup(builder, styleOffset);
		}

		// Token: 0x0401324B RID: 78411
		private Table __p;
	}
}
