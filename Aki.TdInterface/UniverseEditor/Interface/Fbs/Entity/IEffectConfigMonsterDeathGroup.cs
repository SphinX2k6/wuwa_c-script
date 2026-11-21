using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004BF5 RID: 19445
	public struct IEffectConfigMonsterDeathGroup : IFlatbufferObject
	{
		// Token: 0x170089A3 RID: 35235
		// (get) Token: 0x0601DB2C RID: 121644 RVA: 0x0042AA54 File Offset: 0x00428C54
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DB2D RID: 121645 RVA: 0x0042AA61 File Offset: 0x00428C61
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DB2E RID: 121646 RVA: 0x0042AA68 File Offset: 0x00428C68
		public static IEffectConfigMonsterDeathGroup GetRootAsIEffectConfigMonsterDeathGroup(ByteBuffer _bb)
		{
			return IEffectConfigMonsterDeathGroup.GetRootAsIEffectConfigMonsterDeathGroup(_bb, default(IEffectConfigMonsterDeathGroup));
		}

		// Token: 0x0601DB2F RID: 121647 RVA: 0x0042AA84 File Offset: 0x00428C84
		public static IEffectConfigMonsterDeathGroup GetRootAsIEffectConfigMonsterDeathGroup(ByteBuffer _bb, IEffectConfigMonsterDeathGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DB30 RID: 121648 RVA: 0x0042AAA1 File Offset: 0x00428CA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DB31 RID: 121649 RVA: 0x0042AAB0 File Offset: 0x00428CB0
		public IEffectConfigMonsterDeathGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170089A4 RID: 35236
		// (get) Token: 0x0601DB32 RID: 121650 RVA: 0x0042AAC0 File Offset: 0x00428CC0
		public EEffectConfigType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEffectConfigType.Death;
				}
				return (EEffectConfigType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601DB33 RID: 121651 RVA: 0x0042AAFC File Offset: 0x00428CFC
		public IMonsterTagDeathEffectData? EffectGroup(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IMonsterTagDeathEffectData?(default(IMonsterTagDeathEffectData).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170089A5 RID: 35237
		// (get) Token: 0x0601DB34 RID: 121652 RVA: 0x0042AB5C File Offset: 0x00428D5C
		public int EffectGroupLength
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

		// Token: 0x0601DB35 RID: 121653 RVA: 0x0042AB87 File Offset: 0x00428D87
		public static Offset<IEffectConfigMonsterDeathGroup> CreateIEffectConfigMonsterDeathGroup(FlatBufferBuilder builder, EEffectConfigType Type = EEffectConfigType.Death, VectorOffset EffectGroupOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IEffectConfigMonsterDeathGroup.AddEffectGroup(builder, EffectGroupOffset);
			IEffectConfigMonsterDeathGroup.AddType(builder, Type);
			return IEffectConfigMonsterDeathGroup.EndIEffectConfigMonsterDeathGroup(builder);
		}

		// Token: 0x0601DB36 RID: 121654 RVA: 0x0042ABA4 File Offset: 0x00428DA4
		public static void StartIEffectConfigMonsterDeathGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601DB37 RID: 121655 RVA: 0x0042ABAD File Offset: 0x00428DAD
		public static void AddType(FlatBufferBuilder builder, EEffectConfigType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601DB38 RID: 121656 RVA: 0x0042ABB8 File Offset: 0x00428DB8
		public static void AddEffectGroup(FlatBufferBuilder builder, VectorOffset effectGroupOffset)
		{
			builder.AddOffset(1, effectGroupOffset.Value, 0);
		}

		// Token: 0x0601DB39 RID: 121657 RVA: 0x0042ABC8 File Offset: 0x00428DC8
		public static VectorOffset CreateEffectGroupVector(FlatBufferBuilder builder, Offset<IMonsterTagDeathEffectData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601DB3A RID: 121658 RVA: 0x0042AC08 File Offset: 0x00428E08
		public static VectorOffset CreateEffectGroupVectorBlock(FlatBufferBuilder builder, Offset<IMonsterTagDeathEffectData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IMonsterTagDeathEffectData>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DB3B RID: 121659 RVA: 0x0042AC22 File Offset: 0x00428E22
		public static VectorOffset CreateEffectGroupVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IMonsterTagDeathEffectData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IMonsterTagDeathEffectData>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DB3C RID: 121660 RVA: 0x0042AC40 File Offset: 0x00428E40
		public static VectorOffset CreateEffectGroupVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IMonsterTagDeathEffectData>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601DB3D RID: 121661 RVA: 0x0042AC59 File Offset: 0x00428E59
		public static void StartEffectGroupVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601DB3E RID: 121662 RVA: 0x0042AC64 File Offset: 0x00428E64
		public static Offset<IEffectConfigMonsterDeathGroup> EndIEffectConfigMonsterDeathGroup(FlatBufferBuilder builder)
		{
			return new Offset<IEffectConfigMonsterDeathGroup>(builder.EndTable());
		}

		// Token: 0x0601DB3F RID: 121663 RVA: 0x0042AC74 File Offset: 0x00428E74
		public IEffectConfigMonsterDeathGroupT UnPack()
		{
			IEffectConfigMonsterDeathGroupT effectConfigMonsterDeathGroupT = new IEffectConfigMonsterDeathGroupT();
			this.UnPackTo(effectConfigMonsterDeathGroupT);
			return effectConfigMonsterDeathGroupT;
		}

		// Token: 0x0601DB40 RID: 121664 RVA: 0x0042AC90 File Offset: 0x00428E90
		public void UnPackTo(IEffectConfigMonsterDeathGroupT _o)
		{
			_o.Type = this.Type;
			_o.EffectGroup = new List<IMonsterTagDeathEffectDataT>();
			for (int i = 0; i < this.EffectGroupLength; i++)
			{
				_o.EffectGroup.Add((this.EffectGroup(i) != null) ? this.EffectGroup(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601DB41 RID: 121665 RVA: 0x0042ACFC File Offset: 0x00428EFC
		public static Offset<IEffectConfigMonsterDeathGroup> Pack(FlatBufferBuilder builder, IEffectConfigMonsterDeathGroupT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEffectConfigMonsterDeathGroup>);
			}
			VectorOffset effectGroupOffset = default(VectorOffset);
			if (_o.EffectGroup != null)
			{
				Offset<IMonsterTagDeathEffectData>[] array = new Offset<IMonsterTagDeathEffectData>[_o.EffectGroup.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IMonsterTagDeathEffectData.Pack(builder, _o.EffectGroup[i]);
				}
				effectGroupOffset = IEffectConfigMonsterDeathGroup.CreateEffectGroupVector(builder, array);
			}
			return IEffectConfigMonsterDeathGroup.CreateIEffectConfigMonsterDeathGroup(builder, _o.Type, effectGroupOffset);
		}

		// Token: 0x0400D62B RID: 54827
		private Table __p;
	}
}
