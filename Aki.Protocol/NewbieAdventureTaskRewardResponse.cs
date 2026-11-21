using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AEB RID: 2795
	[NetMessage(EMessageId.NewbieAdventureTaskRewardResponse)]
	public sealed class NewbieAdventureTaskRewardResponse : IMessage<NewbieAdventureTaskRewardResponse>, IMessage, IEquatable<NewbieAdventureTaskRewardResponse>, IDeepCloneable<NewbieAdventureTaskRewardResponse>, IBufferMessage
	{
		// Token: 0x0600F35B RID: 62299 RVA: 0x00238DB0 File Offset: 0x00236FB0
		[NullableContext(1)]
		public static NewbieAdventureTaskRewardResponse Create()
		{
			return new NewbieAdventureTaskRewardResponse();
		}

		// Token: 0x1700318D RID: 12685
		// (get) Token: 0x0600F35C RID: 62300 RVA: 0x00238DB7 File Offset: 0x00236FB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700318E RID: 12686
		// (get) Token: 0x0600F35D RID: 62301 RVA: 0x00238DBA File Offset: 0x00236FBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewbieAdventureTaskRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600F35E RID: 62302 RVA: 0x00238DC1 File Offset: 0x00236FC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieAdventureTaskRewardResponse()
		{
		}

		// Token: 0x0600F35F RID: 62303 RVA: 0x00238DC9 File Offset: 0x00236FC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieAdventureTaskRewardResponse(NewbieAdventureTaskRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F360 RID: 62304 RVA: 0x00238DEE File Offset: 0x00236FEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieAdventureTaskRewardResponse Clone()
		{
			return new NewbieAdventureTaskRewardResponse(this);
		}

		// Token: 0x1700318F RID: 12687
		// (get) Token: 0x0600F361 RID: 62305 RVA: 0x00238DF6 File Offset: 0x00236FF6
		// (set) Token: 0x0600F362 RID: 62306 RVA: 0x00238DFE File Offset: 0x00236FFE
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

		// Token: 0x0600F363 RID: 62307 RVA: 0x00238E07 File Offset: 0x00237007
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewbieAdventureTaskRewardResponse);
		}

		// Token: 0x0600F364 RID: 62308 RVA: 0x00238E15 File Offset: 0x00237015
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewbieAdventureTaskRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F365 RID: 62309 RVA: 0x00238E44 File Offset: 0x00237044
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

		// Token: 0x0600F366 RID: 62310 RVA: 0x00238E89 File Offset: 0x00237089
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F367 RID: 62311 RVA: 0x00238E96 File Offset: 0x00237096
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F368 RID: 62312 RVA: 0x00238E9F File Offset: 0x0023709F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F369 RID: 62313 RVA: 0x00238ED4 File Offset: 0x002370D4
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

		// Token: 0x0600F36A RID: 62314 RVA: 0x00238F12 File Offset: 0x00237112
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewbieAdventureTaskRewardResponse other)
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

		// Token: 0x0600F36B RID: 62315 RVA: 0x00238F43 File Offset: 0x00237143
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F36C RID: 62316 RVA: 0x00238F4C File Offset: 0x0023714C
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006276 RID: 25206
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006277 RID: 25207
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04006278 RID: 25208
		private ErrorCode errorCode_;
	}
}
