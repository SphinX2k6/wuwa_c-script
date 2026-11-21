using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E45 RID: 24133
	public struct IRenderBeforeYourEyesSceneReveal : IFlatbufferObject
	{
		// Token: 0x1700B1E4 RID: 45540
		// (get) Token: 0x0602851B RID: 165147 RVA: 0x005830AC File Offset: 0x005812AC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602851C RID: 165148 RVA: 0x005830B9 File Offset: 0x005812B9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602851D RID: 165149 RVA: 0x005830C0 File Offset: 0x005812C0
		public static IRenderBeforeYourEyesSceneReveal GetRootAsIRenderBeforeYourEyesSceneReveal(ByteBuffer _bb)
		{
			return IRenderBeforeYourEyesSceneReveal.GetRootAsIRenderBeforeYourEyesSceneReveal(_bb, default(IRenderBeforeYourEyesSceneReveal));
		}

		// Token: 0x0602851E RID: 165150 RVA: 0x005830DC File Offset: 0x005812DC
		public static IRenderBeforeYourEyesSceneReveal GetRootAsIRenderBeforeYourEyesSceneReveal(ByteBuffer _bb, IRenderBeforeYourEyesSceneReveal obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602851F RID: 165151 RVA: 0x005830F9 File Offset: 0x005812F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028520 RID: 165152 RVA: 0x00583108 File Offset: 0x00581308
		public IRenderBeforeYourEyesSceneReveal __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B1E5 RID: 45541
		// (get) Token: 0x06028521 RID: 165153 RVA: 0x00583118 File Offset: 0x00581318
		public ERenderSpecifiedRangeType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERenderSpecifiedRangeType.FlowerBridge;
				}
				return (ERenderSpecifiedRangeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B1E6 RID: 45542
		// (get) Token: 0x06028522 RID: 165154 RVA: 0x00583154 File Offset: 0x00581354
		public TTargetEntity CenterTargetType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TTargetEntity.NONE;
				}
				return (TTargetEntity)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028523 RID: 165155 RVA: 0x00583190 File Offset: 0x00581390
		public TTable? CenterTarget<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06028524 RID: 165156 RVA: 0x005831D4 File Offset: 0x005813D4
		public IPlayerEntity CenterTargetAsIPlayerEntity()
		{
			return this.CenterTarget<IPlayerEntity>().Value;
		}

		// Token: 0x06028525 RID: 165157 RVA: 0x005831F0 File Offset: 0x005813F0
		public ISelfEntity CenterTargetAsISelfEntity()
		{
			return this.CenterTarget<ISelfEntity>().Value;
		}

		// Token: 0x06028526 RID: 165158 RVA: 0x0058320C File Offset: 0x0058140C
		public ITargetEntity CenterTargetAsITargetEntity()
		{
			return this.CenterTarget<ITargetEntity>().Value;
		}

		// Token: 0x06028527 RID: 165159 RVA: 0x00583228 File Offset: 0x00581428
		public ITriggeredEntity CenterTargetAsITriggeredEntity()
		{
			return this.CenterTarget<ITriggeredEntity>().Value;
		}

		// Token: 0x06028528 RID: 165160 RVA: 0x00583244 File Offset: 0x00581444
		public IVehicleEntity CenterTargetAsIVehicleEntity()
		{
			return this.CenterTarget<IVehicleEntity>().Value;
		}

		// Token: 0x06028529 RID: 165161 RVA: 0x00583260 File Offset: 0x00581460
		public IRenderStateRadiusConfig? StateRadiusConfigs(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IRenderStateRadiusConfig?(default(IRenderStateRadiusConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B1E7 RID: 45543
		// (get) Token: 0x0602852A RID: 165162 RVA: 0x005832C4 File Offset: 0x005814C4
		public int StateRadiusConfigsLength
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

		// Token: 0x0602852B RID: 165163 RVA: 0x005832F0 File Offset: 0x005814F0
		public static Offset<IRenderBeforeYourEyesSceneReveal> CreateIRenderBeforeYourEyesSceneReveal(FlatBufferBuilder builder, ERenderSpecifiedRangeType Type = ERenderSpecifiedRangeType.FlowerBridge, TTargetEntity CenterTarget_type = TTargetEntity.NONE, int CenterTargetOffset = 0, VectorOffset StateRadiusConfigsOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			IRenderBeforeYourEyesSceneReveal.AddStateRadiusConfigs(builder, StateRadiusConfigsOffset);
			IRenderBeforeYourEyesSceneReveal.AddCenterTarget(builder, CenterTargetOffset);
			IRenderBeforeYourEyesSceneReveal.AddCenterTargetType(builder, CenterTarget_type);
			IRenderBeforeYourEyesSceneReveal.AddType(builder, Type);
			return IRenderBeforeYourEyesSceneReveal.EndIRenderBeforeYourEyesSceneReveal(builder);
		}

		// Token: 0x0602852C RID: 165164 RVA: 0x0058331C File Offset: 0x0058151C
		public static void StartIRenderBeforeYourEyesSceneReveal(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602852D RID: 165165 RVA: 0x00583325 File Offset: 0x00581525
		public static void AddType(FlatBufferBuilder builder, ERenderSpecifiedRangeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602852E RID: 165166 RVA: 0x00583330 File Offset: 0x00581530
		public static void AddCenterTargetType(FlatBufferBuilder builder, TTargetEntity centerTargetType)
		{
			builder.AddByte(1, (byte)centerTargetType, 0);
		}

		// Token: 0x0602852F RID: 165167 RVA: 0x0058333B File Offset: 0x0058153B
		public static void AddCenterTarget(FlatBufferBuilder builder, int centerTargetOffset)
		{
			builder.AddOffset(2, centerTargetOffset, 0);
		}

		// Token: 0x06028530 RID: 165168 RVA: 0x00583346 File Offset: 0x00581546
		public static void AddStateRadiusConfigs(FlatBufferBuilder builder, VectorOffset stateRadiusConfigsOffset)
		{
			builder.AddOffset(3, stateRadiusConfigsOffset.Value, 0);
		}

		// Token: 0x06028531 RID: 165169 RVA: 0x00583358 File Offset: 0x00581558
		public static VectorOffset CreateStateRadiusConfigsVector(FlatBufferBuilder builder, Offset<IRenderStateRadiusConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06028532 RID: 165170 RVA: 0x00583398 File Offset: 0x00581598
		public static VectorOffset CreateStateRadiusConfigsVectorBlock(FlatBufferBuilder builder, Offset<IRenderStateRadiusConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IRenderStateRadiusConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028533 RID: 165171 RVA: 0x005833B2 File Offset: 0x005815B2
		public static VectorOffset CreateStateRadiusConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IRenderStateRadiusConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IRenderStateRadiusConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028534 RID: 165172 RVA: 0x005833D0 File Offset: 0x005815D0
		public static VectorOffset CreateStateRadiusConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IRenderStateRadiusConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06028535 RID: 165173 RVA: 0x005833E9 File Offset: 0x005815E9
		public static void StartStateRadiusConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06028536 RID: 165174 RVA: 0x005833F4 File Offset: 0x005815F4
		public static Offset<IRenderBeforeYourEyesSceneReveal> EndIRenderBeforeYourEyesSceneReveal(FlatBufferBuilder builder)
		{
			return new Offset<IRenderBeforeYourEyesSceneReveal>(builder.EndTable());
		}

		// Token: 0x06028537 RID: 165175 RVA: 0x00583404 File Offset: 0x00581604
		public IRenderBeforeYourEyesSceneRevealT UnPack()
		{
			IRenderBeforeYourEyesSceneRevealT renderBeforeYourEyesSceneRevealT = new IRenderBeforeYourEyesSceneRevealT();
			this.UnPackTo(renderBeforeYourEyesSceneRevealT);
			return renderBeforeYourEyesSceneRevealT;
		}

		// Token: 0x06028538 RID: 165176 RVA: 0x00583420 File Offset: 0x00581620
		public void UnPackTo(IRenderBeforeYourEyesSceneRevealT _o)
		{
			_o.Type = this.Type;
			_o.CenterTarget = new TTargetEntityUnion();
			_o.CenterTarget.Type = this.CenterTargetType;
			switch (this.CenterTargetType)
			{
			case TTargetEntity.IPlayerEntity:
				_o.CenterTarget.Value = ((this.CenterTarget<IPlayerEntity>() != null) ? this.CenterTarget<IPlayerEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ISelfEntity:
				_o.CenterTarget.Value = ((this.CenterTarget<ISelfEntity>() != null) ? this.CenterTarget<ISelfEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ITargetEntity:
				_o.CenterTarget.Value = ((this.CenterTarget<ITargetEntity>() != null) ? this.CenterTarget<ITargetEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ITriggeredEntity:
				_o.CenterTarget.Value = ((this.CenterTarget<ITriggeredEntity>() != null) ? this.CenterTarget<ITriggeredEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.IVehicleEntity:
				_o.CenterTarget.Value = ((this.CenterTarget<IVehicleEntity>() != null) ? this.CenterTarget<IVehicleEntity>().Value.UnPack() : null);
				break;
			}
			_o.StateRadiusConfigs = new List<IRenderStateRadiusConfigT>();
			for (int i = 0; i < this.StateRadiusConfigsLength; i++)
			{
				_o.StateRadiusConfigs.Add((this.StateRadiusConfigs(i) != null) ? this.StateRadiusConfigs(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06028539 RID: 165177 RVA: 0x005835F4 File Offset: 0x005817F4
		public static Offset<IRenderBeforeYourEyesSceneReveal> Pack(FlatBufferBuilder builder, IRenderBeforeYourEyesSceneRevealT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRenderBeforeYourEyesSceneReveal>);
			}
			TTargetEntity centerTarget_type = (_o.CenterTarget == null) ? TTargetEntity.NONE : _o.CenterTarget.Type;
			int centerTargetOffset = (_o.CenterTarget == null) ? 0 : TTargetEntityUnion.Pack(builder, _o.CenterTarget);
			VectorOffset stateRadiusConfigsOffset = default(VectorOffset);
			if (_o.StateRadiusConfigs != null)
			{
				Offset<IRenderStateRadiusConfig>[] array = new Offset<IRenderStateRadiusConfig>[_o.StateRadiusConfigs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IRenderStateRadiusConfig.Pack(builder, _o.StateRadiusConfigs[i]);
				}
				stateRadiusConfigsOffset = IRenderBeforeYourEyesSceneReveal.CreateStateRadiusConfigsVector(builder, array);
			}
			return IRenderBeforeYourEyesSceneReveal.CreateIRenderBeforeYourEyesSceneReveal(builder, _o.Type, centerTarget_type, centerTargetOffset, stateRadiusConfigsOffset);
		}

		// Token: 0x0400FA43 RID: 64067
		private Table __p;
	}
}
