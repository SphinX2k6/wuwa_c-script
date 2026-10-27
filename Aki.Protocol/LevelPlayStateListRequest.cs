using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000909 RID: 2313
	[NetMessage(EMessageId.LevelPlayStateListRequest)]
	public sealed class LevelPlayStateListRequest : IMessage<LevelPlayStateListRequest>, IMessage, IEquatable<LevelPlayStateListRequest>, IDeepCloneable<LevelPlayStateListRequest>, IBufferMessage
	{
		// Token: 0x0600CC36 RID: 52278 RVA: 0x001E19C5 File Offset: 0x001DFBC5
		[NullableContext(1)]
		public static LevelPlayStateListRequest Create()
		{
			return new LevelPlayStateListRequest();
		}

		// Token: 0x1700293A RID: 10554
		// (get) Token: 0x0600CC37 RID: 52279 RVA: 0x001E19CC File Offset: 0x001DFBCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700293B RID: 10555
		// (get) Token: 0x0600CC38 RID: 52280 RVA: 0x001E19CF File Offset: 0x001DFBCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelPlayStateListRequest.Descriptor;
			}
		}

		// Token: 0x0600CC39 RID: 52281 RVA: 0x001E19D6 File Offset: 0x001DFBD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayStateListRequest()
		{
		}

		// Token: 0x0600CC3A RID: 52282 RVA: 0x001E19E9 File Offset: 0x001DFBE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayStateListRequest(LevelPlayStateListRequest other) : this()
		{
			this.instLevelPlayStateReqs_ = other.instLevelPlayStateReqs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CC3B RID: 52283 RVA: 0x001E1A13 File Offset: 0x001DFC13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayStateListRequest Clone()
		{
			return new LevelPlayStateListRequest(this);
		}

		// Token: 0x1700293C RID: 10556
		// (get) Token: 0x0600CC3C RID: 52284 RVA: 0x001E1A1B File Offset: 0x001DFC1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<InstLevelPlayStateReq> InstLevelPlayStateReqs
		{
			get
			{
				return this.instLevelPlayStateReqs_;
			}
		}

		// Token: 0x0600CC3D RID: 52285 RVA: 0x001E1A23 File Offset: 0x001DFC23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelPlayStateListRequest);
		}

		// Token: 0x0600CC3E RID: 52286 RVA: 0x001E1A31 File Offset: 0x001DFC31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelPlayStateListRequest other)
		{
			return other != null && (other == this || (this.instLevelPlayStateReqs_.Equals(other.instLevelPlayStateReqs_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CC3F RID: 52287 RVA: 0x001E1A64 File Offset: 0x001DFC64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.instLevelPlayStateReqs_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CC40 RID: 52288 RVA: 0x001E1A98 File Offset: 0x001DFC98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CC41 RID: 52289 RVA: 0x001E1AA5 File Offset: 0x001DFCA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CC42 RID: 52290 RVA: 0x001E1AAE File Offset: 0x001DFCAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.instLevelPlayStateReqs_.WriteTo(ref output, LevelPlayStateListRequest._repeated_instLevelPlayStateReqs_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CC43 RID: 52291 RVA: 0x001E1AD8 File Offset: 0x001DFCD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.instLevelPlayStateReqs_.CalculateSize(LevelPlayStateListRequest._repeated_instLevelPlayStateReqs_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CC44 RID: 52292 RVA: 0x001E1B11 File Offset: 0x001DFD11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LevelPlayStateListRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.instLevelPlayStateReqs_.Add(other.instLevelPlayStateReqs_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CC45 RID: 52293 RVA: 0x001E1B3F File Offset: 0x001DFD3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CC46 RID: 52294 RVA: 0x001E1B48 File Offset: 0x001DFD48
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
				if (num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.instLevelPlayStateReqs_.AddEntriesFrom(ref input, LevelPlayStateListRequest._repeated_instLevelPlayStateReqs_codec);
				}
			}
		}

		// Token: 0x04005698 RID: 22168
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005699 RID: 22169
		public const int InstLevelPlayStateReqsFieldNumber = 7;

		// Token: 0x0400569A RID: 22170
		private static readonly FieldCodec<InstLevelPlayStateReq> _repeated_instLevelPlayStateReqs_codec = FieldCodec.ForMessage<InstLevelPlayStateReq>(58U, InstLevelPlayStateReq.Parser);

		// Token: 0x0400569B RID: 22171
		private readonly RepeatedField<InstLevelPlayStateReq> instLevelPlayStateReqs_ = new RepeatedField<InstLevelPlayStateReq>();
	}
}
