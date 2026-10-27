using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F01 RID: 20225
	public struct IBeamCastComponent : IFlatbufferObject
	{
		// Token: 0x17009185 RID: 37253
		// (get) Token: 0x0601FF32 RID: 130866 RVA: 0x004724E5 File Offset: 0x004706E5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FF33 RID: 130867 RVA: 0x004724F2 File Offset: 0x004706F2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FF34 RID: 130868 RVA: 0x004724FC File Offset: 0x004706FC
		public static IBeamCastComponent GetRootAsIBeamCastComponent(ByteBuffer _bb)
		{
			return IBeamCastComponent.GetRootAsIBeamCastComponent(_bb, default(IBeamCastComponent));
		}

		// Token: 0x0601FF35 RID: 130869 RVA: 0x00472518 File Offset: 0x00470718
		public static IBeamCastComponent GetRootAsIBeamCastComponent(ByteBuffer _bb, IBeamCastComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FF36 RID: 130870 RVA: 0x00472535 File Offset: 0x00470735
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FF37 RID: 130871 RVA: 0x00472544 File Offset: 0x00470744
		public IBeamCastComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009186 RID: 37254
		// (get) Token: 0x0601FF38 RID: 130872 RVA: 0x00472554 File Offset: 0x00470754
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009187 RID: 37255
		// (get) Token: 0x0601FF39 RID: 130873 RVA: 0x00472594 File Offset: 0x00470794
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

		// Token: 0x0601FF3A RID: 130874 RVA: 0x004725CB File Offset: 0x004707CB
		public Span<byte> GetEffectPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601FF3B RID: 130875 RVA: 0x004725DA File Offset: 0x004707DA
		public byte[] GetEffectPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17009188 RID: 37256
		// (get) Token: 0x0601FF3C RID: 130876 RVA: 0x004725E8 File Offset: 0x004707E8
		public bool DelayDestroyEffect
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009189 RID: 37257
		// (get) Token: 0x0601FF3D RID: 130877 RVA: 0x00472628 File Offset: 0x00470828
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

		// Token: 0x0601FF3E RID: 130878 RVA: 0x00472660 File Offset: 0x00470860
		public Span<byte> GetStartEffectPathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0601FF3F RID: 130879 RVA: 0x00472670 File Offset: 0x00470870
		public byte[] GetStartEffectPathArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700918A RID: 37258
		// (get) Token: 0x0601FF40 RID: 130880 RVA: 0x00472680 File Offset: 0x00470880
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

		// Token: 0x0601FF41 RID: 130881 RVA: 0x004726B8 File Offset: 0x004708B8
		public Span<byte> GetHitEffectPathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0601FF42 RID: 130882 RVA: 0x004726C8 File Offset: 0x004708C8
		public byte[] GetHitEffectPathArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x1700918B RID: 37259
		// (get) Token: 0x0601FF43 RID: 130883 RVA: 0x004726D8 File Offset: 0x004708D8
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

		// Token: 0x1700918C RID: 37260
		// (get) Token: 0x0601FF44 RID: 130884 RVA: 0x00472738 File Offset: 0x00470938
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

		// Token: 0x1700918D RID: 37261
		// (get) Token: 0x0601FF45 RID: 130885 RVA: 0x00472798 File Offset: 0x00470998
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

		// Token: 0x0601FF46 RID: 130886 RVA: 0x004727D0 File Offset: 0x004709D0
		public Span<byte> GetTargetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0601FF47 RID: 130887 RVA: 0x004727E0 File Offset: 0x004709E0
		public byte[] GetTargetStateArray()
		{
			return this.__p.__vector_as_array<byte>(18);
		}

		// Token: 0x1700918E RID: 37262
		// (get) Token: 0x0601FF48 RID: 130888 RVA: 0x004727F0 File Offset: 0x004709F0
		public bool IgnoreMonsterCollision
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700918F RID: 37263
		// (get) Token: 0x0601FF49 RID: 130889 RVA: 0x00472830 File Offset: 0x00470A30
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

		// Token: 0x0601FF4A RID: 130890 RVA: 0x00472890 File Offset: 0x00470A90
		public IActionInfo? TriggerActions(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009190 RID: 37264
		// (get) Token: 0x0601FF4B RID: 130891 RVA: 0x004728F4 File Offset: 0x00470AF4
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

		// Token: 0x17009191 RID: 37265
		// (get) Token: 0x0601FF4C RID: 130892 RVA: 0x00472920 File Offset: 0x00470B20
		public bool DisableDynamicRange
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009192 RID: 37266
		// (get) Token: 0x0601FF4D RID: 130893 RVA: 0x00472960 File Offset: 0x00470B60
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

		// Token: 0x0601FF4E RID: 130894 RVA: 0x004729A0 File Offset: 0x00470BA0
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

		// Token: 0x0601FF4F RID: 130895 RVA: 0x00472A20 File Offset: 0x00470C20
		public static void StartIBeamCastComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(13);
		}

		// Token: 0x0601FF50 RID: 130896 RVA: 0x00472A2A File Offset: 0x00470C2A
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0601FF51 RID: 130897 RVA: 0x00472A35 File Offset: 0x00470C35
		public static void AddEffectPath(FlatBufferBuilder builder, StringOffset effectPathOffset)
		{
			builder.AddOffset(1, effectPathOffset.Value, 0);
		}

		// Token: 0x0601FF52 RID: 130898 RVA: 0x00472A45 File Offset: 0x00470C45
		public static void AddDelayDestroyEffect(FlatBufferBuilder builder, bool delayDestroyEffect)
		{
			builder.AddBool(2, delayDestroyEffect, false);
		}

		// Token: 0x0601FF53 RID: 130899 RVA: 0x00472A50 File Offset: 0x00470C50
		public static void AddStartEffectPath(FlatBufferBuilder builder, StringOffset startEffectPathOffset)
		{
			builder.AddOffset(3, startEffectPathOffset.Value, 0);
		}

		// Token: 0x0601FF54 RID: 130900 RVA: 0x00472A60 File Offset: 0x00470C60
		public static void AddHitEffectPath(FlatBufferBuilder builder, StringOffset hitEffectPathOffset)
		{
			builder.AddOffset(4, hitEffectPathOffset.Value, 0);
		}

		// Token: 0x0601FF55 RID: 130901 RVA: 0x00472A70 File Offset: 0x00470C70
		public static void AddRange(FlatBufferBuilder builder, Offset<ICylinderTriggerShape> rangeOffset)
		{
			builder.AddOffset(5, rangeOffset.Value, 0);
		}

		// Token: 0x0601FF56 RID: 130902 RVA: 0x00472A80 File Offset: 0x00470C80
		public static void AddReflection(FlatBufferBuilder builder, Offset<IBeamReflectionConfig> reflectionOffset)
		{
			builder.AddOffset(6, reflectionOffset.Value, 0);
		}

		// Token: 0x0601FF57 RID: 130903 RVA: 0x00472A90 File Offset: 0x00470C90
		public static void AddTargetState(FlatBufferBuilder builder, StringOffset targetStateOffset)
		{
			builder.AddOffset(7, targetStateOffset.Value, 0);
		}

		// Token: 0x0601FF58 RID: 130904 RVA: 0x00472AA0 File Offset: 0x00470CA0
		public static void AddIgnoreMonsterCollision(FlatBufferBuilder builder, bool ignoreMonsterCollision)
		{
			builder.AddBool(8, ignoreMonsterCollision, false);
		}

		// Token: 0x0601FF59 RID: 130905 RVA: 0x00472AAB File Offset: 0x00470CAB
		public static void AddBeamLayout(FlatBufferBuilder builder, Offset<IBeamLayoutConfigWall> beamLayoutOffset)
		{
			builder.AddOffset(9, beamLayoutOffset.Value, 0);
		}

		// Token: 0x0601FF5A RID: 130906 RVA: 0x00472ABC File Offset: 0x00470CBC
		public static void AddTriggerActions(FlatBufferBuilder builder, VectorOffset triggerActionsOffset)
		{
			builder.AddOffset(10, triggerActionsOffset.Value, 0);
		}

		// Token: 0x0601FF5B RID: 130907 RVA: 0x00472AD0 File Offset: 0x00470CD0
		public static VectorOffset CreateTriggerActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601FF5C RID: 130908 RVA: 0x00472B10 File Offset: 0x00470D10
		public static VectorOffset CreateTriggerActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601FF5D RID: 130909 RVA: 0x00472B2A File Offset: 0x00470D2A
		public static VectorOffset CreateTriggerActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601FF5E RID: 130910 RVA: 0x00472B48 File Offset: 0x00470D48
		public static VectorOffset CreateTriggerActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601FF5F RID: 130911 RVA: 0x00472B61 File Offset: 0x00470D61
		public static void StartTriggerActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601FF60 RID: 130912 RVA: 0x00472B6C File Offset: 0x00470D6C
		public static void AddDisableDynamicRange(FlatBufferBuilder builder, bool disableDynamicRange)
		{
			builder.AddBool(11, disableDynamicRange, false);
		}

		// Token: 0x0601FF61 RID: 130913 RVA: 0x00472B78 File Offset: 0x00470D78
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(12, nullMask, 0);
		}

		// Token: 0x0601FF62 RID: 130914 RVA: 0x00472B84 File Offset: 0x00470D84
		public static Offset<IBeamCastComponent> EndIBeamCastComponent(FlatBufferBuilder builder)
		{
			return new Offset<IBeamCastComponent>(builder.EndTable());
		}

		// Token: 0x0601FF63 RID: 130915 RVA: 0x00472B94 File Offset: 0x00470D94
		public IBeamCastComponentT UnPack()
		{
			IBeamCastComponentT beamCastComponentT = new IBeamCastComponentT();
			this.UnPackTo(beamCastComponentT);
			return beamCastComponentT;
		}

		// Token: 0x0601FF64 RID: 130916 RVA: 0x00472BB0 File Offset: 0x00470DB0
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

		// Token: 0x0601FF65 RID: 130917 RVA: 0x00472D14 File Offset: 0x00470F14
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

		// Token: 0x0400DD39 RID: 56633
		private Table __p;
	}
}
