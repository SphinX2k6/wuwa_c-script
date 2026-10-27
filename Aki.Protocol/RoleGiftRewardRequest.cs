using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001080 RID: 4224
	[NetMessage(EMessageId.RoleGiftRewardRequest)]
	public sealed class RoleGiftRewardRequest : IMessage<RoleGiftRewardRequest>, IMessage, IEquatable<RoleGiftRewardRequest>, IDeepCloneable<RoleGiftRewardRequest>, IBufferMessage
	{
		// Token: 0x0601690C RID: 92428 RVA: 0x00347974 File Offset: 0x00345B74
		[NullableContext(1)]
		public static RoleGiftRewardRequest Create()
		{
			return new RoleGiftRewardRequest();
		}

		// Token: 0x17004B8C RID: 19340
		// (get) Token: 0x0601690D RID: 92429 RVA: 0x0034797B File Offset: 0x00345B7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B8D RID: 19341
		// (get) Token: 0x0601690E RID: 92430 RVA: 0x0034797E File Offset: 0x00345B7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleGiftRewardRequest.Descriptor;
			}
		}

		// Token: 0x0601690F RID: 92431 RVA: 0x00347985 File Offset: 0x00345B85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleGiftRewardRequest()
		{
		}

		// Token: 0x06016910 RID: 92432 RVA: 0x0034798D File Offset: 0x00345B8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleGiftRewardRequest(RoleGiftRewardRequest other) : this()
		{
			this.taskId_ = other.taskId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016911 RID: 92433 RVA: 0x003479B2 File Offset: 0x00345BB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleGiftRewardRequest Clone()
		{
			return new RoleGiftRewardRequest(this);
		}

		// Token: 0x17004B8E RID: 19342
		// (get) Token: 0x06016912 RID: 92434 RVA: 0x003479BA File Offset: 0x00345BBA
		// (set) Token: 0x06016913 RID: 92435 RVA: 0x003479C2 File Offset: 0x00345BC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TaskId
		{
			get
			{
				return this.taskId_;
			}
			set
			{
				this.taskId_ = value;
			}
		}

		// Token: 0x06016914 RID: 92436 RVA: 0x003479CB File Offset: 0x00345BCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleGiftRewardRequest);
		}

		// Token: 0x06016915 RID: 92437 RVA: 0x003479D9 File Offset: 0x00345BD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleGiftRewardRequest other)
		{
			return other != null && (other == this || (this.TaskId == other.TaskId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016916 RID: 92438 RVA: 0x00347A08 File Offset: 0x00345C08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TaskId != 0)
			{
				num ^= this.TaskId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016917 RID: 92439 RVA: 0x00347A47 File Offset: 0x00345C47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016918 RID: 92440 RVA: 0x00347A54 File Offset: 0x00345C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016919 RID: 92441 RVA: 0x00347A5D File Offset: 0x00345C5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TaskId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.TaskId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601691A RID: 92442 RVA: 0x00347A90 File Offset: 0x00345C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TaskId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TaskId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601691B RID: 92443 RVA: 0x00347ACE File Offset: 0x00345CCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleGiftRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TaskId != 0)
			{
				this.TaskId = other.TaskId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601691C RID: 92444 RVA: 0x00347AFF File Offset: 0x00345CFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601691D RID: 92445 RVA: 0x00347B08 File Offset: 0x00345D08
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
					this.TaskId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040086D9 RID: 34521
		private UnknownFieldSet _unknownFields;

		// Token: 0x040086DA RID: 34522
		public const int TaskIdFieldNumber = 15;

		// Token: 0x040086DB RID: 34523
		private int taskId_;
	}
}
