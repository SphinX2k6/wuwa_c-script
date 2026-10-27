using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005081 RID: 20609
	public struct IDestroyCfg : IFlatbufferObject
	{
		// Token: 0x17009586 RID: 38278
		// (get) Token: 0x060210A7 RID: 135335 RVA: 0x00496DFF File Offset: 0x00494FFF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060210A8 RID: 135336 RVA: 0x00496E0C File Offset: 0x0049500C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060210A9 RID: 135337 RVA: 0x00496E14 File Offset: 0x00495014
		public static IDestroyCfg GetRootAsIDestroyCfg(ByteBuffer _bb)
		{
			return IDestroyCfg.GetRootAsIDestroyCfg(_bb, default(IDestroyCfg));
		}

		// Token: 0x060210AA RID: 135338 RVA: 0x00496E30 File Offset: 0x00495030
		public static IDestroyCfg GetRootAsIDestroyCfg(ByteBuffer _bb, IDestroyCfg obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060210AB RID: 135339 RVA: 0x00496E4D File Offset: 0x0049504D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060210AC RID: 135340 RVA: 0x00496E5C File Offset: 0x0049505C
		public IDestroyCfg __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x060210AD RID: 135341 RVA: 0x00496E6C File Offset: 0x0049506C
		public TTeleControlDestroyCondition ConditionsType(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return TTeleControlDestroyCondition.NONE;
			}
			return (TTeleControlDestroyCondition)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17009587 RID: 38279
		// (get) Token: 0x060210AE RID: 135342 RVA: 0x00496EAC File Offset: 0x004950AC
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

		// Token: 0x060210AF RID: 135343 RVA: 0x00496ED7 File Offset: 0x004950D7
		public Span<TTeleControlDestroyCondition> GetConditionsTypeBytes()
		{
			return this.__p.__vector_as_span<TTeleControlDestroyCondition>(4, 1);
		}

		// Token: 0x060210B0 RID: 135344 RVA: 0x00496EE8 File Offset: 0x004950E8
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

		// Token: 0x060210B1 RID: 135345 RVA: 0x00496F54 File Offset: 0x00495154
		public TTable? Conditions<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17009588 RID: 38280
		// (get) Token: 0x060210B2 RID: 135346 RVA: 0x00496F9C File Offset: 0x0049519C
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

		// Token: 0x17009589 RID: 38281
		// (get) Token: 0x060210B3 RID: 135347 RVA: 0x00496FC8 File Offset: 0x004951C8
		public bool StopPhysicAfterDestroyed
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700958A RID: 38282
		// (get) Token: 0x060210B4 RID: 135348 RVA: 0x00497008 File Offset: 0x00495208
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

		// Token: 0x060210B5 RID: 135349 RVA: 0x00497045 File Offset: 0x00495245
		public static Offset<IDestroyCfg> CreateIDestroyCfg(FlatBufferBuilder builder, VectorOffset Conditions_typeOffset = default(VectorOffset), VectorOffset ConditionsOffset = default(VectorOffset), bool StopPhysicAfterDestroyed = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			IDestroyCfg.AddConditions(builder, ConditionsOffset);
			IDestroyCfg.AddConditionsType(builder, Conditions_typeOffset);
			IDestroyCfg.AddNullMask(builder, NullMask);
			IDestroyCfg.AddStopPhysicAfterDestroyed(builder, StopPhysicAfterDestroyed);
			return IDestroyCfg.EndIDestroyCfg(builder);
		}

		// Token: 0x060210B6 RID: 135350 RVA: 0x00497071 File Offset: 0x00495271
		public static void StartIDestroyCfg(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060210B7 RID: 135351 RVA: 0x0049707A File Offset: 0x0049527A
		public static void AddConditionsType(FlatBufferBuilder builder, VectorOffset conditionsTypeOffset)
		{
			builder.AddOffset(0, conditionsTypeOffset.Value, 0);
		}

		// Token: 0x060210B8 RID: 135352 RVA: 0x0049708C File Offset: 0x0049528C
		public static VectorOffset CreateConditionsTypeVector(FlatBufferBuilder builder, TTeleControlDestroyCondition[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060210B9 RID: 135353 RVA: 0x004970C3 File Offset: 0x004952C3
		public static VectorOffset CreateConditionsTypeVectorBlock(FlatBufferBuilder builder, TTeleControlDestroyCondition[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TTeleControlDestroyCondition>(data);
			return builder.EndVector();
		}

		// Token: 0x060210BA RID: 135354 RVA: 0x004970DD File Offset: 0x004952DD
		public static VectorOffset CreateConditionsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TTeleControlDestroyCondition> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TTeleControlDestroyCondition>(data);
			return builder.EndVector();
		}

		// Token: 0x060210BB RID: 135355 RVA: 0x004970FB File Offset: 0x004952FB
		public static VectorOffset CreateConditionsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TTeleControlDestroyCondition>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060210BC RID: 135356 RVA: 0x00497114 File Offset: 0x00495314
		public static void StartConditionsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x060210BD RID: 135357 RVA: 0x0049711F File Offset: 0x0049531F
		public static void AddConditions(FlatBufferBuilder builder, VectorOffset conditionsOffset)
		{
			builder.AddOffset(1, conditionsOffset.Value, 0);
		}

		// Token: 0x060210BE RID: 135358 RVA: 0x00497130 File Offset: 0x00495330
		public static VectorOffset CreateConditionsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060210BF RID: 135359 RVA: 0x00497167 File Offset: 0x00495367
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060210C0 RID: 135360 RVA: 0x00497181 File Offset: 0x00495381
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060210C1 RID: 135361 RVA: 0x0049719F File Offset: 0x0049539F
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060210C2 RID: 135362 RVA: 0x004971B8 File Offset: 0x004953B8
		public static void StartConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060210C3 RID: 135363 RVA: 0x004971C3 File Offset: 0x004953C3
		public static void AddStopPhysicAfterDestroyed(FlatBufferBuilder builder, bool stopPhysicAfterDestroyed)
		{
			builder.AddBool(2, stopPhysicAfterDestroyed, false);
		}

		// Token: 0x060210C4 RID: 135364 RVA: 0x004971CE File Offset: 0x004953CE
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x060210C5 RID: 135365 RVA: 0x004971D9 File Offset: 0x004953D9
		public static Offset<IDestroyCfg> EndIDestroyCfg(FlatBufferBuilder builder)
		{
			return new Offset<IDestroyCfg>(builder.EndTable());
		}

		// Token: 0x060210C6 RID: 135366 RVA: 0x004971E8 File Offset: 0x004953E8
		public IDestroyCfgT UnPack()
		{
			IDestroyCfgT destroyCfgT = new IDestroyCfgT();
			this.UnPackTo(destroyCfgT);
			return destroyCfgT;
		}

		// Token: 0x060210C7 RID: 135367 RVA: 0x00497204 File Offset: 0x00495404
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

		// Token: 0x060210C8 RID: 135368 RVA: 0x0049732C File Offset: 0x0049552C
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

		// Token: 0x0400E086 RID: 57478
		private Table __p;
	}
}
