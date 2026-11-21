using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200791A RID: 31002
	public struct ISlideRailFollowConfig : IFlatbufferObject
	{
		// Token: 0x1700E362 RID: 58210
		// (get) Token: 0x0603695C RID: 223580 RVA: 0x0074E3C4 File Offset: 0x0074C5C4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603695D RID: 223581 RVA: 0x0074E3D1 File Offset: 0x0074C5D1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603695E RID: 223582 RVA: 0x0074E3D8 File Offset: 0x0074C5D8
		public static ISlideRailFollowConfig GetRootAsISlideRailFollowConfig(ByteBuffer _bb)
		{
			return ISlideRailFollowConfig.GetRootAsISlideRailFollowConfig(_bb, default(ISlideRailFollowConfig));
		}

		// Token: 0x0603695F RID: 223583 RVA: 0x0074E3F4 File Offset: 0x0074C5F4
		public static ISlideRailFollowConfig GetRootAsISlideRailFollowConfig(ByteBuffer _bb, ISlideRailFollowConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036960 RID: 223584 RVA: 0x0074E411 File Offset: 0x0074C611
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036961 RID: 223585 RVA: 0x0074E420 File Offset: 0x0074C620
		public ISlideRailFollowConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E363 RID: 58211
		// (get) Token: 0x06036962 RID: 223586 RVA: 0x0074E430 File Offset: 0x0074C630
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

		// Token: 0x1700E364 RID: 58212
		// (get) Token: 0x06036963 RID: 223587 RVA: 0x0074E46C File Offset: 0x0074C66C
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

		// Token: 0x06036964 RID: 223588 RVA: 0x0074E4A3 File Offset: 0x0074C6A3
		public Span<byte> GetFollowDaPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06036965 RID: 223589 RVA: 0x0074E4B2 File Offset: 0x0074C6B2
		public byte[] GetFollowDaPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06036966 RID: 223590 RVA: 0x0074E4C0 File Offset: 0x0074C6C0
		public static Offset<ISlideRailFollowConfig> CreateISlideRailFollowConfig(FlatBufferBuilder builder, int EntityId = 0, StringOffset FollowDaPathOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ISlideRailFollowConfig.AddFollowDaPath(builder, FollowDaPathOffset);
			ISlideRailFollowConfig.AddEntityId(builder, EntityId);
			return ISlideRailFollowConfig.EndISlideRailFollowConfig(builder);
		}

		// Token: 0x06036967 RID: 223591 RVA: 0x0074E4DD File Offset: 0x0074C6DD
		public static void StartISlideRailFollowConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06036968 RID: 223592 RVA: 0x0074E4E6 File Offset: 0x0074C6E6
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x06036969 RID: 223593 RVA: 0x0074E4F1 File Offset: 0x0074C6F1
		public static void AddFollowDaPath(FlatBufferBuilder builder, StringOffset followDaPathOffset)
		{
			builder.AddOffset(1, followDaPathOffset.Value, 0);
		}

		// Token: 0x0603696A RID: 223594 RVA: 0x0074E501 File Offset: 0x0074C701
		public static Offset<ISlideRailFollowConfig> EndISlideRailFollowConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISlideRailFollowConfig>(builder.EndTable());
		}

		// Token: 0x0603696B RID: 223595 RVA: 0x0074E510 File Offset: 0x0074C710
		public ISlideRailFollowConfigT UnPack()
		{
			ISlideRailFollowConfigT slideRailFollowConfigT = new ISlideRailFollowConfigT();
			this.UnPackTo(slideRailFollowConfigT);
			return slideRailFollowConfigT;
		}

		// Token: 0x0603696C RID: 223596 RVA: 0x0074E52B File Offset: 0x0074C72B
		public void UnPackTo(ISlideRailFollowConfigT _o)
		{
			_o.EntityId = this.EntityId;
			_o.FollowDaPath = this.FollowDaPath;
		}

		// Token: 0x0603696D RID: 223597 RVA: 0x0074E548 File Offset: 0x0074C748
		public static Offset<ISlideRailFollowConfig> Pack(FlatBufferBuilder builder, ISlideRailFollowConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISlideRailFollowConfig>);
			}
			StringOffset followDaPathOffset = (_o.FollowDaPath == null) ? default(StringOffset) : builder.CreateString(_o.FollowDaPath);
			return ISlideRailFollowConfig.CreateISlideRailFollowConfig(builder, _o.EntityId, followDaPathOffset);
		}

		// Token: 0x04012BDA RID: 76762
		private Table __p;
	}
}
