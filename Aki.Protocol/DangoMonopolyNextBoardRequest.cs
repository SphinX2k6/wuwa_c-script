using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000389 RID: 905
	[NetMessage(EMessageId.DangoMonopolyNextBoardRequest)]
	public sealed class DangoMonopolyNextBoardRequest : IMessage<DangoMonopolyNextBoardRequest>, IMessage, IEquatable<DangoMonopolyNextBoardRequest>, IDeepCloneable<DangoMonopolyNextBoardRequest>, IBufferMessage
	{
		// Token: 0x06005981 RID: 22913 RVA: 0x000D9FB8 File Offset: 0x000D81B8
		[NullableContext(1)]
		public static DangoMonopolyNextBoardRequest Create()
		{
			return new DangoMonopolyNextBoardRequest();
		}

		// Token: 0x17001083 RID: 4227
		// (get) Token: 0x06005982 RID: 22914 RVA: 0x000D9FBF File Offset: 0x000D81BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001084 RID: 4228
		// (get) Token: 0x06005983 RID: 22915 RVA: 0x000D9FC2 File Offset: 0x000D81C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoMonopolyNextBoardRequest.Descriptor;
			}
		}

		// Token: 0x06005984 RID: 22916 RVA: 0x000D9FC9 File Offset: 0x000D81C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyNextBoardRequest()
		{
		}

		// Token: 0x06005985 RID: 22917 RVA: 0x000D9FD1 File Offset: 0x000D81D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyNextBoardRequest(DangoMonopolyNextBoardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005986 RID: 22918 RVA: 0x000D9FF6 File Offset: 0x000D81F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyNextBoardRequest Clone()
		{
			return new DangoMonopolyNextBoardRequest(this);
		}

		// Token: 0x17001085 RID: 4229
		// (get) Token: 0x06005987 RID: 22919 RVA: 0x000D9FFE File Offset: 0x000D81FE
		// (set) Token: 0x06005988 RID: 22920 RVA: 0x000DA006 File Offset: 0x000D8206
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

		// Token: 0x06005989 RID: 22921 RVA: 0x000DA00F File Offset: 0x000D820F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoMonopolyNextBoardRequest);
		}

		// Token: 0x0600598A RID: 22922 RVA: 0x000DA01D File Offset: 0x000D821D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoMonopolyNextBoardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600598B RID: 22923 RVA: 0x000DA04C File Offset: 0x000D824C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600598C RID: 22924 RVA: 0x000DA08B File Offset: 0x000D828B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600598D RID: 22925 RVA: 0x000DA098 File Offset: 0x000D8298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600598E RID: 22926 RVA: 0x000DA0A1 File Offset: 0x000D82A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600598F RID: 22927 RVA: 0x000DA0D4 File Offset: 0x000D82D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005990 RID: 22928 RVA: 0x000DA112 File Offset: 0x000D8312
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoMonopolyNextBoardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005991 RID: 22929 RVA: 0x000DA143 File Offset: 0x000D8343
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005992 RID: 22930 RVA: 0x000DA14C File Offset: 0x000D834C
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003569 RID: 13673
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400356A RID: 13674
		public const int ActivityIdFieldNumber = 6;

		// Token: 0x0400356B RID: 13675
		private int activityId_;
	}
}
