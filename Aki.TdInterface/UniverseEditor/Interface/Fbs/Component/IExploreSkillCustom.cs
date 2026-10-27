using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051DD RID: 20957
	public struct IExploreSkillCustom : IFlatbufferObject
	{
		// Token: 0x17009960 RID: 39264
		// (get) Token: 0x06021FC2 RID: 139202 RVA: 0x004B6C84 File Offset: 0x004B4E84
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021FC3 RID: 139203 RVA: 0x004B6C91 File Offset: 0x004B4E91
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021FC4 RID: 139204 RVA: 0x004B6C98 File Offset: 0x004B4E98
		public static IExploreSkillCustom GetRootAsIExploreSkillCustom(ByteBuffer _bb)
		{
			return IExploreSkillCustom.GetRootAsIExploreSkillCustom(_bb, default(IExploreSkillCustom));
		}

		// Token: 0x06021FC5 RID: 139205 RVA: 0x004B6CB4 File Offset: 0x004B4EB4
		public static IExploreSkillCustom GetRootAsIExploreSkillCustom(ByteBuffer _bb, IExploreSkillCustom obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021FC6 RID: 139206 RVA: 0x004B6CD1 File Offset: 0x004B4ED1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021FC7 RID: 139207 RVA: 0x004B6CE0 File Offset: 0x004B4EE0
		public IExploreSkillCustom __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009961 RID: 39265
		// (get) Token: 0x06021FC8 RID: 139208 RVA: 0x004B6CF0 File Offset: 0x004B4EF0
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

		// Token: 0x17009962 RID: 39266
		// (get) Token: 0x06021FC9 RID: 139209 RVA: 0x004B6D2C File Offset: 0x004B4F2C
		public int LockConfigId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021FCA RID: 139210 RVA: 0x004B6D68 File Offset: 0x004B4F68
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009963 RID: 39267
		// (get) Token: 0x06021FCB RID: 139211 RVA: 0x004B6DC8 File Offset: 0x004B4FC8
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

		// Token: 0x17009964 RID: 39268
		// (get) Token: 0x06021FCC RID: 139212 RVA: 0x004B6DF4 File Offset: 0x004B4FF4
		public IVectorInfo? InteractOffset
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06021FCD RID: 139213 RVA: 0x004B6E52 File Offset: 0x004B5052
		public static Offset<IExploreSkillCustom> CreateIExploreSkillCustom(FlatBufferBuilder builder, EExploreSkillInteractType Type = EExploreSkillInteractType.PullGiant, int LockConfigId = 0, VectorOffset ActionsOffset = default(VectorOffset), Offset<IVectorInfo> InteractOffsetOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(4);
			IExploreSkillCustom.AddInteractOffset(builder, InteractOffsetOffset);
			IExploreSkillCustom.AddActions(builder, ActionsOffset);
			IExploreSkillCustom.AddLockConfigId(builder, LockConfigId);
			IExploreSkillCustom.AddType(builder, Type);
			return IExploreSkillCustom.EndIExploreSkillCustom(builder);
		}

		// Token: 0x06021FCE RID: 139214 RVA: 0x004B6E7E File Offset: 0x004B507E
		public static void StartIExploreSkillCustom(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06021FCF RID: 139215 RVA: 0x004B6E87 File Offset: 0x004B5087
		public static void AddType(FlatBufferBuilder builder, EExploreSkillInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06021FD0 RID: 139216 RVA: 0x004B6E92 File Offset: 0x004B5092
		public static void AddLockConfigId(FlatBufferBuilder builder, int lockConfigId)
		{
			builder.AddInt(1, lockConfigId, 0);
		}

		// Token: 0x06021FD1 RID: 139217 RVA: 0x004B6E9D File Offset: 0x004B509D
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(2, actionsOffset.Value, 0);
		}

		// Token: 0x06021FD2 RID: 139218 RVA: 0x004B6EB0 File Offset: 0x004B50B0
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06021FD3 RID: 139219 RVA: 0x004B6EF0 File Offset: 0x004B50F0
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021FD4 RID: 139220 RVA: 0x004B6F0A File Offset: 0x004B510A
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021FD5 RID: 139221 RVA: 0x004B6F28 File Offset: 0x004B5128
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021FD6 RID: 139222 RVA: 0x004B6F41 File Offset: 0x004B5141
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021FD7 RID: 139223 RVA: 0x004B6F4C File Offset: 0x004B514C
		public static void AddInteractOffset(FlatBufferBuilder builder, Offset<IVectorInfo> interactOffsetOffset)
		{
			builder.AddOffset(3, interactOffsetOffset.Value, 0);
		}

		// Token: 0x06021FD8 RID: 139224 RVA: 0x004B6F5C File Offset: 0x004B515C
		public static Offset<IExploreSkillCustom> EndIExploreSkillCustom(FlatBufferBuilder builder)
		{
			return new Offset<IExploreSkillCustom>(builder.EndTable());
		}

		// Token: 0x06021FD9 RID: 139225 RVA: 0x004B6F6C File Offset: 0x004B516C
		public IExploreSkillCustomT UnPack()
		{
			IExploreSkillCustomT exploreSkillCustomT = new IExploreSkillCustomT();
			this.UnPackTo(exploreSkillCustomT);
			return exploreSkillCustomT;
		}

		// Token: 0x06021FDA RID: 139226 RVA: 0x004B6F88 File Offset: 0x004B5188
		public void UnPackTo(IExploreSkillCustomT _o)
		{
			_o.Type = this.Type;
			_o.LockConfigId = this.LockConfigId;
			_o.Actions = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionsLength; i++)
			{
				_o.Actions.Add((this.Actions(i) != null) ? this.Actions(i).Value.UnPack() : null);
			}
			_o.InteractOffset = ((this.InteractOffset != null) ? this.InteractOffset.Value.UnPack() : null);
		}

		// Token: 0x06021FDB RID: 139227 RVA: 0x004B7030 File Offset: 0x004B5230
		public static Offset<IExploreSkillCustom> Pack(FlatBufferBuilder builder, IExploreSkillCustomT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExploreSkillCustom>);
			}
			VectorOffset actionsOffset = default(VectorOffset);
			if (_o.Actions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.Actions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.Actions[i]);
				}
				actionsOffset = IExploreSkillCustom.CreateActionsVector(builder, array);
			}
			Offset<IVectorInfo> interactOffsetOffset = (_o.InteractOffset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.InteractOffset);
			return IExploreSkillCustom.CreateIExploreSkillCustom(builder, _o.Type, _o.LockConfigId, actionsOffset, interactOffsetOffset);
		}

		// Token: 0x0400E2E8 RID: 58088
		private Table __p;
	}
}
