using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003F2 RID: 1010
	[NetMessage(EMessageId.DropCatchLevelFinishRequest)]
	public sealed class DropCatchLevelFinishRequest : IMessage<DropCatchLevelFinishRequest>, IMessage, IEquatable<DropCatchLevelFinishRequest>, IDeepCloneable<DropCatchLevelFinishRequest>, IBufferMessage
	{
		// Token: 0x0600620D RID: 25101 RVA: 0x000EC688 File Offset: 0x000EA888
		[NullableContext(1)]
		public static DropCatchLevelFinishRequest Create()
		{
			return new DropCatchLevelFinishRequest();
		}

		// Token: 0x17001242 RID: 4674
		// (get) Token: 0x0600620E RID: 25102 RVA: 0x000EC68F File Offset: 0x000EA88F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001243 RID: 4675
		// (get) Token: 0x0600620F RID: 25103 RVA: 0x000EC692 File Offset: 0x000EA892
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DropCatchLevelFinishRequest.Descriptor;
			}
		}

		// Token: 0x06006210 RID: 25104 RVA: 0x000EC699 File Offset: 0x000EA899
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropCatchLevelFinishRequest()
		{
		}

		// Token: 0x06006211 RID: 25105 RVA: 0x000EC6A1 File Offset: 0x000EA8A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropCatchLevelFinishRequest(DropCatchLevelFinishRequest other) : this()
		{
			this.dropCatchId_ = other.dropCatchId_;
			this.score_ = other.score_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006212 RID: 25106 RVA: 0x000EC6D2 File Offset: 0x000EA8D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropCatchLevelFinishRequest Clone()
		{
			return new DropCatchLevelFinishRequest(this);
		}

		// Token: 0x17001244 RID: 4676
		// (get) Token: 0x06006213 RID: 25107 RVA: 0x000EC6DA File Offset: 0x000EA8DA
		// (set) Token: 0x06006214 RID: 25108 RVA: 0x000EC6E2 File Offset: 0x000EA8E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DropCatchId
		{
			get
			{
				return this.dropCatchId_;
			}
			set
			{
				this.dropCatchId_ = value;
			}
		}

		// Token: 0x17001245 RID: 4677
		// (get) Token: 0x06006215 RID: 25109 RVA: 0x000EC6EB File Offset: 0x000EA8EB
		// (set) Token: 0x06006216 RID: 25110 RVA: 0x000EC6F3 File Offset: 0x000EA8F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Score
		{
			get
			{
				return this.score_;
			}
			set
			{
				this.score_ = value;
			}
		}

		// Token: 0x06006217 RID: 25111 RVA: 0x000EC6FC File Offset: 0x000EA8FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DropCatchLevelFinishRequest);
		}

		// Token: 0x06006218 RID: 25112 RVA: 0x000EC70A File Offset: 0x000EA90A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DropCatchLevelFinishRequest other)
		{
			return other != null && (other == this || (this.DropCatchId == other.DropCatchId && this.Score == other.Score && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006219 RID: 25113 RVA: 0x000EC748 File Offset: 0x000EA948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DropCatchId != 0)
			{
				num ^= this.DropCatchId.GetHashCode();
			}
			if (this.Score != 0)
			{
				num ^= this.Score.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600621A RID: 25114 RVA: 0x000EC7A0 File Offset: 0x000EA9A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600621B RID: 25115 RVA: 0x000EC7AD File Offset: 0x000EA9AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600621C RID: 25116 RVA: 0x000EC7B8 File Offset: 0x000EA9B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DropCatchId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.DropCatchId);
			}
			if (this.Score != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.Score);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600621D RID: 25117 RVA: 0x000EC814 File Offset: 0x000EAA14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DropCatchId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DropCatchId);
			}
			if (this.Score != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Score);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600621E RID: 25118 RVA: 0x000EC86C File Offset: 0x000EAA6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DropCatchLevelFinishRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DropCatchId != 0)
			{
				this.DropCatchId = other.DropCatchId;
			}
			if (other.Score != 0)
			{
				this.Score = other.Score;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600621F RID: 25119 RVA: 0x000EC8BC File Offset: 0x000EAABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006220 RID: 25120 RVA: 0x000EC8C8 File Offset: 0x000EAAC8
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
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Score = input.ReadInt32();
					}
				}
				else
				{
					this.DropCatchId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400381B RID: 14363
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400381C RID: 14364
		public const int DropCatchIdFieldNumber = 9;

		// Token: 0x0400381D RID: 14365
		private int dropCatchId_;

		// Token: 0x0400381E RID: 14366
		public const int ScoreFieldNumber = 13;

		// Token: 0x0400381F RID: 14367
		private int score_;
	}
}
