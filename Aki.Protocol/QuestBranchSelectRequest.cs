using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DF9 RID: 3577
	[NetMessage(EMessageId.QuestBranchSelectRequest)]
	public sealed class QuestBranchSelectRequest : IMessage<QuestBranchSelectRequest>, IMessage, IEquatable<QuestBranchSelectRequest>, IDeepCloneable<QuestBranchSelectRequest>, IBufferMessage
	{
		// Token: 0x0601341C RID: 78876 RVA: 0x002CE267 File Offset: 0x002CC467
		[NullableContext(1)]
		public static QuestBranchSelectRequest Create()
		{
			return new QuestBranchSelectRequest();
		}

		// Token: 0x17003FE5 RID: 16357
		// (get) Token: 0x0601341D RID: 78877 RVA: 0x002CE26E File Offset: 0x002CC46E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003FE6 RID: 16358
		// (get) Token: 0x0601341E RID: 78878 RVA: 0x002CE271 File Offset: 0x002CC471
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestBranchSelectRequest.Descriptor;
			}
		}

		// Token: 0x0601341F RID: 78879 RVA: 0x002CE278 File Offset: 0x002CC478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestBranchSelectRequest()
		{
		}

		// Token: 0x06013420 RID: 78880 RVA: 0x002CE280 File Offset: 0x002CC480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestBranchSelectRequest(QuestBranchSelectRequest other) : this()
		{
			this.branchPageId_ = other.branchPageId_;
			this.branchId_ = other.branchId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013421 RID: 78881 RVA: 0x002CE2B1 File Offset: 0x002CC4B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestBranchSelectRequest Clone()
		{
			return new QuestBranchSelectRequest(this);
		}

		// Token: 0x17003FE7 RID: 16359
		// (get) Token: 0x06013422 RID: 78882 RVA: 0x002CE2B9 File Offset: 0x002CC4B9
		// (set) Token: 0x06013423 RID: 78883 RVA: 0x002CE2C1 File Offset: 0x002CC4C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BranchPageId
		{
			get
			{
				return this.branchPageId_;
			}
			set
			{
				this.branchPageId_ = value;
			}
		}

		// Token: 0x17003FE8 RID: 16360
		// (get) Token: 0x06013424 RID: 78884 RVA: 0x002CE2CA File Offset: 0x002CC4CA
		// (set) Token: 0x06013425 RID: 78885 RVA: 0x002CE2D2 File Offset: 0x002CC4D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BranchId
		{
			get
			{
				return this.branchId_;
			}
			set
			{
				this.branchId_ = value;
			}
		}

		// Token: 0x06013426 RID: 78886 RVA: 0x002CE2DB File Offset: 0x002CC4DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestBranchSelectRequest);
		}

		// Token: 0x06013427 RID: 78887 RVA: 0x002CE2E9 File Offset: 0x002CC4E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestBranchSelectRequest other)
		{
			return other != null && (other == this || (this.BranchPageId == other.BranchPageId && this.BranchId == other.BranchId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013428 RID: 78888 RVA: 0x002CE328 File Offset: 0x002CC528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BranchPageId != 0)
			{
				num ^= this.BranchPageId.GetHashCode();
			}
			if (this.BranchId != 0)
			{
				num ^= this.BranchId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013429 RID: 78889 RVA: 0x002CE380 File Offset: 0x002CC580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601342A RID: 78890 RVA: 0x002CE38D File Offset: 0x002CC58D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601342B RID: 78891 RVA: 0x002CE398 File Offset: 0x002CC598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BranchId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.BranchId);
			}
			if (this.BranchPageId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.BranchPageId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601342C RID: 78892 RVA: 0x002CE3F4 File Offset: 0x002CC5F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BranchPageId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BranchPageId);
			}
			if (this.BranchId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BranchId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601342D RID: 78893 RVA: 0x002CE44C File Offset: 0x002CC64C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestBranchSelectRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BranchPageId != 0)
			{
				this.BranchPageId = other.BranchPageId;
			}
			if (other.BranchId != 0)
			{
				this.BranchId = other.BranchId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601342E RID: 78894 RVA: 0x002CE49C File Offset: 0x002CC69C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601342F RID: 78895 RVA: 0x002CE4A8 File Offset: 0x002CC6A8
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
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.BranchPageId = input.ReadInt32();
					}
				}
				else
				{
					this.BranchId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040076D7 RID: 30423
		private UnknownFieldSet _unknownFields;

		// Token: 0x040076D8 RID: 30424
		public const int BranchPageIdFieldNumber = 13;

		// Token: 0x040076D9 RID: 30425
		private int branchPageId_;

		// Token: 0x040076DA RID: 30426
		public const int BranchIdFieldNumber = 6;

		// Token: 0x040076DB RID: 30427
		private int branchId_;
	}
}
