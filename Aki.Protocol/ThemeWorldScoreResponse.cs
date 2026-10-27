using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200135D RID: 4957
	[NetMessage(EMessageId.ThemeWorldScoreResponse)]
	public sealed class ThemeWorldScoreResponse : IMessage<ThemeWorldScoreResponse>, IMessage, IEquatable<ThemeWorldScoreResponse>, IDeepCloneable<ThemeWorldScoreResponse>, IBufferMessage
	{
		// Token: 0x0601A551 RID: 107857 RVA: 0x003D33AD File Offset: 0x003D15AD
		[NullableContext(1)]
		public static ThemeWorldScoreResponse Create()
		{
			return new ThemeWorldScoreResponse();
		}

		// Token: 0x170058D8 RID: 22744
		// (get) Token: 0x0601A552 RID: 107858 RVA: 0x003D33B4 File Offset: 0x003D15B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170058D9 RID: 22745
		// (get) Token: 0x0601A553 RID: 107859 RVA: 0x003D33B7 File Offset: 0x003D15B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ThemeWorldScoreResponse.Descriptor;
			}
		}

		// Token: 0x0601A554 RID: 107860 RVA: 0x003D33BE File Offset: 0x003D15BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThemeWorldScoreResponse()
		{
		}

		// Token: 0x0601A555 RID: 107861 RVA: 0x003D33C6 File Offset: 0x003D15C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThemeWorldScoreResponse(ThemeWorldScoreResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A556 RID: 107862 RVA: 0x003D33EB File Offset: 0x003D15EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThemeWorldScoreResponse Clone()
		{
			return new ThemeWorldScoreResponse(this);
		}

		// Token: 0x170058DA RID: 22746
		// (get) Token: 0x0601A557 RID: 107863 RVA: 0x003D33F3 File Offset: 0x003D15F3
		// (set) Token: 0x0601A558 RID: 107864 RVA: 0x003D33FB File Offset: 0x003D15FB
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

		// Token: 0x0601A559 RID: 107865 RVA: 0x003D3404 File Offset: 0x003D1604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ThemeWorldScoreResponse);
		}

		// Token: 0x0601A55A RID: 107866 RVA: 0x003D3412 File Offset: 0x003D1612
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ThemeWorldScoreResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A55B RID: 107867 RVA: 0x003D3440 File Offset: 0x003D1640
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

		// Token: 0x0601A55C RID: 107868 RVA: 0x003D3485 File Offset: 0x003D1685
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A55D RID: 107869 RVA: 0x003D3492 File Offset: 0x003D1692
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A55E RID: 107870 RVA: 0x003D349B File Offset: 0x003D169B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A55F RID: 107871 RVA: 0x003D34D0 File Offset: 0x003D16D0
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

		// Token: 0x0601A560 RID: 107872 RVA: 0x003D350E File Offset: 0x003D170E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ThemeWorldScoreResponse other)
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

		// Token: 0x0601A561 RID: 107873 RVA: 0x003D353F File Offset: 0x003D173F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A562 RID: 107874 RVA: 0x003D3548 File Offset: 0x003D1748
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009982 RID: 39298
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009983 RID: 39299
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04009984 RID: 39300
		private ErrorCode errorCode_;
	}
}
