using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200714E RID: 29006
	public struct ISlideRailFollowConfig : IFlatbufferObject
	{
		// Token: 0x1700D77D RID: 55165
		// (get) Token: 0x060336B2 RID: 210610 RVA: 0x006EDBB8 File Offset: 0x006EBDB8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060336B3 RID: 210611 RVA: 0x006EDBC5 File Offset: 0x006EBDC5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060336B4 RID: 210612 RVA: 0x006EDBCC File Offset: 0x006EBDCC
		public static ISlideRailFollowConfig GetRootAsISlideRailFollowConfig(ByteBuffer _bb)
		{
			return ISlideRailFollowConfig.GetRootAsISlideRailFollowConfig(_bb, default(ISlideRailFollowConfig));
		}

		// Token: 0x060336B5 RID: 210613 RVA: 0x006EDBE8 File Offset: 0x006EBDE8
		public static ISlideRailFollowConfig GetRootAsISlideRailFollowConfig(ByteBuffer _bb, ISlideRailFollowConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060336B6 RID: 210614 RVA: 0x006EDC05 File Offset: 0x006EBE05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060336B7 RID: 210615 RVA: 0x006EDC14 File Offset: 0x006EBE14
		public ISlideRailFollowConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D77E RID: 55166
		// (get) Token: 0x060336B8 RID: 210616 RVA: 0x006EDC24 File Offset: 0x006EBE24
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

		// Token: 0x1700D77F RID: 55167
		// (get) Token: 0x060336B9 RID: 210617 RVA: 0x006EDC60 File Offset: 0x006EBE60
		public string FollowDaPath
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060336BA RID: 210618 RVA: 0x006EDC97 File Offset: 0x006EBE97
		public Span<byte> GetFollowDaPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060336BB RID: 210619 RVA: 0x006EDCA6 File Offset: 0x006EBEA6
		public byte[] GetFollowDaPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060336BC RID: 210620 RVA: 0x006EDCB4 File Offset: 0x006EBEB4
		public static Offset<ISlideRailFollowConfig> CreateISlideRailFollowConfig(FlatBufferBuilder builder, int EntityId = 0, StringOffset FollowDaPathOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ISlideRailFollowConfig.AddFollowDaPath(builder, FollowDaPathOffset);
			ISlideRailFollowConfig.AddEntityId(builder, EntityId);
			return ISlideRailFollowConfig.EndISlideRailFollowConfig(builder);
		}

		// Token: 0x060336BD RID: 210621 RVA: 0x006EDCD1 File Offset: 0x006EBED1
		public static void StartISlideRailFollowConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060336BE RID: 210622 RVA: 0x006EDCDA File Offset: 0x006EBEDA
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x060336BF RID: 210623 RVA: 0x006EDCE5 File Offset: 0x006EBEE5
		public static void AddFollowDaPath(FlatBufferBuilder builder, StringOffset followDaPathOffset)
		{
			builder.AddOffset(1, followDaPathOffset.Value, 0);
		}

		// Token: 0x060336C0 RID: 210624 RVA: 0x006EDCF5 File Offset: 0x006EBEF5
		public static Offset<ISlideRailFollowConfig> EndISlideRailFollowConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISlideRailFollowConfig>(builder.EndTable());
		}

		// Token: 0x060336C1 RID: 210625 RVA: 0x006EDD04 File Offset: 0x006EBF04
		public ISlideRailFollowConfigT UnPack()
		{
			ISlideRailFollowConfigT slideRailFollowConfigT = new ISlideRailFollowConfigT();
			this.UnPackTo(slideRailFollowConfigT);
			return slideRailFollowConfigT;
		}

		// Token: 0x060336C2 RID: 210626 RVA: 0x006EDD1F File Offset: 0x006EBF1F
		public void UnPackTo(ISlideRailFollowConfigT _o)
		{
			_o.EntityId = this.EntityId;
			_o.FollowDaPath = this.FollowDaPath;
		}

		// Token: 0x060336C3 RID: 210627 RVA: 0x006EDD3C File Offset: 0x006EBF3C
		public static Offset<ISlideRailFollowConfig> Pack(FlatBufferBuilder builder, ISlideRailFollowConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISlideRailFollowConfig>);
			}
			StringOffset followDaPathOffset = (_o.FollowDaPath == null) ? default(StringOffset) : builder.CreateString(_o.FollowDaPath);
			return ISlideRailFollowConfig.CreateISlideRailFollowConfig(builder, _o.EntityId, followDaPathOffset);
		}

		// Token: 0x04011BEB RID: 72683
		private Table __p;
	}
}
