using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055E6 RID: 21990
	public struct IDestroyCfg : IFlatbufferObject
	{
		// Token: 0x17009D73 RID: 40307
		// (get) Token: 0x06022FFB RID: 143355 RVA: 0x004D0D43 File Offset: 0x004CEF43
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022FFC RID: 143356 RVA: 0x004D0D50 File Offset: 0x004CEF50
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022FFD RID: 143357 RVA: 0x004D0D58 File Offset: 0x004CEF58
		public static IDestroyCfg GetRootAsIDestroyCfg(ByteBuffer _bb)
		{
			return IDestroyCfg.GetRootAsIDestroyCfg(_bb, default(IDestroyCfg));
		}

		// Token: 0x06022FFE RID: 143358 RVA: 0x004D0D74 File Offset: 0x004CEF74
		public static IDestroyCfg GetRootAsIDestroyCfg(ByteBuffer _bb, IDestroyCfg obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022FFF RID: 143359 RVA: 0x004D0D91 File Offset: 0x004CEF91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023000 RID: 143360 RVA: 0x004D0DA0 File Offset: 0x004CEFA0
		public IDestroyCfg __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06023001 RID: 143361 RVA: 0x004D0DB0 File Offset: 0x004CEFB0
		public TTeleControlDestroyCondition ConditionsType(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return TTeleControlDestroyCondition.NONE;
			}
			return (TTeleControlDestroyCondition)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17009D74 RID: 40308
		// (get) Token: 0x06023002 RID: 143362 RVA: 0x004D0DF0 File Offset: 0x004CEFF0
		public int ConditionsTypeLength
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

		// Token: 0x06023003 RID: 143363 RVA: 0x004D0E1B File Offset: 0x004CF01B
		public Span<TTeleControlDestroyCondition> GetConditionsTypeBytes()
		{
			return this.__p.__vector_as_span<TTeleControlDestroyCondition>(4, 1);
		}

		// Token: 0x06023004 RID: 143364 RVA: 0x004D0E2C File Offset: 0x004CF02C
		public TTeleControlDestroyCondition[] GetConditionsTypeArray()
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TTeleControlDestroyCondition[] array = new TTeleControlDestroyCondition[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TTeleControlDestroyCondition)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x06023005 RID: 143365 RVA: 0x004D0E98 File Offset: 0x004CF098
		public TTable? Conditions<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17009D75 RID: 40309
		// (get) Token: 0x06023006 RID: 143366 RVA: 0x004D0EE0 File Offset: 0x004CF0E0
		public int ConditionsLength
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

		// Token: 0x17009D76 RID: 40310
		// (get) Token: 0x06023007 RID: 143367 RVA: 0x004D0F0C File Offset: 0x004CF10C
		public bool StopPhysicAfterDestroyed
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009D77 RID: 40311
		// (get) Token: 0x06023008 RID: 143368 RVA: 0x004D0F4C File Offset: 0x004CF14C
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

		// Token: 0x06023009 RID: 143369 RVA: 0x004D0F89 File Offset: 0x004CF189
		public static Offset<IDestroyCfg> CreateIDestroyCfg(FlatBufferBuilder builder, VectorOffset Conditions_typeOffset = default(VectorOffset), VectorOffset ConditionsOffset = default(VectorOffset), bool StopPhysicAfterDestroyed = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			IDestroyCfg.AddConditions(builder, ConditionsOffset);
			IDestroyCfg.AddConditionsType(builder, Conditions_typeOffset);
			IDestroyCfg.AddNullMask(builder, NullMask);
			IDestroyCfg.AddStopPhysicAfterDestroyed(builder, StopPhysicAfterDestroyed);
			return IDestroyCfg.EndIDestroyCfg(builder);
		}

		// Token: 0x0602300A RID: 143370 RVA: 0x004D0FB5 File Offset: 0x004CF1B5
		public static void StartIDestroyCfg(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602300B RID: 143371 RVA: 0x004D0FBE File Offset: 0x004CF1BE
		public static void AddConditionsType(FlatBufferBuilder builder, VectorOffset conditionsTypeOffset)
		{
			builder.AddOffset(0, conditionsTypeOffset.Value, 0);
		}

		// Token: 0x0602300C RID: 143372 RVA: 0x004D0FD0 File Offset: 0x004CF1D0
		public static VectorOffset CreateConditionsTypeVector(FlatBufferBuilder builder, TTeleControlDestroyCondition[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602300D RID: 143373 RVA: 0x004D1007 File Offset: 0x004CF207
		public static VectorOffset CreateConditionsTypeVectorBlock(FlatBufferBuilder builder, TTeleControlDestroyCondition[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TTeleControlDestroyCondition>(data);
			return builder.EndVector();
		}

		// Token: 0x0602300E RID: 143374 RVA: 0x004D1021 File Offset: 0x004CF221
		public static VectorOffset CreateConditionsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TTeleControlDestroyCondition> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TTeleControlDestroyCondition>(data);
			return builder.EndVector();
		}

		// Token: 0x0602300F RID: 143375 RVA: 0x004D103F File Offset: 0x004CF23F
		public static VectorOffset CreateConditionsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TTeleControlDestroyCondition>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023010 RID: 143376 RVA: 0x004D1058 File Offset: 0x004CF258
		public static void StartConditionsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06023011 RID: 143377 RVA: 0x004D1063 File Offset: 0x004CF263
		public static void AddConditions(FlatBufferBuilder builder, VectorOffset conditionsOffset)
		{
			builder.AddOffset(1, conditionsOffset.Value, 0);
		}

		// Token: 0x06023012 RID: 143378 RVA: 0x004D1074 File Offset: 0x004CF274
		public static VectorOffset CreateConditionsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06023013 RID: 143379 RVA: 0x004D10AB File Offset: 0x004CF2AB
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06023014 RID: 143380 RVA: 0x004D10C5 File Offset: 0x004CF2C5
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06023015 RID: 143381 RVA: 0x004D10E3 File Offset: 0x004CF2E3
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023016 RID: 143382 RVA: 0x004D10FC File Offset: 0x004CF2FC
		public static void StartConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023017 RID: 143383 RVA: 0x004D1107 File Offset: 0x004CF307
		public static void AddStopPhysicAfterDestroyed(FlatBufferBuilder builder, bool stopPhysicAfterDestroyed)
		{
			builder.AddBool(2, stopPhysicAfterDestroyed, false);
		}

		// Token: 0x06023018 RID: 143384 RVA: 0x004D1112 File Offset: 0x004CF312
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06023019 RID: 143385 RVA: 0x004D111D File Offset: 0x004CF31D
		public static Offset<IDestroyCfg> EndIDestroyCfg(FlatBufferBuilder builder)
		{
			return new Offset<IDestroyCfg>(builder.EndTable());
		}

		// Token: 0x0602301A RID: 143386 RVA: 0x004D112C File Offset: 0x004CF32C
		public IDestroyCfgT UnPack()
		{
			IDestroyCfgT destroyCfgT = new IDestroyCfgT();
			this.UnPackTo(destroyCfgT);
			return destroyCfgT;
		}

		// Token: 0x0602301B RID: 143387 RVA: 0x004D1148 File Offset: 0x004CF348
		public void UnPackTo(IDestroyCfgT _o)
		{
			_o.Conditions = new List<TTeleControlDestroyConditionUnion>();
			for (int i = 0; i < this.ConditionsLength; i++)
			{
				TTeleControlDestroyConditionUnion tteleControlDestroyConditionUnion = new TTeleControlDestroyConditionUnion();
				tteleControlDestroyConditionUnion.Type = this.ConditionsType(i);
				switch (this.ConditionsType(i))
				{
				case TTeleControlDestroyCondition.ICreateBulletDestroyCondition:
					tteleControlDestroyConditionUnion.Value = ((this.Conditions<ICreateBulletDestroyCondition>(i) != null) ? this.Conditions<ICreateBulletDestroyCondition>(i).Value.UnPack() : null);
					break;
				case TTeleControlDestroyCondition.ILetGoDestroyCondition:
					tteleControlDestroyConditionUnion.Value = ((this.Conditions<ILetGoDestroyCondition>(i) != null) ? this.Conditions<ILetGoDestroyCondition>(i).Value.UnPack() : null);
					break;
				case TTeleControlDestroyCondition.IThrowDestroyCondition:
					tteleControlDestroyConditionUnion.Value = ((this.Conditions<IThrowDestroyCondition>(i) != null) ? this.Conditions<IThrowDestroyCondition>(i).Value.UnPack() : null);
					break;
				}
				_o.Conditions.Add(tteleControlDestroyConditionUnion);
			}
			_o.StopPhysicAfterDestroyed = this.StopPhysicAfterDestroyed;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602301C RID: 143388 RVA: 0x004D1270 File Offset: 0x004CF470
		public static Offset<IDestroyCfg> Pack(FlatBufferBuilder builder, IDestroyCfgT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDestroyCfg>);
			}
			VectorOffset conditions_typeOffset = default(VectorOffset);
			if (_o.Conditions != null)
			{
				TTeleControlDestroyCondition[] array = new TTeleControlDestroyCondition[_o.Conditions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.Conditions[i].Type;
				}
				conditions_typeOffset = IDestroyCfg.CreateConditionsTypeVector(builder, array);
			}
			VectorOffset conditionsOffset = default(VectorOffset);
			if (_o.Conditions != null)
			{
				int[] array2 = new int[_o.Conditions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TTeleControlDestroyConditionUnion.Pack(builder, _o.Conditions[j]);
				}
				conditionsOffset = IDestroyCfg.CreateConditionsVector(builder, array2);
			}
			return IDestroyCfg.CreateIDestroyCfg(builder, conditions_typeOffset, conditionsOffset, _o.StopPhysicAfterDestroyed, _o.NullMask);
		}

		// Token: 0x0400EC83 RID: 60547
		private Table __p;
	}
}
