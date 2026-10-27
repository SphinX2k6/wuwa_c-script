using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009AE RID: 2478
	[NetMessage(EMessageId.MatchChangePlayerUiStateRequest)]
	public sealed class MatchChangePlayerUiStateRequest : IMessage<MatchChangePlayerUiStateRequest>, IMessage, IEquatable<MatchChangePlayerUiStateRequest>, IDeepCloneable<MatchChangePlayerUiStateRequest>, IBufferMessage
	{
		// Token: 0x0600D98D RID: 55693 RVA: 0x001FF5A8 File Offset: 0x001FD7A8
		[NullableContext(1)]
		public static MatchChangePlayerUiStateRequest Create()
		{
			return new MatchChangePlayerUiStateRequest();
		}

		// Token: 0x17002C11 RID: 11281
		// (get) Token: 0x0600D98E RID: 55694 RVA: 0x001FF5AF File Offset: 0x001FD7AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C12 RID: 11282
		// (get) Token: 0x0600D98F RID: 55695 RVA: 0x001FF5B2 File Offset: 0x001FD7B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchChangePlayerUiStateRequest.Descriptor;
			}
		}

		// Token: 0x0600D990 RID: 55696 RVA: 0x001FF5B9 File Offset: 0x001FD7B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchChangePlayerUiStateRequest()
		{
		}

		// Token: 0x0600D991 RID: 55697 RVA: 0x001FF5C1 File Offset: 0x001FD7C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchChangePlayerUiStateRequest(MatchChangePlayerUiStateRequest other) : this()
		{
			this.matchUiState_ = other.matchUiState_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D992 RID: 55698 RVA: 0x001FF5E6 File Offset: 0x001FD7E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchChangePlayerUiStateRequest Clone()
		{
			return new MatchChangePlayerUiStateRequest(this);
		}

		// Token: 0x17002C13 RID: 11283
		// (get) Token: 0x0600D993 RID: 55699 RVA: 0x001FF5EE File Offset: 0x001FD7EE
		// (set) Token: 0x0600D994 RID: 55700 RVA: 0x001FF5F6 File Offset: 0x001FD7F6
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

		// Token: 0x0600D995 RID: 55701 RVA: 0x001FF5FF File Offset: 0x001FD7FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchChangePlayerUiStateRequest);
		}

		// Token: 0x0600D996 RID: 55702 RVA: 0x001FF60D File Offset: 0x001FD80D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchChangePlayerUiStateRequest other)
		{
			return other != null && (other == this || (this.MatchUiState == other.MatchUiState && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D997 RID: 55703 RVA: 0x001FF63C File Offset: 0x001FD83C
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

		// Token: 0x0600D998 RID: 55704 RVA: 0x001FF681 File Offset: 0x001FD881
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D999 RID: 55705 RVA: 0x001FF68E File Offset: 0x001FD88E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D99A RID: 55706 RVA: 0x001FF697 File Offset: 0x001FD897
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MatchUiState != EMatchPlayerUiState.Wait)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.MatchUiState);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D99B RID: 55707 RVA: 0x001FF6C8 File Offset: 0x001FD8C8
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

		// Token: 0x0600D99C RID: 55708 RVA: 0x001FF706 File Offset: 0x001FD906
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

		// Token: 0x0600D99D RID: 55709 RVA: 0x001FF737 File Offset: 0x001FD937
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D99E RID: 55710 RVA: 0x001FF740 File Offset: 0x001FD940
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.MatchUiState = (EMatchPlayerUiState)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005A7F RID: 23167
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A80 RID: 23168
		public const int MatchUiStateFieldNumber = 1;

		// Token: 0x04005A81 RID: 23169
		private EMatchPlayerUiState matchUiState_;
	}
}
