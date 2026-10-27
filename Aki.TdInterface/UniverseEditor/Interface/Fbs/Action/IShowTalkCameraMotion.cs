using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070EE RID: 28910
	public struct IShowTalkCameraMotion : IFlatbufferObject
	{
		// Token: 0x1700D6E6 RID: 55014
		// (get) Token: 0x060333DD RID: 209885 RVA: 0x006E8CB3 File Offset: 0x006E6EB3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060333DE RID: 209886 RVA: 0x006E8CC0 File Offset: 0x006E6EC0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060333DF RID: 209887 RVA: 0x006E8CC8 File Offset: 0x006E6EC8
		public static IShowTalkCameraMotion GetRootAsIShowTalkCameraMotion(ByteBuffer _bb)
		{
			return IShowTalkCameraMotion.GetRootAsIShowTalkCameraMotion(_bb, default(IShowTalkCameraMotion));
		}

		// Token: 0x060333E0 RID: 209888 RVA: 0x006E8CE4 File Offset: 0x006E6EE4
		public static IShowTalkCameraMotion GetRootAsIShowTalkCameraMotion(ByteBuffer _bb, IShowTalkCameraMotion obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060333E1 RID: 209889 RVA: 0x006E8D01 File Offset: 0x006E6F01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060333E2 RID: 209890 RVA: 0x006E8D10 File Offset: 0x006E6F10
		public IShowTalkCameraMotion __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D6E7 RID: 55015
		// (get) Token: 0x060333E3 RID: 209891 RVA: 0x006E8D20 File Offset: 0x006E6F20
		public EShowTalkCameraMotionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EShowTalkCameraMotionType.Preset;
				}
				return (EShowTalkCameraMotionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060333E4 RID: 209892 RVA: 0x006E8D5C File Offset: 0x006E6F5C
		public static Offset<IShowTalkCameraMotion> CreateIShowTalkCameraMotion(FlatBufferBuilder builder, EShowTalkCameraMotionType Type = EShowTalkCameraMotionType.Preset)
		{
			builder.StartTable(1);
			IShowTalkCameraMotion.AddType(builder, Type);
			return IShowTalkCameraMotion.EndIShowTalkCameraMotion(builder);
		}

		// Token: 0x060333E5 RID: 209893 RVA: 0x006E8D72 File Offset: 0x006E6F72
		public static void StartIShowTalkCameraMotion(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060333E6 RID: 209894 RVA: 0x006E8D7B File Offset: 0x006E6F7B
		public static void AddType(FlatBufferBuilder builder, EShowTalkCameraMotionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060333E7 RID: 209895 RVA: 0x006E8D86 File Offset: 0x006E6F86
		public static Offset<IShowTalkCameraMotion> EndIShowTalkCameraMotion(FlatBufferBuilder builder)
		{
			return new Offset<IShowTalkCameraMotion>(builder.EndTable());
		}

		// Token: 0x060333E8 RID: 209896 RVA: 0x006E8D94 File Offset: 0x006E6F94
		public IShowTalkCameraMotionT UnPack()
		{
			IShowTalkCameraMotionT showTalkCameraMotionT = new IShowTalkCameraMotionT();
			this.UnPackTo(showTalkCameraMotionT);
			return showTalkCameraMotionT;
		}

		// Token: 0x060333E9 RID: 209897 RVA: 0x006E8DAF File Offset: 0x006E6FAF
		public void UnPackTo(IShowTalkCameraMotionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060333EA RID: 209898 RVA: 0x006E8DC0 File Offset: 0x006E6FC0
		public static Offset<IShowTalkCameraMotion> Pack(FlatBufferBuilder builder, IShowTalkCameraMotionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowTalkCameraMotion>);
			}
			return IShowTalkCameraMotion.CreateIShowTalkCameraMotion(builder, _o.Type);
		}

		// Token: 0x04011B73 RID: 72563
		private Table __p;
	}
}
