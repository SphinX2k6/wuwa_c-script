using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007076 RID: 28790
	public struct IItemInspectFinishEffect : IFlatbufferObject
	{
		// Token: 0x1700D2D5 RID: 53973
		// (get) Token: 0x06031EC1 RID: 204481 RVA: 0x006C1998 File Offset: 0x006BFB98
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031EC2 RID: 204482 RVA: 0x006C19A5 File Offset: 0x006BFBA5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031EC3 RID: 204483 RVA: 0x006C19AC File Offset: 0x006BFBAC
		public static IItemInspectFinishEffect GetRootAsIItemInspectFinishEffect(ByteBuffer _bb)
		{
			return IItemInspectFinishEffect.GetRootAsIItemInspectFinishEffect(_bb, default(IItemInspectFinishEffect));
		}

		// Token: 0x06031EC4 RID: 204484 RVA: 0x006C19C8 File Offset: 0x006BFBC8
		public static IItemInspectFinishEffect GetRootAsIItemInspectFinishEffect(ByteBuffer _bb, IItemInspectFinishEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031EC5 RID: 204485 RVA: 0x006C19E5 File Offset: 0x006BFBE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031EC6 RID: 204486 RVA: 0x006C19F4 File Offset: 0x006BFBF4
		public IItemInspectFinishEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06031EC7 RID: 204487 RVA: 0x006C1A04 File Offset: 0x006BFC04
		public TInteractEffect EffectListType(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return TInteractEffect.NONE;
			}
			return (TInteractEffect)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700D2D6 RID: 53974
		// (get) Token: 0x06031EC8 RID: 204488 RVA: 0x006C1A44 File Offset: 0x006BFC44
		public int EffectListTypeLength
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

		// Token: 0x06031EC9 RID: 204489 RVA: 0x006C1A6F File Offset: 0x006BFC6F
		public Span<TInteractEffect> GetEffectListTypeBytes()
		{
			return this.__p.__vector_as_span<TInteractEffect>(4, 1);
		}

		// Token: 0x06031ECA RID: 204490 RVA: 0x006C1A80 File Offset: 0x006BFC80
		public TInteractEffect[] GetEffectListTypeArray()
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TInteractEffect[] array = new TInteractEffect[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TInteractEffect)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x06031ECB RID: 204491 RVA: 0x006C1AEC File Offset: 0x006BFCEC
		public TTable? EffectList<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700D2D7 RID: 53975
		// (get) Token: 0x06031ECC RID: 204492 RVA: 0x006C1B34 File Offset: 0x006BFD34
		public int EffectListLength
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

		// Token: 0x1700D2D8 RID: 53976
		// (get) Token: 0x06031ECD RID: 204493 RVA: 0x006C1B60 File Offset: 0x006BFD60
		public float ProtectTime
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

		// Token: 0x1700D2D9 RID: 53977
		// (get) Token: 0x06031ECE RID: 204494 RVA: 0x006C1BA0 File Offset: 0x006BFDA0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031ECF RID: 204495 RVA: 0x006C1BDD File Offset: 0x006BFDDD
		public static Offset<IItemInspectFinishEffect> CreateIItemInspectFinishEffect(FlatBufferBuilder builder, VectorOffset EffectList_typeOffset = default(VectorOffset), VectorOffset EffectListOffset = default(VectorOffset), float ProtectTime = 0f, byte NullMask = 0)
		{
			builder.StartTable(4);
			IItemInspectFinishEffect.AddProtectTime(builder, ProtectTime);
			IItemInspectFinishEffect.AddEffectList(builder, EffectListOffset);
			IItemInspectFinishEffect.AddEffectListType(builder, EffectList_typeOffset);
			IItemInspectFinishEffect.AddNullMask(builder, NullMask);
			return IItemInspectFinishEffect.EndIItemInspectFinishEffect(builder);
		}

		// Token: 0x06031ED0 RID: 204496 RVA: 0x006C1C09 File Offset: 0x006BFE09
		public static void StartIItemInspectFinishEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06031ED1 RID: 204497 RVA: 0x006C1C12 File Offset: 0x006BFE12
		public static void AddEffectListType(FlatBufferBuilder builder, VectorOffset effectListTypeOffset)
		{
			builder.AddOffset(0, effectListTypeOffset.Value, 0);
		}

		// Token: 0x06031ED2 RID: 204498 RVA: 0x006C1C24 File Offset: 0x006BFE24
		public static VectorOffset CreateEffectListTypeVector(FlatBufferBuilder builder, TInteractEffect[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06031ED3 RID: 204499 RVA: 0x006C1C5B File Offset: 0x006BFE5B
		public static VectorOffset CreateEffectListTypeVectorBlock(FlatBufferBuilder builder, TInteractEffect[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TInteractEffect>(data);
			return builder.EndVector();
		}

		// Token: 0x06031ED4 RID: 204500 RVA: 0x006C1C75 File Offset: 0x006BFE75
		public static VectorOffset CreateEffectListTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TInteractEffect> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TInteractEffect>(data);
			return builder.EndVector();
		}

		// Token: 0x06031ED5 RID: 204501 RVA: 0x006C1C93 File Offset: 0x006BFE93
		public static VectorOffset CreateEffectListTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TInteractEffect>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06031ED6 RID: 204502 RVA: 0x006C1CAC File Offset: 0x006BFEAC
		public static void StartEffectListTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06031ED7 RID: 204503 RVA: 0x006C1CB7 File Offset: 0x006BFEB7
		public static void AddEffectList(FlatBufferBuilder builder, VectorOffset effectListOffset)
		{
			builder.AddOffset(1, effectListOffset.Value, 0);
		}

		// Token: 0x06031ED8 RID: 204504 RVA: 0x006C1CC8 File Offset: 0x006BFEC8
		public static VectorOffset CreateEffectListVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06031ED9 RID: 204505 RVA: 0x006C1CFF File Offset: 0x006BFEFF
		public static VectorOffset CreateEffectListVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06031EDA RID: 204506 RVA: 0x006C1D19 File Offset: 0x006BFF19
		public static VectorOffset CreateEffectListVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06031EDB RID: 204507 RVA: 0x006C1D37 File Offset: 0x006BFF37
		public static VectorOffset CreateEffectListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06031EDC RID: 204508 RVA: 0x006C1D50 File Offset: 0x006BFF50
		public static void StartEffectListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06031EDD RID: 204509 RVA: 0x006C1D5B File Offset: 0x006BFF5B
		public static void AddProtectTime(FlatBufferBuilder builder, float protectTime)
		{
			builder.AddFloat(2, protectTime, 0.0);
		}

		// Token: 0x06031EDE RID: 204510 RVA: 0x006C1D6E File Offset: 0x006BFF6E
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06031EDF RID: 204511 RVA: 0x006C1D79 File Offset: 0x006BFF79
		public static Offset<IItemInspectFinishEffect> EndIItemInspectFinishEffect(FlatBufferBuilder builder)
		{
			return new Offset<IItemInspectFinishEffect>(builder.EndTable());
		}

		// Token: 0x06031EE0 RID: 204512 RVA: 0x006C1D88 File Offset: 0x006BFF88
		public IItemInspectFinishEffectT UnPack()
		{
			IItemInspectFinishEffectT itemInspectFinishEffectT = new IItemInspectFinishEffectT();
			this.UnPackTo(itemInspectFinishEffectT);
			return itemInspectFinishEffectT;
		}

		// Token: 0x06031EE1 RID: 204513 RVA: 0x006C1DA4 File Offset: 0x006BFFA4
		public void UnPackTo(IItemInspectFinishEffectT _o)
		{
			_o.EffectList = new List<TInteractEffectUnion>();
			for (int i = 0; i < this.EffectListLength; i++)
			{
				TInteractEffectUnion tinteractEffectUnion = new TInteractEffectUnion();
				tinteractEffectUnion.Type = this.EffectListType(i);
				switch (this.EffectListType(i))
				{
				case TInteractEffect.IExecuteTag:
					tinteractEffectUnion.Value = ((this.EffectList<IExecuteTag>(i) != null) ? this.EffectList<IExecuteTag>(i).Value.UnPack() : null);
					break;
				case TInteractEffect.IModifyTipText:
					tinteractEffectUnion.Value = ((this.EffectList<IModifyTipText>(i) != null) ? this.EffectList<IModifyTipText>(i).Value.UnPack() : null);
					break;
				case TInteractEffect.ITriggerDialogues:
					tinteractEffectUnion.Value = ((this.EffectList<ITriggerDialogues>(i) != null) ? this.EffectList<ITriggerDialogues>(i).Value.UnPack() : null);
					break;
				case TInteractEffect.ITriggerVoiceDialogues:
					tinteractEffectUnion.Value = ((this.EffectList<ITriggerVoiceDialogues>(i) != null) ? this.EffectList<ITriggerVoiceDialogues>(i).Value.UnPack() : null);
					break;
				}
				_o.EffectList.Add(tinteractEffectUnion);
			}
			_o.ProtectTime = this.ProtectTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06031EE2 RID: 204514 RVA: 0x006C1F08 File Offset: 0x006C0108
		public static Offset<IItemInspectFinishEffect> Pack(FlatBufferBuilder builder, IItemInspectFinishEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IItemInspectFinishEffect>);
			}
			VectorOffset effectList_typeOffset = default(VectorOffset);
			if (_o.EffectList != null)
			{
				TInteractEffect[] array = new TInteractEffect[_o.EffectList.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.EffectList[i].Type;
				}
				effectList_typeOffset = IItemInspectFinishEffect.CreateEffectListTypeVector(builder, array);
			}
			VectorOffset effectListOffset = default(VectorOffset);
			if (_o.EffectList != null)
			{
				int[] array2 = new int[_o.EffectList.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TInteractEffectUnion.Pack(builder, _o.EffectList[j]);
				}
				effectListOffset = IItemInspectFinishEffect.CreateEffectListVector(builder, array2);
			}
			return IItemInspectFinishEffect.CreateIItemInspectFinishEffect(builder, effectList_typeOffset, effectListOffset, _o.ProtectTime, _o.NullMask);
		}

		// Token: 0x04011FE1 RID: 73697
		private Table __p;
	}
}
