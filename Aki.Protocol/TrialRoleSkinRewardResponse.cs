using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200146A RID: 5226
	[NetMessage(EMessageId.TrialRoleSkinRewardResponse)]
	public sealed class TrialRoleSkinRewardResponse : IMessage<TrialRoleSkinRewardResponse>, IMessage, IEquatable<TrialRoleSkinRewardResponse>, IDeepCloneable<TrialRoleSkinRewardResponse>, IBufferMessage
	{
		// Token: 0x0601BAB5 RID: 113333 RVA: 0x0040137D File Offset: 0x003FF57D
		[NullableContext(1)]
		public static TrialRoleSkinRewardResponse Create()
		{
			return new TrialRoleSkinRewardResponse();
		}

		// Token: 0x17005D50 RID: 23888
		// (get) Token: 0x0601BAB6 RID: 113334 RVA: 0x00401384 File Offset: 0x003FF584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D51 RID: 23889
		// (get) Token: 0x0601BAB7 RID: 113335 RVA: 0x00401387 File Offset: 0x003FF587
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrialRoleSkinRewardResponse.Descriptor;
			}
		}

		// Token: 0x0601BAB8 RID: 113336 RVA: 0x0040138E File Offset: 0x003FF58E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrialRoleSkinRewardResponse()
		{
		}

		// Token: 0x0601BAB9 RID: 113337 RVA: 0x00401396 File Offset: 0x003FF596
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrialRoleSkinRewardResponse(TrialRoleSkinRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BABA RID: 113338 RVA: 0x004013BB File Offset: 0x003FF5BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrialRoleSkinRewardResponse Clone()
		{
			return new TrialRoleSkinRewardResponse(this);
		}

		// Token: 0x17005D52 RID: 23890
		// (get) Token: 0x0601BABB RID: 113339 RVA: 0x004013C3 File Offset: 0x003FF5C3
		// (set) Token: 0x0601BABC RID: 113340 RVA: 0x004013CB File Offset: 0x003FF5CB
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

		// Token: 0x0601BABD RID: 113341 RVA: 0x004013D4 File Offset: 0x003FF5D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrialRoleSkinRewardResponse);
		}

		// Token: 0x0601BABE RID: 113342 RVA: 0x004013E2 File Offset: 0x003FF5E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrialRoleSkinRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BABF RID: 113343 RVA: 0x00401410 File Offset: 0x003FF610
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

		// Token: 0x0601BAC0 RID: 113344 RVA: 0x00401455 File Offset: 0x003FF655
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BAC1 RID: 113345 RVA: 0x00401462 File Offset: 0x003FF662
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BAC2 RID: 113346 RVA: 0x0040146B File Offset: 0x003FF66B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BAC3 RID: 113347 RVA: 0x004014A0 File Offset: 0x003FF6A0
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

		// Token: 0x0601BAC4 RID: 113348 RVA: 0x004014DE File Offset: 0x003FF6DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrialRoleSkinRewardResponse other)
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

		// Token: 0x0601BAC5 RID: 113349 RVA: 0x0040150F File Offset: 0x003FF70F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BAC6 RID: 113350 RVA: 0x00401518 File Offset: 0x003FF718
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009F72 RID: 40818
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009F73 RID: 40819
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04009F74 RID: 40820
		private ErrorCode errorCode_;
	}
}
