using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005E6 RID: 1510
	[NetMessage(EMessageId.FlowerPollutionRequest)]
	public sealed class FlowerPollutionRequest : IMessage<FlowerPollutionRequest>, IMessage, IEquatable<FlowerPollutionRequest>, IDeepCloneable<FlowerPollutionRequest>, IBufferMessage
	{
		// Token: 0x06008C44 RID: 35908 RVA: 0x00154C20 File Offset: 0x00152E20
		[NullableContext(1)]
		public static FlowerPollutionRequest Create()
		{
			return new FlowerPollutionRequest();
		}

		// Token: 0x17001BCA RID: 7114
		// (get) Token: 0x06008C45 RID: 35909 RVA: 0x00154C27 File Offset: 0x00152E27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001BCB RID: 7115
		// (get) Token: 0x06008C46 RID: 35910 RVA: 0x00154C2A File Offset: 0x00152E2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlowerPollutionRequest.Descriptor;
			}
		}

		// Token: 0x06008C47 RID: 35911 RVA: 0x00154C31 File Offset: 0x00152E31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowerPollutionRequest()
		{
		}

		// Token: 0x06008C48 RID: 35912 RVA: 0x00154C44 File Offset: 0x00152E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowerPollutionRequest(FlowerPollutionRequest other) : this()
		{
			this.managerEntityId_ = other.managerEntityId_;
			this.sourceEntityId_ = other.sourceEntityId_;
			this.targetEntityId_ = other.targetEntityId_;
			this.switchToTargetState_ = other.switchToTargetState_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008C49 RID: 35913 RVA: 0x00154C98 File Offset: 0x00152E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowerPollutionRequest Clone()
		{
			return new FlowerPollutionRequest(this);
		}

		// Token: 0x17001BCC RID: 7116
		// (get) Token: 0x06008C4A RID: 35914 RVA: 0x00154CA0 File Offset: 0x00152EA0
		// (set) Token: 0x06008C4B RID: 35915 RVA: 0x00154CA8 File Offset: 0x00152EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ManagerEntityId
		{
			get
			{
				return this.managerEntityId_;
			}
			set
			{
				this.managerEntityId_ = value;
			}
		}

		// Token: 0x17001BCD RID: 7117
		// (get) Token: 0x06008C4C RID: 35916 RVA: 0x00154CB1 File Offset: 0x00152EB1
		// (set) Token: 0x06008C4D RID: 35917 RVA: 0x00154CB9 File Offset: 0x00152EB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SourceEntityId
		{
			get
			{
				return this.sourceEntityId_;
			}
			set
			{
				this.sourceEntityId_ = value;
			}
		}

		// Token: 0x17001BCE RID: 7118
		// (get) Token: 0x06008C4E RID: 35918 RVA: 0x00154CC2 File Offset: 0x00152EC2
		// (set) Token: 0x06008C4F RID: 35919 RVA: 0x00154CCA File Offset: 0x00152ECA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TargetEntityId
		{
			get
			{
				return this.targetEntityId_;
			}
			set
			{
				this.targetEntityId_ = value;
			}
		}

		// Token: 0x17001BCF RID: 7119
		// (get) Token: 0x06008C50 RID: 35920 RVA: 0x00154CD3 File Offset: 0x00152ED3
		// (set) Token: 0x06008C51 RID: 35921 RVA: 0x00154CDB File Offset: 0x00152EDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string SwitchToTargetState
		{
			get
			{
				return this.switchToTargetState_;
			}
			set
			{
				this.switchToTargetState_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06008C52 RID: 35922 RVA: 0x00154CEE File Offset: 0x00152EEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlowerPollutionRequest);
		}

		// Token: 0x06008C53 RID: 35923 RVA: 0x00154CFC File Offset: 0x00152EFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlowerPollutionRequest other)
		{
			return other != null && (other == this || (this.ManagerEntityId == other.ManagerEntityId && this.SourceEntityId == other.SourceEntityId && this.TargetEntityId == other.TargetEntityId && !(this.SwitchToTargetState != other.SwitchToTargetState) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008C54 RID: 35924 RVA: 0x00154D6C File Offset: 0x00152F6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ManagerEntityId != 0L)
			{
				num ^= this.ManagerEntityId.GetHashCode();
			}
			if (this.SourceEntityId != 0L)
			{
				num ^= this.SourceEntityId.GetHashCode();
			}
			if (this.TargetEntityId != 0L)
			{
				num ^= this.TargetEntityId.GetHashCode();
			}
			if (this.SwitchToTargetState.Length != 0)
			{
				num ^= this.SwitchToTargetState.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008C55 RID: 35925 RVA: 0x00154DF8 File Offset: 0x00152FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008C56 RID: 35926 RVA: 0x00154E05 File Offset: 0x00153005
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008C57 RID: 35927 RVA: 0x00154E10 File Offset: 0x00153010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SourceEntityId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.SourceEntityId);
			}
			if (this.TargetEntityId != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.TargetEntityId);
			}
			if (this.ManagerEntityId != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.ManagerEntityId);
			}
			if (this.SwitchToTargetState.Length != 0)
			{
				output.WriteRawTag(106);
				output.WriteString(this.SwitchToTargetState);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008C58 RID: 35928 RVA: 0x00154EA8 File Offset: 0x001530A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ManagerEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ManagerEntityId);
			}
			if (this.SourceEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SourceEntityId);
			}
			if (this.TargetEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TargetEntityId);
			}
			if (this.SwitchToTargetState.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.SwitchToTargetState);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008C59 RID: 35929 RVA: 0x00154F34 File Offset: 0x00153134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlowerPollutionRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ManagerEntityId != 0L)
			{
				this.ManagerEntityId = other.ManagerEntityId;
			}
			if (other.SourceEntityId != 0L)
			{
				this.SourceEntityId = other.SourceEntityId;
			}
			if (other.TargetEntityId != 0L)
			{
				this.TargetEntityId = other.TargetEntityId;
			}
			if (other.SwitchToTargetState.Length != 0)
			{
				this.SwitchToTargetState = other.SwitchToTargetState;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008C5A RID: 35930 RVA: 0x00154FB1 File Offset: 0x001531B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008C5B RID: 35931 RVA: 0x00154FBC File Offset: 0x001531BC
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
				if (num <= 32U)
				{
					if (num == 24U)
					{
						this.SourceEntityId = input.ReadInt64();
						continue;
					}
					if (num == 32U)
					{
						this.TargetEntityId = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.ManagerEntityId = input.ReadInt64();
						continue;
					}
					if (num == 106U)
					{
						this.SwitchToTargetState = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004514 RID: 17684
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004515 RID: 17685
		public const int ManagerEntityIdFieldNumber = 10;

		// Token: 0x04004516 RID: 17686
		private long managerEntityId_;

		// Token: 0x04004517 RID: 17687
		public const int SourceEntityIdFieldNumber = 3;

		// Token: 0x04004518 RID: 17688
		private long sourceEntityId_;

		// Token: 0x04004519 RID: 17689
		public const int TargetEntityIdFieldNumber = 4;

		// Token: 0x0400451A RID: 17690
		private long targetEntityId_;

		// Token: 0x0400451B RID: 17691
		public const int SwitchToTargetStateFieldNumber = 13;

		// Token: 0x0400451C RID: 17692
		private string switchToTargetState_ = "";
	}
}
