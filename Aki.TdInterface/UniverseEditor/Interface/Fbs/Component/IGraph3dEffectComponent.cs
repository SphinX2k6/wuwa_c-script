using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005315 RID: 21269
	public struct IGraph3dEffectComponent : IFlatbufferObject
	{
		// Token: 0x17009C28 RID: 39976
		// (get) Token: 0x06022BE4 RID: 142308 RVA: 0x004D0482 File Offset: 0x004CE682
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022BE5 RID: 142309 RVA: 0x004D048F File Offset: 0x004CE68F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022BE6 RID: 142310 RVA: 0x004D0498 File Offset: 0x004CE698
		public static IGraph3dEffectComponent GetRootAsIGraph3dEffectComponent(ByteBuffer _bb)
		{
			return IGraph3dEffectComponent.GetRootAsIGraph3dEffectComponent(_bb, default(IGraph3dEffectComponent));
		}

		// Token: 0x06022BE7 RID: 142311 RVA: 0x004D04B4 File Offset: 0x004CE6B4
		public static IGraph3dEffectComponent GetRootAsIGraph3dEffectComponent(ByteBuffer _bb, IGraph3dEffectComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022BE8 RID: 142312 RVA: 0x004D04D1 File Offset: 0x004CE6D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022BE9 RID: 142313 RVA: 0x004D04E0 File Offset: 0x004CE6E0
		public IGraph3dEffectComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009C29 RID: 39977
		// (get) Token: 0x06022BEA RID: 142314 RVA: 0x004D04F0 File Offset: 0x004CE6F0
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009C2A RID: 39978
		// (get) Token: 0x06022BEB RID: 142315 RVA: 0x004D0530 File Offset: 0x004CE730
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

		// Token: 0x17009C2B RID: 39979
		// (get) Token: 0x06022BEC RID: 142316 RVA: 0x004D056C File Offset: 0x004CE76C
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

		// Token: 0x17009C2C RID: 39980
		// (get) Token: 0x06022BED RID: 142317 RVA: 0x004D05CC File Offset: 0x004CE7CC
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

		// Token: 0x06022BEE RID: 142318 RVA: 0x004D0609 File Offset: 0x004CE809
		public static Offset<IGraph3dEffectComponent> CreateIGraph3dEffectComponent(FlatBufferBuilder builder, bool Disabled = false, int Graph3dEntityId = 0, Offset<IFireBoxFishEffect> EffectTypeOffset = default(Offset<IFireBoxFishEffect>), byte NullMask = 0)
		{
			builder.StartTable(4);
			IGraph3dEffectComponent.AddEffectType(builder, EffectTypeOffset);
			IGraph3dEffectComponent.AddGraph3dEntityId(builder, Graph3dEntityId);
			IGraph3dEffectComponent.AddNullMask(builder, NullMask);
			IGraph3dEffectComponent.AddDisabled(builder, Disabled);
			return IGraph3dEffectComponent.EndIGraph3dEffectComponent(builder);
		}

		// Token: 0x06022BEF RID: 142319 RVA: 0x004D0635 File Offset: 0x004CE835
		public static void StartIGraph3dEffectComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06022BF0 RID: 142320 RVA: 0x004D063E File Offset: 0x004CE83E
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06022BF1 RID: 142321 RVA: 0x004D0649 File Offset: 0x004CE849
		public static void AddGraph3dEntityId(FlatBufferBuilder builder, int graph3dEntityId)
		{
			builder.AddInt(1, graph3dEntityId, 0);
		}

		// Token: 0x06022BF2 RID: 142322 RVA: 0x004D0654 File Offset: 0x004CE854
		public static void AddEffectType(FlatBufferBuilder builder, Offset<IFireBoxFishEffect> effectTypeOffset)
		{
			builder.AddOffset(2, effectTypeOffset.Value, 0);
		}

		// Token: 0x06022BF3 RID: 142323 RVA: 0x004D0664 File Offset: 0x004CE864
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06022BF4 RID: 142324 RVA: 0x004D066F File Offset: 0x004CE86F
		public static Offset<IGraph3dEffectComponent> EndIGraph3dEffectComponent(FlatBufferBuilder builder)
		{
			return new Offset<IGraph3dEffectComponent>(builder.EndTable());
		}

		// Token: 0x06022BF5 RID: 142325 RVA: 0x004D067C File Offset: 0x004CE87C
		public IGraph3dEffectComponentT UnPack()
		{
			IGraph3dEffectComponentT graph3dEffectComponentT = new IGraph3dEffectComponentT();
			this.UnPackTo(graph3dEffectComponentT);
			return graph3dEffectComponentT;
		}

		// Token: 0x06022BF6 RID: 142326 RVA: 0x004D0698 File Offset: 0x004CE898
		public void UnPackTo(IGraph3dEffectComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.Graph3dEntityId = this.Graph3dEntityId;
			_o.EffectType = ((this.EffectType != null) ? this.EffectType.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06022BF7 RID: 142327 RVA: 0x004D06F8 File Offset: 0x004CE8F8
		public static Offset<IGraph3dEffectComponent> Pack(FlatBufferBuilder builder, IGraph3dEffectComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGraph3dEffectComponent>);
			}
			Offset<IFireBoxFishEffect> effectTypeOffset = (_o.EffectType == null) ? default(Offset<IFireBoxFishEffect>) : IFireBoxFishEffect.Pack(builder, _o.EffectType);
			return IGraph3dEffectComponent.CreateIGraph3dEffectComponent(builder, _o.Disabled, _o.Graph3dEntityId, effectTypeOffset, _o.NullMask);
		}

		// Token: 0x0400E4CC RID: 58572
		private Table __p;
	}
}
