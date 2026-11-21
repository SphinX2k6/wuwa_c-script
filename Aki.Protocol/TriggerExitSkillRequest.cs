using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014E0 RID: 5344
	[NetMessage(EMessageId.TriggerExitSkillRequest)]
	public sealed class TriggerExitSkillRequest : IMessage<TriggerExitSkillRequest>, IMessage, IEquatable<TriggerExitSkillRequest>, IDeepCloneable<TriggerExitSkillRequest>, IBufferMessage
	{
		// Token: 0x0601C57C RID: 116092 RVA: 0x0041CE04 File Offset: 0x0041B004
		[NullableContext(1)]
		public static TriggerExitSkillRequest Create()
		{
			return new TriggerExitSkillRequest();
		}

		// Token: 0x17005FF1 RID: 24561
		// (get) Token: 0x0601C57D RID: 116093 RVA: 0x0041CE0B File Offset: 0x0041B00B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005FF2 RID: 24562
		// (get) Token: 0x0601C57E RID: 116094 RVA: 0x0041CE0E File Offset: 0x0041B00E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TriggerExitSkillRequest.Descriptor;
			}
		}

		// Token: 0x0601C57F RID: 116095 RVA: 0x0041CE15 File Offset: 0x0041B015
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TriggerExitSkillRequest()
		{
		}

		// Token: 0x0601C580 RID: 116096 RVA: 0x0041CE1D File Offset: 0x0041B01D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TriggerExitSkillRequest(TriggerExitSkillRequest other) : this()
		{
			this.enterEntityId_ = other.enterEntityId_;
			this.leaveEntityId_ = other.leaveEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C581 RID: 116097 RVA: 0x0041CE4E File Offset: 0x0041B04E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TriggerExitSkillRequest Clone()
		{
			return new TriggerExitSkillRequest(this);
		}

		// Token: 0x17005FF3 RID: 24563
		// (get) Token: 0x0601C582 RID: 116098 RVA: 0x0041CE56 File Offset: 0x0041B056
		// (set) Token: 0x0601C583 RID: 116099 RVA: 0x0041CE5E File Offset: 0x0041B05E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EnterEntityId
		{
			get
			{
				return this.enterEntityId_;
			}
			set
			{
				this.enterEntityId_ = value;
			}
		}

		// Token: 0x17005FF4 RID: 24564
		// (get) Token: 0x0601C584 RID: 116100 RVA: 0x0041CE67 File Offset: 0x0041B067
		// (set) Token: 0x0601C585 RID: 116101 RVA: 0x0041CE6F File Offset: 0x0041B06F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LeaveEntityId
		{
			get
			{
				return this.leaveEntityId_;
			}
			set
			{
				this.leaveEntityId_ = value;
			}
		}

		// Token: 0x0601C586 RID: 116102 RVA: 0x0041CE78 File Offset: 0x0041B078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TriggerExitSkillRequest);
		}

		// Token: 0x0601C587 RID: 116103 RVA: 0x0041CE86 File Offset: 0x0041B086
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TriggerExitSkillRequest other)
		{
			return other != null && (other == this || (this.EnterEntityId == other.EnterEntityId && this.LeaveEntityId == other.LeaveEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C588 RID: 116104 RVA: 0x0041CEC4 File Offset: 0x0041B0C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EnterEntityId != 0L)
			{
				num ^= this.EnterEntityId.GetHashCode();
			}
			if (this.LeaveEntityId != 0L)
			{
				num ^= this.LeaveEntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C589 RID: 116105 RVA: 0x0041CF1C File Offset: 0x0041B11C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C58A RID: 116106 RVA: 0x0041CF29 File Offset: 0x0041B129
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C58B RID: 116107 RVA: 0x0041CF34 File Offset: 0x0041B134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LeaveEntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.LeaveEntityId);
			}
			if (this.EnterEntityId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.EnterEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C58C RID: 116108 RVA: 0x0041CF8C File Offset: 0x0041B18C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EnterEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EnterEntityId);
			}
			if (this.LeaveEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.LeaveEntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C58D RID: 116109 RVA: 0x0041CFE4 File Offset: 0x0041B1E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TriggerExitSkillRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EnterEntityId != 0L)
			{
				this.EnterEntityId = other.EnterEntityId;
			}
			if (other.LeaveEntityId != 0L)
			{
				this.LeaveEntityId = other.LeaveEntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C58E RID: 116110 RVA: 0x0041D034 File Offset: 0x0041B234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C58F RID: 116111 RVA: 0x0041D040 File Offset: 0x0041B240
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
					if (num != 24U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EnterEntityId = input.ReadInt64();
					}
				}
				else
				{
					this.LeaveEntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400A3C8 RID: 41928
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A3C9 RID: 41929
		public const int EnterEntityIdFieldNumber = 3;

		// Token: 0x0400A3CA RID: 41930
		private long enterEntityId_;

		// Token: 0x0400A3CB RID: 41931
		public const int LeaveEntityIdFieldNumber = 1;

		// Token: 0x0400A3CC RID: 41932
		private long leaveEntityId_;
	}
}
