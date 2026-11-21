using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200644F RID: 25679
	public struct IOutAreaBorderBuffEffect : IFlatbufferObject
	{
		// Token: 0x1700BD98 RID: 48536
		// (get) Token: 0x0602BA38 RID: 178744 RVA: 0x005F0C98 File Offset: 0x005EEE98
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BA39 RID: 178745 RVA: 0x005F0CA5 File Offset: 0x005EEEA5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BA3A RID: 178746 RVA: 0x005F0CAC File Offset: 0x005EEEAC
		public static IOutAreaBorderBuffEffect GetRootAsIOutAreaBorderBuffEffect(ByteBuffer _bb)
		{
			return IOutAreaBorderBuffEffect.GetRootAsIOutAreaBorderBuffEffect(_bb, default(IOutAreaBorderBuffEffect));
		}

		// Token: 0x0602BA3B RID: 178747 RVA: 0x005F0CC8 File Offset: 0x005EEEC8
		public static IOutAreaBorderBuffEffect GetRootAsIOutAreaBorderBuffEffect(ByteBuffer _bb, IOutAreaBorderBuffEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BA3C RID: 178748 RVA: 0x005F0CE5 File Offset: 0x005EEEE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BA3D RID: 178749 RVA: 0x005F0CF4 File Offset: 0x005EEEF4
		public IOutAreaBorderBuffEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BD99 RID: 48537
		// (get) Token: 0x0602BA3E RID: 178750 RVA: 0x005F0D04 File Offset: 0x005EEF04
		public EOutAreaBorderEffectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EOutAreaBorderEffectType.BuffId;
				}
				return (EOutAreaBorderEffectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602BA3F RID: 178751 RVA: 0x005F0D40 File Offset: 0x005EEF40
		public int BuffIdList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700BD9A RID: 48538
		// (get) Token: 0x0602BA40 RID: 178752 RVA: 0x005F0D80 File Offset: 0x005EEF80
		public int BuffIdListLength
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

		// Token: 0x0602BA41 RID: 178753 RVA: 0x005F0DAB File Offset: 0x005EEFAB
		public Span<int> GetBuffIdListBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0602BA42 RID: 178754 RVA: 0x005F0DBA File Offset: 0x005EEFBA
		public int[] GetBuffIdListArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x0602BA43 RID: 178755 RVA: 0x005F0DC8 File Offset: 0x005EEFC8
		public static Offset<IOutAreaBorderBuffEffect> CreateIOutAreaBorderBuffEffect(FlatBufferBuilder builder, EOutAreaBorderEffectType Type = EOutAreaBorderEffectType.BuffId, VectorOffset BuffIdListOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IOutAreaBorderBuffEffect.AddBuffIdList(builder, BuffIdListOffset);
			IOutAreaBorderBuffEffect.AddType(builder, Type);
			return IOutAreaBorderBuffEffect.EndIOutAreaBorderBuffEffect(builder);
		}

		// Token: 0x0602BA44 RID: 178756 RVA: 0x005F0DE5 File Offset: 0x005EEFE5
		public static void StartIOutAreaBorderBuffEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602BA45 RID: 178757 RVA: 0x005F0DEE File Offset: 0x005EEFEE
		public static void AddType(FlatBufferBuilder builder, EOutAreaBorderEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602BA46 RID: 178758 RVA: 0x005F0DF9 File Offset: 0x005EEFF9
		public static void AddBuffIdList(FlatBufferBuilder builder, VectorOffset buffIdListOffset)
		{
			builder.AddOffset(1, buffIdListOffset.Value, 0);
		}

		// Token: 0x0602BA47 RID: 178759 RVA: 0x005F0E0C File Offset: 0x005EF00C
		public static VectorOffset CreateBuffIdListVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602BA48 RID: 178760 RVA: 0x005F0E43 File Offset: 0x005EF043
		public static VectorOffset CreateBuffIdListVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602BA49 RID: 178761 RVA: 0x005F0E5D File Offset: 0x005EF05D
		public static VectorOffset CreateBuffIdListVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602BA4A RID: 178762 RVA: 0x005F0E7B File Offset: 0x005EF07B
		public static VectorOffset CreateBuffIdListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602BA4B RID: 178763 RVA: 0x005F0E94 File Offset: 0x005EF094
		public static void StartBuffIdListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602BA4C RID: 178764 RVA: 0x005F0E9F File Offset: 0x005EF09F
		public static Offset<IOutAreaBorderBuffEffect> EndIOutAreaBorderBuffEffect(FlatBufferBuilder builder)
		{
			return new Offset<IOutAreaBorderBuffEffect>(builder.EndTable());
		}

		// Token: 0x0602BA4D RID: 178765 RVA: 0x005F0EAC File Offset: 0x005EF0AC
		public IOutAreaBorderBuffEffectT UnPack()
		{
			IOutAreaBorderBuffEffectT outAreaBorderBuffEffectT = new IOutAreaBorderBuffEffectT();
			this.UnPackTo(outAreaBorderBuffEffectT);
			return outAreaBorderBuffEffectT;
		}

		// Token: 0x0602BA4E RID: 178766 RVA: 0x005F0EC8 File Offset: 0x005EF0C8
		public void UnPackTo(IOutAreaBorderBuffEffectT _o)
		{
			_o.Type = this.Type;
			_o.BuffIdList = new List<int>();
			for (int i = 0; i < this.BuffIdListLength; i++)
			{
				_o.BuffIdList.Add(this.BuffIdList(i));
			}
		}

		// Token: 0x0602BA4F RID: 178767 RVA: 0x005F0F10 File Offset: 0x005EF110
		public static Offset<IOutAreaBorderBuffEffect> Pack(FlatBufferBuilder builder, IOutAreaBorderBuffEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOutAreaBorderBuffEffect>);
			}
			VectorOffset buffIdListOffset = default(VectorOffset);
			if (_o.BuffIdList != null)
			{
				int[] data = _o.BuffIdList.ToArray();
				buffIdListOffset = IOutAreaBorderBuffEffect.CreateBuffIdListVector(builder, data);
			}
			return IOutAreaBorderBuffEffect.CreateIOutAreaBorderBuffEffect(builder, _o.Type, buffIdListOffset);
		}

		// Token: 0x04010563 RID: 66915
		private Table __p;
	}
}
