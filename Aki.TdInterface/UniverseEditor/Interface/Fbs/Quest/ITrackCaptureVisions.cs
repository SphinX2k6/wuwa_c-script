using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041EA RID: 16874
	public struct ITrackCaptureVisions : IFlatbufferObject
	{
		// Token: 0x170077B5 RID: 30645
		// (get) Token: 0x06018E12 RID: 101906 RVA: 0x00394561 File Offset: 0x00392761
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018E13 RID: 101907 RVA: 0x0039456E File Offset: 0x0039276E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018E14 RID: 101908 RVA: 0x00394578 File Offset: 0x00392778
		public static ITrackCaptureVisions GetRootAsITrackCaptureVisions(ByteBuffer _bb)
		{
			return ITrackCaptureVisions.GetRootAsITrackCaptureVisions(_bb, default(ITrackCaptureVisions));
		}

		// Token: 0x06018E15 RID: 101909 RVA: 0x00394594 File Offset: 0x00392794
		public static ITrackCaptureVisions GetRootAsITrackCaptureVisions(ByteBuffer _bb, ITrackCaptureVisions obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018E16 RID: 101910 RVA: 0x003945B1 File Offset: 0x003927B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018E17 RID: 101911 RVA: 0x003945C0 File Offset: 0x003927C0
		public ITrackCaptureVisions __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170077B6 RID: 30646
		// (get) Token: 0x06018E18 RID: 101912 RVA: 0x003945D0 File Offset: 0x003927D0
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

		// Token: 0x170077B7 RID: 30647
		// (get) Token: 0x06018E19 RID: 101913 RVA: 0x0039460C File Offset: 0x0039280C
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

		// Token: 0x06018E1A RID: 101914 RVA: 0x00394648 File Offset: 0x00392848
		public TTable? GravityDirection<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06018E1B RID: 101915 RVA: 0x0039468C File Offset: 0x0039288C
		public IGravityDirectionByEntityGravity GravityDirectionAsIGravityDirectionByEntityGravity()
		{
			return this.GravityDirection<IGravityDirectionByEntityGravity>().Value;
		}

		// Token: 0x06018E1C RID: 101916 RVA: 0x003946A8 File Offset: 0x003928A8
		public IGravityDirectionSelfRotation GravityDirectionAsIGravityDirectionSelfRotation()
		{
			return this.GravityDirection<IGravityDirectionSelfRotation>().Value;
		}

		// Token: 0x06018E1D RID: 101917 RVA: 0x003946C4 File Offset: 0x003928C4
		public IGravityDirectionVectorInfo GravityDirectionAsIGravityDirectionVectorInfo()
		{
			return this.GravityDirection<IGravityDirectionVectorInfo>().Value;
		}

		// Token: 0x06018E1E RID: 101918 RVA: 0x003946E0 File Offset: 0x003928E0
		public IGravityDirectionWorldAxis GravityDirectionAsIGravityDirectionWorldAxis()
		{
			return this.GravityDirection<IGravityDirectionWorldAxis>().Value;
		}

		// Token: 0x06018E1F RID: 101919 RVA: 0x003946FC File Offset: 0x003928FC
		public int VisionDropEntities(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170077B8 RID: 30648
		// (get) Token: 0x06018E20 RID: 101920 RVA: 0x0039473C File Offset: 0x0039293C
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

		// Token: 0x06018E21 RID: 101921 RVA: 0x00394768 File Offset: 0x00392968
		public Span<int> GetVisionDropEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06018E22 RID: 101922 RVA: 0x00394778 File Offset: 0x00392978
		public int[] GetVisionDropEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x06018E23 RID: 101923 RVA: 0x00394787 File Offset: 0x00392987
		public static Offset<ITrackCaptureVisions> CreateITrackCaptureVisions(FlatBufferBuilder builder, ETrackType Type = ETrackType.Locations, TGravityDirection GravityDirection_type = TGravityDirection.NONE, int GravityDirectionOffset = 0, VectorOffset VisionDropEntitiesOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			ITrackCaptureVisions.AddVisionDropEntities(builder, VisionDropEntitiesOffset);
			ITrackCaptureVisions.AddGravityDirection(builder, GravityDirectionOffset);
			ITrackCaptureVisions.AddGravityDirectionType(builder, GravityDirection_type);
			ITrackCaptureVisions.AddType(builder, Type);
			return ITrackCaptureVisions.EndITrackCaptureVisions(builder);
		}

		// Token: 0x06018E24 RID: 101924 RVA: 0x003947B3 File Offset: 0x003929B3
		public static void StartITrackCaptureVisions(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06018E25 RID: 101925 RVA: 0x003947BC File Offset: 0x003929BC
		public static void AddType(FlatBufferBuilder builder, ETrackType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018E26 RID: 101926 RVA: 0x003947C7 File Offset: 0x003929C7
		public static void AddGravityDirectionType(FlatBufferBuilder builder, TGravityDirection gravityDirectionType)
		{
			builder.AddByte(1, (byte)gravityDirectionType, 0);
		}

		// Token: 0x06018E27 RID: 101927 RVA: 0x003947D2 File Offset: 0x003929D2
		public static void AddGravityDirection(FlatBufferBuilder builder, int gravityDirectionOffset)
		{
			builder.AddOffset(2, gravityDirectionOffset, 0);
		}

		// Token: 0x06018E28 RID: 101928 RVA: 0x003947DD File Offset: 0x003929DD
		public static void AddVisionDropEntities(FlatBufferBuilder builder, VectorOffset visionDropEntitiesOffset)
		{
			builder.AddOffset(3, visionDropEntitiesOffset.Value, 0);
		}

		// Token: 0x06018E29 RID: 101929 RVA: 0x003947F0 File Offset: 0x003929F0
		public static VectorOffset CreateVisionDropEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06018E2A RID: 101930 RVA: 0x00394827 File Offset: 0x00392A27
		public static VectorOffset CreateVisionDropEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06018E2B RID: 101931 RVA: 0x00394841 File Offset: 0x00392A41
		public static VectorOffset CreateVisionDropEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06018E2C RID: 101932 RVA: 0x0039485F File Offset: 0x00392A5F
		public static VectorOffset CreateVisionDropEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018E2D RID: 101933 RVA: 0x00394878 File Offset: 0x00392A78
		public static void StartVisionDropEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06018E2E RID: 101934 RVA: 0x00394883 File Offset: 0x00392A83
		public static Offset<ITrackCaptureVisions> EndITrackCaptureVisions(FlatBufferBuilder builder)
		{
			return new Offset<ITrackCaptureVisions>(builder.EndTable());
		}

		// Token: 0x06018E2F RID: 101935 RVA: 0x00394890 File Offset: 0x00392A90
		public ITrackCaptureVisionsT UnPack()
		{
			ITrackCaptureVisionsT trackCaptureVisionsT = new ITrackCaptureVisionsT();
			this.UnPackTo(trackCaptureVisionsT);
			return trackCaptureVisionsT;
		}

		// Token: 0x06018E30 RID: 101936 RVA: 0x003948AC File Offset: 0x00392AAC
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

		// Token: 0x06018E31 RID: 101937 RVA: 0x00394A18 File Offset: 0x00392C18
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

		// Token: 0x0400BE3F RID: 48703
		private Table __p;
	}
}
