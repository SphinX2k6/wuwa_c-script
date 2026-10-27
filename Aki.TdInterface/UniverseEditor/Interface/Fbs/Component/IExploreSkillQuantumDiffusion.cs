using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051FE RID: 20990
	public struct IExploreSkillQuantumDiffusion : IFlatbufferObject
	{
		// Token: 0x170099C2 RID: 39362
		// (get) Token: 0x0602219E RID: 139678 RVA: 0x004BB967 File Offset: 0x004B9B67
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602219F RID: 139679 RVA: 0x004BB974 File Offset: 0x004B9B74
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060221A0 RID: 139680 RVA: 0x004BB97C File Offset: 0x004B9B7C
		public static IExploreSkillQuantumDiffusion GetRootAsIExploreSkillQuantumDiffusion(ByteBuffer _bb)
		{
			return IExploreSkillQuantumDiffusion.GetRootAsIExploreSkillQuantumDiffusion(_bb, default(IExploreSkillQuantumDiffusion));
		}

		// Token: 0x060221A1 RID: 139681 RVA: 0x004BB998 File Offset: 0x004B9B98
		public static IExploreSkillQuantumDiffusion GetRootAsIExploreSkillQuantumDiffusion(ByteBuffer _bb, IExploreSkillQuantumDiffusion obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060221A2 RID: 139682 RVA: 0x004BB9B5 File Offset: 0x004B9BB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060221A3 RID: 139683 RVA: 0x004BB9C4 File Offset: 0x004B9BC4
		public IExploreSkillQuantumDiffusion __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170099C3 RID: 39363
		// (get) Token: 0x060221A4 RID: 139684 RVA: 0x004BB9D4 File Offset: 0x004B9BD4
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

		// Token: 0x170099C4 RID: 39364
		// (get) Token: 0x060221A5 RID: 139685 RVA: 0x004BBA10 File Offset: 0x004B9C10
		public bool NeedFollowShooter
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060221A6 RID: 139686 RVA: 0x004BBA50 File Offset: 0x004B9C50
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170099C5 RID: 39365
		// (get) Token: 0x060221A7 RID: 139687 RVA: 0x004BBAB0 File Offset: 0x004B9CB0
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

		// Token: 0x170099C6 RID: 39366
		// (get) Token: 0x060221A8 RID: 139688 RVA: 0x004BBADC File Offset: 0x004B9CDC
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

		// Token: 0x060221A9 RID: 139689 RVA: 0x004BBB19 File Offset: 0x004B9D19
		public static Offset<IExploreSkillQuantumDiffusion> CreateIExploreSkillQuantumDiffusion(FlatBufferBuilder builder, EExploreSkillInteractType Type = EExploreSkillInteractType.PullGiant, bool NeedFollowShooter = false, VectorOffset ActionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IExploreSkillQuantumDiffusion.AddActions(builder, ActionsOffset);
			IExploreSkillQuantumDiffusion.AddNullMask(builder, NullMask);
			IExploreSkillQuantumDiffusion.AddNeedFollowShooter(builder, NeedFollowShooter);
			IExploreSkillQuantumDiffusion.AddType(builder, Type);
			return IExploreSkillQuantumDiffusion.EndIExploreSkillQuantumDiffusion(builder);
		}

		// Token: 0x060221AA RID: 139690 RVA: 0x004BBB45 File Offset: 0x004B9D45
		public static void StartIExploreSkillQuantumDiffusion(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060221AB RID: 139691 RVA: 0x004BBB4E File Offset: 0x004B9D4E
		public static void AddType(FlatBufferBuilder builder, EExploreSkillInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060221AC RID: 139692 RVA: 0x004BBB59 File Offset: 0x004B9D59
		public static void AddNeedFollowShooter(FlatBufferBuilder builder, bool needFollowShooter)
		{
			builder.AddBool(1, needFollowShooter, false);
		}

		// Token: 0x060221AD RID: 139693 RVA: 0x004BBB64 File Offset: 0x004B9D64
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(2, actionsOffset.Value, 0);
		}

		// Token: 0x060221AE RID: 139694 RVA: 0x004BBB74 File Offset: 0x004B9D74
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060221AF RID: 139695 RVA: 0x004BBBB4 File Offset: 0x004B9DB4
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060221B0 RID: 139696 RVA: 0x004BBBCE File Offset: 0x004B9DCE
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060221B1 RID: 139697 RVA: 0x004BBBEC File Offset: 0x004B9DEC
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060221B2 RID: 139698 RVA: 0x004BBC05 File Offset: 0x004B9E05
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060221B3 RID: 139699 RVA: 0x004BBC10 File Offset: 0x004B9E10
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x060221B4 RID: 139700 RVA: 0x004BBC1B File Offset: 0x004B9E1B
		public static Offset<IExploreSkillQuantumDiffusion> EndIExploreSkillQuantumDiffusion(FlatBufferBuilder builder)
		{
			return new Offset<IExploreSkillQuantumDiffusion>(builder.EndTable());
		}

		// Token: 0x060221B5 RID: 139701 RVA: 0x004BBC28 File Offset: 0x004B9E28
		public IExploreSkillQuantumDiffusionT UnPack()
		{
			IExploreSkillQuantumDiffusionT exploreSkillQuantumDiffusionT = new IExploreSkillQuantumDiffusionT();
			this.UnPackTo(exploreSkillQuantumDiffusionT);
			return exploreSkillQuantumDiffusionT;
		}

		// Token: 0x060221B6 RID: 139702 RVA: 0x004BBC44 File Offset: 0x004B9E44
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

		// Token: 0x060221B7 RID: 139703 RVA: 0x004BBCC8 File Offset: 0x004B9EC8
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

		// Token: 0x0400E32F RID: 58159
		private Table __p;
	}
}
