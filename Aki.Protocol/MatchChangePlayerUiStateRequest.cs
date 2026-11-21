using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200099D RID: 2461
	[NetMessage(EMessageId.MatchChangePlayerUiStateRequest)]
	public sealed class MatchChangePlayerUiStateRequest : IMessage<MatchChangePlayerUiStateRequest>, IMessage, IEquatable<MatchChangePlayerUiStateRequest>, IDeepCloneable<MatchChangePlayerUiStateRequest>, IBufferMessage
	{
		// Token: 0x0600D873 RID: 55411 RVA: 0x001FD3B4 File Offset: 0x001FB5B4
		[NullableContext(1)]
		public static MatchChangePlayerUiStateRequest Create()
		{
			return new MatchChangePlayerUiStateRequest();
		}

		// Token: 0x17002BD3 RID: 11219
		// (get) Token: 0x0600D874 RID: 55412 RVA: 0x001FD3BB File Offset: 0x001FB5BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002BD4 RID: 11220
		// (get) Token: 0x0600D875 RID: 55413 RVA: 0x001FD3BE File Offset: 0x001FB5BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchChangePlayerUiStateRequest.Descriptor;
			}
		}

		// Token: 0x0600D876 RID: 55414 RVA: 0x001FD3C5 File Offset: 0x001FB5C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchChangePlayerUiStateRequest()
		{
		}

		// Token: 0x0600D877 RID: 55415 RVA: 0x001FD3CD File Offset: 0x001FB5CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchChangePlayerUiStateRequest(MatchChangePlayerUiStateRequest other) : this()
		{
			this.matchUiState_ = other.matchUiState_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D878 RID: 55416 RVA: 0x001FD3F2 File Offset: 0x001FB5F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchChangePlayerUiStateRequest Clone()
		{
			return new MatchChangePlayerUiStateRequest(this);
		}

		// Token: 0x17002BD5 RID: 11221
		// (get) Token: 0x0600D879 RID: 55417 RVA: 0x001FD3FA File Offset: 0x001FB5FA
		// (set) Token: 0x0600D87A RID: 55418 RVA: 0x001FD402 File Offset: 0x001FB602
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

		// Token: 0x0600D87B RID: 55419 RVA: 0x001FD40B File Offset: 0x001FB60B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchChangePlayerUiStateRequest);
		}

		// Token: 0x0600D87C RID: 55420 RVA: 0x001FD419 File Offset: 0x001FB619
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchChangePlayerUiStateRequest other)
		{
			return other != null && (other == this || (this.MatchUiState == other.MatchUiState && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D87D RID: 55421 RVA: 0x001FD448 File Offset: 0x001FB648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0600D87E RID: 55422 RVA: 0x001FD48D File Offset: 0x001FB68D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D87F RID: 55423 RVA: 0x001FD49A File Offset: 0x001FB69A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D880 RID: 55424 RVA: 0x001FD4A3 File Offset: 0x001FB6A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MatchUiState != EMatchPlayerUiState.Wait)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.MatchUiState);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D881 RID: 55425 RVA: 0x001FD4D8 File Offset: 0x001FB6D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0600D882 RID: 55426 RVA: 0x001FD516 File Offset: 0x001FB716
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MatchChangePlayerUiStateRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MatchUiState != EMatchPlayerUiState.Wait)
			{
				this.MatchUiState = other.MatchUiState;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D883 RID: 55427 RVA: 0x001FD547 File Offset: 0x001FB747
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D884 RID: 55428 RVA: 0x001FD550 File Offset: 0x001FB750
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.MatchUiState = (EMatchPlayerUiState)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005A88 RID: 23176
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A89 RID: 23177
		public const int MatchUiStateFieldNumber = 11;

		// Token: 0x04005A8A RID: 23178
		private EMatchPlayerUiState matchUiState_;
	}
}
