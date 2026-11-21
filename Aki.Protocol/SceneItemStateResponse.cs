using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011B2 RID: 4530
	[NetMessage(EMessageId.SceneItemStateResponse)]
	public sealed class SceneItemStateResponse : IMessage<SceneItemStateResponse>, IMessage, IEquatable<SceneItemStateResponse>, IDeepCloneable<SceneItemStateResponse>, IBufferMessage
	{
		// Token: 0x0601830C RID: 99084 RVA: 0x003859D0 File Offset: 0x00383BD0
		[NullableContext(1)]
		public static SceneItemStateResponse Create()
		{
			return new SceneItemStateResponse();
		}

		// Token: 0x17005180 RID: 20864
		// (get) Token: 0x0601830D RID: 99085 RVA: 0x003859D7 File Offset: 0x00383BD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005181 RID: 20865
		// (get) Token: 0x0601830E RID: 99086 RVA: 0x003859DA File Offset: 0x00383BDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemStateResponse.Descriptor;
			}
		}

		// Token: 0x0601830F RID: 99087 RVA: 0x003859E1 File Offset: 0x00383BE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemStateResponse()
		{
		}

		// Token: 0x06018310 RID: 99088 RVA: 0x003859E9 File Offset: 0x00383BE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemStateResponse(SceneItemStateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018311 RID: 99089 RVA: 0x00385A0E File Offset: 0x00383C0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemStateResponse Clone()
		{
			return new SceneItemStateResponse(this);
		}

		// Token: 0x17005182 RID: 20866
		// (get) Token: 0x06018312 RID: 99090 RVA: 0x00385A16 File Offset: 0x00383C16
		// (set) Token: 0x06018313 RID: 99091 RVA: 0x00385A1E File Offset: 0x00383C1E
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

		// Token: 0x06018314 RID: 99092 RVA: 0x00385A27 File Offset: 0x00383C27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemStateResponse);
		}

		// Token: 0x06018315 RID: 99093 RVA: 0x00385A35 File Offset: 0x00383C35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemStateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018316 RID: 99094 RVA: 0x00385A64 File Offset: 0x00383C64
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

		// Token: 0x06018317 RID: 99095 RVA: 0x00385AA9 File Offset: 0x00383CA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018318 RID: 99096 RVA: 0x00385AB6 File Offset: 0x00383CB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018319 RID: 99097 RVA: 0x00385ABF File Offset: 0x00383CBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601831A RID: 99098 RVA: 0x00385AF4 File Offset: 0x00383CF4
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

		// Token: 0x0601831B RID: 99099 RVA: 0x00385B32 File Offset: 0x00383D32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneItemStateResponse other)
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

		// Token: 0x0601831C RID: 99100 RVA: 0x00385B63 File Offset: 0x00383D63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601831D RID: 99101 RVA: 0x00385B6C File Offset: 0x00383D6C
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008FE8 RID: 36840
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008FE9 RID: 36841
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04008FEA RID: 36842
		private ErrorCode errorCode_;
	}
}
