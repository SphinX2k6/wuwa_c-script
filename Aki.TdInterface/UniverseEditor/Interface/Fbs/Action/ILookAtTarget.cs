using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007181 RID: 29057
	public struct ILookAtTarget : IFlatbufferObject
	{
		// Token: 0x1700D4AF RID: 54447
		// (get) Token: 0x0603281C RID: 206876 RVA: 0x006D3648 File Offset: 0x006D1848
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603281D RID: 206877 RVA: 0x006D3655 File Offset: 0x006D1855
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603281E RID: 206878 RVA: 0x006D365C File Offset: 0x006D185C
		public static ILookAtTarget GetRootAsILookAtTarget(ByteBuffer _bb)
		{
			return ILookAtTarget.GetRootAsILookAtTarget(_bb, default(ILookAtTarget));
		}

		// Token: 0x0603281F RID: 206879 RVA: 0x006D3678 File Offset: 0x006D1878
		public static ILookAtTarget GetRootAsILookAtTarget(ByteBuffer _bb, ILookAtTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032820 RID: 206880 RVA: 0x006D3695 File Offset: 0x006D1895
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032821 RID: 206881 RVA: 0x006D36A4 File Offset: 0x006D18A4
		public ILookAtTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D4B0 RID: 54448
		// (get) Token: 0x06032822 RID: 206882 RVA: 0x006D36B4 File Offset: 0x006D18B4
		public EDefaultLookAtType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDefaultLookAtType.LookAtBubbleEntity;
				}
				return (EDefaultLookAtType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032823 RID: 206883 RVA: 0x006D36F0 File Offset: 0x006D18F0
		public INpcLookAtConfig? LookAtConfigs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new INpcLookAtConfig?(default(INpcLookAtConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700D4B1 RID: 54449
		// (get) Token: 0x06032824 RID: 206884 RVA: 0x006D3750 File Offset: 0x006D1950
		public int LookAtConfigsLength
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

		// Token: 0x06032825 RID: 206885 RVA: 0x006D377B File Offset: 0x006D197B
		public static Offset<ILookAtTarget> CreateILookAtTarget(FlatBufferBuilder builder, EDefaultLookAtType Type = EDefaultLookAtType.LookAtBubbleEntity, VectorOffset LookAtConfigsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ILookAtTarget.AddLookAtConfigs(builder, LookAtConfigsOffset);
			ILookAtTarget.AddType(builder, Type);
			return ILookAtTarget.EndILookAtTarget(builder);
		}

		// Token: 0x06032826 RID: 206886 RVA: 0x006D3798 File Offset: 0x006D1998
		public static void StartILookAtTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06032827 RID: 206887 RVA: 0x006D37A1 File Offset: 0x006D19A1
		public static void AddType(FlatBufferBuilder builder, EDefaultLookAtType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032828 RID: 206888 RVA: 0x006D37AC File Offset: 0x006D19AC
		public static void AddLookAtConfigs(FlatBufferBuilder builder, VectorOffset lookAtConfigsOffset)
		{
			builder.AddOffset(1, lookAtConfigsOffset.Value, 0);
		}

		// Token: 0x06032829 RID: 206889 RVA: 0x006D37BC File Offset: 0x006D19BC
		public static VectorOffset CreateLookAtConfigsVector(FlatBufferBuilder builder, Offset<INpcLookAtConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0603282A RID: 206890 RVA: 0x006D37FC File Offset: 0x006D19FC
		public static VectorOffset CreateLookAtConfigsVectorBlock(FlatBufferBuilder builder, Offset<INpcLookAtConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<INpcLookAtConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603282B RID: 206891 RVA: 0x006D3816 File Offset: 0x006D1A16
		public static VectorOffset CreateLookAtConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<INpcLookAtConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<INpcLookAtConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603282C RID: 206892 RVA: 0x006D3834 File Offset: 0x006D1A34
		public static VectorOffset CreateLookAtConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<INpcLookAtConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603282D RID: 206893 RVA: 0x006D384D File Offset: 0x006D1A4D
		public static void StartLookAtConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0603282E RID: 206894 RVA: 0x006D3858 File Offset: 0x006D1A58
		public static Offset<ILookAtTarget> EndILookAtTarget(FlatBufferBuilder builder)
		{
			return new Offset<ILookAtTarget>(builder.EndTable());
		}

		// Token: 0x0603282F RID: 206895 RVA: 0x006D3868 File Offset: 0x006D1A68
		public ILookAtTargetT UnPack()
		{
			ILookAtTargetT lookAtTargetT = new ILookAtTargetT();
			this.UnPackTo(lookAtTargetT);
			return lookAtTargetT;
		}

		// Token: 0x06032830 RID: 206896 RVA: 0x006D3884 File Offset: 0x006D1A84
		public void UnPackTo(ILookAtTargetT _o)
		{
			_o.Type = this.Type;
			_o.LookAtConfigs = new List<INpcLookAtConfigT>();
			for (int i = 0; i < this.LookAtConfigsLength; i++)
			{
				_o.LookAtConfigs.Add((this.LookAtConfigs(i) != null) ? this.LookAtConfigs(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06032831 RID: 206897 RVA: 0x006D38F0 File Offset: 0x006D1AF0
		public static Offset<ILookAtTarget> Pack(FlatBufferBuilder builder, ILookAtTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILookAtTarget>);
			}
			VectorOffset lookAtConfigsOffset = default(VectorOffset);
			if (_o.LookAtConfigs != null)
			{
				Offset<INpcLookAtConfig>[] array = new Offset<INpcLookAtConfig>[_o.LookAtConfigs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = INpcLookAtConfig.Pack(builder, _o.LookAtConfigs[i]);
				}
				lookAtConfigsOffset = ILookAtTarget.CreateLookAtConfigsVector(builder, array);
			}
			return ILookAtTarget.CreateILookAtTarget(builder, _o.Type, lookAtConfigsOffset);
		}

		// Token: 0x04012178 RID: 74104
		private Table __p;
	}
}
