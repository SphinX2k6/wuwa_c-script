using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AA4 RID: 23204
	public struct IMarkMainStateTextTarget : IFlatbufferObject
	{
		// Token: 0x1700A911 RID: 43281
		// (get) Token: 0x06026089 RID: 155785 RVA: 0x00536409 File Offset: 0x00534609
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602608A RID: 155786 RVA: 0x00536416 File Offset: 0x00534616
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602608B RID: 155787 RVA: 0x00536420 File Offset: 0x00534620
		public static IMarkMainStateTextTarget GetRootAsIMarkMainStateTextTarget(ByteBuffer _bb)
		{
			return IMarkMainStateTextTarget.GetRootAsIMarkMainStateTextTarget(_bb, default(IMarkMainStateTextTarget));
		}

		// Token: 0x0602608C RID: 155788 RVA: 0x0053643C File Offset: 0x0053463C
		public static IMarkMainStateTextTarget GetRootAsIMarkMainStateTextTarget(ByteBuffer _bb, IMarkMainStateTextTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602608D RID: 155789 RVA: 0x00536459 File Offset: 0x00534659
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602608E RID: 155790 RVA: 0x00536468 File Offset: 0x00534668
		public IMarkMainStateTextTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A912 RID: 43282
		// (get) Token: 0x0602608F RID: 155791 RVA: 0x00536478 File Offset: 0x00534678
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

		// Token: 0x06026090 RID: 155792 RVA: 0x005364AF File Offset: 0x005346AF
		public Span<byte> GetTidTargetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06026091 RID: 155793 RVA: 0x005364BE File Offset: 0x005346BE
		public byte[] GetTidTargetNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06026092 RID: 155794 RVA: 0x005364CC File Offset: 0x005346CC
		public static Offset<IMarkMainStateTextTarget> CreateIMarkMainStateTextTarget(FlatBufferBuilder builder, StringOffset TidTargetNameOffset = default(StringOffset))
		{
			builder.StartTable(1);
			IMarkMainStateTextTarget.AddTidTargetName(builder, TidTargetNameOffset);
			return IMarkMainStateTextTarget.EndIMarkMainStateTextTarget(builder);
		}

		// Token: 0x06026093 RID: 155795 RVA: 0x005364E2 File Offset: 0x005346E2
		public static void StartIMarkMainStateTextTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06026094 RID: 155796 RVA: 0x005364EB File Offset: 0x005346EB
		public static void AddTidTargetName(FlatBufferBuilder builder, StringOffset tidTargetNameOffset)
		{
			builder.AddOffset(0, tidTargetNameOffset.Value, 0);
		}

		// Token: 0x06026095 RID: 155797 RVA: 0x005364FB File Offset: 0x005346FB
		public static Offset<IMarkMainStateTextTarget> EndIMarkMainStateTextTarget(FlatBufferBuilder builder)
		{
			return new Offset<IMarkMainStateTextTarget>(builder.EndTable());
		}

		// Token: 0x06026096 RID: 155798 RVA: 0x00536508 File Offset: 0x00534708
		public IMarkMainStateTextTargetT UnPack()
		{
			IMarkMainStateTextTargetT markMainStateTextTargetT = new IMarkMainStateTextTargetT();
			this.UnPackTo(markMainStateTextTargetT);
			return markMainStateTextTargetT;
		}

		// Token: 0x06026097 RID: 155799 RVA: 0x00536523 File Offset: 0x00534723
		public void UnPackTo(IMarkMainStateTextTargetT _o)
		{
			_o.TidTargetName = this.TidTargetName;
		}

		// Token: 0x06026098 RID: 155800 RVA: 0x00536534 File Offset: 0x00534734
		public static Offset<IMarkMainStateTextTarget> Pack(FlatBufferBuilder builder, IMarkMainStateTextTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMarkMainStateTextTarget>);
			}
			StringOffset tidTargetNameOffset = (_o.TidTargetName == null) ? default(StringOffset) : builder.CreateString(_o.TidTargetName);
			return IMarkMainStateTextTarget.CreateIMarkMainStateTextTarget(builder, tidTargetNameOffset);
		}

		// Token: 0x0400F442 RID: 62530
		private Table __p;
	}
}
