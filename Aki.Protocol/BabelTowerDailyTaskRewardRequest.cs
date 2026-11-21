using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200014E RID: 334
	[NetMessage(EMessageId.BabelTowerDailyTaskRewardRequest)]
	public sealed class BabelTowerDailyTaskRewardRequest : IMessage<BabelTowerDailyTaskRewardRequest>, IMessage, IEquatable<BabelTowerDailyTaskRewardRequest>, IDeepCloneable<BabelTowerDailyTaskRewardRequest>, IBufferMessage
	{
		// Token: 0x06002AEA RID: 10986 RVA: 0x000709EF File Offset: 0x0006EBEF
		[NullableContext(1)]
		public static BabelTowerDailyTaskRewardRequest Create()
		{
			return new BabelTowerDailyTaskRewardRequest();
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x06002AEB RID: 10987 RVA: 0x000709F6 File Offset: 0x0006EBF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x06002AEC RID: 10988 RVA: 0x000709F9 File Offset: 0x0006EBF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BabelTowerDailyTaskRewardRequest.Descriptor;
			}
		}

		// Token: 0x06002AED RID: 10989 RVA: 0x00070A00 File Offset: 0x0006EC00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerDailyTaskRewardRequest()
		{
		}

		// Token: 0x06002AEE RID: 10990 RVA: 0x00070A08 File Offset: 0x0006EC08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerDailyTaskRewardRequest(BabelTowerDailyTaskRewardRequest other) : this()
		{
			this.taskId_ = other.taskId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002AEF RID: 10991 RVA: 0x00070A2D File Offset: 0x0006EC2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerDailyTaskRewardRequest Clone()
		{
			return new BabelTowerDailyTaskRewardRequest(this);
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06002AF0 RID: 10992 RVA: 0x00070A35 File Offset: 0x0006EC35
		// (set) Token: 0x06002AF1 RID: 10993 RVA: 0x00070A3D File Offset: 0x0006EC3D
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

		// Token: 0x06002AF2 RID: 10994 RVA: 0x00070A46 File Offset: 0x0006EC46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BabelTowerDailyTaskRewardRequest);
		}

		// Token: 0x06002AF3 RID: 10995 RVA: 0x00070A54 File Offset: 0x0006EC54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BabelTowerDailyTaskRewardRequest other)
		{
			return other != null && (other == this || (this.TaskId == other.TaskId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002AF4 RID: 10996 RVA: 0x00070A84 File Offset: 0x0006EC84
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

		// Token: 0x06002AF5 RID: 10997 RVA: 0x00070AC3 File Offset: 0x0006ECC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002AF6 RID: 10998 RVA: 0x00070AD0 File Offset: 0x0006ECD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002AF7 RID: 10999 RVA: 0x00070AD9 File Offset: 0x0006ECD9
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

		// Token: 0x06002AF8 RID: 11000 RVA: 0x00070B0C File Offset: 0x0006ED0C
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

		// Token: 0x06002AF9 RID: 11001 RVA: 0x00070B4A File Offset: 0x0006ED4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BabelTowerDailyTaskRewardRequest other)
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

		// Token: 0x06002AFA RID: 11002 RVA: 0x00070B7B File Offset: 0x0006ED7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002AFB RID: 11003 RVA: 0x00070B84 File Offset: 0x0006ED84
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

		// Token: 0x040027DC RID: 10204
		private UnknownFieldSet _unknownFields;

		// Token: 0x040027DD RID: 10205
		public const int TaskIdFieldNumber = 15;

		// Token: 0x040027DE RID: 10206
		private int taskId_;
	}
}
