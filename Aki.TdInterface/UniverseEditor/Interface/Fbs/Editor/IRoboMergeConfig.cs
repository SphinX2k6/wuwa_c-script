using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D06 RID: 19718
	public struct IRoboMergeConfig : IFlatbufferObject
	{
		// Token: 0x17008D1D RID: 36125
		// (get) Token: 0x0601E839 RID: 124985 RVA: 0x00445CF8 File Offset: 0x00443EF8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E83A RID: 124986 RVA: 0x00445D05 File Offset: 0x00443F05
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E83B RID: 124987 RVA: 0x00445D0C File Offset: 0x00443F0C
		public static IRoboMergeConfig GetRootAsIRoboMergeConfig(ByteBuffer _bb)
		{
			return IRoboMergeConfig.GetRootAsIRoboMergeConfig(_bb, default(IRoboMergeConfig));
		}

		// Token: 0x0601E83C RID: 124988 RVA: 0x00445D28 File Offset: 0x00443F28
		public static IRoboMergeConfig GetRootAsIRoboMergeConfig(ByteBuffer _bb, IRoboMergeConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E83D RID: 124989 RVA: 0x00445D45 File Offset: 0x00443F45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E83E RID: 124990 RVA: 0x00445D54 File Offset: 0x00443F54
		public IRoboMergeConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008D1E RID: 36126
		// (get) Token: 0x0601E83F RID: 124991 RVA: 0x00445D64 File Offset: 0x00443F64
		public string WorkspaceBranch
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

		// Token: 0x0601E840 RID: 124992 RVA: 0x00445D9B File Offset: 0x00443F9B
		public Span<byte> GetWorkspaceBranchBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601E841 RID: 124993 RVA: 0x00445DAA File Offset: 0x00443FAA
		public byte[] GetWorkspaceBranchArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0601E842 RID: 124994 RVA: 0x00445DB8 File Offset: 0x00443FB8
		public static Offset<IRoboMergeConfig> CreateIRoboMergeConfig(FlatBufferBuilder builder, StringOffset WorkspaceBranchOffset = default(StringOffset))
		{
			builder.StartTable(1);
			IRoboMergeConfig.AddWorkspaceBranch(builder, WorkspaceBranchOffset);
			return IRoboMergeConfig.EndIRoboMergeConfig(builder);
		}

		// Token: 0x0601E843 RID: 124995 RVA: 0x00445DCE File Offset: 0x00443FCE
		public static void StartIRoboMergeConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601E844 RID: 124996 RVA: 0x00445DD7 File Offset: 0x00443FD7
		public static void AddWorkspaceBranch(FlatBufferBuilder builder, StringOffset workspaceBranchOffset)
		{
			builder.AddOffset(0, workspaceBranchOffset.Value, 0);
		}

		// Token: 0x0601E845 RID: 124997 RVA: 0x00445DE7 File Offset: 0x00443FE7
		public static Offset<IRoboMergeConfig> EndIRoboMergeConfig(FlatBufferBuilder builder)
		{
			return new Offset<IRoboMergeConfig>(builder.EndTable());
		}

		// Token: 0x0601E846 RID: 124998 RVA: 0x00445DF4 File Offset: 0x00443FF4
		public IRoboMergeConfigT UnPack()
		{
			IRoboMergeConfigT roboMergeConfigT = new IRoboMergeConfigT();
			this.UnPackTo(roboMergeConfigT);
			return roboMergeConfigT;
		}

		// Token: 0x0601E847 RID: 124999 RVA: 0x00445E0F File Offset: 0x0044400F
		public void UnPackTo(IRoboMergeConfigT _o)
		{
			_o.WorkspaceBranch = this.WorkspaceBranch;
		}

		// Token: 0x0601E848 RID: 125000 RVA: 0x00445E20 File Offset: 0x00444020
		public static Offset<IRoboMergeConfig> Pack(FlatBufferBuilder builder, IRoboMergeConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoboMergeConfig>);
			}
			StringOffset workspaceBranchOffset = (_o.WorkspaceBranch == null) ? default(StringOffset) : builder.CreateString(_o.WorkspaceBranch);
			return IRoboMergeConfig.CreateIRoboMergeConfig(builder, workspaceBranchOffset);
		}

		// Token: 0x0400D8C7 RID: 55495
		private Table __p;
	}
}
