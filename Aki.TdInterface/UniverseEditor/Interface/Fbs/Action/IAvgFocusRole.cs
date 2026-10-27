using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061BE RID: 25022
	public struct IAvgFocusRole : IFlatbufferObject
	{
		// Token: 0x1700BA89 RID: 47753
		// (get) Token: 0x0602B1D0 RID: 176592 RVA: 0x005F1AD5 File Offset: 0x005EFCD5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B1D1 RID: 176593 RVA: 0x005F1AE2 File Offset: 0x005EFCE2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B1D2 RID: 176594 RVA: 0x005F1AEC File Offset: 0x005EFCEC
		public static IAvgFocusRole GetRootAsIAvgFocusRole(ByteBuffer _bb)
		{
			return IAvgFocusRole.GetRootAsIAvgFocusRole(_bb, default(IAvgFocusRole));
		}

		// Token: 0x0602B1D3 RID: 176595 RVA: 0x005F1B08 File Offset: 0x005EFD08
		public static IAvgFocusRole GetRootAsIAvgFocusRole(ByteBuffer _bb, IAvgFocusRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B1D4 RID: 176596 RVA: 0x005F1B25 File Offset: 0x005EFD25
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B1D5 RID: 176597 RVA: 0x005F1B34 File Offset: 0x005EFD34
		public IAvgFocusRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BA8A RID: 47754
		// (get) Token: 0x0602B1D6 RID: 176598 RVA: 0x005F1B44 File Offset: 0x005EFD44
		public bool IsFocus
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602B1D7 RID: 176599 RVA: 0x005F1B83 File Offset: 0x005EFD83
		public static Offset<IAvgFocusRole> CreateIAvgFocusRole(FlatBufferBuilder builder, bool IsFocus = false)
		{
			builder.StartTable(1);
			IAvgFocusRole.AddIsFocus(builder, IsFocus);
			return IAvgFocusRole.EndIAvgFocusRole(builder);
		}

		// Token: 0x0602B1D8 RID: 176600 RVA: 0x005F1B99 File Offset: 0x005EFD99
		public static void StartIAvgFocusRole(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602B1D9 RID: 176601 RVA: 0x005F1BA2 File Offset: 0x005EFDA2
		public static void AddIsFocus(FlatBufferBuilder builder, bool isFocus)
		{
			builder.AddBool(0, isFocus, false);
		}

		// Token: 0x0602B1DA RID: 176602 RVA: 0x005F1BAD File Offset: 0x005EFDAD
		public static Offset<IAvgFocusRole> EndIAvgFocusRole(FlatBufferBuilder builder)
		{
			return new Offset<IAvgFocusRole>(builder.EndTable());
		}

		// Token: 0x0602B1DB RID: 176603 RVA: 0x005F1BBC File Offset: 0x005EFDBC
		public IAvgFocusRoleT UnPack()
		{
			IAvgFocusRoleT avgFocusRoleT = new IAvgFocusRoleT();
			this.UnPackTo(avgFocusRoleT);
			return avgFocusRoleT;
		}

		// Token: 0x0602B1DC RID: 176604 RVA: 0x005F1BD7 File Offset: 0x005EFDD7
		public void UnPackTo(IAvgFocusRoleT _o)
		{
			_o.IsFocus = this.IsFocus;
		}

		// Token: 0x0602B1DD RID: 176605 RVA: 0x005F1BE8 File Offset: 0x005EFDE8
		public static Offset<IAvgFocusRole> Pack(FlatBufferBuilder builder, IAvgFocusRoleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAvgFocusRole>);
			}
			return IAvgFocusRole.CreateIAvgFocusRole(builder, _o.IsFocus);
		}

		// Token: 0x040106DE RID: 67294
		private Table __p;
	}
}
