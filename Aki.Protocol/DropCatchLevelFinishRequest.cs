using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000409 RID: 1033
	[NetMessage(EMessageId.DropCatchLevelFinishRequest)]
	public sealed class DropCatchLevelFinishRequest : IMessage<DropCatchLevelFinishRequest>, IMessage, IEquatable<DropCatchLevelFinishRequest>, IDeepCloneable<DropCatchLevelFinishRequest>, IBufferMessage
	{
		// Token: 0x0600639D RID: 25501 RVA: 0x000EF800 File Offset: 0x000EDA00
		[NullableContext(1)]
		public static DropCatchLevelFinishRequest Create()
		{
			return new DropCatchLevelFinishRequest();
		}

		// Token: 0x17001297 RID: 4759
		// (get) Token: 0x0600639E RID: 25502 RVA: 0x000EF807 File Offset: 0x000EDA07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001298 RID: 4760
		// (get) Token: 0x0600639F RID: 25503 RVA: 0x000EF80A File Offset: 0x000EDA0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DropCatchLevelFinishRequest.Descriptor;
			}
		}

		// Token: 0x060063A0 RID: 25504 RVA: 0x000EF811 File Offset: 0x000EDA11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropCatchLevelFinishRequest()
		{
		}

		// Token: 0x060063A1 RID: 25505 RVA: 0x000EF819 File Offset: 0x000EDA19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropCatchLevelFinishRequest(DropCatchLevelFinishRequest other) : this()
		{
			this.dropCatchId_ = other.dropCatchId_;
			this.score_ = other.score_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060063A2 RID: 25506 RVA: 0x000EF84A File Offset: 0x000EDA4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropCatchLevelFinishRequest Clone()
		{
			return new DropCatchLevelFinishRequest(this);
		}

		// Token: 0x17001299 RID: 4761
		// (get) Token: 0x060063A3 RID: 25507 RVA: 0x000EF852 File Offset: 0x000EDA52
		// (set) Token: 0x060063A4 RID: 25508 RVA: 0x000EF85A File Offset: 0x000EDA5A
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

		// Token: 0x1700129A RID: 4762
		// (get) Token: 0x060063A5 RID: 25509 RVA: 0x000EF863 File Offset: 0x000EDA63
		// (set) Token: 0x060063A6 RID: 25510 RVA: 0x000EF86B File Offset: 0x000EDA6B
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

		// Token: 0x060063A7 RID: 25511 RVA: 0x000EF874 File Offset: 0x000EDA74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DropCatchLevelFinishRequest);
		}

		// Token: 0x060063A8 RID: 25512 RVA: 0x000EF882 File Offset: 0x000EDA82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DropCatchLevelFinishRequest other)
		{
			return other != null && (other == this || (this.DropCatchId == other.DropCatchId && this.Score == other.Score && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060063A9 RID: 25513 RVA: 0x000EF8C0 File Offset: 0x000EDAC0
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

		// Token: 0x060063AA RID: 25514 RVA: 0x000EF918 File Offset: 0x000EDB18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060063AB RID: 25515 RVA: 0x000EF925 File Offset: 0x000EDB25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060063AC RID: 25516 RVA: 0x000EF930 File Offset: 0x000EDB30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DropCatchId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.DropCatchId);
			}
			if (this.Score != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.Score);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060063AD RID: 25517 RVA: 0x000EF988 File Offset: 0x000EDB88
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

		// Token: 0x060063AE RID: 25518 RVA: 0x000EF9E0 File Offset: 0x000EDBE0
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

		// Token: 0x060063AF RID: 25519 RVA: 0x000EFA30 File Offset: 0x000EDC30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060063B0 RID: 25520 RVA: 0x000EFA3C File Offset: 0x000EDC3C
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
					if (num != 80U)
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

		// Token: 0x0400382E RID: 14382
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400382F RID: 14383
		public const int DropCatchIdFieldNumber = 1;

		// Token: 0x04003830 RID: 14384
		private int dropCatchId_;

		// Token: 0x04003831 RID: 14385
		public const int ScoreFieldNumber = 10;

		// Token: 0x04003832 RID: 14386
		private int score_;
	}
}
