using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200028A RID: 650
	public sealed class ChildQuestNodeInfo : IMessage<ChildQuestNodeInfo>, IMessage, IEquatable<ChildQuestNodeInfo>, IDeepCloneable<ChildQuestNodeInfo>, IBufferMessage
	{
		// Token: 0x060043D4 RID: 17364 RVA: 0x000A6078 File Offset: 0x000A4278
		[NullableContext(1)]
		public static ChildQuestNodeInfo Create()
		{
			return new ChildQuestNodeInfo();
		}

		// Token: 0x17000B8F RID: 2959
		// (get) Token: 0x060043D5 RID: 17365 RVA: 0x000A607F File Offset: 0x000A427F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B90 RID: 2960
		// (get) Token: 0x060043D6 RID: 17366 RVA: 0x000A6082 File Offset: 0x000A4282
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChildQuestNodeInfo.Descriptor;
			}
		}

		// Token: 0x060043D7 RID: 17367 RVA: 0x000A6089 File Offset: 0x000A4289
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChildQuestNodeInfo()
		{
		}

		// Token: 0x060043D8 RID: 17368 RVA: 0x000A6094 File Offset: 0x000A4294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChildQuestNodeInfo(ChildQuestNodeInfo other) : this()
		{
			this.status_ = other.status_;
			this.progress_ = ((other.progress_ != null) ? other.progress_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060043D9 RID: 17369 RVA: 0x000A60E0 File Offset: 0x000A42E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChildQuestNodeInfo Clone()
		{
			return new ChildQuestNodeInfo(this);
		}

		// Token: 0x17000B91 RID: 2961
		// (get) Token: 0x060043DA RID: 17370 RVA: 0x000A60E8 File Offset: 0x000A42E8
		// (set) Token: 0x060043DB RID: 17371 RVA: 0x000A60F0 File Offset: 0x000A42F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChildQuestNodeStatus Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		// Token: 0x17000B92 RID: 2962
		// (get) Token: 0x060043DC RID: 17372 RVA: 0x000A60F9 File Offset: 0x000A42F9
		// (set) Token: 0x060043DD RID: 17373 RVA: 0x000A6101 File Offset: 0x000A4301
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChildQuestNodeProgress Progress
		{
			get
			{
				return this.progress_;
			}
			set
			{
				this.progress_ = value;
			}
		}

		// Token: 0x060043DE RID: 17374 RVA: 0x000A610A File Offset: 0x000A430A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChildQuestNodeInfo);
		}

		// Token: 0x060043DF RID: 17375 RVA: 0x000A6118 File Offset: 0x000A4318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChildQuestNodeInfo other)
		{
			return other != null && (other == this || (this.Status == other.Status && object.Equals(this.Progress, other.Progress) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060043E0 RID: 17376 RVA: 0x000A6168 File Offset: 0x000A4368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Status != ChildQuestNodeStatus.CqnsNotActive)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this.progress_ != null)
			{
				num ^= this.Progress.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060043E1 RID: 17377 RVA: 0x000A61C3 File Offset: 0x000A43C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060043E2 RID: 17378 RVA: 0x000A61D0 File Offset: 0x000A43D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060043E3 RID: 17379 RVA: 0x000A61DC File Offset: 0x000A43DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Status != ChildQuestNodeStatus.CqnsNotActive)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Status);
			}
			if (this.progress_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Progress);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060043E4 RID: 17380 RVA: 0x000A6234 File Offset: 0x000A4434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Status != ChildQuestNodeStatus.CqnsNotActive)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Status);
			}
			if (this.progress_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Progress);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060043E5 RID: 17381 RVA: 0x000A628C File Offset: 0x000A448C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChildQuestNodeInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Status != ChildQuestNodeStatus.CqnsNotActive)
			{
				this.Status = other.Status;
			}
			if (other.progress_ != null)
			{
				if (this.progress_ == null)
				{
					this.Progress = new ChildQuestNodeProgress();
				}
				this.Progress.MergeFrom(other.Progress);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060043E6 RID: 17382 RVA: 0x000A62F4 File Offset: 0x000A44F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060043E7 RID: 17383 RVA: 0x000A6300 File Offset: 0x000A4500
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
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.progress_ == null)
						{
							this.Progress = new ChildQuestNodeProgress();
						}
						input.ReadMessage(this.Progress);
					}
				}
				else
				{
					this.Status = (ChildQuestNodeStatus)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002E65 RID: 11877
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E66 RID: 11878
		public const int StatusFieldNumber = 1;

		// Token: 0x04002E67 RID: 11879
		private ChildQuestNodeStatus status_;

		// Token: 0x04002E68 RID: 11880
		public const int ProgressFieldNumber = 2;

		// Token: 0x04002E69 RID: 11881
		private ChildQuestNodeProgress progress_;
	}
}
