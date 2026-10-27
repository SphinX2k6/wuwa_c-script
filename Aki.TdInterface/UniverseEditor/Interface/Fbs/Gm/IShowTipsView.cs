using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x0200469C RID: 18076
	public struct IShowTipsView : IFlatbufferObject
	{
		// Token: 0x1700805B RID: 32859
		// (get) Token: 0x0601B73F RID: 112447 RVA: 0x003E61DA File Offset: 0x003E43DA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B740 RID: 112448 RVA: 0x003E61E7 File Offset: 0x003E43E7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B741 RID: 112449 RVA: 0x003E61F0 File Offset: 0x003E43F0
		public static IShowTipsView GetRootAsIShowTipsView(ByteBuffer _bb)
		{
			return IShowTipsView.GetRootAsIShowTipsView(_bb, default(IShowTipsView));
		}

		// Token: 0x0601B742 RID: 112450 RVA: 0x003E620C File Offset: 0x003E440C
		public static IShowTipsView GetRootAsIShowTipsView(ByteBuffer _bb, IShowTipsView obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B743 RID: 112451 RVA: 0x003E6229 File Offset: 0x003E4429
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B744 RID: 112452 RVA: 0x003E6238 File Offset: 0x003E4438
		public IShowTipsView __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700805C RID: 32860
		// (get) Token: 0x0601B745 RID: 112453 RVA: 0x003E6248 File Offset: 0x003E4448
		public EGmCommand Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGmCommand.SkipToLevelPlayNode;
				}
				return (EGmCommand)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700805D RID: 32861
		// (get) Token: 0x0601B746 RID: 112454 RVA: 0x003E6284 File Offset: 0x003E4484
		public bool IsShield
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601B747 RID: 112455 RVA: 0x003E62C3 File Offset: 0x003E44C3
		public static Offset<IShowTipsView> CreateIShowTipsView(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, bool IsShield = false)
		{
			builder.StartTable(2);
			IShowTipsView.AddIsShield(builder, IsShield);
			IShowTipsView.AddType(builder, Type);
			return IShowTipsView.EndIShowTipsView(builder);
		}

		// Token: 0x0601B748 RID: 112456 RVA: 0x003E62E0 File Offset: 0x003E44E0
		public static void StartIShowTipsView(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601B749 RID: 112457 RVA: 0x003E62E9 File Offset: 0x003E44E9
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B74A RID: 112458 RVA: 0x003E62F4 File Offset: 0x003E44F4
		public static void AddIsShield(FlatBufferBuilder builder, bool isShield)
		{
			builder.AddBool(1, isShield, false);
		}

		// Token: 0x0601B74B RID: 112459 RVA: 0x003E62FF File Offset: 0x003E44FF
		public static Offset<IShowTipsView> EndIShowTipsView(FlatBufferBuilder builder)
		{
			return new Offset<IShowTipsView>(builder.EndTable());
		}

		// Token: 0x0601B74C RID: 112460 RVA: 0x003E630C File Offset: 0x003E450C
		public IShowTipsViewT UnPack()
		{
			IShowTipsViewT showTipsViewT = new IShowTipsViewT();
			this.UnPackTo(showTipsViewT);
			return showTipsViewT;
		}

		// Token: 0x0601B74D RID: 112461 RVA: 0x003E6327 File Offset: 0x003E4527
		public void UnPackTo(IShowTipsViewT _o)
		{
			_o.Type = this.Type;
			_o.IsShield = this.IsShield;
		}

		// Token: 0x0601B74E RID: 112462 RVA: 0x003E6344 File Offset: 0x003E4544
		public static Offset<IShowTipsView> Pack(FlatBufferBuilder builder, IShowTipsViewT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowTipsView>);
			}
			return IShowTipsView.CreateIShowTipsView(builder, _o.Type, _o.IsShield);
		}

		// Token: 0x0400C861 RID: 51297
		private Table __p;
	}
}
