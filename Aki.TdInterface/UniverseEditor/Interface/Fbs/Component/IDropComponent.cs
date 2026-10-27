using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050C0 RID: 20672
	public struct IDropComponent : IFlatbufferObject
	{
		// Token: 0x1700966F RID: 38511
		// (get) Token: 0x060213F9 RID: 136185 RVA: 0x0049E884 File Offset: 0x0049CA84
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060213FA RID: 136186 RVA: 0x0049E891 File Offset: 0x0049CA91
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060213FB RID: 136187 RVA: 0x0049E898 File Offset: 0x0049CA98
		public static IDropComponent GetRootAsIDropComponent(ByteBuffer _bb)
		{
			return IDropComponent.GetRootAsIDropComponent(_bb, default(IDropComponent));
		}

		// Token: 0x060213FC RID: 136188 RVA: 0x0049E8B4 File Offset: 0x0049CAB4
		public static IDropComponent GetRootAsIDropComponent(ByteBuffer _bb, IDropComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060213FD RID: 136189 RVA: 0x0049E8D1 File Offset: 0x0049CAD1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060213FE RID: 136190 RVA: 0x0049E8E0 File Offset: 0x0049CAE0
		public IDropComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009670 RID: 38512
		// (get) Token: 0x060213FF RID: 136191 RVA: 0x0049E8F0 File Offset: 0x0049CAF0
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009671 RID: 38513
		// (get) Token: 0x06021400 RID: 136192 RVA: 0x0049E930 File Offset: 0x0049CB30
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

		// Token: 0x06021401 RID: 136193 RVA: 0x0049E96C File Offset: 0x0049CB6C
		public static Offset<IDropComponent> CreateIDropComponent(FlatBufferBuilder builder, bool Disabled = false, byte NullMask = 0)
		{
			builder.StartTable(2);
			IDropComponent.AddNullMask(builder, NullMask);
			IDropComponent.AddDisabled(builder, Disabled);
			return IDropComponent.EndIDropComponent(builder);
		}

		// Token: 0x06021402 RID: 136194 RVA: 0x0049E989 File Offset: 0x0049CB89
		public static void StartIDropComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06021403 RID: 136195 RVA: 0x0049E992 File Offset: 0x0049CB92
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06021404 RID: 136196 RVA: 0x0049E99D File Offset: 0x0049CB9D
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x06021405 RID: 136197 RVA: 0x0049E9A8 File Offset: 0x0049CBA8
		public static Offset<IDropComponent> EndIDropComponent(FlatBufferBuilder builder)
		{
			return new Offset<IDropComponent>(builder.EndTable());
		}

		// Token: 0x06021406 RID: 136198 RVA: 0x0049E9B8 File Offset: 0x0049CBB8
		public IDropComponentT UnPack()
		{
			IDropComponentT dropComponentT = new IDropComponentT();
			this.UnPackTo(dropComponentT);
			return dropComponentT;
		}

		// Token: 0x06021407 RID: 136199 RVA: 0x0049E9D3 File Offset: 0x0049CBD3
		public void UnPackTo(IDropComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06021408 RID: 136200 RVA: 0x0049E9F0 File Offset: 0x0049CBF0
		public static Offset<IDropComponent> Pack(FlatBufferBuilder builder, IDropComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDropComponent>);
			}
			return IDropComponent.CreateIDropComponent(builder, _o.Disabled, _o.NullMask);
		}

		// Token: 0x0400E104 RID: 57604
		private Table __p;
	}
}
