using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006552 RID: 25938
	public struct IDeadeyeFadeOutConfig : IFlatbufferObject
	{
		// Token: 0x1700C0D1 RID: 49361
		// (get) Token: 0x0602D018 RID: 184344 RVA: 0x0062D77C File Offset: 0x0062B97C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D019 RID: 184345 RVA: 0x0062D789 File Offset: 0x0062B989
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D01A RID: 184346 RVA: 0x0062D790 File Offset: 0x0062B990
		public static IDeadeyeFadeOutConfig GetRootAsIDeadeyeFadeOutConfig(ByteBuffer _bb)
		{
			return IDeadeyeFadeOutConfig.GetRootAsIDeadeyeFadeOutConfig(_bb, default(IDeadeyeFadeOutConfig));
		}

		// Token: 0x0602D01B RID: 184347 RVA: 0x0062D7AC File Offset: 0x0062B9AC
		public static IDeadeyeFadeOutConfig GetRootAsIDeadeyeFadeOutConfig(ByteBuffer _bb, IDeadeyeFadeOutConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D01C RID: 184348 RVA: 0x0062D7C9 File Offset: 0x0062B9C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D01D RID: 184349 RVA: 0x0062D7D8 File Offset: 0x0062B9D8
		public IDeadeyeFadeOutConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C0D2 RID: 49362
		// (get) Token: 0x0602D01E RID: 184350 RVA: 0x0062D7E8 File Offset: 0x0062B9E8
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

		// Token: 0x0602D01F RID: 184351 RVA: 0x0062D828 File Offset: 0x0062BA28
		public static Offset<IDeadeyeFadeOutConfig> CreateIDeadeyeFadeOutConfig(FlatBufferBuilder builder, float TransitionTime = 0f)
		{
			builder.StartTable(1);
			IDeadeyeFadeOutConfig.AddTransitionTime(builder, TransitionTime);
			return IDeadeyeFadeOutConfig.EndIDeadeyeFadeOutConfig(builder);
		}

		// Token: 0x0602D020 RID: 184352 RVA: 0x0062D83E File Offset: 0x0062BA3E
		public static void StartIDeadeyeFadeOutConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602D021 RID: 184353 RVA: 0x0062D847 File Offset: 0x0062BA47
		public static void AddTransitionTime(FlatBufferBuilder builder, float transitionTime)
		{
			builder.AddFloat(0, transitionTime, 0.0);
		}

		// Token: 0x0602D022 RID: 184354 RVA: 0x0062D85A File Offset: 0x0062BA5A
		public static Offset<IDeadeyeFadeOutConfig> EndIDeadeyeFadeOutConfig(FlatBufferBuilder builder)
		{
			return new Offset<IDeadeyeFadeOutConfig>(builder.EndTable());
		}

		// Token: 0x0602D023 RID: 184355 RVA: 0x0062D868 File Offset: 0x0062BA68
		public IDeadeyeFadeOutConfigT UnPack()
		{
			IDeadeyeFadeOutConfigT deadeyeFadeOutConfigT = new IDeadeyeFadeOutConfigT();
			this.UnPackTo(deadeyeFadeOutConfigT);
			return deadeyeFadeOutConfigT;
		}

		// Token: 0x0602D024 RID: 184356 RVA: 0x0062D883 File Offset: 0x0062BA83
		public void UnPackTo(IDeadeyeFadeOutConfigT _o)
		{
			_o.TransitionTime = this.TransitionTime;
		}

		// Token: 0x0602D025 RID: 184357 RVA: 0x0062D894 File Offset: 0x0062BA94
		public static Offset<IDeadeyeFadeOutConfig> Pack(FlatBufferBuilder builder, IDeadeyeFadeOutConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDeadeyeFadeOutConfig>);
			}
			return IDeadeyeFadeOutConfig.CreateIDeadeyeFadeOutConfig(builder, _o.TransitionTime);
		}

		// Token: 0x04010BA4 RID: 68516
		private Table __p;
	}
}
