using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000722 RID: 1826
	[NetMessage(EMessageId.GuideCondDoneNotify)]
	public sealed class GuideCondDoneNotify : IMessage<GuideCondDoneNotify>, IMessage, IEquatable<GuideCondDoneNotify>, IDeepCloneable<GuideCondDoneNotify>, IBufferMessage
	{
		// Token: 0x0600A5F0 RID: 42480 RVA: 0x001904ED File Offset: 0x0018E6ED
		[NullableContext(1)]
		public static GuideCondDoneNotify Create()
		{
			return new GuideCondDoneNotify();
		}

		// Token: 0x17002165 RID: 8549
		// (get) Token: 0x0600A5F1 RID: 42481 RVA: 0x001904F4 File Offset: 0x0018E6F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002166 RID: 8550
		// (get) Token: 0x0600A5F2 RID: 42482 RVA: 0x001904F7 File Offset: 0x0018E6F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GuideCondDoneNotify.Descriptor;
			}
		}

		// Token: 0x0600A5F3 RID: 42483 RVA: 0x001904FE File Offset: 0x0018E6FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuideCondDoneNotify()
		{
		}

		// Token: 0x0600A5F4 RID: 42484 RVA: 0x00190506 File Offset: 0x0018E706
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuideCondDoneNotify(GuideCondDoneNotify other) : this()
		{
			this.groupId_ = other.groupId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A5F5 RID: 42485 RVA: 0x0019052B File Offset: 0x0018E72B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuideCondDoneNotify Clone()
		{
			return new GuideCondDoneNotify(this);
		}

		// Token: 0x17002167 RID: 8551
		// (get) Token: 0x0600A5F6 RID: 42486 RVA: 0x00190533 File Offset: 0x0018E733
		// (set) Token: 0x0600A5F7 RID: 42487 RVA: 0x0019053B File Offset: 0x0018E73B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GroupId
		{
			get
			{
				return this.groupId_;
			}
			set
			{
				this.groupId_ = value;
			}
		}

		// Token: 0x0600A5F8 RID: 42488 RVA: 0x00190544 File Offset: 0x0018E744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GuideCondDoneNotify);
		}

		// Token: 0x0600A5F9 RID: 42489 RVA: 0x00190552 File Offset: 0x0018E752
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GuideCondDoneNotify other)
		{
			return other != null && (other == this || (this.GroupId == other.GroupId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A5FA RID: 42490 RVA: 0x00190580 File Offset: 0x0018E780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GroupId != 0)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A5FB RID: 42491 RVA: 0x001905BF File Offset: 0x0018E7BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A5FC RID: 42492 RVA: 0x001905CC File Offset: 0x0018E7CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A5FD RID: 42493 RVA: 0x001905D5 File Offset: 0x0018E7D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GroupId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.GroupId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A5FE RID: 42494 RVA: 0x00190608 File Offset: 0x0018E808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GroupId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GroupId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A5FF RID: 42495 RVA: 0x00190646 File Offset: 0x0018E846
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GuideCondDoneNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GroupId != 0)
			{
				this.GroupId = other.GroupId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A600 RID: 42496 RVA: 0x00190677 File Offset: 0x0018E877
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A601 RID: 42497 RVA: 0x00190680 File Offset: 0x0018E880
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.GroupId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004C3D RID: 19517
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C3E RID: 19518
		public const int GroupIdFieldNumber = 15;

		// Token: 0x04004C3F RID: 19519
		private int groupId_;
	}
}
