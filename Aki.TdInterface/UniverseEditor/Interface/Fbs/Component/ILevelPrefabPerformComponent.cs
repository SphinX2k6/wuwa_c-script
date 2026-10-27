using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054E8 RID: 21736
	public struct ILevelPrefabPerformComponent : IFlatbufferObject
	{
		// Token: 0x1700A050 RID: 41040
		// (get) Token: 0x06023DB1 RID: 146865 RVA: 0x004F5124 File Offset: 0x004F3324
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023DB2 RID: 146866 RVA: 0x004F5131 File Offset: 0x004F3331
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023DB3 RID: 146867 RVA: 0x004F5138 File Offset: 0x004F3338
		public static ILevelPrefabPerformComponent GetRootAsILevelPrefabPerformComponent(ByteBuffer _bb)
		{
			return ILevelPrefabPerformComponent.GetRootAsILevelPrefabPerformComponent(_bb, default(ILevelPrefabPerformComponent));
		}

		// Token: 0x06023DB4 RID: 146868 RVA: 0x004F5154 File Offset: 0x004F3354
		public static ILevelPrefabPerformComponent GetRootAsILevelPrefabPerformComponent(ByteBuffer _bb, ILevelPrefabPerformComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023DB5 RID: 146869 RVA: 0x004F5171 File Offset: 0x004F3371
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023DB6 RID: 146870 RVA: 0x004F5180 File Offset: 0x004F3380
		public ILevelPrefabPerformComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A051 RID: 41041
		// (get) Token: 0x06023DB7 RID: 146871 RVA: 0x004F5190 File Offset: 0x004F3390
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06023DB8 RID: 146872 RVA: 0x004F51D0 File Offset: 0x004F33D0
		public ITowardEntityConfig? TowardEntity(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ITowardEntityConfig?(default(ITowardEntityConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A052 RID: 41042
		// (get) Token: 0x06023DB9 RID: 146873 RVA: 0x004F5230 File Offset: 0x004F3430
		public int TowardEntityLength
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

		// Token: 0x1700A053 RID: 41043
		// (get) Token: 0x06023DBA RID: 146874 RVA: 0x004F525C File Offset: 0x004F345C
		public ILevelPrefabParamsConfig? PrefabParams
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new ILevelPrefabParamsConfig?(default(ILevelPrefabParamsConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06023DBB RID: 146875 RVA: 0x004F52BC File Offset: 0x004F34BC
		public IPrefabCompTransform? CompTransform(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IPrefabCompTransform?(default(IPrefabCompTransform).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A054 RID: 41044
		// (get) Token: 0x06023DBC RID: 146876 RVA: 0x004F5320 File Offset: 0x004F3520
		public int CompTransformLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700A055 RID: 41045
		// (get) Token: 0x06023DBD RID: 146877 RVA: 0x004F534C File Offset: 0x004F354C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023DBE RID: 146878 RVA: 0x004F5389 File Offset: 0x004F3589
		public static Offset<ILevelPrefabPerformComponent> CreateILevelPrefabPerformComponent(FlatBufferBuilder builder, bool Disabled = false, VectorOffset TowardEntityOffset = default(VectorOffset), Offset<ILevelPrefabParamsConfig> PrefabParamsOffset = default(Offset<ILevelPrefabParamsConfig>), VectorOffset CompTransformOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(5);
			ILevelPrefabPerformComponent.AddCompTransform(builder, CompTransformOffset);
			ILevelPrefabPerformComponent.AddPrefabParams(builder, PrefabParamsOffset);
			ILevelPrefabPerformComponent.AddTowardEntity(builder, TowardEntityOffset);
			ILevelPrefabPerformComponent.AddNullMask(builder, NullMask);
			ILevelPrefabPerformComponent.AddDisabled(builder, Disabled);
			return ILevelPrefabPerformComponent.EndILevelPrefabPerformComponent(builder);
		}

		// Token: 0x06023DBF RID: 146879 RVA: 0x004F53BD File Offset: 0x004F35BD
		public static void StartILevelPrefabPerformComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06023DC0 RID: 146880 RVA: 0x004F53C6 File Offset: 0x004F35C6
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06023DC1 RID: 146881 RVA: 0x004F53D1 File Offset: 0x004F35D1
		public static void AddTowardEntity(FlatBufferBuilder builder, VectorOffset towardEntityOffset)
		{
			builder.AddOffset(1, towardEntityOffset.Value, 0);
		}

		// Token: 0x06023DC2 RID: 146882 RVA: 0x004F53E4 File Offset: 0x004F35E4
		public static VectorOffset CreateTowardEntityVector(FlatBufferBuilder builder, Offset<ITowardEntityConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023DC3 RID: 146883 RVA: 0x004F5424 File Offset: 0x004F3624
		public static VectorOffset CreateTowardEntityVectorBlock(FlatBufferBuilder builder, Offset<ITowardEntityConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ITowardEntityConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023DC4 RID: 146884 RVA: 0x004F543E File Offset: 0x004F363E
		public static VectorOffset CreateTowardEntityVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ITowardEntityConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ITowardEntityConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023DC5 RID: 146885 RVA: 0x004F545C File Offset: 0x004F365C
		public static VectorOffset CreateTowardEntityVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ITowardEntityConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023DC6 RID: 146886 RVA: 0x004F5475 File Offset: 0x004F3675
		public static void StartTowardEntityVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023DC7 RID: 146887 RVA: 0x004F5480 File Offset: 0x004F3680
		public static void AddPrefabParams(FlatBufferBuilder builder, Offset<ILevelPrefabParamsConfig> prefabParamsOffset)
		{
			builder.AddOffset(2, prefabParamsOffset.Value, 0);
		}

		// Token: 0x06023DC8 RID: 146888 RVA: 0x004F5490 File Offset: 0x004F3690
		public static void AddCompTransform(FlatBufferBuilder builder, VectorOffset compTransformOffset)
		{
			builder.AddOffset(3, compTransformOffset.Value, 0);
		}

		// Token: 0x06023DC9 RID: 146889 RVA: 0x004F54A0 File Offset: 0x004F36A0
		public static VectorOffset CreateCompTransformVector(FlatBufferBuilder builder, Offset<IPrefabCompTransform>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023DCA RID: 146890 RVA: 0x004F54E0 File Offset: 0x004F36E0
		public static VectorOffset CreateCompTransformVectorBlock(FlatBufferBuilder builder, Offset<IPrefabCompTransform>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IPrefabCompTransform>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023DCB RID: 146891 RVA: 0x004F54FA File Offset: 0x004F36FA
		public static VectorOffset CreateCompTransformVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IPrefabCompTransform>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IPrefabCompTransform>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023DCC RID: 146892 RVA: 0x004F5518 File Offset: 0x004F3718
		public static VectorOffset CreateCompTransformVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IPrefabCompTransform>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023DCD RID: 146893 RVA: 0x004F5531 File Offset: 0x004F3731
		public static void StartCompTransformVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023DCE RID: 146894 RVA: 0x004F553C File Offset: 0x004F373C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06023DCF RID: 146895 RVA: 0x004F5547 File Offset: 0x004F3747
		public static Offset<ILevelPrefabPerformComponent> EndILevelPrefabPerformComponent(FlatBufferBuilder builder)
		{
			return new Offset<ILevelPrefabPerformComponent>(builder.EndTable());
		}

		// Token: 0x06023DD0 RID: 146896 RVA: 0x004F5554 File Offset: 0x004F3754
		public ILevelPrefabPerformComponentT UnPack()
		{
			ILevelPrefabPerformComponentT levelPrefabPerformComponentT = new ILevelPrefabPerformComponentT();
			this.UnPackTo(levelPrefabPerformComponentT);
			return levelPrefabPerformComponentT;
		}

		// Token: 0x06023DD1 RID: 146897 RVA: 0x004F5570 File Offset: 0x004F3770
		public void UnPackTo(ILevelPrefabPerformComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.TowardEntity = new List<ITowardEntityConfigT>();
			for (int i = 0; i < this.TowardEntityLength; i++)
			{
				_o.TowardEntity.Add((this.TowardEntity(i) != null) ? this.TowardEntity(i).Value.UnPack() : null);
			}
			_o.PrefabParams = ((this.PrefabParams != null) ? this.PrefabParams.Value.UnPack() : null);
			_o.CompTransform = new List<IPrefabCompTransformT>();
			for (int j = 0; j < this.CompTransformLength; j++)
			{
				_o.CompTransform.Add((this.CompTransform(j) != null) ? this.CompTransform(j).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06023DD2 RID: 146898 RVA: 0x004F5674 File Offset: 0x004F3874
		public static Offset<ILevelPrefabPerformComponent> Pack(FlatBufferBuilder builder, ILevelPrefabPerformComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelPrefabPerformComponent>);
			}
			VectorOffset towardEntityOffset = default(VectorOffset);
			if (_o.TowardEntity != null)
			{
				Offset<ITowardEntityConfig>[] array = new Offset<ITowardEntityConfig>[_o.TowardEntity.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ITowardEntityConfig.Pack(builder, _o.TowardEntity[i]);
				}
				towardEntityOffset = ILevelPrefabPerformComponent.CreateTowardEntityVector(builder, array);
			}
			Offset<ILevelPrefabParamsConfig> prefabParamsOffset = (_o.PrefabParams == null) ? default(Offset<ILevelPrefabParamsConfig>) : ILevelPrefabParamsConfig.Pack(builder, _o.PrefabParams);
			VectorOffset compTransformOffset = default(VectorOffset);
			if (_o.CompTransform != null)
			{
				Offset<IPrefabCompTransform>[] array2 = new Offset<IPrefabCompTransform>[_o.CompTransform.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IPrefabCompTransform.Pack(builder, _o.CompTransform[j]);
				}
				compTransformOffset = ILevelPrefabPerformComponent.CreateCompTransformVector(builder, array2);
			}
			return ILevelPrefabPerformComponent.CreateILevelPrefabPerformComponent(builder, _o.Disabled, towardEntityOffset, prefabParamsOffset, compTransformOffset, _o.NullMask);
		}

		// Token: 0x0400E7BF RID: 59327
		private Table __p;
	}
}
