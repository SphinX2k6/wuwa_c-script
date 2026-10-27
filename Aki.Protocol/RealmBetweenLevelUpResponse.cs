using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E9F RID: 3743
	[NetMessage(EMessageId.RealmBetweenLevelUpResponse)]
	public sealed class RealmBetweenLevelUpResponse : IMessage<RealmBetweenLevelUpResponse>, IMessage, IEquatable<RealmBetweenLevelUpResponse>, IDeepCloneable<RealmBetweenLevelUpResponse>, IBufferMessage
	{
		// Token: 0x0601417F RID: 82303 RVA: 0x002ECCD2 File Offset: 0x002EAED2
		[NullableContext(1)]
		public static RealmBetweenLevelUpResponse Create()
		{
			return new RealmBetweenLevelUpResponse();
		}

		// Token: 0x170042D7 RID: 17111
		// (get) Token: 0x06014180 RID: 82304 RVA: 0x002ECCD9 File Offset: 0x002EAED9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170042D8 RID: 17112
		// (get) Token: 0x06014181 RID: 82305 RVA: 0x002ECCDC File Offset: 0x002EAEDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RealmBetweenLevelUpResponse.Descriptor;
			}
		}

		// Token: 0x06014182 RID: 82306 RVA: 0x002ECCE3 File Offset: 0x002EAEE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenLevelUpResponse()
		{
		}

		// Token: 0x06014183 RID: 82307 RVA: 0x002ECCEB File Offset: 0x002EAEEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenLevelUpResponse(RealmBetweenLevelUpResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014184 RID: 82308 RVA: 0x002ECD10 File Offset: 0x002EAF10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenLevelUpResponse Clone()
		{
			return new RealmBetweenLevelUpResponse(this);
		}

		// Token: 0x170042D9 RID: 17113
		// (get) Token: 0x06014185 RID: 82309 RVA: 0x002ECD18 File Offset: 0x002EAF18
		// (set) Token: 0x06014186 RID: 82310 RVA: 0x002ECD20 File Offset: 0x002EAF20
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

		// Token: 0x06014187 RID: 82311 RVA: 0x002ECD29 File Offset: 0x002EAF29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RealmBetweenLevelUpResponse);
		}

		// Token: 0x06014188 RID: 82312 RVA: 0x002ECD37 File Offset: 0x002EAF37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RealmBetweenLevelUpResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014189 RID: 82313 RVA: 0x002ECD68 File Offset: 0x002EAF68
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

		// Token: 0x0601418A RID: 82314 RVA: 0x002ECDAD File Offset: 0x002EAFAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601418B RID: 82315 RVA: 0x002ECDBA File Offset: 0x002EAFBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601418C RID: 82316 RVA: 0x002ECDC3 File Offset: 0x002EAFC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601418D RID: 82317 RVA: 0x002ECDF8 File Offset: 0x002EAFF8
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

		// Token: 0x0601418E RID: 82318 RVA: 0x002ECE36 File Offset: 0x002EB036
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RealmBetweenLevelUpResponse other)
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

		// Token: 0x0601418F RID: 82319 RVA: 0x002ECE67 File Offset: 0x002EB067
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014190 RID: 82320 RVA: 0x002ECE70 File Offset: 0x002EB070
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007A7E RID: 31358
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007A7F RID: 31359
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04007A80 RID: 31360
		private ErrorCode errorCode_;
	}
}
