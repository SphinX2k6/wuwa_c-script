using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076BA RID: 30394
	public struct ISceneInteractionOperationType : IFlatbufferObject
	{
		// Token: 0x1700DEF3 RID: 57075
		// (get) Token: 0x06035517 RID: 218391 RVA: 0x007271CF File Offset: 0x007253CF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035518 RID: 218392 RVA: 0x007271DC File Offset: 0x007253DC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035519 RID: 218393 RVA: 0x007271E4 File Offset: 0x007253E4
		public static ISceneInteractionOperationType GetRootAsISceneInteractionOperationType(ByteBuffer _bb)
		{
			return ISceneInteractionOperationType.GetRootAsISceneInteractionOperationType(_bb, default(ISceneInteractionOperationType));
		}

		// Token: 0x0603551A RID: 218394 RVA: 0x00727200 File Offset: 0x00725400
		public static ISceneInteractionOperationType GetRootAsISceneInteractionOperationType(ByteBuffer _bb, ISceneInteractionOperationType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603551B RID: 218395 RVA: 0x0072721D File Offset: 0x0072541D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603551C RID: 218396 RVA: 0x0072722C File Offset: 0x0072542C
		public ISceneInteractionOperationType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DEF4 RID: 57076
		// (get) Token: 0x0603551D RID: 218397 RVA: 0x0072723C File Offset: 0x0072543C
		public ESceneInteractionOperationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESceneInteractionOperationType.Enable;
				}
				return (ESceneInteractionOperationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603551E RID: 218398 RVA: 0x00727278 File Offset: 0x00725478
		public static Offset<ISceneInteractionOperationType> CreateISceneInteractionOperationType(FlatBufferBuilder builder, ESceneInteractionOperationType Type = ESceneInteractionOperationType.Enable)
		{
			builder.StartTable(1);
			ISceneInteractionOperationType.AddType(builder, Type);
			return ISceneInteractionOperationType.EndISceneInteractionOperationType(builder);
		}

		// Token: 0x0603551F RID: 218399 RVA: 0x0072728E File Offset: 0x0072548E
		public static void StartISceneInteractionOperationType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06035520 RID: 218400 RVA: 0x00727297 File Offset: 0x00725497
		public static void AddType(FlatBufferBuilder builder, ESceneInteractionOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035521 RID: 218401 RVA: 0x007272A2 File Offset: 0x007254A2
		public static Offset<ISceneInteractionOperationType> EndISceneInteractionOperationType(FlatBufferBuilder builder)
		{
			return new Offset<ISceneInteractionOperationType>(builder.EndTable());
		}

		// Token: 0x06035522 RID: 218402 RVA: 0x007272B0 File Offset: 0x007254B0
		public ISceneInteractionOperationTypeT UnPack()
		{
			ISceneInteractionOperationTypeT sceneInteractionOperationTypeT = new ISceneInteractionOperationTypeT();
			this.UnPackTo(sceneInteractionOperationTypeT);
			return sceneInteractionOperationTypeT;
		}

		// Token: 0x06035523 RID: 218403 RVA: 0x007272CB File Offset: 0x007254CB
		public void UnPackTo(ISceneInteractionOperationTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06035524 RID: 218404 RVA: 0x007272DC File Offset: 0x007254DC
		public static Offset<ISceneInteractionOperationType> Pack(FlatBufferBuilder builder, ISceneInteractionOperationTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneInteractionOperationType>);
			}
			return ISceneInteractionOperationType.CreateISceneInteractionOperationType(builder, _o.Type);
		}

		// Token: 0x040128AA RID: 75946
		private Table __p;
	}
}
