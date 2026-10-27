using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E71 RID: 20081
	public struct IAiAlertNotifyComponent : IFlatbufferObject
	{
		// Token: 0x17008FC6 RID: 36806
		// (get) Token: 0x0601F8AE RID: 129198 RVA: 0x0046491B File Offset: 0x00462B1B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F8AF RID: 129199 RVA: 0x00464928 File Offset: 0x00462B28
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F8B0 RID: 129200 RVA: 0x00464930 File Offset: 0x00462B30
		public static IAiAlertNotifyComponent GetRootAsIAiAlertNotifyComponent(ByteBuffer _bb)
		{
			return IAiAlertNotifyComponent.GetRootAsIAiAlertNotifyComponent(_bb, default(IAiAlertNotifyComponent));
		}

		// Token: 0x0601F8B1 RID: 129201 RVA: 0x0046494C File Offset: 0x00462B4C
		public static IAiAlertNotifyComponent GetRootAsIAiAlertNotifyComponent(ByteBuffer _bb, IAiAlertNotifyComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F8B2 RID: 129202 RVA: 0x00464969 File Offset: 0x00462B69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F8B3 RID: 129203 RVA: 0x00464978 File Offset: 0x00462B78
		public IAiAlertNotifyComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008FC7 RID: 36807
		// (get) Token: 0x0601F8B4 RID: 129204 RVA: 0x00464988 File Offset: 0x00462B88
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008FC8 RID: 36808
		// (get) Token: 0x0601F8B5 RID: 129205 RVA: 0x004649C8 File Offset: 0x00462BC8
		public IExtraAiAlert? ExtraAiAlert
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IExtraAiAlert?(default(IExtraAiAlert).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601F8B6 RID: 129206 RVA: 0x00464A28 File Offset: 0x00462C28
		public int ExcludeEntities(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008FC9 RID: 36809
		// (get) Token: 0x0601F8B7 RID: 129207 RVA: 0x00464A68 File Offset: 0x00462C68
		public int ExcludeEntitiesLength
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

		// Token: 0x0601F8B8 RID: 129208 RVA: 0x00464A93 File Offset: 0x00462C93
		public Span<int> GetExcludeEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0601F8B9 RID: 129209 RVA: 0x00464AA2 File Offset: 0x00462CA2
		public int[] GetExcludeEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x17008FCA RID: 36810
		// (get) Token: 0x0601F8BA RID: 129210 RVA: 0x00464AB0 File Offset: 0x00462CB0
		public string AlertSound
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

		// Token: 0x0601F8BB RID: 129211 RVA: 0x00464AE8 File Offset: 0x00462CE8
		public Span<byte> GetAlertSoundBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0601F8BC RID: 129212 RVA: 0x00464AF8 File Offset: 0x00462CF8
		public byte[] GetAlertSoundArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x17008FCB RID: 36811
		// (get) Token: 0x0601F8BD RID: 129213 RVA: 0x00464B08 File Offset: 0x00462D08
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

		// Token: 0x0601F8BE RID: 129214 RVA: 0x00464B45 File Offset: 0x00462D45
		public static Offset<IAiAlertNotifyComponent> CreateIAiAlertNotifyComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<IExtraAiAlert> ExtraAiAlertOffset = default(Offset<IExtraAiAlert>), VectorOffset ExcludeEntitiesOffset = default(VectorOffset), StringOffset AlertSoundOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(5);
			IAiAlertNotifyComponent.AddAlertSound(builder, AlertSoundOffset);
			IAiAlertNotifyComponent.AddExcludeEntities(builder, ExcludeEntitiesOffset);
			IAiAlertNotifyComponent.AddExtraAiAlert(builder, ExtraAiAlertOffset);
			IAiAlertNotifyComponent.AddNullMask(builder, NullMask);
			IAiAlertNotifyComponent.AddDisabled(builder, Disabled);
			return IAiAlertNotifyComponent.EndIAiAlertNotifyComponent(builder);
		}

		// Token: 0x0601F8BF RID: 129215 RVA: 0x00464B79 File Offset: 0x00462D79
		public static void StartIAiAlertNotifyComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601F8C0 RID: 129216 RVA: 0x00464B82 File Offset: 0x00462D82
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0601F8C1 RID: 129217 RVA: 0x00464B8D File Offset: 0x00462D8D
		public static void AddExtraAiAlert(FlatBufferBuilder builder, Offset<IExtraAiAlert> extraAiAlertOffset)
		{
			builder.AddOffset(1, extraAiAlertOffset.Value, 0);
		}

		// Token: 0x0601F8C2 RID: 129218 RVA: 0x00464B9D File Offset: 0x00462D9D
		public static void AddExcludeEntities(FlatBufferBuilder builder, VectorOffset excludeEntitiesOffset)
		{
			builder.AddOffset(2, excludeEntitiesOffset.Value, 0);
		}

		// Token: 0x0601F8C3 RID: 129219 RVA: 0x00464BB0 File Offset: 0x00462DB0
		public static VectorOffset CreateExcludeEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601F8C4 RID: 129220 RVA: 0x00464BE7 File Offset: 0x00462DE7
		public static VectorOffset CreateExcludeEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601F8C5 RID: 129221 RVA: 0x00464C01 File Offset: 0x00462E01
		public static VectorOffset CreateExcludeEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601F8C6 RID: 129222 RVA: 0x00464C1F File Offset: 0x00462E1F
		public static VectorOffset CreateExcludeEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601F8C7 RID: 129223 RVA: 0x00464C38 File Offset: 0x00462E38
		public static void StartExcludeEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601F8C8 RID: 129224 RVA: 0x00464C43 File Offset: 0x00462E43
		public static void AddAlertSound(FlatBufferBuilder builder, StringOffset alertSoundOffset)
		{
			builder.AddOffset(3, alertSoundOffset.Value, 0);
		}

		// Token: 0x0601F8C9 RID: 129225 RVA: 0x00464C53 File Offset: 0x00462E53
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0601F8CA RID: 129226 RVA: 0x00464C5E File Offset: 0x00462E5E
		public static Offset<IAiAlertNotifyComponent> EndIAiAlertNotifyComponent(FlatBufferBuilder builder)
		{
			return new Offset<IAiAlertNotifyComponent>(builder.EndTable());
		}

		// Token: 0x0601F8CB RID: 129227 RVA: 0x00464C6C File Offset: 0x00462E6C
		public IAiAlertNotifyComponentT UnPack()
		{
			IAiAlertNotifyComponentT aiAlertNotifyComponentT = new IAiAlertNotifyComponentT();
			this.UnPackTo(aiAlertNotifyComponentT);
			return aiAlertNotifyComponentT;
		}

		// Token: 0x0601F8CC RID: 129228 RVA: 0x00464C88 File Offset: 0x00462E88
		public void UnPackTo(IAiAlertNotifyComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.ExtraAiAlert = ((this.ExtraAiAlert != null) ? this.ExtraAiAlert.Value.UnPack() : null);
			_o.ExcludeEntities = new List<int>();
			for (int i = 0; i < this.ExcludeEntitiesLength; i++)
			{
				_o.ExcludeEntities.Add(this.ExcludeEntities(i));
			}
			_o.AlertSound = this.AlertSound;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601F8CD RID: 129229 RVA: 0x00464D18 File Offset: 0x00462F18
		public static Offset<IAiAlertNotifyComponent> Pack(FlatBufferBuilder builder, IAiAlertNotifyComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAiAlertNotifyComponent>);
			}
			Offset<IExtraAiAlert> extraAiAlertOffset = (_o.ExtraAiAlert == null) ? default(Offset<IExtraAiAlert>) : IExtraAiAlert.Pack(builder, _o.ExtraAiAlert);
			VectorOffset excludeEntitiesOffset = default(VectorOffset);
			if (_o.ExcludeEntities != null)
			{
				int[] data = _o.ExcludeEntities.ToArray();
				excludeEntitiesOffset = IAiAlertNotifyComponent.CreateExcludeEntitiesVector(builder, data);
			}
			StringOffset alertSoundOffset = (_o.AlertSound == null) ? default(StringOffset) : builder.CreateString(_o.AlertSound);
			return IAiAlertNotifyComponent.CreateIAiAlertNotifyComponent(builder, _o.Disabled, extraAiAlertOffset, excludeEntitiesOffset, alertSoundOffset, _o.NullMask);
		}

		// Token: 0x0400DC1E RID: 56350
		private Table __p;
	}
}
