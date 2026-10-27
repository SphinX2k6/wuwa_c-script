using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x0200478D RID: 18317
	public struct IEffectConfigMonsterDeathGroup : IFlatbufferObject
	{
		// Token: 0x17008362 RID: 33634
		// (get) Token: 0x0601C357 RID: 115543 RVA: 0x003FE7B8 File Offset: 0x003FC9B8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C358 RID: 115544 RVA: 0x003FE7C5 File Offset: 0x003FC9C5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C359 RID: 115545 RVA: 0x003FE7CC File Offset: 0x003FC9CC
		public static IEffectConfigMonsterDeathGroup GetRootAsIEffectConfigMonsterDeathGroup(ByteBuffer _bb)
		{
			return IEffectConfigMonsterDeathGroup.GetRootAsIEffectConfigMonsterDeathGroup(_bb, default(IEffectConfigMonsterDeathGroup));
		}

		// Token: 0x0601C35A RID: 115546 RVA: 0x003FE7E8 File Offset: 0x003FC9E8
		public static IEffectConfigMonsterDeathGroup GetRootAsIEffectConfigMonsterDeathGroup(ByteBuffer _bb, IEffectConfigMonsterDeathGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C35B RID: 115547 RVA: 0x003FE805 File Offset: 0x003FCA05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C35C RID: 115548 RVA: 0x003FE814 File Offset: 0x003FCA14
		public IEffectConfigMonsterDeathGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008363 RID: 33635
		// (get) Token: 0x0601C35D RID: 115549 RVA: 0x003FE824 File Offset: 0x003FCA24
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

		// Token: 0x0601C35E RID: 115550 RVA: 0x003FE860 File Offset: 0x003FCA60
		public IMonsterTagDeathEffectData? EffectGroup(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IMonsterTagDeathEffectData?(default(IMonsterTagDeathEffectData).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008364 RID: 33636
		// (get) Token: 0x0601C35F RID: 115551 RVA: 0x003FE8C0 File Offset: 0x003FCAC0
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

		// Token: 0x0601C360 RID: 115552 RVA: 0x003FE8EB File Offset: 0x003FCAEB
		public static Offset<IEffectConfigMonsterDeathGroup> CreateIEffectConfigMonsterDeathGroup(FlatBufferBuilder builder, EEffectConfigType Type = EEffectConfigType.Death, VectorOffset EffectGroupOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IEffectConfigMonsterDeathGroup.AddEffectGroup(builder, EffectGroupOffset);
			IEffectConfigMonsterDeathGroup.AddType(builder, Type);
			return IEffectConfigMonsterDeathGroup.EndIEffectConfigMonsterDeathGroup(builder);
		}

		// Token: 0x0601C361 RID: 115553 RVA: 0x003FE908 File Offset: 0x003FCB08
		public static void StartIEffectConfigMonsterDeathGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601C362 RID: 115554 RVA: 0x003FE911 File Offset: 0x003FCB11
		public static void AddType(FlatBufferBuilder builder, EEffectConfigType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601C363 RID: 115555 RVA: 0x003FE91C File Offset: 0x003FCB1C
		public static void AddEffectGroup(FlatBufferBuilder builder, VectorOffset effectGroupOffset)
		{
			builder.AddOffset(1, effectGroupOffset.Value, 0);
		}

		// Token: 0x0601C364 RID: 115556 RVA: 0x003FE92C File Offset: 0x003FCB2C
		public static VectorOffset CreateEffectGroupVector(FlatBufferBuilder builder, Offset<IMonsterTagDeathEffectData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C365 RID: 115557 RVA: 0x003FE96C File Offset: 0x003FCB6C
		public static VectorOffset CreateEffectGroupVectorBlock(FlatBufferBuilder builder, Offset<IMonsterTagDeathEffectData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IMonsterTagDeathEffectData>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C366 RID: 115558 RVA: 0x003FE986 File Offset: 0x003FCB86
		public static VectorOffset CreateEffectGroupVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IMonsterTagDeathEffectData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IMonsterTagDeathEffectData>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C367 RID: 115559 RVA: 0x003FE9A4 File Offset: 0x003FCBA4
		public static VectorOffset CreateEffectGroupVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IMonsterTagDeathEffectData>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C368 RID: 115560 RVA: 0x003FE9BD File Offset: 0x003FCBBD
		public static void StartEffectGroupVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C369 RID: 115561 RVA: 0x003FE9C8 File Offset: 0x003FCBC8
		public static Offset<IEffectConfigMonsterDeathGroup> EndIEffectConfigMonsterDeathGroup(FlatBufferBuilder builder)
		{
			return new Offset<IEffectConfigMonsterDeathGroup>(builder.EndTable());
		}

		// Token: 0x0601C36A RID: 115562 RVA: 0x003FE9D8 File Offset: 0x003FCBD8
		public IEffectConfigMonsterDeathGroupT UnPack()
		{
			IEffectConfigMonsterDeathGroupT effectConfigMonsterDeathGroupT = new IEffectConfigMonsterDeathGroupT();
			this.UnPackTo(effectConfigMonsterDeathGroupT);
			return effectConfigMonsterDeathGroupT;
		}

		// Token: 0x0601C36B RID: 115563 RVA: 0x003FE9F4 File Offset: 0x003FCBF4
		public void UnPackTo(IEffectConfigMonsterDeathGroupT _o)
		{
			_o.Type = this.Type;
			_o.EffectGroup = new List<IMonsterTagDeathEffectDataT>();
			for (int i = 0; i < this.EffectGroupLength; i++)
			{
				_o.EffectGroup.Add((this.EffectGroup(i) != null) ? this.EffectGroup(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601C36C RID: 115564 RVA: 0x003FEA60 File Offset: 0x003FCC60
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

		// Token: 0x0400CBF5 RID: 52213
		private Table __p;
	}
}
