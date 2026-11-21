using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005742 RID: 22338
	public struct IExploreSkillCustom : IFlatbufferObject
	{
		// Token: 0x1700A14F RID: 41295
		// (get) Token: 0x06023F1A RID: 147226 RVA: 0x004F0CEC File Offset: 0x004EEEEC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023F1B RID: 147227 RVA: 0x004F0CF9 File Offset: 0x004EEEF9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023F1C RID: 147228 RVA: 0x004F0D00 File Offset: 0x004EEF00
		public static IExploreSkillCustom GetRootAsIExploreSkillCustom(ByteBuffer _bb)
		{
			return IExploreSkillCustom.GetRootAsIExploreSkillCustom(_bb, default(IExploreSkillCustom));
		}

		// Token: 0x06023F1D RID: 147229 RVA: 0x004F0D1C File Offset: 0x004EEF1C
		public static IExploreSkillCustom GetRootAsIExploreSkillCustom(ByteBuffer _bb, IExploreSkillCustom obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023F1E RID: 147230 RVA: 0x004F0D39 File Offset: 0x004EEF39
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023F1F RID: 147231 RVA: 0x004F0D48 File Offset: 0x004EEF48
		public IExploreSkillCustom __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A150 RID: 41296
		// (get) Token: 0x06023F20 RID: 147232 RVA: 0x004F0D58 File Offset: 0x004EEF58
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

		// Token: 0x1700A151 RID: 41297
		// (get) Token: 0x06023F21 RID: 147233 RVA: 0x004F0D94 File Offset: 0x004EEF94
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

		// Token: 0x06023F22 RID: 147234 RVA: 0x004F0DD0 File Offset: 0x004EEFD0
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A152 RID: 41298
		// (get) Token: 0x06023F23 RID: 147235 RVA: 0x004F0E30 File Offset: 0x004EF030
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

		// Token: 0x1700A153 RID: 41299
		// (get) Token: 0x06023F24 RID: 147236 RVA: 0x004F0E5C File Offset: 0x004EF05C
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

		// Token: 0x06023F25 RID: 147237 RVA: 0x004F0EBA File Offset: 0x004EF0BA
		public static Offset<IExploreSkillCustom> CreateIExploreSkillCustom(FlatBufferBuilder builder, EExploreSkillInteractType Type = EExploreSkillInteractType.PullGiant, int LockConfigId = 0, VectorOffset ActionsOffset = default(VectorOffset), Offset<IVectorInfo> InteractOffsetOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(4);
			IExploreSkillCustom.AddInteractOffset(builder, InteractOffsetOffset);
			IExploreSkillCustom.AddActions(builder, ActionsOffset);
			IExploreSkillCustom.AddLockConfigId(builder, LockConfigId);
			IExploreSkillCustom.AddType(builder, Type);
			return IExploreSkillCustom.EndIExploreSkillCustom(builder);
		}

		// Token: 0x06023F26 RID: 147238 RVA: 0x004F0EE6 File Offset: 0x004EF0E6
		public static void StartIExploreSkillCustom(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06023F27 RID: 147239 RVA: 0x004F0EEF File Offset: 0x004EF0EF
		public static void AddType(FlatBufferBuilder builder, EExploreSkillInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06023F28 RID: 147240 RVA: 0x004F0EFA File Offset: 0x004EF0FA
		public static void AddLockConfigId(FlatBufferBuilder builder, int lockConfigId)
		{
			builder.AddInt(1, lockConfigId, 0);
		}

		// Token: 0x06023F29 RID: 147241 RVA: 0x004F0F05 File Offset: 0x004EF105
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(2, actionsOffset.Value, 0);
		}

		// Token: 0x06023F2A RID: 147242 RVA: 0x004F0F18 File Offset: 0x004EF118
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023F2B RID: 147243 RVA: 0x004F0F58 File Offset: 0x004EF158
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023F2C RID: 147244 RVA: 0x004F0F72 File Offset: 0x004EF172
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023F2D RID: 147245 RVA: 0x004F0F90 File Offset: 0x004EF190
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023F2E RID: 147246 RVA: 0x004F0FA9 File Offset: 0x004EF1A9
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023F2F RID: 147247 RVA: 0x004F0FB4 File Offset: 0x004EF1B4
		public static void AddInteractOffset(FlatBufferBuilder builder, Offset<IVectorInfo> interactOffsetOffset)
		{
			builder.AddOffset(3, interactOffsetOffset.Value, 0);
		}

		// Token: 0x06023F30 RID: 147248 RVA: 0x004F0FC4 File Offset: 0x004EF1C4
		public static Offset<IExploreSkillCustom> EndIExploreSkillCustom(FlatBufferBuilder builder)
		{
			return new Offset<IExploreSkillCustom>(builder.EndTable());
		}

		// Token: 0x06023F31 RID: 147249 RVA: 0x004F0FD4 File Offset: 0x004EF1D4
		public IExploreSkillCustomT UnPack()
		{
			IExploreSkillCustomT exploreSkillCustomT = new IExploreSkillCustomT();
			this.UnPackTo(exploreSkillCustomT);
			return exploreSkillCustomT;
		}

		// Token: 0x06023F32 RID: 147250 RVA: 0x004F0FF0 File Offset: 0x004EF1F0
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

		// Token: 0x06023F33 RID: 147251 RVA: 0x004F1098 File Offset: 0x004EF298
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

		// Token: 0x0400EEE6 RID: 61158
		private Table __p;
	}
}
