using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062A8 RID: 25256
	public struct ICameraTransition : IFlatbufferObject
	{
		// Token: 0x1700BC83 RID: 48259
		// (get) Token: 0x0602BA2F RID: 178735 RVA: 0x00601B5C File Offset: 0x005FFD5C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BA30 RID: 178736 RVA: 0x00601B69 File Offset: 0x005FFD69
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BA31 RID: 178737 RVA: 0x00601B70 File Offset: 0x005FFD70
		public static ICameraTransition GetRootAsICameraTransition(ByteBuffer _bb)
		{
			return ICameraTransition.GetRootAsICameraTransition(_bb, default(ICameraTransition));
		}

		// Token: 0x0602BA32 RID: 178738 RVA: 0x00601B8C File Offset: 0x005FFD8C
		public static ICameraTransition GetRootAsICameraTransition(ByteBuffer _bb, ICameraTransition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BA33 RID: 178739 RVA: 0x00601BA9 File Offset: 0x005FFDA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BA34 RID: 178740 RVA: 0x00601BB8 File Offset: 0x005FFDB8
		public ICameraTransition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BC84 RID: 48260
		// (get) Token: 0x0602BA35 RID: 178741 RVA: 0x00601BC8 File Offset: 0x005FFDC8
		public ELevelSequenceTransition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELevelSequenceTransition.Camera;
				}
				return (ELevelSequenceTransition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BC85 RID: 48261
		// (get) Token: 0x0602BA36 RID: 178742 RVA: 0x00601C04 File Offset: 0x005FFE04
		public float Duration
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BC86 RID: 48262
		// (get) Token: 0x0602BA37 RID: 178743 RVA: 0x00601C44 File Offset: 0x005FFE44
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602BA38 RID: 178744 RVA: 0x00601C80 File Offset: 0x005FFE80
		public static Offset<ICameraTransition> CreateICameraTransition(FlatBufferBuilder builder, ELevelSequenceTransition Type = ELevelSequenceTransition.Camera, float Duration = 0f, byte NullMask = 0)
		{
			builder.StartTable(3);
			ICameraTransition.AddDuration(builder, Duration);
			ICameraTransition.AddNullMask(builder, NullMask);
			ICameraTransition.AddType(builder, Type);
			return ICameraTransition.EndICameraTransition(builder);
		}

		// Token: 0x0602BA39 RID: 178745 RVA: 0x00601CA4 File Offset: 0x005FFEA4
		public static void StartICameraTransition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602BA3A RID: 178746 RVA: 0x00601CAD File Offset: 0x005FFEAD
		public static void AddType(FlatBufferBuilder builder, ELevelSequenceTransition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602BA3B RID: 178747 RVA: 0x00601CB8 File Offset: 0x005FFEB8
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(1, duration, 0.0);
		}

		// Token: 0x0602BA3C RID: 178748 RVA: 0x00601CCB File Offset: 0x005FFECB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602BA3D RID: 178749 RVA: 0x00601CD6 File Offset: 0x005FFED6
		public static Offset<ICameraTransition> EndICameraTransition(FlatBufferBuilder builder)
		{
			return new Offset<ICameraTransition>(builder.EndTable());
		}

		// Token: 0x0602BA3E RID: 178750 RVA: 0x00601CE4 File Offset: 0x005FFEE4
		public ICameraTransitionT UnPack()
		{
			ICameraTransitionT cameraTransitionT = new ICameraTransitionT();
			this.UnPackTo(cameraTransitionT);
			return cameraTransitionT;
		}

		// Token: 0x0602BA3F RID: 178751 RVA: 0x00601CFF File Offset: 0x005FFEFF
		public void UnPackTo(ICameraTransitionT _o)
		{
			_o.Type = this.Type;
			_o.Duration = this.Duration;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602BA40 RID: 178752 RVA: 0x00601D28 File Offset: 0x005FFF28
		public static Offset<ICameraTransition> Pack(FlatBufferBuilder builder, ICameraTransitionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICameraTransition>);
			}
			return ICameraTransition.CreateICameraTransition(builder, _o.Type, _o.Duration, _o.NullMask);
		}

		// Token: 0x04010842 RID: 67650
		private Table __p;
	}
}
