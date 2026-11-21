using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200572A RID: 22314
	public struct IEntityVisibleComponent : IFlatbufferObject
	{
		// Token: 0x1700A112 RID: 41234
		// (get) Token: 0x06023E24 RID: 146980 RVA: 0x004EEDAA File Offset: 0x004ECFAA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023E25 RID: 146981 RVA: 0x004EEDB7 File Offset: 0x004ECFB7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023E26 RID: 146982 RVA: 0x004EEDC0 File Offset: 0x004ECFC0
		public static IEntityVisibleComponent GetRootAsIEntityVisibleComponent(ByteBuffer _bb)
		{
			return IEntityVisibleComponent.GetRootAsIEntityVisibleComponent(_bb, default(IEntityVisibleComponent));
		}

		// Token: 0x06023E27 RID: 146983 RVA: 0x004EEDDC File Offset: 0x004ECFDC
		public static IEntityVisibleComponent GetRootAsIEntityVisibleComponent(ByteBuffer _bb, IEntityVisibleComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023E28 RID: 146984 RVA: 0x004EEDF9 File Offset: 0x004ECFF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023E29 RID: 146985 RVA: 0x004EEE08 File Offset: 0x004ED008
		public IEntityVisibleComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A113 RID: 41235
		// (get) Token: 0x06023E2A RID: 146986 RVA: 0x004EEE18 File Offset: 0x004ED018
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A114 RID: 41236
		// (get) Token: 0x06023E2B RID: 146987 RVA: 0x004EEE58 File Offset: 0x004ED058
		public bool DelayChange
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A115 RID: 41237
		// (get) Token: 0x06023E2C RID: 146988 RVA: 0x004EEE98 File Offset: 0x004ED098
		public bool UseFadeEffect
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A116 RID: 41238
		// (get) Token: 0x06023E2D RID: 146989 RVA: 0x004EEED8 File Offset: 0x004ED0D8
		public bool UseCutEffect
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A117 RID: 41239
		// (get) Token: 0x06023E2E RID: 146990 RVA: 0x004EEF18 File Offset: 0x004ED118
		public bool UseHolographicEffect
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06023E2F RID: 146991 RVA: 0x004EEF58 File Offset: 0x004ED158
		public IVisibleConditionGroup? VisibleConditions(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IVisibleConditionGroup?(default(IVisibleConditionGroup).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A118 RID: 41240
		// (get) Token: 0x06023E30 RID: 146992 RVA: 0x004EEFBC File Offset: 0x004ED1BC
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

		// Token: 0x1700A119 RID: 41241
		// (get) Token: 0x06023E31 RID: 146993 RVA: 0x004EEFE8 File Offset: 0x004ED1E8
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

		// Token: 0x1700A11A RID: 41242
		// (get) Token: 0x06023E32 RID: 146994 RVA: 0x004EF028 File Offset: 0x004ED228
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

		// Token: 0x1700A11B RID: 41243
		// (get) Token: 0x06023E33 RID: 146995 RVA: 0x004EF068 File Offset: 0x004ED268
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

		// Token: 0x06023E34 RID: 146996 RVA: 0x004EF0A8 File Offset: 0x004ED2A8
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

		// Token: 0x06023E35 RID: 146997 RVA: 0x004EF108 File Offset: 0x004ED308
		public static void StartIEntityVisibleComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x06023E36 RID: 146998 RVA: 0x004EF112 File Offset: 0x004ED312
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06023E37 RID: 146999 RVA: 0x004EF11D File Offset: 0x004ED31D
		public static void AddDelayChange(FlatBufferBuilder builder, bool delayChange)
		{
			builder.AddBool(1, delayChange, false);
		}

		// Token: 0x06023E38 RID: 147000 RVA: 0x004EF128 File Offset: 0x004ED328
		public static void AddUseFadeEffect(FlatBufferBuilder builder, bool useFadeEffect)
		{
			builder.AddBool(2, useFadeEffect, false);
		}

		// Token: 0x06023E39 RID: 147001 RVA: 0x004EF133 File Offset: 0x004ED333
		public static void AddUseCutEffect(FlatBufferBuilder builder, bool useCutEffect)
		{
			builder.AddBool(3, useCutEffect, false);
		}

		// Token: 0x06023E3A RID: 147002 RVA: 0x004EF13E File Offset: 0x004ED33E
		public static void AddUseHolographicEffect(FlatBufferBuilder builder, bool useHolographicEffect)
		{
			builder.AddBool(4, useHolographicEffect, false);
		}

		// Token: 0x06023E3B RID: 147003 RVA: 0x004EF149 File Offset: 0x004ED349
		public static void AddVisibleConditions(FlatBufferBuilder builder, VectorOffset visibleConditionsOffset)
		{
			builder.AddOffset(5, visibleConditionsOffset.Value, 0);
		}

		// Token: 0x06023E3C RID: 147004 RVA: 0x004EF15C File Offset: 0x004ED35C
		public static VectorOffset CreateVisibleConditionsVector(FlatBufferBuilder builder, Offset<IVisibleConditionGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023E3D RID: 147005 RVA: 0x004EF19C File Offset: 0x004ED39C
		public static VectorOffset CreateVisibleConditionsVectorBlock(FlatBufferBuilder builder, Offset<IVisibleConditionGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IVisibleConditionGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023E3E RID: 147006 RVA: 0x004EF1B6 File Offset: 0x004ED3B6
		public static VectorOffset CreateVisibleConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IVisibleConditionGroup>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IVisibleConditionGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023E3F RID: 147007 RVA: 0x004EF1D4 File Offset: 0x004ED3D4
		public static VectorOffset CreateVisibleConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IVisibleConditionGroup>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023E40 RID: 147008 RVA: 0x004EF1ED File Offset: 0x004ED3ED
		public static void StartVisibleConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023E41 RID: 147009 RVA: 0x004EF1F8 File Offset: 0x004ED3F8
		public static void AddCustomVisibleRange(FlatBufferBuilder builder, int customVisibleRange)
		{
			builder.AddInt(6, customVisibleRange, 0);
		}

		// Token: 0x06023E42 RID: 147010 RVA: 0x004EF203 File Offset: 0x004ED403
		public static void AddTargetPlatform(FlatBufferBuilder builder, ERuntimePlatformOptions targetPlatform)
		{
			builder.AddByte(7, (byte)targetPlatform, 0);
		}

		// Token: 0x06023E43 RID: 147011 RVA: 0x004EF20E File Offset: 0x004ED40E
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x06023E44 RID: 147012 RVA: 0x004EF219 File Offset: 0x004ED419
		public static Offset<IEntityVisibleComponent> EndIEntityVisibleComponent(FlatBufferBuilder builder)
		{
			return new Offset<IEntityVisibleComponent>(builder.EndTable());
		}

		// Token: 0x06023E45 RID: 147013 RVA: 0x004EF228 File Offset: 0x004ED428
		public IEntityVisibleComponentT UnPack()
		{
			IEntityVisibleComponentT entityVisibleComponentT = new IEntityVisibleComponentT();
			this.UnPackTo(entityVisibleComponentT);
			return entityVisibleComponentT;
		}

		// Token: 0x06023E46 RID: 147014 RVA: 0x004EF244 File Offset: 0x004ED444
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

		// Token: 0x06023E47 RID: 147015 RVA: 0x004EF304 File Offset: 0x004ED504
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

		// Token: 0x0400EEBE RID: 61118
		private Table __p;
	}
}
