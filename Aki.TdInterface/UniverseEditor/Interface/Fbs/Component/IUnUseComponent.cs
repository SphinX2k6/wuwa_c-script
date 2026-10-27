using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B02 RID: 23298
	public struct IUnUseComponent : IFlatbufferObject
	{
		// Token: 0x1700AFC5 RID: 44997
		// (get) Token: 0x06027C76 RID: 162934 RVA: 0x00578A94 File Offset: 0x00576C94
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027C77 RID: 162935 RVA: 0x00578AA1 File Offset: 0x00576CA1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027C78 RID: 162936 RVA: 0x00578AA8 File Offset: 0x00576CA8
		public static IUnUseComponent GetRootAsIUnUseComponent(ByteBuffer _bb)
		{
			return IUnUseComponent.GetRootAsIUnUseComponent(_bb, default(IUnUseComponent));
		}

		// Token: 0x06027C79 RID: 162937 RVA: 0x00578AC4 File Offset: 0x00576CC4
		public static IUnUseComponent GetRootAsIUnUseComponent(ByteBuffer _bb, IUnUseComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027C7A RID: 162938 RVA: 0x00578AE1 File Offset: 0x00576CE1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027C7B RID: 162939 RVA: 0x00578AF0 File Offset: 0x00576CF0
		public IUnUseComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AFC6 RID: 44998
		// (get) Token: 0x06027C7C RID: 162940 RVA: 0x00578B00 File Offset: 0x00576D00
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AFC7 RID: 44999
		// (get) Token: 0x06027C7D RID: 162941 RVA: 0x00578B40 File Offset: 0x00576D40
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

		// Token: 0x06027C7E RID: 162942 RVA: 0x00578B7C File Offset: 0x00576D7C
		public static Offset<IUnUseComponent> CreateIUnUseComponent(FlatBufferBuilder builder, bool Disabled = false, byte NullMask = 0)
		{
			builder.StartTable(2);
			IUnUseComponent.AddNullMask(builder, NullMask);
			IUnUseComponent.AddDisabled(builder, Disabled);
			return IUnUseComponent.EndIUnUseComponent(builder);
		}

		// Token: 0x06027C7F RID: 162943 RVA: 0x00578B99 File Offset: 0x00576D99
		public static void StartIUnUseComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06027C80 RID: 162944 RVA: 0x00578BA2 File Offset: 0x00576DA2
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06027C81 RID: 162945 RVA: 0x00578BAD File Offset: 0x00576DAD
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x06027C82 RID: 162946 RVA: 0x00578BB8 File Offset: 0x00576DB8
		public static Offset<IUnUseComponent> EndIUnUseComponent(FlatBufferBuilder builder)
		{
			return new Offset<IUnUseComponent>(builder.EndTable());
		}

		// Token: 0x06027C83 RID: 162947 RVA: 0x00578BC8 File Offset: 0x00576DC8
		public IUnUseComponentT UnPack()
		{
			IUnUseComponentT unUseComponentT = new IUnUseComponentT();
			this.UnPackTo(unUseComponentT);
			return unUseComponentT;
		}

		// Token: 0x06027C84 RID: 162948 RVA: 0x00578BE3 File Offset: 0x00576DE3
		public void UnPackTo(IUnUseComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06027C85 RID: 162949 RVA: 0x00578C00 File Offset: 0x00576E00
		public static Offset<IUnUseComponent> Pack(FlatBufferBuilder builder, IUnUseComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUnUseComponent>);
			}
			return IUnUseComponent.CreateIUnUseComponent(builder, _o.Disabled, _o.NullMask);
		}

		// Token: 0x0400F205 RID: 61957
		private Table __p;
	}
}
