using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043D6 RID: 17366
	public struct IPhotographTargetRolesOnScene : IFlatbufferObject
	{
		// Token: 0x170077A1 RID: 30625
		// (get) Token: 0x06018A8F RID: 101007 RVA: 0x00384403 File Offset: 0x00382603
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018A90 RID: 101008 RVA: 0x00384410 File Offset: 0x00382610
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018A91 RID: 101009 RVA: 0x00384418 File Offset: 0x00382618
		public static IPhotographTargetRolesOnScene GetRootAsIPhotographTargetRolesOnScene(ByteBuffer _bb)
		{
			return IPhotographTargetRolesOnScene.GetRootAsIPhotographTargetRolesOnScene(_bb, default(IPhotographTargetRolesOnScene));
		}

		// Token: 0x06018A92 RID: 101010 RVA: 0x00384434 File Offset: 0x00382634
		public static IPhotographTargetRolesOnScene GetRootAsIPhotographTargetRolesOnScene(ByteBuffer _bb, IPhotographTargetRolesOnScene obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018A93 RID: 101011 RVA: 0x00384451 File Offset: 0x00382651
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018A94 RID: 101012 RVA: 0x00384460 File Offset: 0x00382660
		public IPhotographTargetRolesOnScene __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170077A2 RID: 30626
		// (get) Token: 0x06018A95 RID: 101013 RVA: 0x00384470 File Offset: 0x00382670
		public EPhotographTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPhotographTargetType.Player;
				}
				return (EPhotographTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018A96 RID: 101014 RVA: 0x003844AC File Offset: 0x003826AC
		public static Offset<IPhotographTargetRolesOnScene> CreateIPhotographTargetRolesOnScene(FlatBufferBuilder builder, EPhotographTargetType Type = EPhotographTargetType.Player)
		{
			builder.StartTable(1);
			IPhotographTargetRolesOnScene.AddType(builder, Type);
			return IPhotographTargetRolesOnScene.EndIPhotographTargetRolesOnScene(builder);
		}

		// Token: 0x06018A97 RID: 101015 RVA: 0x003844C2 File Offset: 0x003826C2
		public static void StartIPhotographTargetRolesOnScene(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06018A98 RID: 101016 RVA: 0x003844CB File Offset: 0x003826CB
		public static void AddType(FlatBufferBuilder builder, EPhotographTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018A99 RID: 101017 RVA: 0x003844D6 File Offset: 0x003826D6
		public static Offset<IPhotographTargetRolesOnScene> EndIPhotographTargetRolesOnScene(FlatBufferBuilder builder)
		{
			return new Offset<IPhotographTargetRolesOnScene>(builder.EndTable());
		}

		// Token: 0x06018A9A RID: 101018 RVA: 0x003844E4 File Offset: 0x003826E4
		public IPhotographTargetRolesOnSceneT UnPack()
		{
			IPhotographTargetRolesOnSceneT photographTargetRolesOnSceneT = new IPhotographTargetRolesOnSceneT();
			this.UnPackTo(photographTargetRolesOnSceneT);
			return photographTargetRolesOnSceneT;
		}

		// Token: 0x06018A9B RID: 101019 RVA: 0x003844FF File Offset: 0x003826FF
		public void UnPackTo(IPhotographTargetRolesOnSceneT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06018A9C RID: 101020 RVA: 0x00384510 File Offset: 0x00382710
		public static Offset<IPhotographTargetRolesOnScene> Pack(FlatBufferBuilder builder, IPhotographTargetRolesOnSceneT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPhotographTargetRolesOnScene>);
			}
			return IPhotographTargetRolesOnScene.CreateIPhotographTargetRolesOnScene(builder, _o.Type);
		}

		// Token: 0x0400C3DA RID: 50138
		private Table __p;
	}
}
