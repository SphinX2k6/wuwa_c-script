using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006988 RID: 27016
	public struct IChangePhantomFormation : IFlatbufferObject
	{
		// Token: 0x1700C6E4 RID: 50916
		// (get) Token: 0x0602E556 RID: 189782 RVA: 0x00653505 File Offset: 0x00651705
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E557 RID: 189783 RVA: 0x00653512 File Offset: 0x00651712
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E558 RID: 189784 RVA: 0x0065351C File Offset: 0x0065171C
		public static IChangePhantomFormation GetRootAsIChangePhantomFormation(ByteBuffer _bb)
		{
			return IChangePhantomFormation.GetRootAsIChangePhantomFormation(_bb, default(IChangePhantomFormation));
		}

		// Token: 0x0602E559 RID: 189785 RVA: 0x00653538 File Offset: 0x00651738
		public static IChangePhantomFormation GetRootAsIChangePhantomFormation(ByteBuffer _bb, IChangePhantomFormation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E55A RID: 189786 RVA: 0x00653555 File Offset: 0x00651755
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E55B RID: 189787 RVA: 0x00653564 File Offset: 0x00651764
		public IChangePhantomFormation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C6E5 RID: 50917
		// (get) Token: 0x0602E55C RID: 189788 RVA: 0x00653574 File Offset: 0x00651774
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

		// Token: 0x1700C6E6 RID: 50918
		// (get) Token: 0x0602E55D RID: 189789 RVA: 0x006535B0 File Offset: 0x006517B0
		public bool RetainRole
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C6E7 RID: 50919
		// (get) Token: 0x0602E55E RID: 189790 RVA: 0x006535F0 File Offset: 0x006517F0
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

		// Token: 0x0602E55F RID: 189791 RVA: 0x0065362C File Offset: 0x0065182C
		public long AppendBuffIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x1700C6E8 RID: 50920
		// (get) Token: 0x0602E560 RID: 189792 RVA: 0x00653670 File Offset: 0x00651870
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

		// Token: 0x0602E561 RID: 189793 RVA: 0x0065369C File Offset: 0x0065189C
		public Span<long> GetAppendBuffIdsBytes()
		{
			return this.__p.__vector_as_span<long>(10, 8);
		}

		// Token: 0x0602E562 RID: 189794 RVA: 0x006536AC File Offset: 0x006518AC
		public long[] GetAppendBuffIdsArray()
		{
			return this.__p.__vector_as_array<long>(10);
		}

		// Token: 0x1700C6E9 RID: 50921
		// (get) Token: 0x0602E563 RID: 189795 RVA: 0x006536BC File Offset: 0x006518BC
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

		// Token: 0x0602E564 RID: 189796 RVA: 0x006536F9 File Offset: 0x006518F9
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

		// Token: 0x0602E565 RID: 189797 RVA: 0x0065372D File Offset: 0x0065192D
		public static void StartIChangePhantomFormation(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602E566 RID: 189798 RVA: 0x00653736 File Offset: 0x00651936
		public static void AddFormationId(FlatBufferBuilder builder, int formationId)
		{
			builder.AddInt(0, formationId, 0);
		}

		// Token: 0x0602E567 RID: 189799 RVA: 0x00653741 File Offset: 0x00651941
		public static void AddRetainRole(FlatBufferBuilder builder, bool retainRole)
		{
			builder.AddBool(1, retainRole, false);
		}

		// Token: 0x0602E568 RID: 189800 RVA: 0x0065374C File Offset: 0x0065194C
		public static void AddTeleportEntityId(FlatBufferBuilder builder, int teleportEntityId)
		{
			builder.AddInt(2, teleportEntityId, 0);
		}

		// Token: 0x0602E569 RID: 189801 RVA: 0x00653757 File Offset: 0x00651957
		public static void AddAppendBuffIds(FlatBufferBuilder builder, VectorOffset appendBuffIdsOffset)
		{
			builder.AddOffset(3, appendBuffIdsOffset.Value, 0);
		}

		// Token: 0x0602E56A RID: 189802 RVA: 0x00653768 File Offset: 0x00651968
		public static VectorOffset CreateAppendBuffIdsVector(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddLong(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602E56B RID: 189803 RVA: 0x0065379F File Offset: 0x0065199F
		public static VectorOffset CreateAppendBuffIdsVectorBlock(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x0602E56C RID: 189804 RVA: 0x006537B9 File Offset: 0x006519B9
		public static VectorOffset CreateAppendBuffIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data)
		{
			builder.StartVector(8, data.Count, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x0602E56D RID: 189805 RVA: 0x006537D7 File Offset: 0x006519D7
		public static VectorOffset CreateAppendBuffIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<long>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602E56E RID: 189806 RVA: 0x006537F0 File Offset: 0x006519F0
		public static void StartAppendBuffIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(8, numElems, 8);
		}

		// Token: 0x0602E56F RID: 189807 RVA: 0x006537FB File Offset: 0x006519FB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602E570 RID: 189808 RVA: 0x00653806 File Offset: 0x00651A06
		public static Offset<IChangePhantomFormation> EndIChangePhantomFormation(FlatBufferBuilder builder)
		{
			return new Offset<IChangePhantomFormation>(builder.EndTable());
		}

		// Token: 0x0602E571 RID: 189809 RVA: 0x00653814 File Offset: 0x00651A14
		public IChangePhantomFormationT UnPack()
		{
			IChangePhantomFormationT changePhantomFormationT = new IChangePhantomFormationT();
			this.UnPackTo(changePhantomFormationT);
			return changePhantomFormationT;
		}

		// Token: 0x0602E572 RID: 189810 RVA: 0x00653830 File Offset: 0x00651A30
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

		// Token: 0x0602E573 RID: 189811 RVA: 0x0065389C File Offset: 0x00651A9C
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

		// Token: 0x040116EE RID: 71406
		private Table __p;
	}
}
