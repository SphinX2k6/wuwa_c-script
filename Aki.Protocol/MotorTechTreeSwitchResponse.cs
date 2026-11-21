using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A9F RID: 2719
	[NetMessage(EMessageId.MotorTechTreeSwitchResponse)]
	public sealed class MotorTechTreeSwitchResponse : IMessage<MotorTechTreeSwitchResponse>, IMessage, IEquatable<MotorTechTreeSwitchResponse>, IDeepCloneable<MotorTechTreeSwitchResponse>, IBufferMessage
	{
		// Token: 0x0600ED07 RID: 60679 RVA: 0x00229F3D File Offset: 0x0022813D
		[NullableContext(1)]
		public static MotorTechTreeSwitchResponse Create()
		{
			return new MotorTechTreeSwitchResponse();
		}

		// Token: 0x17003025 RID: 12325
		// (get) Token: 0x0600ED08 RID: 60680 RVA: 0x00229F44 File Offset: 0x00228144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003026 RID: 12326
		// (get) Token: 0x0600ED09 RID: 60681 RVA: 0x00229F47 File Offset: 0x00228147
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorTechTreeSwitchResponse.Descriptor;
			}
		}

		// Token: 0x0600ED0A RID: 60682 RVA: 0x00229F4E File Offset: 0x0022814E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTechTreeSwitchResponse()
		{
		}

		// Token: 0x0600ED0B RID: 60683 RVA: 0x00229F56 File Offset: 0x00228156
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTechTreeSwitchResponse(MotorTechTreeSwitchResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.treeInUse_ = other.treeInUse_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ED0C RID: 60684 RVA: 0x00229F87 File Offset: 0x00228187
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTechTreeSwitchResponse Clone()
		{
			return new MotorTechTreeSwitchResponse(this);
		}

		// Token: 0x17003027 RID: 12327
		// (get) Token: 0x0600ED0D RID: 60685 RVA: 0x00229F8F File Offset: 0x0022818F
		// (set) Token: 0x0600ED0E RID: 60686 RVA: 0x00229F97 File Offset: 0x00228197
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

		// Token: 0x17003028 RID: 12328
		// (get) Token: 0x0600ED0F RID: 60687 RVA: 0x00229FA0 File Offset: 0x002281A0
		// (set) Token: 0x0600ED10 RID: 60688 RVA: 0x00229FA8 File Offset: 0x002281A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TreeInUse
		{
			get
			{
				return this.treeInUse_;
			}
			set
			{
				this.treeInUse_ = value;
			}
		}

		// Token: 0x0600ED11 RID: 60689 RVA: 0x00229FB1 File Offset: 0x002281B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorTechTreeSwitchResponse);
		}

		// Token: 0x0600ED12 RID: 60690 RVA: 0x00229FBF File Offset: 0x002281BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorTechTreeSwitchResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.TreeInUse == other.TreeInUse && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600ED13 RID: 60691 RVA: 0x0022A000 File Offset: 0x00228200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.TreeInUse != 0)
			{
				num ^= this.TreeInUse.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600ED14 RID: 60692 RVA: 0x0022A05E File Offset: 0x0022825E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600ED15 RID: 60693 RVA: 0x0022A06B File Offset: 0x0022826B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ED16 RID: 60694 RVA: 0x0022A074 File Offset: 0x00228274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TreeInUse != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TreeInUse);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ED17 RID: 60695 RVA: 0x0022A0CC File Offset: 0x002282CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.TreeInUse != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TreeInUse);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600ED18 RID: 60696 RVA: 0x0022A124 File Offset: 0x00228324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorTechTreeSwitchResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.TreeInUse != 0)
			{
				this.TreeInUse = other.TreeInUse;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600ED19 RID: 60697 RVA: 0x0022A174 File Offset: 0x00228374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ED1A RID: 60698 RVA: 0x0022A180 File Offset: 0x00228380
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
					if (num != 40U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.TreeInUse = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006068 RID: 24680
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006069 RID: 24681
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x0400606A RID: 24682
		private ErrorCode errorCode_;

		// Token: 0x0400606B RID: 24683
		public const int TreeInUseFieldNumber = 1;

		// Token: 0x0400606C RID: 24684
		private int treeInUse_;
	}
}
