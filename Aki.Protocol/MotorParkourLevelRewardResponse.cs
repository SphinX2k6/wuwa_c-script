using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A85 RID: 2693
	[NetMessage(EMessageId.MotorParkourLevelRewardResponse)]
	public sealed class MotorParkourLevelRewardResponse : IMessage<MotorParkourLevelRewardResponse>, IMessage, IEquatable<MotorParkourLevelRewardResponse>, IDeepCloneable<MotorParkourLevelRewardResponse>, IBufferMessage
	{
		// Token: 0x0600EAE2 RID: 60130 RVA: 0x002251B8 File Offset: 0x002233B8
		[NullableContext(1)]
		public static MotorParkourLevelRewardResponse Create()
		{
			return new MotorParkourLevelRewardResponse();
		}

		// Token: 0x17002FAD RID: 12205
		// (get) Token: 0x0600EAE3 RID: 60131 RVA: 0x002251BF File Offset: 0x002233BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002FAE RID: 12206
		// (get) Token: 0x0600EAE4 RID: 60132 RVA: 0x002251C2 File Offset: 0x002233C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorParkourLevelRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600EAE5 RID: 60133 RVA: 0x002251C9 File Offset: 0x002233C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorParkourLevelRewardResponse()
		{
		}

		// Token: 0x0600EAE6 RID: 60134 RVA: 0x002251D1 File Offset: 0x002233D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorParkourLevelRewardResponse(MotorParkourLevelRewardResponse other) : this()
		{
			this.error_ = other.error_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EAE7 RID: 60135 RVA: 0x002251F6 File Offset: 0x002233F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorParkourLevelRewardResponse Clone()
		{
			return new MotorParkourLevelRewardResponse(this);
		}

		// Token: 0x17002FAF RID: 12207
		// (get) Token: 0x0600EAE8 RID: 60136 RVA: 0x002251FE File Offset: 0x002233FE
		// (set) Token: 0x0600EAE9 RID: 60137 RVA: 0x00225206 File Offset: 0x00223406
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

		// Token: 0x0600EAEA RID: 60138 RVA: 0x0022520F File Offset: 0x0022340F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorParkourLevelRewardResponse);
		}

		// Token: 0x0600EAEB RID: 60139 RVA: 0x0022521D File Offset: 0x0022341D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorParkourLevelRewardResponse other)
		{
			return other != null && (other == this || (this.Error == other.Error && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EAEC RID: 60140 RVA: 0x0022524C File Offset: 0x0022344C
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

		// Token: 0x0600EAED RID: 60141 RVA: 0x00225291 File Offset: 0x00223491
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EAEE RID: 60142 RVA: 0x0022529E File Offset: 0x0022349E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EAEF RID: 60143 RVA: 0x002252A7 File Offset: 0x002234A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Error != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.Error);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EAF0 RID: 60144 RVA: 0x002252DC File Offset: 0x002234DC
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

		// Token: 0x0600EAF1 RID: 60145 RVA: 0x0022531A File Offset: 0x0022351A
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

		// Token: 0x0600EAF2 RID: 60146 RVA: 0x0022534B File Offset: 0x0022354B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EAF3 RID: 60147 RVA: 0x00225354 File Offset: 0x00223554
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Error = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005FC1 RID: 24513
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005FC2 RID: 24514
		public const int ErrorFieldNumber = 9;

		// Token: 0x04005FC3 RID: 24515
		private ErrorCode error_;
	}
}
