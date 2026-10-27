using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051E0 RID: 20960
	public struct IExploreSkillEavesdrop : IFlatbufferObject
	{
		// Token: 0x17009969 RID: 39273
		// (get) Token: 0x06021FE6 RID: 139238 RVA: 0x004B71CA File Offset: 0x004B53CA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021FE7 RID: 139239 RVA: 0x004B71D7 File Offset: 0x004B53D7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021FE8 RID: 139240 RVA: 0x004B71E0 File Offset: 0x004B53E0
		public static IExploreSkillEavesdrop GetRootAsIExploreSkillEavesdrop(ByteBuffer _bb)
		{
			return IExploreSkillEavesdrop.GetRootAsIExploreSkillEavesdrop(_bb, default(IExploreSkillEavesdrop));
		}

		// Token: 0x06021FE9 RID: 139241 RVA: 0x004B71FC File Offset: 0x004B53FC
		public static IExploreSkillEavesdrop GetRootAsIExploreSkillEavesdrop(ByteBuffer _bb, IExploreSkillEavesdrop obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021FEA RID: 139242 RVA: 0x004B7219 File Offset: 0x004B5419
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021FEB RID: 139243 RVA: 0x004B7228 File Offset: 0x004B5428
		public IExploreSkillEavesdrop __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700996A RID: 39274
		// (get) Token: 0x06021FEC RID: 139244 RVA: 0x004B7238 File Offset: 0x004B5438
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

		// Token: 0x06021FED RID: 139245 RVA: 0x004B7274 File Offset: 0x004B5474
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700996B RID: 39275
		// (get) Token: 0x06021FEE RID: 139246 RVA: 0x004B72D4 File Offset: 0x004B54D4
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

		// Token: 0x1700996C RID: 39276
		// (get) Token: 0x06021FEF RID: 139247 RVA: 0x004B7300 File Offset: 0x004B5500
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

		// Token: 0x06021FF0 RID: 139248 RVA: 0x004B735D File Offset: 0x004B555D
		public static Offset<IExploreSkillEavesdrop> CreateIExploreSkillEavesdrop(FlatBufferBuilder builder, EExploreSkillInteractType Type = EExploreSkillInteractType.PullGiant, VectorOffset ActionsOffset = default(VectorOffset), Offset<IVectorInfo> InteractOffsetOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(3);
			IExploreSkillEavesdrop.AddInteractOffset(builder, InteractOffsetOffset);
			IExploreSkillEavesdrop.AddActions(builder, ActionsOffset);
			IExploreSkillEavesdrop.AddType(builder, Type);
			return IExploreSkillEavesdrop.EndIExploreSkillEavesdrop(builder);
		}

		// Token: 0x06021FF1 RID: 139249 RVA: 0x004B7381 File Offset: 0x004B5581
		public static void StartIExploreSkillEavesdrop(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06021FF2 RID: 139250 RVA: 0x004B738A File Offset: 0x004B558A
		public static void AddType(FlatBufferBuilder builder, EExploreSkillInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06021FF3 RID: 139251 RVA: 0x004B7395 File Offset: 0x004B5595
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(1, actionsOffset.Value, 0);
		}

		// Token: 0x06021FF4 RID: 139252 RVA: 0x004B73A8 File Offset: 0x004B55A8
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06021FF5 RID: 139253 RVA: 0x004B73E8 File Offset: 0x004B55E8
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021FF6 RID: 139254 RVA: 0x004B7402 File Offset: 0x004B5602
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021FF7 RID: 139255 RVA: 0x004B7420 File Offset: 0x004B5620
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021FF8 RID: 139256 RVA: 0x004B7439 File Offset: 0x004B5639
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021FF9 RID: 139257 RVA: 0x004B7444 File Offset: 0x004B5644
		public static void AddInteractOffset(FlatBufferBuilder builder, Offset<IVectorInfo> interactOffsetOffset)
		{
			builder.AddOffset(2, interactOffsetOffset.Value, 0);
		}

		// Token: 0x06021FFA RID: 139258 RVA: 0x004B7454 File Offset: 0x004B5654
		public static Offset<IExploreSkillEavesdrop> EndIExploreSkillEavesdrop(FlatBufferBuilder builder)
		{
			return new Offset<IExploreSkillEavesdrop>(builder.EndTable());
		}

		// Token: 0x06021FFB RID: 139259 RVA: 0x004B7464 File Offset: 0x004B5664
		public IExploreSkillEavesdropT UnPack()
		{
			IExploreSkillEavesdropT exploreSkillEavesdropT = new IExploreSkillEavesdropT();
			this.UnPackTo(exploreSkillEavesdropT);
			return exploreSkillEavesdropT;
		}

		// Token: 0x06021FFC RID: 139260 RVA: 0x004B7480 File Offset: 0x004B5680
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

		// Token: 0x06021FFD RID: 139261 RVA: 0x004B751C File Offset: 0x004B571C
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

		// Token: 0x0400E2ED RID: 58093
		private Table __p;
	}
}
