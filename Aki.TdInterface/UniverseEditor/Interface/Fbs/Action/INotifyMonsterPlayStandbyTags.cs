using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072FB RID: 29435
	public struct INotifyMonsterPlayStandbyTags : IFlatbufferObject
	{
		// Token: 0x1700D7D0 RID: 55248
		// (get) Token: 0x06033543 RID: 210243 RVA: 0x006EC2F6 File Offset: 0x006EA4F6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033544 RID: 210244 RVA: 0x006EC303 File Offset: 0x006EA503
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033545 RID: 210245 RVA: 0x006EC30C File Offset: 0x006EA50C
		public static INotifyMonsterPlayStandbyTags GetRootAsINotifyMonsterPlayStandbyTags(ByteBuffer _bb)
		{
			return INotifyMonsterPlayStandbyTags.GetRootAsINotifyMonsterPlayStandbyTags(_bb, default(INotifyMonsterPlayStandbyTags));
		}

		// Token: 0x06033546 RID: 210246 RVA: 0x006EC328 File Offset: 0x006EA528
		public static INotifyMonsterPlayStandbyTags GetRootAsINotifyMonsterPlayStandbyTags(ByteBuffer _bb, INotifyMonsterPlayStandbyTags obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033547 RID: 210247 RVA: 0x006EC345 File Offset: 0x006EA545
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033548 RID: 210248 RVA: 0x006EC354 File Offset: 0x006EA554
		public INotifyMonsterPlayStandbyTags __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D7D1 RID: 55249
		// (get) Token: 0x06033549 RID: 210249 RVA: 0x006EC364 File Offset: 0x006EA564
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

		// Token: 0x0603354A RID: 210250 RVA: 0x006EC3A0 File Offset: 0x006EA5A0
		public IMonsterStandByConfig? StandbyConfigs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IMonsterStandByConfig?(default(IMonsterStandByConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700D7D2 RID: 55250
		// (get) Token: 0x0603354B RID: 210251 RVA: 0x006EC400 File Offset: 0x006EA600
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

		// Token: 0x1700D7D3 RID: 55251
		// (get) Token: 0x0603354C RID: 210252 RVA: 0x006EC42C File Offset: 0x006EA62C
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

		// Token: 0x0603354D RID: 210253 RVA: 0x006EC468 File Offset: 0x006EA668
		public static Offset<INotifyMonsterPlayStandbyTags> CreateINotifyMonsterPlayStandbyTags(FlatBufferBuilder builder, ESetBattleStateType Type = ESetBattleStateType.SetBattleTag, VectorOffset StandbyConfigsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			INotifyMonsterPlayStandbyTags.AddStandbyConfigs(builder, StandbyConfigsOffset);
			INotifyMonsterPlayStandbyTags.AddNullMask(builder, NullMask);
			INotifyMonsterPlayStandbyTags.AddType(builder, Type);
			return INotifyMonsterPlayStandbyTags.EndINotifyMonsterPlayStandbyTags(builder);
		}

		// Token: 0x0603354E RID: 210254 RVA: 0x006EC48C File Offset: 0x006EA68C
		public static void StartINotifyMonsterPlayStandbyTags(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0603354F RID: 210255 RVA: 0x006EC495 File Offset: 0x006EA695
		public static void AddType(FlatBufferBuilder builder, ESetBattleStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033550 RID: 210256 RVA: 0x006EC4A0 File Offset: 0x006EA6A0
		public static void AddStandbyConfigs(FlatBufferBuilder builder, VectorOffset standbyConfigsOffset)
		{
			builder.AddOffset(1, standbyConfigsOffset.Value, 0);
		}

		// Token: 0x06033551 RID: 210257 RVA: 0x006EC4B0 File Offset: 0x006EA6B0
		public static VectorOffset CreateStandbyConfigsVector(FlatBufferBuilder builder, Offset<IMonsterStandByConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06033552 RID: 210258 RVA: 0x006EC4F0 File Offset: 0x006EA6F0
		public static VectorOffset CreateStandbyConfigsVectorBlock(FlatBufferBuilder builder, Offset<IMonsterStandByConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IMonsterStandByConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06033553 RID: 210259 RVA: 0x006EC50A File Offset: 0x006EA70A
		public static VectorOffset CreateStandbyConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IMonsterStandByConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IMonsterStandByConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06033554 RID: 210260 RVA: 0x006EC528 File Offset: 0x006EA728
		public static VectorOffset CreateStandbyConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IMonsterStandByConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06033555 RID: 210261 RVA: 0x006EC541 File Offset: 0x006EA741
		public static void StartStandbyConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06033556 RID: 210262 RVA: 0x006EC54C File Offset: 0x006EA74C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06033557 RID: 210263 RVA: 0x006EC557 File Offset: 0x006EA757
		public static Offset<INotifyMonsterPlayStandbyTags> EndINotifyMonsterPlayStandbyTags(FlatBufferBuilder builder)
		{
			return new Offset<INotifyMonsterPlayStandbyTags>(builder.EndTable());
		}

		// Token: 0x06033558 RID: 210264 RVA: 0x006EC564 File Offset: 0x006EA764
		public INotifyMonsterPlayStandbyTagsT UnPack()
		{
			INotifyMonsterPlayStandbyTagsT notifyMonsterPlayStandbyTagsT = new INotifyMonsterPlayStandbyTagsT();
			this.UnPackTo(notifyMonsterPlayStandbyTagsT);
			return notifyMonsterPlayStandbyTagsT;
		}

		// Token: 0x06033559 RID: 210265 RVA: 0x006EC580 File Offset: 0x006EA780
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

		// Token: 0x0603355A RID: 210266 RVA: 0x006EC5F8 File Offset: 0x006EA7F8
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

		// Token: 0x040123B4 RID: 74676
		private Table __p;
	}
}
