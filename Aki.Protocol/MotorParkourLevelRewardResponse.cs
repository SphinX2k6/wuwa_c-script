using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A96 RID: 2710
	[NetMessage(EMessageId.MotorParkourLevelRewardResponse)]
	public sealed class MotorParkourLevelRewardResponse : IMessage<MotorParkourLevelRewardResponse>, IMessage, IEquatable<MotorParkourLevelRewardResponse>, IDeepCloneable<MotorParkourLevelRewardResponse>, IBufferMessage
	{
		// Token: 0x0600EBFC RID: 60412 RVA: 0x002273B4 File Offset: 0x002255B4
		[NullableContext(1)]
		public static MotorParkourLevelRewardResponse Create()
		{
			return new MotorParkourLevelRewardResponse();
		}

		// Token: 0x17002FEB RID: 12267
		// (get) Token: 0x0600EBFD RID: 60413 RVA: 0x002273BB File Offset: 0x002255BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002FEC RID: 12268
		// (get) Token: 0x0600EBFE RID: 60414 RVA: 0x002273BE File Offset: 0x002255BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorParkourLevelRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600EBFF RID: 60415 RVA: 0x002273C5 File Offset: 0x002255C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorParkourLevelRewardResponse()
		{
		}

		// Token: 0x0600EC00 RID: 60416 RVA: 0x002273CD File Offset: 0x002255CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorParkourLevelRewardResponse(MotorParkourLevelRewardResponse other) : this()
		{
			this.error_ = other.error_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EC01 RID: 60417 RVA: 0x002273F2 File Offset: 0x002255F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorParkourLevelRewardResponse Clone()
		{
			return new MotorParkourLevelRewardResponse(this);
		}

		// Token: 0x17002FED RID: 12269
		// (get) Token: 0x0600EC02 RID: 60418 RVA: 0x002273FA File Offset: 0x002255FA
		// (set) Token: 0x0600EC03 RID: 60419 RVA: 0x00227402 File Offset: 0x00225602
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Error
		{
			get
			{
				return this.error_;
			}
			set
			{
				this.error_ = value;
			}
		}

		// Token: 0x0600EC04 RID: 60420 RVA: 0x0022740B File Offset: 0x0022560B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorParkourLevelRewardResponse);
		}

		// Token: 0x0600EC05 RID: 60421 RVA: 0x00227419 File Offset: 0x00225619
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorParkourLevelRewardResponse other)
		{
			return other != null && (other == this || (this.Error == other.Error && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EC06 RID: 60422 RVA: 0x00227448 File Offset: 0x00225648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Error != ErrorCode.Success)
			{
				num ^= this.Error.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600EC07 RID: 60423 RVA: 0x0022748D File Offset: 0x0022568D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EC08 RID: 60424 RVA: 0x0022749A File Offset: 0x0022569A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EC09 RID: 60425 RVA: 0x002274A3 File Offset: 0x002256A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Error != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Error);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EC0A RID: 60426 RVA: 0x002274D4 File Offset: 0x002256D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Error != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Error);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600EC0B RID: 60427 RVA: 0x00227512 File Offset: 0x00225712
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorParkourLevelRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Error != ErrorCode.Success)
			{
				this.Error = other.Error;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600EC0C RID: 60428 RVA: 0x00227543 File Offset: 0x00225743
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EC0D RID: 60429 RVA: 0x0022754C File Offset: 0x0022574C
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
					this.Error = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005FB8 RID: 24504
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005FB9 RID: 24505
		public const int ErrorFieldNumber = 1;

		// Token: 0x04005FBA RID: 24506
		private ErrorCode error_;
	}
}
