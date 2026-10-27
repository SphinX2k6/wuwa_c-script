using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007295 RID: 29333
	public struct ITalkBackgroundClean : IFlatbufferObject
	{
		// Token: 0x1700D990 RID: 55696
		// (get) Token: 0x060340A5 RID: 213157 RVA: 0x006FF221 File Offset: 0x006FD421
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060340A6 RID: 213158 RVA: 0x006FF22E File Offset: 0x006FD42E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060340A7 RID: 213159 RVA: 0x006FF238 File Offset: 0x006FD438
		public static ITalkBackgroundClean GetRootAsITalkBackgroundClean(ByteBuffer _bb)
		{
			return ITalkBackgroundClean.GetRootAsITalkBackgroundClean(_bb, default(ITalkBackgroundClean));
		}

		// Token: 0x060340A8 RID: 213160 RVA: 0x006FF254 File Offset: 0x006FD454
		public static ITalkBackgroundClean GetRootAsITalkBackgroundClean(ByteBuffer _bb, ITalkBackgroundClean obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060340A9 RID: 213161 RVA: 0x006FF271 File Offset: 0x006FD471
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060340AA RID: 213162 RVA: 0x006FF280 File Offset: 0x006FD480
		public ITalkBackgroundClean __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D991 RID: 55697
		// (get) Token: 0x060340AB RID: 213163 RVA: 0x006FF290 File Offset: 0x006FD490
		public ETalkBackgroundType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETalkBackgroundType.Clean;
				}
				return (ETalkBackgroundType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060340AC RID: 213164 RVA: 0x006FF2CC File Offset: 0x006FD4CC
		public static Offset<ITalkBackgroundClean> CreateITalkBackgroundClean(FlatBufferBuilder builder, ETalkBackgroundType Type = ETalkBackgroundType.Clean)
		{
			builder.StartTable(1);
			ITalkBackgroundClean.AddType(builder, Type);
			return ITalkBackgroundClean.EndITalkBackgroundClean(builder);
		}

		// Token: 0x060340AD RID: 213165 RVA: 0x006FF2E2 File Offset: 0x006FD4E2
		public static void StartITalkBackgroundClean(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060340AE RID: 213166 RVA: 0x006FF2EB File Offset: 0x006FD4EB
		public static void AddType(FlatBufferBuilder builder, ETalkBackgroundType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060340AF RID: 213167 RVA: 0x006FF2F6 File Offset: 0x006FD4F6
		public static Offset<ITalkBackgroundClean> EndITalkBackgroundClean(FlatBufferBuilder builder)
		{
			return new Offset<ITalkBackgroundClean>(builder.EndTable());
		}

		// Token: 0x060340B0 RID: 213168 RVA: 0x006FF304 File Offset: 0x006FD504
		public ITalkBackgroundCleanT UnPack()
		{
			ITalkBackgroundCleanT talkBackgroundCleanT = new ITalkBackgroundCleanT();
			this.UnPackTo(talkBackgroundCleanT);
			return talkBackgroundCleanT;
		}

		// Token: 0x060340B1 RID: 213169 RVA: 0x006FF31F File Offset: 0x006FD51F
		public void UnPackTo(ITalkBackgroundCleanT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060340B2 RID: 213170 RVA: 0x006FF330 File Offset: 0x006FD530
		public static Offset<ITalkBackgroundClean> Pack(FlatBufferBuilder builder, ITalkBackgroundCleanT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkBackgroundClean>);
			}
			return ITalkBackgroundClean.CreateITalkBackgroundClean(builder, _o.Type);
		}

		// Token: 0x04011DA0 RID: 73120
		private Table __p;
	}
}
