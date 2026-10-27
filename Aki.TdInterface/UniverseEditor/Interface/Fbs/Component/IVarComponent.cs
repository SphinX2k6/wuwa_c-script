using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B05 RID: 23301
	public struct IVarComponent : IFlatbufferObject
	{
		// Token: 0x1700AFCA RID: 45002
		// (get) Token: 0x06027C8C RID: 162956 RVA: 0x00578C96 File Offset: 0x00576E96
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027C8D RID: 162957 RVA: 0x00578CA3 File Offset: 0x00576EA3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027C8E RID: 162958 RVA: 0x00578CAC File Offset: 0x00576EAC
		public static IVarComponent GetRootAsIVarComponent(ByteBuffer _bb)
		{
			return IVarComponent.GetRootAsIVarComponent(_bb, default(IVarComponent));
		}

		// Token: 0x06027C8F RID: 162959 RVA: 0x00578CC8 File Offset: 0x00576EC8
		public static IVarComponent GetRootAsIVarComponent(ByteBuffer _bb, IVarComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027C90 RID: 162960 RVA: 0x00578CE5 File Offset: 0x00576EE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027C91 RID: 162961 RVA: 0x00578CF4 File Offset: 0x00576EF4
		public IVarComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AFCB RID: 45003
		// (get) Token: 0x06027C92 RID: 162962 RVA: 0x00578D04 File Offset: 0x00576F04
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06027C93 RID: 162963 RVA: 0x00578D44 File Offset: 0x00576F44
		public IVarDefine? Vars(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IVarDefine?(default(IVarDefine).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AFCC RID: 45004
		// (get) Token: 0x06027C94 RID: 162964 RVA: 0x00578DA4 File Offset: 0x00576FA4
		public int VarsLength
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

		// Token: 0x1700AFCD RID: 45005
		// (get) Token: 0x06027C95 RID: 162965 RVA: 0x00578DD0 File Offset: 0x00576FD0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027C96 RID: 162966 RVA: 0x00578E0C File Offset: 0x0057700C
		public static Offset<IVarComponent> CreateIVarComponent(FlatBufferBuilder builder, bool Disabled = false, VectorOffset VarsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IVarComponent.AddVars(builder, VarsOffset);
			IVarComponent.AddNullMask(builder, NullMask);
			IVarComponent.AddDisabled(builder, Disabled);
			return IVarComponent.EndIVarComponent(builder);
		}

		// Token: 0x06027C97 RID: 162967 RVA: 0x00578E30 File Offset: 0x00577030
		public static void StartIVarComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06027C98 RID: 162968 RVA: 0x00578E39 File Offset: 0x00577039
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06027C99 RID: 162969 RVA: 0x00578E44 File Offset: 0x00577044
		public static void AddVars(FlatBufferBuilder builder, VectorOffset varsOffset)
		{
			builder.AddOffset(1, varsOffset.Value, 0);
		}

		// Token: 0x06027C9A RID: 162970 RVA: 0x00578E54 File Offset: 0x00577054
		public static VectorOffset CreateVarsVector(FlatBufferBuilder builder, Offset<IVarDefine>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06027C9B RID: 162971 RVA: 0x00578E94 File Offset: 0x00577094
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, Offset<IVarDefine>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IVarDefine>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027C9C RID: 162972 RVA: 0x00578EAE File Offset: 0x005770AE
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IVarDefine>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IVarDefine>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027C9D RID: 162973 RVA: 0x00578ECC File Offset: 0x005770CC
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IVarDefine>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027C9E RID: 162974 RVA: 0x00578EE5 File Offset: 0x005770E5
		public static void StartVarsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06027C9F RID: 162975 RVA: 0x00578EF0 File Offset: 0x005770F0
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06027CA0 RID: 162976 RVA: 0x00578EFB File Offset: 0x005770FB
		public static Offset<IVarComponent> EndIVarComponent(FlatBufferBuilder builder)
		{
			return new Offset<IVarComponent>(builder.EndTable());
		}

		// Token: 0x06027CA1 RID: 162977 RVA: 0x00578F08 File Offset: 0x00577108
		public IVarComponentT UnPack()
		{
			IVarComponentT varComponentT = new IVarComponentT();
			this.UnPackTo(varComponentT);
			return varComponentT;
		}

		// Token: 0x06027CA2 RID: 162978 RVA: 0x00578F24 File Offset: 0x00577124
		public void UnPackTo(IVarComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.Vars = new List<IVarDefineT>();
			for (int i = 0; i < this.VarsLength; i++)
			{
				_o.Vars.Add((this.Vars(i) != null) ? this.Vars(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06027CA3 RID: 162979 RVA: 0x00578F9C File Offset: 0x0057719C
		public static Offset<IVarComponent> Pack(FlatBufferBuilder builder, IVarComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVarComponent>);
			}
			VectorOffset varsOffset = default(VectorOffset);
			if (_o.Vars != null)
			{
				Offset<IVarDefine>[] array = new Offset<IVarDefine>[_o.Vars.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IVarDefine.Pack(builder, _o.Vars[i]);
				}
				varsOffset = IVarComponent.CreateVarsVector(builder, array);
			}
			return IVarComponent.CreateIVarComponent(builder, _o.Disabled, varsOffset, _o.NullMask);
		}

		// Token: 0x0400F208 RID: 61960
		private Table __p;
	}
}
