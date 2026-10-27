using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002B5 RID: 693
	public sealed class CombineEntityInfoPb : IMessage<CombineEntityInfoPb>, IMessage, IEquatable<CombineEntityInfoPb>, IDeepCloneable<CombineEntityInfoPb>, IBufferMessage
	{
		// Token: 0x060047A2 RID: 18338 RVA: 0x000AFE61 File Offset: 0x000AE061
		[NullableContext(1)]
		public static CombineEntityInfoPb Create()
		{
			return new CombineEntityInfoPb();
		}

		// Token: 0x17000C7A RID: 3194
		// (get) Token: 0x060047A3 RID: 18339 RVA: 0x000AFE68 File Offset: 0x000AE068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C7B RID: 3195
		// (get) Token: 0x060047A4 RID: 18340 RVA: 0x000AFE6B File Offset: 0x000AE06B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CombineEntityInfoPb.Descriptor;
			}
		}

		// Token: 0x060047A5 RID: 18341 RVA: 0x000AFE72 File Offset: 0x000AE072
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombineEntityInfoPb()
		{
		}

		// Token: 0x060047A6 RID: 18342 RVA: 0x000AFE85 File Offset: 0x000AE085
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombineEntityInfoPb(CombineEntityInfoPb other) : this()
		{
			this.combinePartInfoList_ = other.combinePartInfoList_.Clone();
			this.targetEntityId_ = other.targetEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060047A7 RID: 18343 RVA: 0x000AFEBB File Offset: 0x000AE0BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombineEntityInfoPb Clone()
		{
			return new CombineEntityInfoPb(this);
		}

		// Token: 0x17000C7C RID: 3196
		// (get) Token: 0x060047A8 RID: 18344 RVA: 0x000AFEC3 File Offset: 0x000AE0C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CombinePartInfo> CombinePartInfoList
		{
			get
			{
				return this.combinePartInfoList_;
			}
		}

		// Token: 0x17000C7D RID: 3197
		// (get) Token: 0x060047A9 RID: 18345 RVA: 0x000AFECB File Offset: 0x000AE0CB
		// (set) Token: 0x060047AA RID: 18346 RVA: 0x000AFED3 File Offset: 0x000AE0D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TargetEntityId
		{
			get
			{
				return this.targetEntityId_;
			}
			set
			{
				this.targetEntityId_ = value;
			}
		}

		// Token: 0x060047AB RID: 18347 RVA: 0x000AFEDC File Offset: 0x000AE0DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CombineEntityInfoPb);
		}

		// Token: 0x060047AC RID: 18348 RVA: 0x000AFEEC File Offset: 0x000AE0EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CombineEntityInfoPb other)
		{
			return other != null && (other == this || (this.combinePartInfoList_.Equals(other.combinePartInfoList_) && this.TargetEntityId == other.TargetEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060047AD RID: 18349 RVA: 0x000AFF3C File Offset: 0x000AE13C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.combinePartInfoList_.GetHashCode();
			if (this.TargetEntityId != 0L)
			{
				num ^= this.TargetEntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060047AE RID: 18350 RVA: 0x000AFF89 File Offset: 0x000AE189
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060047AF RID: 18351 RVA: 0x000AFF96 File Offset: 0x000AE196
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060047B0 RID: 18352 RVA: 0x000AFFA0 File Offset: 0x000AE1A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.combinePartInfoList_.WriteTo(ref output, CombineEntityInfoPb._repeated_combinePartInfoList_codec);
			if (this.TargetEntityId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.TargetEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060047B1 RID: 18353 RVA: 0x000AFFF0 File Offset: 0x000AE1F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.combinePartInfoList_.CalculateSize(CombineEntityInfoPb._repeated_combinePartInfoList_codec);
			if (this.TargetEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TargetEntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060047B2 RID: 18354 RVA: 0x000B0044 File Offset: 0x000AE244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CombineEntityInfoPb other)
		{
			if (other == null)
			{
				return;
			}
			this.combinePartInfoList_.Add(other.combinePartInfoList_);
			if (other.TargetEntityId != 0L)
			{
				this.TargetEntityId = other.TargetEntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060047B3 RID: 18355 RVA: 0x000B0091 File Offset: 0x000AE291
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060047B4 RID: 18356 RVA: 0x000B009C File Offset: 0x000AE29C
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.TargetEntityId = input.ReadInt64();
					}
				}
				else
				{
					this.combinePartInfoList_.AddEntriesFrom(ref input, CombineEntityInfoPb._repeated_combinePartInfoList_codec);
				}
			}
		}

		// Token: 0x04002FAE RID: 12206
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FAF RID: 12207
		public const int CombinePartInfoListFieldNumber = 1;

		// Token: 0x04002FB0 RID: 12208
		private static readonly FieldCodec<CombinePartInfo> _repeated_combinePartInfoList_codec = FieldCodec.ForMessage<CombinePartInfo>(10U, CombinePartInfo.Parser);

		// Token: 0x04002FB1 RID: 12209
		private readonly RepeatedField<CombinePartInfo> combinePartInfoList_ = new RepeatedField<CombinePartInfo>();

		// Token: 0x04002FB2 RID: 12210
		public const int TargetEntityIdFieldNumber = 2;

		// Token: 0x04002FB3 RID: 12211
		private long targetEntityId_;
	}
}
