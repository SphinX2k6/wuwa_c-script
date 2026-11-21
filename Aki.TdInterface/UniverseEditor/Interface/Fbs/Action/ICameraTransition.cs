using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006919 RID: 26905
	public struct ICameraTransition : IFlatbufferObject
	{
		// Token: 0x1700C60B RID: 50699
		// (get) Token: 0x0602E190 RID: 188816 RVA: 0x0064C964 File Offset: 0x0064AB64
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E191 RID: 188817 RVA: 0x0064C971 File Offset: 0x0064AB71
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E192 RID: 188818 RVA: 0x0064C978 File Offset: 0x0064AB78
		public static ICameraTransition GetRootAsICameraTransition(ByteBuffer _bb)
		{
			return ICameraTransition.GetRootAsICameraTransition(_bb, default(ICameraTransition));
		}

		// Token: 0x0602E193 RID: 188819 RVA: 0x0064C994 File Offset: 0x0064AB94
		public static ICameraTransition GetRootAsICameraTransition(ByteBuffer _bb, ICameraTransition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E194 RID: 188820 RVA: 0x0064C9B1 File Offset: 0x0064ABB1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E195 RID: 188821 RVA: 0x0064C9C0 File Offset: 0x0064ABC0
		public ICameraTransition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C60C RID: 50700
		// (get) Token: 0x0602E196 RID: 188822 RVA: 0x0064C9D0 File Offset: 0x0064ABD0
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

		// Token: 0x1700C60D RID: 50701
		// (get) Token: 0x0602E197 RID: 188823 RVA: 0x0064CA0C File Offset: 0x0064AC0C
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

		// Token: 0x1700C60E RID: 50702
		// (get) Token: 0x0602E198 RID: 188824 RVA: 0x0064CA4C File Offset: 0x0064AC4C
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

		// Token: 0x0602E199 RID: 188825 RVA: 0x0064CA88 File Offset: 0x0064AC88
		public static Offset<ICameraTransition> CreateICameraTransition(FlatBufferBuilder builder, ELevelSequenceTransition Type = ELevelSequenceTransition.Camera, float Duration = 0f, byte NullMask = 0)
		{
			builder.StartTable(3);
			ICameraTransition.AddDuration(builder, Duration);
			ICameraTransition.AddNullMask(builder, NullMask);
			ICameraTransition.AddType(builder, Type);
			return ICameraTransition.EndICameraTransition(builder);
		}

		// Token: 0x0602E19A RID: 188826 RVA: 0x0064CAAC File Offset: 0x0064ACAC
		public static void StartICameraTransition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602E19B RID: 188827 RVA: 0x0064CAB5 File Offset: 0x0064ACB5
		public static void AddType(FlatBufferBuilder builder, ELevelSequenceTransition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E19C RID: 188828 RVA: 0x0064CAC0 File Offset: 0x0064ACC0
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(1, duration, 0.0);
		}

		// Token: 0x0602E19D RID: 188829 RVA: 0x0064CAD3 File Offset: 0x0064ACD3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602E19E RID: 188830 RVA: 0x0064CADE File Offset: 0x0064ACDE
		public static Offset<ICameraTransition> EndICameraTransition(FlatBufferBuilder builder)
		{
			return new Offset<ICameraTransition>(builder.EndTable());
		}

		// Token: 0x0602E19F RID: 188831 RVA: 0x0064CAEC File Offset: 0x0064ACEC
		public ICameraTransitionT UnPack()
		{
			ICameraTransitionT cameraTransitionT = new ICameraTransitionT();
			this.UnPackTo(cameraTransitionT);
			return cameraTransitionT;
		}

		// Token: 0x0602E1A0 RID: 188832 RVA: 0x0064CB07 File Offset: 0x0064AD07
		public void UnPackTo(ICameraTransitionT _o)
		{
			_o.Type = this.Type;
			_o.Duration = this.Duration;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602E1A1 RID: 188833 RVA: 0x0064CB30 File Offset: 0x0064AD30
		public static Offset<ICameraTransition> Pack(FlatBufferBuilder builder, ICameraTransitionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICameraTransition>);
			}
			return ICameraTransition.CreateICameraTransition(builder, _o.Type, _o.Duration, _o.NullMask);
		}

		// Token: 0x04011657 RID: 71255
		private Table __p;
	}
}
