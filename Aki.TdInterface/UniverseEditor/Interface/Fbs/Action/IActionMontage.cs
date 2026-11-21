using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066E2 RID: 26338
	public struct IActionMontage : IFlatbufferObject
	{
		// Token: 0x1700BF87 RID: 49031
		// (get) Token: 0x0602C440 RID: 181312 RVA: 0x00606E55 File Offset: 0x00605055
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C441 RID: 181313 RVA: 0x00606E62 File Offset: 0x00605062
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C442 RID: 181314 RVA: 0x00606E6C File Offset: 0x0060506C
		public static IActionMontage GetRootAsIActionMontage(ByteBuffer _bb)
		{
			return IActionMontage.GetRootAsIActionMontage(_bb, default(IActionMontage));
		}

		// Token: 0x0602C443 RID: 181315 RVA: 0x00606E88 File Offset: 0x00605088
		public static IActionMontage GetRootAsIActionMontage(ByteBuffer _bb, IActionMontage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C444 RID: 181316 RVA: 0x00606EA5 File Offset: 0x006050A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C445 RID: 181317 RVA: 0x00606EB4 File Offset: 0x006050B4
		public IActionMontage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BF88 RID: 49032
		// (get) Token: 0x0602C446 RID: 181318 RVA: 0x00606EC4 File Offset: 0x006050C4
		public EActionMontageType MontageType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EActionMontageType.Normal;
				}
				return (EActionMontageType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BF89 RID: 49033
		// (get) Token: 0x0602C447 RID: 181319 RVA: 0x00606F00 File Offset: 0x00605100
		public string Path
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602C448 RID: 181320 RVA: 0x00606F37 File Offset: 0x00605137
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602C449 RID: 181321 RVA: 0x00606F46 File Offset: 0x00605146
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602C44A RID: 181322 RVA: 0x00606F54 File Offset: 0x00605154
		public static Offset<IActionMontage> CreateIActionMontage(FlatBufferBuilder builder, EActionMontageType MontageType = EActionMontageType.Normal, StringOffset PathOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IActionMontage.AddPath(builder, PathOffset);
			IActionMontage.AddMontageType(builder, MontageType);
			return IActionMontage.EndIActionMontage(builder);
		}

		// Token: 0x0602C44B RID: 181323 RVA: 0x00606F71 File Offset: 0x00605171
		public static void StartIActionMontage(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602C44C RID: 181324 RVA: 0x00606F7A File Offset: 0x0060517A
		public static void AddMontageType(FlatBufferBuilder builder, EActionMontageType montageType)
		{
			builder.AddByte(0, (byte)montageType, 0);
		}

		// Token: 0x0602C44D RID: 181325 RVA: 0x00606F85 File Offset: 0x00605185
		public static void AddPath(FlatBufferBuilder builder, StringOffset pathOffset)
		{
			builder.AddOffset(1, pathOffset.Value, 0);
		}

		// Token: 0x0602C44E RID: 181326 RVA: 0x00606F95 File Offset: 0x00605195
		public static Offset<IActionMontage> EndIActionMontage(FlatBufferBuilder builder)
		{
			return new Offset<IActionMontage>(builder.EndTable());
		}

		// Token: 0x0602C44F RID: 181327 RVA: 0x00606FA4 File Offset: 0x006051A4
		public IActionMontageT UnPack()
		{
			IActionMontageT actionMontageT = new IActionMontageT();
			this.UnPackTo(actionMontageT);
			return actionMontageT;
		}

		// Token: 0x0602C450 RID: 181328 RVA: 0x00606FBF File Offset: 0x006051BF
		public void UnPackTo(IActionMontageT _o)
		{
			_o.MontageType = this.MontageType;
			_o.Path = this.Path;
		}

		// Token: 0x0602C451 RID: 181329 RVA: 0x00606FDC File Offset: 0x006051DC
		public static Offset<IActionMontage> Pack(FlatBufferBuilder builder, IActionMontageT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActionMontage>);
			}
			StringOffset pathOffset = (_o.Path == null) ? default(StringOffset) : builder.CreateString(_o.Path);
			return IActionMontage.CreateIActionMontage(builder, _o.MontageType, pathOffset);
		}

		// Token: 0x0401104F RID: 69711
		private Table __p;
	}
}
