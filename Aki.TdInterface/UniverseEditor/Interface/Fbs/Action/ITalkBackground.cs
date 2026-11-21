using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A67 RID: 31335
	public struct ITalkBackground : IFlatbufferObject
	{
		// Token: 0x1700E586 RID: 58758
		// (get) Token: 0x06037397 RID: 226199 RVA: 0x00760446 File Offset: 0x0075E646
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06037398 RID: 226200 RVA: 0x00760453 File Offset: 0x0075E653
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06037399 RID: 226201 RVA: 0x0076045C File Offset: 0x0075E65C
		public static ITalkBackground GetRootAsITalkBackground(ByteBuffer _bb)
		{
			return ITalkBackground.GetRootAsITalkBackground(_bb, default(ITalkBackground));
		}

		// Token: 0x0603739A RID: 226202 RVA: 0x00760478 File Offset: 0x0075E678
		public static ITalkBackground GetRootAsITalkBackground(ByteBuffer _bb, ITalkBackground obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603739B RID: 226203 RVA: 0x00760495 File Offset: 0x0075E695
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603739C RID: 226204 RVA: 0x007604A4 File Offset: 0x0075E6A4
		public ITalkBackground __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E587 RID: 58759
		// (get) Token: 0x0603739D RID: 226205 RVA: 0x007604B4 File Offset: 0x0075E6B4
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

		// Token: 0x0603739E RID: 226206 RVA: 0x007604F0 File Offset: 0x0075E6F0
		public static Offset<ITalkBackground> CreateITalkBackground(FlatBufferBuilder builder, ETalkBackgroundType Type = ETalkBackgroundType.Clean)
		{
			builder.StartTable(1);
			ITalkBackground.AddType(builder, Type);
			return ITalkBackground.EndITalkBackground(builder);
		}

		// Token: 0x0603739F RID: 226207 RVA: 0x00760506 File Offset: 0x0075E706
		public static void StartITalkBackground(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060373A0 RID: 226208 RVA: 0x0076050F File Offset: 0x0075E70F
		public static void AddType(FlatBufferBuilder builder, ETalkBackgroundType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060373A1 RID: 226209 RVA: 0x0076051A File Offset: 0x0075E71A
		public static Offset<ITalkBackground> EndITalkBackground(FlatBufferBuilder builder)
		{
			return new Offset<ITalkBackground>(builder.EndTable());
		}

		// Token: 0x060373A2 RID: 226210 RVA: 0x00760528 File Offset: 0x0075E728
		public ITalkBackgroundT UnPack()
		{
			ITalkBackgroundT talkBackgroundT = new ITalkBackgroundT();
			this.UnPackTo(talkBackgroundT);
			return talkBackgroundT;
		}

		// Token: 0x060373A3 RID: 226211 RVA: 0x00760543 File Offset: 0x0075E743
		public void UnPackTo(ITalkBackgroundT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060373A4 RID: 226212 RVA: 0x00760554 File Offset: 0x0075E754
		public static Offset<ITalkBackground> Pack(FlatBufferBuilder builder, ITalkBackgroundT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkBackground>);
			}
			return ITalkBackground.CreateITalkBackground(builder, _o.Type);
		}

		// Token: 0x04012DA1 RID: 77217
		private Table __p;
	}
}
