using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200059B RID: 1435
	[NetMessage(EMessageId.FloroRanchExecuteSkillPlayRequest)]
	public sealed class FloroRanchExecuteSkillPlayRequest : IMessage<FloroRanchExecuteSkillPlayRequest>, IMessage, IEquatable<FloroRanchExecuteSkillPlayRequest>, IDeepCloneable<FloroRanchExecuteSkillPlayRequest>, IBufferMessage
	{
		// Token: 0x06008526 RID: 34086 RVA: 0x00140A78 File Offset: 0x0013EC78
		[NullableContext(1)]
		public static FloroRanchExecuteSkillPlayRequest Create()
		{
			return new FloroRanchExecuteSkillPlayRequest();
		}

		// Token: 0x170019F5 RID: 6645
		// (get) Token: 0x06008527 RID: 34087 RVA: 0x00140A7F File Offset: 0x0013EC7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019F6 RID: 6646
		// (get) Token: 0x06008528 RID: 34088 RVA: 0x00140A82 File Offset: 0x0013EC82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchExecuteSkillPlayRequest.Descriptor;
			}
		}

		// Token: 0x06008529 RID: 34089 RVA: 0x00140A89 File Offset: 0x0013EC89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchExecuteSkillPlayRequest()
		{
		}

		// Token: 0x0600852A RID: 34090 RVA: 0x00140A91 File Offset: 0x0013EC91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchExecuteSkillPlayRequest(FloroRanchExecuteSkillPlayRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.subInsId_ = other.subInsId_;
			this.incId_ = other.incId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600852B RID: 34091 RVA: 0x00140ACE File Offset: 0x0013ECCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchExecuteSkillPlayRequest Clone()
		{
			return new FloroRanchExecuteSkillPlayRequest(this);
		}

		// Token: 0x170019F7 RID: 6647
		// (get) Token: 0x0600852C RID: 34092 RVA: 0x00140AD6 File Offset: 0x0013ECD6
		// (set) Token: 0x0600852D RID: 34093 RVA: 0x00140ADE File Offset: 0x0013ECDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x170019F8 RID: 6648
		// (get) Token: 0x0600852E RID: 34094 RVA: 0x00140AE7 File Offset: 0x0013ECE7
		// (set) Token: 0x0600852F RID: 34095 RVA: 0x00140AEF File Offset: 0x0013ECEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SubInsId
		{
			get
			{
				return this.subInsId_;
			}
			set
			{
				this.subInsId_ = value;
			}
		}

		// Token: 0x170019F9 RID: 6649
		// (get) Token: 0x06008530 RID: 34096 RVA: 0x00140AF8 File Offset: 0x0013ECF8
		// (set) Token: 0x06008531 RID: 34097 RVA: 0x00140B00 File Offset: 0x0013ED00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x06008532 RID: 34098 RVA: 0x00140B09 File Offset: 0x0013ED09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchExecuteSkillPlayRequest);
		}

		// Token: 0x06008533 RID: 34099 RVA: 0x00140B18 File Offset: 0x0013ED18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchExecuteSkillPlayRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.SubInsId == other.SubInsId && this.IncId == other.IncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008534 RID: 34100 RVA: 0x00140B74 File Offset: 0x0013ED74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.SubInsId != 0)
			{
				num ^= this.SubInsId.GetHashCode();
			}
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008535 RID: 34101 RVA: 0x00140BE5 File Offset: 0x0013EDE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008536 RID: 34102 RVA: 0x00140BF2 File Offset: 0x0013EDF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008537 RID: 34103 RVA: 0x00140BFC File Offset: 0x0013EDFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.IncId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.ActivityId);
			}
			if (this.SubInsId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.SubInsId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008538 RID: 34104 RVA: 0x00140C74 File Offset: 0x0013EE74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.SubInsId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SubInsId);
			}
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008539 RID: 34105 RVA: 0x00140CE4 File Offset: 0x0013EEE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchExecuteSkillPlayRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.SubInsId != 0)
			{
				this.SubInsId = other.SubInsId;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600853A RID: 34106 RVA: 0x00140D48 File Offset: 0x0013EF48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600853B RID: 34107 RVA: 0x00140D54 File Offset: 0x0013EF54
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
				if (num != 48U)
				{
					if (num != 80U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.SubInsId = input.ReadInt32();
						}
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.IncId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004250 RID: 16976
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004251 RID: 16977
		public const int ActivityIdFieldNumber = 10;

		// Token: 0x04004252 RID: 16978
		private int activityId_;

		// Token: 0x04004253 RID: 16979
		public const int SubInsIdFieldNumber = 15;

		// Token: 0x04004254 RID: 16980
		private int subInsId_;

		// Token: 0x04004255 RID: 16981
		public const int IncIdFieldNumber = 6;

		// Token: 0x04004256 RID: 16982
		private int incId_;
	}
}
