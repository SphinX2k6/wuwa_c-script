using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078BA RID: 30906
	public struct IShowTalkCameraMotion : IFlatbufferObject
	{
		// Token: 0x1700E2C9 RID: 58057
		// (get) Token: 0x0603667F RID: 222847 RVA: 0x007492BF File Offset: 0x007474BF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036680 RID: 222848 RVA: 0x007492CC File Offset: 0x007474CC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036681 RID: 222849 RVA: 0x007492D4 File Offset: 0x007474D4
		public static IShowTalkCameraMotion GetRootAsIShowTalkCameraMotion(ByteBuffer _bb)
		{
			return IShowTalkCameraMotion.GetRootAsIShowTalkCameraMotion(_bb, default(IShowTalkCameraMotion));
		}

		// Token: 0x06036682 RID: 222850 RVA: 0x007492F0 File Offset: 0x007474F0
		public static IShowTalkCameraMotion GetRootAsIShowTalkCameraMotion(ByteBuffer _bb, IShowTalkCameraMotion obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036683 RID: 222851 RVA: 0x0074930D File Offset: 0x0074750D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036684 RID: 222852 RVA: 0x0074931C File Offset: 0x0074751C
		public IShowTalkCameraMotion __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E2CA RID: 58058
		// (get) Token: 0x06036685 RID: 222853 RVA: 0x0074932C File Offset: 0x0074752C
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

		// Token: 0x06036686 RID: 222854 RVA: 0x00749368 File Offset: 0x00747568
		public static Offset<IShowTalkCameraMotion> CreateIShowTalkCameraMotion(FlatBufferBuilder builder, EShowTalkCameraMotionType Type = EShowTalkCameraMotionType.Preset)
		{
			builder.StartTable(1);
			IShowTalkCameraMotion.AddType(builder, Type);
			return IShowTalkCameraMotion.EndIShowTalkCameraMotion(builder);
		}

		// Token: 0x06036687 RID: 222855 RVA: 0x0074937E File Offset: 0x0074757E
		public static void StartIShowTalkCameraMotion(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06036688 RID: 222856 RVA: 0x00749387 File Offset: 0x00747587
		public static void AddType(FlatBufferBuilder builder, EShowTalkCameraMotionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036689 RID: 222857 RVA: 0x00749392 File Offset: 0x00747592
		public static Offset<IShowTalkCameraMotion> EndIShowTalkCameraMotion(FlatBufferBuilder builder)
		{
			return new Offset<IShowTalkCameraMotion>(builder.EndTable());
		}

		// Token: 0x0603668A RID: 222858 RVA: 0x007493A0 File Offset: 0x007475A0
		public IShowTalkCameraMotionT UnPack()
		{
			IShowTalkCameraMotionT showTalkCameraMotionT = new IShowTalkCameraMotionT();
			this.UnPackTo(showTalkCameraMotionT);
			return showTalkCameraMotionT;
		}

		// Token: 0x0603668B RID: 222859 RVA: 0x007493BB File Offset: 0x007475BB
		public void UnPackTo(IShowTalkCameraMotionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603668C RID: 222860 RVA: 0x007493CC File Offset: 0x007475CC
		public static Offset<IShowTalkCameraMotion> Pack(FlatBufferBuilder builder, IShowTalkCameraMotionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowTalkCameraMotion>);
			}
			return IShowTalkCameraMotion.CreateIShowTalkCameraMotion(builder, _o.Type);
		}

		// Token: 0x04012B61 RID: 76641
		private Table __p;
	}
}
