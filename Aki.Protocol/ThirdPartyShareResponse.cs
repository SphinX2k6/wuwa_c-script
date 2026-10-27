using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001360 RID: 4960
	[NetMessage(EMessageId.ThirdPartyShareResponse)]
	public sealed class ThirdPartyShareResponse : IMessage<ThirdPartyShareResponse>, IMessage, IEquatable<ThirdPartyShareResponse>, IDeepCloneable<ThirdPartyShareResponse>, IBufferMessage
	{
		// Token: 0x0601A587 RID: 107911 RVA: 0x003D3945 File Offset: 0x003D1B45
		[NullableContext(1)]
		public static ThirdPartyShareResponse Create()
		{
			return new ThirdPartyShareResponse();
		}

		// Token: 0x170058E1 RID: 22753
		// (get) Token: 0x0601A588 RID: 107912 RVA: 0x003D394C File Offset: 0x003D1B4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170058E2 RID: 22754
		// (get) Token: 0x0601A589 RID: 107913 RVA: 0x003D394F File Offset: 0x003D1B4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ThirdPartyShareResponse.Descriptor;
			}
		}

		// Token: 0x0601A58A RID: 107914 RVA: 0x003D3956 File Offset: 0x003D1B56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThirdPartyShareResponse()
		{
		}

		// Token: 0x0601A58B RID: 107915 RVA: 0x003D395E File Offset: 0x003D1B5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThirdPartyShareResponse(ThirdPartyShareResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A58C RID: 107916 RVA: 0x003D3983 File Offset: 0x003D1B83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThirdPartyShareResponse Clone()
		{
			return new ThirdPartyShareResponse(this);
		}

		// Token: 0x170058E3 RID: 22755
		// (get) Token: 0x0601A58D RID: 107917 RVA: 0x003D398B File Offset: 0x003D1B8B
		// (set) Token: 0x0601A58E RID: 107918 RVA: 0x003D3993 File Offset: 0x003D1B93
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

		// Token: 0x0601A58F RID: 107919 RVA: 0x003D399C File Offset: 0x003D1B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ThirdPartyShareResponse);
		}

		// Token: 0x0601A590 RID: 107920 RVA: 0x003D39AA File Offset: 0x003D1BAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ThirdPartyShareResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A591 RID: 107921 RVA: 0x003D39D8 File Offset: 0x003D1BD8
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

		// Token: 0x0601A592 RID: 107922 RVA: 0x003D3A1D File Offset: 0x003D1C1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A593 RID: 107923 RVA: 0x003D3A2A File Offset: 0x003D1C2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A594 RID: 107924 RVA: 0x003D3A33 File Offset: 0x003D1C33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A595 RID: 107925 RVA: 0x003D3A68 File Offset: 0x003D1C68
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

		// Token: 0x0601A596 RID: 107926 RVA: 0x003D3AA6 File Offset: 0x003D1CA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ThirdPartyShareResponse other)
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

		// Token: 0x0601A597 RID: 107927 RVA: 0x003D3AD7 File Offset: 0x003D1CD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A598 RID: 107928 RVA: 0x003D3AE0 File Offset: 0x003D1CE0
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400998C RID: 39308
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400998D RID: 39309
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x0400998E RID: 39310
		private ErrorCode errorCode_;
	}
}
