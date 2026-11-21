using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200682C RID: 26668
	public struct IAvgFocusRole : IFlatbufferObject
	{
		// Token: 0x1700C40C RID: 50188
		// (get) Token: 0x0602D917 RID: 186647 RVA: 0x0063C549 File Offset: 0x0063A749
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D918 RID: 186648 RVA: 0x0063C556 File Offset: 0x0063A756
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D919 RID: 186649 RVA: 0x0063C560 File Offset: 0x0063A760
		public static IAvgFocusRole GetRootAsIAvgFocusRole(ByteBuffer _bb)
		{
			return IAvgFocusRole.GetRootAsIAvgFocusRole(_bb, default(IAvgFocusRole));
		}

		// Token: 0x0602D91A RID: 186650 RVA: 0x0063C57C File Offset: 0x0063A77C
		public static IAvgFocusRole GetRootAsIAvgFocusRole(ByteBuffer _bb, IAvgFocusRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D91B RID: 186651 RVA: 0x0063C599 File Offset: 0x0063A799
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D91C RID: 186652 RVA: 0x0063C5A8 File Offset: 0x0063A7A8
		public IAvgFocusRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C40D RID: 50189
		// (get) Token: 0x0602D91D RID: 186653 RVA: 0x0063C5B8 File Offset: 0x0063A7B8
		public bool IsFocus
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602D91E RID: 186654 RVA: 0x0063C5F7 File Offset: 0x0063A7F7
		public static Offset<IAvgFocusRole> CreateIAvgFocusRole(FlatBufferBuilder builder, bool IsFocus = false)
		{
			builder.StartTable(1);
			IAvgFocusRole.AddIsFocus(builder, IsFocus);
			return IAvgFocusRole.EndIAvgFocusRole(builder);
		}

		// Token: 0x0602D91F RID: 186655 RVA: 0x0063C60D File Offset: 0x0063A80D
		public static void StartIAvgFocusRole(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602D920 RID: 186656 RVA: 0x0063C616 File Offset: 0x0063A816
		public static void AddIsFocus(FlatBufferBuilder builder, bool isFocus)
		{
			builder.AddBool(0, isFocus, false);
		}

		// Token: 0x0602D921 RID: 186657 RVA: 0x0063C621 File Offset: 0x0063A821
		public static Offset<IAvgFocusRole> EndIAvgFocusRole(FlatBufferBuilder builder)
		{
			return new Offset<IAvgFocusRole>(builder.EndTable());
		}

		// Token: 0x0602D922 RID: 186658 RVA: 0x0063C630 File Offset: 0x0063A830
		public IAvgFocusRoleT UnPack()
		{
			IAvgFocusRoleT avgFocusRoleT = new IAvgFocusRoleT();
			this.UnPackTo(avgFocusRoleT);
			return avgFocusRoleT;
		}

		// Token: 0x0602D923 RID: 186659 RVA: 0x0063C64B File Offset: 0x0063A84B
		public void UnPackTo(IAvgFocusRoleT _o)
		{
			_o.IsFocus = this.IsFocus;
		}

		// Token: 0x0602D924 RID: 186660 RVA: 0x0063C65C File Offset: 0x0063A85C
		public static Offset<IAvgFocusRole> Pack(FlatBufferBuilder builder, IAvgFocusRoleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAvgFocusRole>);
			}
			return IAvgFocusRole.CreateIAvgFocusRole(builder, _o.IsFocus);
		}

		// Token: 0x040114F0 RID: 70896
		private Table __p;
	}
}
