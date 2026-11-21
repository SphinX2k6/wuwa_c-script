using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005760 RID: 22368
	public struct IExploreSkillPullGiant : IFlatbufferObject
	{
		// Token: 0x1700A1B0 RID: 41392
		// (get) Token: 0x060240FA RID: 147706 RVA: 0x004F5CCB File Offset: 0x004F3ECB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060240FB RID: 147707 RVA: 0x004F5CD8 File Offset: 0x004F3ED8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060240FC RID: 147708 RVA: 0x004F5CE0 File Offset: 0x004F3EE0
		public static IExploreSkillPullGiant GetRootAsIExploreSkillPullGiant(ByteBuffer _bb)
		{
			return IExploreSkillPullGiant.GetRootAsIExploreSkillPullGiant(_bb, default(IExploreSkillPullGiant));
		}

		// Token: 0x060240FD RID: 147709 RVA: 0x004F5CFC File Offset: 0x004F3EFC
		public static IExploreSkillPullGiant GetRootAsIExploreSkillPullGiant(ByteBuffer _bb, IExploreSkillPullGiant obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060240FE RID: 147710 RVA: 0x004F5D19 File Offset: 0x004F3F19
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060240FF RID: 147711 RVA: 0x004F5D28 File Offset: 0x004F3F28
		public IExploreSkillPullGiant __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A1B1 RID: 41393
		// (get) Token: 0x06024100 RID: 147712 RVA: 0x004F5D38 File Offset: 0x004F3F38
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

		// Token: 0x1700A1B2 RID: 41394
		// (get) Token: 0x06024101 RID: 147713 RVA: 0x004F5D74 File Offset: 0x004F3F74
		public float PullTime
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024102 RID: 147714 RVA: 0x004F5DB4 File Offset: 0x004F3FB4
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A1B3 RID: 41395
		// (get) Token: 0x06024103 RID: 147715 RVA: 0x004F5E14 File Offset: 0x004F4014
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

		// Token: 0x06024104 RID: 147716 RVA: 0x004F5E3F File Offset: 0x004F403F
		public static Offset<IExploreSkillPullGiant> CreateIExploreSkillPullGiant(FlatBufferBuilder builder, EExploreSkillInteractType Type = EExploreSkillInteractType.PullGiant, float PullTime = 0f, VectorOffset ActionsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IExploreSkillPullGiant.AddActions(builder, ActionsOffset);
			IExploreSkillPullGiant.AddPullTime(builder, PullTime);
			IExploreSkillPullGiant.AddType(builder, Type);
			return IExploreSkillPullGiant.EndIExploreSkillPullGiant(builder);
		}

		// Token: 0x06024105 RID: 147717 RVA: 0x004F5E63 File Offset: 0x004F4063
		public static void StartIExploreSkillPullGiant(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06024106 RID: 147718 RVA: 0x004F5E6C File Offset: 0x004F406C
		public static void AddType(FlatBufferBuilder builder, EExploreSkillInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024107 RID: 147719 RVA: 0x004F5E77 File Offset: 0x004F4077
		public static void AddPullTime(FlatBufferBuilder builder, float pullTime)
		{
			builder.AddFloat(1, pullTime, 0.0);
		}

		// Token: 0x06024108 RID: 147720 RVA: 0x004F5E8A File Offset: 0x004F408A
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(2, actionsOffset.Value, 0);
		}

		// Token: 0x06024109 RID: 147721 RVA: 0x004F5E9C File Offset: 0x004F409C
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602410A RID: 147722 RVA: 0x004F5EDC File Offset: 0x004F40DC
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602410B RID: 147723 RVA: 0x004F5EF6 File Offset: 0x004F40F6
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602410C RID: 147724 RVA: 0x004F5F14 File Offset: 0x004F4114
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602410D RID: 147725 RVA: 0x004F5F2D File Offset: 0x004F412D
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602410E RID: 147726 RVA: 0x004F5F38 File Offset: 0x004F4138
		public static Offset<IExploreSkillPullGiant> EndIExploreSkillPullGiant(FlatBufferBuilder builder)
		{
			return new Offset<IExploreSkillPullGiant>(builder.EndTable());
		}

		// Token: 0x0602410F RID: 147727 RVA: 0x004F5F48 File Offset: 0x004F4148
		public IExploreSkillPullGiantT UnPack()
		{
			IExploreSkillPullGiantT exploreSkillPullGiantT = new IExploreSkillPullGiantT();
			this.UnPackTo(exploreSkillPullGiantT);
			return exploreSkillPullGiantT;
		}

		// Token: 0x06024110 RID: 147728 RVA: 0x004F5F64 File Offset: 0x004F4164
		public void UnPackTo(IExploreSkillPullGiantT _o)
		{
			_o.Type = this.Type;
			_o.PullTime = this.PullTime;
			_o.Actions = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionsLength; i++)
			{
				_o.Actions.Add((this.Actions(i) != null) ? this.Actions(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06024111 RID: 147729 RVA: 0x004F5FDC File Offset: 0x004F41DC
		public static Offset<IExploreSkillPullGiant> Pack(FlatBufferBuilder builder, IExploreSkillPullGiantT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExploreSkillPullGiant>);
			}
			VectorOffset actionsOffset = default(VectorOffset);
			if (_o.Actions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.Actions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.Actions[i]);
				}
				actionsOffset = IExploreSkillPullGiant.CreateActionsVector(builder, array);
			}
			return IExploreSkillPullGiant.CreateIExploreSkillPullGiant(builder, _o.Type, _o.PullTime, actionsOffset);
		}

		// Token: 0x0400EF2D RID: 61229
		private Table __p;
	}
}
