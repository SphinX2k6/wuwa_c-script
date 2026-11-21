using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200059D RID: 1437
	[NetMessage(EMessageId.FloroRanchFirstEnterRequest)]
	public sealed class FloroRanchFirstEnterRequest : IMessage<FloroRanchFirstEnterRequest>, IMessage, IEquatable<FloroRanchFirstEnterRequest>, IDeepCloneable<FloroRanchFirstEnterRequest>, IBufferMessage
	{
		// Token: 0x06008550 RID: 34128 RVA: 0x00141070 File Offset: 0x0013F270
		[NullableContext(1)]
		public static FloroRanchFirstEnterRequest Create()
		{
			return new FloroRanchFirstEnterRequest();
		}

		// Token: 0x170019FE RID: 6654
		// (get) Token: 0x06008551 RID: 34129 RVA: 0x00141077 File Offset: 0x0013F277
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019FF RID: 6655
		// (get) Token: 0x06008552 RID: 34130 RVA: 0x0014107A File Offset: 0x0013F27A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchFirstEnterRequest.Descriptor;
			}
		}

		// Token: 0x06008553 RID: 34131 RVA: 0x00141081 File Offset: 0x0013F281
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchFirstEnterRequest()
		{
		}

		// Token: 0x06008554 RID: 34132 RVA: 0x00141089 File Offset: 0x0013F289
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchFirstEnterRequest(FloroRanchFirstEnterRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.subInsId_ = other.subInsId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008555 RID: 34133 RVA: 0x001410BA File Offset: 0x0013F2BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchFirstEnterRequest Clone()
		{
			return new FloroRanchFirstEnterRequest(this);
		}

		// Token: 0x17001A00 RID: 6656
		// (get) Token: 0x06008556 RID: 34134 RVA: 0x001410C2 File Offset: 0x0013F2C2
		// (set) Token: 0x06008557 RID: 34135 RVA: 0x001410CA File Offset: 0x0013F2CA
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

		// Token: 0x17001A01 RID: 6657
		// (get) Token: 0x06008558 RID: 34136 RVA: 0x001410D3 File Offset: 0x0013F2D3
		// (set) Token: 0x06008559 RID: 34137 RVA: 0x001410DB File Offset: 0x0013F2DB
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

		// Token: 0x0600855A RID: 34138 RVA: 0x001410E4 File Offset: 0x0013F2E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchFirstEnterRequest);
		}

		// Token: 0x0600855B RID: 34139 RVA: 0x001410F2 File Offset: 0x0013F2F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchFirstEnterRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.SubInsId == other.SubInsId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600855C RID: 34140 RVA: 0x00141130 File Offset: 0x0013F330
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

		// Token: 0x0600855D RID: 34141 RVA: 0x00141188 File Offset: 0x0013F388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600855E RID: 34142 RVA: 0x00141195 File Offset: 0x0013F395
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600855F RID: 34143 RVA: 0x001411A0 File Offset: 0x0013F3A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SubInsId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.SubInsId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008560 RID: 34144 RVA: 0x001411FC File Offset: 0x0013F3FC
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

		// Token: 0x06008561 RID: 34145 RVA: 0x00141254 File Offset: 0x0013F454
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

		// Token: 0x06008562 RID: 34146 RVA: 0x001412A4 File Offset: 0x0013F4A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008563 RID: 34147 RVA: 0x001412B0 File Offset: 0x0013F4B0
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
				if (num != 80U)
				{
					if (num != 96U)
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

		// Token: 0x0400425D RID: 16989
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400425E RID: 16990
		public const int ActivityIdFieldNumber = 12;

		// Token: 0x0400425F RID: 16991
		private int activityId_;

		// Token: 0x04004260 RID: 16992
		public const int SubInsIdFieldNumber = 10;

		// Token: 0x04004261 RID: 16993
		private int subInsId_;
	}
}
