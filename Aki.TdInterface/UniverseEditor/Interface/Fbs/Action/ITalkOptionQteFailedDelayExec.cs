using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B1E RID: 31518
	public struct ITalkOptionQteFailedDelayExec : IFlatbufferObject
	{
		// Token: 0x1700EC13 RID: 60435
		// (get) Token: 0x06038C09 RID: 232457 RVA: 0x007ACFB1 File Offset: 0x007AB1B1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06038C0A RID: 232458 RVA: 0x007ACFBE File Offset: 0x007AB1BE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06038C0B RID: 232459 RVA: 0x007ACFC8 File Offset: 0x007AB1C8
		public static ITalkOptionQteFailedDelayExec GetRootAsITalkOptionQteFailedDelayExec(ByteBuffer _bb)
		{
			return ITalkOptionQteFailedDelayExec.GetRootAsITalkOptionQteFailedDelayExec(_bb, default(ITalkOptionQteFailedDelayExec));
		}

		// Token: 0x06038C0C RID: 232460 RVA: 0x007ACFE4 File Offset: 0x007AB1E4
		public static ITalkOptionQteFailedDelayExec GetRootAsITalkOptionQteFailedDelayExec(ByteBuffer _bb, ITalkOptionQteFailedDelayExec obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06038C0D RID: 232461 RVA: 0x007AD001 File Offset: 0x007AB201
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06038C0E RID: 232462 RVA: 0x007AD010 File Offset: 0x007AB210
		public ITalkOptionQteFailedDelayExec __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EC14 RID: 60436
		// (get) Token: 0x06038C0F RID: 232463 RVA: 0x007AD020 File Offset: 0x007AB220
		public ETalkOptionParamType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETalkOptionParamType.QteSucceed;
				}
				return (ETalkOptionParamType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06038C10 RID: 232464 RVA: 0x007AD05C File Offset: 0x007AB25C
		public static Offset<ITalkOptionQteFailedDelayExec> CreateITalkOptionQteFailedDelayExec(FlatBufferBuilder builder, ETalkOptionParamType Type = ETalkOptionParamType.QteSucceed)
		{
			builder.StartTable(1);
			ITalkOptionQteFailedDelayExec.AddType(builder, Type);
			return ITalkOptionQteFailedDelayExec.EndITalkOptionQteFailedDelayExec(builder);
		}

		// Token: 0x06038C11 RID: 232465 RVA: 0x007AD072 File Offset: 0x007AB272
		public static void StartITalkOptionQteFailedDelayExec(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06038C12 RID: 232466 RVA: 0x007AD07B File Offset: 0x007AB27B
		public static void AddType(FlatBufferBuilder builder, ETalkOptionParamType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06038C13 RID: 232467 RVA: 0x007AD086 File Offset: 0x007AB286
		public static Offset<ITalkOptionQteFailedDelayExec> EndITalkOptionQteFailedDelayExec(FlatBufferBuilder builder)
		{
			return new Offset<ITalkOptionQteFailedDelayExec>(builder.EndTable());
		}

		// Token: 0x06038C14 RID: 232468 RVA: 0x007AD094 File Offset: 0x007AB294
		public ITalkOptionQteFailedDelayExecT UnPack()
		{
			ITalkOptionQteFailedDelayExecT talkOptionQteFailedDelayExecT = new ITalkOptionQteFailedDelayExecT();
			this.UnPackTo(talkOptionQteFailedDelayExecT);
			return talkOptionQteFailedDelayExecT;
		}

		// Token: 0x06038C15 RID: 232469 RVA: 0x007AD0AF File Offset: 0x007AB2AF
		public void UnPackTo(ITalkOptionQteFailedDelayExecT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06038C16 RID: 232470 RVA: 0x007AD0C0 File Offset: 0x007AB2C0
		public static Offset<ITalkOptionQteFailedDelayExec> Pack(FlatBufferBuilder builder, ITalkOptionQteFailedDelayExecT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkOptionQteFailedDelayExec>);
			}
			return ITalkOptionQteFailedDelayExec.CreateITalkOptionQteFailedDelayExec(builder, _o.Type);
		}

		// Token: 0x04013146 RID: 78150
		private Table __p;
	}
}
