using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011A3 RID: 4515
	public sealed class ScratchCardTimeInfo : IMessage<ScratchCardTimeInfo>, IMessage, IEquatable<ScratchCardTimeInfo>, IDeepCloneable<ScratchCardTimeInfo>, IBufferMessage
	{
		// Token: 0x060180EA RID: 98538 RVA: 0x0037E449 File Offset: 0x0037C649
		[NullableContext(1)]
		public static ScratchCardTimeInfo Create()
		{
			return new ScratchCardTimeInfo();
		}

		// Token: 0x170050D9 RID: 20697
		// (get) Token: 0x060180EB RID: 98539 RVA: 0x0037E450 File Offset: 0x0037C650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ScratchCardTimeInfo> Parser
		{
			get
			{
				return ScratchCardTimeInfo._parser;
			}
		}

		// Token: 0x170050DA RID: 20698
		// (get) Token: 0x060180EC RID: 98540 RVA: 0x0037E457 File Offset: 0x0037C657
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170050DB RID: 20699
		// (get) Token: 0x060180ED RID: 98541 RVA: 0x0037E45A File Offset: 0x0037C65A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ScratchCardTimeInfo.Descriptor;
			}
		}

		// Token: 0x060180EE RID: 98542 RVA: 0x0037E461 File Offset: 0x0037C661
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScratchCardTimeInfo()
		{
		}

		// Token: 0x060180EF RID: 98543 RVA: 0x0037E469 File Offset: 0x0037C669
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScratchCardTimeInfo(ScratchCardTimeInfo other) : this()
		{
			this.id_ = other.id_;
			this.progress_ = other.progress_;
			this.finishCount_ = other.finishCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060180F0 RID: 98544 RVA: 0x0037E4A6 File Offset: 0x0037C6A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScratchCardTimeInfo Clone()
		{
			return new ScratchCardTimeInfo(this);
		}

		// Token: 0x170050DC RID: 20700
		// (get) Token: 0x060180F1 RID: 98545 RVA: 0x0037E4AE File Offset: 0x0037C6AE
		// (set) Token: 0x060180F2 RID: 98546 RVA: 0x0037E4B6 File Offset: 0x0037C6B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x170050DD RID: 20701
		// (get) Token: 0x060180F3 RID: 98547 RVA: 0x0037E4BF File Offset: 0x0037C6BF
		// (set) Token: 0x060180F4 RID: 98548 RVA: 0x0037E4C7 File Offset: 0x0037C6C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Progress
		{
			get
			{
				return this.progress_;
			}
			set
			{
				this.progress_ = value;
			}
		}

		// Token: 0x170050DE RID: 20702
		// (get) Token: 0x060180F5 RID: 98549 RVA: 0x0037E4D0 File Offset: 0x0037C6D0
		// (set) Token: 0x060180F6 RID: 98550 RVA: 0x0037E4D8 File Offset: 0x0037C6D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FinishCount
		{
			get
			{
				return this.finishCount_;
			}
			set
			{
				this.finishCount_ = value;
			}
		}

		// Token: 0x060180F7 RID: 98551 RVA: 0x0037E4E1 File Offset: 0x0037C6E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ScratchCardTimeInfo);
		}

		// Token: 0x060180F8 RID: 98552 RVA: 0x0037E4F0 File Offset: 0x0037C6F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ScratchCardTimeInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Progress == other.Progress && this.FinishCount == other.FinishCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060180F9 RID: 98553 RVA: 0x0037E54C File Offset: 0x0037C74C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Progress != 0)
			{
				num ^= this.Progress.GetHashCode();
			}
			if (this.FinishCount != 0)
			{
				num ^= this.FinishCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060180FA RID: 98554 RVA: 0x0037E5BD File Offset: 0x0037C7BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060180FB RID: 98555 RVA: 0x0037E5CA File Offset: 0x0037C7CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060180FC RID: 98556 RVA: 0x0037E5D4 File Offset: 0x0037C7D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Progress != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Progress);
			}
			if (this.FinishCount != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.FinishCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060180FD RID: 98557 RVA: 0x0037E648 File Offset: 0x0037C848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Progress != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Progress);
			}
			if (this.FinishCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FinishCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060180FE RID: 98558 RVA: 0x0037E6B8 File Offset: 0x0037C8B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ScratchCardTimeInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Progress != 0)
			{
				this.Progress = other.Progress;
			}
			if (other.FinishCount != 0)
			{
				this.FinishCount = other.FinishCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060180FF RID: 98559 RVA: 0x0037E71C File Offset: 0x0037C91C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018100 RID: 98560 RVA: 0x0037E728 File Offset: 0x0037C928
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
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.FinishCount = input.ReadInt32();
						}
					}
					else
					{
						this.Progress = input.ReadInt32();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008E6C RID: 36460
		private static readonly MessageParser<ScratchCardTimeInfo> _parser = new MessageParser<ScratchCardTimeInfo>(() => new ScratchCardTimeInfo());

		// Token: 0x04008E6D RID: 36461
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008E6E RID: 36462
		public const int IdFieldNumber = 1;

		// Token: 0x04008E6F RID: 36463
		private int id_;

		// Token: 0x04008E70 RID: 36464
		public const int ProgressFieldNumber = 2;

		// Token: 0x04008E71 RID: 36465
		private int progress_;

		// Token: 0x04008E72 RID: 36466
		public const int FinishCountFieldNumber = 3;

		// Token: 0x04008E73 RID: 36467
		private int finishCount_;
	}
}
