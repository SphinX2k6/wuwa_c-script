using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006906 RID: 26886
	public struct IHideSpecifyLevelPlayGroup : IFlatbufferObject
	{
		// Token: 0x1700C774 RID: 51060
		// (get) Token: 0x0602EE91 RID: 192145 RVA: 0x00665E92 File Offset: 0x00664092
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EE92 RID: 192146 RVA: 0x00665E9F File Offset: 0x0066409F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EE93 RID: 192147 RVA: 0x00665EA8 File Offset: 0x006640A8
		public static IHideSpecifyLevelPlayGroup GetRootAsIHideSpecifyLevelPlayGroup(ByteBuffer _bb)
		{
			return IHideSpecifyLevelPlayGroup.GetRootAsIHideSpecifyLevelPlayGroup(_bb, default(IHideSpecifyLevelPlayGroup));
		}

		// Token: 0x0602EE94 RID: 192148 RVA: 0x00665EC4 File Offset: 0x006640C4
		public static IHideSpecifyLevelPlayGroup GetRootAsIHideSpecifyLevelPlayGroup(ByteBuffer _bb, IHideSpecifyLevelPlayGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EE95 RID: 192149 RVA: 0x00665EE1 File Offset: 0x006640E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EE96 RID: 192150 RVA: 0x00665EF0 File Offset: 0x006640F0
		public IHideSpecifyLevelPlayGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C775 RID: 51061
		// (get) Token: 0x0602EE97 RID: 192151 RVA: 0x00665F00 File Offset: 0x00664100
		public EHideType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EHideType.WorldMonsterAndMonsterTreasure;
				}
				return (EHideType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602EE98 RID: 192152 RVA: 0x00665F3C File Offset: 0x0066413C
		public int LevelPlays(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C776 RID: 51062
		// (get) Token: 0x0602EE99 RID: 192153 RVA: 0x00665F7C File Offset: 0x0066417C
		public int LevelPlaysLength
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

		// Token: 0x0602EE9A RID: 192154 RVA: 0x00665FA7 File Offset: 0x006641A7
		public Span<int> GetLevelPlaysBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0602EE9B RID: 192155 RVA: 0x00665FB6 File Offset: 0x006641B6
		public int[] GetLevelPlaysArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x0602EE9C RID: 192156 RVA: 0x00665FC4 File Offset: 0x006641C4
		public static Offset<IHideSpecifyLevelPlayGroup> CreateIHideSpecifyLevelPlayGroup(FlatBufferBuilder builder, EHideType Type = EHideType.WorldMonsterAndMonsterTreasure, VectorOffset LevelPlaysOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IHideSpecifyLevelPlayGroup.AddLevelPlays(builder, LevelPlaysOffset);
			IHideSpecifyLevelPlayGroup.AddType(builder, Type);
			return IHideSpecifyLevelPlayGroup.EndIHideSpecifyLevelPlayGroup(builder);
		}

		// Token: 0x0602EE9D RID: 192157 RVA: 0x00665FE1 File Offset: 0x006641E1
		public static void StartIHideSpecifyLevelPlayGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602EE9E RID: 192158 RVA: 0x00665FEA File Offset: 0x006641EA
		public static void AddType(FlatBufferBuilder builder, EHideType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602EE9F RID: 192159 RVA: 0x00665FF5 File Offset: 0x006641F5
		public static void AddLevelPlays(FlatBufferBuilder builder, VectorOffset levelPlaysOffset)
		{
			builder.AddOffset(1, levelPlaysOffset.Value, 0);
		}

		// Token: 0x0602EEA0 RID: 192160 RVA: 0x00666008 File Offset: 0x00664208
		public static VectorOffset CreateLevelPlaysVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602EEA1 RID: 192161 RVA: 0x0066603F File Offset: 0x0066423F
		public static VectorOffset CreateLevelPlaysVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602EEA2 RID: 192162 RVA: 0x00666059 File Offset: 0x00664259
		public static VectorOffset CreateLevelPlaysVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602EEA3 RID: 192163 RVA: 0x00666077 File Offset: 0x00664277
		public static VectorOffset CreateLevelPlaysVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602EEA4 RID: 192164 RVA: 0x00666090 File Offset: 0x00664290
		public static void StartLevelPlaysVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602EEA5 RID: 192165 RVA: 0x0066609B File Offset: 0x0066429B
		public static Offset<IHideSpecifyLevelPlayGroup> EndIHideSpecifyLevelPlayGroup(FlatBufferBuilder builder)
		{
			return new Offset<IHideSpecifyLevelPlayGroup>(builder.EndTable());
		}

		// Token: 0x0602EEA6 RID: 192166 RVA: 0x006660A8 File Offset: 0x006642A8
		public IHideSpecifyLevelPlayGroupT UnPack()
		{
			IHideSpecifyLevelPlayGroupT hideSpecifyLevelPlayGroupT = new IHideSpecifyLevelPlayGroupT();
			this.UnPackTo(hideSpecifyLevelPlayGroupT);
			return hideSpecifyLevelPlayGroupT;
		}

		// Token: 0x0602EEA7 RID: 192167 RVA: 0x006660C4 File Offset: 0x006642C4
		public void UnPackTo(IHideSpecifyLevelPlayGroupT _o)
		{
			_o.Type = this.Type;
			_o.LevelPlays = new List<int>();
			for (int i = 0; i < this.LevelPlaysLength; i++)
			{
				_o.LevelPlays.Add(this.LevelPlays(i));
			}
		}

		// Token: 0x0602EEA8 RID: 192168 RVA: 0x0066610C File Offset: 0x0066430C
		public static Offset<IHideSpecifyLevelPlayGroup> Pack(FlatBufferBuilder builder, IHideSpecifyLevelPlayGroupT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHideSpecifyLevelPlayGroup>);
			}
			VectorOffset levelPlaysOffset = default(VectorOffset);
			if (_o.LevelPlays != null)
			{
				int[] data = _o.LevelPlays.ToArray();
				levelPlaysOffset = IHideSpecifyLevelPlayGroup.CreateLevelPlaysVector(builder, data);
			}
			return IHideSpecifyLevelPlayGroup.CreateIHideSpecifyLevelPlayGroup(builder, _o.Type, levelPlaysOffset);
		}

		// Token: 0x0401107B RID: 69755
		private Table __p;
	}
}
