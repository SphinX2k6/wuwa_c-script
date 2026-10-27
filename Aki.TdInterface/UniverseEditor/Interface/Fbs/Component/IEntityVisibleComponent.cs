using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051C5 RID: 20933
	public struct IEntityVisibleComponent : IFlatbufferObject
	{
		// Token: 0x17009923 RID: 39203
		// (get) Token: 0x06021ECC RID: 138956 RVA: 0x004B4D42 File Offset: 0x004B2F42
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021ECD RID: 138957 RVA: 0x004B4D4F File Offset: 0x004B2F4F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021ECE RID: 138958 RVA: 0x004B4D58 File Offset: 0x004B2F58
		public static IEntityVisibleComponent GetRootAsIEntityVisibleComponent(ByteBuffer _bb)
		{
			return IEntityVisibleComponent.GetRootAsIEntityVisibleComponent(_bb, default(IEntityVisibleComponent));
		}

		// Token: 0x06021ECF RID: 138959 RVA: 0x004B4D74 File Offset: 0x004B2F74
		public static IEntityVisibleComponent GetRootAsIEntityVisibleComponent(ByteBuffer _bb, IEntityVisibleComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021ED0 RID: 138960 RVA: 0x004B4D91 File Offset: 0x004B2F91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021ED1 RID: 138961 RVA: 0x004B4DA0 File Offset: 0x004B2FA0
		public IEntityVisibleComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009924 RID: 39204
		// (get) Token: 0x06021ED2 RID: 138962 RVA: 0x004B4DB0 File Offset: 0x004B2FB0
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009925 RID: 39205
		// (get) Token: 0x06021ED3 RID: 138963 RVA: 0x004B4DF0 File Offset: 0x004B2FF0
		public bool DelayChange
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009926 RID: 39206
		// (get) Token: 0x06021ED4 RID: 138964 RVA: 0x004B4E30 File Offset: 0x004B3030
		public bool UseFadeEffect
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009927 RID: 39207
		// (get) Token: 0x06021ED5 RID: 138965 RVA: 0x004B4E70 File Offset: 0x004B3070
		public bool UseCutEffect
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009928 RID: 39208
		// (get) Token: 0x06021ED6 RID: 138966 RVA: 0x004B4EB0 File Offset: 0x004B30B0
		public bool UseHolographicEffect
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06021ED7 RID: 138967 RVA: 0x004B4EF0 File Offset: 0x004B30F0
		public IVisibleConditionGroup? VisibleConditions(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IVisibleConditionGroup?(default(IVisibleConditionGroup).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009929 RID: 39209
		// (get) Token: 0x06021ED8 RID: 138968 RVA: 0x004B4F54 File Offset: 0x004B3154
		public int VisibleConditionsLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700992A RID: 39210
		// (get) Token: 0x06021ED9 RID: 138969 RVA: 0x004B4F80 File Offset: 0x004B3180
		public int CustomVisibleRange
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700992B RID: 39211
		// (get) Token: 0x06021EDA RID: 138970 RVA: 0x004B4FC0 File Offset: 0x004B31C0
		public ERuntimePlatformOptions TargetPlatform
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return ERuntimePlatformOptions.None;
				}
				return (ERuntimePlatformOptions)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700992C RID: 39212
		// (get) Token: 0x06021EDB RID: 138971 RVA: 0x004B5000 File Offset: 0x004B3200
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021EDC RID: 138972 RVA: 0x004B5040 File Offset: 0x004B3240
		public static Offset<IEntityVisibleComponent> CreateIEntityVisibleComponent(FlatBufferBuilder builder, bool Disabled = false, bool DelayChange = false, bool UseFadeEffect = false, bool UseCutEffect = false, bool UseHolographicEffect = false, VectorOffset VisibleConditionsOffset = default(VectorOffset), int CustomVisibleRange = 0, ERuntimePlatformOptions TargetPlatform = ERuntimePlatformOptions.None, byte NullMask = 0)
		{
			builder.StartTable(9);
			IEntityVisibleComponent.AddCustomVisibleRange(builder, CustomVisibleRange);
			IEntityVisibleComponent.AddVisibleConditions(builder, VisibleConditionsOffset);
			IEntityVisibleComponent.AddNullMask(builder, NullMask);
			IEntityVisibleComponent.AddTargetPlatform(builder, TargetPlatform);
			IEntityVisibleComponent.AddUseHolographicEffect(builder, UseHolographicEffect);
			IEntityVisibleComponent.AddUseCutEffect(builder, UseCutEffect);
			IEntityVisibleComponent.AddUseFadeEffect(builder, UseFadeEffect);
			IEntityVisibleComponent.AddDelayChange(builder, DelayChange);
			IEntityVisibleComponent.AddDisabled(builder, Disabled);
			return IEntityVisibleComponent.EndIEntityVisibleComponent(builder);
		}

		// Token: 0x06021EDD RID: 138973 RVA: 0x004B50A0 File Offset: 0x004B32A0
		public static void StartIEntityVisibleComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x06021EDE RID: 138974 RVA: 0x004B50AA File Offset: 0x004B32AA
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06021EDF RID: 138975 RVA: 0x004B50B5 File Offset: 0x004B32B5
		public static void AddDelayChange(FlatBufferBuilder builder, bool delayChange)
		{
			builder.AddBool(1, delayChange, false);
		}

		// Token: 0x06021EE0 RID: 138976 RVA: 0x004B50C0 File Offset: 0x004B32C0
		public static void AddUseFadeEffect(FlatBufferBuilder builder, bool useFadeEffect)
		{
			builder.AddBool(2, useFadeEffect, false);
		}

		// Token: 0x06021EE1 RID: 138977 RVA: 0x004B50CB File Offset: 0x004B32CB
		public static void AddUseCutEffect(FlatBufferBuilder builder, bool useCutEffect)
		{
			builder.AddBool(3, useCutEffect, false);
		}

		// Token: 0x06021EE2 RID: 138978 RVA: 0x004B50D6 File Offset: 0x004B32D6
		public static void AddUseHolographicEffect(FlatBufferBuilder builder, bool useHolographicEffect)
		{
			builder.AddBool(4, useHolographicEffect, false);
		}

		// Token: 0x06021EE3 RID: 138979 RVA: 0x004B50E1 File Offset: 0x004B32E1
		public static void AddVisibleConditions(FlatBufferBuilder builder, VectorOffset visibleConditionsOffset)
		{
			builder.AddOffset(5, visibleConditionsOffset.Value, 0);
		}

		// Token: 0x06021EE4 RID: 138980 RVA: 0x004B50F4 File Offset: 0x004B32F4
		public static VectorOffset CreateVisibleConditionsVector(FlatBufferBuilder builder, Offset<IVisibleConditionGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06021EE5 RID: 138981 RVA: 0x004B5134 File Offset: 0x004B3334
		public static VectorOffset CreateVisibleConditionsVectorBlock(FlatBufferBuilder builder, Offset<IVisibleConditionGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IVisibleConditionGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021EE6 RID: 138982 RVA: 0x004B514E File Offset: 0x004B334E
		public static VectorOffset CreateVisibleConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IVisibleConditionGroup>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IVisibleConditionGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021EE7 RID: 138983 RVA: 0x004B516C File Offset: 0x004B336C
		public static VectorOffset CreateVisibleConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IVisibleConditionGroup>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021EE8 RID: 138984 RVA: 0x004B5185 File Offset: 0x004B3385
		public static void StartVisibleConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021EE9 RID: 138985 RVA: 0x004B5190 File Offset: 0x004B3390
		public static void AddCustomVisibleRange(FlatBufferBuilder builder, int customVisibleRange)
		{
			builder.AddInt(6, customVisibleRange, 0);
		}

		// Token: 0x06021EEA RID: 138986 RVA: 0x004B519B File Offset: 0x004B339B
		public static void AddTargetPlatform(FlatBufferBuilder builder, ERuntimePlatformOptions targetPlatform)
		{
			builder.AddByte(7, (byte)targetPlatform, 0);
		}

		// Token: 0x06021EEB RID: 138987 RVA: 0x004B51A6 File Offset: 0x004B33A6
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x06021EEC RID: 138988 RVA: 0x004B51B1 File Offset: 0x004B33B1
		public static Offset<IEntityVisibleComponent> EndIEntityVisibleComponent(FlatBufferBuilder builder)
		{
			return new Offset<IEntityVisibleComponent>(builder.EndTable());
		}

		// Token: 0x06021EED RID: 138989 RVA: 0x004B51C0 File Offset: 0x004B33C0
		public IEntityVisibleComponentT UnPack()
		{
			IEntityVisibleComponentT entityVisibleComponentT = new IEntityVisibleComponentT();
			this.UnPackTo(entityVisibleComponentT);
			return entityVisibleComponentT;
		}

		// Token: 0x06021EEE RID: 138990 RVA: 0x004B51DC File Offset: 0x004B33DC
		public void UnPackTo(IEntityVisibleComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.DelayChange = this.DelayChange;
			_o.UseFadeEffect = this.UseFadeEffect;
			_o.UseCutEffect = this.UseCutEffect;
			_o.UseHolographicEffect = this.UseHolographicEffect;
			_o.VisibleConditions = new List<IVisibleConditionGroupT>();
			for (int i = 0; i < this.VisibleConditionsLength; i++)
			{
				_o.VisibleConditions.Add((this.VisibleConditions(i) != null) ? this.VisibleConditions(i).Value.UnPack() : null);
			}
			_o.CustomVisibleRange = this.CustomVisibleRange;
			_o.TargetPlatform = this.TargetPlatform;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06021EEF RID: 138991 RVA: 0x004B529C File Offset: 0x004B349C
		public static Offset<IEntityVisibleComponent> Pack(FlatBufferBuilder builder, IEntityVisibleComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityVisibleComponent>);
			}
			VectorOffset visibleConditionsOffset = default(VectorOffset);
			if (_o.VisibleConditions != null)
			{
				Offset<IVisibleConditionGroup>[] array = new Offset<IVisibleConditionGroup>[_o.VisibleConditions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IVisibleConditionGroup.Pack(builder, _o.VisibleConditions[i]);
				}
				visibleConditionsOffset = IEntityVisibleComponent.CreateVisibleConditionsVector(builder, array);
			}
			return IEntityVisibleComponent.CreateIEntityVisibleComponent(builder, _o.Disabled, _o.DelayChange, _o.UseFadeEffect, _o.UseCutEffect, _o.UseHolographicEffect, visibleConditionsOffset, _o.CustomVisibleRange, _o.TargetPlatform, _o.NullMask);
		}

		// Token: 0x0400E2C0 RID: 58048
		private Table __p;
	}
}
