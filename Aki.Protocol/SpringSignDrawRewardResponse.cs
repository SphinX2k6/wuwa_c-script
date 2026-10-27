using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200127E RID: 4734
	[NetMessage(EMessageId.SpringSignDrawRewardResponse)]
	public sealed class SpringSignDrawRewardResponse : IMessage<SpringSignDrawRewardResponse>, IMessage, IEquatable<SpringSignDrawRewardResponse>, IDeepCloneable<SpringSignDrawRewardResponse>, IBufferMessage
	{
		// Token: 0x06019374 RID: 103284 RVA: 0x003AB305 File Offset: 0x003A9505
		[NullableContext(1)]
		public static SpringSignDrawRewardResponse Create()
		{
			return new SpringSignDrawRewardResponse();
		}

		// Token: 0x17005513 RID: 21779
		// (get) Token: 0x06019375 RID: 103285 RVA: 0x003AB30C File Offset: 0x003A950C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005514 RID: 21780
		// (get) Token: 0x06019376 RID: 103286 RVA: 0x003AB30F File Offset: 0x003A950F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpringSignDrawRewardResponse.Descriptor;
			}
		}

		// Token: 0x06019377 RID: 103287 RVA: 0x003AB316 File Offset: 0x003A9516
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringSignDrawRewardResponse()
		{
		}

		// Token: 0x06019378 RID: 103288 RVA: 0x003AB31E File Offset: 0x003A951E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringSignDrawRewardResponse(SpringSignDrawRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019379 RID: 103289 RVA: 0x003AB343 File Offset: 0x003A9543
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringSignDrawRewardResponse Clone()
		{
			return new SpringSignDrawRewardResponse(this);
		}

		// Token: 0x17005515 RID: 21781
		// (get) Token: 0x0601937A RID: 103290 RVA: 0x003AB34B File Offset: 0x003A954B
		// (set) Token: 0x0601937B RID: 103291 RVA: 0x003AB353 File Offset: 0x003A9553
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

		// Token: 0x0601937C RID: 103292 RVA: 0x003AB35C File Offset: 0x003A955C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpringSignDrawRewardResponse);
		}

		// Token: 0x0601937D RID: 103293 RVA: 0x003AB36A File Offset: 0x003A956A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpringSignDrawRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601937E RID: 103294 RVA: 0x003AB398 File Offset: 0x003A9598
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

		// Token: 0x0601937F RID: 103295 RVA: 0x003AB3DD File Offset: 0x003A95DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019380 RID: 103296 RVA: 0x003AB3EA File Offset: 0x003A95EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019381 RID: 103297 RVA: 0x003AB3F3 File Offset: 0x003A95F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019382 RID: 103298 RVA: 0x003AB428 File Offset: 0x003A9628
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

		// Token: 0x06019383 RID: 103299 RVA: 0x003AB466 File Offset: 0x003A9666
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpringSignDrawRewardResponse other)
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

		// Token: 0x06019384 RID: 103300 RVA: 0x003AB497 File Offset: 0x003A9697
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019385 RID: 103301 RVA: 0x003AB4A0 File Offset: 0x003A96A0
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009465 RID: 37989
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009466 RID: 37990
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04009467 RID: 37991
		private ErrorCode errorCode_;
	}
}
