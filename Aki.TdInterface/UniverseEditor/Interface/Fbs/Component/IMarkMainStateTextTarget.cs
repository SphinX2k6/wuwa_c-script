using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200551E RID: 21790
	public struct IMarkMainStateTextTarget : IFlatbufferObject
	{
		// Token: 0x1700A0D7 RID: 41175
		// (get) Token: 0x06023FCF RID: 147407 RVA: 0x004F92E5 File Offset: 0x004F74E5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023FD0 RID: 147408 RVA: 0x004F92F2 File Offset: 0x004F74F2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023FD1 RID: 147409 RVA: 0x004F92FC File Offset: 0x004F74FC
		public static IMarkMainStateTextTarget GetRootAsIMarkMainStateTextTarget(ByteBuffer _bb)
		{
			return IMarkMainStateTextTarget.GetRootAsIMarkMainStateTextTarget(_bb, default(IMarkMainStateTextTarget));
		}

		// Token: 0x06023FD2 RID: 147410 RVA: 0x004F9318 File Offset: 0x004F7518
		public static IMarkMainStateTextTarget GetRootAsIMarkMainStateTextTarget(ByteBuffer _bb, IMarkMainStateTextTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023FD3 RID: 147411 RVA: 0x004F9335 File Offset: 0x004F7535
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023FD4 RID: 147412 RVA: 0x004F9344 File Offset: 0x004F7544
		public IMarkMainStateTextTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A0D8 RID: 41176
		// (get) Token: 0x06023FD5 RID: 147413 RVA: 0x004F9354 File Offset: 0x004F7554
		public string TidTargetName
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023FD6 RID: 147414 RVA: 0x004F938B File Offset: 0x004F758B
		public Span<byte> GetTidTargetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06023FD7 RID: 147415 RVA: 0x004F939A File Offset: 0x004F759A
		public byte[] GetTidTargetNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06023FD8 RID: 147416 RVA: 0x004F93A8 File Offset: 0x004F75A8
		public static Offset<IMarkMainStateTextTarget> CreateIMarkMainStateTextTarget(FlatBufferBuilder builder, StringOffset TidTargetNameOffset = default(StringOffset))
		{
			builder.StartTable(1);
			IMarkMainStateTextTarget.AddTidTargetName(builder, TidTargetNameOffset);
			return IMarkMainStateTextTarget.EndIMarkMainStateTextTarget(builder);
		}

		// Token: 0x06023FD9 RID: 147417 RVA: 0x004F93BE File Offset: 0x004F75BE
		public static void StartIMarkMainStateTextTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06023FDA RID: 147418 RVA: 0x004F93C7 File Offset: 0x004F75C7
		public static void AddTidTargetName(FlatBufferBuilder builder, StringOffset tidTargetNameOffset)
		{
			builder.AddOffset(0, tidTargetNameOffset.Value, 0);
		}

		// Token: 0x06023FDB RID: 147419 RVA: 0x004F93D7 File Offset: 0x004F75D7
		public static Offset<IMarkMainStateTextTarget> EndIMarkMainStateTextTarget(FlatBufferBuilder builder)
		{
			return new Offset<IMarkMainStateTextTarget>(builder.EndTable());
		}

		// Token: 0x06023FDC RID: 147420 RVA: 0x004F93E4 File Offset: 0x004F75E4
		public IMarkMainStateTextTargetT UnPack()
		{
			IMarkMainStateTextTargetT markMainStateTextTargetT = new IMarkMainStateTextTargetT();
			this.UnPackTo(markMainStateTextTargetT);
			return markMainStateTextTargetT;
		}

		// Token: 0x06023FDD RID: 147421 RVA: 0x004F93FF File Offset: 0x004F75FF
		public void UnPackTo(IMarkMainStateTextTargetT _o)
		{
			_o.TidTargetName = this.TidTargetName;
		}

		// Token: 0x06023FDE RID: 147422 RVA: 0x004F9410 File Offset: 0x004F7610
		public static Offset<IMarkMainStateTextTarget> Pack(FlatBufferBuilder builder, IMarkMainStateTextTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMarkMainStateTextTarget>);
			}
			StringOffset tidTargetNameOffset = (_o.TidTargetName == null) ? default(StringOffset) : builder.CreateString(_o.TidTargetName);
			return IMarkMainStateTextTarget.CreateIMarkMainStateTextTarget(builder, tidTargetNameOffset);
		}

		// Token: 0x0400E811 RID: 59409
		private Table __p;
	}
}
