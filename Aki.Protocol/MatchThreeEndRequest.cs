using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009C4 RID: 2500
	[NetMessage(EMessageId.MatchThreeEndRequest)]
	public sealed class MatchThreeEndRequest : IMessage<MatchThreeEndRequest>, IMessage, IEquatable<MatchThreeEndRequest>, IDeepCloneable<MatchThreeEndRequest>, IBufferMessage
	{
		// Token: 0x0600DB57 RID: 56151 RVA: 0x00203611 File Offset: 0x00201811
		[NullableContext(1)]
		public static MatchThreeEndRequest Create()
		{
			return new MatchThreeEndRequest();
		}

		// Token: 0x17002C74 RID: 11380
		// (get) Token: 0x0600DB58 RID: 56152 RVA: 0x00203618 File Offset: 0x00201818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C75 RID: 11381
		// (get) Token: 0x0600DB59 RID: 56153 RVA: 0x0020361B File Offset: 0x0020181B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchThreeEndRequest.Descriptor;
			}
		}

		// Token: 0x0600DB5A RID: 56154 RVA: 0x00203622 File Offset: 0x00201822
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchThreeEndRequest()
		{
		}

		// Token: 0x0600DB5B RID: 56155 RVA: 0x00203640 File Offset: 0x00201840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchThreeEndRequest(MatchThreeEndRequest other) : this()
		{
			this.levelId_ = other.levelId_;
			this.traceId_ = other.traceId_;
			this.results_ = other.results_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DB5C RID: 56156 RVA: 0x0020368D File Offset: 0x0020188D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchThreeEndRequest Clone()
		{
			return new MatchThreeEndRequest(this);
		}

		// Token: 0x17002C76 RID: 11382
		// (get) Token: 0x0600DB5D RID: 56157 RVA: 0x00203695 File Offset: 0x00201895
		// (set) Token: 0x0600DB5E RID: 56158 RVA: 0x0020369D File Offset: 0x0020189D
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

		// Token: 0x17002C77 RID: 11383
		// (get) Token: 0x0600DB5F RID: 56159 RVA: 0x002036A6 File Offset: 0x002018A6
		// (set) Token: 0x0600DB60 RID: 56160 RVA: 0x002036AE File Offset: 0x002018AE
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

		// Token: 0x17002C78 RID: 11384
		// (get) Token: 0x0600DB61 RID: 56161 RVA: 0x002036C1 File Offset: 0x002018C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> Results
		{
			get
			{
				return this.results_;
			}
		}

		// Token: 0x0600DB62 RID: 56162 RVA: 0x002036C9 File Offset: 0x002018C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchThreeEndRequest);
		}

		// Token: 0x0600DB63 RID: 56163 RVA: 0x002036D8 File Offset: 0x002018D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchThreeEndRequest other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && !(this.TraceId != other.TraceId) && this.Results.Equals(other.Results) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DB64 RID: 56164 RVA: 0x0020373C File Offset: 0x0020193C
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

		// Token: 0x0600DB65 RID: 56165 RVA: 0x002037A4 File Offset: 0x002019A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DB66 RID: 56166 RVA: 0x002037B1 File Offset: 0x002019B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DB67 RID: 56167 RVA: 0x002037BC File Offset: 0x002019BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.results_.WriteTo(ref output, MatchThreeEndRequest._map_results_codec);
			if (this.LevelId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.LevelId);
			}
			if (this.TraceId.Length != 0)
			{
				output.WriteRawTag(98);
				output.WriteString(this.TraceId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DB68 RID: 56168 RVA: 0x0020382C File Offset: 0x00201A2C
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

		// Token: 0x0600DB69 RID: 56169 RVA: 0x0020389C File Offset: 0x00201A9C
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

		// Token: 0x0600DB6A RID: 56170 RVA: 0x00203902 File Offset: 0x00201B02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DB6B RID: 56171 RVA: 0x0020390C File Offset: 0x00201B0C
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
				if (num != 74U)
				{
					if (num != 80U)
					{
						if (num != 98U)
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
						this.LevelId = input.ReadInt32();
					}
				}
				else
				{
					this.results_.AddEntriesFrom(ref input, MatchThreeEndRequest._map_results_codec);
				}
			}
		}

		// Token: 0x04005B08 RID: 23304
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B09 RID: 23305
		public const int LevelIdFieldNumber = 10;

		// Token: 0x04005B0A RID: 23306
		private int levelId_;

		// Token: 0x04005B0B RID: 23307
		public const int TraceIdFieldNumber = 12;

		// Token: 0x04005B0C RID: 23308
		private string traceId_ = "";

		// Token: 0x04005B0D RID: 23309
		public const int ResultsFieldNumber = 9;

		// Token: 0x04005B0E RID: 23310
		private static readonly MapField<int, int>.Codec _map_results_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 74U);

		// Token: 0x04005B0F RID: 23311
		private readonly MapField<int, int> results_ = new MapField<int, int>();
	}
}
