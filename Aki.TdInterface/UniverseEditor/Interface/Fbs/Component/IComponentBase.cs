using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FD9 RID: 20441
	public struct IComponentBase : IFlatbufferObject
	{
		// Token: 0x1700941C RID: 37916
		// (get) Token: 0x06020903 RID: 133379 RVA: 0x004874A9 File Offset: 0x004856A9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020904 RID: 133380 RVA: 0x004874B6 File Offset: 0x004856B6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020905 RID: 133381 RVA: 0x004874C0 File Offset: 0x004856C0
		public static IComponentBase GetRootAsIComponentBase(ByteBuffer _bb)
		{
			return IComponentBase.GetRootAsIComponentBase(_bb, default(IComponentBase));
		}

		// Token: 0x06020906 RID: 133382 RVA: 0x004874DC File Offset: 0x004856DC
		public static IComponentBase GetRootAsIComponentBase(ByteBuffer _bb, IComponentBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020907 RID: 133383 RVA: 0x004874F9 File Offset: 0x004856F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020908 RID: 133384 RVA: 0x00487508 File Offset: 0x00485708
		public IComponentBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700941D RID: 37917
		// (get) Token: 0x06020909 RID: 133385 RVA: 0x00487518 File Offset: 0x00485718
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700941E RID: 37918
		// (get) Token: 0x0602090A RID: 133386 RVA: 0x00487558 File Offset: 0x00485758
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602090B RID: 133387 RVA: 0x00487594 File Offset: 0x00485794
		public static Offset<IComponentBase> CreateIComponentBase(FlatBufferBuilder builder, bool Disabled = false, byte NullMask = 0)
		{
			builder.StartTable(2);
			IComponentBase.AddNullMask(builder, NullMask);
			IComponentBase.AddDisabled(builder, Disabled);
			return IComponentBase.EndIComponentBase(builder);
		}

		// Token: 0x0602090C RID: 133388 RVA: 0x004875B1 File Offset: 0x004857B1
		public static void StartIComponentBase(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602090D RID: 133389 RVA: 0x004875BA File Offset: 0x004857BA
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602090E RID: 133390 RVA: 0x004875C5 File Offset: 0x004857C5
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x0602090F RID: 133391 RVA: 0x004875D0 File Offset: 0x004857D0
		public static Offset<IComponentBase> EndIComponentBase(FlatBufferBuilder builder)
		{
			return new Offset<IComponentBase>(builder.EndTable());
		}

		// Token: 0x06020910 RID: 133392 RVA: 0x004875E0 File Offset: 0x004857E0
		public IComponentBaseT UnPack()
		{
			IComponentBaseT componentBaseT = new IComponentBaseT();
			this.UnPackTo(componentBaseT);
			return componentBaseT;
		}

		// Token: 0x06020911 RID: 133393 RVA: 0x004875FB File Offset: 0x004857FB
		public void UnPackTo(IComponentBaseT _o)
		{
			_o.Disabled = this.Disabled;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06020912 RID: 133394 RVA: 0x00487618 File Offset: 0x00485818
		public static Offset<IComponentBase> Pack(FlatBufferBuilder builder, IComponentBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IComponentBase>);
			}
			return IComponentBase.CreateIComponentBase(builder, _o.Disabled, _o.NullMask);
		}

		// Token: 0x0400DEC8 RID: 57032
		private Table __p;
	}
}
