using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F68 RID: 3944
	[NetMessage(EMessageId.RiskHarvestStarRewardRequest)]
	public sealed class RiskHarvestStarRewardRequest : IMessage<RiskHarvestStarRewardRequest>, IMessage, IEquatable<RiskHarvestStarRewardRequest>, IDeepCloneable<RiskHarvestStarRewardRequest>, IBufferMessage
	{
		// Token: 0x0601516A RID: 86378 RVA: 0x0030EC5B File Offset: 0x0030CE5B
		[NullableContext(1)]
		public static RiskHarvestStarRewardRequest Create()
		{
			return new RiskHarvestStarRewardRequest();
		}

		// Token: 0x17004624 RID: 17956
		// (get) Token: 0x0601516B RID: 86379 RVA: 0x0030EC62 File Offset: 0x0030CE62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004625 RID: 17957
		// (get) Token: 0x0601516C RID: 86380 RVA: 0x0030EC65 File Offset: 0x0030CE65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RiskHarvestStarRewardRequest.Descriptor;
			}
		}

		// Token: 0x0601516D RID: 86381 RVA: 0x0030EC6C File Offset: 0x0030CE6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestStarRewardRequest()
		{
		}

		// Token: 0x0601516E RID: 86382 RVA: 0x0030EC74 File Offset: 0x0030CE74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestStarRewardRequest(RiskHarvestStarRewardRequest other) : this()
		{
			this.id_ = other.id_;
			this.index_ = other.index_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601516F RID: 86383 RVA: 0x0030ECA5 File Offset: 0x0030CEA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestStarRewardRequest Clone()
		{
			return new RiskHarvestStarRewardRequest(this);
		}

		// Token: 0x17004626 RID: 17958
		// (get) Token: 0x06015170 RID: 86384 RVA: 0x0030ECAD File Offset: 0x0030CEAD
		// (set) Token: 0x06015171 RID: 86385 RVA: 0x0030ECB5 File Offset: 0x0030CEB5
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

		// Token: 0x17004627 RID: 17959
		// (get) Token: 0x06015172 RID: 86386 RVA: 0x0030ECBE File Offset: 0x0030CEBE
		// (set) Token: 0x06015173 RID: 86387 RVA: 0x0030ECC6 File Offset: 0x0030CEC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x06015174 RID: 86388 RVA: 0x0030ECCF File Offset: 0x0030CECF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RiskHarvestStarRewardRequest);
		}

		// Token: 0x06015175 RID: 86389 RVA: 0x0030ECDD File Offset: 0x0030CEDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RiskHarvestStarRewardRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Index == other.Index && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015176 RID: 86390 RVA: 0x0030ED1C File Offset: 0x0030CF1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015177 RID: 86391 RVA: 0x0030ED74 File Offset: 0x0030CF74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015178 RID: 86392 RVA: 0x0030ED81 File Offset: 0x0030CF81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015179 RID: 86393 RVA: 0x0030ED8C File Offset: 0x0030CF8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Index != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Index);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601517A RID: 86394 RVA: 0x0030EDE8 File Offset: 0x0030CFE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601517B RID: 86395 RVA: 0x0030EE40 File Offset: 0x0030D040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RiskHarvestStarRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601517C RID: 86396 RVA: 0x0030EE90 File Offset: 0x0030D090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601517D RID: 86397 RVA: 0x0030EE9C File Offset: 0x0030D09C
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
				if (num != 40U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Id = input.ReadInt32();
					}
				}
				else
				{
					this.Index = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007EF2 RID: 32498
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007EF3 RID: 32499
		public const int IdFieldNumber = 15;

		// Token: 0x04007EF4 RID: 32500
		private int id_;

		// Token: 0x04007EF5 RID: 32501
		public const int IndexFieldNumber = 5;

		// Token: 0x04007EF6 RID: 32502
		private int index_;
	}
}
