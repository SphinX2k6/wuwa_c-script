using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005745 RID: 22341
	public struct IExploreSkillEavesdrop : IFlatbufferObject
	{
		// Token: 0x1700A158 RID: 41304
		// (get) Token: 0x06023F3E RID: 147262 RVA: 0x004F1232 File Offset: 0x004EF432
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023F3F RID: 147263 RVA: 0x004F123F File Offset: 0x004EF43F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023F40 RID: 147264 RVA: 0x004F1248 File Offset: 0x004EF448
		public static IExploreSkillEavesdrop GetRootAsIExploreSkillEavesdrop(ByteBuffer _bb)
		{
			return IExploreSkillEavesdrop.GetRootAsIExploreSkillEavesdrop(_bb, default(IExploreSkillEavesdrop));
		}

		// Token: 0x06023F41 RID: 147265 RVA: 0x004F1264 File Offset: 0x004EF464
		public static IExploreSkillEavesdrop GetRootAsIExploreSkillEavesdrop(ByteBuffer _bb, IExploreSkillEavesdrop obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023F42 RID: 147266 RVA: 0x004F1281 File Offset: 0x004EF481
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023F43 RID: 147267 RVA: 0x004F1290 File Offset: 0x004EF490
		public IExploreSkillEavesdrop __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A159 RID: 41305
		// (get) Token: 0x06023F44 RID: 147268 RVA: 0x004F12A0 File Offset: 0x004EF4A0
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

		// Token: 0x06023F45 RID: 147269 RVA: 0x004F12DC File Offset: 0x004EF4DC
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A15A RID: 41306
		// (get) Token: 0x06023F46 RID: 147270 RVA: 0x004F133C File Offset: 0x004EF53C
		public int ActionsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700A15B RID: 41307
		// (get) Token: 0x06023F47 RID: 147271 RVA: 0x004F1368 File Offset: 0x004EF568
		public IVectorInfo? InteractOffset
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06023F48 RID: 147272 RVA: 0x004F13C5 File Offset: 0x004EF5C5
		public static Offset<IExploreSkillEavesdrop> CreateIExploreSkillEavesdrop(FlatBufferBuilder builder, EExploreSkillInteractType Type = EExploreSkillInteractType.PullGiant, VectorOffset ActionsOffset = default(VectorOffset), Offset<IVectorInfo> InteractOffsetOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(3);
			IExploreSkillEavesdrop.AddInteractOffset(builder, InteractOffsetOffset);
			IExploreSkillEavesdrop.AddActions(builder, ActionsOffset);
			IExploreSkillEavesdrop.AddType(builder, Type);
			return IExploreSkillEavesdrop.EndIExploreSkillEavesdrop(builder);
		}

		// Token: 0x06023F49 RID: 147273 RVA: 0x004F13E9 File Offset: 0x004EF5E9
		public static void StartIExploreSkillEavesdrop(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06023F4A RID: 147274 RVA: 0x004F13F2 File Offset: 0x004EF5F2
		public static void AddType(FlatBufferBuilder builder, EExploreSkillInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06023F4B RID: 147275 RVA: 0x004F13FD File Offset: 0x004EF5FD
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(1, actionsOffset.Value, 0);
		}

		// Token: 0x06023F4C RID: 147276 RVA: 0x004F1410 File Offset: 0x004EF610
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023F4D RID: 147277 RVA: 0x004F1450 File Offset: 0x004EF650
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023F4E RID: 147278 RVA: 0x004F146A File Offset: 0x004EF66A
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023F4F RID: 147279 RVA: 0x004F1488 File Offset: 0x004EF688
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023F50 RID: 147280 RVA: 0x004F14A1 File Offset: 0x004EF6A1
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023F51 RID: 147281 RVA: 0x004F14AC File Offset: 0x004EF6AC
		public static void AddInteractOffset(FlatBufferBuilder builder, Offset<IVectorInfo> interactOffsetOffset)
		{
			builder.AddOffset(2, interactOffsetOffset.Value, 0);
		}

		// Token: 0x06023F52 RID: 147282 RVA: 0x004F14BC File Offset: 0x004EF6BC
		public static Offset<IExploreSkillEavesdrop> EndIExploreSkillEavesdrop(FlatBufferBuilder builder)
		{
			return new Offset<IExploreSkillEavesdrop>(builder.EndTable());
		}

		// Token: 0x06023F53 RID: 147283 RVA: 0x004F14CC File Offset: 0x004EF6CC
		public IExploreSkillEavesdropT UnPack()
		{
			IExploreSkillEavesdropT exploreSkillEavesdropT = new IExploreSkillEavesdropT();
			this.UnPackTo(exploreSkillEavesdropT);
			return exploreSkillEavesdropT;
		}

		// Token: 0x06023F54 RID: 147284 RVA: 0x004F14E8 File Offset: 0x004EF6E8
		public void UnPackTo(IExploreSkillEavesdropT _o)
		{
			_o.Type = this.Type;
			_o.Actions = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionsLength; i++)
			{
				_o.Actions.Add((this.Actions(i) != null) ? this.Actions(i).Value.UnPack() : null);
			}
			_o.InteractOffset = ((this.InteractOffset != null) ? this.InteractOffset.Value.UnPack() : null);
		}

		// Token: 0x06023F55 RID: 147285 RVA: 0x004F1584 File Offset: 0x004EF784
		public static Offset<IExploreSkillEavesdrop> Pack(FlatBufferBuilder builder, IExploreSkillEavesdropT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExploreSkillEavesdrop>);
			}
			VectorOffset actionsOffset = default(VectorOffset);
			if (_o.Actions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.Actions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.Actions[i]);
				}
				actionsOffset = IExploreSkillEavesdrop.CreateActionsVector(builder, array);
			}
			Offset<IVectorInfo> interactOffsetOffset = (_o.InteractOffset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.InteractOffset);
			return IExploreSkillEavesdrop.CreateIExploreSkillEavesdrop(builder, _o.Type, actionsOffset, interactOffsetOffset);
		}

		// Token: 0x0400EEEB RID: 61163
		private Table __p;
	}
}
