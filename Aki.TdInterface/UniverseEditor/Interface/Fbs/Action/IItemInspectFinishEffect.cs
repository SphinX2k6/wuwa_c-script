using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069C6 RID: 27078
	public struct IItemInspectFinishEffect : IFlatbufferObject
	{
		// Token: 0x1700C8D5 RID: 51413
		// (get) Token: 0x0602F501 RID: 193793 RVA: 0x00671640 File Offset: 0x0066F840
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F502 RID: 193794 RVA: 0x0067164D File Offset: 0x0066F84D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F503 RID: 193795 RVA: 0x00671654 File Offset: 0x0066F854
		public static IItemInspectFinishEffect GetRootAsIItemInspectFinishEffect(ByteBuffer _bb)
		{
			return IItemInspectFinishEffect.GetRootAsIItemInspectFinishEffect(_bb, default(IItemInspectFinishEffect));
		}

		// Token: 0x0602F504 RID: 193796 RVA: 0x00671670 File Offset: 0x0066F870
		public static IItemInspectFinishEffect GetRootAsIItemInspectFinishEffect(ByteBuffer _bb, IItemInspectFinishEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F505 RID: 193797 RVA: 0x0067168D File Offset: 0x0066F88D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F506 RID: 193798 RVA: 0x0067169C File Offset: 0x0066F89C
		public IItemInspectFinishEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602F507 RID: 193799 RVA: 0x006716AC File Offset: 0x0066F8AC
		public TInteractEffect EffectListType(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return TInteractEffect.NONE;
			}
			return (TInteractEffect)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700C8D6 RID: 51414
		// (get) Token: 0x0602F508 RID: 193800 RVA: 0x006716EC File Offset: 0x0066F8EC
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

		// Token: 0x0602F509 RID: 193801 RVA: 0x00671717 File Offset: 0x0066F917
		public Span<TInteractEffect> GetEffectListTypeBytes()
		{
			return this.__p.__vector_as_span<TInteractEffect>(4, 1);
		}

		// Token: 0x0602F50A RID: 193802 RVA: 0x00671728 File Offset: 0x0066F928
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

		// Token: 0x0602F50B RID: 193803 RVA: 0x00671794 File Offset: 0x0066F994
		public TTable? EffectList<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700C8D7 RID: 51415
		// (get) Token: 0x0602F50C RID: 193804 RVA: 0x006717DC File Offset: 0x0066F9DC
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

		// Token: 0x1700C8D8 RID: 51416
		// (get) Token: 0x0602F50D RID: 193805 RVA: 0x00671808 File Offset: 0x0066FA08
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

		// Token: 0x1700C8D9 RID: 51417
		// (get) Token: 0x0602F50E RID: 193806 RVA: 0x00671848 File Offset: 0x0066FA48
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

		// Token: 0x0602F50F RID: 193807 RVA: 0x00671885 File Offset: 0x0066FA85
		public static Offset<IItemInspectFinishEffect> CreateIItemInspectFinishEffect(FlatBufferBuilder builder, VectorOffset EffectList_typeOffset = default(VectorOffset), VectorOffset EffectListOffset = default(VectorOffset), float ProtectTime = 0f, byte NullMask = 0)
		{
			builder.StartTable(4);
			IItemInspectFinishEffect.AddProtectTime(builder, ProtectTime);
			IItemInspectFinishEffect.AddEffectList(builder, EffectListOffset);
			IItemInspectFinishEffect.AddEffectListType(builder, EffectList_typeOffset);
			IItemInspectFinishEffect.AddNullMask(builder, NullMask);
			return IItemInspectFinishEffect.EndIItemInspectFinishEffect(builder);
		}

		// Token: 0x0602F510 RID: 193808 RVA: 0x006718B1 File Offset: 0x0066FAB1
		public static void StartIItemInspectFinishEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602F511 RID: 193809 RVA: 0x006718BA File Offset: 0x0066FABA
		public static void AddEffectListType(FlatBufferBuilder builder, VectorOffset effectListTypeOffset)
		{
			builder.AddOffset(0, effectListTypeOffset.Value, 0);
		}

		// Token: 0x0602F512 RID: 193810 RVA: 0x006718CC File Offset: 0x0066FACC
		public static VectorOffset CreateEffectListTypeVector(FlatBufferBuilder builder, TInteractEffect[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602F513 RID: 193811 RVA: 0x00671903 File Offset: 0x0066FB03
		public static VectorOffset CreateEffectListTypeVectorBlock(FlatBufferBuilder builder, TInteractEffect[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TInteractEffect>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F514 RID: 193812 RVA: 0x0067191D File Offset: 0x0066FB1D
		public static VectorOffset CreateEffectListTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TInteractEffect> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TInteractEffect>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F515 RID: 193813 RVA: 0x0067193B File Offset: 0x0066FB3B
		public static VectorOffset CreateEffectListTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TInteractEffect>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602F516 RID: 193814 RVA: 0x00671954 File Offset: 0x0066FB54
		public static void StartEffectListTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0602F517 RID: 193815 RVA: 0x0067195F File Offset: 0x0066FB5F
		public static void AddEffectList(FlatBufferBuilder builder, VectorOffset effectListOffset)
		{
			builder.AddOffset(1, effectListOffset.Value, 0);
		}

		// Token: 0x0602F518 RID: 193816 RVA: 0x00671970 File Offset: 0x0066FB70
		public static VectorOffset CreateEffectListVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602F519 RID: 193817 RVA: 0x006719A7 File Offset: 0x0066FBA7
		public static VectorOffset CreateEffectListVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F51A RID: 193818 RVA: 0x006719C1 File Offset: 0x0066FBC1
		public static VectorOffset CreateEffectListVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F51B RID: 193819 RVA: 0x006719DF File Offset: 0x0066FBDF
		public static VectorOffset CreateEffectListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602F51C RID: 193820 RVA: 0x006719F8 File Offset: 0x0066FBF8
		public static void StartEffectListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602F51D RID: 193821 RVA: 0x00671A03 File Offset: 0x0066FC03
		public static void AddProtectTime(FlatBufferBuilder builder, float protectTime)
		{
			builder.AddFloat(2, protectTime, 0.0);
		}

		// Token: 0x0602F51E RID: 193822 RVA: 0x00671A16 File Offset: 0x0066FC16
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602F51F RID: 193823 RVA: 0x00671A21 File Offset: 0x0066FC21
		public static Offset<IItemInspectFinishEffect> EndIItemInspectFinishEffect(FlatBufferBuilder builder)
		{
			return new Offset<IItemInspectFinishEffect>(builder.EndTable());
		}

		// Token: 0x0602F520 RID: 193824 RVA: 0x00671A30 File Offset: 0x0066FC30
		public IItemInspectFinishEffectT UnPack()
		{
			IItemInspectFinishEffectT itemInspectFinishEffectT = new IItemInspectFinishEffectT();
			this.UnPackTo(itemInspectFinishEffectT);
			return itemInspectFinishEffectT;
		}

		// Token: 0x0602F521 RID: 193825 RVA: 0x00671A4C File Offset: 0x0066FC4C
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

		// Token: 0x0602F522 RID: 193826 RVA: 0x00671BB0 File Offset: 0x0066FDB0
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

		// Token: 0x04011177 RID: 70007
		private Table __p;
	}
}
