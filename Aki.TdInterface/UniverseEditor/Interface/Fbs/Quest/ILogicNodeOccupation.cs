using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F11 RID: 16145
	public struct ILogicNodeOccupation : IFlatbufferObject
	{
		// Token: 0x17007043 RID: 28739
		// (get) Token: 0x06016E7C RID: 93820 RVA: 0x0034E45A File Offset: 0x0034C65A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016E7D RID: 93821 RVA: 0x0034E467 File Offset: 0x0034C667
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016E7E RID: 93822 RVA: 0x0034E470 File Offset: 0x0034C670
		public static ILogicNodeOccupation GetRootAsILogicNodeOccupation(ByteBuffer _bb)
		{
			return ILogicNodeOccupation.GetRootAsILogicNodeOccupation(_bb, default(ILogicNodeOccupation));
		}

		// Token: 0x06016E7F RID: 93823 RVA: 0x0034E48C File Offset: 0x0034C68C
		public static ILogicNodeOccupation GetRootAsILogicNodeOccupation(ByteBuffer _bb, ILogicNodeOccupation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016E80 RID: 93824 RVA: 0x0034E4A9 File Offset: 0x0034C6A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016E81 RID: 93825 RVA: 0x0034E4B8 File Offset: 0x0034C6B8
		public ILogicNodeOccupation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06016E82 RID: 93826 RVA: 0x0034E4C8 File Offset: 0x0034C6C8
		public string Occupations(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007044 RID: 28740
		// (get) Token: 0x06016E83 RID: 93827 RVA: 0x0034E504 File Offset: 0x0034C704
		public int OccupationsLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17007045 RID: 28741
		// (get) Token: 0x06016E84 RID: 93828 RVA: 0x0034E530 File Offset: 0x0034C730
		public string TidDesc
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06016E85 RID: 93829 RVA: 0x0034E567 File Offset: 0x0034C767
		public Span<byte> GetTidDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06016E86 RID: 93830 RVA: 0x0034E576 File Offset: 0x0034C776
		public byte[] GetTidDescArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06016E87 RID: 93831 RVA: 0x0034E584 File Offset: 0x0034C784
		public IActionInfo? ExitActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007046 RID: 28742
		// (get) Token: 0x06016E88 RID: 93832 RVA: 0x0034E5E4 File Offset: 0x0034C7E4
		public int ExitActionsLength
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

		// Token: 0x06016E89 RID: 93833 RVA: 0x0034E610 File Offset: 0x0034C810
		public IActionInfo? ReenterActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007047 RID: 28743
		// (get) Token: 0x06016E8A RID: 93834 RVA: 0x0034E674 File Offset: 0x0034C874
		public int ReenterActionsLength
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

		// Token: 0x06016E8B RID: 93835 RVA: 0x0034E6A0 File Offset: 0x0034C8A0
		public int BanInteractEntities(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007048 RID: 28744
		// (get) Token: 0x06016E8C RID: 93836 RVA: 0x0034E6E0 File Offset: 0x0034C8E0
		public int BanInteractEntitiesLength
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

		// Token: 0x06016E8D RID: 93837 RVA: 0x0034E70C File Offset: 0x0034C90C
		public Span<int> GetBanInteractEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06016E8E RID: 93838 RVA: 0x0034E71C File Offset: 0x0034C91C
		public int[] GetBanInteractEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(12);
		}

		// Token: 0x17007049 RID: 28745
		// (get) Token: 0x06016E8F RID: 93839 RVA: 0x0034E72C File Offset: 0x0034C92C
		public bool ReclaimOccupationWhenEnter
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700704A RID: 28746
		// (get) Token: 0x06016E90 RID: 93840 RVA: 0x0034E76C File Offset: 0x0034C96C
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

		// Token: 0x06016E91 RID: 93841 RVA: 0x0034E7AC File Offset: 0x0034C9AC
		public static Offset<ILogicNodeOccupation> CreateILogicNodeOccupation(FlatBufferBuilder builder, VectorOffset OccupationsOffset = default(VectorOffset), StringOffset TidDescOffset = default(StringOffset), VectorOffset ExitActionsOffset = default(VectorOffset), VectorOffset ReenterActionsOffset = default(VectorOffset), VectorOffset BanInteractEntitiesOffset = default(VectorOffset), bool ReclaimOccupationWhenEnter = false, byte NullMask = 0)
		{
			builder.StartTable(7);
			ILogicNodeOccupation.AddBanInteractEntities(builder, BanInteractEntitiesOffset);
			ILogicNodeOccupation.AddReenterActions(builder, ReenterActionsOffset);
			ILogicNodeOccupation.AddExitActions(builder, ExitActionsOffset);
			ILogicNodeOccupation.AddTidDesc(builder, TidDescOffset);
			ILogicNodeOccupation.AddOccupations(builder, OccupationsOffset);
			ILogicNodeOccupation.AddNullMask(builder, NullMask);
			ILogicNodeOccupation.AddReclaimOccupationWhenEnter(builder, ReclaimOccupationWhenEnter);
			return ILogicNodeOccupation.EndILogicNodeOccupation(builder);
		}

		// Token: 0x06016E92 RID: 93842 RVA: 0x0034E7FB File Offset: 0x0034C9FB
		public static void StartILogicNodeOccupation(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06016E93 RID: 93843 RVA: 0x0034E804 File Offset: 0x0034CA04
		public static void AddOccupations(FlatBufferBuilder builder, VectorOffset occupationsOffset)
		{
			builder.AddOffset(0, occupationsOffset.Value, 0);
		}

		// Token: 0x06016E94 RID: 93844 RVA: 0x0034E814 File Offset: 0x0034CA14
		public static VectorOffset CreateOccupationsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06016E95 RID: 93845 RVA: 0x0034E854 File Offset: 0x0034CA54
		public static VectorOffset CreateOccupationsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06016E96 RID: 93846 RVA: 0x0034E86E File Offset: 0x0034CA6E
		public static VectorOffset CreateOccupationsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06016E97 RID: 93847 RVA: 0x0034E88C File Offset: 0x0034CA8C
		public static VectorOffset CreateOccupationsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06016E98 RID: 93848 RVA: 0x0034E8A5 File Offset: 0x0034CAA5
		public static void StartOccupationsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06016E99 RID: 93849 RVA: 0x0034E8B0 File Offset: 0x0034CAB0
		public static void AddTidDesc(FlatBufferBuilder builder, StringOffset tidDescOffset)
		{
			builder.AddOffset(1, tidDescOffset.Value, 0);
		}

		// Token: 0x06016E9A RID: 93850 RVA: 0x0034E8C0 File Offset: 0x0034CAC0
		public static void AddExitActions(FlatBufferBuilder builder, VectorOffset exitActionsOffset)
		{
			builder.AddOffset(2, exitActionsOffset.Value, 0);
		}

		// Token: 0x06016E9B RID: 93851 RVA: 0x0034E8D0 File Offset: 0x0034CAD0
		public static VectorOffset CreateExitActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06016E9C RID: 93852 RVA: 0x0034E910 File Offset: 0x0034CB10
		public static VectorOffset CreateExitActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06016E9D RID: 93853 RVA: 0x0034E92A File Offset: 0x0034CB2A
		public static VectorOffset CreateExitActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06016E9E RID: 93854 RVA: 0x0034E948 File Offset: 0x0034CB48
		public static VectorOffset CreateExitActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06016E9F RID: 93855 RVA: 0x0034E961 File Offset: 0x0034CB61
		public static void StartExitActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06016EA0 RID: 93856 RVA: 0x0034E96C File Offset: 0x0034CB6C
		public static void AddReenterActions(FlatBufferBuilder builder, VectorOffset reenterActionsOffset)
		{
			builder.AddOffset(3, reenterActionsOffset.Value, 0);
		}

		// Token: 0x06016EA1 RID: 93857 RVA: 0x0034E97C File Offset: 0x0034CB7C
		public static VectorOffset CreateReenterActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06016EA2 RID: 93858 RVA: 0x0034E9BC File Offset: 0x0034CBBC
		public static VectorOffset CreateReenterActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06016EA3 RID: 93859 RVA: 0x0034E9D6 File Offset: 0x0034CBD6
		public static VectorOffset CreateReenterActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06016EA4 RID: 93860 RVA: 0x0034E9F4 File Offset: 0x0034CBF4
		public static VectorOffset CreateReenterActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06016EA5 RID: 93861 RVA: 0x0034EA0D File Offset: 0x0034CC0D
		public static void StartReenterActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06016EA6 RID: 93862 RVA: 0x0034EA18 File Offset: 0x0034CC18
		public static void AddBanInteractEntities(FlatBufferBuilder builder, VectorOffset banInteractEntitiesOffset)
		{
			builder.AddOffset(4, banInteractEntitiesOffset.Value, 0);
		}

		// Token: 0x06016EA7 RID: 93863 RVA: 0x0034EA28 File Offset: 0x0034CC28
		public static VectorOffset CreateBanInteractEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06016EA8 RID: 93864 RVA: 0x0034EA5F File Offset: 0x0034CC5F
		public static VectorOffset CreateBanInteractEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06016EA9 RID: 93865 RVA: 0x0034EA79 File Offset: 0x0034CC79
		public static VectorOffset CreateBanInteractEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06016EAA RID: 93866 RVA: 0x0034EA97 File Offset: 0x0034CC97
		public static VectorOffset CreateBanInteractEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06016EAB RID: 93867 RVA: 0x0034EAB0 File Offset: 0x0034CCB0
		public static void StartBanInteractEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06016EAC RID: 93868 RVA: 0x0034EABB File Offset: 0x0034CCBB
		public static void AddReclaimOccupationWhenEnter(FlatBufferBuilder builder, bool reclaimOccupationWhenEnter)
		{
			builder.AddBool(5, reclaimOccupationWhenEnter, false);
		}

		// Token: 0x06016EAD RID: 93869 RVA: 0x0034EAC6 File Offset: 0x0034CCC6
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06016EAE RID: 93870 RVA: 0x0034EAD1 File Offset: 0x0034CCD1
		public static Offset<ILogicNodeOccupation> EndILogicNodeOccupation(FlatBufferBuilder builder)
		{
			return new Offset<ILogicNodeOccupation>(builder.EndTable());
		}

		// Token: 0x06016EAF RID: 93871 RVA: 0x0034EAE0 File Offset: 0x0034CCE0
		public ILogicNodeOccupationT UnPack()
		{
			ILogicNodeOccupationT logicNodeOccupationT = new ILogicNodeOccupationT();
			this.UnPackTo(logicNodeOccupationT);
			return logicNodeOccupationT;
		}

		// Token: 0x06016EB0 RID: 93872 RVA: 0x0034EAFC File Offset: 0x0034CCFC
		public void UnPackTo(ILogicNodeOccupationT _o)
		{
			_o.Occupations = new List<string>();
			for (int i = 0; i < this.OccupationsLength; i++)
			{
				_o.Occupations.Add(this.Occupations(i));
			}
			_o.TidDesc = this.TidDesc;
			_o.ExitActions = new List<IActionInfoT>();
			for (int j = 0; j < this.ExitActionsLength; j++)
			{
				_o.ExitActions.Add((this.ExitActions(j) != null) ? this.ExitActions(j).Value.UnPack() : null);
			}
			_o.ReenterActions = new List<IActionInfoT>();
			for (int k = 0; k < this.ReenterActionsLength; k++)
			{
				_o.ReenterActions.Add((this.ReenterActions(k) != null) ? this.ReenterActions(k).Value.UnPack() : null);
			}
			_o.BanInteractEntities = new List<int>();
			for (int l = 0; l < this.BanInteractEntitiesLength; l++)
			{
				_o.BanInteractEntities.Add(this.BanInteractEntities(l));
			}
			_o.ReclaimOccupationWhenEnter = this.ReclaimOccupationWhenEnter;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06016EB1 RID: 93873 RVA: 0x0034EC38 File Offset: 0x0034CE38
		public static Offset<ILogicNodeOccupation> Pack(FlatBufferBuilder builder, ILogicNodeOccupationT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILogicNodeOccupation>);
			}
			VectorOffset occupationsOffset = default(VectorOffset);
			if (_o.Occupations != null)
			{
				StringOffset[] array = new StringOffset[_o.Occupations.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.Occupations[i]);
				}
				occupationsOffset = ILogicNodeOccupation.CreateOccupationsVector(builder, array);
			}
			StringOffset tidDescOffset = (_o.TidDesc == null) ? default(StringOffset) : builder.CreateString(_o.TidDesc);
			VectorOffset exitActionsOffset = default(VectorOffset);
			if (_o.ExitActions != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.ExitActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.ExitActions[j]);
				}
				exitActionsOffset = ILogicNodeOccupation.CreateExitActionsVector(builder, array2);
			}
			VectorOffset reenterActionsOffset = default(VectorOffset);
			if (_o.ReenterActions != null)
			{
				Offset<IActionInfo>[] array3 = new Offset<IActionInfo>[_o.ReenterActions.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IActionInfo.Pack(builder, _o.ReenterActions[k]);
				}
				reenterActionsOffset = ILogicNodeOccupation.CreateReenterActionsVector(builder, array3);
			}
			VectorOffset banInteractEntitiesOffset = default(VectorOffset);
			if (_o.BanInteractEntities != null)
			{
				int[] data = _o.BanInteractEntities.ToArray();
				banInteractEntitiesOffset = ILogicNodeOccupation.CreateBanInteractEntitiesVector(builder, data);
			}
			return ILogicNodeOccupation.CreateILogicNodeOccupation(builder, occupationsOffset, tidDescOffset, exitActionsOffset, reenterActionsOffset, banInteractEntitiesOffset, _o.ReclaimOccupationWhenEnter, _o.NullMask);
		}

		// Token: 0x0400B912 RID: 47378
		private Table __p;
	}
}
