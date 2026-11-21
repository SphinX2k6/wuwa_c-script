using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B21 RID: 31521
	public struct ITalkOptionQteSucceed : IFlatbufferObject
	{
		// Token: 0x1700EC16 RID: 60438
		// (get) Token: 0x06038C1B RID: 232475 RVA: 0x007AD129 File Offset: 0x007AB329
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06038C1C RID: 232476 RVA: 0x007AD136 File Offset: 0x007AB336
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06038C1D RID: 232477 RVA: 0x007AD140 File Offset: 0x007AB340
		public static ITalkOptionQteSucceed GetRootAsITalkOptionQteSucceed(ByteBuffer _bb)
		{
			return ITalkOptionQteSucceed.GetRootAsITalkOptionQteSucceed(_bb, default(ITalkOptionQteSucceed));
		}

		// Token: 0x06038C1E RID: 232478 RVA: 0x007AD15C File Offset: 0x007AB35C
		public static ITalkOptionQteSucceed GetRootAsITalkOptionQteSucceed(ByteBuffer _bb, ITalkOptionQteSucceed obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06038C1F RID: 232479 RVA: 0x007AD179 File Offset: 0x007AB379
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06038C20 RID: 232480 RVA: 0x007AD188 File Offset: 0x007AB388
		public ITalkOptionQteSucceed __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EC17 RID: 60439
		// (get) Token: 0x06038C21 RID: 232481 RVA: 0x007AD198 File Offset: 0x007AB398
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

		// Token: 0x06038C22 RID: 232482 RVA: 0x007AD1D4 File Offset: 0x007AB3D4
		public static Offset<ITalkOptionQteSucceed> CreateITalkOptionQteSucceed(FlatBufferBuilder builder, ETalkOptionParamType Type = ETalkOptionParamType.QteSucceed)
		{
			builder.StartTable(1);
			ITalkOptionQteSucceed.AddType(builder, Type);
			return ITalkOptionQteSucceed.EndITalkOptionQteSucceed(builder);
		}

		// Token: 0x06038C23 RID: 232483 RVA: 0x007AD1EA File Offset: 0x007AB3EA
		public static void StartITalkOptionQteSucceed(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06038C24 RID: 232484 RVA: 0x007AD1F3 File Offset: 0x007AB3F3
		public static void AddType(FlatBufferBuilder builder, ETalkOptionParamType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06038C25 RID: 232485 RVA: 0x007AD1FE File Offset: 0x007AB3FE
		public static Offset<ITalkOptionQteSucceed> EndITalkOptionQteSucceed(FlatBufferBuilder builder)
		{
			return new Offset<ITalkOptionQteSucceed>(builder.EndTable());
		}

		// Token: 0x06038C26 RID: 232486 RVA: 0x007AD20C File Offset: 0x007AB40C
		public ITalkOptionQteSucceedT UnPack()
		{
			ITalkOptionQteSucceedT talkOptionQteSucceedT = new ITalkOptionQteSucceedT();
			this.UnPackTo(talkOptionQteSucceedT);
			return talkOptionQteSucceedT;
		}

		// Token: 0x06038C27 RID: 232487 RVA: 0x007AD227 File Offset: 0x007AB427
		public void UnPackTo(ITalkOptionQteSucceedT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06038C28 RID: 232488 RVA: 0x007AD238 File Offset: 0x007AB438
		public static Offset<ITalkOptionQteSucceed> Pack(FlatBufferBuilder builder, ITalkOptionQteSucceedT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkOptionQteSucceed>);
			}
			return ITalkOptionQteSucceed.CreateITalkOptionQteSucceed(builder, _o.Type);
		}

		// Token: 0x04013148 RID: 78152
		private Table __p;
	}
}
