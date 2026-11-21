using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044C3 RID: 17603
	public struct IRecallConfig : IFlatbufferObject
	{
		// Token: 0x17007A8F RID: 31375
		// (get) Token: 0x060196F4 RID: 104180 RVA: 0x003A116E File Offset: 0x0039F36E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060196F5 RID: 104181 RVA: 0x003A117B File Offset: 0x0039F37B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060196F6 RID: 104182 RVA: 0x003A1184 File Offset: 0x0039F384
		public static IRecallConfig GetRootAsIRecallConfig(ByteBuffer _bb)
		{
			return IRecallConfig.GetRootAsIRecallConfig(_bb, default(IRecallConfig));
		}

		// Token: 0x060196F7 RID: 104183 RVA: 0x003A11A0 File Offset: 0x0039F3A0
		public static IRecallConfig GetRootAsIRecallConfig(ByteBuffer _bb, IRecallConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060196F8 RID: 104184 RVA: 0x003A11BD File Offset: 0x0039F3BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060196F9 RID: 104185 RVA: 0x003A11CC File Offset: 0x0039F3CC
		public IRecallConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007A90 RID: 31376
		// (get) Token: 0x060196FA RID: 104186 RVA: 0x003A11DC File Offset: 0x0039F3DC
		public int RecallId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060196FB RID: 104187 RVA: 0x003A1218 File Offset: 0x0039F418
		public static Offset<IRecallConfig> CreateIRecallConfig(FlatBufferBuilder builder, int RecallId = 0)
		{
			builder.StartTable(1);
			IRecallConfig.AddRecallId(builder, RecallId);
			return IRecallConfig.EndIRecallConfig(builder);
		}

		// Token: 0x060196FC RID: 104188 RVA: 0x003A122E File Offset: 0x0039F42E
		public static void StartIRecallConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060196FD RID: 104189 RVA: 0x003A1237 File Offset: 0x0039F437
		public static void AddRecallId(FlatBufferBuilder builder, int recallId)
		{
			builder.AddInt(0, recallId, 0);
		}

		// Token: 0x060196FE RID: 104190 RVA: 0x003A1242 File Offset: 0x0039F442
		public static Offset<IRecallConfig> EndIRecallConfig(FlatBufferBuilder builder)
		{
			return new Offset<IRecallConfig>(builder.EndTable());
		}

		// Token: 0x060196FF RID: 104191 RVA: 0x003A1250 File Offset: 0x0039F450
		public IRecallConfigT UnPack()
		{
			IRecallConfigT recallConfigT = new IRecallConfigT();
			this.UnPackTo(recallConfigT);
			return recallConfigT;
		}

		// Token: 0x06019700 RID: 104192 RVA: 0x003A126B File Offset: 0x0039F46B
		public void UnPackTo(IRecallConfigT _o)
		{
			_o.RecallId = this.RecallId;
		}

		// Token: 0x06019701 RID: 104193 RVA: 0x003A127C File Offset: 0x0039F47C
		public static Offset<IRecallConfig> Pack(FlatBufferBuilder builder, IRecallConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRecallConfig>);
			}
			return IRecallConfig.CreateIRecallConfig(builder, _o.RecallId);
		}

		// Token: 0x0400C5EF RID: 50671
		private Table __p;
	}
}
