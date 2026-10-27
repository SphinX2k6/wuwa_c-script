using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005FB RID: 1531
	[NetMessage(EMessageId.FlowerPollutionRequest)]
	public sealed class FlowerPollutionRequest : IMessage<FlowerPollutionRequest>, IMessage, IEquatable<FlowerPollutionRequest>, IDeepCloneable<FlowerPollutionRequest>, IBufferMessage
	{
		// Token: 0x06008DAC RID: 36268 RVA: 0x00157820 File Offset: 0x00155A20
		[NullableContext(1)]
		public static FlowerPollutionRequest Create()
		{
			return new FlowerPollutionRequest();
		}

		// Token: 0x17001C17 RID: 7191
		// (get) Token: 0x06008DAD RID: 36269 RVA: 0x00157827 File Offset: 0x00155A27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C18 RID: 7192
		// (get) Token: 0x06008DAE RID: 36270 RVA: 0x0015782A File Offset: 0x00155A2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlowerPollutionRequest.Descriptor;
			}
		}

		// Token: 0x06008DAF RID: 36271 RVA: 0x00157831 File Offset: 0x00155A31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowerPollutionRequest()
		{
		}

		// Token: 0x06008DB0 RID: 36272 RVA: 0x00157844 File Offset: 0x00155A44
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

		// Token: 0x06008DB1 RID: 36273 RVA: 0x00157898 File Offset: 0x00155A98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowerPollutionRequest Clone()
		{
			return new FlowerPollutionRequest(this);
		}

		// Token: 0x17001C19 RID: 7193
		// (get) Token: 0x06008DB2 RID: 36274 RVA: 0x001578A0 File Offset: 0x00155AA0
		// (set) Token: 0x06008DB3 RID: 36275 RVA: 0x001578A8 File Offset: 0x00155AA8
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

		// Token: 0x17001C1A RID: 7194
		// (get) Token: 0x06008DB4 RID: 36276 RVA: 0x001578B1 File Offset: 0x00155AB1
		// (set) Token: 0x06008DB5 RID: 36277 RVA: 0x001578B9 File Offset: 0x00155AB9
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

		// Token: 0x17001C1B RID: 7195
		// (get) Token: 0x06008DB6 RID: 36278 RVA: 0x001578C2 File Offset: 0x00155AC2
		// (set) Token: 0x06008DB7 RID: 36279 RVA: 0x001578CA File Offset: 0x00155ACA
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

		// Token: 0x17001C1C RID: 7196
		// (get) Token: 0x06008DB8 RID: 36280 RVA: 0x001578D3 File Offset: 0x00155AD3
		// (set) Token: 0x06008DB9 RID: 36281 RVA: 0x001578DB File Offset: 0x00155ADB
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

		// Token: 0x06008DBA RID: 36282 RVA: 0x001578EE File Offset: 0x00155AEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlowerPollutionRequest);
		}

		// Token: 0x06008DBB RID: 36283 RVA: 0x001578FC File Offset: 0x00155AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlowerPollutionRequest other)
		{
			return other != null && (other == this || (this.ManagerEntityId == other.ManagerEntityId && this.SourceEntityId == other.SourceEntityId && this.TargetEntityId == other.TargetEntityId && !(this.SwitchToTargetState != other.SwitchToTargetState) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008DBC RID: 36284 RVA: 0x0015796C File Offset: 0x00155B6C
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

		// Token: 0x06008DBD RID: 36285 RVA: 0x001579F8 File Offset: 0x00155BF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008DBE RID: 36286 RVA: 0x00157A05 File Offset: 0x00155C05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008DBF RID: 36287 RVA: 0x00157A10 File Offset: 0x00155C10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TargetEntityId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.TargetEntityId);
			}
			if (this.SwitchToTargetState.Length != 0)
			{
				output.WriteRawTag(66);
				output.WriteString(this.SwitchToTargetState);
			}
			if (this.ManagerEntityId != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.ManagerEntityId);
			}
			if (this.SourceEntityId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.SourceEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008DC0 RID: 36288 RVA: 0x00157AA8 File Offset: 0x00155CA8
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

		// Token: 0x06008DC1 RID: 36289 RVA: 0x00157B34 File Offset: 0x00155D34
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

		// Token: 0x06008DC2 RID: 36290 RVA: 0x00157BB1 File Offset: 0x00155DB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008DC3 RID: 36291 RVA: 0x00157BBC File Offset: 0x00155DBC
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
				if (num <= 66U)
				{
					if (num == 40U)
					{
						this.TargetEntityId = input.ReadInt64();
						continue;
					}
					if (num == 66U)
					{
						this.SwitchToTargetState = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.ManagerEntityId = input.ReadInt64();
						continue;
					}
					if (num == 96U)
					{
						this.SourceEntityId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400451E RID: 17694
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400451F RID: 17695
		public const int ManagerEntityIdFieldNumber = 9;

		// Token: 0x04004520 RID: 17696
		private long managerEntityId_;

		// Token: 0x04004521 RID: 17697
		public const int SourceEntityIdFieldNumber = 12;

		// Token: 0x04004522 RID: 17698
		private long sourceEntityId_;

		// Token: 0x04004523 RID: 17699
		public const int TargetEntityIdFieldNumber = 5;

		// Token: 0x04004524 RID: 17700
		private long targetEntityId_;

		// Token: 0x04004525 RID: 17701
		public const int SwitchToTargetStateFieldNumber = 8;

		// Token: 0x04004526 RID: 17702
		private string switchToTargetState_ = "";
	}
}
