using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A4C RID: 23116
	public struct ITeleportComponent : IFlatbufferObject
	{
		// Token: 0x1700ADDE RID: 44510
		// (get) Token: 0x060274E4 RID: 160996 RVA: 0x00568864 File Offset: 0x00566A64
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060274E5 RID: 160997 RVA: 0x00568871 File Offset: 0x00566A71
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060274E6 RID: 160998 RVA: 0x00568878 File Offset: 0x00566A78
		public static ITeleportComponent GetRootAsITeleportComponent(ByteBuffer _bb)
		{
			return ITeleportComponent.GetRootAsITeleportComponent(_bb, default(ITeleportComponent));
		}

		// Token: 0x060274E7 RID: 160999 RVA: 0x00568894 File Offset: 0x00566A94
		public static ITeleportComponent GetRootAsITeleportComponent(ByteBuffer _bb, ITeleportComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060274E8 RID: 161000 RVA: 0x005688B1 File Offset: 0x00566AB1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060274E9 RID: 161001 RVA: 0x005688C0 File Offset: 0x00566AC0
		public ITeleportComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ADDF RID: 44511
		// (get) Token: 0x060274EA RID: 161002 RVA: 0x005688D0 File Offset: 0x00566AD0
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700ADE0 RID: 44512
		// (get) Token: 0x060274EB RID: 161003 RVA: 0x00568910 File Offset: 0x00566B10
		public int TeleporterId
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

		// Token: 0x1700ADE1 RID: 44513
		// (get) Token: 0x060274EC RID: 161004 RVA: 0x0056894C File Offset: 0x00566B4C
		public IPosA? TeleportPos
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IPosA?(default(IPosA).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700ADE2 RID: 44514
		// (get) Token: 0x060274ED RID: 161005 RVA: 0x005689AC File Offset: 0x00566BAC
		public IGravityFlipTeleportConfig? GravityConfig
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IGravityFlipTeleportConfig?(default(IGravityFlipTeleportConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700ADE3 RID: 44515
		// (get) Token: 0x060274EE RID: 161006 RVA: 0x00568A0C File Offset: 0x00566C0C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060274EF RID: 161007 RVA: 0x00568A49 File Offset: 0x00566C49
		public static Offset<ITeleportComponent> CreateITeleportComponent(FlatBufferBuilder builder, bool Disabled = false, int TeleporterId = 0, Offset<IPosA> TeleportPosOffset = default(Offset<IPosA>), Offset<IGravityFlipTeleportConfig> GravityConfigOffset = default(Offset<IGravityFlipTeleportConfig>), byte NullMask = 0)
		{
			builder.StartTable(5);
			ITeleportComponent.AddGravityConfig(builder, GravityConfigOffset);
			ITeleportComponent.AddTeleportPos(builder, TeleportPosOffset);
			ITeleportComponent.AddTeleporterId(builder, TeleporterId);
			ITeleportComponent.AddNullMask(builder, NullMask);
			ITeleportComponent.AddDisabled(builder, Disabled);
			return ITeleportComponent.EndITeleportComponent(builder);
		}

		// Token: 0x060274F0 RID: 161008 RVA: 0x00568A7D File Offset: 0x00566C7D
		public static void StartITeleportComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060274F1 RID: 161009 RVA: 0x00568A86 File Offset: 0x00566C86
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060274F2 RID: 161010 RVA: 0x00568A91 File Offset: 0x00566C91
		public static void AddTeleporterId(FlatBufferBuilder builder, int teleporterId)
		{
			builder.AddInt(1, teleporterId, 0);
		}

		// Token: 0x060274F3 RID: 161011 RVA: 0x00568A9C File Offset: 0x00566C9C
		public static void AddTeleportPos(FlatBufferBuilder builder, Offset<IPosA> teleportPosOffset)
		{
			builder.AddOffset(2, teleportPosOffset.Value, 0);
		}

		// Token: 0x060274F4 RID: 161012 RVA: 0x00568AAC File Offset: 0x00566CAC
		public static void AddGravityConfig(FlatBufferBuilder builder, Offset<IGravityFlipTeleportConfig> gravityConfigOffset)
		{
			builder.AddOffset(3, gravityConfigOffset.Value, 0);
		}

		// Token: 0x060274F5 RID: 161013 RVA: 0x00568ABC File Offset: 0x00566CBC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x060274F6 RID: 161014 RVA: 0x00568AC7 File Offset: 0x00566CC7
		public static Offset<ITeleportComponent> EndITeleportComponent(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportComponent>(builder.EndTable());
		}

		// Token: 0x060274F7 RID: 161015 RVA: 0x00568AD4 File Offset: 0x00566CD4
		public ITeleportComponentT UnPack()
		{
			ITeleportComponentT teleportComponentT = new ITeleportComponentT();
			this.UnPackTo(teleportComponentT);
			return teleportComponentT;
		}

		// Token: 0x060274F8 RID: 161016 RVA: 0x00568AF0 File Offset: 0x00566CF0
		public void UnPackTo(ITeleportComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.TeleporterId = this.TeleporterId;
			_o.TeleportPos = ((this.TeleportPos != null) ? this.TeleportPos.Value.UnPack() : null);
			_o.GravityConfig = ((this.GravityConfig != null) ? this.GravityConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060274F9 RID: 161017 RVA: 0x00568B80 File Offset: 0x00566D80
		public static Offset<ITeleportComponent> Pack(FlatBufferBuilder builder, ITeleportComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleportComponent>);
			}
			Offset<IPosA> teleportPosOffset = (_o.TeleportPos == null) ? default(Offset<IPosA>) : IPosA.Pack(builder, _o.TeleportPos);
			Offset<IGravityFlipTeleportConfig> gravityConfigOffset = (_o.GravityConfig == null) ? default(Offset<IGravityFlipTeleportConfig>) : IGravityFlipTeleportConfig.Pack(builder, _o.GravityConfig);
			return ITeleportComponent.CreateITeleportComponent(builder, _o.Disabled, _o.TeleporterId, teleportPosOffset, gravityConfigOffset, _o.NullMask);
		}

		// Token: 0x0400F0CF RID: 61647
		private Table __p;
	}
}
