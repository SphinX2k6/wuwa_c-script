using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041F3 RID: 16883
	public struct ITrackEffectAutoChange : IFlatbufferObject
	{
		// Token: 0x170077D4 RID: 30676
		// (get) Token: 0x06018E82 RID: 102018 RVA: 0x003958EF File Offset: 0x00393AEF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018E83 RID: 102019 RVA: 0x003958FC File Offset: 0x00393AFC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018E84 RID: 102020 RVA: 0x00395904 File Offset: 0x00393B04
		public static ITrackEffectAutoChange GetRootAsITrackEffectAutoChange(ByteBuffer _bb)
		{
			return ITrackEffectAutoChange.GetRootAsITrackEffectAutoChange(_bb, default(ITrackEffectAutoChange));
		}

		// Token: 0x06018E85 RID: 102021 RVA: 0x00395920 File Offset: 0x00393B20
		public static ITrackEffectAutoChange GetRootAsITrackEffectAutoChange(ByteBuffer _bb, ITrackEffectAutoChange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018E86 RID: 102022 RVA: 0x0039593D File Offset: 0x00393B3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018E87 RID: 102023 RVA: 0x0039594C File Offset: 0x00393B4C
		public ITrackEffectAutoChange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170077D5 RID: 30677
		// (get) Token: 0x06018E88 RID: 102024 RVA: 0x0039595C File Offset: 0x00393B5C
		public ETrackEffectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETrackEffectType.AutoChange;
				}
				return (ETrackEffectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170077D6 RID: 30678
		// (get) Token: 0x06018E89 RID: 102025 RVA: 0x00395998 File Offset: 0x00393B98
		public int EnterRange
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170077D7 RID: 30679
		// (get) Token: 0x06018E8A RID: 102026 RVA: 0x003959D4 File Offset: 0x00393BD4
		public int LeaveRange
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018E8B RID: 102027 RVA: 0x00395A10 File Offset: 0x00393C10
		public static Offset<ITrackEffectAutoChange> CreateITrackEffectAutoChange(FlatBufferBuilder builder, ETrackEffectType Type = ETrackEffectType.AutoChange, int EnterRange = 0, int LeaveRange = 0)
		{
			builder.StartTable(3);
			ITrackEffectAutoChange.AddLeaveRange(builder, LeaveRange);
			ITrackEffectAutoChange.AddEnterRange(builder, EnterRange);
			ITrackEffectAutoChange.AddType(builder, Type);
			return ITrackEffectAutoChange.EndITrackEffectAutoChange(builder);
		}

		// Token: 0x06018E8C RID: 102028 RVA: 0x00395A34 File Offset: 0x00393C34
		public static void StartITrackEffectAutoChange(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06018E8D RID: 102029 RVA: 0x00395A3D File Offset: 0x00393C3D
		public static void AddType(FlatBufferBuilder builder, ETrackEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018E8E RID: 102030 RVA: 0x00395A48 File Offset: 0x00393C48
		public static void AddEnterRange(FlatBufferBuilder builder, int enterRange)
		{
			builder.AddInt(1, enterRange, 0);
		}

		// Token: 0x06018E8F RID: 102031 RVA: 0x00395A53 File Offset: 0x00393C53
		public static void AddLeaveRange(FlatBufferBuilder builder, int leaveRange)
		{
			builder.AddInt(2, leaveRange, 0);
		}

		// Token: 0x06018E90 RID: 102032 RVA: 0x00395A5E File Offset: 0x00393C5E
		public static Offset<ITrackEffectAutoChange> EndITrackEffectAutoChange(FlatBufferBuilder builder)
		{
			return new Offset<ITrackEffectAutoChange>(builder.EndTable());
		}

		// Token: 0x06018E91 RID: 102033 RVA: 0x00395A6C File Offset: 0x00393C6C
		public ITrackEffectAutoChangeT UnPack()
		{
			ITrackEffectAutoChangeT trackEffectAutoChangeT = new ITrackEffectAutoChangeT();
			this.UnPackTo(trackEffectAutoChangeT);
			return trackEffectAutoChangeT;
		}

		// Token: 0x06018E92 RID: 102034 RVA: 0x00395A87 File Offset: 0x00393C87
		public void UnPackTo(ITrackEffectAutoChangeT _o)
		{
			_o.Type = this.Type;
			_o.EnterRange = this.EnterRange;
			_o.LeaveRange = this.LeaveRange;
		}

		// Token: 0x06018E93 RID: 102035 RVA: 0x00395AB0 File Offset: 0x00393CB0
		public static Offset<ITrackEffectAutoChange> Pack(FlatBufferBuilder builder, ITrackEffectAutoChangeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrackEffectAutoChange>);
			}
			return ITrackEffectAutoChange.CreateITrackEffectAutoChange(builder, _o.Type, _o.EnterRange, _o.LeaveRange);
		}

		// Token: 0x0400BE50 RID: 48720
		private Table __p;
	}
}
