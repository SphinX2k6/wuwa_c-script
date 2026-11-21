using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001AD RID: 429
	[NetMessage(EMessageId.BlackCoastThemeTaskRewardRequest)]
	public sealed class BlackCoastThemeTaskRewardRequest : IMessage<BlackCoastThemeTaskRewardRequest>, IMessage, IEquatable<BlackCoastThemeTaskRewardRequest>, IDeepCloneable<BlackCoastThemeTaskRewardRequest>, IBufferMessage
	{
		// Token: 0x0600325C RID: 12892 RVA: 0x0008045D File Offset: 0x0007E65D
		[NullableContext(1)]
		public static BlackCoastThemeTaskRewardRequest Create()
		{
			return new BlackCoastThemeTaskRewardRequest();
		}

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x0600325D RID: 12893 RVA: 0x00080464 File Offset: 0x0007E664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x0600325E RID: 12894 RVA: 0x00080467 File Offset: 0x0007E667
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BlackCoastThemeTaskRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600325F RID: 12895 RVA: 0x0008046E File Offset: 0x0007E66E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackCoastThemeTaskRewardRequest()
		{
		}

		// Token: 0x06003260 RID: 12896 RVA: 0x00080476 File Offset: 0x0007E676
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackCoastThemeTaskRewardRequest(BlackCoastThemeTaskRewardRequest other) : this()
		{
			this.taskId_ = other.taskId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003261 RID: 12897 RVA: 0x0008049B File Offset: 0x0007E69B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackCoastThemeTaskRewardRequest Clone()
		{
			return new BlackCoastThemeTaskRewardRequest(this);
		}

		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x06003262 RID: 12898 RVA: 0x000804A3 File Offset: 0x0007E6A3
		// (set) Token: 0x06003263 RID: 12899 RVA: 0x000804AB File Offset: 0x0007E6AB
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

		// Token: 0x06003264 RID: 12900 RVA: 0x000804B4 File Offset: 0x0007E6B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BlackCoastThemeTaskRewardRequest);
		}

		// Token: 0x06003265 RID: 12901 RVA: 0x000804C2 File Offset: 0x0007E6C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BlackCoastThemeTaskRewardRequest other)
		{
			return other != null && (other == this || (this.TaskId == other.TaskId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003266 RID: 12902 RVA: 0x000804F0 File Offset: 0x0007E6F0
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

		// Token: 0x06003267 RID: 12903 RVA: 0x0008052F File Offset: 0x0007E72F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003268 RID: 12904 RVA: 0x0008053C File Offset: 0x0007E73C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003269 RID: 12905 RVA: 0x00080545 File Offset: 0x0007E745
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TaskId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.TaskId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600326A RID: 12906 RVA: 0x00080578 File Offset: 0x0007E778
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

		// Token: 0x0600326B RID: 12907 RVA: 0x000805B6 File Offset: 0x0007E7B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BlackCoastThemeTaskRewardRequest other)
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

		// Token: 0x0600326C RID: 12908 RVA: 0x000805E7 File Offset: 0x0007E7E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600326D RID: 12909 RVA: 0x000805F0 File Offset: 0x0007E7F0
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TaskId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040029CA RID: 10698
		private UnknownFieldSet _unknownFields;

		// Token: 0x040029CB RID: 10699
		public const int TaskIdFieldNumber = 9;

		// Token: 0x040029CC RID: 10700
		private int taskId_;
	}
}
