using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000187 RID: 391
	[NetMessage(EMessageId.BeControlledDestroyResponse)]
	public sealed class BeControlledDestroyResponse : IMessage<BeControlledDestroyResponse>, IMessage, IEquatable<BeControlledDestroyResponse>, IDeepCloneable<BeControlledDestroyResponse>, IBufferMessage
	{
		// Token: 0x06002F0D RID: 12045 RVA: 0x00078C65 File Offset: 0x00076E65
		[NullableContext(1)]
		public static BeControlledDestroyResponse Create()
		{
			return new BeControlledDestroyResponse();
		}

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x06002F0E RID: 12046 RVA: 0x00078C6C File Offset: 0x00076E6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x06002F0F RID: 12047 RVA: 0x00078C6F File Offset: 0x00076E6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BeControlledDestroyResponse.Descriptor;
			}
		}

		// Token: 0x06002F10 RID: 12048 RVA: 0x00078C76 File Offset: 0x00076E76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledDestroyResponse()
		{
		}

		// Token: 0x06002F11 RID: 12049 RVA: 0x00078C7E File Offset: 0x00076E7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledDestroyResponse(BeControlledDestroyResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002F12 RID: 12050 RVA: 0x00078CA3 File Offset: 0x00076EA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledDestroyResponse Clone()
		{
			return new BeControlledDestroyResponse(this);
		}

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x06002F13 RID: 12051 RVA: 0x00078CAB File Offset: 0x00076EAB
		// (set) Token: 0x06002F14 RID: 12052 RVA: 0x00078CB3 File Offset: 0x00076EB3
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

		// Token: 0x06002F15 RID: 12053 RVA: 0x00078CBC File Offset: 0x00076EBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BeControlledDestroyResponse);
		}

		// Token: 0x06002F16 RID: 12054 RVA: 0x00078CCA File Offset: 0x00076ECA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BeControlledDestroyResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002F17 RID: 12055 RVA: 0x00078CF8 File Offset: 0x00076EF8
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

		// Token: 0x06002F18 RID: 12056 RVA: 0x00078D3D File Offset: 0x00076F3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002F19 RID: 12057 RVA: 0x00078D4A File Offset: 0x00076F4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002F1A RID: 12058 RVA: 0x00078D53 File Offset: 0x00076F53
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

		// Token: 0x06002F1B RID: 12059 RVA: 0x00078D88 File Offset: 0x00076F88
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

		// Token: 0x06002F1C RID: 12060 RVA: 0x00078DC6 File Offset: 0x00076FC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BeControlledDestroyResponse other)
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

		// Token: 0x06002F1D RID: 12061 RVA: 0x00078DF7 File Offset: 0x00076FF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002F1E RID: 12062 RVA: 0x00078E00 File Offset: 0x00077000
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

		// Token: 0x04002899 RID: 10393
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400289A RID: 10394
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x0400289B RID: 10395
		private ErrorCode errorCode_;
	}
}
