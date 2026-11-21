using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007783 RID: 30595
	public struct ISetBattleTag : IFlatbufferObject
	{
		// Token: 0x1700E031 RID: 57393
		// (get) Token: 0x06035B34 RID: 219956 RVA: 0x00732259 File Offset: 0x00730459
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035B35 RID: 219957 RVA: 0x00732266 File Offset: 0x00730466
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035B36 RID: 219958 RVA: 0x00732270 File Offset: 0x00730470
		public static ISetBattleTag GetRootAsISetBattleTag(ByteBuffer _bb)
		{
			return ISetBattleTag.GetRootAsISetBattleTag(_bb, default(ISetBattleTag));
		}

		// Token: 0x06035B37 RID: 219959 RVA: 0x0073228C File Offset: 0x0073048C
		public static ISetBattleTag GetRootAsISetBattleTag(ByteBuffer _bb, ISetBattleTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035B38 RID: 219960 RVA: 0x007322A9 File Offset: 0x007304A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035B39 RID: 219961 RVA: 0x007322B8 File Offset: 0x007304B8
		public ISetBattleTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E032 RID: 57394
		// (get) Token: 0x06035B3A RID: 219962 RVA: 0x007322C8 File Offset: 0x007304C8
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

		// Token: 0x06035B3B RID: 219963 RVA: 0x00732304 File Offset: 0x00730504
		public ISetEntityTag? SetTags(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ISetEntityTag?(default(ISetEntityTag).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700E033 RID: 57395
		// (get) Token: 0x06035B3C RID: 219964 RVA: 0x00732364 File Offset: 0x00730564
		public int SetTagsLength
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

		// Token: 0x06035B3D RID: 219965 RVA: 0x0073238F File Offset: 0x0073058F
		public static Offset<ISetBattleTag> CreateISetBattleTag(FlatBufferBuilder builder, ESetBattleStateType Type = ESetBattleStateType.SetBattleTag, VectorOffset SetTagsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ISetBattleTag.AddSetTags(builder, SetTagsOffset);
			ISetBattleTag.AddType(builder, Type);
			return ISetBattleTag.EndISetBattleTag(builder);
		}

		// Token: 0x06035B3E RID: 219966 RVA: 0x007323AC File Offset: 0x007305AC
		public static void StartISetBattleTag(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06035B3F RID: 219967 RVA: 0x007323B5 File Offset: 0x007305B5
		public static void AddType(FlatBufferBuilder builder, ESetBattleStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035B40 RID: 219968 RVA: 0x007323C0 File Offset: 0x007305C0
		public static void AddSetTags(FlatBufferBuilder builder, VectorOffset setTagsOffset)
		{
			builder.AddOffset(1, setTagsOffset.Value, 0);
		}

		// Token: 0x06035B41 RID: 219969 RVA: 0x007323D0 File Offset: 0x007305D0
		public static VectorOffset CreateSetTagsVector(FlatBufferBuilder builder, Offset<ISetEntityTag>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06035B42 RID: 219970 RVA: 0x00732410 File Offset: 0x00730610
		public static VectorOffset CreateSetTagsVectorBlock(FlatBufferBuilder builder, Offset<ISetEntityTag>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISetEntityTag>>(data);
			return builder.EndVector();
		}

		// Token: 0x06035B43 RID: 219971 RVA: 0x0073242A File Offset: 0x0073062A
		public static VectorOffset CreateSetTagsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISetEntityTag>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISetEntityTag>>(data);
			return builder.EndVector();
		}

		// Token: 0x06035B44 RID: 219972 RVA: 0x00732448 File Offset: 0x00730648
		public static VectorOffset CreateSetTagsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISetEntityTag>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06035B45 RID: 219973 RVA: 0x00732461 File Offset: 0x00730661
		public static void StartSetTagsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06035B46 RID: 219974 RVA: 0x0073246C File Offset: 0x0073066C
		public static Offset<ISetBattleTag> EndISetBattleTag(FlatBufferBuilder builder)
		{
			return new Offset<ISetBattleTag>(builder.EndTable());
		}

		// Token: 0x06035B47 RID: 219975 RVA: 0x0073247C File Offset: 0x0073067C
		public ISetBattleTagT UnPack()
		{
			ISetBattleTagT setBattleTagT = new ISetBattleTagT();
			this.UnPackTo(setBattleTagT);
			return setBattleTagT;
		}

		// Token: 0x06035B48 RID: 219976 RVA: 0x00732498 File Offset: 0x00730698
		public void UnPackTo(ISetBattleTagT _o)
		{
			_o.Type = this.Type;
			_o.SetTags = new List<ISetEntityTagT>();
			for (int i = 0; i < this.SetTagsLength; i++)
			{
				_o.SetTags.Add((this.SetTags(i) != null) ? this.SetTags(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06035B49 RID: 219977 RVA: 0x00732504 File Offset: 0x00730704
		public static Offset<ISetBattleTag> Pack(FlatBufferBuilder builder, ISetBattleTagT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetBattleTag>);
			}
			VectorOffset setTagsOffset = default(VectorOffset);
			if (_o.SetTags != null)
			{
				Offset<ISetEntityTag>[] array = new Offset<ISetEntityTag>[_o.SetTags.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ISetEntityTag.Pack(builder, _o.SetTags[i]);
				}
				setTagsOffset = ISetBattleTag.CreateSetTagsVector(builder, array);
			}
			return ISetBattleTag.CreateISetBattleTag(builder, _o.Type, setTagsOffset);
		}

		// Token: 0x040129A4 RID: 76196
		private Table __p;
	}
}
