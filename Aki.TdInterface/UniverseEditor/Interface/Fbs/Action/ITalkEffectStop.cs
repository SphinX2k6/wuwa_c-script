using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072B3 RID: 29363
	public struct ITalkEffectStop : IFlatbufferObject
	{
		// Token: 0x1700D9CC RID: 55756
		// (get) Token: 0x060341A3 RID: 213411 RVA: 0x00700C47 File Offset: 0x006FEE47
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060341A4 RID: 213412 RVA: 0x00700C54 File Offset: 0x006FEE54
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060341A5 RID: 213413 RVA: 0x00700C5C File Offset: 0x006FEE5C
		public static ITalkEffectStop GetRootAsITalkEffectStop(ByteBuffer _bb)
		{
			return ITalkEffectStop.GetRootAsITalkEffectStop(_bb, default(ITalkEffectStop));
		}

		// Token: 0x060341A6 RID: 213414 RVA: 0x00700C78 File Offset: 0x006FEE78
		public static ITalkEffectStop GetRootAsITalkEffectStop(ByteBuffer _bb, ITalkEffectStop obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060341A7 RID: 213415 RVA: 0x00700C95 File Offset: 0x006FEE95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060341A8 RID: 213416 RVA: 0x00700CA4 File Offset: 0x006FEEA4
		public ITalkEffectStop __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D9CD RID: 55757
		// (get) Token: 0x060341A9 RID: 213417 RVA: 0x00700CB4 File Offset: 0x006FEEB4
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

		// Token: 0x060341AA RID: 213418 RVA: 0x00700CF0 File Offset: 0x006FEEF0
		public string EffectKeys(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D9CE RID: 55758
		// (get) Token: 0x060341AB RID: 213419 RVA: 0x00700D2C File Offset: 0x006FEF2C
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

		// Token: 0x1700D9CF RID: 55759
		// (get) Token: 0x060341AC RID: 213420 RVA: 0x00700D58 File Offset: 0x006FEF58
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

		// Token: 0x1700D9D0 RID: 55760
		// (get) Token: 0x060341AD RID: 213421 RVA: 0x00700D98 File Offset: 0x006FEF98
		public bool ImmediatelyDestroy
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D9D1 RID: 55761
		// (get) Token: 0x060341AE RID: 213422 RVA: 0x00700DD8 File Offset: 0x006FEFD8
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

		// Token: 0x060341AF RID: 213423 RVA: 0x00700E15 File Offset: 0x006FF015
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

		// Token: 0x060341B0 RID: 213424 RVA: 0x00700E49 File Offset: 0x006FF049
		public static void StartITalkEffectStop(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060341B1 RID: 213425 RVA: 0x00700E52 File Offset: 0x006FF052
		public static void AddType(FlatBufferBuilder builder, ETalkEffectActionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060341B2 RID: 213426 RVA: 0x00700E5D File Offset: 0x006FF05D
		public static void AddEffectKeys(FlatBufferBuilder builder, VectorOffset effectKeysOffset)
		{
			builder.AddOffset(1, effectKeysOffset.Value, 0);
		}

		// Token: 0x060341B3 RID: 213427 RVA: 0x00700E70 File Offset: 0x006FF070
		public static VectorOffset CreateEffectKeysVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060341B4 RID: 213428 RVA: 0x00700EB0 File Offset: 0x006FF0B0
		public static VectorOffset CreateEffectKeysVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060341B5 RID: 213429 RVA: 0x00700ECA File Offset: 0x006FF0CA
		public static VectorOffset CreateEffectKeysVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060341B6 RID: 213430 RVA: 0x00700EE8 File Offset: 0x006FF0E8
		public static VectorOffset CreateEffectKeysVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060341B7 RID: 213431 RVA: 0x00700F01 File Offset: 0x006FF101
		public static void StartEffectKeysVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060341B8 RID: 213432 RVA: 0x00700F0C File Offset: 0x006FF10C
		public static void AddDelayTime(FlatBufferBuilder builder, float delayTime)
		{
			builder.AddFloat(2, delayTime, 0.0);
		}

		// Token: 0x060341B9 RID: 213433 RVA: 0x00700F1F File Offset: 0x006FF11F
		public static void AddImmediatelyDestroy(FlatBufferBuilder builder, bool immediatelyDestroy)
		{
			builder.AddBool(3, immediatelyDestroy, false);
		}

		// Token: 0x060341BA RID: 213434 RVA: 0x00700F2A File Offset: 0x006FF12A
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x060341BB RID: 213435 RVA: 0x00700F35 File Offset: 0x006FF135
		public static Offset<ITalkEffectStop> EndITalkEffectStop(FlatBufferBuilder builder)
		{
			return new Offset<ITalkEffectStop>(builder.EndTable());
		}

		// Token: 0x060341BC RID: 213436 RVA: 0x00700F44 File Offset: 0x006FF144
		public ITalkEffectStopT UnPack()
		{
			ITalkEffectStopT talkEffectStopT = new ITalkEffectStopT();
			this.UnPackTo(talkEffectStopT);
			return talkEffectStopT;
		}

		// Token: 0x060341BD RID: 213437 RVA: 0x00700F60 File Offset: 0x006FF160
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

		// Token: 0x060341BE RID: 213438 RVA: 0x00700FCC File Offset: 0x006FF1CC
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

		// Token: 0x04011DD1 RID: 73169
		private Table __p;
	}
}
