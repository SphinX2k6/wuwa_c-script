using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D55 RID: 23893
	public struct IBvbPlayerTurnEndData : IFlatbufferObject
	{
		// Token: 0x1700B30B RID: 45835
		// (get) Token: 0x06028E0E RID: 167438 RVA: 0x0059E05D File Offset: 0x0059C25D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028E0F RID: 167439 RVA: 0x0059E06A File Offset: 0x0059C26A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028E10 RID: 167440 RVA: 0x0059E074 File Offset: 0x0059C274
		public static IBvbPlayerTurnEndData GetRootAsIBvbPlayerTurnEndData(ByteBuffer _bb)
		{
			return IBvbPlayerTurnEndData.GetRootAsIBvbPlayerTurnEndData(_bb, default(IBvbPlayerTurnEndData));
		}

		// Token: 0x06028E11 RID: 167441 RVA: 0x0059E090 File Offset: 0x0059C290
		public static IBvbPlayerTurnEndData GetRootAsIBvbPlayerTurnEndData(ByteBuffer _bb, IBvbPlayerTurnEndData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028E12 RID: 167442 RVA: 0x0059E0AD File Offset: 0x0059C2AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028E13 RID: 167443 RVA: 0x0059E0BC File Offset: 0x0059C2BC
		public IBvbPlayerTurnEndData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B30C RID: 45836
		// (get) Token: 0x06028E14 RID: 167444 RVA: 0x0059E0CC File Offset: 0x0059C2CC
		public EBvbEventName Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBvbEventName.AIEvolution;
				}
				return (EBvbEventName)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028E15 RID: 167445 RVA: 0x0059E108 File Offset: 0x0059C308
		public static Offset<IBvbPlayerTurnEndData> CreateIBvbPlayerTurnEndData(FlatBufferBuilder builder, EBvbEventName Type = EBvbEventName.AIEvolution)
		{
			builder.StartTable(1);
			IBvbPlayerTurnEndData.AddType(builder, Type);
			return IBvbPlayerTurnEndData.EndIBvbPlayerTurnEndData(builder);
		}

		// Token: 0x06028E16 RID: 167446 RVA: 0x0059E11E File Offset: 0x0059C31E
		public static void StartIBvbPlayerTurnEndData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06028E17 RID: 167447 RVA: 0x0059E127 File Offset: 0x0059C327
		public static void AddType(FlatBufferBuilder builder, EBvbEventName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028E18 RID: 167448 RVA: 0x0059E132 File Offset: 0x0059C332
		public static Offset<IBvbPlayerTurnEndData> EndIBvbPlayerTurnEndData(FlatBufferBuilder builder)
		{
			return new Offset<IBvbPlayerTurnEndData>(builder.EndTable());
		}

		// Token: 0x06028E19 RID: 167449 RVA: 0x0059E140 File Offset: 0x0059C340
		public IBvbPlayerTurnEndDataT UnPack()
		{
			IBvbPlayerTurnEndDataT bvbPlayerTurnEndDataT = new IBvbPlayerTurnEndDataT();
			this.UnPackTo(bvbPlayerTurnEndDataT);
			return bvbPlayerTurnEndDataT;
		}

		// Token: 0x06028E1A RID: 167450 RVA: 0x0059E15B File Offset: 0x0059C35B
		public void UnPackTo(IBvbPlayerTurnEndDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06028E1B RID: 167451 RVA: 0x0059E16C File Offset: 0x0059C36C
		public static Offset<IBvbPlayerTurnEndData> Pack(FlatBufferBuilder builder, IBvbPlayerTurnEndDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbPlayerTurnEndData>);
			}
			return IBvbPlayerTurnEndData.CreateIBvbPlayerTurnEndData(builder, _o.Type);
		}

		// Token: 0x0400F721 RID: 63265
		private Table __p;
	}
}
