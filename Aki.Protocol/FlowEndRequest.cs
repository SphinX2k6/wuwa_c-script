using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005E3 RID: 1507
	[NetMessage(EMessageId.FlowEndRequest)]
	public sealed class FlowEndRequest : IMessage<FlowEndRequest>, IMessage, IEquatable<FlowEndRequest>, IDeepCloneable<FlowEndRequest>, IBufferMessage
	{
		// Token: 0x06008C08 RID: 35848 RVA: 0x00154467 File Offset: 0x00152667
		[NullableContext(1)]
		public static FlowEndRequest Create()
		{
			return new FlowEndRequest();
		}

		// Token: 0x17001BBE RID: 7102
		// (get) Token: 0x06008C09 RID: 35849 RVA: 0x0015446E File Offset: 0x0015266E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001BBF RID: 7103
		// (get) Token: 0x06008C0A RID: 35850 RVA: 0x00154471 File Offset: 0x00152671
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlowEndRequest.Descriptor;
			}
		}

		// Token: 0x06008C0B RID: 35851 RVA: 0x00154478 File Offset: 0x00152678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowEndRequest()
		{
		}

		// Token: 0x06008C0C RID: 35852 RVA: 0x0015448C File Offset: 0x0015268C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowEndRequest(FlowEndRequest other) : this()
		{
			this.flowIncId_ = other.flowIncId_;
			this.isSkip_ = other.isSkip_;
			this.optionInfos_ = other.optionInfos_.Clone();
			this.clientError_ = other.clientError_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008C0D RID: 35853 RVA: 0x001544E5 File Offset: 0x001526E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowEndRequest Clone()
		{
			return new FlowEndRequest(this);
		}

		// Token: 0x17001BC0 RID: 7104
		// (get) Token: 0x06008C0E RID: 35854 RVA: 0x001544ED File Offset: 0x001526ED
		// (set) Token: 0x06008C0F RID: 35855 RVA: 0x001544F5 File Offset: 0x001526F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long FlowIncId
		{
			get
			{
				return this.flowIncId_;
			}
			set
			{
				this.flowIncId_ = value;
			}
		}

		// Token: 0x17001BC1 RID: 7105
		// (get) Token: 0x06008C10 RID: 35856 RVA: 0x001544FE File Offset: 0x001526FE
		// (set) Token: 0x06008C11 RID: 35857 RVA: 0x00154506 File Offset: 0x00152706
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSkip
		{
			get
			{
				return this.isSkip_;
			}
			set
			{
				this.isSkip_ = value;
			}
		}

		// Token: 0x17001BC2 RID: 7106
		// (get) Token: 0x06008C12 RID: 35858 RVA: 0x0015450F File Offset: 0x0015270F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, FlowOptionInfoList> OptionInfos
		{
			get
			{
				return this.optionInfos_;
			}
		}

		// Token: 0x17001BC3 RID: 7107
		// (get) Token: 0x06008C13 RID: 35859 RVA: 0x00154517 File Offset: 0x00152717
		// (set) Token: 0x06008C14 RID: 35860 RVA: 0x0015451F File Offset: 0x0015271F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ClientError
		{
			get
			{
				return this.clientError_;
			}
			set
			{
				this.clientError_ = value;
			}
		}

		// Token: 0x06008C15 RID: 35861 RVA: 0x00154528 File Offset: 0x00152728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlowEndRequest);
		}

		// Token: 0x06008C16 RID: 35862 RVA: 0x00154538 File Offset: 0x00152738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlowEndRequest other)
		{
			return other != null && (other == this || (this.FlowIncId == other.FlowIncId && this.IsSkip == other.IsSkip && this.OptionInfos.Equals(other.OptionInfos) && this.ClientError == other.ClientError && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008C17 RID: 35863 RVA: 0x001545A8 File Offset: 0x001527A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FlowIncId != 0L)
			{
				num ^= this.FlowIncId.GetHashCode();
			}
			if (this.IsSkip)
			{
				num ^= this.IsSkip.GetHashCode();
			}
			num ^= this.OptionInfos.GetHashCode();
			if (this.ClientError)
			{
				num ^= this.ClientError.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008C18 RID: 35864 RVA: 0x00154627 File Offset: 0x00152827
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008C19 RID: 35865 RVA: 0x00154634 File Offset: 0x00152834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008C1A RID: 35866 RVA: 0x00154640 File Offset: 0x00152840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.optionInfos_.WriteTo(ref output, FlowEndRequest._map_optionInfos_codec);
			if (this.FlowIncId != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.FlowIncId);
			}
			if (this.IsSkip)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.IsSkip);
			}
			if (this.ClientError)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.ClientError);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008C1B RID: 35867 RVA: 0x001546C8 File Offset: 0x001528C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FlowIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.FlowIncId);
			}
			if (this.IsSkip)
			{
				num += 2;
			}
			num += this.optionInfos_.CalculateSize(FlowEndRequest._map_optionInfos_codec);
			if (this.ClientError)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008C1C RID: 35868 RVA: 0x00154734 File Offset: 0x00152934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlowEndRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FlowIncId != 0L)
			{
				this.FlowIncId = other.FlowIncId;
			}
			if (other.IsSkip)
			{
				this.IsSkip = other.IsSkip;
			}
			this.optionInfos_.MergeFrom(other.optionInfos_);
			if (other.ClientError)
			{
				this.ClientError = other.ClientError;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008C1D RID: 35869 RVA: 0x001547A9 File Offset: 0x001529A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008C1E RID: 35870 RVA: 0x001547B4 File Offset: 0x001529B4
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
				if (num <= 72U)
				{
					if (num == 26U)
					{
						this.optionInfos_.AddEntriesFrom(ref input, FlowEndRequest._map_optionInfos_codec);
						continue;
					}
					if (num == 72U)
					{
						this.FlowIncId = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.IsSkip = input.ReadBool();
						continue;
					}
					if (num == 112U)
					{
						this.ClientError = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004503 RID: 17667
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004504 RID: 17668
		public const int FlowIncIdFieldNumber = 9;

		// Token: 0x04004505 RID: 17669
		private long flowIncId_;

		// Token: 0x04004506 RID: 17670
		public const int IsSkipFieldNumber = 12;

		// Token: 0x04004507 RID: 17671
		private bool isSkip_;

		// Token: 0x04004508 RID: 17672
		public const int OptionInfosFieldNumber = 3;

		// Token: 0x04004509 RID: 17673
		private static readonly MapField<int, FlowOptionInfoList>.Codec _map_optionInfos_codec = new MapField<int, FlowOptionInfoList>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<FlowOptionInfoList>(18U, FlowOptionInfoList.Parser), 26U);

		// Token: 0x0400450A RID: 17674
		private readonly MapField<int, FlowOptionInfoList> optionInfos_ = new MapField<int, FlowOptionInfoList>();

		// Token: 0x0400450B RID: 17675
		public const int ClientErrorFieldNumber = 14;

		// Token: 0x0400450C RID: 17676
		private bool clientError_;
	}
}
