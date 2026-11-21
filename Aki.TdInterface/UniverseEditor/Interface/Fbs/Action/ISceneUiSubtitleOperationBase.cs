using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076DB RID: 30427
	public struct ISceneUiSubtitleOperationBase : IFlatbufferObject
	{
		// Token: 0x1700DF34 RID: 57140
		// (get) Token: 0x0603562D RID: 218669 RVA: 0x0072925B File Offset: 0x0072745B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603562E RID: 218670 RVA: 0x00729268 File Offset: 0x00727468
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603562F RID: 218671 RVA: 0x00729270 File Offset: 0x00727470
		public static ISceneUiSubtitleOperationBase GetRootAsISceneUiSubtitleOperationBase(ByteBuffer _bb)
		{
			return ISceneUiSubtitleOperationBase.GetRootAsISceneUiSubtitleOperationBase(_bb, default(ISceneUiSubtitleOperationBase));
		}

		// Token: 0x06035630 RID: 218672 RVA: 0x0072928C File Offset: 0x0072748C
		public static ISceneUiSubtitleOperationBase GetRootAsISceneUiSubtitleOperationBase(ByteBuffer _bb, ISceneUiSubtitleOperationBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035631 RID: 218673 RVA: 0x007292A9 File Offset: 0x007274A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035632 RID: 218674 RVA: 0x007292B8 File Offset: 0x007274B8
		public ISceneUiSubtitleOperationBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DF35 RID: 57141
		// (get) Token: 0x06035633 RID: 218675 RVA: 0x007292C8 File Offset: 0x007274C8
		public ESceneUiSubtitleOperationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESceneUiSubtitleOperationType.Spawn;
				}
				return (ESceneUiSubtitleOperationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035634 RID: 218676 RVA: 0x00729304 File Offset: 0x00727504
		public static Offset<ISceneUiSubtitleOperationBase> CreateISceneUiSubtitleOperationBase(FlatBufferBuilder builder, ESceneUiSubtitleOperationType Type = ESceneUiSubtitleOperationType.Spawn)
		{
			builder.StartTable(1);
			ISceneUiSubtitleOperationBase.AddType(builder, Type);
			return ISceneUiSubtitleOperationBase.EndISceneUiSubtitleOperationBase(builder);
		}

		// Token: 0x06035635 RID: 218677 RVA: 0x0072931A File Offset: 0x0072751A
		public static void StartISceneUiSubtitleOperationBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06035636 RID: 218678 RVA: 0x00729323 File Offset: 0x00727523
		public static void AddType(FlatBufferBuilder builder, ESceneUiSubtitleOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035637 RID: 218679 RVA: 0x0072932E File Offset: 0x0072752E
		public static Offset<ISceneUiSubtitleOperationBase> EndISceneUiSubtitleOperationBase(FlatBufferBuilder builder)
		{
			return new Offset<ISceneUiSubtitleOperationBase>(builder.EndTable());
		}

		// Token: 0x06035638 RID: 218680 RVA: 0x0072933C File Offset: 0x0072753C
		public ISceneUiSubtitleOperationBaseT UnPack()
		{
			ISceneUiSubtitleOperationBaseT sceneUiSubtitleOperationBaseT = new ISceneUiSubtitleOperationBaseT();
			this.UnPackTo(sceneUiSubtitleOperationBaseT);
			return sceneUiSubtitleOperationBaseT;
		}

		// Token: 0x06035639 RID: 218681 RVA: 0x00729357 File Offset: 0x00727557
		public void UnPackTo(ISceneUiSubtitleOperationBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603563A RID: 218682 RVA: 0x00729368 File Offset: 0x00727568
		public static Offset<ISceneUiSubtitleOperationBase> Pack(FlatBufferBuilder builder, ISceneUiSubtitleOperationBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneUiSubtitleOperationBase>);
			}
			return ISceneUiSubtitleOperationBase.CreateISceneUiSubtitleOperationBase(builder, _o.Type);
		}

		// Token: 0x040128DB RID: 75995
		private Table __p;
	}
}
