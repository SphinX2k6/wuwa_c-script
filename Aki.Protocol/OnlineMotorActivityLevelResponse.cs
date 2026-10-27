using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B97 RID: 2967
	[NetMessage(EMessageId.OnlineMotorActivityLevelResponse)]
	public sealed class OnlineMotorActivityLevelResponse : IMessage<OnlineMotorActivityLevelResponse>, IMessage, IEquatable<OnlineMotorActivityLevelResponse>, IDeepCloneable<OnlineMotorActivityLevelResponse>, IBufferMessage
	{
		// Token: 0x06010169 RID: 65897 RVA: 0x00259408 File Offset: 0x00257608
		[NullableContext(1)]
		public static OnlineMotorActivityLevelResponse Create()
		{
			return new OnlineMotorActivityLevelResponse();
		}

		// Token: 0x170034B6 RID: 13494
		// (get) Token: 0x0601016A RID: 65898 RVA: 0x0025940F File Offset: 0x0025760F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170034B7 RID: 13495
		// (get) Token: 0x0601016B RID: 65899 RVA: 0x00259412 File Offset: 0x00257612
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OnlineMotorActivityLevelResponse.Descriptor;
			}
		}

		// Token: 0x0601016C RID: 65900 RVA: 0x00259419 File Offset: 0x00257619
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorActivityLevelResponse()
		{
		}

		// Token: 0x0601016D RID: 65901 RVA: 0x00259421 File Offset: 0x00257621
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorActivityLevelResponse(OnlineMotorActivityLevelResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601016E RID: 65902 RVA: 0x00259446 File Offset: 0x00257646
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorActivityLevelResponse Clone()
		{
			return new OnlineMotorActivityLevelResponse(this);
		}

		// Token: 0x170034B8 RID: 13496
		// (get) Token: 0x0601016F RID: 65903 RVA: 0x0025944E File Offset: 0x0025764E
		// (set) Token: 0x06010170 RID: 65904 RVA: 0x00259456 File Offset: 0x00257656
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

		// Token: 0x06010171 RID: 65905 RVA: 0x0025945F File Offset: 0x0025765F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OnlineMotorActivityLevelResponse);
		}

		// Token: 0x06010172 RID: 65906 RVA: 0x0025946D File Offset: 0x0025766D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OnlineMotorActivityLevelResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010173 RID: 65907 RVA: 0x0025949C File Offset: 0x0025769C
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

		// Token: 0x06010174 RID: 65908 RVA: 0x002594E1 File Offset: 0x002576E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010175 RID: 65909 RVA: 0x002594EE File Offset: 0x002576EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010176 RID: 65910 RVA: 0x002594F7 File Offset: 0x002576F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010177 RID: 65911 RVA: 0x00259528 File Offset: 0x00257728
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

		// Token: 0x06010178 RID: 65912 RVA: 0x00259566 File Offset: 0x00257766
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OnlineMotorActivityLevelResponse other)
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

		// Token: 0x06010179 RID: 65913 RVA: 0x00259597 File Offset: 0x00257797
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601017A RID: 65914 RVA: 0x002595A0 File Offset: 0x002577A0
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006695 RID: 26261
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006696 RID: 26262
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04006697 RID: 26263
		private ErrorCode errorCode_;
	}
}
