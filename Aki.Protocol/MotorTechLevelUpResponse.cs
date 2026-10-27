using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AAC RID: 2732
	[NetMessage(EMessageId.MotorTechLevelUpResponse)]
	public sealed class MotorTechLevelUpResponse : IMessage<MotorTechLevelUpResponse>, IMessage, IEquatable<MotorTechLevelUpResponse>, IDeepCloneable<MotorTechLevelUpResponse>, IBufferMessage
	{
		// Token: 0x0600EDCA RID: 60874 RVA: 0x0022B4E9 File Offset: 0x002296E9
		[NullableContext(1)]
		public static MotorTechLevelUpResponse Create()
		{
			return new MotorTechLevelUpResponse();
		}

		// Token: 0x1700304F RID: 12367
		// (get) Token: 0x0600EDCB RID: 60875 RVA: 0x0022B4F0 File Offset: 0x002296F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003050 RID: 12368
		// (get) Token: 0x0600EDCC RID: 60876 RVA: 0x0022B4F3 File Offset: 0x002296F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorTechLevelUpResponse.Descriptor;
			}
		}

		// Token: 0x0600EDCD RID: 60877 RVA: 0x0022B4FA File Offset: 0x002296FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTechLevelUpResponse()
		{
		}

		// Token: 0x0600EDCE RID: 60878 RVA: 0x0022B504 File Offset: 0x00229704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTechLevelUpResponse(MotorTechLevelUpResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.tree_ = ((other.tree_ != null) ? other.tree_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EDCF RID: 60879 RVA: 0x0022B550 File Offset: 0x00229750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTechLevelUpResponse Clone()
		{
			return new MotorTechLevelUpResponse(this);
		}

		// Token: 0x17003051 RID: 12369
		// (get) Token: 0x0600EDD0 RID: 60880 RVA: 0x0022B558 File Offset: 0x00229758
		// (set) Token: 0x0600EDD1 RID: 60881 RVA: 0x0022B560 File Offset: 0x00229760
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

		// Token: 0x17003052 RID: 12370
		// (get) Token: 0x0600EDD2 RID: 60882 RVA: 0x0022B569 File Offset: 0x00229769
		// (set) Token: 0x0600EDD3 RID: 60883 RVA: 0x0022B571 File Offset: 0x00229771
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

		// Token: 0x0600EDD4 RID: 60884 RVA: 0x0022B57A File Offset: 0x0022977A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorTechLevelUpResponse);
		}

		// Token: 0x0600EDD5 RID: 60885 RVA: 0x0022B588 File Offset: 0x00229788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorTechLevelUpResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.Tree, other.Tree) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EDD6 RID: 60886 RVA: 0x0022B5D8 File Offset: 0x002297D8
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

		// Token: 0x0600EDD7 RID: 60887 RVA: 0x0022B633 File Offset: 0x00229833
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EDD8 RID: 60888 RVA: 0x0022B640 File Offset: 0x00229840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EDD9 RID: 60889 RVA: 0x0022B64C File Offset: 0x0022984C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.tree_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Tree);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EDDA RID: 60890 RVA: 0x0022B6A8 File Offset: 0x002298A8
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

		// Token: 0x0600EDDB RID: 60891 RVA: 0x0022B700 File Offset: 0x00229900
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

		// Token: 0x0600EDDC RID: 60892 RVA: 0x0022B768 File Offset: 0x00229968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EDDD RID: 60893 RVA: 0x0022B774 File Offset: 0x00229974
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
				if (num != 24U)
				{
					if (num != 34U)
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

		// Token: 0x04006044 RID: 24644
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006045 RID: 24645
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04006046 RID: 24646
		private ErrorCode errorCode_;

		// Token: 0x04006047 RID: 24647
		public const int TreeFieldNumber = 4;

		// Token: 0x04006048 RID: 24648
		private MotorTechOneTreePb tree_;
	}
}
