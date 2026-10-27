using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008E3 RID: 2275
	[NetMessage(EMessageId.LandingDamageResponse)]
	public sealed class LandingDamageResponse : IMessage<LandingDamageResponse>, IMessage, IEquatable<LandingDamageResponse>, IDeepCloneable<LandingDamageResponse>, IBufferMessage
	{
		// Token: 0x0600C954 RID: 51540 RVA: 0x001DBFAF File Offset: 0x001DA1AF
		[NullableContext(1)]
		public static LandingDamageResponse Create()
		{
			return new LandingDamageResponse();
		}

		// Token: 0x170028AC RID: 10412
		// (get) Token: 0x0600C955 RID: 51541 RVA: 0x001DBFB6 File Offset: 0x001DA1B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170028AD RID: 10413
		// (get) Token: 0x0600C956 RID: 51542 RVA: 0x001DBFB9 File Offset: 0x001DA1B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LandingDamageResponse.Descriptor;
			}
		}

		// Token: 0x0600C957 RID: 51543 RVA: 0x001DBFC0 File Offset: 0x001DA1C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LandingDamageResponse()
		{
		}

		// Token: 0x0600C958 RID: 51544 RVA: 0x001DBFC8 File Offset: 0x001DA1C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LandingDamageResponse(LandingDamageResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C959 RID: 51545 RVA: 0x001DBFED File Offset: 0x001DA1ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LandingDamageResponse Clone()
		{
			return new LandingDamageResponse(this);
		}

		// Token: 0x170028AE RID: 10414
		// (get) Token: 0x0600C95A RID: 51546 RVA: 0x001DBFF5 File Offset: 0x001DA1F5
		// (set) Token: 0x0600C95B RID: 51547 RVA: 0x001DBFFD File Offset: 0x001DA1FD
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

		// Token: 0x0600C95C RID: 51548 RVA: 0x001DC006 File Offset: 0x001DA206
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LandingDamageResponse);
		}

		// Token: 0x0600C95D RID: 51549 RVA: 0x001DC014 File Offset: 0x001DA214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LandingDamageResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C95E RID: 51550 RVA: 0x001DC044 File Offset: 0x001DA244
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

		// Token: 0x0600C95F RID: 51551 RVA: 0x001DC089 File Offset: 0x001DA289
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C960 RID: 51552 RVA: 0x001DC096 File Offset: 0x001DA296
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C961 RID: 51553 RVA: 0x001DC09F File Offset: 0x001DA29F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C962 RID: 51554 RVA: 0x001DC0D4 File Offset: 0x001DA2D4
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

		// Token: 0x0600C963 RID: 51555 RVA: 0x001DC112 File Offset: 0x001DA312
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LandingDamageResponse other)
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

		// Token: 0x0600C964 RID: 51556 RVA: 0x001DC143 File Offset: 0x001DA343
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C965 RID: 51557 RVA: 0x001DC14C File Offset: 0x001DA34C
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040055EB RID: 21995
		private UnknownFieldSet _unknownFields;

		// Token: 0x040055EC RID: 21996
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x040055ED RID: 21997
		private ErrorCode errorCode_;
	}
}
