using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DAF RID: 23983
	public struct IProjectorComponent : IFlatbufferObject
	{
		// Token: 0x1700B09B RID: 45211
		// (get) Token: 0x06027F84 RID: 163716 RVA: 0x00577A13 File Offset: 0x00575C13
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027F85 RID: 163717 RVA: 0x00577A20 File Offset: 0x00575C20
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027F86 RID: 163718 RVA: 0x00577A28 File Offset: 0x00575C28
		public static IProjectorComponent GetRootAsIProjectorComponent(ByteBuffer _bb)
		{
			return IProjectorComponent.GetRootAsIProjectorComponent(_bb, default(IProjectorComponent));
		}

		// Token: 0x06027F87 RID: 163719 RVA: 0x00577A44 File Offset: 0x00575C44
		public static IProjectorComponent GetRootAsIProjectorComponent(ByteBuffer _bb, IProjectorComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027F88 RID: 163720 RVA: 0x00577A61 File Offset: 0x00575C61
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027F89 RID: 163721 RVA: 0x00577A70 File Offset: 0x00575C70
		public IProjectorComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B09C RID: 45212
		// (get) Token: 0x06027F8A RID: 163722 RVA: 0x00577A80 File Offset: 0x00575C80
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B09D RID: 45213
		// (get) Token: 0x06027F8B RID: 163723 RVA: 0x00577AC0 File Offset: 0x00575CC0
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

		// Token: 0x1700B09E RID: 45214
		// (get) Token: 0x06027F8C RID: 163724 RVA: 0x00577AFC File Offset: 0x00575CFC
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

		// Token: 0x1700B09F RID: 45215
		// (get) Token: 0x06027F8D RID: 163725 RVA: 0x00577B3C File Offset: 0x00575D3C
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

		// Token: 0x06027F8E RID: 163726 RVA: 0x00577B80 File Offset: 0x00575D80
		public IVectorInfo? RotationTargetAngles(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B0A0 RID: 45216
		// (get) Token: 0x06027F8F RID: 163727 RVA: 0x00577BE4 File Offset: 0x00575DE4
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

		// Token: 0x1700B0A1 RID: 45217
		// (get) Token: 0x06027F90 RID: 163728 RVA: 0x00577C10 File Offset: 0x00575E10
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

		// Token: 0x1700B0A2 RID: 45218
		// (get) Token: 0x06027F91 RID: 163729 RVA: 0x00577C54 File Offset: 0x00575E54
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

		// Token: 0x1700B0A3 RID: 45219
		// (get) Token: 0x06027F92 RID: 163730 RVA: 0x00577C94 File Offset: 0x00575E94
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

		// Token: 0x06027F93 RID: 163731 RVA: 0x00577CD4 File Offset: 0x00575ED4
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

		// Token: 0x06027F94 RID: 163732 RVA: 0x00577D2B File Offset: 0x00575F2B
		public static void StartIProjectorComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06027F95 RID: 163733 RVA: 0x00577D34 File Offset: 0x00575F34
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06027F96 RID: 163734 RVA: 0x00577D3F File Offset: 0x00575F3F
		public static void AddProjectorPatternId(FlatBufferBuilder builder, int projectorPatternId)
		{
			builder.AddInt(1, projectorPatternId, 0);
		}

		// Token: 0x06027F97 RID: 163735 RVA: 0x00577D4A File Offset: 0x00575F4A
		public static void AddRotationSpeed(FlatBufferBuilder builder, float rotationSpeed)
		{
			builder.AddFloat(2, rotationSpeed, 0.0);
		}

		// Token: 0x06027F98 RID: 163736 RVA: 0x00577D5D File Offset: 0x00575F5D
		public static void AddDragRotationCoefficient(FlatBufferBuilder builder, float dragRotationCoefficient)
		{
			builder.AddFloat(3, dragRotationCoefficient, 0.0);
		}

		// Token: 0x06027F99 RID: 163737 RVA: 0x00577D70 File Offset: 0x00575F70
		public static void AddRotationTargetAngles(FlatBufferBuilder builder, VectorOffset rotationTargetAnglesOffset)
		{
			builder.AddOffset(4, rotationTargetAnglesOffset.Value, 0);
		}

		// Token: 0x06027F9A RID: 163738 RVA: 0x00577D80 File Offset: 0x00575F80
		public static VectorOffset CreateRotationTargetAnglesVector(FlatBufferBuilder builder, Offset<IVectorInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06027F9B RID: 163739 RVA: 0x00577DC0 File Offset: 0x00575FC0
		public static VectorOffset CreateRotationTargetAnglesVectorBlock(FlatBufferBuilder builder, Offset<IVectorInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IVectorInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027F9C RID: 163740 RVA: 0x00577DDA File Offset: 0x00575FDA
		public static VectorOffset CreateRotationTargetAnglesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IVectorInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IVectorInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027F9D RID: 163741 RVA: 0x00577DF8 File Offset: 0x00575FF8
		public static VectorOffset CreateRotationTargetAnglesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IVectorInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027F9E RID: 163742 RVA: 0x00577E11 File Offset: 0x00576011
		public static void StartRotationTargetAnglesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06027F9F RID: 163743 RVA: 0x00577E1C File Offset: 0x0057601C
		public static void AddMatchTolerance(FlatBufferBuilder builder, float matchTolerance)
		{
			builder.AddFloat(5, matchTolerance, 0.0);
		}

		// Token: 0x06027FA0 RID: 163744 RVA: 0x00577E2F File Offset: 0x0057602F
		public static void AddBackgroundEntityId(FlatBufferBuilder builder, int backgroundEntityId)
		{
			builder.AddInt(6, backgroundEntityId, 0);
		}

		// Token: 0x06027FA1 RID: 163745 RVA: 0x00577E3A File Offset: 0x0057603A
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06027FA2 RID: 163746 RVA: 0x00577E45 File Offset: 0x00576045
		public static Offset<IProjectorComponent> EndIProjectorComponent(FlatBufferBuilder builder)
		{
			return new Offset<IProjectorComponent>(builder.EndTable());
		}

		// Token: 0x06027FA3 RID: 163747 RVA: 0x00577E54 File Offset: 0x00576054
		public IProjectorComponentT UnPack()
		{
			IProjectorComponentT projectorComponentT = new IProjectorComponentT();
			this.UnPackTo(projectorComponentT);
			return projectorComponentT;
		}

		// Token: 0x06027FA4 RID: 163748 RVA: 0x00577E70 File Offset: 0x00576070
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

		// Token: 0x06027FA5 RID: 163749 RVA: 0x00577F24 File Offset: 0x00576124
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

		// Token: 0x0400F962 RID: 63842
		private Table __p;
	}
}
