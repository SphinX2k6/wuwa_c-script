using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200589B RID: 22683
	public struct IGraph3dEffectComponent : IFlatbufferObject
	{
		// Token: 0x1700A460 RID: 42080
		// (get) Token: 0x06024C98 RID: 150680 RVA: 0x0050D356 File Offset: 0x0050B556
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024C99 RID: 150681 RVA: 0x0050D363 File Offset: 0x0050B563
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024C9A RID: 150682 RVA: 0x0050D36C File Offset: 0x0050B56C
		public static IGraph3dEffectComponent GetRootAsIGraph3dEffectComponent(ByteBuffer _bb)
		{
			return IGraph3dEffectComponent.GetRootAsIGraph3dEffectComponent(_bb, default(IGraph3dEffectComponent));
		}

		// Token: 0x06024C9B RID: 150683 RVA: 0x0050D388 File Offset: 0x0050B588
		public static IGraph3dEffectComponent GetRootAsIGraph3dEffectComponent(ByteBuffer _bb, IGraph3dEffectComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024C9C RID: 150684 RVA: 0x0050D3A5 File Offset: 0x0050B5A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024C9D RID: 150685 RVA: 0x0050D3B4 File Offset: 0x0050B5B4
		public IGraph3dEffectComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A461 RID: 42081
		// (get) Token: 0x06024C9E RID: 150686 RVA: 0x0050D3C4 File Offset: 0x0050B5C4
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A462 RID: 42082
		// (get) Token: 0x06024C9F RID: 150687 RVA: 0x0050D404 File Offset: 0x0050B604
		public int Graph3dEntityId
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

		// Token: 0x1700A463 RID: 42083
		// (get) Token: 0x06024CA0 RID: 150688 RVA: 0x0050D440 File Offset: 0x0050B640
		public IFireBoxFishEffect? EffectType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IFireBoxFishEffect?(default(IFireBoxFishEffect).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A464 RID: 42084
		// (get) Token: 0x06024CA1 RID: 150689 RVA: 0x0050D4A0 File Offset: 0x0050B6A0
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

		// Token: 0x06024CA2 RID: 150690 RVA: 0x0050D4DD File Offset: 0x0050B6DD
		public static Offset<IGraph3dEffectComponent> CreateIGraph3dEffectComponent(FlatBufferBuilder builder, bool Disabled = false, int Graph3dEntityId = 0, Offset<IFireBoxFishEffect> EffectTypeOffset = default(Offset<IFireBoxFishEffect>), byte NullMask = 0)
		{
			builder.StartTable(4);
			IGraph3dEffectComponent.AddEffectType(builder, EffectTypeOffset);
			IGraph3dEffectComponent.AddGraph3dEntityId(builder, Graph3dEntityId);
			IGraph3dEffectComponent.AddNullMask(builder, NullMask);
			IGraph3dEffectComponent.AddDisabled(builder, Disabled);
			return IGraph3dEffectComponent.EndIGraph3dEffectComponent(builder);
		}

		// Token: 0x06024CA3 RID: 150691 RVA: 0x0050D509 File Offset: 0x0050B709
		public static void StartIGraph3dEffectComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06024CA4 RID: 150692 RVA: 0x0050D512 File Offset: 0x0050B712
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06024CA5 RID: 150693 RVA: 0x0050D51D File Offset: 0x0050B71D
		public static void AddGraph3dEntityId(FlatBufferBuilder builder, int graph3dEntityId)
		{
			builder.AddInt(1, graph3dEntityId, 0);
		}

		// Token: 0x06024CA6 RID: 150694 RVA: 0x0050D528 File Offset: 0x0050B728
		public static void AddEffectType(FlatBufferBuilder builder, Offset<IFireBoxFishEffect> effectTypeOffset)
		{
			builder.AddOffset(2, effectTypeOffset.Value, 0);
		}

		// Token: 0x06024CA7 RID: 150695 RVA: 0x0050D538 File Offset: 0x0050B738
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06024CA8 RID: 150696 RVA: 0x0050D543 File Offset: 0x0050B743
		public static Offset<IGraph3dEffectComponent> EndIGraph3dEffectComponent(FlatBufferBuilder builder)
		{
			return new Offset<IGraph3dEffectComponent>(builder.EndTable());
		}

		// Token: 0x06024CA9 RID: 150697 RVA: 0x0050D550 File Offset: 0x0050B750
		public IGraph3dEffectComponentT UnPack()
		{
			IGraph3dEffectComponentT graph3dEffectComponentT = new IGraph3dEffectComponentT();
			this.UnPackTo(graph3dEffectComponentT);
			return graph3dEffectComponentT;
		}

		// Token: 0x06024CAA RID: 150698 RVA: 0x0050D56C File Offset: 0x0050B76C
		public void UnPackTo(IGraph3dEffectComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.Graph3dEntityId = this.Graph3dEntityId;
			_o.EffectType = ((this.EffectType != null) ? this.EffectType.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06024CAB RID: 150699 RVA: 0x0050D5CC File Offset: 0x0050B7CC
		public static Offset<IGraph3dEffectComponent> Pack(FlatBufferBuilder builder, IGraph3dEffectComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGraph3dEffectComponent>);
			}
			Offset<IFireBoxFishEffect> effectTypeOffset = (_o.EffectType == null) ? default(Offset<IFireBoxFishEffect>) : IFireBoxFishEffect.Pack(builder, _o.EffectType);
			return IGraph3dEffectComponent.CreateIGraph3dEffectComponent(builder, _o.Disabled, _o.Graph3dEntityId, effectTypeOffset, _o.NullMask);
		}

		// Token: 0x0400F0FC RID: 61692
		private Table __p;
	}
}
