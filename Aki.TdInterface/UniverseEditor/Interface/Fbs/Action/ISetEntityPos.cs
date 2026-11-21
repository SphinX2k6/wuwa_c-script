using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077AC RID: 30636
	public struct ISetEntityPos : IFlatbufferObject
	{
		// Token: 0x1700E07A RID: 57466
		// (get) Token: 0x06035C9A RID: 220314 RVA: 0x00734B27 File Offset: 0x00732D27
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035C9B RID: 220315 RVA: 0x00734B34 File Offset: 0x00732D34
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035C9C RID: 220316 RVA: 0x00734B3C File Offset: 0x00732D3C
		public static ISetEntityPos GetRootAsISetEntityPos(ByteBuffer _bb)
		{
			return ISetEntityPos.GetRootAsISetEntityPos(_bb, default(ISetEntityPos));
		}

		// Token: 0x06035C9D RID: 220317 RVA: 0x00734B58 File Offset: 0x00732D58
		public static ISetEntityPos GetRootAsISetEntityPos(ByteBuffer _bb, ISetEntityPos obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035C9E RID: 220318 RVA: 0x00734B75 File Offset: 0x00732D75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035C9F RID: 220319 RVA: 0x00734B84 File Offset: 0x00732D84
		public ISetEntityPos __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E07B RID: 57467
		// (get) Token: 0x06035CA0 RID: 220320 RVA: 0x00734B94 File Offset: 0x00732D94
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E07C RID: 57468
		// (get) Token: 0x06035CA1 RID: 220321 RVA: 0x00734BD0 File Offset: 0x00732DD0
		public IPosA? Pos
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IPosA?(default(IPosA).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700E07D RID: 57469
		// (get) Token: 0x06035CA2 RID: 220322 RVA: 0x00734C30 File Offset: 0x00732E30
		public IVectorInfo? Rot
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

		// Token: 0x06035CA3 RID: 220323 RVA: 0x00734C8D File Offset: 0x00732E8D
		public static Offset<ISetEntityPos> CreateISetEntityPos(FlatBufferBuilder builder, int EntityId = 0, Offset<IPosA> PosOffset = default(Offset<IPosA>), Offset<IVectorInfo> RotOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(3);
			ISetEntityPos.AddRot(builder, RotOffset);
			ISetEntityPos.AddPos(builder, PosOffset);
			ISetEntityPos.AddEntityId(builder, EntityId);
			return ISetEntityPos.EndISetEntityPos(builder);
		}

		// Token: 0x06035CA4 RID: 220324 RVA: 0x00734CB1 File Offset: 0x00732EB1
		public static void StartISetEntityPos(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06035CA5 RID: 220325 RVA: 0x00734CBA File Offset: 0x00732EBA
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x06035CA6 RID: 220326 RVA: 0x00734CC5 File Offset: 0x00732EC5
		public static void AddPos(FlatBufferBuilder builder, Offset<IPosA> posOffset)
		{
			builder.AddOffset(1, posOffset.Value, 0);
		}

		// Token: 0x06035CA7 RID: 220327 RVA: 0x00734CD5 File Offset: 0x00732ED5
		public static void AddRot(FlatBufferBuilder builder, Offset<IVectorInfo> rotOffset)
		{
			builder.AddOffset(2, rotOffset.Value, 0);
		}

		// Token: 0x06035CA8 RID: 220328 RVA: 0x00734CE5 File Offset: 0x00732EE5
		public static Offset<ISetEntityPos> EndISetEntityPos(FlatBufferBuilder builder)
		{
			return new Offset<ISetEntityPos>(builder.EndTable());
		}

		// Token: 0x06035CA9 RID: 220329 RVA: 0x00734CF4 File Offset: 0x00732EF4
		public ISetEntityPosT UnPack()
		{
			ISetEntityPosT setEntityPosT = new ISetEntityPosT();
			this.UnPackTo(setEntityPosT);
			return setEntityPosT;
		}

		// Token: 0x06035CAA RID: 220330 RVA: 0x00734D10 File Offset: 0x00732F10
		public void UnPackTo(ISetEntityPosT _o)
		{
			_o.EntityId = this.EntityId;
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
			_o.Rot = ((this.Rot != null) ? this.Rot.Value.UnPack() : null);
		}

		// Token: 0x06035CAB RID: 220331 RVA: 0x00734D88 File Offset: 0x00732F88
		public static Offset<ISetEntityPos> Pack(FlatBufferBuilder builder, ISetEntityPosT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetEntityPos>);
			}
			Offset<IPosA> posOffset = (_o.Pos == null) ? default(Offset<IPosA>) : IPosA.Pack(builder, _o.Pos);
			Offset<IVectorInfo> rotOffset = (_o.Rot == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Rot);
			return ISetEntityPos.CreateISetEntityPos(builder, _o.EntityId, posOffset, rotOffset);
		}

		// Token: 0x040129D6 RID: 76246
		private Table __p;
	}
}
