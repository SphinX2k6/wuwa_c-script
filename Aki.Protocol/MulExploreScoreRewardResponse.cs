using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ADB RID: 2779
	[NetMessage(EMessageId.MulExploreScoreRewardResponse)]
	public sealed class MulExploreScoreRewardResponse : IMessage<MulExploreScoreRewardResponse>, IMessage, IEquatable<MulExploreScoreRewardResponse>, IDeepCloneable<MulExploreScoreRewardResponse>, IBufferMessage
	{
		// Token: 0x0600F1D3 RID: 61907 RVA: 0x00235223 File Offset: 0x00233423
		[NullableContext(1)]
		public static MulExploreScoreRewardResponse Create()
		{
			return new MulExploreScoreRewardResponse();
		}

		// Token: 0x1700313F RID: 12607
		// (get) Token: 0x0600F1D4 RID: 61908 RVA: 0x0023522A File Offset: 0x0023342A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003140 RID: 12608
		// (get) Token: 0x0600F1D5 RID: 61909 RVA: 0x0023522D File Offset: 0x0023342D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MulExploreScoreRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600F1D6 RID: 61910 RVA: 0x00235234 File Offset: 0x00233434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulExploreScoreRewardResponse()
		{
		}

		// Token: 0x0600F1D7 RID: 61911 RVA: 0x0023523C File Offset: 0x0023343C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulExploreScoreRewardResponse(MulExploreScoreRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F1D8 RID: 61912 RVA: 0x00235261 File Offset: 0x00233461
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulExploreScoreRewardResponse Clone()
		{
			return new MulExploreScoreRewardResponse(this);
		}

		// Token: 0x17003141 RID: 12609
		// (get) Token: 0x0600F1D9 RID: 61913 RVA: 0x00235269 File Offset: 0x00233469
		// (set) Token: 0x0600F1DA RID: 61914 RVA: 0x00235271 File Offset: 0x00233471
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x0600F1DB RID: 61915 RVA: 0x0023527A File Offset: 0x0023347A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MulExploreScoreRewardResponse);
		}

		// Token: 0x0600F1DC RID: 61916 RVA: 0x00235288 File Offset: 0x00233488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MulExploreScoreRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F1DD RID: 61917 RVA: 0x002352B8 File Offset: 0x002334B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F1DE RID: 61918 RVA: 0x002352FD File Offset: 0x002334FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F1DF RID: 61919 RVA: 0x0023530A File Offset: 0x0023350A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F1E0 RID: 61920 RVA: 0x00235313 File Offset: 0x00233513
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F1E1 RID: 61921 RVA: 0x00235348 File Offset: 0x00233548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F1E2 RID: 61922 RVA: 0x00235386 File Offset: 0x00233586
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MulExploreScoreRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F1E3 RID: 61923 RVA: 0x002353B7 File Offset: 0x002335B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F1E4 RID: 61924 RVA: 0x002353C0 File Offset: 0x002335C0
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040061A5 RID: 24997
		private UnknownFieldSet _unknownFields;

		// Token: 0x040061A6 RID: 24998
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x040061A7 RID: 24999
		private ErrorCode errorCode_;
	}
}
