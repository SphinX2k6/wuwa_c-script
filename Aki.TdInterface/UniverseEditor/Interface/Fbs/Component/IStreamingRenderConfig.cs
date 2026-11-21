using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FDB RID: 24539
	public struct IStreamingRenderConfig : IFlatbufferObject
	{
		// Token: 0x1700B5EB RID: 46571
		// (get) Token: 0x06029550 RID: 169296 RVA: 0x005A4737 File Offset: 0x005A2937
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029551 RID: 169297 RVA: 0x005A4744 File Offset: 0x005A2944
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029552 RID: 169298 RVA: 0x005A474C File Offset: 0x005A294C
		public static IStreamingRenderConfig GetRootAsIStreamingRenderConfig(ByteBuffer _bb)
		{
			return IStreamingRenderConfig.GetRootAsIStreamingRenderConfig(_bb, default(IStreamingRenderConfig));
		}

		// Token: 0x06029553 RID: 169299 RVA: 0x005A4768 File Offset: 0x005A2968
		public static IStreamingRenderConfig GetRootAsIStreamingRenderConfig(ByteBuffer _bb, IStreamingRenderConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029554 RID: 169300 RVA: 0x005A4785 File Offset: 0x005A2985
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029555 RID: 169301 RVA: 0x005A4794 File Offset: 0x005A2994
		public IStreamingRenderConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B5EC RID: 46572
		// (get) Token: 0x06029556 RID: 169302 RVA: 0x005A47A4 File Offset: 0x005A29A4
		public TPortalViewDistanceConfig ViewDistanceType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TPortalViewDistanceConfig.NONE;
				}
				return (TPortalViewDistanceConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029557 RID: 169303 RVA: 0x005A47E0 File Offset: 0x005A29E0
		public TTable? ViewDistance<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06029558 RID: 169304 RVA: 0x005A4824 File Offset: 0x005A2A24
		public ICustomViewDistance ViewDistanceAsICustomViewDistance()
		{
			return this.ViewDistance<ICustomViewDistance>().Value;
		}

		// Token: 0x06029559 RID: 169305 RVA: 0x005A4840 File Offset: 0x005A2A40
		public IHighViewDistance ViewDistanceAsIHighViewDistance()
		{
			return this.ViewDistance<IHighViewDistance>().Value;
		}

		// Token: 0x0602955A RID: 169306 RVA: 0x005A485C File Offset: 0x005A2A5C
		public ILowViewDistance ViewDistanceAsILowViewDistance()
		{
			return this.ViewDistance<ILowViewDistance>().Value;
		}

		// Token: 0x0602955B RID: 169307 RVA: 0x005A4878 File Offset: 0x005A2A78
		public IMidViewDistance ViewDistanceAsIMidViewDistance()
		{
			return this.ViewDistance<IMidViewDistance>().Value;
		}

		// Token: 0x0602955C RID: 169308 RVA: 0x005A4894 File Offset: 0x005A2A94
		public IActorRef? ForceRenderActors(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActorRef?(default(IActorRef).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B5ED RID: 46573
		// (get) Token: 0x0602955D RID: 169309 RVA: 0x005A48F4 File Offset: 0x005A2AF4
		public int ForceRenderActorsLength
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

		// Token: 0x0602955E RID: 169310 RVA: 0x005A4920 File Offset: 0x005A2B20
		public IRenderFlag? SetRenderFlags(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IRenderFlag?(default(IRenderFlag).__assign(this.__p.__vector(num) + j * 2, this.__p.bb));
		}

		// Token: 0x1700B5EE RID: 46574
		// (get) Token: 0x0602955F RID: 169311 RVA: 0x005A4978 File Offset: 0x005A2B78
		public int SetRenderFlagsLength
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

		// Token: 0x1700B5EF RID: 46575
		// (get) Token: 0x06029560 RID: 169312 RVA: 0x005A49A4 File Offset: 0x005A2BA4
		public IStreamingRtEffectRef? RtEffectRef
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IStreamingRtEffectRef?(default(IStreamingRtEffectRef).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B5F0 RID: 46576
		// (get) Token: 0x06029561 RID: 169313 RVA: 0x005A4A04 File Offset: 0x005A2C04
		public IRtSize? RtData
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new IRtSize?(default(IRtSize).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B5F1 RID: 46577
		// (get) Token: 0x06029562 RID: 169314 RVA: 0x005A4A64 File Offset: 0x005A2C64
		public string FallbackCubeMapTexturePath
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029563 RID: 169315 RVA: 0x005A4A9C File Offset: 0x005A2C9C
		public Span<byte> GetFallbackCubeMapTexturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06029564 RID: 169316 RVA: 0x005A4AAC File Offset: 0x005A2CAC
		public byte[] GetFallbackCubeMapTexturePathArray()
		{
			return this.__p.__vector_as_array<byte>(16);
		}

		// Token: 0x1700B5F2 RID: 46578
		// (get) Token: 0x06029565 RID: 169317 RVA: 0x005A4ABC File Offset: 0x005A2CBC
		public string FallbackCubeMapKey
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

		// Token: 0x06029566 RID: 169318 RVA: 0x005A4AF4 File Offset: 0x005A2CF4
		public Span<byte> GetFallbackCubeMapKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06029567 RID: 169319 RVA: 0x005A4B04 File Offset: 0x005A2D04
		public byte[] GetFallbackCubeMapKeyArray()
		{
			return this.__p.__vector_as_array<byte>(18);
		}

		// Token: 0x1700B5F3 RID: 46579
		// (get) Token: 0x06029568 RID: 169320 RVA: 0x005A4B14 File Offset: 0x005A2D14
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

		// Token: 0x06029569 RID: 169321 RVA: 0x005A4B54 File Offset: 0x005A2D54
		public static Offset<IStreamingRenderConfig> CreateIStreamingRenderConfig(FlatBufferBuilder builder, TPortalViewDistanceConfig ViewDistance_type = TPortalViewDistanceConfig.NONE, int ViewDistanceOffset = 0, VectorOffset ForceRenderActorsOffset = default(VectorOffset), VectorOffset SetRenderFlagsOffset = default(VectorOffset), Offset<IStreamingRtEffectRef> RtEffectRefOffset = default(Offset<IStreamingRtEffectRef>), Offset<IRtSize> RtDataOffset = default(Offset<IRtSize>), StringOffset FallbackCubeMapTexturePathOffset = default(StringOffset), StringOffset FallbackCubeMapKeyOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(9);
			IStreamingRenderConfig.AddFallbackCubeMapKey(builder, FallbackCubeMapKeyOffset);
			IStreamingRenderConfig.AddFallbackCubeMapTexturePath(builder, FallbackCubeMapTexturePathOffset);
			IStreamingRenderConfig.AddRtData(builder, RtDataOffset);
			IStreamingRenderConfig.AddRtEffectRef(builder, RtEffectRefOffset);
			IStreamingRenderConfig.AddSetRenderFlags(builder, SetRenderFlagsOffset);
			IStreamingRenderConfig.AddForceRenderActors(builder, ForceRenderActorsOffset);
			IStreamingRenderConfig.AddViewDistance(builder, ViewDistanceOffset);
			IStreamingRenderConfig.AddNullMask(builder, NullMask);
			IStreamingRenderConfig.AddViewDistanceType(builder, ViewDistance_type);
			return IStreamingRenderConfig.EndIStreamingRenderConfig(builder);
		}

		// Token: 0x0602956A RID: 169322 RVA: 0x005A4BB4 File Offset: 0x005A2DB4
		public static void StartIStreamingRenderConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x0602956B RID: 169323 RVA: 0x005A4BBE File Offset: 0x005A2DBE
		public static void AddViewDistanceType(FlatBufferBuilder builder, TPortalViewDistanceConfig viewDistanceType)
		{
			builder.AddByte(0, (byte)viewDistanceType, 0);
		}

		// Token: 0x0602956C RID: 169324 RVA: 0x005A4BC9 File Offset: 0x005A2DC9
		public static void AddViewDistance(FlatBufferBuilder builder, int viewDistanceOffset)
		{
			builder.AddOffset(1, viewDistanceOffset, 0);
		}

		// Token: 0x0602956D RID: 169325 RVA: 0x005A4BD4 File Offset: 0x005A2DD4
		public static void AddForceRenderActors(FlatBufferBuilder builder, VectorOffset forceRenderActorsOffset)
		{
			builder.AddOffset(2, forceRenderActorsOffset.Value, 0);
		}

		// Token: 0x0602956E RID: 169326 RVA: 0x005A4BE4 File Offset: 0x005A2DE4
		public static VectorOffset CreateForceRenderActorsVector(FlatBufferBuilder builder, Offset<IActorRef>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602956F RID: 169327 RVA: 0x005A4C24 File Offset: 0x005A2E24
		public static VectorOffset CreateForceRenderActorsVectorBlock(FlatBufferBuilder builder, Offset<IActorRef>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorRef>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029570 RID: 169328 RVA: 0x005A4C3E File Offset: 0x005A2E3E
		public static VectorOffset CreateForceRenderActorsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorRef>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorRef>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029571 RID: 169329 RVA: 0x005A4C5C File Offset: 0x005A2E5C
		public static VectorOffset CreateForceRenderActorsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorRef>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06029572 RID: 169330 RVA: 0x005A4C75 File Offset: 0x005A2E75
		public static void StartForceRenderActorsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06029573 RID: 169331 RVA: 0x005A4C80 File Offset: 0x005A2E80
		public static void AddSetRenderFlags(FlatBufferBuilder builder, VectorOffset setRenderFlagsOffset)
		{
			builder.AddOffset(3, setRenderFlagsOffset.Value, 0);
		}

		// Token: 0x06029574 RID: 169332 RVA: 0x005A4C90 File Offset: 0x005A2E90
		public static void StartSetRenderFlagsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(2, numElems, 1);
		}

		// Token: 0x06029575 RID: 169333 RVA: 0x005A4C9B File Offset: 0x005A2E9B
		public static void AddRtEffectRef(FlatBufferBuilder builder, Offset<IStreamingRtEffectRef> rtEffectRefOffset)
		{
			builder.AddOffset(4, rtEffectRefOffset.Value, 0);
		}

		// Token: 0x06029576 RID: 169334 RVA: 0x005A4CAB File Offset: 0x005A2EAB
		public static void AddRtData(FlatBufferBuilder builder, Offset<IRtSize> rtDataOffset)
		{
			builder.AddOffset(5, rtDataOffset.Value, 0);
		}

		// Token: 0x06029577 RID: 169335 RVA: 0x005A4CBB File Offset: 0x005A2EBB
		public static void AddFallbackCubeMapTexturePath(FlatBufferBuilder builder, StringOffset fallbackCubeMapTexturePathOffset)
		{
			builder.AddOffset(6, fallbackCubeMapTexturePathOffset.Value, 0);
		}

		// Token: 0x06029578 RID: 169336 RVA: 0x005A4CCB File Offset: 0x005A2ECB
		public static void AddFallbackCubeMapKey(FlatBufferBuilder builder, StringOffset fallbackCubeMapKeyOffset)
		{
			builder.AddOffset(7, fallbackCubeMapKeyOffset.Value, 0);
		}

		// Token: 0x06029579 RID: 169337 RVA: 0x005A4CDB File Offset: 0x005A2EDB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x0602957A RID: 169338 RVA: 0x005A4CE6 File Offset: 0x005A2EE6
		public static Offset<IStreamingRenderConfig> EndIStreamingRenderConfig(FlatBufferBuilder builder)
		{
			return new Offset<IStreamingRenderConfig>(builder.EndTable());
		}

		// Token: 0x0602957B RID: 169339 RVA: 0x005A4CF4 File Offset: 0x005A2EF4
		public IStreamingRenderConfigT UnPack()
		{
			IStreamingRenderConfigT streamingRenderConfigT = new IStreamingRenderConfigT();
			this.UnPackTo(streamingRenderConfigT);
			return streamingRenderConfigT;
		}

		// Token: 0x0602957C RID: 169340 RVA: 0x005A4D10 File Offset: 0x005A2F10
		public void UnPackTo(IStreamingRenderConfigT _o)
		{
			_o.ViewDistance = new TPortalViewDistanceConfigUnion();
			_o.ViewDistance.Type = this.ViewDistanceType;
			switch (this.ViewDistanceType)
			{
			case TPortalViewDistanceConfig.ICustomViewDistance:
				_o.ViewDistance.Value = ((this.ViewDistance<ICustomViewDistance>() != null) ? this.ViewDistance<ICustomViewDistance>().Value.UnPack() : null);
				break;
			case TPortalViewDistanceConfig.IHighViewDistance:
				_o.ViewDistance.Value = ((this.ViewDistance<IHighViewDistance>() != null) ? this.ViewDistance<IHighViewDistance>().Value.UnPack() : null);
				break;
			case TPortalViewDistanceConfig.ILowViewDistance:
				_o.ViewDistance.Value = ((this.ViewDistance<ILowViewDistance>() != null) ? this.ViewDistance<ILowViewDistance>().Value.UnPack() : null);
				break;
			case TPortalViewDistanceConfig.IMidViewDistance:
				_o.ViewDistance.Value = ((this.ViewDistance<IMidViewDistance>() != null) ? this.ViewDistance<IMidViewDistance>().Value.UnPack() : null);
				break;
			}
			_o.ForceRenderActors = new List<IActorRefT>();
			for (int i = 0; i < this.ForceRenderActorsLength; i++)
			{
				_o.ForceRenderActors.Add((this.ForceRenderActors(i) != null) ? this.ForceRenderActors(i).Value.UnPack() : null);
			}
			_o.SetRenderFlags = new List<IRenderFlagT>();
			for (int j = 0; j < this.SetRenderFlagsLength; j++)
			{
				_o.SetRenderFlags.Add((this.SetRenderFlags(j) != null) ? this.SetRenderFlags(j).Value.UnPack() : null);
			}
			_o.RtEffectRef = ((this.RtEffectRef != null) ? this.RtEffectRef.Value.UnPack() : null);
			_o.RtData = ((this.RtData != null) ? this.RtData.Value.UnPack() : null);
			_o.FallbackCubeMapTexturePath = this.FallbackCubeMapTexturePath;
			_o.FallbackCubeMapKey = this.FallbackCubeMapKey;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602957D RID: 169341 RVA: 0x005A4F7C File Offset: 0x005A317C
		public static Offset<IStreamingRenderConfig> Pack(FlatBufferBuilder builder, IStreamingRenderConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStreamingRenderConfig>);
			}
			TPortalViewDistanceConfig viewDistance_type = (_o.ViewDistance == null) ? TPortalViewDistanceConfig.NONE : _o.ViewDistance.Type;
			int viewDistanceOffset = (_o.ViewDistance == null) ? 0 : TPortalViewDistanceConfigUnion.Pack(builder, _o.ViewDistance);
			VectorOffset forceRenderActorsOffset = default(VectorOffset);
			if (_o.ForceRenderActors != null)
			{
				Offset<IActorRef>[] array = new Offset<IActorRef>[_o.ForceRenderActors.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActorRef.Pack(builder, _o.ForceRenderActors[i]);
				}
				forceRenderActorsOffset = IStreamingRenderConfig.CreateForceRenderActorsVector(builder, array);
			}
			VectorOffset setRenderFlagsOffset = default(VectorOffset);
			if (_o.SetRenderFlags != null)
			{
				IStreamingRenderConfig.StartSetRenderFlagsVector(builder, _o.SetRenderFlags.Count);
				for (int j = _o.SetRenderFlags.Count - 1; j >= 0; j--)
				{
					IRenderFlag.Pack(builder, _o.SetRenderFlags[j]);
				}
				setRenderFlagsOffset = builder.EndVector();
			}
			Offset<IStreamingRtEffectRef> rtEffectRefOffset = (_o.RtEffectRef == null) ? default(Offset<IStreamingRtEffectRef>) : IStreamingRtEffectRef.Pack(builder, _o.RtEffectRef);
			Offset<IRtSize> rtDataOffset = (_o.RtData == null) ? default(Offset<IRtSize>) : IRtSize.Pack(builder, _o.RtData);
			StringOffset fallbackCubeMapTexturePathOffset = (_o.FallbackCubeMapTexturePath == null) ? default(StringOffset) : builder.CreateString(_o.FallbackCubeMapTexturePath);
			StringOffset fallbackCubeMapKeyOffset = (_o.FallbackCubeMapKey == null) ? default(StringOffset) : builder.CreateString(_o.FallbackCubeMapKey);
			return IStreamingRenderConfig.CreateIStreamingRenderConfig(builder, viewDistance_type, viewDistanceOffset, forceRenderActorsOffset, setRenderFlagsOffset, rtEffectRefOffset, rtDataOffset, fallbackCubeMapTexturePathOffset, fallbackCubeMapKeyOffset, _o.NullMask);
		}

		// Token: 0x0400FCF3 RID: 64755
		private Table __p;
	}
}
