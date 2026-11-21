using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F83 RID: 28547
	public struct IHeadStyleVoiceOnly : IFlatbufferObject
	{
		// Token: 0x1700D116 RID: 53526
		// (get) Token: 0x0603168E RID: 202382 RVA: 0x006B3172 File Offset: 0x006B1372
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603168F RID: 202383 RVA: 0x006B317F File Offset: 0x006B137F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031690 RID: 202384 RVA: 0x006B3188 File Offset: 0x006B1388
		public static IHeadStyleVoiceOnly GetRootAsIHeadStyleVoiceOnly(ByteBuffer _bb)
		{
			return IHeadStyleVoiceOnly.GetRootAsIHeadStyleVoiceOnly(_bb, default(IHeadStyleVoiceOnly));
		}

		// Token: 0x06031691 RID: 202385 RVA: 0x006B31A4 File Offset: 0x006B13A4
		public static IHeadStyleVoiceOnly GetRootAsIHeadStyleVoiceOnly(ByteBuffer _bb, IHeadStyleVoiceOnly obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031692 RID: 202386 RVA: 0x006B31C1 File Offset: 0x006B13C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031693 RID: 202387 RVA: 0x006B31D0 File Offset: 0x006B13D0
		public IHeadStyleVoiceOnly __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D117 RID: 53527
		// (get) Token: 0x06031694 RID: 202388 RVA: 0x006B31E0 File Offset: 0x006B13E0
		public EHeadStyle Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EHeadStyle.Normal;
				}
				return (EHeadStyle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D118 RID: 53528
		// (get) Token: 0x06031695 RID: 202389 RVA: 0x006B321C File Offset: 0x006B141C
		public int WhoId
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

		// Token: 0x06031696 RID: 202390 RVA: 0x006B3258 File Offset: 0x006B1458
		public static Offset<IHeadStyleVoiceOnly> CreateIHeadStyleVoiceOnly(FlatBufferBuilder builder, EHeadStyle Type = EHeadStyle.Normal, int WhoId = 0)
		{
			builder.StartTable(2);
			IHeadStyleVoiceOnly.AddWhoId(builder, WhoId);
			IHeadStyleVoiceOnly.AddType(builder, Type);
			return IHeadStyleVoiceOnly.EndIHeadStyleVoiceOnly(builder);
		}

		// Token: 0x06031697 RID: 202391 RVA: 0x006B3275 File Offset: 0x006B1475
		public static void StartIHeadStyleVoiceOnly(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031698 RID: 202392 RVA: 0x006B327E File Offset: 0x006B147E
		public static void AddType(FlatBufferBuilder builder, EHeadStyle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031699 RID: 202393 RVA: 0x006B3289 File Offset: 0x006B1489
		public static void AddWhoId(FlatBufferBuilder builder, int whoId)
		{
			builder.AddInt(1, whoId, 0);
		}

		// Token: 0x0603169A RID: 202394 RVA: 0x006B3294 File Offset: 0x006B1494
		public static Offset<IHeadStyleVoiceOnly> EndIHeadStyleVoiceOnly(FlatBufferBuilder builder)
		{
			return new Offset<IHeadStyleVoiceOnly>(builder.EndTable());
		}

		// Token: 0x0603169B RID: 202395 RVA: 0x006B32A4 File Offset: 0x006B14A4
		public IHeadStyleVoiceOnlyT UnPack()
		{
			IHeadStyleVoiceOnlyT headStyleVoiceOnlyT = new IHeadStyleVoiceOnlyT();
			this.UnPackTo(headStyleVoiceOnlyT);
			return headStyleVoiceOnlyT;
		}

		// Token: 0x0603169C RID: 202396 RVA: 0x006B32BF File Offset: 0x006B14BF
		public void UnPackTo(IHeadStyleVoiceOnlyT _o)
		{
			_o.Type = this.Type;
			_o.WhoId = this.WhoId;
		}

		// Token: 0x0603169D RID: 202397 RVA: 0x006B32DC File Offset: 0x006B14DC
		public static Offset<IHeadStyleVoiceOnly> Pack(FlatBufferBuilder builder, IHeadStyleVoiceOnlyT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHeadStyleVoiceOnly>);
			}
			return IHeadStyleVoiceOnly.CreateIHeadStyleVoiceOnly(builder, _o.Type, _o.WhoId);
		}

		// Token: 0x04011E96 RID: 73366
		private Table __p;
	}
}
