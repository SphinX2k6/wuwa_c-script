using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048A1 RID: 18593
	public struct IRoboMergeConfig : IFlatbufferObject
	{
		// Token: 0x170086D5 RID: 34517
		// (get) Token: 0x0601D04C RID: 118860 RVA: 0x0041955C File Offset: 0x0041775C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D04D RID: 118861 RVA: 0x00419569 File Offset: 0x00417769
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D04E RID: 118862 RVA: 0x00419570 File Offset: 0x00417770
		public static IRoboMergeConfig GetRootAsIRoboMergeConfig(ByteBuffer _bb)
		{
			return IRoboMergeConfig.GetRootAsIRoboMergeConfig(_bb, default(IRoboMergeConfig));
		}

		// Token: 0x0601D04F RID: 118863 RVA: 0x0041958C File Offset: 0x0041778C
		public static IRoboMergeConfig GetRootAsIRoboMergeConfig(ByteBuffer _bb, IRoboMergeConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D050 RID: 118864 RVA: 0x004195A9 File Offset: 0x004177A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D051 RID: 118865 RVA: 0x004195B8 File Offset: 0x004177B8
		public IRoboMergeConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170086D6 RID: 34518
		// (get) Token: 0x0601D052 RID: 118866 RVA: 0x004195C8 File Offset: 0x004177C8
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

		// Token: 0x0601D053 RID: 118867 RVA: 0x004195FF File Offset: 0x004177FF
		public Span<byte> GetWorkspaceBranchBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601D054 RID: 118868 RVA: 0x0041960E File Offset: 0x0041780E
		public byte[] GetWorkspaceBranchArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0601D055 RID: 118869 RVA: 0x0041961C File Offset: 0x0041781C
		public static Offset<IRoboMergeConfig> CreateIRoboMergeConfig(FlatBufferBuilder builder, StringOffset WorkspaceBranchOffset = default(StringOffset))
		{
			builder.StartTable(1);
			IRoboMergeConfig.AddWorkspaceBranch(builder, WorkspaceBranchOffset);
			return IRoboMergeConfig.EndIRoboMergeConfig(builder);
		}

		// Token: 0x0601D056 RID: 118870 RVA: 0x00419632 File Offset: 0x00417832
		public static void StartIRoboMergeConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601D057 RID: 118871 RVA: 0x0041963B File Offset: 0x0041783B
		public static void AddWorkspaceBranch(FlatBufferBuilder builder, StringOffset workspaceBranchOffset)
		{
			builder.AddOffset(0, workspaceBranchOffset.Value, 0);
		}

		// Token: 0x0601D058 RID: 118872 RVA: 0x0041964B File Offset: 0x0041784B
		public static Offset<IRoboMergeConfig> EndIRoboMergeConfig(FlatBufferBuilder builder)
		{
			return new Offset<IRoboMergeConfig>(builder.EndTable());
		}

		// Token: 0x0601D059 RID: 118873 RVA: 0x00419658 File Offset: 0x00417858
		public IRoboMergeConfigT UnPack()
		{
			IRoboMergeConfigT roboMergeConfigT = new IRoboMergeConfigT();
			this.UnPackTo(roboMergeConfigT);
			return roboMergeConfigT;
		}

		// Token: 0x0601D05A RID: 118874 RVA: 0x00419673 File Offset: 0x00417873
		public void UnPackTo(IRoboMergeConfigT _o)
		{
			_o.WorkspaceBranch = this.WorkspaceBranch;
		}

		// Token: 0x0601D05B RID: 118875 RVA: 0x00419684 File Offset: 0x00417884
		public static Offset<IRoboMergeConfig> Pack(FlatBufferBuilder builder, IRoboMergeConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoboMergeConfig>);
			}
			StringOffset workspaceBranchOffset = (_o.WorkspaceBranch == null) ? default(StringOffset) : builder.CreateString(_o.WorkspaceBranch);
			return IRoboMergeConfig.CreateIRoboMergeConfig(builder, workspaceBranchOffset);
		}

		// Token: 0x0400CE8E RID: 52878
		private Table __p;
	}
}
