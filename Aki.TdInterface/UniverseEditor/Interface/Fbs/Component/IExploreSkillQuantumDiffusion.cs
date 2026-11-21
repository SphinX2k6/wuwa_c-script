using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005766 RID: 22374
	public struct IExploreSkillQuantumDiffusion : IFlatbufferObject
	{
		// Token: 0x1700A1BE RID: 41406
		// (get) Token: 0x06024134 RID: 147764 RVA: 0x004F642B File Offset: 0x004F462B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024135 RID: 147765 RVA: 0x004F6438 File Offset: 0x004F4638
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024136 RID: 147766 RVA: 0x004F6440 File Offset: 0x004F4640
		public static IExploreSkillQuantumDiffusion GetRootAsIExploreSkillQuantumDiffusion(ByteBuffer _bb)
		{
			return IExploreSkillQuantumDiffusion.GetRootAsIExploreSkillQuantumDiffusion(_bb, default(IExploreSkillQuantumDiffusion));
		}

		// Token: 0x06024137 RID: 147767 RVA: 0x004F645C File Offset: 0x004F465C
		public static IExploreSkillQuantumDiffusion GetRootAsIExploreSkillQuantumDiffusion(ByteBuffer _bb, IExploreSkillQuantumDiffusion obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024138 RID: 147768 RVA: 0x004F6479 File Offset: 0x004F4679
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024139 RID: 147769 RVA: 0x004F6488 File Offset: 0x004F4688
		public IExploreSkillQuantumDiffusion __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A1BF RID: 41407
		// (get) Token: 0x0602413A RID: 147770 RVA: 0x004F6498 File Offset: 0x004F4698
		public EExploreSkillInteractType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EExploreSkillInteractType.PullGiant;
				}
				return (EExploreSkillInteractType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A1C0 RID: 41408
		// (get) Token: 0x0602413B RID: 147771 RVA: 0x004F64D4 File Offset: 0x004F46D4
		public bool NeedFollowShooter
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602413C RID: 147772 RVA: 0x004F6514 File Offset: 0x004F4714
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A1C1 RID: 41409
		// (get) Token: 0x0602413D RID: 147773 RVA: 0x004F6574 File Offset: 0x004F4774
		public int ActionsLength
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

		// Token: 0x1700A1C2 RID: 41410
		// (get) Token: 0x0602413E RID: 147774 RVA: 0x004F65A0 File Offset: 0x004F47A0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602413F RID: 147775 RVA: 0x004F65DD File Offset: 0x004F47DD
		public static Offset<IExploreSkillQuantumDiffusion> CreateIExploreSkillQuantumDiffusion(FlatBufferBuilder builder, EExploreSkillInteractType Type = EExploreSkillInteractType.PullGiant, bool NeedFollowShooter = false, VectorOffset ActionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IExploreSkillQuantumDiffusion.AddActions(builder, ActionsOffset);
			IExploreSkillQuantumDiffusion.AddNullMask(builder, NullMask);
			IExploreSkillQuantumDiffusion.AddNeedFollowShooter(builder, NeedFollowShooter);
			IExploreSkillQuantumDiffusion.AddType(builder, Type);
			return IExploreSkillQuantumDiffusion.EndIExploreSkillQuantumDiffusion(builder);
		}

		// Token: 0x06024140 RID: 147776 RVA: 0x004F6609 File Offset: 0x004F4809
		public static void StartIExploreSkillQuantumDiffusion(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06024141 RID: 147777 RVA: 0x004F6612 File Offset: 0x004F4812
		public static void AddType(FlatBufferBuilder builder, EExploreSkillInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024142 RID: 147778 RVA: 0x004F661D File Offset: 0x004F481D
		public static void AddNeedFollowShooter(FlatBufferBuilder builder, bool needFollowShooter)
		{
			builder.AddBool(1, needFollowShooter, false);
		}

		// Token: 0x06024143 RID: 147779 RVA: 0x004F6628 File Offset: 0x004F4828
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(2, actionsOffset.Value, 0);
		}

		// Token: 0x06024144 RID: 147780 RVA: 0x004F6638 File Offset: 0x004F4838
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06024145 RID: 147781 RVA: 0x004F6678 File Offset: 0x004F4878
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024146 RID: 147782 RVA: 0x004F6692 File Offset: 0x004F4892
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024147 RID: 147783 RVA: 0x004F66B0 File Offset: 0x004F48B0
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06024148 RID: 147784 RVA: 0x004F66C9 File Offset: 0x004F48C9
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06024149 RID: 147785 RVA: 0x004F66D4 File Offset: 0x004F48D4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602414A RID: 147786 RVA: 0x004F66DF File Offset: 0x004F48DF
		public static Offset<IExploreSkillQuantumDiffusion> EndIExploreSkillQuantumDiffusion(FlatBufferBuilder builder)
		{
			return new Offset<IExploreSkillQuantumDiffusion>(builder.EndTable());
		}

		// Token: 0x0602414B RID: 147787 RVA: 0x004F66EC File Offset: 0x004F48EC
		public IExploreSkillQuantumDiffusionT UnPack()
		{
			IExploreSkillQuantumDiffusionT exploreSkillQuantumDiffusionT = new IExploreSkillQuantumDiffusionT();
			this.UnPackTo(exploreSkillQuantumDiffusionT);
			return exploreSkillQuantumDiffusionT;
		}

		// Token: 0x0602414C RID: 147788 RVA: 0x004F6708 File Offset: 0x004F4908
		public void UnPackTo(IExploreSkillQuantumDiffusionT _o)
		{
			_o.Type = this.Type;
			_o.NeedFollowShooter = this.NeedFollowShooter;
			_o.Actions = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionsLength; i++)
			{
				_o.Actions.Add((this.Actions(i) != null) ? this.Actions(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602414D RID: 147789 RVA: 0x004F678C File Offset: 0x004F498C
		public static Offset<IExploreSkillQuantumDiffusion> Pack(FlatBufferBuilder builder, IExploreSkillQuantumDiffusionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExploreSkillQuantumDiffusion>);
			}
			VectorOffset actionsOffset = default(VectorOffset);
			if (_o.Actions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.Actions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.Actions[i]);
				}
				actionsOffset = IExploreSkillQuantumDiffusion.CreateActionsVector(builder, array);
			}
			return IExploreSkillQuantumDiffusion.CreateIExploreSkillQuantumDiffusion(builder, _o.Type, _o.NeedFollowShooter, actionsOffset, _o.NullMask);
		}

		// Token: 0x0400EF35 RID: 61237
		private Table __p;
	}
}
