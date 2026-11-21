using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000599 RID: 1433
	[NetMessage(EMessageId.FloroRanchEventChoiceRequest)]
	public sealed class FloroRanchEventChoiceRequest : IMessage<FloroRanchEventChoiceRequest>, IMessage, IEquatable<FloroRanchEventChoiceRequest>, IDeepCloneable<FloroRanchEventChoiceRequest>, IBufferMessage
	{
		// Token: 0x060084FA RID: 34042 RVA: 0x001403CF File Offset: 0x0013E5CF
		[NullableContext(1)]
		public static FloroRanchEventChoiceRequest Create()
		{
			return new FloroRanchEventChoiceRequest();
		}

		// Token: 0x170019EB RID: 6635
		// (get) Token: 0x060084FB RID: 34043 RVA: 0x001403D6 File Offset: 0x0013E5D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019EC RID: 6636
		// (get) Token: 0x060084FC RID: 34044 RVA: 0x001403D9 File Offset: 0x0013E5D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchEventChoiceRequest.Descriptor;
			}
		}

		// Token: 0x060084FD RID: 34045 RVA: 0x001403E0 File Offset: 0x0013E5E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchEventChoiceRequest()
		{
		}

		// Token: 0x060084FE RID: 34046 RVA: 0x001403E8 File Offset: 0x0013E5E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchEventChoiceRequest(FloroRanchEventChoiceRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.subInsId_ = other.subInsId_;
			this.incId_ = other.incId_;
			this.choice_ = other.choice_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060084FF RID: 34047 RVA: 0x0014043C File Offset: 0x0013E63C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchEventChoiceRequest Clone()
		{
			return new FloroRanchEventChoiceRequest(this);
		}

		// Token: 0x170019ED RID: 6637
		// (get) Token: 0x06008500 RID: 34048 RVA: 0x00140444 File Offset: 0x0013E644
		// (set) Token: 0x06008501 RID: 34049 RVA: 0x0014044C File Offset: 0x0013E64C
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

		// Token: 0x170019EE RID: 6638
		// (get) Token: 0x06008502 RID: 34050 RVA: 0x00140455 File Offset: 0x0013E655
		// (set) Token: 0x06008503 RID: 34051 RVA: 0x0014045D File Offset: 0x0013E65D
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

		// Token: 0x170019EF RID: 6639
		// (get) Token: 0x06008504 RID: 34052 RVA: 0x00140466 File Offset: 0x0013E666
		// (set) Token: 0x06008505 RID: 34053 RVA: 0x0014046E File Offset: 0x0013E66E
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

		// Token: 0x170019F0 RID: 6640
		// (get) Token: 0x06008506 RID: 34054 RVA: 0x00140477 File Offset: 0x0013E677
		// (set) Token: 0x06008507 RID: 34055 RVA: 0x0014047F File Offset: 0x0013E67F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Choice
		{
			get
			{
				return this.choice_;
			}
			set
			{
				this.choice_ = value;
			}
		}

		// Token: 0x06008508 RID: 34056 RVA: 0x00140488 File Offset: 0x0013E688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchEventChoiceRequest);
		}

		// Token: 0x06008509 RID: 34057 RVA: 0x00140498 File Offset: 0x0013E698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchEventChoiceRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.SubInsId == other.SubInsId && this.IncId == other.IncId && this.Choice == other.Choice && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600850A RID: 34058 RVA: 0x00140504 File Offset: 0x0013E704
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
			if (this.Choice != 0)
			{
				num ^= this.Choice.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600850B RID: 34059 RVA: 0x0014058E File Offset: 0x0013E78E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600850C RID: 34060 RVA: 0x0014059B File Offset: 0x0013E79B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600850D RID: 34061 RVA: 0x001405A4 File Offset: 0x0013E7A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SubInsId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SubInsId);
			}
			if (this.IncId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.IncId);
			}
			if (this.Choice != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Choice);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600850E RID: 34062 RVA: 0x00140634 File Offset: 0x0013E834
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
			if (this.Choice != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Choice);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600850F RID: 34063 RVA: 0x001406BC File Offset: 0x0013E8BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchEventChoiceRequest other)
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
			if (other.Choice != 0)
			{
				this.Choice = other.Choice;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008510 RID: 34064 RVA: 0x00140734 File Offset: 0x0013E934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008511 RID: 34065 RVA: 0x00140740 File Offset: 0x0013E940
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
				if (num <= 80U)
				{
					if (num == 8U)
					{
						this.SubInsId = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.IncId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.Choice = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004241 RID: 16961
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004242 RID: 16962
		public const int ActivityIdFieldNumber = 15;

		// Token: 0x04004243 RID: 16963
		private int activityId_;

		// Token: 0x04004244 RID: 16964
		public const int SubInsIdFieldNumber = 1;

		// Token: 0x04004245 RID: 16965
		private int subInsId_;

		// Token: 0x04004246 RID: 16966
		public const int IncIdFieldNumber = 10;

		// Token: 0x04004247 RID: 16967
		private int incId_;

		// Token: 0x04004248 RID: 16968
		public const int ChoiceFieldNumber = 12;

		// Token: 0x04004249 RID: 16969
		private int choice_;
	}
}
