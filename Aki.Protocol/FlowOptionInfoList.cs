using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005EA RID: 1514
	public sealed class FlowOptionInfoList : IMessage<FlowOptionInfoList>, IMessage, IEquatable<FlowOptionInfoList>, IDeepCloneable<FlowOptionInfoList>, IBufferMessage
	{
		// Token: 0x06008C9A RID: 35994 RVA: 0x00155813 File Offset: 0x00153A13
		[NullableContext(1)]
		public static FlowOptionInfoList Create()
		{
			return new FlowOptionInfoList();
		}

		// Token: 0x17001BDD RID: 7133
		// (get) Token: 0x06008C9B RID: 35995 RVA: 0x0015581A File Offset: 0x00153A1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FlowOptionInfoList> Parser
		{
			get
			{
				return FlowOptionInfoList._parser;
			}
		}

		// Token: 0x17001BDE RID: 7134
		// (get) Token: 0x06008C9C RID: 35996 RVA: 0x00155821 File Offset: 0x00153A21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001BDF RID: 7135
		// (get) Token: 0x06008C9D RID: 35997 RVA: 0x00155824 File Offset: 0x00153A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlowOptionInfoList.Descriptor;
			}
		}

		// Token: 0x06008C9E RID: 35998 RVA: 0x0015582B File Offset: 0x00153A2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowOptionInfoList()
		{
		}

		// Token: 0x06008C9F RID: 35999 RVA: 0x0015583E File Offset: 0x00153A3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowOptionInfoList(FlowOptionInfoList other) : this()
		{
			this.optionIndexList_ = other.optionIndexList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008CA0 RID: 36000 RVA: 0x00155868 File Offset: 0x00153A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowOptionInfoList Clone()
		{
			return new FlowOptionInfoList(this);
		}

		// Token: 0x17001BE0 RID: 7136
		// (get) Token: 0x06008CA1 RID: 36001 RVA: 0x00155870 File Offset: 0x00153A70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FlowOptionInfo> OptionIndexList
		{
			get
			{
				return this.optionIndexList_;
			}
		}

		// Token: 0x06008CA2 RID: 36002 RVA: 0x00155878 File Offset: 0x00153A78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlowOptionInfoList);
		}

		// Token: 0x06008CA3 RID: 36003 RVA: 0x00155886 File Offset: 0x00153A86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlowOptionInfoList other)
		{
			return other != null && (other == this || (this.optionIndexList_.Equals(other.optionIndexList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008CA4 RID: 36004 RVA: 0x001558BC File Offset: 0x00153ABC
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

		// Token: 0x06008CA5 RID: 36005 RVA: 0x001558F0 File Offset: 0x00153AF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008CA6 RID: 36006 RVA: 0x001558FD File Offset: 0x00153AFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008CA7 RID: 36007 RVA: 0x00155906 File Offset: 0x00153B06
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

		// Token: 0x06008CA8 RID: 36008 RVA: 0x00155930 File Offset: 0x00153B30
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

		// Token: 0x06008CA9 RID: 36009 RVA: 0x00155969 File Offset: 0x00153B69
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

		// Token: 0x06008CAA RID: 36010 RVA: 0x00155997 File Offset: 0x00153B97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008CAB RID: 36011 RVA: 0x001559A0 File Offset: 0x00153BA0
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

		// Token: 0x0400452D RID: 17709
		private static readonly MessageParser<FlowOptionInfoList> _parser = new MessageParser<FlowOptionInfoList>(() => new FlowOptionInfoList());

		// Token: 0x0400452E RID: 17710
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400452F RID: 17711
		public const int OptionIndexListFieldNumber = 1;

		// Token: 0x04004530 RID: 17712
		private static readonly FieldCodec<FlowOptionInfo> _repeated_optionIndexList_codec = FieldCodec.ForMessage<FlowOptionInfo>(10U, FlowOptionInfo.Parser);

		// Token: 0x04004531 RID: 17713
		private readonly RepeatedField<FlowOptionInfo> optionIndexList_ = new RepeatedField<FlowOptionInfo>();
	}
}
