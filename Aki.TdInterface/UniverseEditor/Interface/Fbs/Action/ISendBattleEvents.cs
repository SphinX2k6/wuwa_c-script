using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F60 RID: 28512
	public struct ISendBattleEvents : IFlatbufferObject
	{
		// Token: 0x1700D3D5 RID: 54229
		// (get) Token: 0x060325E9 RID: 206313 RVA: 0x006CCD70 File Offset: 0x006CAF70
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060325EA RID: 206314 RVA: 0x006CCD7D File Offset: 0x006CAF7D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060325EB RID: 206315 RVA: 0x006CCD84 File Offset: 0x006CAF84
		public static ISendBattleEvents GetRootAsISendBattleEvents(ByteBuffer _bb)
		{
			return ISendBattleEvents.GetRootAsISendBattleEvents(_bb, default(ISendBattleEvents));
		}

		// Token: 0x060325EC RID: 206316 RVA: 0x006CCDA0 File Offset: 0x006CAFA0
		public static ISendBattleEvents GetRootAsISendBattleEvents(ByteBuffer _bb, ISendBattleEvents obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060325ED RID: 206317 RVA: 0x006CCDBD File Offset: 0x006CAFBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060325EE RID: 206318 RVA: 0x006CCDCC File Offset: 0x006CAFCC
		public ISendBattleEvents __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D3D6 RID: 54230
		// (get) Token: 0x060325EF RID: 206319 RVA: 0x006CCDDC File Offset: 0x006CAFDC
		public EExecBattleActionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EExecBattleActionType.SetBattleTags;
				}
				return (EExecBattleActionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060325F0 RID: 206320 RVA: 0x006CCE18 File Offset: 0x006CB018
		public ISetBattleTagConfig? Configs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ISetBattleTagConfig?(default(ISetBattleTagConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700D3D7 RID: 54231
		// (get) Token: 0x060325F1 RID: 206321 RVA: 0x006CCE78 File Offset: 0x006CB078
		public int ConfigsLength
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

		// Token: 0x060325F2 RID: 206322 RVA: 0x006CCEA3 File Offset: 0x006CB0A3
		public static Offset<ISendBattleEvents> CreateISendBattleEvents(FlatBufferBuilder builder, EExecBattleActionType Type = EExecBattleActionType.SetBattleTags, VectorOffset ConfigsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ISendBattleEvents.AddConfigs(builder, ConfigsOffset);
			ISendBattleEvents.AddType(builder, Type);
			return ISendBattleEvents.EndISendBattleEvents(builder);
		}

		// Token: 0x060325F3 RID: 206323 RVA: 0x006CCEC0 File Offset: 0x006CB0C0
		public static void StartISendBattleEvents(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060325F4 RID: 206324 RVA: 0x006CCEC9 File Offset: 0x006CB0C9
		public static void AddType(FlatBufferBuilder builder, EExecBattleActionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060325F5 RID: 206325 RVA: 0x006CCED4 File Offset: 0x006CB0D4
		public static void AddConfigs(FlatBufferBuilder builder, VectorOffset configsOffset)
		{
			builder.AddOffset(1, configsOffset.Value, 0);
		}

		// Token: 0x060325F6 RID: 206326 RVA: 0x006CCEE4 File Offset: 0x006CB0E4
		public static VectorOffset CreateConfigsVector(FlatBufferBuilder builder, Offset<ISetBattleTagConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060325F7 RID: 206327 RVA: 0x006CCF24 File Offset: 0x006CB124
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, Offset<ISetBattleTagConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISetBattleTagConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x060325F8 RID: 206328 RVA: 0x006CCF3E File Offset: 0x006CB13E
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISetBattleTagConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISetBattleTagConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x060325F9 RID: 206329 RVA: 0x006CCF5C File Offset: 0x006CB15C
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISetBattleTagConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060325FA RID: 206330 RVA: 0x006CCF75 File Offset: 0x006CB175
		public static void StartConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060325FB RID: 206331 RVA: 0x006CCF80 File Offset: 0x006CB180
		public static Offset<ISendBattleEvents> EndISendBattleEvents(FlatBufferBuilder builder)
		{
			return new Offset<ISendBattleEvents>(builder.EndTable());
		}

		// Token: 0x060325FC RID: 206332 RVA: 0x006CCF90 File Offset: 0x006CB190
		public ISendBattleEventsT UnPack()
		{
			ISendBattleEventsT sendBattleEventsT = new ISendBattleEventsT();
			this.UnPackTo(sendBattleEventsT);
			return sendBattleEventsT;
		}

		// Token: 0x060325FD RID: 206333 RVA: 0x006CCFAC File Offset: 0x006CB1AC
		public void UnPackTo(ISendBattleEventsT _o)
		{
			_o.Type = this.Type;
			_o.Configs = new List<ISetBattleTagConfigT>();
			for (int i = 0; i < this.ConfigsLength; i++)
			{
				_o.Configs.Add((this.Configs(i) != null) ? this.Configs(i).Value.UnPack() : null);
			}
		}

		// Token: 0x060325FE RID: 206334 RVA: 0x006CD018 File Offset: 0x006CB218
		public static Offset<ISendBattleEvents> Pack(FlatBufferBuilder builder, ISendBattleEventsT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISendBattleEvents>);
			}
			VectorOffset configsOffset = default(VectorOffset);
			if (_o.Configs != null)
			{
				Offset<ISetBattleTagConfig>[] array = new Offset<ISetBattleTagConfig>[_o.Configs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ISetBattleTagConfig.Pack(builder, _o.Configs[i]);
				}
				configsOffset = ISendBattleEvents.CreateConfigsVector(builder, array);
			}
			return ISendBattleEvents.CreateISendBattleEvents(builder, _o.Type, configsOffset);
		}

		// Token: 0x04011959 RID: 72025
		private Table __p;
	}
}
