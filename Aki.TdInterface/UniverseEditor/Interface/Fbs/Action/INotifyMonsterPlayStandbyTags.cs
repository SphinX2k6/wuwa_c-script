using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BAF RID: 27567
	public struct INotifyMonsterPlayStandbyTags : IFlatbufferObject
	{
		// Token: 0x1700CCE4 RID: 52452
		// (get) Token: 0x060306C9 RID: 198345 RVA: 0x00693956 File Offset: 0x00691B56
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060306CA RID: 198346 RVA: 0x00693963 File Offset: 0x00691B63
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060306CB RID: 198347 RVA: 0x0069396C File Offset: 0x00691B6C
		public static INotifyMonsterPlayStandbyTags GetRootAsINotifyMonsterPlayStandbyTags(ByteBuffer _bb)
		{
			return INotifyMonsterPlayStandbyTags.GetRootAsINotifyMonsterPlayStandbyTags(_bb, default(INotifyMonsterPlayStandbyTags));
		}

		// Token: 0x060306CC RID: 198348 RVA: 0x00693988 File Offset: 0x00691B88
		public static INotifyMonsterPlayStandbyTags GetRootAsINotifyMonsterPlayStandbyTags(ByteBuffer _bb, INotifyMonsterPlayStandbyTags obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060306CD RID: 198349 RVA: 0x006939A5 File Offset: 0x00691BA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060306CE RID: 198350 RVA: 0x006939B4 File Offset: 0x00691BB4
		public INotifyMonsterPlayStandbyTags __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CCE5 RID: 52453
		// (get) Token: 0x060306CF RID: 198351 RVA: 0x006939C4 File Offset: 0x00691BC4
		public ESetBattleStateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESetBattleStateType.SetBattleTag;
				}
				return (ESetBattleStateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060306D0 RID: 198352 RVA: 0x00693A00 File Offset: 0x00691C00
		public IMonsterStandByConfig? StandbyConfigs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IMonsterStandByConfig?(default(IMonsterStandByConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700CCE6 RID: 52454
		// (get) Token: 0x060306D1 RID: 198353 RVA: 0x00693A60 File Offset: 0x00691C60
		public int StandbyConfigsLength
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

		// Token: 0x1700CCE7 RID: 52455
		// (get) Token: 0x060306D2 RID: 198354 RVA: 0x00693A8C File Offset: 0x00691C8C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060306D3 RID: 198355 RVA: 0x00693AC8 File Offset: 0x00691CC8
		public static Offset<INotifyMonsterPlayStandbyTags> CreateINotifyMonsterPlayStandbyTags(FlatBufferBuilder builder, ESetBattleStateType Type = ESetBattleStateType.SetBattleTag, VectorOffset StandbyConfigsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			INotifyMonsterPlayStandbyTags.AddStandbyConfigs(builder, StandbyConfigsOffset);
			INotifyMonsterPlayStandbyTags.AddNullMask(builder, NullMask);
			INotifyMonsterPlayStandbyTags.AddType(builder, Type);
			return INotifyMonsterPlayStandbyTags.EndINotifyMonsterPlayStandbyTags(builder);
		}

		// Token: 0x060306D4 RID: 198356 RVA: 0x00693AEC File Offset: 0x00691CEC
		public static void StartINotifyMonsterPlayStandbyTags(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060306D5 RID: 198357 RVA: 0x00693AF5 File Offset: 0x00691CF5
		public static void AddType(FlatBufferBuilder builder, ESetBattleStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060306D6 RID: 198358 RVA: 0x00693B00 File Offset: 0x00691D00
		public static void AddStandbyConfigs(FlatBufferBuilder builder, VectorOffset standbyConfigsOffset)
		{
			builder.AddOffset(1, standbyConfigsOffset.Value, 0);
		}

		// Token: 0x060306D7 RID: 198359 RVA: 0x00693B10 File Offset: 0x00691D10
		public static VectorOffset CreateStandbyConfigsVector(FlatBufferBuilder builder, Offset<IMonsterStandByConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060306D8 RID: 198360 RVA: 0x00693B50 File Offset: 0x00691D50
		public static VectorOffset CreateStandbyConfigsVectorBlock(FlatBufferBuilder builder, Offset<IMonsterStandByConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IMonsterStandByConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x060306D9 RID: 198361 RVA: 0x00693B6A File Offset: 0x00691D6A
		public static VectorOffset CreateStandbyConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IMonsterStandByConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IMonsterStandByConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x060306DA RID: 198362 RVA: 0x00693B88 File Offset: 0x00691D88
		public static VectorOffset CreateStandbyConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IMonsterStandByConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060306DB RID: 198363 RVA: 0x00693BA1 File Offset: 0x00691DA1
		public static void StartStandbyConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060306DC RID: 198364 RVA: 0x00693BAC File Offset: 0x00691DAC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x060306DD RID: 198365 RVA: 0x00693BB7 File Offset: 0x00691DB7
		public static Offset<INotifyMonsterPlayStandbyTags> EndINotifyMonsterPlayStandbyTags(FlatBufferBuilder builder)
		{
			return new Offset<INotifyMonsterPlayStandbyTags>(builder.EndTable());
		}

		// Token: 0x060306DE RID: 198366 RVA: 0x00693BC4 File Offset: 0x00691DC4
		public INotifyMonsterPlayStandbyTagsT UnPack()
		{
			INotifyMonsterPlayStandbyTagsT notifyMonsterPlayStandbyTagsT = new INotifyMonsterPlayStandbyTagsT();
			this.UnPackTo(notifyMonsterPlayStandbyTagsT);
			return notifyMonsterPlayStandbyTagsT;
		}

		// Token: 0x060306DF RID: 198367 RVA: 0x00693BE0 File Offset: 0x00691DE0
		public void UnPackTo(INotifyMonsterPlayStandbyTagsT _o)
		{
			_o.Type = this.Type;
			_o.StandbyConfigs = new List<IMonsterStandByConfigT>();
			for (int i = 0; i < this.StandbyConfigsLength; i++)
			{
				_o.StandbyConfigs.Add((this.StandbyConfigs(i) != null) ? this.StandbyConfigs(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060306E0 RID: 198368 RVA: 0x00693C58 File Offset: 0x00691E58
		public static Offset<INotifyMonsterPlayStandbyTags> Pack(FlatBufferBuilder builder, INotifyMonsterPlayStandbyTagsT _o)
		{
			if (_o == null)
			{
				return default(Offset<INotifyMonsterPlayStandbyTags>);
			}
			VectorOffset standbyConfigsOffset = default(VectorOffset);
			if (_o.StandbyConfigs != null)
			{
				Offset<IMonsterStandByConfig>[] array = new Offset<IMonsterStandByConfig>[_o.StandbyConfigs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IMonsterStandByConfig.Pack(builder, _o.StandbyConfigs[i]);
				}
				standbyConfigsOffset = INotifyMonsterPlayStandbyTags.CreateStandbyConfigsVector(builder, array);
			}
			return INotifyMonsterPlayStandbyTags.CreateINotifyMonsterPlayStandbyTags(builder, _o.Type, standbyConfigsOffset, _o.NullMask);
		}

		// Token: 0x04011482 RID: 70786
		private Table __p;
	}
}
