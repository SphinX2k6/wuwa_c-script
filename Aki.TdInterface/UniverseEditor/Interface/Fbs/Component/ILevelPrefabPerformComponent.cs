using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A6E RID: 23150
	public struct ILevelPrefabPerformComponent : IFlatbufferObject
	{
		// Token: 0x1700A88A RID: 43146
		// (get) Token: 0x06025E6B RID: 155243 RVA: 0x00532248 File Offset: 0x00530448
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025E6C RID: 155244 RVA: 0x00532255 File Offset: 0x00530455
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025E6D RID: 155245 RVA: 0x0053225C File Offset: 0x0053045C
		public static ILevelPrefabPerformComponent GetRootAsILevelPrefabPerformComponent(ByteBuffer _bb)
		{
			return ILevelPrefabPerformComponent.GetRootAsILevelPrefabPerformComponent(_bb, default(ILevelPrefabPerformComponent));
		}

		// Token: 0x06025E6E RID: 155246 RVA: 0x00532278 File Offset: 0x00530478
		public static ILevelPrefabPerformComponent GetRootAsILevelPrefabPerformComponent(ByteBuffer _bb, ILevelPrefabPerformComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025E6F RID: 155247 RVA: 0x00532295 File Offset: 0x00530495
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025E70 RID: 155248 RVA: 0x005322A4 File Offset: 0x005304A4
		public ILevelPrefabPerformComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A88B RID: 43147
		// (get) Token: 0x06025E71 RID: 155249 RVA: 0x005322B4 File Offset: 0x005304B4
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06025E72 RID: 155250 RVA: 0x005322F4 File Offset: 0x005304F4
		public ITowardEntityConfig? TowardEntity(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ITowardEntityConfig?(default(ITowardEntityConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A88C RID: 43148
		// (get) Token: 0x06025E73 RID: 155251 RVA: 0x00532354 File Offset: 0x00530554
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

		// Token: 0x1700A88D RID: 43149
		// (get) Token: 0x06025E74 RID: 155252 RVA: 0x00532380 File Offset: 0x00530580
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

		// Token: 0x06025E75 RID: 155253 RVA: 0x005323E0 File Offset: 0x005305E0
		public IPrefabCompTransform? CompTransform(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IPrefabCompTransform?(default(IPrefabCompTransform).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A88E RID: 43150
		// (get) Token: 0x06025E76 RID: 155254 RVA: 0x00532444 File Offset: 0x00530644
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

		// Token: 0x1700A88F RID: 43151
		// (get) Token: 0x06025E77 RID: 155255 RVA: 0x00532470 File Offset: 0x00530670
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

		// Token: 0x06025E78 RID: 155256 RVA: 0x005324AD File Offset: 0x005306AD
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

		// Token: 0x06025E79 RID: 155257 RVA: 0x005324E1 File Offset: 0x005306E1
		public static void StartILevelPrefabPerformComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06025E7A RID: 155258 RVA: 0x005324EA File Offset: 0x005306EA
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06025E7B RID: 155259 RVA: 0x005324F5 File Offset: 0x005306F5
		public static void AddTowardEntity(FlatBufferBuilder builder, VectorOffset towardEntityOffset)
		{
			builder.AddOffset(1, towardEntityOffset.Value, 0);
		}

		// Token: 0x06025E7C RID: 155260 RVA: 0x00532508 File Offset: 0x00530708
		public static VectorOffset CreateTowardEntityVector(FlatBufferBuilder builder, Offset<ITowardEntityConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06025E7D RID: 155261 RVA: 0x00532548 File Offset: 0x00530748
		public static VectorOffset CreateTowardEntityVectorBlock(FlatBufferBuilder builder, Offset<ITowardEntityConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ITowardEntityConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025E7E RID: 155262 RVA: 0x00532562 File Offset: 0x00530762
		public static VectorOffset CreateTowardEntityVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ITowardEntityConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ITowardEntityConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025E7F RID: 155263 RVA: 0x00532580 File Offset: 0x00530780
		public static VectorOffset CreateTowardEntityVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ITowardEntityConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025E80 RID: 155264 RVA: 0x00532599 File Offset: 0x00530799
		public static void StartTowardEntityVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025E81 RID: 155265 RVA: 0x005325A4 File Offset: 0x005307A4
		public static void AddPrefabParams(FlatBufferBuilder builder, Offset<ILevelPrefabParamsConfig> prefabParamsOffset)
		{
			builder.AddOffset(2, prefabParamsOffset.Value, 0);
		}

		// Token: 0x06025E82 RID: 155266 RVA: 0x005325B4 File Offset: 0x005307B4
		public static void AddCompTransform(FlatBufferBuilder builder, VectorOffset compTransformOffset)
		{
			builder.AddOffset(3, compTransformOffset.Value, 0);
		}

		// Token: 0x06025E83 RID: 155267 RVA: 0x005325C4 File Offset: 0x005307C4
		public static VectorOffset CreateCompTransformVector(FlatBufferBuilder builder, Offset<IPrefabCompTransform>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06025E84 RID: 155268 RVA: 0x00532604 File Offset: 0x00530804
		public static VectorOffset CreateCompTransformVectorBlock(FlatBufferBuilder builder, Offset<IPrefabCompTransform>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IPrefabCompTransform>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025E85 RID: 155269 RVA: 0x0053261E File Offset: 0x0053081E
		public static VectorOffset CreateCompTransformVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IPrefabCompTransform>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IPrefabCompTransform>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025E86 RID: 155270 RVA: 0x0053263C File Offset: 0x0053083C
		public static VectorOffset CreateCompTransformVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IPrefabCompTransform>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025E87 RID: 155271 RVA: 0x00532655 File Offset: 0x00530855
		public static void StartCompTransformVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025E88 RID: 155272 RVA: 0x00532660 File Offset: 0x00530860
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06025E89 RID: 155273 RVA: 0x0053266B File Offset: 0x0053086B
		public static Offset<ILevelPrefabPerformComponent> EndILevelPrefabPerformComponent(FlatBufferBuilder builder)
		{
			return new Offset<ILevelPrefabPerformComponent>(builder.EndTable());
		}

		// Token: 0x06025E8A RID: 155274 RVA: 0x00532678 File Offset: 0x00530878
		public ILevelPrefabPerformComponentT UnPack()
		{
			ILevelPrefabPerformComponentT levelPrefabPerformComponentT = new ILevelPrefabPerformComponentT();
			this.UnPackTo(levelPrefabPerformComponentT);
			return levelPrefabPerformComponentT;
		}

		// Token: 0x06025E8B RID: 155275 RVA: 0x00532694 File Offset: 0x00530894
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

		// Token: 0x06025E8C RID: 155276 RVA: 0x00532798 File Offset: 0x00530998
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

		// Token: 0x0400F3F0 RID: 62448
		private Table __p;
	}
}
