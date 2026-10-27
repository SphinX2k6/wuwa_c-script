using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009C3 RID: 2499
	public sealed class MatchThreeActivityInfo : IMessage<MatchThreeActivityInfo>, IMessage, IEquatable<MatchThreeActivityInfo>, IDeepCloneable<MatchThreeActivityInfo>, IBufferMessage
	{
		// Token: 0x0600DB45 RID: 56133 RVA: 0x00203431 File Offset: 0x00201631
		[NullableContext(1)]
		public static MatchThreeActivityInfo Create()
		{
			return new MatchThreeActivityInfo();
		}

		// Token: 0x17002C71 RID: 11377
		// (get) Token: 0x0600DB46 RID: 56134 RVA: 0x00203438 File Offset: 0x00201638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C72 RID: 11378
		// (get) Token: 0x0600DB47 RID: 56135 RVA: 0x0020343B File Offset: 0x0020163B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchThreeActivityInfo.Descriptor;
			}
		}

		// Token: 0x0600DB48 RID: 56136 RVA: 0x00203442 File Offset: 0x00201642
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchThreeActivityInfo()
		{
		}

		// Token: 0x0600DB49 RID: 56137 RVA: 0x00203455 File Offset: 0x00201655
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchThreeActivityInfo(MatchThreeActivityInfo other) : this()
		{
			this.matchThreeLevelInfos_ = other.matchThreeLevelInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DB4A RID: 56138 RVA: 0x0020347F File Offset: 0x0020167F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchThreeActivityInfo Clone()
		{
			return new MatchThreeActivityInfo(this);
		}

		// Token: 0x17002C73 RID: 11379
		// (get) Token: 0x0600DB4B RID: 56139 RVA: 0x00203487 File Offset: 0x00201687
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MatchThreeLevelInfo> MatchThreeLevelInfos
		{
			get
			{
				return this.matchThreeLevelInfos_;
			}
		}

		// Token: 0x0600DB4C RID: 56140 RVA: 0x0020348F File Offset: 0x0020168F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchThreeActivityInfo);
		}

		// Token: 0x0600DB4D RID: 56141 RVA: 0x0020349D File Offset: 0x0020169D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchThreeActivityInfo other)
		{
			return other != null && (other == this || (this.matchThreeLevelInfos_.Equals(other.matchThreeLevelInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DB4E RID: 56142 RVA: 0x002034D0 File Offset: 0x002016D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.matchThreeLevelInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DB4F RID: 56143 RVA: 0x00203504 File Offset: 0x00201704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DB50 RID: 56144 RVA: 0x00203511 File Offset: 0x00201711
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DB51 RID: 56145 RVA: 0x0020351A File Offset: 0x0020171A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.matchThreeLevelInfos_.WriteTo(ref output, MatchThreeActivityInfo._repeated_matchThreeLevelInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DB52 RID: 56146 RVA: 0x00203544 File Offset: 0x00201744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.matchThreeLevelInfos_.CalculateSize(MatchThreeActivityInfo._repeated_matchThreeLevelInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DB53 RID: 56147 RVA: 0x0020357D File Offset: 0x0020177D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MatchThreeActivityInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.matchThreeLevelInfos_.Add(other.matchThreeLevelInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DB54 RID: 56148 RVA: 0x002035AB File Offset: 0x002017AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DB55 RID: 56149 RVA: 0x002035B4 File Offset: 0x002017B4
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
					this.matchThreeLevelInfos_.AddEntriesFrom(ref input, MatchThreeActivityInfo._repeated_matchThreeLevelInfos_codec);
				}
			}
		}

		// Token: 0x04005B04 RID: 23300
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B05 RID: 23301
		public const int MatchThreeLevelInfosFieldNumber = 1;

		// Token: 0x04005B06 RID: 23302
		private static readonly FieldCodec<MatchThreeLevelInfo> _repeated_matchThreeLevelInfos_codec = FieldCodec.ForMessage<MatchThreeLevelInfo>(10U, MatchThreeLevelInfo.Parser);

		// Token: 0x04005B07 RID: 23303
		private readonly RepeatedField<MatchThreeLevelInfo> matchThreeLevelInfos_ = new RepeatedField<MatchThreeLevelInfo>();
	}
}
