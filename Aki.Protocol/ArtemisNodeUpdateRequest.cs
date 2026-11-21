using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000119 RID: 281
	[NetMessage(EMessageId.ArtemisNodeUpdateRequest)]
	public sealed class ArtemisNodeUpdateRequest : IMessage<ArtemisNodeUpdateRequest>, IMessage, IEquatable<ArtemisNodeUpdateRequest>, IDeepCloneable<ArtemisNodeUpdateRequest>, IBufferMessage
	{
		// Token: 0x06002684 RID: 9860 RVA: 0x000667F3 File Offset: 0x000649F3
		[NullableContext(1)]
		public static ArtemisNodeUpdateRequest Create()
		{
			return new ArtemisNodeUpdateRequest();
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06002685 RID: 9861 RVA: 0x000667FA File Offset: 0x000649FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06002686 RID: 9862 RVA: 0x000667FD File Offset: 0x000649FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ArtemisNodeUpdateRequest.Descriptor;
			}
		}

		// Token: 0x06002687 RID: 9863 RVA: 0x00066804 File Offset: 0x00064A04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArtemisNodeUpdateRequest()
		{
		}

		// Token: 0x06002688 RID: 9864 RVA: 0x0006680C File Offset: 0x00064A0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArtemisNodeUpdateRequest(ArtemisNodeUpdateRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.index_ = other.index_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002689 RID: 9865 RVA: 0x0006683D File Offset: 0x00064A3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArtemisNodeUpdateRequest Clone()
		{
			return new ArtemisNodeUpdateRequest(this);
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x0600268A RID: 9866 RVA: 0x00066845 File Offset: 0x00064A45
		// (set) Token: 0x0600268B RID: 9867 RVA: 0x0006684D File Offset: 0x00064A4D
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

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x0600268C RID: 9868 RVA: 0x00066856 File Offset: 0x00064A56
		// (set) Token: 0x0600268D RID: 9869 RVA: 0x0006685E File Offset: 0x00064A5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x0600268E RID: 9870 RVA: 0x00066867 File Offset: 0x00064A67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ArtemisNodeUpdateRequest);
		}

		// Token: 0x0600268F RID: 9871 RVA: 0x00066875 File Offset: 0x00064A75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ArtemisNodeUpdateRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.Index == other.Index && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002690 RID: 9872 RVA: 0x000668B4 File Offset: 0x00064AB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002691 RID: 9873 RVA: 0x0006690C File Offset: 0x00064B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002692 RID: 9874 RVA: 0x00066919 File Offset: 0x00064B19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002693 RID: 9875 RVA: 0x00066924 File Offset: 0x00064B24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Index != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Index);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002694 RID: 9876 RVA: 0x00066980 File Offset: 0x00064B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002695 RID: 9877 RVA: 0x000669D8 File Offset: 0x00064BD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ArtemisNodeUpdateRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002696 RID: 9878 RVA: 0x00066A28 File Offset: 0x00064C28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002697 RID: 9879 RVA: 0x00066A34 File Offset: 0x00064C34
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
				if (num != 32U)
				{
					if (num != 112U)
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
					this.Index = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400266C RID: 9836
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400266D RID: 9837
		public const int ActivityIdFieldNumber = 14;

		// Token: 0x0400266E RID: 9838
		private int activityId_;

		// Token: 0x0400266F RID: 9839
		public const int IndexFieldNumber = 4;

		// Token: 0x04002670 RID: 9840
		private int index_;
	}
}
