using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D79 RID: 23929
	public struct IPortalRenderConfig : IFlatbufferObject
	{
		// Token: 0x1700B019 RID: 45081
		// (get) Token: 0x06027D61 RID: 163169 RVA: 0x00572F3C File Offset: 0x0057113C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027D62 RID: 163170 RVA: 0x00572F49 File Offset: 0x00571149
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027D63 RID: 163171 RVA: 0x00572F50 File Offset: 0x00571150
		public static IPortalRenderConfig GetRootAsIPortalRenderConfig(ByteBuffer _bb)
		{
			return IPortalRenderConfig.GetRootAsIPortalRenderConfig(_bb, default(IPortalRenderConfig));
		}

		// Token: 0x06027D64 RID: 163172 RVA: 0x00572F6C File Offset: 0x0057116C
		public static IPortalRenderConfig GetRootAsIPortalRenderConfig(ByteBuffer _bb, IPortalRenderConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027D65 RID: 163173 RVA: 0x00572F89 File Offset: 0x00571189
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027D66 RID: 163174 RVA: 0x00572F98 File Offset: 0x00571198
		public IPortalRenderConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B01A RID: 45082
		// (get) Token: 0x06027D67 RID: 163175 RVA: 0x00572FA8 File Offset: 0x005711A8
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

		// Token: 0x06027D68 RID: 163176 RVA: 0x00572FE4 File Offset: 0x005711E4
		public TTable? ViewDistance<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06027D69 RID: 163177 RVA: 0x00573028 File Offset: 0x00571228
		public ICustomViewDistance ViewDistanceAsICustomViewDistance()
		{
			return this.ViewDistance<ICustomViewDistance>().Value;
		}

		// Token: 0x06027D6A RID: 163178 RVA: 0x00573044 File Offset: 0x00571244
		public IHighViewDistance ViewDistanceAsIHighViewDistance()
		{
			return this.ViewDistance<IHighViewDistance>().Value;
		}

		// Token: 0x06027D6B RID: 163179 RVA: 0x00573060 File Offset: 0x00571260
		public ILowViewDistance ViewDistanceAsILowViewDistance()
		{
			return this.ViewDistance<ILowViewDistance>().Value;
		}

		// Token: 0x06027D6C RID: 163180 RVA: 0x0057307C File Offset: 0x0057127C
		public IMidViewDistance ViewDistanceAsIMidViewDistance()
		{
			return this.ViewDistance<IMidViewDistance>().Value;
		}

		// Token: 0x06027D6D RID: 163181 RVA: 0x00573098 File Offset: 0x00571298
		public IActorRef? ForceRenderActors(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActorRef?(default(IActorRef).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B01B RID: 45083
		// (get) Token: 0x06027D6E RID: 163182 RVA: 0x005730F8 File Offset: 0x005712F8
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

		// Token: 0x06027D6F RID: 163183 RVA: 0x00573124 File Offset: 0x00571324
		public IRenderFlag? SetRenderFlags(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IRenderFlag?(default(IRenderFlag).__assign(this.__p.__vector(num) + j * 2, this.__p.bb));
		}

		// Token: 0x1700B01C RID: 45084
		// (get) Token: 0x06027D70 RID: 163184 RVA: 0x0057317C File Offset: 0x0057137C
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

		// Token: 0x1700B01D RID: 45085
		// (get) Token: 0x06027D71 RID: 163185 RVA: 0x005731A8 File Offset: 0x005713A8
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

		// Token: 0x06027D72 RID: 163186 RVA: 0x005731E5 File Offset: 0x005713E5
		public static Offset<IPortalRenderConfig> CreateIPortalRenderConfig(FlatBufferBuilder builder, TPortalViewDistanceConfig ViewDistance_type = TPortalViewDistanceConfig.NONE, int ViewDistanceOffset = 0, VectorOffset ForceRenderActorsOffset = default(VectorOffset), VectorOffset SetRenderFlagsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(5);
			IPortalRenderConfig.AddSetRenderFlags(builder, SetRenderFlagsOffset);
			IPortalRenderConfig.AddForceRenderActors(builder, ForceRenderActorsOffset);
			IPortalRenderConfig.AddViewDistance(builder, ViewDistanceOffset);
			IPortalRenderConfig.AddNullMask(builder, NullMask);
			IPortalRenderConfig.AddViewDistanceType(builder, ViewDistance_type);
			return IPortalRenderConfig.EndIPortalRenderConfig(builder);
		}

		// Token: 0x06027D73 RID: 163187 RVA: 0x00573219 File Offset: 0x00571419
		public static void StartIPortalRenderConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06027D74 RID: 163188 RVA: 0x00573222 File Offset: 0x00571422
		public static void AddViewDistanceType(FlatBufferBuilder builder, TPortalViewDistanceConfig viewDistanceType)
		{
			builder.AddByte(0, (byte)viewDistanceType, 0);
		}

		// Token: 0x06027D75 RID: 163189 RVA: 0x0057322D File Offset: 0x0057142D
		public static void AddViewDistance(FlatBufferBuilder builder, int viewDistanceOffset)
		{
			builder.AddOffset(1, viewDistanceOffset, 0);
		}

		// Token: 0x06027D76 RID: 163190 RVA: 0x00573238 File Offset: 0x00571438
		public static void AddForceRenderActors(FlatBufferBuilder builder, VectorOffset forceRenderActorsOffset)
		{
			builder.AddOffset(2, forceRenderActorsOffset.Value, 0);
		}

		// Token: 0x06027D77 RID: 163191 RVA: 0x00573248 File Offset: 0x00571448
		public static VectorOffset CreateForceRenderActorsVector(FlatBufferBuilder builder, Offset<IActorRef>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06027D78 RID: 163192 RVA: 0x00573288 File Offset: 0x00571488
		public static VectorOffset CreateForceRenderActorsVectorBlock(FlatBufferBuilder builder, Offset<IActorRef>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorRef>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027D79 RID: 163193 RVA: 0x005732A2 File Offset: 0x005714A2
		public static VectorOffset CreateForceRenderActorsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorRef>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorRef>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027D7A RID: 163194 RVA: 0x005732C0 File Offset: 0x005714C0
		public static VectorOffset CreateForceRenderActorsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorRef>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027D7B RID: 163195 RVA: 0x005732D9 File Offset: 0x005714D9
		public static void StartForceRenderActorsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06027D7C RID: 163196 RVA: 0x005732E4 File Offset: 0x005714E4
		public static void AddSetRenderFlags(FlatBufferBuilder builder, VectorOffset setRenderFlagsOffset)
		{
			builder.AddOffset(3, setRenderFlagsOffset.Value, 0);
		}

		// Token: 0x06027D7D RID: 163197 RVA: 0x005732F4 File Offset: 0x005714F4
		public static void StartSetRenderFlagsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(2, numElems, 1);
		}

		// Token: 0x06027D7E RID: 163198 RVA: 0x005732FF File Offset: 0x005714FF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06027D7F RID: 163199 RVA: 0x0057330A File Offset: 0x0057150A
		public static Offset<IPortalRenderConfig> EndIPortalRenderConfig(FlatBufferBuilder builder)
		{
			return new Offset<IPortalRenderConfig>(builder.EndTable());
		}

		// Token: 0x06027D80 RID: 163200 RVA: 0x00573318 File Offset: 0x00571518
		public IPortalRenderConfigT UnPack()
		{
			IPortalRenderConfigT portalRenderConfigT = new IPortalRenderConfigT();
			this.UnPackTo(portalRenderConfigT);
			return portalRenderConfigT;
		}

		// Token: 0x06027D81 RID: 163201 RVA: 0x00573334 File Offset: 0x00571534
		public void UnPackTo(IPortalRenderConfigT _o)
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
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06027D82 RID: 163202 RVA: 0x00573524 File Offset: 0x00571724
		public static Offset<IPortalRenderConfig> Pack(FlatBufferBuilder builder, IPortalRenderConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPortalRenderConfig>);
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
				forceRenderActorsOffset = IPortalRenderConfig.CreateForceRenderActorsVector(builder, array);
			}
			VectorOffset setRenderFlagsOffset = default(VectorOffset);
			if (_o.SetRenderFlags != null)
			{
				IPortalRenderConfig.StartSetRenderFlagsVector(builder, _o.SetRenderFlags.Count);
				for (int j = _o.SetRenderFlags.Count - 1; j >= 0; j--)
				{
					IRenderFlag.Pack(builder, _o.SetRenderFlags[j]);
				}
				setRenderFlagsOffset = builder.EndVector();
			}
			return IPortalRenderConfig.CreateIPortalRenderConfig(builder, viewDistance_type, viewDistanceOffset, forceRenderActorsOffset, setRenderFlagsOffset, _o.NullMask);
		}

		// Token: 0x0400F906 RID: 63750
		private Table __p;
	}
}
