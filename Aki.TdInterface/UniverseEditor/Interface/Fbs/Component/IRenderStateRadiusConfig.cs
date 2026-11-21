using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E5F RID: 24159
	public struct IRenderStateRadiusConfig : IFlatbufferObject
	{
		// Token: 0x1700B226 RID: 45606
		// (get) Token: 0x0602863B RID: 165435 RVA: 0x00585DDA File Offset: 0x00583FDA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602863C RID: 165436 RVA: 0x00585DE7 File Offset: 0x00583FE7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602863D RID: 165437 RVA: 0x00585DF0 File Offset: 0x00583FF0
		public static IRenderStateRadiusConfig GetRootAsIRenderStateRadiusConfig(ByteBuffer _bb)
		{
			return IRenderStateRadiusConfig.GetRootAsIRenderStateRadiusConfig(_bb, default(IRenderStateRadiusConfig));
		}

		// Token: 0x0602863E RID: 165438 RVA: 0x00585E0C File Offset: 0x0058400C
		public static IRenderStateRadiusConfig GetRootAsIRenderStateRadiusConfig(ByteBuffer _bb, IRenderStateRadiusConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602863F RID: 165439 RVA: 0x00585E29 File Offset: 0x00584029
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028640 RID: 165440 RVA: 0x00585E38 File Offset: 0x00584038
		public IRenderStateRadiusConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B227 RID: 45607
		// (get) Token: 0x06028641 RID: 165441 RVA: 0x00585E48 File Offset: 0x00584048
		public string State
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028642 RID: 165442 RVA: 0x00585E7F File Offset: 0x0058407F
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06028643 RID: 165443 RVA: 0x00585E8E File Offset: 0x0058408E
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700B228 RID: 45608
		// (get) Token: 0x06028644 RID: 165444 RVA: 0x00585E9C File Offset: 0x0058409C
		public float Radius
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

		// Token: 0x06028645 RID: 165445 RVA: 0x00585EDC File Offset: 0x005840DC
		public static Offset<IRenderStateRadiusConfig> CreateIRenderStateRadiusConfig(FlatBufferBuilder builder, StringOffset StateOffset = default(StringOffset), float Radius = 0f)
		{
			builder.StartTable(2);
			IRenderStateRadiusConfig.AddRadius(builder, Radius);
			IRenderStateRadiusConfig.AddState(builder, StateOffset);
			return IRenderStateRadiusConfig.EndIRenderStateRadiusConfig(builder);
		}

		// Token: 0x06028646 RID: 165446 RVA: 0x00585EF9 File Offset: 0x005840F9
		public static void StartIRenderStateRadiusConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06028647 RID: 165447 RVA: 0x00585F02 File Offset: 0x00584102
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(0, stateOffset.Value, 0);
		}

		// Token: 0x06028648 RID: 165448 RVA: 0x00585F12 File Offset: 0x00584112
		public static void AddRadius(FlatBufferBuilder builder, float radius)
		{
			builder.AddFloat(1, radius, 0.0);
		}

		// Token: 0x06028649 RID: 165449 RVA: 0x00585F25 File Offset: 0x00584125
		public static Offset<IRenderStateRadiusConfig> EndIRenderStateRadiusConfig(FlatBufferBuilder builder)
		{
			return new Offset<IRenderStateRadiusConfig>(builder.EndTable());
		}

		// Token: 0x0602864A RID: 165450 RVA: 0x00585F34 File Offset: 0x00584134
		public IRenderStateRadiusConfigT UnPack()
		{
			IRenderStateRadiusConfigT renderStateRadiusConfigT = new IRenderStateRadiusConfigT();
			this.UnPackTo(renderStateRadiusConfigT);
			return renderStateRadiusConfigT;
		}

		// Token: 0x0602864B RID: 165451 RVA: 0x00585F4F File Offset: 0x0058414F
		public void UnPackTo(IRenderStateRadiusConfigT _o)
		{
			_o.State = this.State;
			_o.Radius = this.Radius;
		}

		// Token: 0x0602864C RID: 165452 RVA: 0x00585F6C File Offset: 0x0058416C
		public static Offset<IRenderStateRadiusConfig> Pack(FlatBufferBuilder builder, IRenderStateRadiusConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRenderStateRadiusConfig>);
			}
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			return IRenderStateRadiusConfig.CreateIRenderStateRadiusConfig(builder, stateOffset, _o.Radius);
		}

		// Token: 0x0400FA71 RID: 64113
		private Table __p;
	}
}
