using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070EE RID: 28910
	public struct ILiveDanmakuPool : IFlatbufferObject
	{
		// Token: 0x1700D3B3 RID: 54195
		// (get) Token: 0x06032342 RID: 205634 RVA: 0x006CA7D0 File Offset: 0x006C89D0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032343 RID: 205635 RVA: 0x006CA7DD File Offset: 0x006C89DD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032344 RID: 205636 RVA: 0x006CA7E4 File Offset: 0x006C89E4
		public static ILiveDanmakuPool GetRootAsILiveDanmakuPool(ByteBuffer _bb)
		{
			return ILiveDanmakuPool.GetRootAsILiveDanmakuPool(_bb, default(ILiveDanmakuPool));
		}

		// Token: 0x06032345 RID: 205637 RVA: 0x006CA800 File Offset: 0x006C8A00
		public static ILiveDanmakuPool GetRootAsILiveDanmakuPool(ByteBuffer _bb, ILiveDanmakuPool obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032346 RID: 205638 RVA: 0x006CA81D File Offset: 0x006C8A1D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032347 RID: 205639 RVA: 0x006CA82C File Offset: 0x006C8A2C
		public ILiveDanmakuPool __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D3B4 RID: 54196
		// (get) Token: 0x06032348 RID: 205640 RVA: 0x006CA83C File Offset: 0x006C8A3C
		public int DanmakuPoolId
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

		// Token: 0x1700D3B5 RID: 54197
		// (get) Token: 0x06032349 RID: 205641 RVA: 0x006CA878 File Offset: 0x006C8A78
		public float Weight
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D3B6 RID: 54198
		// (get) Token: 0x0603234A RID: 205642 RVA: 0x006CA8B8 File Offset: 0x006C8AB8
		public float DelayTime
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D3B7 RID: 54199
		// (get) Token: 0x0603234B RID: 205643 RVA: 0x006CA8F8 File Offset: 0x006C8AF8
		public ELiveDanmakuLoopType LoopType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return ELiveDanmakuLoopType.OrderOnce;
				}
				return (ELiveDanmakuLoopType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603234C RID: 205644 RVA: 0x006CA935 File Offset: 0x006C8B35
		public static Offset<ILiveDanmakuPool> CreateILiveDanmakuPool(FlatBufferBuilder builder, int DanmakuPoolId = 0, float Weight = 0f, float DelayTime = 0f, ELiveDanmakuLoopType LoopType = ELiveDanmakuLoopType.OrderOnce)
		{
			builder.StartTable(4);
			ILiveDanmakuPool.AddDelayTime(builder, DelayTime);
			ILiveDanmakuPool.AddWeight(builder, Weight);
			ILiveDanmakuPool.AddDanmakuPoolId(builder, DanmakuPoolId);
			ILiveDanmakuPool.AddLoopType(builder, LoopType);
			return ILiveDanmakuPool.EndILiveDanmakuPool(builder);
		}

		// Token: 0x0603234D RID: 205645 RVA: 0x006CA961 File Offset: 0x006C8B61
		public static void StartILiveDanmakuPool(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0603234E RID: 205646 RVA: 0x006CA96A File Offset: 0x006C8B6A
		public static void AddDanmakuPoolId(FlatBufferBuilder builder, int danmakuPoolId)
		{
			builder.AddInt(0, danmakuPoolId, 0);
		}

		// Token: 0x0603234F RID: 205647 RVA: 0x006CA975 File Offset: 0x006C8B75
		public static void AddWeight(FlatBufferBuilder builder, float weight)
		{
			builder.AddFloat(1, weight, 0.0);
		}

		// Token: 0x06032350 RID: 205648 RVA: 0x006CA988 File Offset: 0x006C8B88
		public static void AddDelayTime(FlatBufferBuilder builder, float delayTime)
		{
			builder.AddFloat(2, delayTime, 0.0);
		}

		// Token: 0x06032351 RID: 205649 RVA: 0x006CA99B File Offset: 0x006C8B9B
		public static void AddLoopType(FlatBufferBuilder builder, ELiveDanmakuLoopType loopType)
		{
			builder.AddByte(3, (byte)loopType, 0);
		}

		// Token: 0x06032352 RID: 205650 RVA: 0x006CA9A6 File Offset: 0x006C8BA6
		public static Offset<ILiveDanmakuPool> EndILiveDanmakuPool(FlatBufferBuilder builder)
		{
			return new Offset<ILiveDanmakuPool>(builder.EndTable());
		}

		// Token: 0x06032353 RID: 205651 RVA: 0x006CA9B4 File Offset: 0x006C8BB4
		public ILiveDanmakuPoolT UnPack()
		{
			ILiveDanmakuPoolT liveDanmakuPoolT = new ILiveDanmakuPoolT();
			this.UnPackTo(liveDanmakuPoolT);
			return liveDanmakuPoolT;
		}

		// Token: 0x06032354 RID: 205652 RVA: 0x006CA9CF File Offset: 0x006C8BCF
		public void UnPackTo(ILiveDanmakuPoolT _o)
		{
			_o.DanmakuPoolId = this.DanmakuPoolId;
			_o.Weight = this.Weight;
			_o.DelayTime = this.DelayTime;
			_o.LoopType = this.LoopType;
		}

		// Token: 0x06032355 RID: 205653 RVA: 0x006CAA04 File Offset: 0x006C8C04
		public static Offset<ILiveDanmakuPool> Pack(FlatBufferBuilder builder, ILiveDanmakuPoolT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILiveDanmakuPool>);
			}
			return ILiveDanmakuPool.CreateILiveDanmakuPool(builder, _o.DanmakuPoolId, _o.Weight, _o.DelayTime, _o.LoopType);
		}

		// Token: 0x040120BC RID: 73916
		private Table __p;
	}
}
