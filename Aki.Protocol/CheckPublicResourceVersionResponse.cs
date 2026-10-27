using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000285 RID: 645
	[NetMessage(EMessageId.CheckPublicResourceVersionResponse)]
	public sealed class CheckPublicResourceVersionResponse : IMessage<CheckPublicResourceVersionResponse>, IMessage, IEquatable<CheckPublicResourceVersionResponse>, IDeepCloneable<CheckPublicResourceVersionResponse>, IBufferMessage
	{
		// Token: 0x0600437A RID: 17274 RVA: 0x000A5674 File Offset: 0x000A3874
		[NullableContext(1)]
		public static CheckPublicResourceVersionResponse Create()
		{
			return new CheckPublicResourceVersionResponse();
		}

		// Token: 0x17000B80 RID: 2944
		// (get) Token: 0x0600437B RID: 17275 RVA: 0x000A567B File Offset: 0x000A387B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B81 RID: 2945
		// (get) Token: 0x0600437C RID: 17276 RVA: 0x000A567E File Offset: 0x000A387E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CheckPublicResourceVersionResponse.Descriptor;
			}
		}

		// Token: 0x0600437D RID: 17277 RVA: 0x000A5685 File Offset: 0x000A3885
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CheckPublicResourceVersionResponse()
		{
		}

		// Token: 0x0600437E RID: 17278 RVA: 0x000A568D File Offset: 0x000A388D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CheckPublicResourceVersionResponse(CheckPublicResourceVersionResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this.tipLevel_ = other.tipLevel_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600437F RID: 17279 RVA: 0x000A56BE File Offset: 0x000A38BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CheckPublicResourceVersionResponse Clone()
		{
			return new CheckPublicResourceVersionResponse(this);
		}

		// Token: 0x17000B82 RID: 2946
		// (get) Token: 0x06004380 RID: 17280 RVA: 0x000A56C6 File Offset: 0x000A38C6
		// (set) Token: 0x06004381 RID: 17281 RVA: 0x000A56CE File Offset: 0x000A38CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorId
		{
			get
			{
				return this.errorId_;
			}
			set
			{
				this.errorId_ = value;
			}
		}

		// Token: 0x17000B83 RID: 2947
		// (get) Token: 0x06004382 RID: 17282 RVA: 0x000A56D7 File Offset: 0x000A38D7
		// (set) Token: 0x06004383 RID: 17283 RVA: 0x000A56DF File Offset: 0x000A38DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TipLevel
		{
			get
			{
				return this.tipLevel_;
			}
			set
			{
				this.tipLevel_ = value;
			}
		}

		// Token: 0x06004384 RID: 17284 RVA: 0x000A56E8 File Offset: 0x000A38E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CheckPublicResourceVersionResponse);
		}

		// Token: 0x06004385 RID: 17285 RVA: 0x000A56F6 File Offset: 0x000A38F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CheckPublicResourceVersionResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && this.TipLevel == other.TipLevel && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004386 RID: 17286 RVA: 0x000A5734 File Offset: 0x000A3934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorId != ErrorCode.Success)
			{
				num ^= this.ErrorId.GetHashCode();
			}
			if (this.TipLevel != 0)
			{
				num ^= this.TipLevel.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004387 RID: 17287 RVA: 0x000A5792 File Offset: 0x000A3992
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004388 RID: 17288 RVA: 0x000A579F File Offset: 0x000A399F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004389 RID: 17289 RVA: 0x000A57A8 File Offset: 0x000A39A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this.TipLevel != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.TipLevel);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600438A RID: 17290 RVA: 0x000A5804 File Offset: 0x000A3A04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorId != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorId);
			}
			if (this.TipLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TipLevel);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600438B RID: 17291 RVA: 0x000A585C File Offset: 0x000A3A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CheckPublicResourceVersionResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorId != ErrorCode.Success)
			{
				this.ErrorId = other.ErrorId;
			}
			if (other.TipLevel != 0)
			{
				this.TipLevel = other.TipLevel;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600438C RID: 17292 RVA: 0x000A58AC File Offset: 0x000A3AAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600438D RID: 17293 RVA: 0x000A58B8 File Offset: 0x000A3AB8
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
				if (num != 24U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.TipLevel = input.ReadInt32();
					}
				}
				else
				{
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002E56 RID: 11862
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E57 RID: 11863
		public const int ErrorIdFieldNumber = 3;

		// Token: 0x04002E58 RID: 11864
		private ErrorCode errorId_;

		// Token: 0x04002E59 RID: 11865
		public const int TipLevelFieldNumber = 12;

		// Token: 0x04002E5A RID: 11866
		private int tipLevel_;
	}
}
