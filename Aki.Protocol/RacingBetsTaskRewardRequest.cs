using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E6B RID: 3691
	[NetMessage(EMessageId.RacingBetsTaskRewardRequest)]
	public sealed class RacingBetsTaskRewardRequest : IMessage<RacingBetsTaskRewardRequest>, IMessage, IEquatable<RacingBetsTaskRewardRequest>, IDeepCloneable<RacingBetsTaskRewardRequest>, IBufferMessage
	{
		// Token: 0x06013DAA RID: 81322 RVA: 0x002E4B59 File Offset: 0x002E2D59
		[NullableContext(1)]
		public static RacingBetsTaskRewardRequest Create()
		{
			return new RacingBetsTaskRewardRequest();
		}

		// Token: 0x1700420B RID: 16907
		// (get) Token: 0x06013DAB RID: 81323 RVA: 0x002E4B60 File Offset: 0x002E2D60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700420C RID: 16908
		// (get) Token: 0x06013DAC RID: 81324 RVA: 0x002E4B63 File Offset: 0x002E2D63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsTaskRewardRequest.Descriptor;
			}
		}

		// Token: 0x06013DAD RID: 81325 RVA: 0x002E4B6A File Offset: 0x002E2D6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsTaskRewardRequest()
		{
		}

		// Token: 0x06013DAE RID: 81326 RVA: 0x002E4B72 File Offset: 0x002E2D72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsTaskRewardRequest(RacingBetsTaskRewardRequest other) : this()
		{
			this.taskId_ = other.taskId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013DAF RID: 81327 RVA: 0x002E4B97 File Offset: 0x002E2D97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsTaskRewardRequest Clone()
		{
			return new RacingBetsTaskRewardRequest(this);
		}

		// Token: 0x1700420D RID: 16909
		// (get) Token: 0x06013DB0 RID: 81328 RVA: 0x002E4B9F File Offset: 0x002E2D9F
		// (set) Token: 0x06013DB1 RID: 81329 RVA: 0x002E4BA7 File Offset: 0x002E2DA7
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

		// Token: 0x06013DB2 RID: 81330 RVA: 0x002E4BB0 File Offset: 0x002E2DB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsTaskRewardRequest);
		}

		// Token: 0x06013DB3 RID: 81331 RVA: 0x002E4BBE File Offset: 0x002E2DBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsTaskRewardRequest other)
		{
			return other != null && (other == this || (this.TaskId == other.TaskId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013DB4 RID: 81332 RVA: 0x002E4BEC File Offset: 0x002E2DEC
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

		// Token: 0x06013DB5 RID: 81333 RVA: 0x002E4C2B File Offset: 0x002E2E2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013DB6 RID: 81334 RVA: 0x002E4C38 File Offset: 0x002E2E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013DB7 RID: 81335 RVA: 0x002E4C41 File Offset: 0x002E2E41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TaskId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.TaskId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013DB8 RID: 81336 RVA: 0x002E4C74 File Offset: 0x002E2E74
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

		// Token: 0x06013DB9 RID: 81337 RVA: 0x002E4CB2 File Offset: 0x002E2EB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsTaskRewardRequest other)
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

		// Token: 0x06013DBA RID: 81338 RVA: 0x002E4CE3 File Offset: 0x002E2EE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013DBB RID: 81339 RVA: 0x002E4CEC File Offset: 0x002E2EEC
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TaskId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040079DA RID: 31194
		private UnknownFieldSet _unknownFields;

		// Token: 0x040079DB RID: 31195
		public const int TaskIdFieldNumber = 13;

		// Token: 0x040079DC RID: 31196
		private int taskId_;
	}
}
