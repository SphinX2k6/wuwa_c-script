using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005425 RID: 21541
	public struct IInitStateMagneticStorm : IFlatbufferObject
	{
		// Token: 0x17009E6F RID: 40559
		// (get) Token: 0x0602360B RID: 144907 RVA: 0x004E52CD File Offset: 0x004E34CD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602360C RID: 144908 RVA: 0x004E52DA File Offset: 0x004E34DA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602360D RID: 144909 RVA: 0x004E52E4 File Offset: 0x004E34E4
		public static IInitStateMagneticStorm GetRootAsIInitStateMagneticStorm(ByteBuffer _bb)
		{
			return IInitStateMagneticStorm.GetRootAsIInitStateMagneticStorm(_bb, default(IInitStateMagneticStorm));
		}

		// Token: 0x0602360E RID: 144910 RVA: 0x004E5300 File Offset: 0x004E3500
		public static IInitStateMagneticStorm GetRootAsIInitStateMagneticStorm(ByteBuffer _bb, IInitStateMagneticStorm obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602360F RID: 144911 RVA: 0x004E531D File Offset: 0x004E351D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023610 RID: 144912 RVA: 0x004E532C File Offset: 0x004E352C
		public IInitStateMagneticStorm __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009E70 RID: 40560
		// (get) Token: 0x06023611 RID: 144913 RVA: 0x004E533C File Offset: 0x004E353C
		public EInitStateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInitStateType.Birth;
				}
				return (EInitStateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023612 RID: 144914 RVA: 0x004E5378 File Offset: 0x004E3578
		public static Offset<IInitStateMagneticStorm> CreateIInitStateMagneticStorm(FlatBufferBuilder builder, EInitStateType Type = EInitStateType.Birth)
		{
			builder.StartTable(1);
			IInitStateMagneticStorm.AddType(builder, Type);
			return IInitStateMagneticStorm.EndIInitStateMagneticStorm(builder);
		}

		// Token: 0x06023613 RID: 144915 RVA: 0x004E538E File Offset: 0x004E358E
		public static void StartIInitStateMagneticStorm(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06023614 RID: 144916 RVA: 0x004E5397 File Offset: 0x004E3597
		public static void AddType(FlatBufferBuilder builder, EInitStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06023615 RID: 144917 RVA: 0x004E53A2 File Offset: 0x004E35A2
		public static Offset<IInitStateMagneticStorm> EndIInitStateMagneticStorm(FlatBufferBuilder builder)
		{
			return new Offset<IInitStateMagneticStorm>(builder.EndTable());
		}

		// Token: 0x06023616 RID: 144918 RVA: 0x004E53B0 File Offset: 0x004E35B0
		public IInitStateMagneticStormT UnPack()
		{
			IInitStateMagneticStormT initStateMagneticStormT = new IInitStateMagneticStormT();
			this.UnPackTo(initStateMagneticStormT);
			return initStateMagneticStormT;
		}

		// Token: 0x06023617 RID: 144919 RVA: 0x004E53CB File Offset: 0x004E35CB
		public void UnPackTo(IInitStateMagneticStormT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06023618 RID: 144920 RVA: 0x004E53DC File Offset: 0x004E35DC
		public static Offset<IInitStateMagneticStorm> Pack(FlatBufferBuilder builder, IInitStateMagneticStormT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInitStateMagneticStorm>);
			}
			return IInitStateMagneticStorm.CreateIInitStateMagneticStorm(builder, _o.Type);
		}

		// Token: 0x0400E66E RID: 58990
		private Table __p;
	}
}
