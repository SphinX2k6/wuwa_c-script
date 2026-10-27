using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005B0 RID: 1456
	[NetMessage(EMessageId.FloroRanchExecuteSkillPlayRequest)]
	public sealed class FloroRanchExecuteSkillPlayRequest : IMessage<FloroRanchExecuteSkillPlayRequest>, IMessage, IEquatable<FloroRanchExecuteSkillPlayRequest>, IDeepCloneable<FloroRanchExecuteSkillPlayRequest>, IBufferMessage
	{
		// Token: 0x0600868E RID: 34446 RVA: 0x00143688 File Offset: 0x00141888
		[NullableContext(1)]
		public static FloroRanchExecuteSkillPlayRequest Create()
		{
			return new FloroRanchExecuteSkillPlayRequest();
		}

		// Token: 0x17001A42 RID: 6722
		// (get) Token: 0x0600868F RID: 34447 RVA: 0x0014368F File Offset: 0x0014188F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A43 RID: 6723
		// (get) Token: 0x06008690 RID: 34448 RVA: 0x00143692 File Offset: 0x00141892
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchExecuteSkillPlayRequest.Descriptor;
			}
		}

		// Token: 0x06008691 RID: 34449 RVA: 0x00143699 File Offset: 0x00141899
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchExecuteSkillPlayRequest()
		{
		}

		// Token: 0x06008692 RID: 34450 RVA: 0x001436A1 File Offset: 0x001418A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchExecuteSkillPlayRequest(FloroRanchExecuteSkillPlayRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.subInsId_ = other.subInsId_;
			this.incId_ = other.incId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008693 RID: 34451 RVA: 0x001436DE File Offset: 0x001418DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchExecuteSkillPlayRequest Clone()
		{
			return new FloroRanchExecuteSkillPlayRequest(this);
		}

		// Token: 0x17001A44 RID: 6724
		// (get) Token: 0x06008694 RID: 34452 RVA: 0x001436E6 File Offset: 0x001418E6
		// (set) Token: 0x06008695 RID: 34453 RVA: 0x001436EE File Offset: 0x001418EE
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

		// Token: 0x17001A45 RID: 6725
		// (get) Token: 0x06008696 RID: 34454 RVA: 0x001436F7 File Offset: 0x001418F7
		// (set) Token: 0x06008697 RID: 34455 RVA: 0x001436FF File Offset: 0x001418FF
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

		// Token: 0x17001A46 RID: 6726
		// (get) Token: 0x06008698 RID: 34456 RVA: 0x00143708 File Offset: 0x00141908
		// (set) Token: 0x06008699 RID: 34457 RVA: 0x00143710 File Offset: 0x00141910
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

		// Token: 0x0600869A RID: 34458 RVA: 0x00143719 File Offset: 0x00141919
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchExecuteSkillPlayRequest);
		}

		// Token: 0x0600869B RID: 34459 RVA: 0x00143728 File Offset: 0x00141928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchExecuteSkillPlayRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.SubInsId == other.SubInsId && this.IncId == other.IncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600869C RID: 34460 RVA: 0x00143784 File Offset: 0x00141984
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

		// Token: 0x0600869D RID: 34461 RVA: 0x001437F5 File Offset: 0x001419F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600869E RID: 34462 RVA: 0x00143802 File Offset: 0x00141A02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600869F RID: 34463 RVA: 0x0014380C File Offset: 0x00141A0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.IncId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.ActivityId);
			}
			if (this.SubInsId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.SubInsId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060086A0 RID: 34464 RVA: 0x00143884 File Offset: 0x00141A84
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

		// Token: 0x060086A1 RID: 34465 RVA: 0x001438F4 File Offset: 0x00141AF4
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

		// Token: 0x060086A2 RID: 34466 RVA: 0x00143958 File Offset: 0x00141B58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060086A3 RID: 34467 RVA: 0x00143964 File Offset: 0x00141B64
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
					if (num != 80U)
					{
						if (num != 112U)
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

		// Token: 0x0400425A RID: 16986
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400425B RID: 16987
		public const int ActivityIdFieldNumber = 10;

		// Token: 0x0400425C RID: 16988
		private int activityId_;

		// Token: 0x0400425D RID: 16989
		public const int SubInsIdFieldNumber = 14;

		// Token: 0x0400425E RID: 16990
		private int subInsId_;

		// Token: 0x0400425F RID: 16991
		public const int IncIdFieldNumber = 3;

		// Token: 0x04004260 RID: 16992
		private int incId_;
	}
}
