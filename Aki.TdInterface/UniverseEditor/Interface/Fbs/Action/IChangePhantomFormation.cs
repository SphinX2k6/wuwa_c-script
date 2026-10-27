using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006317 RID: 25367
	public struct IChangePhantomFormation : IFlatbufferObject
	{
		// Token: 0x1700BD5A RID: 48474
		// (get) Token: 0x0602BDED RID: 179693 RVA: 0x006084F9 File Offset: 0x006066F9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BDEE RID: 179694 RVA: 0x00608506 File Offset: 0x00606706
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BDEF RID: 179695 RVA: 0x00608510 File Offset: 0x00606710
		public static IChangePhantomFormation GetRootAsIChangePhantomFormation(ByteBuffer _bb)
		{
			return IChangePhantomFormation.GetRootAsIChangePhantomFormation(_bb, default(IChangePhantomFormation));
		}

		// Token: 0x0602BDF0 RID: 179696 RVA: 0x0060852C File Offset: 0x0060672C
		public static IChangePhantomFormation GetRootAsIChangePhantomFormation(ByteBuffer _bb, IChangePhantomFormation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BDF1 RID: 179697 RVA: 0x00608549 File Offset: 0x00606749
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BDF2 RID: 179698 RVA: 0x00608558 File Offset: 0x00606758
		public IChangePhantomFormation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BD5B RID: 48475
		// (get) Token: 0x0602BDF3 RID: 179699 RVA: 0x00608568 File Offset: 0x00606768
		public int FormationId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BD5C RID: 48476
		// (get) Token: 0x0602BDF4 RID: 179700 RVA: 0x006085A4 File Offset: 0x006067A4
		public bool RetainRole
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700BD5D RID: 48477
		// (get) Token: 0x0602BDF5 RID: 179701 RVA: 0x006085E4 File Offset: 0x006067E4
		public int TeleportEntityId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602BDF6 RID: 179702 RVA: 0x00608620 File Offset: 0x00606820
		public long AppendBuffIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x1700BD5E RID: 48478
		// (get) Token: 0x0602BDF7 RID: 179703 RVA: 0x00608664 File Offset: 0x00606864
		public int AppendBuffIdsLength
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

		// Token: 0x0602BDF8 RID: 179704 RVA: 0x00608690 File Offset: 0x00606890
		public Span<long> GetAppendBuffIdsBytes()
		{
			return this.__p.__vector_as_span<long>(10, 8);
		}

		// Token: 0x0602BDF9 RID: 179705 RVA: 0x006086A0 File Offset: 0x006068A0
		public long[] GetAppendBuffIdsArray()
		{
			return this.__p.__vector_as_array<long>(10);
		}

		// Token: 0x1700BD5F RID: 48479
		// (get) Token: 0x0602BDFA RID: 179706 RVA: 0x006086B0 File Offset: 0x006068B0
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

		// Token: 0x0602BDFB RID: 179707 RVA: 0x006086ED File Offset: 0x006068ED
		public static Offset<IChangePhantomFormation> CreateIChangePhantomFormation(FlatBufferBuilder builder, int FormationId = 0, bool RetainRole = false, int TeleportEntityId = 0, VectorOffset AppendBuffIdsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(5);
			IChangePhantomFormation.AddAppendBuffIds(builder, AppendBuffIdsOffset);
			IChangePhantomFormation.AddTeleportEntityId(builder, TeleportEntityId);
			IChangePhantomFormation.AddFormationId(builder, FormationId);
			IChangePhantomFormation.AddNullMask(builder, NullMask);
			IChangePhantomFormation.AddRetainRole(builder, RetainRole);
			return IChangePhantomFormation.EndIChangePhantomFormation(builder);
		}

		// Token: 0x0602BDFC RID: 179708 RVA: 0x00608721 File Offset: 0x00606921
		public static void StartIChangePhantomFormation(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602BDFD RID: 179709 RVA: 0x0060872A File Offset: 0x0060692A
		public static void AddFormationId(FlatBufferBuilder builder, int formationId)
		{
			builder.AddInt(0, formationId, 0);
		}

		// Token: 0x0602BDFE RID: 179710 RVA: 0x00608735 File Offset: 0x00606935
		public static void AddRetainRole(FlatBufferBuilder builder, bool retainRole)
		{
			builder.AddBool(1, retainRole, false);
		}

		// Token: 0x0602BDFF RID: 179711 RVA: 0x00608740 File Offset: 0x00606940
		public static void AddTeleportEntityId(FlatBufferBuilder builder, int teleportEntityId)
		{
			builder.AddInt(2, teleportEntityId, 0);
		}

		// Token: 0x0602BE00 RID: 179712 RVA: 0x0060874B File Offset: 0x0060694B
		public static void AddAppendBuffIds(FlatBufferBuilder builder, VectorOffset appendBuffIdsOffset)
		{
			builder.AddOffset(3, appendBuffIdsOffset.Value, 0);
		}

		// Token: 0x0602BE01 RID: 179713 RVA: 0x0060875C File Offset: 0x0060695C
		public static VectorOffset CreateAppendBuffIdsVector(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddLong(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602BE02 RID: 179714 RVA: 0x00608793 File Offset: 0x00606993
		public static VectorOffset CreateAppendBuffIdsVectorBlock(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x0602BE03 RID: 179715 RVA: 0x006087AD File Offset: 0x006069AD
		public static VectorOffset CreateAppendBuffIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data)
		{
			builder.StartVector(8, data.Count, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x0602BE04 RID: 179716 RVA: 0x006087CB File Offset: 0x006069CB
		public static VectorOffset CreateAppendBuffIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<long>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602BE05 RID: 179717 RVA: 0x006087E4 File Offset: 0x006069E4
		public static void StartAppendBuffIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(8, numElems, 8);
		}

		// Token: 0x0602BE06 RID: 179718 RVA: 0x006087EF File Offset: 0x006069EF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602BE07 RID: 179719 RVA: 0x006087FA File Offset: 0x006069FA
		public static Offset<IChangePhantomFormation> EndIChangePhantomFormation(FlatBufferBuilder builder)
		{
			return new Offset<IChangePhantomFormation>(builder.EndTable());
		}

		// Token: 0x0602BE08 RID: 179720 RVA: 0x00608808 File Offset: 0x00606A08
		public IChangePhantomFormationT UnPack()
		{
			IChangePhantomFormationT changePhantomFormationT = new IChangePhantomFormationT();
			this.UnPackTo(changePhantomFormationT);
			return changePhantomFormationT;
		}

		// Token: 0x0602BE09 RID: 179721 RVA: 0x00608824 File Offset: 0x00606A24
		public void UnPackTo(IChangePhantomFormationT _o)
		{
			_o.FormationId = this.FormationId;
			_o.RetainRole = this.RetainRole;
			_o.TeleportEntityId = this.TeleportEntityId;
			_o.AppendBuffIds = new List<long>();
			for (int i = 0; i < this.AppendBuffIdsLength; i++)
			{
				_o.AppendBuffIds.Add(this.AppendBuffIds(i));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602BE0A RID: 179722 RVA: 0x00608890 File Offset: 0x00606A90
		public static Offset<IChangePhantomFormation> Pack(FlatBufferBuilder builder, IChangePhantomFormationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangePhantomFormation>);
			}
			VectorOffset appendBuffIdsOffset = default(VectorOffset);
			if (_o.AppendBuffIds != null)
			{
				long[] data = _o.AppendBuffIds.ToArray();
				appendBuffIdsOffset = IChangePhantomFormation.CreateAppendBuffIdsVector(builder, data);
			}
			return IChangePhantomFormation.CreateIChangePhantomFormation(builder, _o.FormationId, _o.RetainRole, _o.TeleportEntityId, appendBuffIdsOffset, _o.NullMask);
		}

		// Token: 0x040108D8 RID: 67800
		private Table __p;
	}
}
