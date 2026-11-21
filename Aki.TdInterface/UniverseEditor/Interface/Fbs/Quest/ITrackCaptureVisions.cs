using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004643 RID: 17987
	public struct ITrackCaptureVisions : IFlatbufferObject
	{
		// Token: 0x17007DE1 RID: 32225
		// (get) Token: 0x0601A568 RID: 107880 RVA: 0x003BF9B5 File Offset: 0x003BDBB5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A569 RID: 107881 RVA: 0x003BF9C2 File Offset: 0x003BDBC2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A56A RID: 107882 RVA: 0x003BF9CC File Offset: 0x003BDBCC
		public static ITrackCaptureVisions GetRootAsITrackCaptureVisions(ByteBuffer _bb)
		{
			return ITrackCaptureVisions.GetRootAsITrackCaptureVisions(_bb, default(ITrackCaptureVisions));
		}

		// Token: 0x0601A56B RID: 107883 RVA: 0x003BF9E8 File Offset: 0x003BDBE8
		public static ITrackCaptureVisions GetRootAsITrackCaptureVisions(ByteBuffer _bb, ITrackCaptureVisions obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A56C RID: 107884 RVA: 0x003BFA05 File Offset: 0x003BDC05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A56D RID: 107885 RVA: 0x003BFA14 File Offset: 0x003BDC14
		public ITrackCaptureVisions __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007DE2 RID: 32226
		// (get) Token: 0x0601A56E RID: 107886 RVA: 0x003BFA24 File Offset: 0x003BDC24
		public ETrackType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETrackType.Locations;
				}
				return (ETrackType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007DE3 RID: 32227
		// (get) Token: 0x0601A56F RID: 107887 RVA: 0x003BFA60 File Offset: 0x003BDC60
		public TGravityDirection GravityDirectionType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TGravityDirection.NONE;
				}
				return (TGravityDirection)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601A570 RID: 107888 RVA: 0x003BFA9C File Offset: 0x003BDC9C
		public TTable? GravityDirection<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601A571 RID: 107889 RVA: 0x003BFAE0 File Offset: 0x003BDCE0
		public IGravityDirectionByEntityGravity GravityDirectionAsIGravityDirectionByEntityGravity()
		{
			return this.GravityDirection<IGravityDirectionByEntityGravity>().Value;
		}

		// Token: 0x0601A572 RID: 107890 RVA: 0x003BFAFC File Offset: 0x003BDCFC
		public IGravityDirectionSelfRotation GravityDirectionAsIGravityDirectionSelfRotation()
		{
			return this.GravityDirection<IGravityDirectionSelfRotation>().Value;
		}

		// Token: 0x0601A573 RID: 107891 RVA: 0x003BFB18 File Offset: 0x003BDD18
		public IGravityDirectionVectorInfo GravityDirectionAsIGravityDirectionVectorInfo()
		{
			return this.GravityDirection<IGravityDirectionVectorInfo>().Value;
		}

		// Token: 0x0601A574 RID: 107892 RVA: 0x003BFB34 File Offset: 0x003BDD34
		public IGravityDirectionWorldAxis GravityDirectionAsIGravityDirectionWorldAxis()
		{
			return this.GravityDirection<IGravityDirectionWorldAxis>().Value;
		}

		// Token: 0x0601A575 RID: 107893 RVA: 0x003BFB50 File Offset: 0x003BDD50
		public int VisionDropEntities(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007DE4 RID: 32228
		// (get) Token: 0x0601A576 RID: 107894 RVA: 0x003BFB90 File Offset: 0x003BDD90
		public int VisionDropEntitiesLength
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

		// Token: 0x0601A577 RID: 107895 RVA: 0x003BFBBC File Offset: 0x003BDDBC
		public Span<int> GetVisionDropEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0601A578 RID: 107896 RVA: 0x003BFBCC File Offset: 0x003BDDCC
		public int[] GetVisionDropEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x0601A579 RID: 107897 RVA: 0x003BFBDB File Offset: 0x003BDDDB
		public static Offset<ITrackCaptureVisions> CreateITrackCaptureVisions(FlatBufferBuilder builder, ETrackType Type = ETrackType.Locations, TGravityDirection GravityDirection_type = TGravityDirection.NONE, int GravityDirectionOffset = 0, VectorOffset VisionDropEntitiesOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			ITrackCaptureVisions.AddVisionDropEntities(builder, VisionDropEntitiesOffset);
			ITrackCaptureVisions.AddGravityDirection(builder, GravityDirectionOffset);
			ITrackCaptureVisions.AddGravityDirectionType(builder, GravityDirection_type);
			ITrackCaptureVisions.AddType(builder, Type);
			return ITrackCaptureVisions.EndITrackCaptureVisions(builder);
		}

		// Token: 0x0601A57A RID: 107898 RVA: 0x003BFC07 File Offset: 0x003BDE07
		public static void StartITrackCaptureVisions(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601A57B RID: 107899 RVA: 0x003BFC10 File Offset: 0x003BDE10
		public static void AddType(FlatBufferBuilder builder, ETrackType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A57C RID: 107900 RVA: 0x003BFC1B File Offset: 0x003BDE1B
		public static void AddGravityDirectionType(FlatBufferBuilder builder, TGravityDirection gravityDirectionType)
		{
			builder.AddByte(1, (byte)gravityDirectionType, 0);
		}

		// Token: 0x0601A57D RID: 107901 RVA: 0x003BFC26 File Offset: 0x003BDE26
		public static void AddGravityDirection(FlatBufferBuilder builder, int gravityDirectionOffset)
		{
			builder.AddOffset(2, gravityDirectionOffset, 0);
		}

		// Token: 0x0601A57E RID: 107902 RVA: 0x003BFC31 File Offset: 0x003BDE31
		public static void AddVisionDropEntities(FlatBufferBuilder builder, VectorOffset visionDropEntitiesOffset)
		{
			builder.AddOffset(3, visionDropEntitiesOffset.Value, 0);
		}

		// Token: 0x0601A57F RID: 107903 RVA: 0x003BFC44 File Offset: 0x003BDE44
		public static VectorOffset CreateVisionDropEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601A580 RID: 107904 RVA: 0x003BFC7B File Offset: 0x003BDE7B
		public static VectorOffset CreateVisionDropEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A581 RID: 107905 RVA: 0x003BFC95 File Offset: 0x003BDE95
		public static VectorOffset CreateVisionDropEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A582 RID: 107906 RVA: 0x003BFCB3 File Offset: 0x003BDEB3
		public static VectorOffset CreateVisionDropEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601A583 RID: 107907 RVA: 0x003BFCCC File Offset: 0x003BDECC
		public static void StartVisionDropEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601A584 RID: 107908 RVA: 0x003BFCD7 File Offset: 0x003BDED7
		public static Offset<ITrackCaptureVisions> EndITrackCaptureVisions(FlatBufferBuilder builder)
		{
			return new Offset<ITrackCaptureVisions>(builder.EndTable());
		}

		// Token: 0x0601A585 RID: 107909 RVA: 0x003BFCE4 File Offset: 0x003BDEE4
		public ITrackCaptureVisionsT UnPack()
		{
			ITrackCaptureVisionsT trackCaptureVisionsT = new ITrackCaptureVisionsT();
			this.UnPackTo(trackCaptureVisionsT);
			return trackCaptureVisionsT;
		}

		// Token: 0x0601A586 RID: 107910 RVA: 0x003BFD00 File Offset: 0x003BDF00
		public void UnPackTo(ITrackCaptureVisionsT _o)
		{
			_o.Type = this.Type;
			_o.GravityDirection = new TGravityDirectionUnion();
			_o.GravityDirection.Type = this.GravityDirectionType;
			switch (this.GravityDirectionType)
			{
			case TGravityDirection.IGravityDirectionByEntityGravity:
				_o.GravityDirection.Value = ((this.GravityDirection<IGravityDirectionByEntityGravity>() != null) ? this.GravityDirection<IGravityDirectionByEntityGravity>().Value.UnPack() : null);
				break;
			case TGravityDirection.IGravityDirectionSelfRotation:
				_o.GravityDirection.Value = ((this.GravityDirection<IGravityDirectionSelfRotation>() != null) ? this.GravityDirection<IGravityDirectionSelfRotation>().Value.UnPack() : null);
				break;
			case TGravityDirection.IGravityDirectionVectorInfo:
				_o.GravityDirection.Value = ((this.GravityDirection<IGravityDirectionVectorInfo>() != null) ? this.GravityDirection<IGravityDirectionVectorInfo>().Value.UnPack() : null);
				break;
			case TGravityDirection.IGravityDirectionWorldAxis:
				_o.GravityDirection.Value = ((this.GravityDirection<IGravityDirectionWorldAxis>() != null) ? this.GravityDirection<IGravityDirectionWorldAxis>().Value.UnPack() : null);
				break;
			}
			_o.VisionDropEntities = new List<int>();
			for (int i = 0; i < this.VisionDropEntitiesLength; i++)
			{
				_o.VisionDropEntities.Add(this.VisionDropEntities(i));
			}
		}

		// Token: 0x0601A587 RID: 107911 RVA: 0x003BFE6C File Offset: 0x003BE06C
		public static Offset<ITrackCaptureVisions> Pack(FlatBufferBuilder builder, ITrackCaptureVisionsT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrackCaptureVisions>);
			}
			TGravityDirection gravityDirection_type = (_o.GravityDirection == null) ? TGravityDirection.NONE : _o.GravityDirection.Type;
			int gravityDirectionOffset = (_o.GravityDirection == null) ? 0 : TGravityDirectionUnion.Pack(builder, _o.GravityDirection);
			VectorOffset visionDropEntitiesOffset = default(VectorOffset);
			if (_o.VisionDropEntities != null)
			{
				int[] data = _o.VisionDropEntities.ToArray();
				visionDropEntitiesOffset = ITrackCaptureVisions.CreateVisionDropEntitiesVector(builder, data);
			}
			return ITrackCaptureVisions.CreateITrackCaptureVisions(builder, _o.Type, gravityDirection_type, gravityDirectionOffset, visionDropEntitiesOffset);
		}

		// Token: 0x0400C849 RID: 51273
		private Table __p;
	}
}
