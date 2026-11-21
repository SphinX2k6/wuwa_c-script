using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EB6 RID: 24246
	public struct ISceneItemAiComponent : IFlatbufferObject
	{
		// Token: 0x1700B323 RID: 45859
		// (get) Token: 0x06028A10 RID: 166416 RVA: 0x0058E0EF File Offset: 0x0058C2EF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028A11 RID: 166417 RVA: 0x0058E0FC File Offset: 0x0058C2FC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028A12 RID: 166418 RVA: 0x0058E104 File Offset: 0x0058C304
		public static ISceneItemAiComponent GetRootAsISceneItemAiComponent(ByteBuffer _bb)
		{
			return ISceneItemAiComponent.GetRootAsISceneItemAiComponent(_bb, default(ISceneItemAiComponent));
		}

		// Token: 0x06028A13 RID: 166419 RVA: 0x0058E120 File Offset: 0x0058C320
		public static ISceneItemAiComponent GetRootAsISceneItemAiComponent(ByteBuffer _bb, ISceneItemAiComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028A14 RID: 166420 RVA: 0x0058E13D File Offset: 0x0058C33D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028A15 RID: 166421 RVA: 0x0058E14C File Offset: 0x0058C34C
		public ISceneItemAiComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B324 RID: 45860
		// (get) Token: 0x06028A16 RID: 166422 RVA: 0x0058E15C File Offset: 0x0058C35C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B325 RID: 45861
		// (get) Token: 0x06028A17 RID: 166423 RVA: 0x0058E19C File Offset: 0x0058C39C
		public ISceneItemPatrol? AiConfig
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ISceneItemPatrol?(default(ISceneItemPatrol).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B326 RID: 45862
		// (get) Token: 0x06028A18 RID: 166424 RVA: 0x0058E1FC File Offset: 0x0058C3FC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028A19 RID: 166425 RVA: 0x0058E238 File Offset: 0x0058C438
		public static Offset<ISceneItemAiComponent> CreateISceneItemAiComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<ISceneItemPatrol> AiConfigOffset = default(Offset<ISceneItemPatrol>), byte NullMask = 0)
		{
			builder.StartTable(3);
			ISceneItemAiComponent.AddAiConfig(builder, AiConfigOffset);
			ISceneItemAiComponent.AddNullMask(builder, NullMask);
			ISceneItemAiComponent.AddDisabled(builder, Disabled);
			return ISceneItemAiComponent.EndISceneItemAiComponent(builder);
		}

		// Token: 0x06028A1A RID: 166426 RVA: 0x0058E25C File Offset: 0x0058C45C
		public static void StartISceneItemAiComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06028A1B RID: 166427 RVA: 0x0058E265 File Offset: 0x0058C465
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06028A1C RID: 166428 RVA: 0x0058E270 File Offset: 0x0058C470
		public static void AddAiConfig(FlatBufferBuilder builder, Offset<ISceneItemPatrol> aiConfigOffset)
		{
			builder.AddOffset(1, aiConfigOffset.Value, 0);
		}

		// Token: 0x06028A1D RID: 166429 RVA: 0x0058E280 File Offset: 0x0058C480
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06028A1E RID: 166430 RVA: 0x0058E28B File Offset: 0x0058C48B
		public static Offset<ISceneItemAiComponent> EndISceneItemAiComponent(FlatBufferBuilder builder)
		{
			return new Offset<ISceneItemAiComponent>(builder.EndTable());
		}

		// Token: 0x06028A1F RID: 166431 RVA: 0x0058E298 File Offset: 0x0058C498
		public ISceneItemAiComponentT UnPack()
		{
			ISceneItemAiComponentT sceneItemAiComponentT = new ISceneItemAiComponentT();
			this.UnPackTo(sceneItemAiComponentT);
			return sceneItemAiComponentT;
		}

		// Token: 0x06028A20 RID: 166432 RVA: 0x0058E2B4 File Offset: 0x0058C4B4
		public void UnPackTo(ISceneItemAiComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.AiConfig = ((this.AiConfig != null) ? this.AiConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06028A21 RID: 166433 RVA: 0x0058E308 File Offset: 0x0058C508
		public static Offset<ISceneItemAiComponent> Pack(FlatBufferBuilder builder, ISceneItemAiComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneItemAiComponent>);
			}
			Offset<ISceneItemPatrol> aiConfigOffset = (_o.AiConfig == null) ? default(Offset<ISceneItemPatrol>) : ISceneItemPatrol.Pack(builder, _o.AiConfig);
			return ISceneItemAiComponent.CreateISceneItemAiComponent(builder, _o.Disabled, aiConfigOffset, _o.NullMask);
		}

		// Token: 0x0400FB07 RID: 64263
		private Table __p;
	}
}
