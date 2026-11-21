using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004379 RID: 17273
	public struct IMonsterMergedHpBarSettings : IFlatbufferObject
	{
		// Token: 0x17007683 RID: 30339
		// (get) Token: 0x06018669 RID: 99945 RVA: 0x0037AA46 File Offset: 0x00378C46
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601866A RID: 99946 RVA: 0x0037AA53 File Offset: 0x00378C53
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601866B RID: 99947 RVA: 0x0037AA5C File Offset: 0x00378C5C
		public static IMonsterMergedHpBarSettings GetRootAsIMonsterMergedHpBarSettings(ByteBuffer _bb)
		{
			return IMonsterMergedHpBarSettings.GetRootAsIMonsterMergedHpBarSettings(_bb, default(IMonsterMergedHpBarSettings));
		}

		// Token: 0x0601866C RID: 99948 RVA: 0x0037AA78 File Offset: 0x00378C78
		public static IMonsterMergedHpBarSettings GetRootAsIMonsterMergedHpBarSettings(ByteBuffer _bb, IMonsterMergedHpBarSettings obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601866D RID: 99949 RVA: 0x0037AA95 File Offset: 0x00378C95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601866E RID: 99950 RVA: 0x0037AAA4 File Offset: 0x00378CA4
		public IMonsterMergedHpBarSettings __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601866F RID: 99951 RVA: 0x0037AAB4 File Offset: 0x00378CB4
		public long DisplayBuffIds(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x17007684 RID: 30340
		// (get) Token: 0x06018670 RID: 99952 RVA: 0x0037AAF4 File Offset: 0x00378CF4
		public int DisplayBuffIdsLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06018671 RID: 99953 RVA: 0x0037AB1F File Offset: 0x00378D1F
		public Span<long> GetDisplayBuffIdsBytes()
		{
			return this.__p.__vector_as_span<long>(4, 8);
		}

		// Token: 0x06018672 RID: 99954 RVA: 0x0037AB2E File Offset: 0x00378D2E
		public long[] GetDisplayBuffIdsArray()
		{
			return this.__p.__vector_as_array<long>(4);
		}

		// Token: 0x17007685 RID: 30341
		// (get) Token: 0x06018673 RID: 99955 RVA: 0x0037AB3C File Offset: 0x00378D3C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018674 RID: 99956 RVA: 0x0037AB78 File Offset: 0x00378D78
		public static Offset<IMonsterMergedHpBarSettings> CreateIMonsterMergedHpBarSettings(FlatBufferBuilder builder, VectorOffset DisplayBuffIdsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(2);
			IMonsterMergedHpBarSettings.AddDisplayBuffIds(builder, DisplayBuffIdsOffset);
			IMonsterMergedHpBarSettings.AddNullMask(builder, NullMask);
			return IMonsterMergedHpBarSettings.EndIMonsterMergedHpBarSettings(builder);
		}

		// Token: 0x06018675 RID: 99957 RVA: 0x0037AB95 File Offset: 0x00378D95
		public static void StartIMonsterMergedHpBarSettings(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06018676 RID: 99958 RVA: 0x0037AB9E File Offset: 0x00378D9E
		public static void AddDisplayBuffIds(FlatBufferBuilder builder, VectorOffset displayBuffIdsOffset)
		{
			builder.AddOffset(0, displayBuffIdsOffset.Value, 0);
		}

		// Token: 0x06018677 RID: 99959 RVA: 0x0037ABB0 File Offset: 0x00378DB0
		public static VectorOffset CreateDisplayBuffIdsVector(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddLong(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06018678 RID: 99960 RVA: 0x0037ABE7 File Offset: 0x00378DE7
		public static VectorOffset CreateDisplayBuffIdsVectorBlock(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x06018679 RID: 99961 RVA: 0x0037AC01 File Offset: 0x00378E01
		public static VectorOffset CreateDisplayBuffIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data)
		{
			builder.StartVector(8, data.Count, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x0601867A RID: 99962 RVA: 0x0037AC1F File Offset: 0x00378E1F
		public static VectorOffset CreateDisplayBuffIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<long>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601867B RID: 99963 RVA: 0x0037AC38 File Offset: 0x00378E38
		public static void StartDisplayBuffIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(8, numElems, 8);
		}

		// Token: 0x0601867C RID: 99964 RVA: 0x0037AC43 File Offset: 0x00378E43
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x0601867D RID: 99965 RVA: 0x0037AC4E File Offset: 0x00378E4E
		public static Offset<IMonsterMergedHpBarSettings> EndIMonsterMergedHpBarSettings(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterMergedHpBarSettings>(builder.EndTable());
		}

		// Token: 0x0601867E RID: 99966 RVA: 0x0037AC5C File Offset: 0x00378E5C
		public IMonsterMergedHpBarSettingsT UnPack()
		{
			IMonsterMergedHpBarSettingsT monsterMergedHpBarSettingsT = new IMonsterMergedHpBarSettingsT();
			this.UnPackTo(monsterMergedHpBarSettingsT);
			return monsterMergedHpBarSettingsT;
		}

		// Token: 0x0601867F RID: 99967 RVA: 0x0037AC78 File Offset: 0x00378E78
		public void UnPackTo(IMonsterMergedHpBarSettingsT _o)
		{
			_o.DisplayBuffIds = new List<long>();
			for (int i = 0; i < this.DisplayBuffIdsLength; i++)
			{
				_o.DisplayBuffIds.Add(this.DisplayBuffIds(i));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06018680 RID: 99968 RVA: 0x0037ACC0 File Offset: 0x00378EC0
		public static Offset<IMonsterMergedHpBarSettings> Pack(FlatBufferBuilder builder, IMonsterMergedHpBarSettingsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMonsterMergedHpBarSettings>);
			}
			VectorOffset displayBuffIdsOffset = default(VectorOffset);
			if (_o.DisplayBuffIds != null)
			{
				long[] data = _o.DisplayBuffIds.ToArray();
				displayBuffIdsOffset = IMonsterMergedHpBarSettings.CreateDisplayBuffIdsVector(builder, data);
			}
			return IMonsterMergedHpBarSettings.CreateIMonsterMergedHpBarSettings(builder, displayBuffIdsOffset, _o.NullMask);
		}

		// Token: 0x0400C329 RID: 49961
		private Table __p;
	}
}
