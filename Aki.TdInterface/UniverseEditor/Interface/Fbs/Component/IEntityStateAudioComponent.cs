using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051B3 RID: 20915
	public struct IEntityStateAudioComponent : IFlatbufferObject
	{
		// Token: 0x170098DB RID: 39131
		// (get) Token: 0x06021DB7 RID: 138679 RVA: 0x004B2330 File Offset: 0x004B0530
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021DB8 RID: 138680 RVA: 0x004B233D File Offset: 0x004B053D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021DB9 RID: 138681 RVA: 0x004B2344 File Offset: 0x004B0544
		public static IEntityStateAudioComponent GetRootAsIEntityStateAudioComponent(ByteBuffer _bb)
		{
			return IEntityStateAudioComponent.GetRootAsIEntityStateAudioComponent(_bb, default(IEntityStateAudioComponent));
		}

		// Token: 0x06021DBA RID: 138682 RVA: 0x004B2360 File Offset: 0x004B0560
		public static IEntityStateAudioComponent GetRootAsIEntityStateAudioComponent(ByteBuffer _bb, IEntityStateAudioComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021DBB RID: 138683 RVA: 0x004B237D File Offset: 0x004B057D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021DBC RID: 138684 RVA: 0x004B238C File Offset: 0x004B058C
		public IEntityStateAudioComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170098DC RID: 39132
		// (get) Token: 0x06021DBD RID: 138685 RVA: 0x004B239C File Offset: 0x004B059C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170098DD RID: 39133
		// (get) Token: 0x06021DBE RID: 138686 RVA: 0x004B23DC File Offset: 0x004B05DC
		public TAkEventType AkEventTypeType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TAkEventType.NONE;
				}
				return (TAkEventType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021DBF RID: 138687 RVA: 0x004B2418 File Offset: 0x004B0618
		public TTable? AkEventType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06021DC0 RID: 138688 RVA: 0x004B245C File Offset: 0x004B065C
		public IBoxAkEvent AkEventTypeAsIBoxAkEvent()
		{
			return this.AkEventType<IBoxAkEvent>().Value;
		}

		// Token: 0x06021DC1 RID: 138689 RVA: 0x004B2478 File Offset: 0x004B0678
		public IDefaultAkEvent AkEventTypeAsIDefaultAkEvent()
		{
			return this.AkEventType<IDefaultAkEvent>().Value;
		}

		// Token: 0x06021DC2 RID: 138690 RVA: 0x004B2494 File Offset: 0x004B0694
		public IPointAkEvent AkEventTypeAsIPointAkEvent()
		{
			return this.AkEventType<IPointAkEvent>().Value;
		}

		// Token: 0x170098DE RID: 39134
		// (get) Token: 0x06021DC3 RID: 138691 RVA: 0x004B24B0 File Offset: 0x004B06B0
		public EAudioRangeType AudioRangeType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return EAudioRangeType.SceneActorRefComp;
				}
				return (EAudioRangeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021DC4 RID: 138692 RVA: 0x004B24F0 File Offset: 0x004B06F0
		public IEntityStateAudioConfig? Config(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IEntityStateAudioConfig?(default(IEntityStateAudioConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170098DF RID: 39135
		// (get) Token: 0x06021DC5 RID: 138693 RVA: 0x004B2554 File Offset: 0x004B0754
		public int ConfigLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170098E0 RID: 39136
		// (get) Token: 0x06021DC6 RID: 138694 RVA: 0x004B2580 File Offset: 0x004B0780
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021DC7 RID: 138695 RVA: 0x004B25BD File Offset: 0x004B07BD
		public static Offset<IEntityStateAudioComponent> CreateIEntityStateAudioComponent(FlatBufferBuilder builder, bool Disabled = false, TAkEventType AkEventType_type = TAkEventType.NONE, int AkEventTypeOffset = 0, EAudioRangeType AudioRangeType = EAudioRangeType.SceneActorRefComp, VectorOffset ConfigOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(6);
			IEntityStateAudioComponent.AddConfig(builder, ConfigOffset);
			IEntityStateAudioComponent.AddAkEventType(builder, AkEventTypeOffset);
			IEntityStateAudioComponent.AddNullMask(builder, NullMask);
			IEntityStateAudioComponent.AddAudioRangeType(builder, AudioRangeType);
			IEntityStateAudioComponent.AddAkEventTypeType(builder, AkEventType_type);
			IEntityStateAudioComponent.AddDisabled(builder, Disabled);
			return IEntityStateAudioComponent.EndIEntityStateAudioComponent(builder);
		}

		// Token: 0x06021DC8 RID: 138696 RVA: 0x004B25F9 File Offset: 0x004B07F9
		public static void StartIEntityStateAudioComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06021DC9 RID: 138697 RVA: 0x004B2602 File Offset: 0x004B0802
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06021DCA RID: 138698 RVA: 0x004B260D File Offset: 0x004B080D
		public static void AddAkEventTypeType(FlatBufferBuilder builder, TAkEventType akEventTypeType)
		{
			builder.AddByte(1, (byte)akEventTypeType, 0);
		}

		// Token: 0x06021DCB RID: 138699 RVA: 0x004B2618 File Offset: 0x004B0818
		public static void AddAkEventType(FlatBufferBuilder builder, int akEventTypeOffset)
		{
			builder.AddOffset(2, akEventTypeOffset, 0);
		}

		// Token: 0x06021DCC RID: 138700 RVA: 0x004B2623 File Offset: 0x004B0823
		public static void AddAudioRangeType(FlatBufferBuilder builder, EAudioRangeType audioRangeType)
		{
			builder.AddByte(3, (byte)audioRangeType, 0);
		}

		// Token: 0x06021DCD RID: 138701 RVA: 0x004B262E File Offset: 0x004B082E
		public static void AddConfig(FlatBufferBuilder builder, VectorOffset configOffset)
		{
			builder.AddOffset(4, configOffset.Value, 0);
		}

		// Token: 0x06021DCE RID: 138702 RVA: 0x004B2640 File Offset: 0x004B0840
		public static VectorOffset CreateConfigVector(FlatBufferBuilder builder, Offset<IEntityStateAudioConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06021DCF RID: 138703 RVA: 0x004B2680 File Offset: 0x004B0880
		public static VectorOffset CreateConfigVectorBlock(FlatBufferBuilder builder, Offset<IEntityStateAudioConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityStateAudioConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021DD0 RID: 138704 RVA: 0x004B269A File Offset: 0x004B089A
		public static VectorOffset CreateConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityStateAudioConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityStateAudioConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021DD1 RID: 138705 RVA: 0x004B26B8 File Offset: 0x004B08B8
		public static VectorOffset CreateConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityStateAudioConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021DD2 RID: 138706 RVA: 0x004B26D1 File Offset: 0x004B08D1
		public static void StartConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021DD3 RID: 138707 RVA: 0x004B26DC File Offset: 0x004B08DC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06021DD4 RID: 138708 RVA: 0x004B26E7 File Offset: 0x004B08E7
		public static Offset<IEntityStateAudioComponent> EndIEntityStateAudioComponent(FlatBufferBuilder builder)
		{
			return new Offset<IEntityStateAudioComponent>(builder.EndTable());
		}

		// Token: 0x06021DD5 RID: 138709 RVA: 0x004B26F4 File Offset: 0x004B08F4
		public IEntityStateAudioComponentT UnPack()
		{
			IEntityStateAudioComponentT entityStateAudioComponentT = new IEntityStateAudioComponentT();
			this.UnPackTo(entityStateAudioComponentT);
			return entityStateAudioComponentT;
		}

		// Token: 0x06021DD6 RID: 138710 RVA: 0x004B2710 File Offset: 0x004B0910
		public void UnPackTo(IEntityStateAudioComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.AkEventType = new TAkEventTypeUnion();
			_o.AkEventType.Type = this.AkEventTypeType;
			switch (this.AkEventTypeType)
			{
			case TAkEventType.IBoxAkEvent:
				_o.AkEventType.Value = ((this.AkEventType<IBoxAkEvent>() != null) ? this.AkEventType<IBoxAkEvent>().Value.UnPack() : null);
				break;
			case TAkEventType.IDefaultAkEvent:
				_o.AkEventType.Value = ((this.AkEventType<IDefaultAkEvent>() != null) ? this.AkEventType<IDefaultAkEvent>().Value.UnPack() : null);
				break;
			case TAkEventType.IPointAkEvent:
				_o.AkEventType.Value = ((this.AkEventType<IPointAkEvent>() != null) ? this.AkEventType<IPointAkEvent>().Value.UnPack() : null);
				break;
			}
			_o.AudioRangeType = this.AudioRangeType;
			_o.Config = new List<IEntityStateAudioConfigT>();
			for (int i = 0; i < this.ConfigLength; i++)
			{
				_o.Config.Add((this.Config(i) != null) ? this.Config(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06021DD7 RID: 138711 RVA: 0x004B287C File Offset: 0x004B0A7C
		public static Offset<IEntityStateAudioComponent> Pack(FlatBufferBuilder builder, IEntityStateAudioComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityStateAudioComponent>);
			}
			TAkEventType akEventType_type = (_o.AkEventType == null) ? TAkEventType.NONE : _o.AkEventType.Type;
			int akEventTypeOffset = (_o.AkEventType == null) ? 0 : TAkEventTypeUnion.Pack(builder, _o.AkEventType);
			VectorOffset configOffset = default(VectorOffset);
			if (_o.Config != null)
			{
				Offset<IEntityStateAudioConfig>[] array = new Offset<IEntityStateAudioConfig>[_o.Config.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IEntityStateAudioConfig.Pack(builder, _o.Config[i]);
				}
				configOffset = IEntityStateAudioComponent.CreateConfigVector(builder, array);
			}
			return IEntityStateAudioComponent.CreateIEntityStateAudioComponent(builder, _o.Disabled, akEventType_type, akEventTypeOffset, _o.AudioRangeType, configOffset, _o.NullMask);
		}

		// Token: 0x0400E299 RID: 58009
		private Table __p;
	}
}
