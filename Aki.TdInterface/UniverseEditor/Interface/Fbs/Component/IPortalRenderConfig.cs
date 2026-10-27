using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005772 RID: 22386
	public struct IPortalRenderConfig : IFlatbufferObject
	{
		// Token: 0x1700A6F5 RID: 42741
		// (get) Token: 0x06025841 RID: 153665 RVA: 0x0052CDB0 File Offset: 0x0052AFB0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025842 RID: 153666 RVA: 0x0052CDBD File Offset: 0x0052AFBD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025843 RID: 153667 RVA: 0x0052CDC4 File Offset: 0x0052AFC4
		public static IPortalRenderConfig GetRootAsIPortalRenderConfig(ByteBuffer _bb)
		{
			return IPortalRenderConfig.GetRootAsIPortalRenderConfig(_bb, default(IPortalRenderConfig));
		}

		// Token: 0x06025844 RID: 153668 RVA: 0x0052CDE0 File Offset: 0x0052AFE0
		public static IPortalRenderConfig GetRootAsIPortalRenderConfig(ByteBuffer _bb, IPortalRenderConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025845 RID: 153669 RVA: 0x0052CDFD File Offset: 0x0052AFFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025846 RID: 153670 RVA: 0x0052CE0C File Offset: 0x0052B00C
		public IPortalRenderConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A6F6 RID: 42742
		// (get) Token: 0x06025847 RID: 153671 RVA: 0x0052CE1C File Offset: 0x0052B01C
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

		// Token: 0x06025848 RID: 153672 RVA: 0x0052CE58 File Offset: 0x0052B058
		public TTable? ViewDistance<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06025849 RID: 153673 RVA: 0x0052CE9C File Offset: 0x0052B09C
		public ICustomViewDistance ViewDistanceAsICustomViewDistance()
		{
			return this.ViewDistance<ICustomViewDistance>().Value;
		}

		// Token: 0x0602584A RID: 153674 RVA: 0x0052CEB8 File Offset: 0x0052B0B8
		public IHighViewDistance ViewDistanceAsIHighViewDistance()
		{
			return this.ViewDistance<IHighViewDistance>().Value;
		}

		// Token: 0x0602584B RID: 153675 RVA: 0x0052CED4 File Offset: 0x0052B0D4
		public ILowViewDistance ViewDistanceAsILowViewDistance()
		{
			return this.ViewDistance<ILowViewDistance>().Value;
		}

		// Token: 0x0602584C RID: 153676 RVA: 0x0052CEF0 File Offset: 0x0052B0F0
		public IMidViewDistance ViewDistanceAsIMidViewDistance()
		{
			return this.ViewDistance<IMidViewDistance>().Value;
		}

		// Token: 0x0602584D RID: 153677 RVA: 0x0052CF0C File Offset: 0x0052B10C
		public IActorRef? ForceRenderActors(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActorRef?(default(IActorRef).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A6F7 RID: 42743
		// (get) Token: 0x0602584E RID: 153678 RVA: 0x0052CF6C File Offset: 0x0052B16C
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

		// Token: 0x0602584F RID: 153679 RVA: 0x0052CF98 File Offset: 0x0052B198
		public IRenderFlag? SetRenderFlags(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IRenderFlag?(default(IRenderFlag).__assign(this.__p.__vector(num) + j * 2, this.__p.bb));
		}

		// Token: 0x1700A6F8 RID: 42744
		// (get) Token: 0x06025850 RID: 153680 RVA: 0x0052CFF0 File Offset: 0x0052B1F0
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

		// Token: 0x1700A6F9 RID: 42745
		// (get) Token: 0x06025851 RID: 153681 RVA: 0x0052D01C File Offset: 0x0052B21C
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

		// Token: 0x06025852 RID: 153682 RVA: 0x0052D059 File Offset: 0x0052B259
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

		// Token: 0x06025853 RID: 153683 RVA: 0x0052D08D File Offset: 0x0052B28D
		public static void StartIPortalRenderConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06025854 RID: 153684 RVA: 0x0052D096 File Offset: 0x0052B296
		public static void AddViewDistanceType(FlatBufferBuilder builder, TPortalViewDistanceConfig viewDistanceType)
		{
			builder.AddByte(0, (byte)viewDistanceType, 0);
		}

		// Token: 0x06025855 RID: 153685 RVA: 0x0052D0A1 File Offset: 0x0052B2A1
		public static void AddViewDistance(FlatBufferBuilder builder, int viewDistanceOffset)
		{
			builder.AddOffset(1, viewDistanceOffset, 0);
		}

		// Token: 0x06025856 RID: 153686 RVA: 0x0052D0AC File Offset: 0x0052B2AC
		public static void AddForceRenderActors(FlatBufferBuilder builder, VectorOffset forceRenderActorsOffset)
		{
			builder.AddOffset(2, forceRenderActorsOffset.Value, 0);
		}

		// Token: 0x06025857 RID: 153687 RVA: 0x0052D0BC File Offset: 0x0052B2BC
		public static VectorOffset CreateForceRenderActorsVector(FlatBufferBuilder builder, Offset<IActorRef>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06025858 RID: 153688 RVA: 0x0052D0FC File Offset: 0x0052B2FC
		public static VectorOffset CreateForceRenderActorsVectorBlock(FlatBufferBuilder builder, Offset<IActorRef>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorRef>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025859 RID: 153689 RVA: 0x0052D116 File Offset: 0x0052B316
		public static VectorOffset CreateForceRenderActorsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorRef>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorRef>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602585A RID: 153690 RVA: 0x0052D134 File Offset: 0x0052B334
		public static VectorOffset CreateForceRenderActorsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorRef>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602585B RID: 153691 RVA: 0x0052D14D File Offset: 0x0052B34D
		public static void StartForceRenderActorsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602585C RID: 153692 RVA: 0x0052D158 File Offset: 0x0052B358
		public static void AddSetRenderFlags(FlatBufferBuilder builder, VectorOffset setRenderFlagsOffset)
		{
			builder.AddOffset(3, setRenderFlagsOffset.Value, 0);
		}

		// Token: 0x0602585D RID: 153693 RVA: 0x0052D168 File Offset: 0x0052B368
		public static void StartSetRenderFlagsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(2, numElems, 1);
		}

		// Token: 0x0602585E RID: 153694 RVA: 0x0052D173 File Offset: 0x0052B373
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602585F RID: 153695 RVA: 0x0052D17E File Offset: 0x0052B37E
		public static Offset<IPortalRenderConfig> EndIPortalRenderConfig(FlatBufferBuilder builder)
		{
			return new Offset<IPortalRenderConfig>(builder.EndTable());
		}

		// Token: 0x06025860 RID: 153696 RVA: 0x0052D18C File Offset: 0x0052B38C
		public IPortalRenderConfigT UnPack()
		{
			IPortalRenderConfigT portalRenderConfigT = new IPortalRenderConfigT();
			this.UnPackTo(portalRenderConfigT);
			return portalRenderConfigT;
		}

		// Token: 0x06025861 RID: 153697 RVA: 0x0052D1A8 File Offset: 0x0052B3A8
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

		// Token: 0x06025862 RID: 153698 RVA: 0x0052D398 File Offset: 0x0052B598
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

		// Token: 0x0400EC1B RID: 60443
		private Table __p;
	}
}
