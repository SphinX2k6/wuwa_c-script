using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200686E RID: 26734
	public struct IBeginFlowTemplate : IFlatbufferObject
	{
		// Token: 0x1700C47D RID: 50301
		// (get) Token: 0x0602DB18 RID: 187160 RVA: 0x0063FA45 File Offset: 0x0063DC45
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DB19 RID: 187161 RVA: 0x0063FA52 File Offset: 0x0063DC52
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DB1A RID: 187162 RVA: 0x0063FA5C File Offset: 0x0063DC5C
		public static IBeginFlowTemplate GetRootAsIBeginFlowTemplate(ByteBuffer _bb)
		{
			return IBeginFlowTemplate.GetRootAsIBeginFlowTemplate(_bb, default(IBeginFlowTemplate));
		}

		// Token: 0x0602DB1B RID: 187163 RVA: 0x0063FA78 File Offset: 0x0063DC78
		public static IBeginFlowTemplate GetRootAsIBeginFlowTemplate(ByteBuffer _bb, IBeginFlowTemplate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DB1C RID: 187164 RVA: 0x0063FA95 File Offset: 0x0063DC95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DB1D RID: 187165 RVA: 0x0063FAA4 File Offset: 0x0063DCA4
		public IBeginFlowTemplate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C47E RID: 50302
		// (get) Token: 0x0602DB1E RID: 187166 RVA: 0x0063FAB4 File Offset: 0x0063DCB4
		public bool _Folded
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602DB1F RID: 187167 RVA: 0x0063FAF4 File Offset: 0x0063DCF4
		public IFlowActorUnit? Actors(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IFlowActorUnit?(default(IFlowActorUnit).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700C47F RID: 50303
		// (get) Token: 0x0602DB20 RID: 187168 RVA: 0x0063FB54 File Offset: 0x0063DD54
		public int ActorsLength
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

		// Token: 0x0602DB21 RID: 187169 RVA: 0x0063FB80 File Offset: 0x0063DD80
		public int MontageIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C480 RID: 50304
		// (get) Token: 0x0602DB22 RID: 187170 RVA: 0x0063FBC0 File Offset: 0x0063DDC0
		public int MontageIdsLength
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

		// Token: 0x0602DB23 RID: 187171 RVA: 0x0063FBEB File Offset: 0x0063DDEB
		public Span<int> GetMontageIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0602DB24 RID: 187172 RVA: 0x0063FBFA File Offset: 0x0063DDFA
		public int[] GetMontageIdsArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x1700C481 RID: 50305
		// (get) Token: 0x0602DB25 RID: 187173 RVA: 0x0063FC08 File Offset: 0x0063DE08
		public bool UseFreeCamera
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C482 RID: 50306
		// (get) Token: 0x0602DB26 RID: 187174 RVA: 0x0063FC48 File Offset: 0x0063DE48
		public bool IsSwitchMainRole
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C483 RID: 50307
		// (get) Token: 0x0602DB27 RID: 187175 RVA: 0x0063FC88 File Offset: 0x0063DE88
		public bool IsUseSeqFace
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C484 RID: 50308
		// (get) Token: 0x0602DB28 RID: 187176 RVA: 0x0063FCC8 File Offset: 0x0063DEC8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602DB29 RID: 187177 RVA: 0x0063FD08 File Offset: 0x0063DF08
		public static Offset<IBeginFlowTemplate> CreateIBeginFlowTemplate(FlatBufferBuilder builder, bool _folded = false, VectorOffset ActorsOffset = default(VectorOffset), VectorOffset MontageIdsOffset = default(VectorOffset), bool UseFreeCamera = false, bool IsSwitchMainRole = false, bool IsUseSeqFace = false, byte NullMask = 0)
		{
			builder.StartTable(7);
			IBeginFlowTemplate.AddMontageIds(builder, MontageIdsOffset);
			IBeginFlowTemplate.AddActors(builder, ActorsOffset);
			IBeginFlowTemplate.AddNullMask(builder, NullMask);
			IBeginFlowTemplate.AddIsUseSeqFace(builder, IsUseSeqFace);
			IBeginFlowTemplate.AddIsSwitchMainRole(builder, IsSwitchMainRole);
			IBeginFlowTemplate.AddUseFreeCamera(builder, UseFreeCamera);
			IBeginFlowTemplate.Add_Folded(builder, _folded);
			return IBeginFlowTemplate.EndIBeginFlowTemplate(builder);
		}

		// Token: 0x0602DB2A RID: 187178 RVA: 0x0063FD57 File Offset: 0x0063DF57
		public static void StartIBeginFlowTemplate(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0602DB2B RID: 187179 RVA: 0x0063FD60 File Offset: 0x0063DF60
		public static void Add_Folded(FlatBufferBuilder builder, bool _Folded)
		{
			builder.AddBool(0, _Folded, false);
		}

		// Token: 0x0602DB2C RID: 187180 RVA: 0x0063FD6B File Offset: 0x0063DF6B
		public static void AddActors(FlatBufferBuilder builder, VectorOffset actorsOffset)
		{
			builder.AddOffset(1, actorsOffset.Value, 0);
		}

		// Token: 0x0602DB2D RID: 187181 RVA: 0x0063FD7C File Offset: 0x0063DF7C
		public static VectorOffset CreateActorsVector(FlatBufferBuilder builder, Offset<IFlowActorUnit>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602DB2E RID: 187182 RVA: 0x0063FDBC File Offset: 0x0063DFBC
		public static VectorOffset CreateActorsVectorBlock(FlatBufferBuilder builder, Offset<IFlowActorUnit>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IFlowActorUnit>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602DB2F RID: 187183 RVA: 0x0063FDD6 File Offset: 0x0063DFD6
		public static VectorOffset CreateActorsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IFlowActorUnit>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IFlowActorUnit>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602DB30 RID: 187184 RVA: 0x0063FDF4 File Offset: 0x0063DFF4
		public static VectorOffset CreateActorsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IFlowActorUnit>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602DB31 RID: 187185 RVA: 0x0063FE0D File Offset: 0x0063E00D
		public static void StartActorsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602DB32 RID: 187186 RVA: 0x0063FE18 File Offset: 0x0063E018
		public static void AddMontageIds(FlatBufferBuilder builder, VectorOffset montageIdsOffset)
		{
			builder.AddOffset(2, montageIdsOffset.Value, 0);
		}

		// Token: 0x0602DB33 RID: 187187 RVA: 0x0063FE28 File Offset: 0x0063E028
		public static VectorOffset CreateMontageIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602DB34 RID: 187188 RVA: 0x0063FE5F File Offset: 0x0063E05F
		public static VectorOffset CreateMontageIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602DB35 RID: 187189 RVA: 0x0063FE79 File Offset: 0x0063E079
		public static VectorOffset CreateMontageIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602DB36 RID: 187190 RVA: 0x0063FE97 File Offset: 0x0063E097
		public static VectorOffset CreateMontageIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602DB37 RID: 187191 RVA: 0x0063FEB0 File Offset: 0x0063E0B0
		public static void StartMontageIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602DB38 RID: 187192 RVA: 0x0063FEBB File Offset: 0x0063E0BB
		public static void AddUseFreeCamera(FlatBufferBuilder builder, bool useFreeCamera)
		{
			builder.AddBool(3, useFreeCamera, false);
		}

		// Token: 0x0602DB39 RID: 187193 RVA: 0x0063FEC6 File Offset: 0x0063E0C6
		public static void AddIsSwitchMainRole(FlatBufferBuilder builder, bool isSwitchMainRole)
		{
			builder.AddBool(4, isSwitchMainRole, false);
		}

		// Token: 0x0602DB3A RID: 187194 RVA: 0x0063FED1 File Offset: 0x0063E0D1
		public static void AddIsUseSeqFace(FlatBufferBuilder builder, bool isUseSeqFace)
		{
			builder.AddBool(5, isUseSeqFace, false);
		}

		// Token: 0x0602DB3B RID: 187195 RVA: 0x0063FEDC File Offset: 0x0063E0DC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0602DB3C RID: 187196 RVA: 0x0063FEE7 File Offset: 0x0063E0E7
		public static Offset<IBeginFlowTemplate> EndIBeginFlowTemplate(FlatBufferBuilder builder)
		{
			return new Offset<IBeginFlowTemplate>(builder.EndTable());
		}

		// Token: 0x0602DB3D RID: 187197 RVA: 0x0063FEF4 File Offset: 0x0063E0F4
		public IBeginFlowTemplateT UnPack()
		{
			IBeginFlowTemplateT beginFlowTemplateT = new IBeginFlowTemplateT();
			this.UnPackTo(beginFlowTemplateT);
			return beginFlowTemplateT;
		}

		// Token: 0x0602DB3E RID: 187198 RVA: 0x0063FF10 File Offset: 0x0063E110
		public void UnPackTo(IBeginFlowTemplateT _o)
		{
			_o._Folded = this._Folded;
			_o.Actors = new List<IFlowActorUnitT>();
			for (int i = 0; i < this.ActorsLength; i++)
			{
				_o.Actors.Add((this.Actors(i) != null) ? this.Actors(i).Value.UnPack() : null);
			}
			_o.MontageIds = new List<int>();
			for (int j = 0; j < this.MontageIdsLength; j++)
			{
				_o.MontageIds.Add(this.MontageIds(j));
			}
			_o.UseFreeCamera = this.UseFreeCamera;
			_o.IsSwitchMainRole = this.IsSwitchMainRole;
			_o.IsUseSeqFace = this.IsUseSeqFace;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602DB3F RID: 187199 RVA: 0x0063FFDC File Offset: 0x0063E1DC
		public static Offset<IBeginFlowTemplate> Pack(FlatBufferBuilder builder, IBeginFlowTemplateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBeginFlowTemplate>);
			}
			VectorOffset actorsOffset = default(VectorOffset);
			if (_o.Actors != null)
			{
				Offset<IFlowActorUnit>[] array = new Offset<IFlowActorUnit>[_o.Actors.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IFlowActorUnit.Pack(builder, _o.Actors[i]);
				}
				actorsOffset = IBeginFlowTemplate.CreateActorsVector(builder, array);
			}
			VectorOffset montageIdsOffset = default(VectorOffset);
			if (_o.MontageIds != null)
			{
				int[] data = _o.MontageIds.ToArray();
				montageIdsOffset = IBeginFlowTemplate.CreateMontageIdsVector(builder, data);
			}
			return IBeginFlowTemplate.CreateIBeginFlowTemplate(builder, _o._Folded, actorsOffset, montageIdsOffset, _o.UseFreeCamera, _o.IsSwitchMainRole, _o.IsUseSeqFace, _o.NullMask);
		}

		// Token: 0x04011546 RID: 70982
		private Table __p;
	}
}
