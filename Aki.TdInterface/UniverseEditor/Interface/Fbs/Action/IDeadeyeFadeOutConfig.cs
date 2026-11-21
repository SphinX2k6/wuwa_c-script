using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BC3 RID: 27587
	public struct IDeadeyeFadeOutConfig : IFlatbufferObject
	{
		// Token: 0x1700CA6C RID: 51820
		// (get) Token: 0x0602F7D4 RID: 194516 RVA: 0x00679F40 File Offset: 0x00678140
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F7D5 RID: 194517 RVA: 0x00679F4D File Offset: 0x0067814D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F7D6 RID: 194518 RVA: 0x00679F54 File Offset: 0x00678154
		public static IDeadeyeFadeOutConfig GetRootAsIDeadeyeFadeOutConfig(ByteBuffer _bb)
		{
			return IDeadeyeFadeOutConfig.GetRootAsIDeadeyeFadeOutConfig(_bb, default(IDeadeyeFadeOutConfig));
		}

		// Token: 0x0602F7D7 RID: 194519 RVA: 0x00679F70 File Offset: 0x00678170
		public static IDeadeyeFadeOutConfig GetRootAsIDeadeyeFadeOutConfig(ByteBuffer _bb, IDeadeyeFadeOutConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F7D8 RID: 194520 RVA: 0x00679F8D File Offset: 0x0067818D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F7D9 RID: 194521 RVA: 0x00679F9C File Offset: 0x0067819C
		public IDeadeyeFadeOutConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CA6D RID: 51821
		// (get) Token: 0x0602F7DA RID: 194522 RVA: 0x00679FAC File Offset: 0x006781AC
		public float TransitionTime
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F7DB RID: 194523 RVA: 0x00679FEC File Offset: 0x006781EC
		public static Offset<IDeadeyeFadeOutConfig> CreateIDeadeyeFadeOutConfig(FlatBufferBuilder builder, float TransitionTime = 0f)
		{
			builder.StartTable(1);
			IDeadeyeFadeOutConfig.AddTransitionTime(builder, TransitionTime);
			return IDeadeyeFadeOutConfig.EndIDeadeyeFadeOutConfig(builder);
		}

		// Token: 0x0602F7DC RID: 194524 RVA: 0x0067A002 File Offset: 0x00678202
		public static void StartIDeadeyeFadeOutConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602F7DD RID: 194525 RVA: 0x0067A00B File Offset: 0x0067820B
		public static void AddTransitionTime(FlatBufferBuilder builder, float transitionTime)
		{
			builder.AddFloat(0, transitionTime, 0.0);
		}

		// Token: 0x0602F7DE RID: 194526 RVA: 0x0067A01E File Offset: 0x0067821E
		public static Offset<IDeadeyeFadeOutConfig> EndIDeadeyeFadeOutConfig(FlatBufferBuilder builder)
		{
			return new Offset<IDeadeyeFadeOutConfig>(builder.EndTable());
		}

		// Token: 0x0602F7DF RID: 194527 RVA: 0x0067A02C File Offset: 0x0067822C
		public IDeadeyeFadeOutConfigT UnPack()
		{
			IDeadeyeFadeOutConfigT deadeyeFadeOutConfigT = new IDeadeyeFadeOutConfigT();
			this.UnPackTo(deadeyeFadeOutConfigT);
			return deadeyeFadeOutConfigT;
		}

		// Token: 0x0602F7E0 RID: 194528 RVA: 0x0067A047 File Offset: 0x00678247
		public void UnPackTo(IDeadeyeFadeOutConfigT _o)
		{
			_o.TransitionTime = this.TransitionTime;
		}

		// Token: 0x0602F7E1 RID: 194529 RVA: 0x0067A058 File Offset: 0x00678258
		public static Offset<IDeadeyeFadeOutConfig> Pack(FlatBufferBuilder builder, IDeadeyeFadeOutConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDeadeyeFadeOutConfig>);
			}
			return IDeadeyeFadeOutConfig.CreateIDeadeyeFadeOutConfig(builder, _o.TransitionTime);
		}

		// Token: 0x040119C2 RID: 72130
		private Table __p;
	}
}
