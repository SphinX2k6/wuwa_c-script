using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F95 RID: 16277
	public struct IPhotographTargetRolesOnScene : IFlatbufferObject
	{
		// Token: 0x170071A3 RID: 29091
		// (get) Token: 0x06017400 RID: 95232 RVA: 0x0035A7EB File Offset: 0x003589EB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017401 RID: 95233 RVA: 0x0035A7F8 File Offset: 0x003589F8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017402 RID: 95234 RVA: 0x0035A800 File Offset: 0x00358A00
		public static IPhotographTargetRolesOnScene GetRootAsIPhotographTargetRolesOnScene(ByteBuffer _bb)
		{
			return IPhotographTargetRolesOnScene.GetRootAsIPhotographTargetRolesOnScene(_bb, default(IPhotographTargetRolesOnScene));
		}

		// Token: 0x06017403 RID: 95235 RVA: 0x0035A81C File Offset: 0x00358A1C
		public static IPhotographTargetRolesOnScene GetRootAsIPhotographTargetRolesOnScene(ByteBuffer _bb, IPhotographTargetRolesOnScene obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017404 RID: 95236 RVA: 0x0035A839 File Offset: 0x00358A39
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017405 RID: 95237 RVA: 0x0035A848 File Offset: 0x00358A48
		public IPhotographTargetRolesOnScene __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170071A4 RID: 29092
		// (get) Token: 0x06017406 RID: 95238 RVA: 0x0035A858 File Offset: 0x00358A58
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

		// Token: 0x06017407 RID: 95239 RVA: 0x0035A894 File Offset: 0x00358A94
		public static Offset<IPhotographTargetRolesOnScene> CreateIPhotographTargetRolesOnScene(FlatBufferBuilder builder, EPhotographTargetType Type = EPhotographTargetType.Player)
		{
			builder.StartTable(1);
			IPhotographTargetRolesOnScene.AddType(builder, Type);
			return IPhotographTargetRolesOnScene.EndIPhotographTargetRolesOnScene(builder);
		}

		// Token: 0x06017408 RID: 95240 RVA: 0x0035A8AA File Offset: 0x00358AAA
		public static void StartIPhotographTargetRolesOnScene(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06017409 RID: 95241 RVA: 0x0035A8B3 File Offset: 0x00358AB3
		public static void AddType(FlatBufferBuilder builder, EPhotographTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601740A RID: 95242 RVA: 0x0035A8BE File Offset: 0x00358ABE
		public static Offset<IPhotographTargetRolesOnScene> EndIPhotographTargetRolesOnScene(FlatBufferBuilder builder)
		{
			return new Offset<IPhotographTargetRolesOnScene>(builder.EndTable());
		}

		// Token: 0x0601740B RID: 95243 RVA: 0x0035A8CC File Offset: 0x00358ACC
		public IPhotographTargetRolesOnSceneT UnPack()
		{
			IPhotographTargetRolesOnSceneT photographTargetRolesOnSceneT = new IPhotographTargetRolesOnSceneT();
			this.UnPackTo(photographTargetRolesOnSceneT);
			return photographTargetRolesOnSceneT;
		}

		// Token: 0x0601740C RID: 95244 RVA: 0x0035A8E7 File Offset: 0x00358AE7
		public void UnPackTo(IPhotographTargetRolesOnSceneT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601740D RID: 95245 RVA: 0x0035A8F8 File Offset: 0x00358AF8
		public static Offset<IPhotographTargetRolesOnScene> Pack(FlatBufferBuilder builder, IPhotographTargetRolesOnSceneT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPhotographTargetRolesOnScene>);
			}
			return IPhotographTargetRolesOnScene.CreateIPhotographTargetRolesOnScene(builder, _o.Type);
		}

		// Token: 0x0400B9F5 RID: 47605
		private Table __p;
	}
}
