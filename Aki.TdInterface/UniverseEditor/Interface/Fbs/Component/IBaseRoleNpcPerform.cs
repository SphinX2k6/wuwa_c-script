using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200541E RID: 21534
	public struct IBaseRoleNpcPerform : IFlatbufferObject
	{
		// Token: 0x170098CE RID: 39118
		// (get) Token: 0x06021BBB RID: 138171 RVA: 0x004A6850 File Offset: 0x004A4A50
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021BBC RID: 138172 RVA: 0x004A685D File Offset: 0x004A4A5D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021BBD RID: 138173 RVA: 0x004A6864 File Offset: 0x004A4A64
		public static IBaseRoleNpcPerform GetRootAsIBaseRoleNpcPerform(ByteBuffer _bb)
		{
			return IBaseRoleNpcPerform.GetRootAsIBaseRoleNpcPerform(_bb, default(IBaseRoleNpcPerform));
		}

		// Token: 0x06021BBE RID: 138174 RVA: 0x004A6880 File Offset: 0x004A4A80
		public static IBaseRoleNpcPerform GetRootAsIBaseRoleNpcPerform(ByteBuffer _bb, IBaseRoleNpcPerform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021BBF RID: 138175 RVA: 0x004A689D File Offset: 0x004A4A9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021BC0 RID: 138176 RVA: 0x004A68AC File Offset: 0x004A4AAC
		public IBaseRoleNpcPerform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170098CF RID: 39119
		// (get) Token: 0x06021BC1 RID: 138177 RVA: 0x004A68BC File Offset: 0x004A4ABC
		public ESpecialNpcType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESpecialNpcType.BaseRoleNpc;
				}
				return (ESpecialNpcType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021BC2 RID: 138178 RVA: 0x004A68F8 File Offset: 0x004A4AF8
		public static Offset<IBaseRoleNpcPerform> CreateIBaseRoleNpcPerform(FlatBufferBuilder builder, ESpecialNpcType Type = ESpecialNpcType.BaseRoleNpc)
		{
			builder.StartTable(1);
			IBaseRoleNpcPerform.AddType(builder, Type);
			return IBaseRoleNpcPerform.EndIBaseRoleNpcPerform(builder);
		}

		// Token: 0x06021BC3 RID: 138179 RVA: 0x004A690E File Offset: 0x004A4B0E
		public static void StartIBaseRoleNpcPerform(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06021BC4 RID: 138180 RVA: 0x004A6917 File Offset: 0x004A4B17
		public static void AddType(FlatBufferBuilder builder, ESpecialNpcType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06021BC5 RID: 138181 RVA: 0x004A6922 File Offset: 0x004A4B22
		public static Offset<IBaseRoleNpcPerform> EndIBaseRoleNpcPerform(FlatBufferBuilder builder)
		{
			return new Offset<IBaseRoleNpcPerform>(builder.EndTable());
		}

		// Token: 0x06021BC6 RID: 138182 RVA: 0x004A6930 File Offset: 0x004A4B30
		public IBaseRoleNpcPerformT UnPack()
		{
			IBaseRoleNpcPerformT baseRoleNpcPerformT = new IBaseRoleNpcPerformT();
			this.UnPackTo(baseRoleNpcPerformT);
			return baseRoleNpcPerformT;
		}

		// Token: 0x06021BC7 RID: 138183 RVA: 0x004A694B File Offset: 0x004A4B4B
		public void UnPackTo(IBaseRoleNpcPerformT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06021BC8 RID: 138184 RVA: 0x004A695C File Offset: 0x004A4B5C
		public static Offset<IBaseRoleNpcPerform> Pack(FlatBufferBuilder builder, IBaseRoleNpcPerformT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBaseRoleNpcPerform>);
			}
			return IBaseRoleNpcPerform.CreateIBaseRoleNpcPerform(builder, _o.Type);
		}

		// Token: 0x0400E8C8 RID: 59592
		private Table __p;
	}
}
