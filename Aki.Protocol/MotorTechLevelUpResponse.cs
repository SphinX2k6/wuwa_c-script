using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A9B RID: 2715
	[NetMessage(EMessageId.MotorTechLevelUpResponse)]
	public sealed class MotorTechLevelUpResponse : IMessage<MotorTechLevelUpResponse>, IMessage, IEquatable<MotorTechLevelUpResponse>, IDeepCloneable<MotorTechLevelUpResponse>, IBufferMessage
	{
		// Token: 0x0600ECB0 RID: 60592 RVA: 0x002292ED File Offset: 0x002274ED
		[NullableContext(1)]
		public static MotorTechLevelUpResponse Create()
		{
			return new MotorTechLevelUpResponse();
		}

		// Token: 0x17003011 RID: 12305
		// (get) Token: 0x0600ECB1 RID: 60593 RVA: 0x002292F4 File Offset: 0x002274F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003012 RID: 12306
		// (get) Token: 0x0600ECB2 RID: 60594 RVA: 0x002292F7 File Offset: 0x002274F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorTechLevelUpResponse.Descriptor;
			}
		}

		// Token: 0x0600ECB3 RID: 60595 RVA: 0x002292FE File Offset: 0x002274FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTechLevelUpResponse()
		{
		}

		// Token: 0x0600ECB4 RID: 60596 RVA: 0x00229308 File Offset: 0x00227508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTechLevelUpResponse(MotorTechLevelUpResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.tree_ = ((other.tree_ != null) ? other.tree_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ECB5 RID: 60597 RVA: 0x00229354 File Offset: 0x00227554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTechLevelUpResponse Clone()
		{
			return new MotorTechLevelUpResponse(this);
		}

		// Token: 0x17003013 RID: 12307
		// (get) Token: 0x0600ECB6 RID: 60598 RVA: 0x0022935C File Offset: 0x0022755C
		// (set) Token: 0x0600ECB7 RID: 60599 RVA: 0x00229364 File Offset: 0x00227564
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

		// Token: 0x17003014 RID: 12308
		// (get) Token: 0x0600ECB8 RID: 60600 RVA: 0x0022936D File Offset: 0x0022756D
		// (set) Token: 0x0600ECB9 RID: 60601 RVA: 0x00229375 File Offset: 0x00227575
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTechOneTreePb Tree
		{
			get
			{
				return this.tree_;
			}
			set
			{
				this.tree_ = value;
			}
		}

		// Token: 0x0600ECBA RID: 60602 RVA: 0x0022937E File Offset: 0x0022757E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorTechLevelUpResponse);
		}

		// Token: 0x0600ECBB RID: 60603 RVA: 0x0022938C File Offset: 0x0022758C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorTechLevelUpResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.Tree, other.Tree) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600ECBC RID: 60604 RVA: 0x002293DC File Offset: 0x002275DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.tree_ != null)
			{
				num ^= this.Tree.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600ECBD RID: 60605 RVA: 0x00229437 File Offset: 0x00227637
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600ECBE RID: 60606 RVA: 0x00229444 File Offset: 0x00227644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ECBF RID: 60607 RVA: 0x00229450 File Offset: 0x00227650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.tree_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.Tree);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ECC0 RID: 60608 RVA: 0x002294AC File Offset: 0x002276AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.tree_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Tree);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600ECC1 RID: 60609 RVA: 0x00229504 File Offset: 0x00227704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorTechLevelUpResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.tree_ != null)
			{
				if (this.tree_ == null)
				{
					this.Tree = new MotorTechOneTreePb();
				}
				this.Tree.MergeFrom(other.Tree);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600ECC2 RID: 60610 RVA: 0x0022956C File Offset: 0x0022776C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ECC3 RID: 60611 RVA: 0x00229578 File Offset: 0x00227778
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
					if (num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.tree_ == null)
						{
							this.Tree = new MotorTechOneTreePb();
						}
						input.ReadMessage(this.Tree);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400604D RID: 24653
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400604E RID: 24654
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x0400604F RID: 24655
		private ErrorCode errorCode_;

		// Token: 0x04006050 RID: 24656
		public const int TreeFieldNumber = 10;

		// Token: 0x04006051 RID: 24657
		private MotorTechOneTreePb tree_;
	}
}
