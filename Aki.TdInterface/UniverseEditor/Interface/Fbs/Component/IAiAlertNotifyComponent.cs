using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005382 RID: 21378
	public struct IAiAlertNotifyComponent : IFlatbufferObject
	{
		// Token: 0x170096FF RID: 38655
		// (get) Token: 0x060214F9 RID: 136441 RVA: 0x00498933 File Offset: 0x00496B33
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060214FA RID: 136442 RVA: 0x00498940 File Offset: 0x00496B40
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060214FB RID: 136443 RVA: 0x00498948 File Offset: 0x00496B48
		public static IAiAlertNotifyComponent GetRootAsIAiAlertNotifyComponent(ByteBuffer _bb)
		{
			return IAiAlertNotifyComponent.GetRootAsIAiAlertNotifyComponent(_bb, default(IAiAlertNotifyComponent));
		}

		// Token: 0x060214FC RID: 136444 RVA: 0x00498964 File Offset: 0x00496B64
		public static IAiAlertNotifyComponent GetRootAsIAiAlertNotifyComponent(ByteBuffer _bb, IAiAlertNotifyComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060214FD RID: 136445 RVA: 0x00498981 File Offset: 0x00496B81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060214FE RID: 136446 RVA: 0x00498990 File Offset: 0x00496B90
		public IAiAlertNotifyComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009700 RID: 38656
		// (get) Token: 0x060214FF RID: 136447 RVA: 0x004989A0 File Offset: 0x00496BA0
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009701 RID: 38657
		// (get) Token: 0x06021500 RID: 136448 RVA: 0x004989E0 File Offset: 0x00496BE0
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

		// Token: 0x06021501 RID: 136449 RVA: 0x00498A40 File Offset: 0x00496C40
		public int ExcludeEntities(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17009702 RID: 38658
		// (get) Token: 0x06021502 RID: 136450 RVA: 0x00498A80 File Offset: 0x00496C80
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

		// Token: 0x06021503 RID: 136451 RVA: 0x00498AAB File Offset: 0x00496CAB
		public Span<int> GetExcludeEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06021504 RID: 136452 RVA: 0x00498ABA File Offset: 0x00496CBA
		public int[] GetExcludeEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x17009703 RID: 38659
		// (get) Token: 0x06021505 RID: 136453 RVA: 0x00498AC8 File Offset: 0x00496CC8
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

		// Token: 0x06021506 RID: 136454 RVA: 0x00498B00 File Offset: 0x00496D00
		public Span<byte> GetAlertSoundBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06021507 RID: 136455 RVA: 0x00498B10 File Offset: 0x00496D10
		public byte[] GetAlertSoundArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x17009704 RID: 38660
		// (get) Token: 0x06021508 RID: 136456 RVA: 0x00498B20 File Offset: 0x00496D20
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

		// Token: 0x06021509 RID: 136457 RVA: 0x00498B5D File Offset: 0x00496D5D
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

		// Token: 0x0602150A RID: 136458 RVA: 0x00498B91 File Offset: 0x00496D91
		public static void StartIAiAlertNotifyComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602150B RID: 136459 RVA: 0x00498B9A File Offset: 0x00496D9A
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602150C RID: 136460 RVA: 0x00498BA5 File Offset: 0x00496DA5
		public static void AddExtraAiAlert(FlatBufferBuilder builder, Offset<IExtraAiAlert> extraAiAlertOffset)
		{
			builder.AddOffset(1, extraAiAlertOffset.Value, 0);
		}

		// Token: 0x0602150D RID: 136461 RVA: 0x00498BB5 File Offset: 0x00496DB5
		public static void AddExcludeEntities(FlatBufferBuilder builder, VectorOffset excludeEntitiesOffset)
		{
			builder.AddOffset(2, excludeEntitiesOffset.Value, 0);
		}

		// Token: 0x0602150E RID: 136462 RVA: 0x00498BC8 File Offset: 0x00496DC8
		public static VectorOffset CreateExcludeEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602150F RID: 136463 RVA: 0x00498BFF File Offset: 0x00496DFF
		public static VectorOffset CreateExcludeEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06021510 RID: 136464 RVA: 0x00498C19 File Offset: 0x00496E19
		public static VectorOffset CreateExcludeEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06021511 RID: 136465 RVA: 0x00498C37 File Offset: 0x00496E37
		public static VectorOffset CreateExcludeEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021512 RID: 136466 RVA: 0x00498C50 File Offset: 0x00496E50
		public static void StartExcludeEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021513 RID: 136467 RVA: 0x00498C5B File Offset: 0x00496E5B
		public static void AddAlertSound(FlatBufferBuilder builder, StringOffset alertSoundOffset)
		{
			builder.AddOffset(3, alertSoundOffset.Value, 0);
		}

		// Token: 0x06021514 RID: 136468 RVA: 0x00498C6B File Offset: 0x00496E6B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06021515 RID: 136469 RVA: 0x00498C76 File Offset: 0x00496E76
		public static Offset<IAiAlertNotifyComponent> EndIAiAlertNotifyComponent(FlatBufferBuilder builder)
		{
			return new Offset<IAiAlertNotifyComponent>(builder.EndTable());
		}

		// Token: 0x06021516 RID: 136470 RVA: 0x00498C84 File Offset: 0x00496E84
		public IAiAlertNotifyComponentT UnPack()
		{
			IAiAlertNotifyComponentT aiAlertNotifyComponentT = new IAiAlertNotifyComponentT();
			this.UnPackTo(aiAlertNotifyComponentT);
			return aiAlertNotifyComponentT;
		}

		// Token: 0x06021517 RID: 136471 RVA: 0x00498CA0 File Offset: 0x00496EA0
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

		// Token: 0x06021518 RID: 136472 RVA: 0x00498D30 File Offset: 0x00496F30
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

		// Token: 0x0400E798 RID: 59288
		private Table __p;
	}
}
