using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F3B RID: 16187
	public struct IMonsterMergedHpBarSettings : IFlatbufferObject
	{
		// Token: 0x17007092 RID: 28818
		// (get) Token: 0x06017007 RID: 94215 RVA: 0x003515D2 File Offset: 0x0034F7D2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017008 RID: 94216 RVA: 0x003515DF File Offset: 0x0034F7DF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017009 RID: 94217 RVA: 0x003515E8 File Offset: 0x0034F7E8
		public static IMonsterMergedHpBarSettings GetRootAsIMonsterMergedHpBarSettings(ByteBuffer _bb)
		{
			return IMonsterMergedHpBarSettings.GetRootAsIMonsterMergedHpBarSettings(_bb, default(IMonsterMergedHpBarSettings));
		}

		// Token: 0x0601700A RID: 94218 RVA: 0x00351604 File Offset: 0x0034F804
		public static IMonsterMergedHpBarSettings GetRootAsIMonsterMergedHpBarSettings(ByteBuffer _bb, IMonsterMergedHpBarSettings obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601700B RID: 94219 RVA: 0x00351621 File Offset: 0x0034F821
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601700C RID: 94220 RVA: 0x00351630 File Offset: 0x0034F830
		public IMonsterMergedHpBarSettings __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601700D RID: 94221 RVA: 0x00351640 File Offset: 0x0034F840
		public long DisplayBuffIds(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x17007093 RID: 28819
		// (get) Token: 0x0601700E RID: 94222 RVA: 0x00351680 File Offset: 0x0034F880
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

		// Token: 0x0601700F RID: 94223 RVA: 0x003516AB File Offset: 0x0034F8AB
		public Span<long> GetDisplayBuffIdsBytes()
		{
			return this.__p.__vector_as_span<long>(4, 8);
		}

		// Token: 0x06017010 RID: 94224 RVA: 0x003516BA File Offset: 0x0034F8BA
		public long[] GetDisplayBuffIdsArray()
		{
			return this.__p.__vector_as_array<long>(4);
		}

		// Token: 0x17007094 RID: 28820
		// (get) Token: 0x06017011 RID: 94225 RVA: 0x003516C8 File Offset: 0x0034F8C8
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

		// Token: 0x06017012 RID: 94226 RVA: 0x00351704 File Offset: 0x0034F904
		public static Offset<IMonsterMergedHpBarSettings> CreateIMonsterMergedHpBarSettings(FlatBufferBuilder builder, VectorOffset DisplayBuffIdsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(2);
			IMonsterMergedHpBarSettings.AddDisplayBuffIds(builder, DisplayBuffIdsOffset);
			IMonsterMergedHpBarSettings.AddNullMask(builder, NullMask);
			return IMonsterMergedHpBarSettings.EndIMonsterMergedHpBarSettings(builder);
		}

		// Token: 0x06017013 RID: 94227 RVA: 0x00351721 File Offset: 0x0034F921
		public static void StartIMonsterMergedHpBarSettings(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06017014 RID: 94228 RVA: 0x0035172A File Offset: 0x0034F92A
		public static void AddDisplayBuffIds(FlatBufferBuilder builder, VectorOffset displayBuffIdsOffset)
		{
			builder.AddOffset(0, displayBuffIdsOffset.Value, 0);
		}

		// Token: 0x06017015 RID: 94229 RVA: 0x0035173C File Offset: 0x0034F93C
		public static VectorOffset CreateDisplayBuffIdsVector(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddLong(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06017016 RID: 94230 RVA: 0x00351773 File Offset: 0x0034F973
		public static VectorOffset CreateDisplayBuffIdsVectorBlock(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x06017017 RID: 94231 RVA: 0x0035178D File Offset: 0x0034F98D
		public static VectorOffset CreateDisplayBuffIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data)
		{
			builder.StartVector(8, data.Count, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x06017018 RID: 94232 RVA: 0x003517AB File Offset: 0x0034F9AB
		public static VectorOffset CreateDisplayBuffIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<long>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017019 RID: 94233 RVA: 0x003517C4 File Offset: 0x0034F9C4
		public static void StartDisplayBuffIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(8, numElems, 8);
		}

		// Token: 0x0601701A RID: 94234 RVA: 0x003517CF File Offset: 0x0034F9CF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x0601701B RID: 94235 RVA: 0x003517DA File Offset: 0x0034F9DA
		public static Offset<IMonsterMergedHpBarSettings> EndIMonsterMergedHpBarSettings(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterMergedHpBarSettings>(builder.EndTable());
		}

		// Token: 0x0601701C RID: 94236 RVA: 0x003517E8 File Offset: 0x0034F9E8
		public IMonsterMergedHpBarSettingsT UnPack()
		{
			IMonsterMergedHpBarSettingsT monsterMergedHpBarSettingsT = new IMonsterMergedHpBarSettingsT();
			this.UnPackTo(monsterMergedHpBarSettingsT);
			return monsterMergedHpBarSettingsT;
		}

		// Token: 0x0601701D RID: 94237 RVA: 0x00351804 File Offset: 0x0034FA04
		public void UnPackTo(IMonsterMergedHpBarSettingsT _o)
		{
			_o.DisplayBuffIds = new List<long>();
			for (int i = 0; i < this.DisplayBuffIdsLength; i++)
			{
				_o.DisplayBuffIds.Add(this.DisplayBuffIds(i));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601701E RID: 94238 RVA: 0x0035184C File Offset: 0x0034FA4C
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

		// Token: 0x0400B94B RID: 47435
		private Table __p;
	}
}
