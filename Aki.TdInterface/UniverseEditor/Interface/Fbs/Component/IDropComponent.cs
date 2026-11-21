using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005625 RID: 22053
	public struct IDropComponent : IFlatbufferObject
	{
		// Token: 0x17009E5C RID: 40540
		// (get) Token: 0x0602334D RID: 144205 RVA: 0x004D8810 File Offset: 0x004D6A10
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602334E RID: 144206 RVA: 0x004D881D File Offset: 0x004D6A1D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602334F RID: 144207 RVA: 0x004D8824 File Offset: 0x004D6A24
		public static IDropComponent GetRootAsIDropComponent(ByteBuffer _bb)
		{
			return IDropComponent.GetRootAsIDropComponent(_bb, default(IDropComponent));
		}

		// Token: 0x06023350 RID: 144208 RVA: 0x004D8840 File Offset: 0x004D6A40
		public static IDropComponent GetRootAsIDropComponent(ByteBuffer _bb, IDropComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023351 RID: 144209 RVA: 0x004D885D File Offset: 0x004D6A5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023352 RID: 144210 RVA: 0x004D886C File Offset: 0x004D6A6C
		public IDropComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009E5D RID: 40541
		// (get) Token: 0x06023353 RID: 144211 RVA: 0x004D887C File Offset: 0x004D6A7C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009E5E RID: 40542
		// (get) Token: 0x06023354 RID: 144212 RVA: 0x004D88BC File Offset: 0x004D6ABC
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

		// Token: 0x06023355 RID: 144213 RVA: 0x004D88F8 File Offset: 0x004D6AF8
		public static Offset<IDropComponent> CreateIDropComponent(FlatBufferBuilder builder, bool Disabled = false, byte NullMask = 0)
		{
			builder.StartTable(2);
			IDropComponent.AddNullMask(builder, NullMask);
			IDropComponent.AddDisabled(builder, Disabled);
			return IDropComponent.EndIDropComponent(builder);
		}

		// Token: 0x06023356 RID: 144214 RVA: 0x004D8915 File Offset: 0x004D6B15
		public static void StartIDropComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06023357 RID: 144215 RVA: 0x004D891E File Offset: 0x004D6B1E
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06023358 RID: 144216 RVA: 0x004D8929 File Offset: 0x004D6B29
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x06023359 RID: 144217 RVA: 0x004D8934 File Offset: 0x004D6B34
		public static Offset<IDropComponent> EndIDropComponent(FlatBufferBuilder builder)
		{
			return new Offset<IDropComponent>(builder.EndTable());
		}

		// Token: 0x0602335A RID: 144218 RVA: 0x004D8944 File Offset: 0x004D6B44
		public IDropComponentT UnPack()
		{
			IDropComponentT dropComponentT = new IDropComponentT();
			this.UnPackTo(dropComponentT);
			return dropComponentT;
		}

		// Token: 0x0602335B RID: 144219 RVA: 0x004D895F File Offset: 0x004D6B5F
		public void UnPackTo(IDropComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602335C RID: 144220 RVA: 0x004D897C File Offset: 0x004D6B7C
		public static Offset<IDropComponent> Pack(FlatBufferBuilder builder, IDropComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDropComponent>);
			}
			return IDropComponent.CreateIDropComponent(builder, _o.Disabled, _o.NullMask);
		}

		// Token: 0x0400ED01 RID: 60673
		private Table __p;
	}
}
