using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004B37 RID: 19255
	public struct IUnlockEntityForGm : IFlatbufferObject
	{
		// Token: 0x1700870B RID: 34571
		// (get) Token: 0x0601D0C2 RID: 118978 RVA: 0x00414FCD File Offset: 0x004131CD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D0C3 RID: 118979 RVA: 0x00414FDA File Offset: 0x004131DA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D0C4 RID: 118980 RVA: 0x00414FE4 File Offset: 0x004131E4
		public static IUnlockEntityForGm GetRootAsIUnlockEntityForGm(ByteBuffer _bb)
		{
			return IUnlockEntityForGm.GetRootAsIUnlockEntityForGm(_bb, default(IUnlockEntityForGm));
		}

		// Token: 0x0601D0C5 RID: 118981 RVA: 0x00415000 File Offset: 0x00413200
		public static IUnlockEntityForGm GetRootAsIUnlockEntityForGm(ByteBuffer _bb, IUnlockEntityForGm obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D0C6 RID: 118982 RVA: 0x0041501D File Offset: 0x0041321D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D0C7 RID: 118983 RVA: 0x0041502C File Offset: 0x0041322C
		public IUnlockEntityForGm __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700870C RID: 34572
		// (get) Token: 0x0601D0C8 RID: 118984 RVA: 0x0041503C File Offset: 0x0041323C
		public EGmCommand Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGmCommand.SkipToLevelPlayNode;
				}
				return (EGmCommand)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601D0C9 RID: 118985 RVA: 0x00415078 File Offset: 0x00413278
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700870D RID: 34573
		// (get) Token: 0x0601D0CA RID: 118986 RVA: 0x004150B8 File Offset: 0x004132B8
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

		// Token: 0x0601D0CB RID: 118987 RVA: 0x004150E3 File Offset: 0x004132E3
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0601D0CC RID: 118988 RVA: 0x004150F2 File Offset: 0x004132F2
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x0601D0CD RID: 118989 RVA: 0x00415100 File Offset: 0x00413300
		public static Offset<IUnlockEntityForGm> CreateIUnlockEntityForGm(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, VectorOffset EntityIdsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IUnlockEntityForGm.AddEntityIds(builder, EntityIdsOffset);
			IUnlockEntityForGm.AddType(builder, Type);
			return IUnlockEntityForGm.EndIUnlockEntityForGm(builder);
		}

		// Token: 0x0601D0CE RID: 118990 RVA: 0x0041511D File Offset: 0x0041331D
		public static void StartIUnlockEntityForGm(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601D0CF RID: 118991 RVA: 0x00415126 File Offset: 0x00413326
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D0D0 RID: 118992 RVA: 0x00415131 File Offset: 0x00413331
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(1, entityIdsOffset.Value, 0);
		}

		// Token: 0x0601D0D1 RID: 118993 RVA: 0x00415144 File Offset: 0x00413344
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D0D2 RID: 118994 RVA: 0x0041517B File Offset: 0x0041337B
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D0D3 RID: 118995 RVA: 0x00415195 File Offset: 0x00413395
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D0D4 RID: 118996 RVA: 0x004151B3 File Offset: 0x004133B3
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D0D5 RID: 118997 RVA: 0x004151CC File Offset: 0x004133CC
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601D0D6 RID: 118998 RVA: 0x004151D7 File Offset: 0x004133D7
		public static Offset<IUnlockEntityForGm> EndIUnlockEntityForGm(FlatBufferBuilder builder)
		{
			return new Offset<IUnlockEntityForGm>(builder.EndTable());
		}

		// Token: 0x0601D0D7 RID: 118999 RVA: 0x004151E4 File Offset: 0x004133E4
		public IUnlockEntityForGmT UnPack()
		{
			IUnlockEntityForGmT unlockEntityForGmT = new IUnlockEntityForGmT();
			this.UnPackTo(unlockEntityForGmT);
			return unlockEntityForGmT;
		}

		// Token: 0x0601D0D8 RID: 119000 RVA: 0x00415200 File Offset: 0x00413400
		public void UnPackTo(IUnlockEntityForGmT _o)
		{
			_o.Type = this.Type;
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
		}

		// Token: 0x0601D0D9 RID: 119001 RVA: 0x00415248 File Offset: 0x00413448
		public static Offset<IUnlockEntityForGm> Pack(FlatBufferBuilder builder, IUnlockEntityForGmT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUnlockEntityForGm>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = IUnlockEntityForGm.CreateEntityIdsVector(builder, data);
			}
			return IUnlockEntityForGm.CreateIUnlockEntityForGm(builder, _o.Type, entityIdsOffset);
		}

		// Token: 0x0400D2D0 RID: 53968
		private Table __p;
	}
}
