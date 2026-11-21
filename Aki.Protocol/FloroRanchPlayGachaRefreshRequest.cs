using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005A7 RID: 1447
	[NetMessage(EMessageId.FloroRanchPlayGachaRefreshRequest)]
	public sealed class FloroRanchPlayGachaRefreshRequest : IMessage<FloroRanchPlayGachaRefreshRequest>, IMessage, IEquatable<FloroRanchPlayGachaRefreshRequest>, IDeepCloneable<FloroRanchPlayGachaRefreshRequest>, IBufferMessage
	{
		// Token: 0x06008635 RID: 34357 RVA: 0x00143806 File Offset: 0x00141A06
		[NullableContext(1)]
		public static FloroRanchPlayGachaRefreshRequest Create()
		{
			return new FloroRanchPlayGachaRefreshRequest();
		}

		// Token: 0x17001A3A RID: 6714
		// (get) Token: 0x06008636 RID: 34358 RVA: 0x0014380D File Offset: 0x00141A0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A3B RID: 6715
		// (get) Token: 0x06008637 RID: 34359 RVA: 0x00143810 File Offset: 0x00141A10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayGachaRefreshRequest.Descriptor;
			}
		}

		// Token: 0x06008638 RID: 34360 RVA: 0x00143817 File Offset: 0x00141A17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayGachaRefreshRequest()
		{
		}

		// Token: 0x06008639 RID: 34361 RVA: 0x0014381F File Offset: 0x00141A1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayGachaRefreshRequest(FloroRanchPlayGachaRefreshRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.subInsId_ = other.subInsId_;
			this.incId_ = other.incId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600863A RID: 34362 RVA: 0x0014385C File Offset: 0x00141A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayGachaRefreshRequest Clone()
		{
			return new FloroRanchPlayGachaRefreshRequest(this);
		}

		// Token: 0x17001A3C RID: 6716
		// (get) Token: 0x0600863B RID: 34363 RVA: 0x00143864 File Offset: 0x00141A64
		// (set) Token: 0x0600863C RID: 34364 RVA: 0x0014386C File Offset: 0x00141A6C
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

		// Token: 0x17001A3D RID: 6717
		// (get) Token: 0x0600863D RID: 34365 RVA: 0x00143875 File Offset: 0x00141A75
		// (set) Token: 0x0600863E RID: 34366 RVA: 0x0014387D File Offset: 0x00141A7D
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

		// Token: 0x17001A3E RID: 6718
		// (get) Token: 0x0600863F RID: 34367 RVA: 0x00143886 File Offset: 0x00141A86
		// (set) Token: 0x06008640 RID: 34368 RVA: 0x0014388E File Offset: 0x00141A8E
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

		// Token: 0x06008641 RID: 34369 RVA: 0x00143897 File Offset: 0x00141A97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayGachaRefreshRequest);
		}

		// Token: 0x06008642 RID: 34370 RVA: 0x001438A8 File Offset: 0x00141AA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayGachaRefreshRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.SubInsId == other.SubInsId && this.IncId == other.IncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008643 RID: 34371 RVA: 0x00143904 File Offset: 0x00141B04
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

		// Token: 0x06008644 RID: 34372 RVA: 0x00143975 File Offset: 0x00141B75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008645 RID: 34373 RVA: 0x00143982 File Offset: 0x00141B82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008646 RID: 34374 RVA: 0x0014398C File Offset: 0x00141B8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.IncId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(112);
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

		// Token: 0x06008647 RID: 34375 RVA: 0x00143A04 File Offset: 0x00141C04
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

		// Token: 0x06008648 RID: 34376 RVA: 0x00143A74 File Offset: 0x00141C74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchPlayGachaRefreshRequest other)
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

		// Token: 0x06008649 RID: 34377 RVA: 0x00143AD8 File Offset: 0x00141CD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600864A RID: 34378 RVA: 0x00143AE4 File Offset: 0x00141CE4
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
				if (num != 72U)
				{
					if (num != 112U)
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

		// Token: 0x040042C4 RID: 17092
		private UnknownFieldSet _unknownFields;

		// Token: 0x040042C5 RID: 17093
		public const int ActivityIdFieldNumber = 14;

		// Token: 0x040042C6 RID: 17094
		private int activityId_;

		// Token: 0x040042C7 RID: 17095
		public const int SubInsIdFieldNumber = 15;

		// Token: 0x040042C8 RID: 17096
		private int subInsId_;

		// Token: 0x040042C9 RID: 17097
		public const int IncIdFieldNumber = 9;

		// Token: 0x040042CA RID: 17098
		private int incId_;
	}
}
