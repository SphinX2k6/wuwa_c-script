using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AB0 RID: 2736
	[NetMessage(EMessageId.MotorTechTreeSwitchResponse)]
	public sealed class MotorTechTreeSwitchResponse : IMessage<MotorTechTreeSwitchResponse>, IMessage, IEquatable<MotorTechTreeSwitchResponse>, IDeepCloneable<MotorTechTreeSwitchResponse>, IBufferMessage
	{
		// Token: 0x0600EE21 RID: 60961 RVA: 0x0022C139 File Offset: 0x0022A339
		[NullableContext(1)]
		public static MotorTechTreeSwitchResponse Create()
		{
			return new MotorTechTreeSwitchResponse();
		}

		// Token: 0x17003063 RID: 12387
		// (get) Token: 0x0600EE22 RID: 60962 RVA: 0x0022C140 File Offset: 0x0022A340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003064 RID: 12388
		// (get) Token: 0x0600EE23 RID: 60963 RVA: 0x0022C143 File Offset: 0x0022A343
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorTechTreeSwitchResponse.Descriptor;
			}
		}

		// Token: 0x0600EE24 RID: 60964 RVA: 0x0022C14A File Offset: 0x0022A34A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTechTreeSwitchResponse()
		{
		}

		// Token: 0x0600EE25 RID: 60965 RVA: 0x0022C152 File Offset: 0x0022A352
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTechTreeSwitchResponse(MotorTechTreeSwitchResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.treeInUse_ = other.treeInUse_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EE26 RID: 60966 RVA: 0x0022C183 File Offset: 0x0022A383
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTechTreeSwitchResponse Clone()
		{
			return new MotorTechTreeSwitchResponse(this);
		}

		// Token: 0x17003065 RID: 12389
		// (get) Token: 0x0600EE27 RID: 60967 RVA: 0x0022C18B File Offset: 0x0022A38B
		// (set) Token: 0x0600EE28 RID: 60968 RVA: 0x0022C193 File Offset: 0x0022A393
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

		// Token: 0x17003066 RID: 12390
		// (get) Token: 0x0600EE29 RID: 60969 RVA: 0x0022C19C File Offset: 0x0022A39C
		// (set) Token: 0x0600EE2A RID: 60970 RVA: 0x0022C1A4 File Offset: 0x0022A3A4
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

		// Token: 0x0600EE2B RID: 60971 RVA: 0x0022C1AD File Offset: 0x0022A3AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorTechTreeSwitchResponse);
		}

		// Token: 0x0600EE2C RID: 60972 RVA: 0x0022C1BB File Offset: 0x0022A3BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorTechTreeSwitchResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.TreeInUse == other.TreeInUse && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EE2D RID: 60973 RVA: 0x0022C1FC File Offset: 0x0022A3FC
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

		// Token: 0x0600EE2E RID: 60974 RVA: 0x0022C25A File Offset: 0x0022A45A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EE2F RID: 60975 RVA: 0x0022C267 File Offset: 0x0022A467
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EE30 RID: 60976 RVA: 0x0022C270 File Offset: 0x0022A470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TreeInUse != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.TreeInUse);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EE31 RID: 60977 RVA: 0x0022C2CC File Offset: 0x0022A4CC
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

		// Token: 0x0600EE32 RID: 60978 RVA: 0x0022C324 File Offset: 0x0022A524
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

		// Token: 0x0600EE33 RID: 60979 RVA: 0x0022C374 File Offset: 0x0022A574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EE34 RID: 60980 RVA: 0x0022C380 File Offset: 0x0022A580
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
				if (num != 40U)
				{
					if (num != 120U)
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

		// Token: 0x0400605F RID: 24671
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006060 RID: 24672
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04006061 RID: 24673
		private ErrorCode errorCode_;

		// Token: 0x04006062 RID: 24674
		public const int TreeInUseFieldNumber = 5;

		// Token: 0x04006063 RID: 24675
		private int treeInUse_;
	}
}
