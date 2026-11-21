using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005B1 RID: 1457
	[NetMessage(EMessageId.FloroRanchPlayRefreshShopRequest)]
	public sealed class FloroRanchPlayRefreshShopRequest : IMessage<FloroRanchPlayRefreshShopRequest>, IMessage, IEquatable<FloroRanchPlayRefreshShopRequest>, IDeepCloneable<FloroRanchPlayRefreshShopRequest>, IBufferMessage
	{
		// Token: 0x0600872C RID: 34604 RVA: 0x00146493 File Offset: 0x00144693
		[NullableContext(1)]
		public static FloroRanchPlayRefreshShopRequest Create()
		{
			return new FloroRanchPlayRefreshShopRequest();
		}

		// Token: 0x17001A7B RID: 6779
		// (get) Token: 0x0600872D RID: 34605 RVA: 0x0014649A File Offset: 0x0014469A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A7C RID: 6780
		// (get) Token: 0x0600872E RID: 34606 RVA: 0x0014649D File Offset: 0x0014469D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayRefreshShopRequest.Descriptor;
			}
		}

		// Token: 0x0600872F RID: 34607 RVA: 0x001464A4 File Offset: 0x001446A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayRefreshShopRequest()
		{
		}

		// Token: 0x06008730 RID: 34608 RVA: 0x001464AC File Offset: 0x001446AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayRefreshShopRequest(FloroRanchPlayRefreshShopRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.subInsId_ = other.subInsId_;
			this.incId_ = other.incId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008731 RID: 34609 RVA: 0x001464E9 File Offset: 0x001446E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayRefreshShopRequest Clone()
		{
			return new FloroRanchPlayRefreshShopRequest(this);
		}

		// Token: 0x17001A7D RID: 6781
		// (get) Token: 0x06008732 RID: 34610 RVA: 0x001464F1 File Offset: 0x001446F1
		// (set) Token: 0x06008733 RID: 34611 RVA: 0x001464F9 File Offset: 0x001446F9
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

		// Token: 0x17001A7E RID: 6782
		// (get) Token: 0x06008734 RID: 34612 RVA: 0x00146502 File Offset: 0x00144702
		// (set) Token: 0x06008735 RID: 34613 RVA: 0x0014650A File Offset: 0x0014470A
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

		// Token: 0x17001A7F RID: 6783
		// (get) Token: 0x06008736 RID: 34614 RVA: 0x00146513 File Offset: 0x00144713
		// (set) Token: 0x06008737 RID: 34615 RVA: 0x0014651B File Offset: 0x0014471B
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

		// Token: 0x06008738 RID: 34616 RVA: 0x00146524 File Offset: 0x00144724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayRefreshShopRequest);
		}

		// Token: 0x06008739 RID: 34617 RVA: 0x00146534 File Offset: 0x00144734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayRefreshShopRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.SubInsId == other.SubInsId && this.IncId == other.IncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600873A RID: 34618 RVA: 0x00146590 File Offset: 0x00144790
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

		// Token: 0x0600873B RID: 34619 RVA: 0x00146601 File Offset: 0x00144801
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600873C RID: 34620 RVA: 0x0014660E File Offset: 0x0014480E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600873D RID: 34621 RVA: 0x00146618 File Offset: 0x00144818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.IncId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(72);
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

		// Token: 0x0600873E RID: 34622 RVA: 0x0014668C File Offset: 0x0014488C
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

		// Token: 0x0600873F RID: 34623 RVA: 0x001466FC File Offset: 0x001448FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchPlayRefreshShopRequest other)
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

		// Token: 0x06008740 RID: 34624 RVA: 0x00146760 File Offset: 0x00144960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008741 RID: 34625 RVA: 0x0014676C File Offset: 0x0014496C
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
					if (num != 72U)
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

		// Token: 0x0400432F RID: 17199
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004330 RID: 17200
		public const int ActivityIdFieldNumber = 9;

		// Token: 0x04004331 RID: 17201
		private int activityId_;

		// Token: 0x04004332 RID: 17202
		public const int SubInsIdFieldNumber = 15;

		// Token: 0x04004333 RID: 17203
		private int subInsId_;

		// Token: 0x04004334 RID: 17204
		public const int IncIdFieldNumber = 1;

		// Token: 0x04004335 RID: 17205
		private int incId_;
	}
}
