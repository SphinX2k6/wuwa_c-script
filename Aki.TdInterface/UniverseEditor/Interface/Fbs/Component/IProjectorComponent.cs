using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057A8 RID: 22440
	public struct IProjectorComponent : IFlatbufferObject
	{
		// Token: 0x1700A777 RID: 42871
		// (get) Token: 0x06025A64 RID: 154212 RVA: 0x00531887 File Offset: 0x0052FA87
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025A65 RID: 154213 RVA: 0x00531894 File Offset: 0x0052FA94
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025A66 RID: 154214 RVA: 0x0053189C File Offset: 0x0052FA9C
		public static IProjectorComponent GetRootAsIProjectorComponent(ByteBuffer _bb)
		{
			return IProjectorComponent.GetRootAsIProjectorComponent(_bb, default(IProjectorComponent));
		}

		// Token: 0x06025A67 RID: 154215 RVA: 0x005318B8 File Offset: 0x0052FAB8
		public static IProjectorComponent GetRootAsIProjectorComponent(ByteBuffer _bb, IProjectorComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025A68 RID: 154216 RVA: 0x005318D5 File Offset: 0x0052FAD5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025A69 RID: 154217 RVA: 0x005318E4 File Offset: 0x0052FAE4
		public IProjectorComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A778 RID: 42872
		// (get) Token: 0x06025A6A RID: 154218 RVA: 0x005318F4 File Offset: 0x0052FAF4
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A779 RID: 42873
		// (get) Token: 0x06025A6B RID: 154219 RVA: 0x00531934 File Offset: 0x0052FB34
		public int ProjectorPatternId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A77A RID: 42874
		// (get) Token: 0x06025A6C RID: 154220 RVA: 0x00531970 File Offset: 0x0052FB70
		public float RotationSpeed
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A77B RID: 42875
		// (get) Token: 0x06025A6D RID: 154221 RVA: 0x005319B0 File Offset: 0x0052FBB0
		public float DragRotationCoefficient
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025A6E RID: 154222 RVA: 0x005319F4 File Offset: 0x0052FBF4
		public IVectorInfo? RotationTargetAngles(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A77C RID: 42876
		// (get) Token: 0x06025A6F RID: 154223 RVA: 0x00531A58 File Offset: 0x0052FC58
		public int RotationTargetAnglesLength
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

		// Token: 0x1700A77D RID: 42877
		// (get) Token: 0x06025A70 RID: 154224 RVA: 0x00531A84 File Offset: 0x0052FC84
		public float MatchTolerance
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A77E RID: 42878
		// (get) Token: 0x06025A71 RID: 154225 RVA: 0x00531AC8 File Offset: 0x0052FCC8
		public int BackgroundEntityId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A77F RID: 42879
		// (get) Token: 0x06025A72 RID: 154226 RVA: 0x00531B08 File Offset: 0x0052FD08
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

		// Token: 0x06025A73 RID: 154227 RVA: 0x00531B48 File Offset: 0x0052FD48
		public static Offset<IProjectorComponent> CreateIProjectorComponent(FlatBufferBuilder builder, bool Disabled = false, int ProjectorPatternId = 0, float RotationSpeed = 0f, float DragRotationCoefficient = 0f, VectorOffset RotationTargetAnglesOffset = default(VectorOffset), float MatchTolerance = 0f, int BackgroundEntityId = 0, byte NullMask = 0)
		{
			builder.StartTable(8);
			IProjectorComponent.AddBackgroundEntityId(builder, BackgroundEntityId);
			IProjectorComponent.AddMatchTolerance(builder, MatchTolerance);
			IProjectorComponent.AddRotationTargetAngles(builder, RotationTargetAnglesOffset);
			IProjectorComponent.AddDragRotationCoefficient(builder, DragRotationCoefficient);
			IProjectorComponent.AddRotationSpeed(builder, RotationSpeed);
			IProjectorComponent.AddProjectorPatternId(builder, ProjectorPatternId);
			IProjectorComponent.AddNullMask(builder, NullMask);
			IProjectorComponent.AddDisabled(builder, Disabled);
			return IProjectorComponent.EndIProjectorComponent(builder);
		}

		// Token: 0x06025A74 RID: 154228 RVA: 0x00531B9F File Offset: 0x0052FD9F
		public static void StartIProjectorComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06025A75 RID: 154229 RVA: 0x00531BA8 File Offset: 0x0052FDA8
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06025A76 RID: 154230 RVA: 0x00531BB3 File Offset: 0x0052FDB3
		public static void AddProjectorPatternId(FlatBufferBuilder builder, int projectorPatternId)
		{
			builder.AddInt(1, projectorPatternId, 0);
		}

		// Token: 0x06025A77 RID: 154231 RVA: 0x00531BBE File Offset: 0x0052FDBE
		public static void AddRotationSpeed(FlatBufferBuilder builder, float rotationSpeed)
		{
			builder.AddFloat(2, rotationSpeed, 0.0);
		}

		// Token: 0x06025A78 RID: 154232 RVA: 0x00531BD1 File Offset: 0x0052FDD1
		public static void AddDragRotationCoefficient(FlatBufferBuilder builder, float dragRotationCoefficient)
		{
			builder.AddFloat(3, dragRotationCoefficient, 0.0);
		}

		// Token: 0x06025A79 RID: 154233 RVA: 0x00531BE4 File Offset: 0x0052FDE4
		public static void AddRotationTargetAngles(FlatBufferBuilder builder, VectorOffset rotationTargetAnglesOffset)
		{
			builder.AddOffset(4, rotationTargetAnglesOffset.Value, 0);
		}

		// Token: 0x06025A7A RID: 154234 RVA: 0x00531BF4 File Offset: 0x0052FDF4
		public static VectorOffset CreateRotationTargetAnglesVector(FlatBufferBuilder builder, Offset<IVectorInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06025A7B RID: 154235 RVA: 0x00531C34 File Offset: 0x0052FE34
		public static VectorOffset CreateRotationTargetAnglesVectorBlock(FlatBufferBuilder builder, Offset<IVectorInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IVectorInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025A7C RID: 154236 RVA: 0x00531C4E File Offset: 0x0052FE4E
		public static VectorOffset CreateRotationTargetAnglesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IVectorInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IVectorInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025A7D RID: 154237 RVA: 0x00531C6C File Offset: 0x0052FE6C
		public static VectorOffset CreateRotationTargetAnglesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IVectorInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025A7E RID: 154238 RVA: 0x00531C85 File Offset: 0x0052FE85
		public static void StartRotationTargetAnglesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025A7F RID: 154239 RVA: 0x00531C90 File Offset: 0x0052FE90
		public static void AddMatchTolerance(FlatBufferBuilder builder, float matchTolerance)
		{
			builder.AddFloat(5, matchTolerance, 0.0);
		}

		// Token: 0x06025A80 RID: 154240 RVA: 0x00531CA3 File Offset: 0x0052FEA3
		public static void AddBackgroundEntityId(FlatBufferBuilder builder, int backgroundEntityId)
		{
			builder.AddInt(6, backgroundEntityId, 0);
		}

		// Token: 0x06025A81 RID: 154241 RVA: 0x00531CAE File Offset: 0x0052FEAE
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06025A82 RID: 154242 RVA: 0x00531CB9 File Offset: 0x0052FEB9
		public static Offset<IProjectorComponent> EndIProjectorComponent(FlatBufferBuilder builder)
		{
			return new Offset<IProjectorComponent>(builder.EndTable());
		}

		// Token: 0x06025A83 RID: 154243 RVA: 0x00531CC8 File Offset: 0x0052FEC8
		public IProjectorComponentT UnPack()
		{
			IProjectorComponentT projectorComponentT = new IProjectorComponentT();
			this.UnPackTo(projectorComponentT);
			return projectorComponentT;
		}

		// Token: 0x06025A84 RID: 154244 RVA: 0x00531CE4 File Offset: 0x0052FEE4
		public void UnPackTo(IProjectorComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.ProjectorPatternId = this.ProjectorPatternId;
			_o.RotationSpeed = this.RotationSpeed;
			_o.DragRotationCoefficient = this.DragRotationCoefficient;
			_o.RotationTargetAngles = new List<IVectorInfoT>();
			for (int i = 0; i < this.RotationTargetAnglesLength; i++)
			{
				_o.RotationTargetAngles.Add((this.RotationTargetAngles(i) != null) ? this.RotationTargetAngles(i).Value.UnPack() : null);
			}
			_o.MatchTolerance = this.MatchTolerance;
			_o.BackgroundEntityId = this.BackgroundEntityId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06025A85 RID: 154245 RVA: 0x00531D98 File Offset: 0x0052FF98
		public static Offset<IProjectorComponent> Pack(FlatBufferBuilder builder, IProjectorComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IProjectorComponent>);
			}
			VectorOffset rotationTargetAnglesOffset = default(VectorOffset);
			if (_o.RotationTargetAngles != null)
			{
				Offset<IVectorInfo>[] array = new Offset<IVectorInfo>[_o.RotationTargetAngles.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IVectorInfo.Pack(builder, _o.RotationTargetAngles[i]);
				}
				rotationTargetAnglesOffset = IProjectorComponent.CreateRotationTargetAnglesVector(builder, array);
			}
			return IProjectorComponent.CreateIProjectorComponent(builder, _o.Disabled, _o.ProjectorPatternId, _o.RotationSpeed, _o.DragRotationCoefficient, rotationTargetAnglesOffset, _o.MatchTolerance, _o.BackgroundEntityId, _o.NullMask);
		}

		// Token: 0x0400EC77 RID: 60535
		private Table __p;
	}
}
