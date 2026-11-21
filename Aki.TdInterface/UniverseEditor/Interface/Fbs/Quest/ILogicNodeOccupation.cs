using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200434F RID: 17231
	public struct ILogicNodeOccupation : IFlatbufferObject
	{
		// Token: 0x17007632 RID: 30258
		// (get) Token: 0x060184D4 RID: 99540 RVA: 0x00377682 File Offset: 0x00375882
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060184D5 RID: 99541 RVA: 0x0037768F File Offset: 0x0037588F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060184D6 RID: 99542 RVA: 0x00377698 File Offset: 0x00375898
		public static ILogicNodeOccupation GetRootAsILogicNodeOccupation(ByteBuffer _bb)
		{
			return ILogicNodeOccupation.GetRootAsILogicNodeOccupation(_bb, default(ILogicNodeOccupation));
		}

		// Token: 0x060184D7 RID: 99543 RVA: 0x003776B4 File Offset: 0x003758B4
		public static ILogicNodeOccupation GetRootAsILogicNodeOccupation(ByteBuffer _bb, ILogicNodeOccupation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060184D8 RID: 99544 RVA: 0x003776D1 File Offset: 0x003758D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060184D9 RID: 99545 RVA: 0x003776E0 File Offset: 0x003758E0
		public ILogicNodeOccupation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x060184DA RID: 99546 RVA: 0x003776F0 File Offset: 0x003758F0
		public string Occupations(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007633 RID: 30259
		// (get) Token: 0x060184DB RID: 99547 RVA: 0x0037772C File Offset: 0x0037592C
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

		// Token: 0x17007634 RID: 30260
		// (get) Token: 0x060184DC RID: 99548 RVA: 0x00377758 File Offset: 0x00375958
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

		// Token: 0x060184DD RID: 99549 RVA: 0x0037778F File Offset: 0x0037598F
		public Span<byte> GetTidDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060184DE RID: 99550 RVA: 0x0037779E File Offset: 0x0037599E
		public byte[] GetTidDescArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060184DF RID: 99551 RVA: 0x003777AC File Offset: 0x003759AC
		public IActionInfo? ExitActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007635 RID: 30261
		// (get) Token: 0x060184E0 RID: 99552 RVA: 0x0037780C File Offset: 0x00375A0C
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

		// Token: 0x060184E1 RID: 99553 RVA: 0x00377838 File Offset: 0x00375A38
		public IActionInfo? ReenterActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007636 RID: 30262
		// (get) Token: 0x060184E2 RID: 99554 RVA: 0x0037789C File Offset: 0x00375A9C
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

		// Token: 0x060184E3 RID: 99555 RVA: 0x003778C8 File Offset: 0x00375AC8
		public int BanInteractEntities(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007637 RID: 30263
		// (get) Token: 0x060184E4 RID: 99556 RVA: 0x00377908 File Offset: 0x00375B08
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

		// Token: 0x060184E5 RID: 99557 RVA: 0x00377934 File Offset: 0x00375B34
		public Span<int> GetBanInteractEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x060184E6 RID: 99558 RVA: 0x00377944 File Offset: 0x00375B44
		public int[] GetBanInteractEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(12);
		}

		// Token: 0x17007638 RID: 30264
		// (get) Token: 0x060184E7 RID: 99559 RVA: 0x00377954 File Offset: 0x00375B54
		public bool ReclaimOccupationWhenEnter
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007639 RID: 30265
		// (get) Token: 0x060184E8 RID: 99560 RVA: 0x00377994 File Offset: 0x00375B94
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

		// Token: 0x060184E9 RID: 99561 RVA: 0x003779D4 File Offset: 0x00375BD4
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

		// Token: 0x060184EA RID: 99562 RVA: 0x00377A23 File Offset: 0x00375C23
		public static void StartILogicNodeOccupation(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x060184EB RID: 99563 RVA: 0x00377A2C File Offset: 0x00375C2C
		public static void AddOccupations(FlatBufferBuilder builder, VectorOffset occupationsOffset)
		{
			builder.AddOffset(0, occupationsOffset.Value, 0);
		}

		// Token: 0x060184EC RID: 99564 RVA: 0x00377A3C File Offset: 0x00375C3C
		public static VectorOffset CreateOccupationsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060184ED RID: 99565 RVA: 0x00377A7C File Offset: 0x00375C7C
		public static VectorOffset CreateOccupationsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060184EE RID: 99566 RVA: 0x00377A96 File Offset: 0x00375C96
		public static VectorOffset CreateOccupationsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060184EF RID: 99567 RVA: 0x00377AB4 File Offset: 0x00375CB4
		public static VectorOffset CreateOccupationsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060184F0 RID: 99568 RVA: 0x00377ACD File Offset: 0x00375CCD
		public static void StartOccupationsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060184F1 RID: 99569 RVA: 0x00377AD8 File Offset: 0x00375CD8
		public static void AddTidDesc(FlatBufferBuilder builder, StringOffset tidDescOffset)
		{
			builder.AddOffset(1, tidDescOffset.Value, 0);
		}

		// Token: 0x060184F2 RID: 99570 RVA: 0x00377AE8 File Offset: 0x00375CE8
		public static void AddExitActions(FlatBufferBuilder builder, VectorOffset exitActionsOffset)
		{
			builder.AddOffset(2, exitActionsOffset.Value, 0);
		}

		// Token: 0x060184F3 RID: 99571 RVA: 0x00377AF8 File Offset: 0x00375CF8
		public static VectorOffset CreateExitActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060184F4 RID: 99572 RVA: 0x00377B38 File Offset: 0x00375D38
		public static VectorOffset CreateExitActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060184F5 RID: 99573 RVA: 0x00377B52 File Offset: 0x00375D52
		public static VectorOffset CreateExitActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060184F6 RID: 99574 RVA: 0x00377B70 File Offset: 0x00375D70
		public static VectorOffset CreateExitActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060184F7 RID: 99575 RVA: 0x00377B89 File Offset: 0x00375D89
		public static void StartExitActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060184F8 RID: 99576 RVA: 0x00377B94 File Offset: 0x00375D94
		public static void AddReenterActions(FlatBufferBuilder builder, VectorOffset reenterActionsOffset)
		{
			builder.AddOffset(3, reenterActionsOffset.Value, 0);
		}

		// Token: 0x060184F9 RID: 99577 RVA: 0x00377BA4 File Offset: 0x00375DA4
		public static VectorOffset CreateReenterActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060184FA RID: 99578 RVA: 0x00377BE4 File Offset: 0x00375DE4
		public static VectorOffset CreateReenterActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060184FB RID: 99579 RVA: 0x00377BFE File Offset: 0x00375DFE
		public static VectorOffset CreateReenterActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060184FC RID: 99580 RVA: 0x00377C1C File Offset: 0x00375E1C
		public static VectorOffset CreateReenterActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060184FD RID: 99581 RVA: 0x00377C35 File Offset: 0x00375E35
		public static void StartReenterActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060184FE RID: 99582 RVA: 0x00377C40 File Offset: 0x00375E40
		public static void AddBanInteractEntities(FlatBufferBuilder builder, VectorOffset banInteractEntitiesOffset)
		{
			builder.AddOffset(4, banInteractEntitiesOffset.Value, 0);
		}

		// Token: 0x060184FF RID: 99583 RVA: 0x00377C50 File Offset: 0x00375E50
		public static VectorOffset CreateBanInteractEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06018500 RID: 99584 RVA: 0x00377C87 File Offset: 0x00375E87
		public static VectorOffset CreateBanInteractEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06018501 RID: 99585 RVA: 0x00377CA1 File Offset: 0x00375EA1
		public static VectorOffset CreateBanInteractEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06018502 RID: 99586 RVA: 0x00377CBF File Offset: 0x00375EBF
		public static VectorOffset CreateBanInteractEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018503 RID: 99587 RVA: 0x00377CD8 File Offset: 0x00375ED8
		public static void StartBanInteractEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06018504 RID: 99588 RVA: 0x00377CE3 File Offset: 0x00375EE3
		public static void AddReclaimOccupationWhenEnter(FlatBufferBuilder builder, bool reclaimOccupationWhenEnter)
		{
			builder.AddBool(5, reclaimOccupationWhenEnter, false);
		}

		// Token: 0x06018505 RID: 99589 RVA: 0x00377CEE File Offset: 0x00375EEE
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06018506 RID: 99590 RVA: 0x00377CF9 File Offset: 0x00375EF9
		public static Offset<ILogicNodeOccupation> EndILogicNodeOccupation(FlatBufferBuilder builder)
		{
			return new Offset<ILogicNodeOccupation>(builder.EndTable());
		}

		// Token: 0x06018507 RID: 99591 RVA: 0x00377D08 File Offset: 0x00375F08
		public ILogicNodeOccupationT UnPack()
		{
			ILogicNodeOccupationT logicNodeOccupationT = new ILogicNodeOccupationT();
			this.UnPackTo(logicNodeOccupationT);
			return logicNodeOccupationT;
		}

		// Token: 0x06018508 RID: 99592 RVA: 0x00377D24 File Offset: 0x00375F24
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

		// Token: 0x06018509 RID: 99593 RVA: 0x00377E60 File Offset: 0x00376060
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

		// Token: 0x0400C2EF RID: 49903
		private Table __p;
	}
}
