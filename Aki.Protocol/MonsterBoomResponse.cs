using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009E4 RID: 2532
	[NetMessage(EMessageId.MonsterBoomResponse)]
	public sealed class MonsterBoomResponse : IMessage<MonsterBoomResponse>, IMessage, IEquatable<MonsterBoomResponse>, IDeepCloneable<MonsterBoomResponse>, IBufferMessage
	{
		// Token: 0x0600DE1A RID: 56858 RVA: 0x00209791 File Offset: 0x00207991
		[NullableContext(1)]
		public static MonsterBoomResponse Create()
		{
			return new MonsterBoomResponse();
		}

		// Token: 0x17002D00 RID: 11520
		// (get) Token: 0x0600DE1B RID: 56859 RVA: 0x00209798 File Offset: 0x00207998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D01 RID: 11521
		// (get) Token: 0x0600DE1C RID: 56860 RVA: 0x0020979B File Offset: 0x0020799B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonsterBoomResponse.Descriptor;
			}
		}

		// Token: 0x0600DE1D RID: 56861 RVA: 0x002097A2 File Offset: 0x002079A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterBoomResponse()
		{
		}

		// Token: 0x0600DE1E RID: 56862 RVA: 0x002097AA File Offset: 0x002079AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterBoomResponse(MonsterBoomResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DE1F RID: 56863 RVA: 0x002097CF File Offset: 0x002079CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterBoomResponse Clone()
		{
			return new MonsterBoomResponse(this);
		}

		// Token: 0x17002D02 RID: 11522
		// (get) Token: 0x0600DE20 RID: 56864 RVA: 0x002097D7 File Offset: 0x002079D7
		// (set) Token: 0x0600DE21 RID: 56865 RVA: 0x002097DF File Offset: 0x002079DF
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

		// Token: 0x0600DE22 RID: 56866 RVA: 0x002097E8 File Offset: 0x002079E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonsterBoomResponse);
		}

		// Token: 0x0600DE23 RID: 56867 RVA: 0x002097F6 File Offset: 0x002079F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonsterBoomResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DE24 RID: 56868 RVA: 0x00209824 File Offset: 0x00207A24
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

		// Token: 0x0600DE25 RID: 56869 RVA: 0x00209869 File Offset: 0x00207A69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DE26 RID: 56870 RVA: 0x00209876 File Offset: 0x00207A76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DE27 RID: 56871 RVA: 0x0020987F File Offset: 0x00207A7F
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

		// Token: 0x0600DE28 RID: 56872 RVA: 0x002098B4 File Offset: 0x00207AB4
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

		// Token: 0x0600DE29 RID: 56873 RVA: 0x002098F2 File Offset: 0x00207AF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonsterBoomResponse other)
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

		// Token: 0x0600DE2A RID: 56874 RVA: 0x00209923 File Offset: 0x00207B23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DE2B RID: 56875 RVA: 0x0020992C File Offset: 0x00207B2C
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

		// Token: 0x04005C14 RID: 23572
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005C15 RID: 23573
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04005C16 RID: 23574
		private ErrorCode errorCode_;
	}
}
