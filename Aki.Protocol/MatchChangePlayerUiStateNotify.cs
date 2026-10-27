using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009AD RID: 2477
	[NetMessage(EMessageId.MatchChangePlayerUiStateNotify)]
	public sealed class MatchChangePlayerUiStateNotify : IMessage<MatchChangePlayerUiStateNotify>, IMessage, IEquatable<MatchChangePlayerUiStateNotify>, IDeepCloneable<MatchChangePlayerUiStateNotify>, IBufferMessage
	{
		// Token: 0x0600D979 RID: 55673 RVA: 0x001FF309 File Offset: 0x001FD509
		[NullableContext(1)]
		public static MatchChangePlayerUiStateNotify Create()
		{
			return new MatchChangePlayerUiStateNotify();
		}

		// Token: 0x17002C0D RID: 11277
		// (get) Token: 0x0600D97A RID: 55674 RVA: 0x001FF310 File Offset: 0x001FD510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C0E RID: 11278
		// (get) Token: 0x0600D97B RID: 55675 RVA: 0x001FF313 File Offset: 0x001FD513
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchChangePlayerUiStateNotify.Descriptor;
			}
		}

		// Token: 0x0600D97C RID: 55676 RVA: 0x001FF31A File Offset: 0x001FD51A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchChangePlayerUiStateNotify()
		{
		}

		// Token: 0x0600D97D RID: 55677 RVA: 0x001FF322 File Offset: 0x001FD522
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchChangePlayerUiStateNotify(MatchChangePlayerUiStateNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.matchUiState_ = other.matchUiState_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D97E RID: 55678 RVA: 0x001FF353 File Offset: 0x001FD553
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchChangePlayerUiStateNotify Clone()
		{
			return new MatchChangePlayerUiStateNotify(this);
		}

		// Token: 0x17002C0F RID: 11279
		// (get) Token: 0x0600D97F RID: 55679 RVA: 0x001FF35B File Offset: 0x001FD55B
		// (set) Token: 0x0600D980 RID: 55680 RVA: 0x001FF363 File Offset: 0x001FD563
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x17002C10 RID: 11280
		// (get) Token: 0x0600D981 RID: 55681 RVA: 0x001FF36C File Offset: 0x001FD56C
		// (set) Token: 0x0600D982 RID: 55682 RVA: 0x001FF374 File Offset: 0x001FD574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EMatchPlayerUiState MatchUiState
		{
			get
			{
				return this.matchUiState_;
			}
			set
			{
				this.matchUiState_ = value;
			}
		}

		// Token: 0x0600D983 RID: 55683 RVA: 0x001FF37D File Offset: 0x001FD57D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchChangePlayerUiStateNotify);
		}

		// Token: 0x0600D984 RID: 55684 RVA: 0x001FF38B File Offset: 0x001FD58B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchChangePlayerUiStateNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.MatchUiState == other.MatchUiState && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D985 RID: 55685 RVA: 0x001FF3CC File Offset: 0x001FD5CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.MatchUiState != EMatchPlayerUiState.Wait)
			{
				num ^= this.MatchUiState.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D986 RID: 55686 RVA: 0x001FF42A File Offset: 0x001FD62A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D987 RID: 55687 RVA: 0x001FF437 File Offset: 0x001FD637
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D988 RID: 55688 RVA: 0x001FF440 File Offset: 0x001FD640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.PlayerId);
			}
			if (this.MatchUiState != EMatchPlayerUiState.Wait)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.MatchUiState);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D989 RID: 55689 RVA: 0x001FF49C File Offset: 0x001FD69C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.MatchUiState != EMatchPlayerUiState.Wait)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.MatchUiState);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D98A RID: 55690 RVA: 0x001FF4F4 File Offset: 0x001FD6F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MatchChangePlayerUiStateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.MatchUiState != EMatchPlayerUiState.Wait)
			{
				this.MatchUiState = other.MatchUiState;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D98B RID: 55691 RVA: 0x001FF544 File Offset: 0x001FD744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D98C RID: 55692 RVA: 0x001FF550 File Offset: 0x001FD750
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
				if (num != 40U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.MatchUiState = (EMatchPlayerUiState)input.ReadEnum();
					}
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005A7A RID: 23162
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A7B RID: 23163
		public const int PlayerIdFieldNumber = 5;

		// Token: 0x04005A7C RID: 23164
		private int playerId_;

		// Token: 0x04005A7D RID: 23165
		public const int MatchUiStateFieldNumber = 10;

		// Token: 0x04005A7E RID: 23166
		private EMatchPlayerUiState matchUiState_;
	}
}
