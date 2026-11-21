using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005B3 RID: 1459
	[NetMessage(EMessageId.FloroRanchPlayRemoveUnitRequest)]
	public sealed class FloroRanchPlayRemoveUnitRequest : IMessage<FloroRanchPlayRemoveUnitRequest>, IMessage, IEquatable<FloroRanchPlayRemoveUnitRequest>, IDeepCloneable<FloroRanchPlayRemoveUnitRequest>, IBufferMessage
	{
		// Token: 0x0600875A RID: 34650 RVA: 0x00146C17 File Offset: 0x00144E17
		[NullableContext(1)]
		public static FloroRanchPlayRemoveUnitRequest Create()
		{
			return new FloroRanchPlayRemoveUnitRequest();
		}

		// Token: 0x17001A86 RID: 6790
		// (get) Token: 0x0600875B RID: 34651 RVA: 0x00146C1E File Offset: 0x00144E1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A87 RID: 6791
		// (get) Token: 0x0600875C RID: 34652 RVA: 0x00146C21 File Offset: 0x00144E21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayRemoveUnitRequest.Descriptor;
			}
		}

		// Token: 0x0600875D RID: 34653 RVA: 0x00146C28 File Offset: 0x00144E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayRemoveUnitRequest()
		{
		}

		// Token: 0x0600875E RID: 34654 RVA: 0x00146C30 File Offset: 0x00144E30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayRemoveUnitRequest(FloroRanchPlayRemoveUnitRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.subInsId_ = other.subInsId_;
			this.unitIncId_ = other.unitIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600875F RID: 34655 RVA: 0x00146C6D File Offset: 0x00144E6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayRemoveUnitRequest Clone()
		{
			return new FloroRanchPlayRemoveUnitRequest(this);
		}

		// Token: 0x17001A88 RID: 6792
		// (get) Token: 0x06008760 RID: 34656 RVA: 0x00146C75 File Offset: 0x00144E75
		// (set) Token: 0x06008761 RID: 34657 RVA: 0x00146C7D File Offset: 0x00144E7D
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

		// Token: 0x17001A89 RID: 6793
		// (get) Token: 0x06008762 RID: 34658 RVA: 0x00146C86 File Offset: 0x00144E86
		// (set) Token: 0x06008763 RID: 34659 RVA: 0x00146C8E File Offset: 0x00144E8E
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

		// Token: 0x17001A8A RID: 6794
		// (get) Token: 0x06008764 RID: 34660 RVA: 0x00146C97 File Offset: 0x00144E97
		// (set) Token: 0x06008765 RID: 34661 RVA: 0x00146C9F File Offset: 0x00144E9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UnitIncId
		{
			get
			{
				return this.unitIncId_;
			}
			set
			{
				this.unitIncId_ = value;
			}
		}

		// Token: 0x06008766 RID: 34662 RVA: 0x00146CA8 File Offset: 0x00144EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayRemoveUnitRequest);
		}

		// Token: 0x06008767 RID: 34663 RVA: 0x00146CB8 File Offset: 0x00144EB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayRemoveUnitRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.SubInsId == other.SubInsId && this.UnitIncId == other.UnitIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008768 RID: 34664 RVA: 0x00146D14 File Offset: 0x00144F14
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
			if (this.UnitIncId != 0)
			{
				num ^= this.UnitIncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008769 RID: 34665 RVA: 0x00146D85 File Offset: 0x00144F85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600876A RID: 34666 RVA: 0x00146D92 File Offset: 0x00144F92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600876B RID: 34667 RVA: 0x00146D9C File Offset: 0x00144F9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ActivityId);
			}
			if (this.SubInsId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.SubInsId);
			}
			if (this.UnitIncId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.UnitIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600876C RID: 34668 RVA: 0x00146E14 File Offset: 0x00145014
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
			if (this.UnitIncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UnitIncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600876D RID: 34669 RVA: 0x00146E84 File Offset: 0x00145084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchPlayRemoveUnitRequest other)
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
			if (other.UnitIncId != 0)
			{
				this.UnitIncId = other.UnitIncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600876E RID: 34670 RVA: 0x00146EE8 File Offset: 0x001450E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600876F RID: 34671 RVA: 0x00146EF4 File Offset: 0x001450F4
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
				if (num != 16U)
				{
					if (num != 40U)
					{
						if (num != 80U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.UnitIncId = input.ReadInt32();
						}
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
		}

		// Token: 0x0400433F RID: 17215
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004340 RID: 17216
		public const int ActivityIdFieldNumber = 2;

		// Token: 0x04004341 RID: 17217
		private int activityId_;

		// Token: 0x04004342 RID: 17218
		public const int SubInsIdFieldNumber = 5;

		// Token: 0x04004343 RID: 17219
		private int subInsId_;

		// Token: 0x04004344 RID: 17220
		public const int UnitIncIdFieldNumber = 10;

		// Token: 0x04004345 RID: 17221
		private int unitIncId_;
	}
}
