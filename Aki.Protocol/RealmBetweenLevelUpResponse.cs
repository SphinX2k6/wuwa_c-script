using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E8F RID: 3727
	[NetMessage(EMessageId.RealmBetweenLevelUpResponse)]
	public sealed class RealmBetweenLevelUpResponse : IMessage<RealmBetweenLevelUpResponse>, IMessage, IEquatable<RealmBetweenLevelUpResponse>, IDeepCloneable<RealmBetweenLevelUpResponse>, IBufferMessage
	{
		// Token: 0x0601409A RID: 82074 RVA: 0x002EB62A File Offset: 0x002E982A
		[NullableContext(1)]
		public static RealmBetweenLevelUpResponse Create()
		{
			return new RealmBetweenLevelUpResponse();
		}

		// Token: 0x170042AD RID: 17069
		// (get) Token: 0x0601409B RID: 82075 RVA: 0x002EB631 File Offset: 0x002E9831
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170042AE RID: 17070
		// (get) Token: 0x0601409C RID: 82076 RVA: 0x002EB634 File Offset: 0x002E9834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RealmBetweenLevelUpResponse.Descriptor;
			}
		}

		// Token: 0x0601409D RID: 82077 RVA: 0x002EB63B File Offset: 0x002E983B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenLevelUpResponse()
		{
		}

		// Token: 0x0601409E RID: 82078 RVA: 0x002EB643 File Offset: 0x002E9843
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenLevelUpResponse(RealmBetweenLevelUpResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601409F RID: 82079 RVA: 0x002EB668 File Offset: 0x002E9868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenLevelUpResponse Clone()
		{
			return new RealmBetweenLevelUpResponse(this);
		}

		// Token: 0x170042AF RID: 17071
		// (get) Token: 0x060140A0 RID: 82080 RVA: 0x002EB670 File Offset: 0x002E9870
		// (set) Token: 0x060140A1 RID: 82081 RVA: 0x002EB678 File Offset: 0x002E9878
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

		// Token: 0x060140A2 RID: 82082 RVA: 0x002EB681 File Offset: 0x002E9881
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RealmBetweenLevelUpResponse);
		}

		// Token: 0x060140A3 RID: 82083 RVA: 0x002EB68F File Offset: 0x002E988F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RealmBetweenLevelUpResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060140A4 RID: 82084 RVA: 0x002EB6C0 File Offset: 0x002E98C0
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

		// Token: 0x060140A5 RID: 82085 RVA: 0x002EB705 File Offset: 0x002E9905
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060140A6 RID: 82086 RVA: 0x002EB712 File Offset: 0x002E9912
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060140A7 RID: 82087 RVA: 0x002EB71B File Offset: 0x002E991B
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

		// Token: 0x060140A8 RID: 82088 RVA: 0x002EB74C File Offset: 0x002E994C
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

		// Token: 0x060140A9 RID: 82089 RVA: 0x002EB78A File Offset: 0x002E998A
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

		// Token: 0x060140AA RID: 82090 RVA: 0x002EB7BB File Offset: 0x002E99BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060140AB RID: 82091 RVA: 0x002EB7C4 File Offset: 0x002E99C4
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

		// Token: 0x04007AA8 RID: 31400
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007AA9 RID: 31401
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04007AAA RID: 31402
		private ErrorCode errorCode_;
	}
}
