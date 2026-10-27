using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075E0 RID: 30176
	public struct IVisualNovelTransitionConfigBase : IFlatbufferObject
	{
		// Token: 0x1700E541 RID: 58689
		// (get) Token: 0x06036F7E RID: 225150 RVA: 0x00775A20 File Offset: 0x00773C20
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036F7F RID: 225151 RVA: 0x00775A2D File Offset: 0x00773C2D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036F80 RID: 225152 RVA: 0x00775A34 File Offset: 0x00773C34
		public static IVisualNovelTransitionConfigBase GetRootAsIVisualNovelTransitionConfigBase(ByteBuffer _bb)
		{
			return IVisualNovelTransitionConfigBase.GetRootAsIVisualNovelTransitionConfigBase(_bb, default(IVisualNovelTransitionConfigBase));
		}

		// Token: 0x06036F81 RID: 225153 RVA: 0x00775A50 File Offset: 0x00773C50
		public static IVisualNovelTransitionConfigBase GetRootAsIVisualNovelTransitionConfigBase(ByteBuffer _bb, IVisualNovelTransitionConfigBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036F82 RID: 225154 RVA: 0x00775A6D File Offset: 0x00773C6D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036F83 RID: 225155 RVA: 0x00775A7C File Offset: 0x00773C7C
		public IVisualNovelTransitionConfigBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E542 RID: 58690
		// (get) Token: 0x06036F84 RID: 225156 RVA: 0x00775A8C File Offset: 0x00773C8C
		public EVisualNovelTransitionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVisualNovelTransitionType.Location;
				}
				return (EVisualNovelTransitionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036F85 RID: 225157 RVA: 0x00775AC8 File Offset: 0x00773CC8
		public static Offset<IVisualNovelTransitionConfigBase> CreateIVisualNovelTransitionConfigBase(FlatBufferBuilder builder, EVisualNovelTransitionType Type = EVisualNovelTransitionType.Location)
		{
			builder.StartTable(1);
			IVisualNovelTransitionConfigBase.AddType(builder, Type);
			return IVisualNovelTransitionConfigBase.EndIVisualNovelTransitionConfigBase(builder);
		}

		// Token: 0x06036F86 RID: 225158 RVA: 0x00775ADE File Offset: 0x00773CDE
		public static void StartIVisualNovelTransitionConfigBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06036F87 RID: 225159 RVA: 0x00775AE7 File Offset: 0x00773CE7
		public static void AddType(FlatBufferBuilder builder, EVisualNovelTransitionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036F88 RID: 225160 RVA: 0x00775AF2 File Offset: 0x00773CF2
		public static Offset<IVisualNovelTransitionConfigBase> EndIVisualNovelTransitionConfigBase(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelTransitionConfigBase>(builder.EndTable());
		}

		// Token: 0x06036F89 RID: 225161 RVA: 0x00775B00 File Offset: 0x00773D00
		public IVisualNovelTransitionConfigBaseT UnPack()
		{
			IVisualNovelTransitionConfigBaseT visualNovelTransitionConfigBaseT = new IVisualNovelTransitionConfigBaseT();
			this.UnPackTo(visualNovelTransitionConfigBaseT);
			return visualNovelTransitionConfigBaseT;
		}

		// Token: 0x06036F8A RID: 225162 RVA: 0x00775B1B File Offset: 0x00773D1B
		public void UnPackTo(IVisualNovelTransitionConfigBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06036F8B RID: 225163 RVA: 0x00775B2C File Offset: 0x00773D2C
		public static Offset<IVisualNovelTransitionConfigBase> Pack(FlatBufferBuilder builder, IVisualNovelTransitionConfigBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelTransitionConfigBase>);
			}
			return IVisualNovelTransitionConfigBase.CreateIVisualNovelTransitionConfigBase(builder, _o.Type);
		}

		// Token: 0x04012547 RID: 75079
		private Table __p;
	}
}
