using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005B2 RID: 1458
	[NetMessage(EMessageId.FloroRanchFirstEnterRequest)]
	public sealed class FloroRanchFirstEnterRequest : IMessage<FloroRanchFirstEnterRequest>, IMessage, IEquatable<FloroRanchFirstEnterRequest>, IDeepCloneable<FloroRanchFirstEnterRequest>, IBufferMessage
	{
		// Token: 0x060086B8 RID: 34488 RVA: 0x00143C80 File Offset: 0x00141E80
		[NullableContext(1)]
		public static FloroRanchFirstEnterRequest Create()
		{
			return new FloroRanchFirstEnterRequest();
		}

		// Token: 0x17001A4B RID: 6731
		// (get) Token: 0x060086B9 RID: 34489 RVA: 0x00143C87 File Offset: 0x00141E87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A4C RID: 6732
		// (get) Token: 0x060086BA RID: 34490 RVA: 0x00143C8A File Offset: 0x00141E8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchFirstEnterRequest.Descriptor;
			}
		}

		// Token: 0x060086BB RID: 34491 RVA: 0x00143C91 File Offset: 0x00141E91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchFirstEnterRequest()
		{
		}

		// Token: 0x060086BC RID: 34492 RVA: 0x00143C99 File Offset: 0x00141E99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchFirstEnterRequest(FloroRanchFirstEnterRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.subInsId_ = other.subInsId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060086BD RID: 34493 RVA: 0x00143CCA File Offset: 0x00141ECA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchFirstEnterRequest Clone()
		{
			return new FloroRanchFirstEnterRequest(this);
		}

		// Token: 0x17001A4D RID: 6733
		// (get) Token: 0x060086BE RID: 34494 RVA: 0x00143CD2 File Offset: 0x00141ED2
		// (set) Token: 0x060086BF RID: 34495 RVA: 0x00143CDA File Offset: 0x00141EDA
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

		// Token: 0x17001A4E RID: 6734
		// (get) Token: 0x060086C0 RID: 34496 RVA: 0x00143CE3 File Offset: 0x00141EE3
		// (set) Token: 0x060086C1 RID: 34497 RVA: 0x00143CEB File Offset: 0x00141EEB
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

		// Token: 0x060086C2 RID: 34498 RVA: 0x00143CF4 File Offset: 0x00141EF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchFirstEnterRequest);
		}

		// Token: 0x060086C3 RID: 34499 RVA: 0x00143D02 File Offset: 0x00141F02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchFirstEnterRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.SubInsId == other.SubInsId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060086C4 RID: 34500 RVA: 0x00143D40 File Offset: 0x00141F40
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060086C5 RID: 34501 RVA: 0x00143D98 File Offset: 0x00141F98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060086C6 RID: 34502 RVA: 0x00143DA5 File Offset: 0x00141FA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060086C7 RID: 34503 RVA: 0x00143DB0 File Offset: 0x00141FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SubInsId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.SubInsId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060086C8 RID: 34504 RVA: 0x00143E0C File Offset: 0x0014200C
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060086C9 RID: 34505 RVA: 0x00143E64 File Offset: 0x00142064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchFirstEnterRequest other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060086CA RID: 34506 RVA: 0x00143EB4 File Offset: 0x001420B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060086CB RID: 34507 RVA: 0x00143EC0 File Offset: 0x001420C0
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
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.SubInsId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004267 RID: 16999
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004268 RID: 17000
		public const int ActivityIdFieldNumber = 13;

		// Token: 0x04004269 RID: 17001
		private int activityId_;

		// Token: 0x0400426A RID: 17002
		public const int SubInsIdFieldNumber = 5;

		// Token: 0x0400426B RID: 17003
		private int subInsId_;
	}
}
