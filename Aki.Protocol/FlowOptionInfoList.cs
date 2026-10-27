using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005FF RID: 1535
	public sealed class FlowOptionInfoList : IMessage<FlowOptionInfoList>, IMessage, IEquatable<FlowOptionInfoList>, IDeepCloneable<FlowOptionInfoList>, IBufferMessage
	{
		// Token: 0x06008E02 RID: 36354 RVA: 0x00158413 File Offset: 0x00156613
		[NullableContext(1)]
		public static FlowOptionInfoList Create()
		{
			return new FlowOptionInfoList();
		}

		// Token: 0x17001C2A RID: 7210
		// (get) Token: 0x06008E03 RID: 36355 RVA: 0x0015841A File Offset: 0x0015661A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FlowOptionInfoList> Parser
		{
			get
			{
				return FlowOptionInfoList._parser;
			}
		}

		// Token: 0x17001C2B RID: 7211
		// (get) Token: 0x06008E04 RID: 36356 RVA: 0x00158421 File Offset: 0x00156621
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C2C RID: 7212
		// (get) Token: 0x06008E05 RID: 36357 RVA: 0x00158424 File Offset: 0x00156624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlowOptionInfoList.Descriptor;
			}
		}

		// Token: 0x06008E06 RID: 36358 RVA: 0x0015842B File Offset: 0x0015662B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowOptionInfoList()
		{
		}

		// Token: 0x06008E07 RID: 36359 RVA: 0x0015843E File Offset: 0x0015663E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowOptionInfoList(FlowOptionInfoList other) : this()
		{
			this.optionIndexList_ = other.optionIndexList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008E08 RID: 36360 RVA: 0x00158468 File Offset: 0x00156668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowOptionInfoList Clone()
		{
			return new FlowOptionInfoList(this);
		}

		// Token: 0x17001C2D RID: 7213
		// (get) Token: 0x06008E09 RID: 36361 RVA: 0x00158470 File Offset: 0x00156670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FlowOptionInfo> OptionIndexList
		{
			get
			{
				return this.optionIndexList_;
			}
		}

		// Token: 0x06008E0A RID: 36362 RVA: 0x00158478 File Offset: 0x00156678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlowOptionInfoList);
		}

		// Token: 0x06008E0B RID: 36363 RVA: 0x00158486 File Offset: 0x00156686
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlowOptionInfoList other)
		{
			return other != null && (other == this || (this.optionIndexList_.Equals(other.optionIndexList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008E0C RID: 36364 RVA: 0x001584BC File Offset: 0x001566BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.optionIndexList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008E0D RID: 36365 RVA: 0x001584F0 File Offset: 0x001566F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008E0E RID: 36366 RVA: 0x001584FD File Offset: 0x001566FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008E0F RID: 36367 RVA: 0x00158506 File Offset: 0x00156706
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.optionIndexList_.WriteTo(ref output, FlowOptionInfoList._repeated_optionIndexList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008E10 RID: 36368 RVA: 0x00158530 File Offset: 0x00156730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.optionIndexList_.CalculateSize(FlowOptionInfoList._repeated_optionIndexList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008E11 RID: 36369 RVA: 0x00158569 File Offset: 0x00156769
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlowOptionInfoList other)
		{
			if (other == null)
			{
				return;
			}
			this.optionIndexList_.Add(other.optionIndexList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008E12 RID: 36370 RVA: 0x00158597 File Offset: 0x00156797
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008E13 RID: 36371 RVA: 0x001585A0 File Offset: 0x001567A0
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.optionIndexList_.AddEntriesFrom(ref input, FlowOptionInfoList._repeated_optionIndexList_codec);
				}
			}
		}

		// Token: 0x04004537 RID: 17719
		private static readonly MessageParser<FlowOptionInfoList> _parser = new MessageParser<FlowOptionInfoList>(() => new FlowOptionInfoList());

		// Token: 0x04004538 RID: 17720
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004539 RID: 17721
		public const int OptionIndexListFieldNumber = 1;

		// Token: 0x0400453A RID: 17722
		private static readonly FieldCodec<FlowOptionInfo> _repeated_optionIndexList_codec = FieldCodec.ForMessage<FlowOptionInfo>(10U, FlowOptionInfo.Parser);

		// Token: 0x0400453B RID: 17723
		private readonly RepeatedField<FlowOptionInfo> optionIndexList_ = new RepeatedField<FlowOptionInfo>();
	}
}
