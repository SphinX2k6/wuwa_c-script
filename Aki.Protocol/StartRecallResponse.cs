using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012FE RID: 4862
	[NetMessage(EMessageId.StartRecallResponse)]
	public sealed class StartRecallResponse : IMessage<StartRecallResponse>, IMessage, IEquatable<StartRecallResponse>, IDeepCloneable<StartRecallResponse>, IBufferMessage
	{
		// Token: 0x06019EF6 RID: 106230 RVA: 0x003C8290 File Offset: 0x003C6490
		[NullableContext(1)]
		public static StartRecallResponse Create()
		{
			return new StartRecallResponse();
		}

		// Token: 0x170057D5 RID: 22485
		// (get) Token: 0x06019EF7 RID: 106231 RVA: 0x003C8297 File Offset: 0x003C6497
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170057D6 RID: 22486
		// (get) Token: 0x06019EF8 RID: 106232 RVA: 0x003C829A File Offset: 0x003C649A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StartRecallResponse.Descriptor;
			}
		}

		// Token: 0x06019EF9 RID: 106233 RVA: 0x003C82A1 File Offset: 0x003C64A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartRecallResponse()
		{
		}

		// Token: 0x06019EFA RID: 106234 RVA: 0x003C82A9 File Offset: 0x003C64A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartRecallResponse(StartRecallResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.canContinue_ = other.canContinue_;
			this.enterInstId_ = other.enterInstId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019EFB RID: 106235 RVA: 0x003C82E6 File Offset: 0x003C64E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartRecallResponse Clone()
		{
			return new StartRecallResponse(this);
		}

		// Token: 0x170057D7 RID: 22487
		// (get) Token: 0x06019EFC RID: 106236 RVA: 0x003C82EE File Offset: 0x003C64EE
		// (set) Token: 0x06019EFD RID: 106237 RVA: 0x003C82F6 File Offset: 0x003C64F6
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

		// Token: 0x170057D8 RID: 22488
		// (get) Token: 0x06019EFE RID: 106238 RVA: 0x003C82FF File Offset: 0x003C64FF
		// (set) Token: 0x06019EFF RID: 106239 RVA: 0x003C8307 File Offset: 0x003C6507
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool CanContinue
		{
			get
			{
				return this.canContinue_;
			}
			set
			{
				this.canContinue_ = value;
			}
		}

		// Token: 0x170057D9 RID: 22489
		// (get) Token: 0x06019F00 RID: 106240 RVA: 0x003C8310 File Offset: 0x003C6510
		// (set) Token: 0x06019F01 RID: 106241 RVA: 0x003C8318 File Offset: 0x003C6518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EnterInstId
		{
			get
			{
				return this.enterInstId_;
			}
			set
			{
				this.enterInstId_ = value;
			}
		}

		// Token: 0x06019F02 RID: 106242 RVA: 0x003C8321 File Offset: 0x003C6521
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StartRecallResponse);
		}

		// Token: 0x06019F03 RID: 106243 RVA: 0x003C8330 File Offset: 0x003C6530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StartRecallResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.CanContinue == other.CanContinue && this.EnterInstId == other.EnterInstId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019F04 RID: 106244 RVA: 0x003C838C File Offset: 0x003C658C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.CanContinue)
			{
				num ^= this.CanContinue.GetHashCode();
			}
			if (this.EnterInstId != 0)
			{
				num ^= this.EnterInstId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019F05 RID: 106245 RVA: 0x003C8403 File Offset: 0x003C6603
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019F06 RID: 106246 RVA: 0x003C8410 File Offset: 0x003C6610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019F07 RID: 106247 RVA: 0x003C841C File Offset: 0x003C661C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CanContinue)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.CanContinue);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.EnterInstId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.EnterInstId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019F08 RID: 106248 RVA: 0x003C8494 File Offset: 0x003C6694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.CanContinue)
			{
				num += 2;
			}
			if (this.EnterInstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EnterInstId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019F09 RID: 106249 RVA: 0x003C84F8 File Offset: 0x003C66F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StartRecallResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.CanContinue)
			{
				this.CanContinue = other.CanContinue;
			}
			if (other.EnterInstId != 0)
			{
				this.EnterInstId = other.EnterInstId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019F0A RID: 106250 RVA: 0x003C855C File Offset: 0x003C675C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019F0B RID: 106251 RVA: 0x003C8568 File Offset: 0x003C6768
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
				if (num != 16U)
				{
					if (num != 56U)
					{
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.EnterInstId = input.ReadInt32();
						}
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.CanContinue = input.ReadBool();
				}
			}
		}

		// Token: 0x040098E2 RID: 39138
		private UnknownFieldSet _unknownFields;

		// Token: 0x040098E3 RID: 39139
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x040098E4 RID: 39140
		private ErrorCode errorCode_;

		// Token: 0x040098E5 RID: 39141
		public const int CanContinueFieldNumber = 2;

		// Token: 0x040098E6 RID: 39142
		private bool canContinue_;

		// Token: 0x040098E7 RID: 39143
		public const int EnterInstIdFieldNumber = 12;

		// Token: 0x040098E8 RID: 39144
		private int enterInstId_;
	}
}
