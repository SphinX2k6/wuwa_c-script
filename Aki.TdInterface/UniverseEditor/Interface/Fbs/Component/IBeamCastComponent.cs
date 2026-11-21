using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005433 RID: 21555
	public struct IBeamCastComponent : IFlatbufferObject
	{
		// Token: 0x17009907 RID: 39175
		// (get) Token: 0x06021CA2 RID: 138402 RVA: 0x004A8879 File Offset: 0x004A6A79
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021CA3 RID: 138403 RVA: 0x004A8886 File Offset: 0x004A6A86
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021CA4 RID: 138404 RVA: 0x004A8890 File Offset: 0x004A6A90
		public static IBeamCastComponent GetRootAsIBeamCastComponent(ByteBuffer _bb)
		{
			return IBeamCastComponent.GetRootAsIBeamCastComponent(_bb, default(IBeamCastComponent));
		}

		// Token: 0x06021CA5 RID: 138405 RVA: 0x004A88AC File Offset: 0x004A6AAC
		public static IBeamCastComponent GetRootAsIBeamCastComponent(ByteBuffer _bb, IBeamCastComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021CA6 RID: 138406 RVA: 0x004A88C9 File Offset: 0x004A6AC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021CA7 RID: 138407 RVA: 0x004A88D8 File Offset: 0x004A6AD8
		public IBeamCastComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009908 RID: 39176
		// (get) Token: 0x06021CA8 RID: 138408 RVA: 0x004A88E8 File Offset: 0x004A6AE8
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009909 RID: 39177
		// (get) Token: 0x06021CA9 RID: 138409 RVA: 0x004A8928 File Offset: 0x004A6B28
		public string EffectPath
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021CAA RID: 138410 RVA: 0x004A895F File Offset: 0x004A6B5F
		public Span<byte> GetEffectPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06021CAB RID: 138411 RVA: 0x004A896E File Offset: 0x004A6B6E
		public byte[] GetEffectPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700990A RID: 39178
		// (get) Token: 0x06021CAC RID: 138412 RVA: 0x004A897C File Offset: 0x004A6B7C
		public bool DelayDestroyEffect
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700990B RID: 39179
		// (get) Token: 0x06021CAD RID: 138413 RVA: 0x004A89BC File Offset: 0x004A6BBC
		public string StartEffectPath
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021CAE RID: 138414 RVA: 0x004A89F4 File Offset: 0x004A6BF4
		public Span<byte> GetStartEffectPathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06021CAF RID: 138415 RVA: 0x004A8A04 File Offset: 0x004A6C04
		public byte[] GetStartEffectPathArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700990C RID: 39180
		// (get) Token: 0x06021CB0 RID: 138416 RVA: 0x004A8A14 File Offset: 0x004A6C14
		public string HitEffectPath
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021CB1 RID: 138417 RVA: 0x004A8A4C File Offset: 0x004A6C4C
		public Span<byte> GetHitEffectPathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06021CB2 RID: 138418 RVA: 0x004A8A5C File Offset: 0x004A6C5C
		public byte[] GetHitEffectPathArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x1700990D RID: 39181
		// (get) Token: 0x06021CB3 RID: 138419 RVA: 0x004A8A6C File Offset: 0x004A6C6C
		public ICylinderTriggerShape? Range
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new ICylinderTriggerShape?(default(ICylinderTriggerShape).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700990E RID: 39182
		// (get) Token: 0x06021CB4 RID: 138420 RVA: 0x004A8ACC File Offset: 0x004A6CCC
		public IBeamReflectionConfig? Reflection
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new IBeamReflectionConfig?(default(IBeamReflectionConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700990F RID: 39183
		// (get) Token: 0x06021CB5 RID: 138421 RVA: 0x004A8B2C File Offset: 0x004A6D2C
		public string TargetState
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021CB6 RID: 138422 RVA: 0x004A8B64 File Offset: 0x004A6D64
		public Span<byte> GetTargetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06021CB7 RID: 138423 RVA: 0x004A8B74 File Offset: 0x004A6D74
		public byte[] GetTargetStateArray()
		{
			return this.__p.__vector_as_array<byte>(18);
		}

		// Token: 0x17009910 RID: 39184
		// (get) Token: 0x06021CB8 RID: 138424 RVA: 0x004A8B84 File Offset: 0x004A6D84
		public bool IgnoreMonsterCollision
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009911 RID: 39185
		// (get) Token: 0x06021CB9 RID: 138425 RVA: 0x004A8BC4 File Offset: 0x004A6DC4
		public IBeamLayoutConfigWall? BeamLayout
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return new IBeamLayoutConfigWall?(default(IBeamLayoutConfigWall).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06021CBA RID: 138426 RVA: 0x004A8C24 File Offset: 0x004A6E24
		public IActionInfo? TriggerActions(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009912 RID: 39186
		// (get) Token: 0x06021CBB RID: 138427 RVA: 0x004A8C88 File Offset: 0x004A6E88
		public int TriggerActionsLength
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17009913 RID: 39187
		// (get) Token: 0x06021CBC RID: 138428 RVA: 0x004A8CB4 File Offset: 0x004A6EB4
		public bool DisableDynamicRange
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009914 RID: 39188
		// (get) Token: 0x06021CBD RID: 138429 RVA: 0x004A8CF4 File Offset: 0x004A6EF4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021CBE RID: 138430 RVA: 0x004A8D34 File Offset: 0x004A6F34
		public static Offset<IBeamCastComponent> CreateIBeamCastComponent(FlatBufferBuilder builder, bool Disabled = false, StringOffset EffectPathOffset = default(StringOffset), bool DelayDestroyEffect = false, StringOffset StartEffectPathOffset = default(StringOffset), StringOffset HitEffectPathOffset = default(StringOffset), Offset<ICylinderTriggerShape> RangeOffset = default(Offset<ICylinderTriggerShape>), Offset<IBeamReflectionConfig> ReflectionOffset = default(Offset<IBeamReflectionConfig>), StringOffset TargetStateOffset = default(StringOffset), bool IgnoreMonsterCollision = false, Offset<IBeamLayoutConfigWall> BeamLayoutOffset = default(Offset<IBeamLayoutConfigWall>), VectorOffset TriggerActionsOffset = default(VectorOffset), bool DisableDynamicRange = false, byte NullMask = 0)
		{
			builder.StartTable(13);
			IBeamCastComponent.AddTriggerActions(builder, TriggerActionsOffset);
			IBeamCastComponent.AddBeamLayout(builder, BeamLayoutOffset);
			IBeamCastComponent.AddTargetState(builder, TargetStateOffset);
			IBeamCastComponent.AddReflection(builder, ReflectionOffset);
			IBeamCastComponent.AddRange(builder, RangeOffset);
			IBeamCastComponent.AddHitEffectPath(builder, HitEffectPathOffset);
			IBeamCastComponent.AddStartEffectPath(builder, StartEffectPathOffset);
			IBeamCastComponent.AddEffectPath(builder, EffectPathOffset);
			IBeamCastComponent.AddNullMask(builder, NullMask);
			IBeamCastComponent.AddDisableDynamicRange(builder, DisableDynamicRange);
			IBeamCastComponent.AddIgnoreMonsterCollision(builder, IgnoreMonsterCollision);
			IBeamCastComponent.AddDelayDestroyEffect(builder, DelayDestroyEffect);
			IBeamCastComponent.AddDisabled(builder, Disabled);
			return IBeamCastComponent.EndIBeamCastComponent(builder);
		}

		// Token: 0x06021CBF RID: 138431 RVA: 0x004A8DB4 File Offset: 0x004A6FB4
		public static void StartIBeamCastComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(13);
		}

		// Token: 0x06021CC0 RID: 138432 RVA: 0x004A8DBE File Offset: 0x004A6FBE
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06021CC1 RID: 138433 RVA: 0x004A8DC9 File Offset: 0x004A6FC9
		public static void AddEffectPath(FlatBufferBuilder builder, StringOffset effectPathOffset)
		{
			builder.AddOffset(1, effectPathOffset.Value, 0);
		}

		// Token: 0x06021CC2 RID: 138434 RVA: 0x004A8DD9 File Offset: 0x004A6FD9
		public static void AddDelayDestroyEffect(FlatBufferBuilder builder, bool delayDestroyEffect)
		{
			builder.AddBool(2, delayDestroyEffect, false);
		}

		// Token: 0x06021CC3 RID: 138435 RVA: 0x004A8DE4 File Offset: 0x004A6FE4
		public static void AddStartEffectPath(FlatBufferBuilder builder, StringOffset startEffectPathOffset)
		{
			builder.AddOffset(3, startEffectPathOffset.Value, 0);
		}

		// Token: 0x06021CC4 RID: 138436 RVA: 0x004A8DF4 File Offset: 0x004A6FF4
		public static void AddHitEffectPath(FlatBufferBuilder builder, StringOffset hitEffectPathOffset)
		{
			builder.AddOffset(4, hitEffectPathOffset.Value, 0);
		}

		// Token: 0x06021CC5 RID: 138437 RVA: 0x004A8E04 File Offset: 0x004A7004
		public static void AddRange(FlatBufferBuilder builder, Offset<ICylinderTriggerShape> rangeOffset)
		{
			builder.AddOffset(5, rangeOffset.Value, 0);
		}

		// Token: 0x06021CC6 RID: 138438 RVA: 0x004A8E14 File Offset: 0x004A7014
		public static void AddReflection(FlatBufferBuilder builder, Offset<IBeamReflectionConfig> reflectionOffset)
		{
			builder.AddOffset(6, reflectionOffset.Value, 0);
		}

		// Token: 0x06021CC7 RID: 138439 RVA: 0x004A8E24 File Offset: 0x004A7024
		public static void AddTargetState(FlatBufferBuilder builder, StringOffset targetStateOffset)
		{
			builder.AddOffset(7, targetStateOffset.Value, 0);
		}

		// Token: 0x06021CC8 RID: 138440 RVA: 0x004A8E34 File Offset: 0x004A7034
		public static void AddIgnoreMonsterCollision(FlatBufferBuilder builder, bool ignoreMonsterCollision)
		{
			builder.AddBool(8, ignoreMonsterCollision, false);
		}

		// Token: 0x06021CC9 RID: 138441 RVA: 0x004A8E3F File Offset: 0x004A703F
		public static void AddBeamLayout(FlatBufferBuilder builder, Offset<IBeamLayoutConfigWall> beamLayoutOffset)
		{
			builder.AddOffset(9, beamLayoutOffset.Value, 0);
		}

		// Token: 0x06021CCA RID: 138442 RVA: 0x004A8E50 File Offset: 0x004A7050
		public static void AddTriggerActions(FlatBufferBuilder builder, VectorOffset triggerActionsOffset)
		{
			builder.AddOffset(10, triggerActionsOffset.Value, 0);
		}

		// Token: 0x06021CCB RID: 138443 RVA: 0x004A8E64 File Offset: 0x004A7064
		public static VectorOffset CreateTriggerActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06021CCC RID: 138444 RVA: 0x004A8EA4 File Offset: 0x004A70A4
		public static VectorOffset CreateTriggerActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021CCD RID: 138445 RVA: 0x004A8EBE File Offset: 0x004A70BE
		public static VectorOffset CreateTriggerActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021CCE RID: 138446 RVA: 0x004A8EDC File Offset: 0x004A70DC
		public static VectorOffset CreateTriggerActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021CCF RID: 138447 RVA: 0x004A8EF5 File Offset: 0x004A70F5
		public static void StartTriggerActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021CD0 RID: 138448 RVA: 0x004A8F00 File Offset: 0x004A7100
		public static void AddDisableDynamicRange(FlatBufferBuilder builder, bool disableDynamicRange)
		{
			builder.AddBool(11, disableDynamicRange, false);
		}

		// Token: 0x06021CD1 RID: 138449 RVA: 0x004A8F0C File Offset: 0x004A710C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(12, nullMask, 0);
		}

		// Token: 0x06021CD2 RID: 138450 RVA: 0x004A8F18 File Offset: 0x004A7118
		public static Offset<IBeamCastComponent> EndIBeamCastComponent(FlatBufferBuilder builder)
		{
			return new Offset<IBeamCastComponent>(builder.EndTable());
		}

		// Token: 0x06021CD3 RID: 138451 RVA: 0x004A8F28 File Offset: 0x004A7128
		public IBeamCastComponentT UnPack()
		{
			IBeamCastComponentT beamCastComponentT = new IBeamCastComponentT();
			this.UnPackTo(beamCastComponentT);
			return beamCastComponentT;
		}

		// Token: 0x06021CD4 RID: 138452 RVA: 0x004A8F44 File Offset: 0x004A7144
		public void UnPackTo(IBeamCastComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.EffectPath = this.EffectPath;
			_o.DelayDestroyEffect = this.DelayDestroyEffect;
			_o.StartEffectPath = this.StartEffectPath;
			_o.HitEffectPath = this.HitEffectPath;
			_o.Range = ((this.Range != null) ? this.Range.Value.UnPack() : null);
			_o.Reflection = ((this.Reflection != null) ? this.Reflection.Value.UnPack() : null);
			_o.TargetState = this.TargetState;
			_o.IgnoreMonsterCollision = this.IgnoreMonsterCollision;
			_o.BeamLayout = ((this.BeamLayout != null) ? this.BeamLayout.Value.UnPack() : null);
			_o.TriggerActions = new List<IActionInfoT>();
			for (int i = 0; i < this.TriggerActionsLength; i++)
			{
				_o.TriggerActions.Add((this.TriggerActions(i) != null) ? this.TriggerActions(i).Value.UnPack() : null);
			}
			_o.DisableDynamicRange = this.DisableDynamicRange;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06021CD5 RID: 138453 RVA: 0x004A90A8 File Offset: 0x004A72A8
		public static Offset<IBeamCastComponent> Pack(FlatBufferBuilder builder, IBeamCastComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBeamCastComponent>);
			}
			StringOffset effectPathOffset = (_o.EffectPath == null) ? default(StringOffset) : builder.CreateString(_o.EffectPath);
			StringOffset startEffectPathOffset = (_o.StartEffectPath == null) ? default(StringOffset) : builder.CreateString(_o.StartEffectPath);
			StringOffset hitEffectPathOffset = (_o.HitEffectPath == null) ? default(StringOffset) : builder.CreateString(_o.HitEffectPath);
			Offset<ICylinderTriggerShape> rangeOffset = (_o.Range == null) ? default(Offset<ICylinderTriggerShape>) : ICylinderTriggerShape.Pack(builder, _o.Range);
			Offset<IBeamReflectionConfig> reflectionOffset = (_o.Reflection == null) ? default(Offset<IBeamReflectionConfig>) : IBeamReflectionConfig.Pack(builder, _o.Reflection);
			StringOffset targetStateOffset = (_o.TargetState == null) ? default(StringOffset) : builder.CreateString(_o.TargetState);
			Offset<IBeamLayoutConfigWall> beamLayoutOffset = (_o.BeamLayout == null) ? default(Offset<IBeamLayoutConfigWall>) : IBeamLayoutConfigWall.Pack(builder, _o.BeamLayout);
			VectorOffset triggerActionsOffset = default(VectorOffset);
			if (_o.TriggerActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.TriggerActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.TriggerActions[i]);
				}
				triggerActionsOffset = IBeamCastComponent.CreateTriggerActionsVector(builder, array);
			}
			return IBeamCastComponent.CreateIBeamCastComponent(builder, _o.Disabled, effectPathOffset, _o.DelayDestroyEffect, startEffectPathOffset, hitEffectPathOffset, rangeOffset, reflectionOffset, targetStateOffset, _o.IgnoreMonsterCollision, beamLayoutOffset, triggerActionsOffset, _o.DisableDynamicRange, _o.NullMask);
		}

		// Token: 0x0400E8E8 RID: 59624
		private Table __p;
	}
}
