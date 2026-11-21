using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EB7 RID: 20151
	public struct ICheckEntitiesExist : IFlatbufferObject
	{
		// Token: 0x17008FBD RID: 36797
		// (get) Token: 0x0601F3CB RID: 127947 RVA: 0x0045AA24 File Offset: 0x00458C24
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F3CC RID: 127948 RVA: 0x0045AA31 File Offset: 0x00458C31
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F3CD RID: 127949 RVA: 0x0045AA38 File Offset: 0x00458C38
		public static ICheckEntitiesExist GetRootAsICheckEntitiesExist(ByteBuffer _bb)
		{
			return ICheckEntitiesExist.GetRootAsICheckEntitiesExist(_bb, default(ICheckEntitiesExist));
		}

		// Token: 0x0601F3CE RID: 127950 RVA: 0x0045AA54 File Offset: 0x00458C54
		public static ICheckEntitiesExist GetRootAsICheckEntitiesExist(ByteBuffer _bb, ICheckEntitiesExist obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F3CF RID: 127951 RVA: 0x0045AA71 File Offset: 0x00458C71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F3D0 RID: 127952 RVA: 0x0045AA80 File Offset: 0x00458C80
		public ICheckEntitiesExist __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008FBE RID: 36798
		// (get) Token: 0x0601F3D1 RID: 127953 RVA: 0x0045AA90 File Offset: 0x00458C90
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F3D2 RID: 127954 RVA: 0x0045AACC File Offset: 0x00458CCC
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008FBF RID: 36799
		// (get) Token: 0x0601F3D3 RID: 127955 RVA: 0x0045AB0C File Offset: 0x00458D0C
		public int EntityIdsLength
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

		// Token: 0x0601F3D4 RID: 127956 RVA: 0x0045AB37 File Offset: 0x00458D37
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0601F3D5 RID: 127957 RVA: 0x0045AB46 File Offset: 0x00458D46
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x17008FC0 RID: 36800
		// (get) Token: 0x0601F3D6 RID: 127958 RVA: 0x0045AB54 File Offset: 0x00458D54
		public bool IsExist
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008FC1 RID: 36801
		// (get) Token: 0x0601F3D7 RID: 127959 RVA: 0x0045AB94 File Offset: 0x00458D94
		public bool IsFinishLoading
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008FC2 RID: 36802
		// (get) Token: 0x0601F3D8 RID: 127960 RVA: 0x0045ABD4 File Offset: 0x00458DD4
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

		// Token: 0x0601F3D9 RID: 127961 RVA: 0x0045AC11 File Offset: 0x00458E11
		public static Offset<ICheckEntitiesExist> CreateICheckEntitiesExist(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, VectorOffset EntityIdsOffset = default(VectorOffset), bool IsExist = false, bool IsFinishLoading = false, byte NullMask = 0)
		{
			builder.StartTable(5);
			ICheckEntitiesExist.AddEntityIds(builder, EntityIdsOffset);
			ICheckEntitiesExist.AddNullMask(builder, NullMask);
			ICheckEntitiesExist.AddIsFinishLoading(builder, IsFinishLoading);
			ICheckEntitiesExist.AddIsExist(builder, IsExist);
			ICheckEntitiesExist.AddType(builder, Type);
			return ICheckEntitiesExist.EndICheckEntitiesExist(builder);
		}

		// Token: 0x0601F3DA RID: 127962 RVA: 0x0045AC45 File Offset: 0x00458E45
		public static void StartICheckEntitiesExist(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601F3DB RID: 127963 RVA: 0x0045AC4E File Offset: 0x00458E4E
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F3DC RID: 127964 RVA: 0x0045AC59 File Offset: 0x00458E59
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(1, entityIdsOffset.Value, 0);
		}

		// Token: 0x0601F3DD RID: 127965 RVA: 0x0045AC6C File Offset: 0x00458E6C
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601F3DE RID: 127966 RVA: 0x0045ACA3 File Offset: 0x00458EA3
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601F3DF RID: 127967 RVA: 0x0045ACBD File Offset: 0x00458EBD
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601F3E0 RID: 127968 RVA: 0x0045ACDB File Offset: 0x00458EDB
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601F3E1 RID: 127969 RVA: 0x0045ACF4 File Offset: 0x00458EF4
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601F3E2 RID: 127970 RVA: 0x0045ACFF File Offset: 0x00458EFF
		public static void AddIsExist(FlatBufferBuilder builder, bool isExist)
		{
			builder.AddBool(2, isExist, false);
		}

		// Token: 0x0601F3E3 RID: 127971 RVA: 0x0045AD0A File Offset: 0x00458F0A
		public static void AddIsFinishLoading(FlatBufferBuilder builder, bool isFinishLoading)
		{
			builder.AddBool(3, isFinishLoading, false);
		}

		// Token: 0x0601F3E4 RID: 127972 RVA: 0x0045AD15 File Offset: 0x00458F15
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0601F3E5 RID: 127973 RVA: 0x0045AD20 File Offset: 0x00458F20
		public static Offset<ICheckEntitiesExist> EndICheckEntitiesExist(FlatBufferBuilder builder)
		{
			return new Offset<ICheckEntitiesExist>(builder.EndTable());
		}

		// Token: 0x0601F3E6 RID: 127974 RVA: 0x0045AD30 File Offset: 0x00458F30
		public ICheckEntitiesExistT UnPack()
		{
			ICheckEntitiesExistT checkEntitiesExistT = new ICheckEntitiesExistT();
			this.UnPackTo(checkEntitiesExistT);
			return checkEntitiesExistT;
		}

		// Token: 0x0601F3E7 RID: 127975 RVA: 0x0045AD4C File Offset: 0x00458F4C
		public void UnPackTo(ICheckEntitiesExistT _o)
		{
			_o.Type = this.Type;
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
			_o.IsExist = this.IsExist;
			_o.IsFinishLoading = this.IsFinishLoading;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601F3E8 RID: 127976 RVA: 0x0045ADB8 File Offset: 0x00458FB8
		public static Offset<ICheckEntitiesExist> Pack(FlatBufferBuilder builder, ICheckEntitiesExistT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckEntitiesExist>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = ICheckEntitiesExist.CreateEntityIdsVector(builder, data);
			}
			return ICheckEntitiesExist.CreateICheckEntitiesExist(builder, _o.Type, entityIdsOffset, _o.IsExist, _o.IsFinishLoading, _o.NullMask);
		}

		// Token: 0x0400DD01 RID: 56577
		private Table __p;
	}
}
