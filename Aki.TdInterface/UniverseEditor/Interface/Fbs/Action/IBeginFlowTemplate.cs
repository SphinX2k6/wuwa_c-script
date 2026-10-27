using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061FD RID: 25085
	public struct IBeginFlowTemplate : IFlatbufferObject
	{
		// Token: 0x1700BAF7 RID: 47863
		// (get) Token: 0x0602B3BF RID: 177087 RVA: 0x005F4E5C File Offset: 0x005F305C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B3C0 RID: 177088 RVA: 0x005F4E69 File Offset: 0x005F3069
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B3C1 RID: 177089 RVA: 0x005F4E70 File Offset: 0x005F3070
		public static IBeginFlowTemplate GetRootAsIBeginFlowTemplate(ByteBuffer _bb)
		{
			return IBeginFlowTemplate.GetRootAsIBeginFlowTemplate(_bb, default(IBeginFlowTemplate));
		}

		// Token: 0x0602B3C2 RID: 177090 RVA: 0x005F4E8C File Offset: 0x005F308C
		public static IBeginFlowTemplate GetRootAsIBeginFlowTemplate(ByteBuffer _bb, IBeginFlowTemplate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B3C3 RID: 177091 RVA: 0x005F4EA9 File Offset: 0x005F30A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B3C4 RID: 177092 RVA: 0x005F4EB8 File Offset: 0x005F30B8
		public IBeginFlowTemplate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BAF8 RID: 47864
		// (get) Token: 0x0602B3C5 RID: 177093 RVA: 0x005F4EC8 File Offset: 0x005F30C8
		public bool _Folded
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602B3C6 RID: 177094 RVA: 0x005F4F08 File Offset: 0x005F3108
		public IFlowActorUnit? Actors(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IFlowActorUnit?(default(IFlowActorUnit).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700BAF9 RID: 47865
		// (get) Token: 0x0602B3C7 RID: 177095 RVA: 0x005F4F68 File Offset: 0x005F3168
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

		// Token: 0x0602B3C8 RID: 177096 RVA: 0x005F4F94 File Offset: 0x005F3194
		public int MontageIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700BAFA RID: 47866
		// (get) Token: 0x0602B3C9 RID: 177097 RVA: 0x005F4FD4 File Offset: 0x005F31D4
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

		// Token: 0x0602B3CA RID: 177098 RVA: 0x005F4FFF File Offset: 0x005F31FF
		public Span<int> GetMontageIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0602B3CB RID: 177099 RVA: 0x005F500E File Offset: 0x005F320E
		public int[] GetMontageIdsArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x1700BAFB RID: 47867
		// (get) Token: 0x0602B3CC RID: 177100 RVA: 0x005F501C File Offset: 0x005F321C
		public bool UseFreeCamera
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700BAFC RID: 47868
		// (get) Token: 0x0602B3CD RID: 177101 RVA: 0x005F505C File Offset: 0x005F325C
		public bool IsSwitchMainRole
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700BAFD RID: 47869
		// (get) Token: 0x0602B3CE RID: 177102 RVA: 0x005F509C File Offset: 0x005F329C
		public bool IsUseSeqFace
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700BAFE RID: 47870
		// (get) Token: 0x0602B3CF RID: 177103 RVA: 0x005F50DC File Offset: 0x005F32DC
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

		// Token: 0x0602B3D0 RID: 177104 RVA: 0x005F511C File Offset: 0x005F331C
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

		// Token: 0x0602B3D1 RID: 177105 RVA: 0x005F516B File Offset: 0x005F336B
		public static void StartIBeginFlowTemplate(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0602B3D2 RID: 177106 RVA: 0x005F5174 File Offset: 0x005F3374
		public static void Add_Folded(FlatBufferBuilder builder, bool _Folded)
		{
			builder.AddBool(0, _Folded, false);
		}

		// Token: 0x0602B3D3 RID: 177107 RVA: 0x005F517F File Offset: 0x005F337F
		public static void AddActors(FlatBufferBuilder builder, VectorOffset actorsOffset)
		{
			builder.AddOffset(1, actorsOffset.Value, 0);
		}

		// Token: 0x0602B3D4 RID: 177108 RVA: 0x005F5190 File Offset: 0x005F3390
		public static VectorOffset CreateActorsVector(FlatBufferBuilder builder, Offset<IFlowActorUnit>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602B3D5 RID: 177109 RVA: 0x005F51D0 File Offset: 0x005F33D0
		public static VectorOffset CreateActorsVectorBlock(FlatBufferBuilder builder, Offset<IFlowActorUnit>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IFlowActorUnit>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602B3D6 RID: 177110 RVA: 0x005F51EA File Offset: 0x005F33EA
		public static VectorOffset CreateActorsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IFlowActorUnit>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IFlowActorUnit>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602B3D7 RID: 177111 RVA: 0x005F5208 File Offset: 0x005F3408
		public static VectorOffset CreateActorsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IFlowActorUnit>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602B3D8 RID: 177112 RVA: 0x005F5221 File Offset: 0x005F3421
		public static void StartActorsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602B3D9 RID: 177113 RVA: 0x005F522C File Offset: 0x005F342C
		public static void AddMontageIds(FlatBufferBuilder builder, VectorOffset montageIdsOffset)
		{
			builder.AddOffset(2, montageIdsOffset.Value, 0);
		}

		// Token: 0x0602B3DA RID: 177114 RVA: 0x005F523C File Offset: 0x005F343C
		public static VectorOffset CreateMontageIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602B3DB RID: 177115 RVA: 0x005F5273 File Offset: 0x005F3473
		public static VectorOffset CreateMontageIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602B3DC RID: 177116 RVA: 0x005F528D File Offset: 0x005F348D
		public static VectorOffset CreateMontageIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602B3DD RID: 177117 RVA: 0x005F52AB File Offset: 0x005F34AB
		public static VectorOffset CreateMontageIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602B3DE RID: 177118 RVA: 0x005F52C4 File Offset: 0x005F34C4
		public static void StartMontageIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602B3DF RID: 177119 RVA: 0x005F52CF File Offset: 0x005F34CF
		public static void AddUseFreeCamera(FlatBufferBuilder builder, bool useFreeCamera)
		{
			builder.AddBool(3, useFreeCamera, false);
		}

		// Token: 0x0602B3E0 RID: 177120 RVA: 0x005F52DA File Offset: 0x005F34DA
		public static void AddIsSwitchMainRole(FlatBufferBuilder builder, bool isSwitchMainRole)
		{
			builder.AddBool(4, isSwitchMainRole, false);
		}

		// Token: 0x0602B3E1 RID: 177121 RVA: 0x005F52E5 File Offset: 0x005F34E5
		public static void AddIsUseSeqFace(FlatBufferBuilder builder, bool isUseSeqFace)
		{
			builder.AddBool(5, isUseSeqFace, false);
		}

		// Token: 0x0602B3E2 RID: 177122 RVA: 0x005F52F0 File Offset: 0x005F34F0
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0602B3E3 RID: 177123 RVA: 0x005F52FB File Offset: 0x005F34FB
		public static Offset<IBeginFlowTemplate> EndIBeginFlowTemplate(FlatBufferBuilder builder)
		{
			return new Offset<IBeginFlowTemplate>(builder.EndTable());
		}

		// Token: 0x0602B3E4 RID: 177124 RVA: 0x005F5308 File Offset: 0x005F3508
		public IBeginFlowTemplateT UnPack()
		{
			IBeginFlowTemplateT beginFlowTemplateT = new IBeginFlowTemplateT();
			this.UnPackTo(beginFlowTemplateT);
			return beginFlowTemplateT;
		}

		// Token: 0x0602B3E5 RID: 177125 RVA: 0x005F5324 File Offset: 0x005F3524
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

		// Token: 0x0602B3E6 RID: 177126 RVA: 0x005F53F0 File Offset: 0x005F35F0
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

		// Token: 0x04010732 RID: 67378
		private Table __p;
	}
}
