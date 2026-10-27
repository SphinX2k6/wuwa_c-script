using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051F8 RID: 20984
	public struct IExploreSkillPullGiant : IFlatbufferObject
	{
		// Token: 0x170099B4 RID: 39348
		// (get) Token: 0x06022164 RID: 139620 RVA: 0x004BB207 File Offset: 0x004B9407
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022165 RID: 139621 RVA: 0x004BB214 File Offset: 0x004B9414
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022166 RID: 139622 RVA: 0x004BB21C File Offset: 0x004B941C
		public static IExploreSkillPullGiant GetRootAsIExploreSkillPullGiant(ByteBuffer _bb)
		{
			return IExploreSkillPullGiant.GetRootAsIExploreSkillPullGiant(_bb, default(IExploreSkillPullGiant));
		}

		// Token: 0x06022167 RID: 139623 RVA: 0x004BB238 File Offset: 0x004B9438
		public static IExploreSkillPullGiant GetRootAsIExploreSkillPullGiant(ByteBuffer _bb, IExploreSkillPullGiant obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022168 RID: 139624 RVA: 0x004BB255 File Offset: 0x004B9455
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022169 RID: 139625 RVA: 0x004BB264 File Offset: 0x004B9464
		public IExploreSkillPullGiant __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170099B5 RID: 39349
		// (get) Token: 0x0602216A RID: 139626 RVA: 0x004BB274 File Offset: 0x004B9474
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

		// Token: 0x170099B6 RID: 39350
		// (get) Token: 0x0602216B RID: 139627 RVA: 0x004BB2B0 File Offset: 0x004B94B0
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

		// Token: 0x0602216C RID: 139628 RVA: 0x004BB2F0 File Offset: 0x004B94F0
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170099B7 RID: 39351
		// (get) Token: 0x0602216D RID: 139629 RVA: 0x004BB350 File Offset: 0x004B9550
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

		// Token: 0x0602216E RID: 139630 RVA: 0x004BB37B File Offset: 0x004B957B
		public static Offset<IExploreSkillPullGiant> CreateIExploreSkillPullGiant(FlatBufferBuilder builder, EExploreSkillInteractType Type = EExploreSkillInteractType.PullGiant, float PullTime = 0f, VectorOffset ActionsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IExploreSkillPullGiant.AddActions(builder, ActionsOffset);
			IExploreSkillPullGiant.AddPullTime(builder, PullTime);
			IExploreSkillPullGiant.AddType(builder, Type);
			return IExploreSkillPullGiant.EndIExploreSkillPullGiant(builder);
		}

		// Token: 0x0602216F RID: 139631 RVA: 0x004BB39F File Offset: 0x004B959F
		public static void StartIExploreSkillPullGiant(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06022170 RID: 139632 RVA: 0x004BB3A8 File Offset: 0x004B95A8
		public static void AddType(FlatBufferBuilder builder, EExploreSkillInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022171 RID: 139633 RVA: 0x004BB3B3 File Offset: 0x004B95B3
		public static void AddPullTime(FlatBufferBuilder builder, float pullTime)
		{
			builder.AddFloat(1, pullTime, 0.0);
		}

		// Token: 0x06022172 RID: 139634 RVA: 0x004BB3C6 File Offset: 0x004B95C6
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(2, actionsOffset.Value, 0);
		}

		// Token: 0x06022173 RID: 139635 RVA: 0x004BB3D8 File Offset: 0x004B95D8
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06022174 RID: 139636 RVA: 0x004BB418 File Offset: 0x004B9618
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022175 RID: 139637 RVA: 0x004BB432 File Offset: 0x004B9632
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022176 RID: 139638 RVA: 0x004BB450 File Offset: 0x004B9650
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022177 RID: 139639 RVA: 0x004BB469 File Offset: 0x004B9669
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06022178 RID: 139640 RVA: 0x004BB474 File Offset: 0x004B9674
		public static Offset<IExploreSkillPullGiant> EndIExploreSkillPullGiant(FlatBufferBuilder builder)
		{
			return new Offset<IExploreSkillPullGiant>(builder.EndTable());
		}

		// Token: 0x06022179 RID: 139641 RVA: 0x004BB484 File Offset: 0x004B9684
		public IExploreSkillPullGiantT UnPack()
		{
			IExploreSkillPullGiantT exploreSkillPullGiantT = new IExploreSkillPullGiantT();
			this.UnPackTo(exploreSkillPullGiantT);
			return exploreSkillPullGiantT;
		}

		// Token: 0x0602217A RID: 139642 RVA: 0x004BB4A0 File Offset: 0x004B96A0
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

		// Token: 0x0602217B RID: 139643 RVA: 0x004BB518 File Offset: 0x004B9718
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

		// Token: 0x0400E327 RID: 58151
		private Table __p;
	}
}
