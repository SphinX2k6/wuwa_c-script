using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009B3 RID: 2483
	[NetMessage(EMessageId.MatchThreeEndRequest)]
	public sealed class MatchThreeEndRequest : IMessage<MatchThreeEndRequest>, IMessage, IEquatable<MatchThreeEndRequest>, IDeepCloneable<MatchThreeEndRequest>, IBufferMessage
	{
		// Token: 0x0600DA3D RID: 55869 RVA: 0x0020141D File Offset: 0x001FF61D
		[NullableContext(1)]
		public static MatchThreeEndRequest Create()
		{
			return new MatchThreeEndRequest();
		}

		// Token: 0x17002C36 RID: 11318
		// (get) Token: 0x0600DA3E RID: 55870 RVA: 0x00201424 File Offset: 0x001FF624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C37 RID: 11319
		// (get) Token: 0x0600DA3F RID: 55871 RVA: 0x00201427 File Offset: 0x001FF627
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchThreeEndRequest.Descriptor;
			}
		}

		// Token: 0x0600DA40 RID: 55872 RVA: 0x0020142E File Offset: 0x001FF62E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchThreeEndRequest()
		{
		}

		// Token: 0x0600DA41 RID: 55873 RVA: 0x0020144C File Offset: 0x001FF64C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchThreeEndRequest(MatchThreeEndRequest other) : this()
		{
			this.levelId_ = other.levelId_;
			this.traceId_ = other.traceId_;
			this.results_ = other.results_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DA42 RID: 55874 RVA: 0x00201499 File Offset: 0x001FF699
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchThreeEndRequest Clone()
		{
			return new MatchThreeEndRequest(this);
		}

		// Token: 0x17002C38 RID: 11320
		// (get) Token: 0x0600DA43 RID: 55875 RVA: 0x002014A1 File Offset: 0x001FF6A1
		// (set) Token: 0x0600DA44 RID: 55876 RVA: 0x002014A9 File Offset: 0x001FF6A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelId
		{
			get
			{
				return this.levelId_;
			}
			set
			{
				this.levelId_ = value;
			}
		}

		// Token: 0x17002C39 RID: 11321
		// (get) Token: 0x0600DA45 RID: 55877 RVA: 0x002014B2 File Offset: 0x001FF6B2
		// (set) Token: 0x0600DA46 RID: 55878 RVA: 0x002014BA File Offset: 0x001FF6BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string TraceId
		{
			get
			{
				return this.traceId_;
			}
			set
			{
				this.traceId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002C3A RID: 11322
		// (get) Token: 0x0600DA47 RID: 55879 RVA: 0x002014CD File Offset: 0x001FF6CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> Results
		{
			get
			{
				return this.results_;
			}
		}

		// Token: 0x0600DA48 RID: 55880 RVA: 0x002014D5 File Offset: 0x001FF6D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchThreeEndRequest);
		}

		// Token: 0x0600DA49 RID: 55881 RVA: 0x002014E4 File Offset: 0x001FF6E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchThreeEndRequest other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && !(this.TraceId != other.TraceId) && this.Results.Equals(other.Results) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DA4A RID: 55882 RVA: 0x00201548 File Offset: 0x001FF748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelId != 0)
			{
				num ^= this.LevelId.GetHashCode();
			}
			if (this.TraceId.Length != 0)
			{
				num ^= this.TraceId.GetHashCode();
			}
			num ^= this.Results.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DA4B RID: 55883 RVA: 0x002015B0 File Offset: 0x001FF7B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DA4C RID: 55884 RVA: 0x002015BD File Offset: 0x001FF7BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DA4D RID: 55885 RVA: 0x002015C8 File Offset: 0x001FF7C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LevelId);
			}
			this.results_.WriteTo(ref output, MatchThreeEndRequest._map_results_codec);
			if (this.TraceId.Length != 0)
			{
				output.WriteRawTag(82);
				output.WriteString(this.TraceId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DA4E RID: 55886 RVA: 0x00201638 File Offset: 0x001FF838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelId);
			}
			if (this.TraceId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.TraceId);
			}
			num += this.results_.CalculateSize(MatchThreeEndRequest._map_results_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DA4F RID: 55887 RVA: 0x002016A8 File Offset: 0x001FF8A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MatchThreeEndRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelId != 0)
			{
				this.LevelId = other.LevelId;
			}
			if (other.TraceId.Length != 0)
			{
				this.TraceId = other.TraceId;
			}
			this.results_.MergeFrom(other.results_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DA50 RID: 55888 RVA: 0x0020170E File Offset: 0x001FF90E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DA51 RID: 55889 RVA: 0x00201718 File Offset: 0x001FF918
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
					if (num != 66U)
					{
						if (num != 82U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.TraceId = input.ReadString();
						}
					}
					else
					{
						this.results_.AddEntriesFrom(ref input, MatchThreeEndRequest._map_results_codec);
					}
				}
				else
				{
					this.LevelId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005B11 RID: 23313
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B12 RID: 23314
		public const int LevelIdFieldNumber = 1;

		// Token: 0x04005B13 RID: 23315
		private int levelId_;

		// Token: 0x04005B14 RID: 23316
		public const int TraceIdFieldNumber = 10;

		// Token: 0x04005B15 RID: 23317
		private string traceId_ = "";

		// Token: 0x04005B16 RID: 23318
		public const int ResultsFieldNumber = 8;

		// Token: 0x04005B17 RID: 23319
		private static readonly MapField<int, int>.Codec _map_results_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 66U);

		// Token: 0x04005B18 RID: 23320
		private readonly MapField<int, int> results_ = new MapField<int, int>();
	}
}
