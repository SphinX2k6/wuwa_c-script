using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000325 RID: 805
	[NetMessage(EMessageId.DailyQuestChangePreferRequest)]
	public sealed class DailyQuestChangePreferRequest : IMessage<DailyQuestChangePreferRequest>, IMessage, IEquatable<DailyQuestChangePreferRequest>, IDeepCloneable<DailyQuestChangePreferRequest>, IBufferMessage
	{
		// Token: 0x060050E4 RID: 20708 RVA: 0x000C4F68 File Offset: 0x000C3168
		[NullableContext(1)]
		public static DailyQuestChangePreferRequest Create()
		{
			return new DailyQuestChangePreferRequest();
		}

		// Token: 0x17000E84 RID: 3716
		// (get) Token: 0x060050E5 RID: 20709 RVA: 0x000C4F6F File Offset: 0x000C316F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E85 RID: 3717
		// (get) Token: 0x060050E6 RID: 20710 RVA: 0x000C4F72 File Offset: 0x000C3172
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DailyQuestChangePreferRequest.Descriptor;
			}
		}

		// Token: 0x060050E7 RID: 20711 RVA: 0x000C4F79 File Offset: 0x000C3179
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyQuestChangePreferRequest()
		{
		}

		// Token: 0x060050E8 RID: 20712 RVA: 0x000C4F81 File Offset: 0x000C3181
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyQuestChangePreferRequest(DailyQuestChangePreferRequest other) : this()
		{
			this.targetArea_ = other.targetArea_;
			this.targetInfluence_ = other.targetInfluence_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060050E9 RID: 20713 RVA: 0x000C4FB2 File Offset: 0x000C31B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyQuestChangePreferRequest Clone()
		{
			return new DailyQuestChangePreferRequest(this);
		}

		// Token: 0x17000E86 RID: 3718
		// (get) Token: 0x060050EA RID: 20714 RVA: 0x000C4FBA File Offset: 0x000C31BA
		// (set) Token: 0x060050EB RID: 20715 RVA: 0x000C4FC2 File Offset: 0x000C31C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TargetArea
		{
			get
			{
				return this.targetArea_;
			}
			set
			{
				this.targetArea_ = value;
			}
		}

		// Token: 0x17000E87 RID: 3719
		// (get) Token: 0x060050EC RID: 20716 RVA: 0x000C4FCB File Offset: 0x000C31CB
		// (set) Token: 0x060050ED RID: 20717 RVA: 0x000C4FD3 File Offset: 0x000C31D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TargetInfluence
		{
			get
			{
				return this.targetInfluence_;
			}
			set
			{
				this.targetInfluence_ = value;
			}
		}

		// Token: 0x060050EE RID: 20718 RVA: 0x000C4FDC File Offset: 0x000C31DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DailyQuestChangePreferRequest);
		}

		// Token: 0x060050EF RID: 20719 RVA: 0x000C4FEA File Offset: 0x000C31EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DailyQuestChangePreferRequest other)
		{
			return other != null && (other == this || (this.TargetArea == other.TargetArea && this.TargetInfluence == other.TargetInfluence && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060050F0 RID: 20720 RVA: 0x000C5028 File Offset: 0x000C3228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TargetArea != 0)
			{
				num ^= this.TargetArea.GetHashCode();
			}
			if (this.TargetInfluence != 0)
			{
				num ^= this.TargetInfluence.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060050F1 RID: 20721 RVA: 0x000C5080 File Offset: 0x000C3280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060050F2 RID: 20722 RVA: 0x000C508D File Offset: 0x000C328D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060050F3 RID: 20723 RVA: 0x000C5098 File Offset: 0x000C3298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TargetArea != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.TargetArea);
			}
			if (this.TargetInfluence != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.TargetInfluence);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060050F4 RID: 20724 RVA: 0x000C50F4 File Offset: 0x000C32F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TargetArea != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetArea);
			}
			if (this.TargetInfluence != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetInfluence);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060050F5 RID: 20725 RVA: 0x000C514C File Offset: 0x000C334C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DailyQuestChangePreferRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TargetArea != 0)
			{
				this.TargetArea = other.TargetArea;
			}
			if (other.TargetInfluence != 0)
			{
				this.TargetInfluence = other.TargetInfluence;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060050F6 RID: 20726 RVA: 0x000C519C File Offset: 0x000C339C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060050F7 RID: 20727 RVA: 0x000C51A8 File Offset: 0x000C33A8
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
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.TargetInfluence = input.ReadInt32();
					}
				}
				else
				{
					this.TargetArea = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003280 RID: 12928
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003281 RID: 12929
		public const int TargetAreaFieldNumber = 9;

		// Token: 0x04003282 RID: 12930
		private int targetArea_;

		// Token: 0x04003283 RID: 12931
		public const int TargetInfluenceFieldNumber = 12;

		// Token: 0x04003284 RID: 12932
		private int targetInfluence_;
	}
}
