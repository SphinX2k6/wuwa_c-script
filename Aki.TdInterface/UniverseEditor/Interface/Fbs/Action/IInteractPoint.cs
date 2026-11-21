using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200704C RID: 28748
	public struct IInteractPoint : IFlatbufferObject
	{
		// Token: 0x1700D290 RID: 53904
		// (get) Token: 0x06031D7F RID: 204159 RVA: 0x006BF5F9 File Offset: 0x006BD7F9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031D80 RID: 204160 RVA: 0x006BF606 File Offset: 0x006BD806
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031D81 RID: 204161 RVA: 0x006BF610 File Offset: 0x006BD810
		public static IInteractPoint GetRootAsIInteractPoint(ByteBuffer _bb)
		{
			return IInteractPoint.GetRootAsIInteractPoint(_bb, default(IInteractPoint));
		}

		// Token: 0x06031D82 RID: 204162 RVA: 0x006BF62C File Offset: 0x006BD82C
		public static IInteractPoint GetRootAsIInteractPoint(ByteBuffer _bb, IInteractPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031D83 RID: 204163 RVA: 0x006BF649 File Offset: 0x006BD849
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031D84 RID: 204164 RVA: 0x006BF658 File Offset: 0x006BD858
		public IInteractPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D291 RID: 53905
		// (get) Token: 0x06031D85 RID: 204165 RVA: 0x006BF668 File Offset: 0x006BD868
		public int Tag
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031D86 RID: 204166 RVA: 0x006BF6A4 File Offset: 0x006BD8A4
		public TInteractEffect InteractEffectsType(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return TInteractEffect.NONE;
			}
			return (TInteractEffect)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700D292 RID: 53906
		// (get) Token: 0x06031D87 RID: 204167 RVA: 0x006BF6E4 File Offset: 0x006BD8E4
		public int InteractEffectsTypeLength
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

		// Token: 0x06031D88 RID: 204168 RVA: 0x006BF70F File Offset: 0x006BD90F
		public Span<TInteractEffect> GetInteractEffectsTypeBytes()
		{
			return this.__p.__vector_as_span<TInteractEffect>(6, 1);
		}

		// Token: 0x06031D89 RID: 204169 RVA: 0x006BF720 File Offset: 0x006BD920
		public TInteractEffect[] GetInteractEffectsTypeArray()
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TInteractEffect[] array = new TInteractEffect[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TInteractEffect)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x06031D8A RID: 204170 RVA: 0x006BF78C File Offset: 0x006BD98C
		public TTable? InteractEffects<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700D293 RID: 53907
		// (get) Token: 0x06031D8B RID: 204171 RVA: 0x006BF7D4 File Offset: 0x006BD9D4
		public int InteractEffectsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700D294 RID: 53908
		// (get) Token: 0x06031D8C RID: 204172 RVA: 0x006BF800 File Offset: 0x006BDA00
		public bool IsValidPoint
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D295 RID: 53909
		// (get) Token: 0x06031D8D RID: 204173 RVA: 0x006BF840 File Offset: 0x006BDA40
		public float ProtectTime
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D296 RID: 53910
		// (get) Token: 0x06031D8E RID: 204174 RVA: 0x006BF884 File Offset: 0x006BDA84
		public bool CancelRaycast
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D297 RID: 53911
		// (get) Token: 0x06031D8F RID: 204175 RVA: 0x006BF8C4 File Offset: 0x006BDAC4
		public IDragInteractPointInteraction? InteractionConfig
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new IDragInteractPointInteraction?(default(IDragInteractPointInteraction).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D298 RID: 53912
		// (get) Token: 0x06031D90 RID: 204176 RVA: 0x006BF924 File Offset: 0x006BDB24
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031D91 RID: 204177 RVA: 0x006BF964 File Offset: 0x006BDB64
		public static Offset<IInteractPoint> CreateIInteractPoint(FlatBufferBuilder builder, int Tag = 0, VectorOffset InteractEffects_typeOffset = default(VectorOffset), VectorOffset InteractEffectsOffset = default(VectorOffset), bool IsValidPoint = false, float ProtectTime = 0f, bool CancelRaycast = false, Offset<IDragInteractPointInteraction> InteractionConfigOffset = default(Offset<IDragInteractPointInteraction>), byte NullMask = 0)
		{
			builder.StartTable(8);
			IInteractPoint.AddInteractionConfig(builder, InteractionConfigOffset);
			IInteractPoint.AddProtectTime(builder, ProtectTime);
			IInteractPoint.AddInteractEffects(builder, InteractEffectsOffset);
			IInteractPoint.AddInteractEffectsType(builder, InteractEffects_typeOffset);
			IInteractPoint.AddTag(builder, Tag);
			IInteractPoint.AddNullMask(builder, NullMask);
			IInteractPoint.AddCancelRaycast(builder, CancelRaycast);
			IInteractPoint.AddIsValidPoint(builder, IsValidPoint);
			return IInteractPoint.EndIInteractPoint(builder);
		}

		// Token: 0x06031D92 RID: 204178 RVA: 0x006BF9BB File Offset: 0x006BDBBB
		public static void StartIInteractPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06031D93 RID: 204179 RVA: 0x006BF9C4 File Offset: 0x006BDBC4
		public static void AddTag(FlatBufferBuilder builder, int tag)
		{
			builder.AddInt(0, tag, 0);
		}

		// Token: 0x06031D94 RID: 204180 RVA: 0x006BF9CF File Offset: 0x006BDBCF
		public static void AddInteractEffectsType(FlatBufferBuilder builder, VectorOffset interactEffectsTypeOffset)
		{
			builder.AddOffset(1, interactEffectsTypeOffset.Value, 0);
		}

		// Token: 0x06031D95 RID: 204181 RVA: 0x006BF9E0 File Offset: 0x006BDBE0
		public static VectorOffset CreateInteractEffectsTypeVector(FlatBufferBuilder builder, TInteractEffect[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06031D96 RID: 204182 RVA: 0x006BFA17 File Offset: 0x006BDC17
		public static VectorOffset CreateInteractEffectsTypeVectorBlock(FlatBufferBuilder builder, TInteractEffect[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TInteractEffect>(data);
			return builder.EndVector();
		}

		// Token: 0x06031D97 RID: 204183 RVA: 0x006BFA31 File Offset: 0x006BDC31
		public static VectorOffset CreateInteractEffectsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TInteractEffect> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TInteractEffect>(data);
			return builder.EndVector();
		}

		// Token: 0x06031D98 RID: 204184 RVA: 0x006BFA4F File Offset: 0x006BDC4F
		public static VectorOffset CreateInteractEffectsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TInteractEffect>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06031D99 RID: 204185 RVA: 0x006BFA68 File Offset: 0x006BDC68
		public static void StartInteractEffectsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06031D9A RID: 204186 RVA: 0x006BFA73 File Offset: 0x006BDC73
		public static void AddInteractEffects(FlatBufferBuilder builder, VectorOffset interactEffectsOffset)
		{
			builder.AddOffset(2, interactEffectsOffset.Value, 0);
		}

		// Token: 0x06031D9B RID: 204187 RVA: 0x006BFA84 File Offset: 0x006BDC84
		public static VectorOffset CreateInteractEffectsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06031D9C RID: 204188 RVA: 0x006BFABB File Offset: 0x006BDCBB
		public static VectorOffset CreateInteractEffectsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06031D9D RID: 204189 RVA: 0x006BFAD5 File Offset: 0x006BDCD5
		public static VectorOffset CreateInteractEffectsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06031D9E RID: 204190 RVA: 0x006BFAF3 File Offset: 0x006BDCF3
		public static VectorOffset CreateInteractEffectsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06031D9F RID: 204191 RVA: 0x006BFB0C File Offset: 0x006BDD0C
		public static void StartInteractEffectsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06031DA0 RID: 204192 RVA: 0x006BFB17 File Offset: 0x006BDD17
		public static void AddIsValidPoint(FlatBufferBuilder builder, bool isValidPoint)
		{
			builder.AddBool(3, isValidPoint, false);
		}

		// Token: 0x06031DA1 RID: 204193 RVA: 0x006BFB22 File Offset: 0x006BDD22
		public static void AddProtectTime(FlatBufferBuilder builder, float protectTime)
		{
			builder.AddFloat(4, protectTime, 0.0);
		}

		// Token: 0x06031DA2 RID: 204194 RVA: 0x006BFB35 File Offset: 0x006BDD35
		public static void AddCancelRaycast(FlatBufferBuilder builder, bool cancelRaycast)
		{
			builder.AddBool(5, cancelRaycast, false);
		}

		// Token: 0x06031DA3 RID: 204195 RVA: 0x006BFB40 File Offset: 0x006BDD40
		public static void AddInteractionConfig(FlatBufferBuilder builder, Offset<IDragInteractPointInteraction> interactionConfigOffset)
		{
			builder.AddOffset(6, interactionConfigOffset.Value, 0);
		}

		// Token: 0x06031DA4 RID: 204196 RVA: 0x006BFB50 File Offset: 0x006BDD50
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06031DA5 RID: 204197 RVA: 0x006BFB5B File Offset: 0x006BDD5B
		public static Offset<IInteractPoint> EndIInteractPoint(FlatBufferBuilder builder)
		{
			return new Offset<IInteractPoint>(builder.EndTable());
		}

		// Token: 0x06031DA6 RID: 204198 RVA: 0x006BFB68 File Offset: 0x006BDD68
		public IInteractPointT UnPack()
		{
			IInteractPointT interactPointT = new IInteractPointT();
			this.UnPackTo(interactPointT);
			return interactPointT;
		}

		// Token: 0x06031DA7 RID: 204199 RVA: 0x006BFB84 File Offset: 0x006BDD84
		public void UnPackTo(IInteractPointT _o)
		{
			_o.Tag = this.Tag;
			_o.InteractEffects = new List<TInteractEffectUnion>();
			for (int i = 0; i < this.InteractEffectsLength; i++)
			{
				TInteractEffectUnion tinteractEffectUnion = new TInteractEffectUnion();
				tinteractEffectUnion.Type = this.InteractEffectsType(i);
				switch (this.InteractEffectsType(i))
				{
				case TInteractEffect.IExecuteTag:
					tinteractEffectUnion.Value = ((this.InteractEffects<IExecuteTag>(i) != null) ? this.InteractEffects<IExecuteTag>(i).Value.UnPack() : null);
					break;
				case TInteractEffect.IModifyTipText:
					tinteractEffectUnion.Value = ((this.InteractEffects<IModifyTipText>(i) != null) ? this.InteractEffects<IModifyTipText>(i).Value.UnPack() : null);
					break;
				case TInteractEffect.ITriggerDialogues:
					tinteractEffectUnion.Value = ((this.InteractEffects<ITriggerDialogues>(i) != null) ? this.InteractEffects<ITriggerDialogues>(i).Value.UnPack() : null);
					break;
				case TInteractEffect.ITriggerVoiceDialogues:
					tinteractEffectUnion.Value = ((this.InteractEffects<ITriggerVoiceDialogues>(i) != null) ? this.InteractEffects<ITriggerVoiceDialogues>(i).Value.UnPack() : null);
					break;
				}
				_o.InteractEffects.Add(tinteractEffectUnion);
			}
			_o.IsValidPoint = this.IsValidPoint;
			_o.ProtectTime = this.ProtectTime;
			_o.CancelRaycast = this.CancelRaycast;
			_o.InteractionConfig = ((this.InteractionConfig != null) ? this.InteractionConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06031DA8 RID: 204200 RVA: 0x006BFD3C File Offset: 0x006BDF3C
		public static Offset<IInteractPoint> Pack(FlatBufferBuilder builder, IInteractPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInteractPoint>);
			}
			VectorOffset interactEffects_typeOffset = default(VectorOffset);
			if (_o.InteractEffects != null)
			{
				TInteractEffect[] array = new TInteractEffect[_o.InteractEffects.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.InteractEffects[i].Type;
				}
				interactEffects_typeOffset = IInteractPoint.CreateInteractEffectsTypeVector(builder, array);
			}
			VectorOffset interactEffectsOffset = default(VectorOffset);
			if (_o.InteractEffects != null)
			{
				int[] array2 = new int[_o.InteractEffects.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TInteractEffectUnion.Pack(builder, _o.InteractEffects[j]);
				}
				interactEffectsOffset = IInteractPoint.CreateInteractEffectsVector(builder, array2);
			}
			Offset<IDragInteractPointInteraction> interactionConfigOffset = (_o.InteractionConfig == null) ? default(Offset<IDragInteractPointInteraction>) : IDragInteractPointInteraction.Pack(builder, _o.InteractionConfig);
			return IInteractPoint.CreateIInteractPoint(builder, _o.Tag, interactEffects_typeOffset, interactEffectsOffset, _o.IsValidPoint, _o.ProtectTime, _o.CancelRaycast, interactionConfigOffset, _o.NullMask);
		}

		// Token: 0x04011FA5 RID: 73637
		private Table __p;
	}
}
