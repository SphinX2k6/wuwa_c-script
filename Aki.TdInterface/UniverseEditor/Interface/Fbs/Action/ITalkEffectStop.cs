using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A88 RID: 31368
	public struct ITalkEffectStop : IFlatbufferObject
	{
		// Token: 0x1700E5C5 RID: 58821
		// (get) Token: 0x060374A7 RID: 226471 RVA: 0x00761FE3 File Offset: 0x007601E3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060374A8 RID: 226472 RVA: 0x00761FF0 File Offset: 0x007601F0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060374A9 RID: 226473 RVA: 0x00761FF8 File Offset: 0x007601F8
		public static ITalkEffectStop GetRootAsITalkEffectStop(ByteBuffer _bb)
		{
			return ITalkEffectStop.GetRootAsITalkEffectStop(_bb, default(ITalkEffectStop));
		}

		// Token: 0x060374AA RID: 226474 RVA: 0x00762014 File Offset: 0x00760214
		public static ITalkEffectStop GetRootAsITalkEffectStop(ByteBuffer _bb, ITalkEffectStop obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060374AB RID: 226475 RVA: 0x00762031 File Offset: 0x00760231
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060374AC RID: 226476 RVA: 0x00762040 File Offset: 0x00760240
		public ITalkEffectStop __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E5C6 RID: 58822
		// (get) Token: 0x060374AD RID: 226477 RVA: 0x00762050 File Offset: 0x00760250
		public ETalkEffectActionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETalkEffectActionType.Play;
				}
				return (ETalkEffectActionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060374AE RID: 226478 RVA: 0x0076208C File Offset: 0x0076028C
		public string EffectKeys(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700E5C7 RID: 58823
		// (get) Token: 0x060374AF RID: 226479 RVA: 0x007620C8 File Offset: 0x007602C8
		public int EffectKeysLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700E5C8 RID: 58824
		// (get) Token: 0x060374B0 RID: 226480 RVA: 0x007620F4 File Offset: 0x007602F4
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

		// Token: 0x1700E5C9 RID: 58825
		// (get) Token: 0x060374B1 RID: 226481 RVA: 0x00762134 File Offset: 0x00760334
		public bool ImmediatelyDestroy
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E5CA RID: 58826
		// (get) Token: 0x060374B2 RID: 226482 RVA: 0x00762174 File Offset: 0x00760374
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060374B3 RID: 226483 RVA: 0x007621B1 File Offset: 0x007603B1
		public static Offset<ITalkEffectStop> CreateITalkEffectStop(FlatBufferBuilder builder, ETalkEffectActionType Type = ETalkEffectActionType.Play, VectorOffset EffectKeysOffset = default(VectorOffset), float DelayTime = 0f, bool ImmediatelyDestroy = false, byte NullMask = 0)
		{
			builder.StartTable(5);
			ITalkEffectStop.AddDelayTime(builder, DelayTime);
			ITalkEffectStop.AddEffectKeys(builder, EffectKeysOffset);
			ITalkEffectStop.AddNullMask(builder, NullMask);
			ITalkEffectStop.AddImmediatelyDestroy(builder, ImmediatelyDestroy);
			ITalkEffectStop.AddType(builder, Type);
			return ITalkEffectStop.EndITalkEffectStop(builder);
		}

		// Token: 0x060374B4 RID: 226484 RVA: 0x007621E5 File Offset: 0x007603E5
		public static void StartITalkEffectStop(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060374B5 RID: 226485 RVA: 0x007621EE File Offset: 0x007603EE
		public static void AddType(FlatBufferBuilder builder, ETalkEffectActionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060374B6 RID: 226486 RVA: 0x007621F9 File Offset: 0x007603F9
		public static void AddEffectKeys(FlatBufferBuilder builder, VectorOffset effectKeysOffset)
		{
			builder.AddOffset(1, effectKeysOffset.Value, 0);
		}

		// Token: 0x060374B7 RID: 226487 RVA: 0x0076220C File Offset: 0x0076040C
		public static VectorOffset CreateEffectKeysVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060374B8 RID: 226488 RVA: 0x0076224C File Offset: 0x0076044C
		public static VectorOffset CreateEffectKeysVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060374B9 RID: 226489 RVA: 0x00762266 File Offset: 0x00760466
		public static VectorOffset CreateEffectKeysVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060374BA RID: 226490 RVA: 0x00762284 File Offset: 0x00760484
		public static VectorOffset CreateEffectKeysVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060374BB RID: 226491 RVA: 0x0076229D File Offset: 0x0076049D
		public static void StartEffectKeysVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060374BC RID: 226492 RVA: 0x007622A8 File Offset: 0x007604A8
		public static void AddDelayTime(FlatBufferBuilder builder, float delayTime)
		{
			builder.AddFloat(2, delayTime, 0.0);
		}

		// Token: 0x060374BD RID: 226493 RVA: 0x007622BB File Offset: 0x007604BB
		public static void AddImmediatelyDestroy(FlatBufferBuilder builder, bool immediatelyDestroy)
		{
			builder.AddBool(3, immediatelyDestroy, false);
		}

		// Token: 0x060374BE RID: 226494 RVA: 0x007622C6 File Offset: 0x007604C6
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x060374BF RID: 226495 RVA: 0x007622D1 File Offset: 0x007604D1
		public static Offset<ITalkEffectStop> EndITalkEffectStop(FlatBufferBuilder builder)
		{
			return new Offset<ITalkEffectStop>(builder.EndTable());
		}

		// Token: 0x060374C0 RID: 226496 RVA: 0x007622E0 File Offset: 0x007604E0
		public ITalkEffectStopT UnPack()
		{
			ITalkEffectStopT talkEffectStopT = new ITalkEffectStopT();
			this.UnPackTo(talkEffectStopT);
			return talkEffectStopT;
		}

		// Token: 0x060374C1 RID: 226497 RVA: 0x007622FC File Offset: 0x007604FC
		public void UnPackTo(ITalkEffectStopT _o)
		{
			_o.Type = this.Type;
			_o.EffectKeys = new List<string>();
			for (int i = 0; i < this.EffectKeysLength; i++)
			{
				_o.EffectKeys.Add(this.EffectKeys(i));
			}
			_o.DelayTime = this.DelayTime;
			_o.ImmediatelyDestroy = this.ImmediatelyDestroy;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060374C2 RID: 226498 RVA: 0x00762368 File Offset: 0x00760568
		public static Offset<ITalkEffectStop> Pack(FlatBufferBuilder builder, ITalkEffectStopT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkEffectStop>);
			}
			VectorOffset effectKeysOffset = default(VectorOffset);
			if (_o.EffectKeys != null)
			{
				StringOffset[] array = new StringOffset[_o.EffectKeys.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.EffectKeys[i]);
				}
				effectKeysOffset = ITalkEffectStop.CreateEffectKeysVector(builder, array);
			}
			return ITalkEffectStop.CreateITalkEffectStop(builder, _o.Type, effectKeysOffset, _o.DelayTime, _o.ImmediatelyDestroy, _o.NullMask);
		}

		// Token: 0x04012DD4 RID: 77268
		private Table __p;
	}
}
