using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009B1 RID: 2481
	[NetMessage(EMessageId.MatchTeamStateNotify)]
	public sealed class MatchTeamStateNotify : IMessage<MatchTeamStateNotify>, IMessage, IEquatable<MatchTeamStateNotify>, IDeepCloneable<MatchTeamStateNotify>, IBufferMessage
	{
		// Token: 0x0600DA19 RID: 55833 RVA: 0x0020105C File Offset: 0x001FF25C
		[NullableContext(1)]
		public static MatchTeamStateNotify Create()
		{
			return new MatchTeamStateNotify();
		}

		// Token: 0x17002C30 RID: 11312
		// (get) Token: 0x0600DA1A RID: 55834 RVA: 0x00201063 File Offset: 0x001FF263
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C31 RID: 11313
		// (get) Token: 0x0600DA1B RID: 55835 RVA: 0x00201066 File Offset: 0x001FF266
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchTeamStateNotify.Descriptor;
			}
		}

		// Token: 0x0600DA1C RID: 55836 RVA: 0x0020106D File Offset: 0x001FF26D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchTeamStateNotify()
		{
		}

		// Token: 0x0600DA1D RID: 55837 RVA: 0x00201075 File Offset: 0x001FF275
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchTeamStateNotify(MatchTeamStateNotify other) : this()
		{
			this.teamState_ = other.teamState_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DA1E RID: 55838 RVA: 0x0020109A File Offset: 0x001FF29A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchTeamStateNotify Clone()
		{
			return new MatchTeamStateNotify(this);
		}

		// Token: 0x17002C32 RID: 11314
		// (get) Token: 0x0600DA1F RID: 55839 RVA: 0x002010A2 File Offset: 0x001FF2A2
		// (set) Token: 0x0600DA20 RID: 55840 RVA: 0x002010AA File Offset: 0x001FF2AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchTeamState TeamState
		{
			get
			{
				return this.teamState_;
			}
			set
			{
				this.teamState_ = value;
			}
		}

		// Token: 0x0600DA21 RID: 55841 RVA: 0x002010B3 File Offset: 0x001FF2B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchTeamStateNotify);
		}

		// Token: 0x0600DA22 RID: 55842 RVA: 0x002010C1 File Offset: 0x001FF2C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchTeamStateNotify other)
		{
			return other != null && (other == this || (this.TeamState == other.TeamState && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DA23 RID: 55843 RVA: 0x002010F0 File Offset: 0x001FF2F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TeamState != MatchTeamState.WaiteConfirm)
			{
				num ^= this.TeamState.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DA24 RID: 55844 RVA: 0x00201135 File Offset: 0x001FF335
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DA25 RID: 55845 RVA: 0x00201142 File Offset: 0x001FF342
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DA26 RID: 55846 RVA: 0x0020114B File Offset: 0x001FF34B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TeamState != MatchTeamState.WaiteConfirm)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.TeamState);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DA27 RID: 55847 RVA: 0x00201180 File Offset: 0x001FF380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TeamState != MatchTeamState.WaiteConfirm)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.TeamState);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DA28 RID: 55848 RVA: 0x002011BE File Offset: 0x001FF3BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MatchTeamStateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TeamState != MatchTeamState.WaiteConfirm)
			{
				this.TeamState = other.TeamState;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DA29 RID: 55849 RVA: 0x002011EF File Offset: 0x001FF3EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DA2A RID: 55850 RVA: 0x002011F8 File Offset: 0x001FF3F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TeamState = (MatchTeamState)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005B0A RID: 23306
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B0B RID: 23307
		public const int TeamStateFieldNumber = 8;

		// Token: 0x04005B0C RID: 23308
		private MatchTeamState teamState_;
	}
}
