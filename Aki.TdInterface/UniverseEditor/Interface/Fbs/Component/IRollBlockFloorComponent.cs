using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E92 RID: 24210
	public struct IRollBlockFloorComponent : IFlatbufferObject
	{
		// Token: 0x1700B2A7 RID: 45735
		// (get) Token: 0x06028848 RID: 165960 RVA: 0x0058A282 File Offset: 0x00588482
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028849 RID: 165961 RVA: 0x0058A28F File Offset: 0x0058848F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602884A RID: 165962 RVA: 0x0058A298 File Offset: 0x00588498
		public static IRollBlockFloorComponent GetRootAsIRollBlockFloorComponent(ByteBuffer _bb)
		{
			return IRollBlockFloorComponent.GetRootAsIRollBlockFloorComponent(_bb, default(IRollBlockFloorComponent));
		}

		// Token: 0x0602884B RID: 165963 RVA: 0x0058A2B4 File Offset: 0x005884B4
		public static IRollBlockFloorComponent GetRootAsIRollBlockFloorComponent(ByteBuffer _bb, IRollBlockFloorComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602884C RID: 165964 RVA: 0x0058A2D1 File Offset: 0x005884D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602884D RID: 165965 RVA: 0x0058A2E0 File Offset: 0x005884E0
		public IRollBlockFloorComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B2A8 RID: 45736
		// (get) Token: 0x0602884E RID: 165966 RVA: 0x0058A2F0 File Offset: 0x005884F0
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B2A9 RID: 45737
		// (get) Token: 0x0602884F RID: 165967 RVA: 0x0058A330 File Offset: 0x00588530
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028850 RID: 165968 RVA: 0x0058A36C File Offset: 0x0058856C
		public static Offset<IRollBlockFloorComponent> CreateIRollBlockFloorComponent(FlatBufferBuilder builder, bool Disabled = false, byte NullMask = 0)
		{
			builder.StartTable(2);
			IRollBlockFloorComponent.AddNullMask(builder, NullMask);
			IRollBlockFloorComponent.AddDisabled(builder, Disabled);
			return IRollBlockFloorComponent.EndIRollBlockFloorComponent(builder);
		}

		// Token: 0x06028851 RID: 165969 RVA: 0x0058A389 File Offset: 0x00588589
		public static void StartIRollBlockFloorComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06028852 RID: 165970 RVA: 0x0058A392 File Offset: 0x00588592
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06028853 RID: 165971 RVA: 0x0058A39D File Offset: 0x0058859D
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x06028854 RID: 165972 RVA: 0x0058A3A8 File Offset: 0x005885A8
		public static Offset<IRollBlockFloorComponent> EndIRollBlockFloorComponent(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockFloorComponent>(builder.EndTable());
		}

		// Token: 0x06028855 RID: 165973 RVA: 0x0058A3B8 File Offset: 0x005885B8
		public IRollBlockFloorComponentT UnPack()
		{
			IRollBlockFloorComponentT rollBlockFloorComponentT = new IRollBlockFloorComponentT();
			this.UnPackTo(rollBlockFloorComponentT);
			return rollBlockFloorComponentT;
		}

		// Token: 0x06028856 RID: 165974 RVA: 0x0058A3D3 File Offset: 0x005885D3
		public void UnPackTo(IRollBlockFloorComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06028857 RID: 165975 RVA: 0x0058A3F0 File Offset: 0x005885F0
		public static Offset<IRollBlockFloorComponent> Pack(FlatBufferBuilder builder, IRollBlockFloorComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRollBlockFloorComponent>);
			}
			return IRollBlockFloorComponent.CreateIRollBlockFloorComponent(builder, _o.Disabled, _o.NullMask);
		}

		// Token: 0x0400FAC3 RID: 64195
		private Table __p;
	}
}
