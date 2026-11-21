using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001458 RID: 5208
	[NetMessage(EMessageId.TrackMoonIllustratedRequest)]
	public sealed class TrackMoonIllustratedRequest : IMessage<TrackMoonIllustratedRequest>, IMessage, IEquatable<TrackMoonIllustratedRequest>, IDeepCloneable<TrackMoonIllustratedRequest>, IBufferMessage
	{
		// Token: 0x0601BA76 RID: 113270 RVA: 0x00404239 File Offset: 0x00402439
		[NullableContext(1)]
		public static TrackMoonIllustratedRequest Create()
		{
			return new TrackMoonIllustratedRequest();
		}

		// Token: 0x17005D91 RID: 23953
		// (get) Token: 0x0601BA77 RID: 113271 RVA: 0x00404240 File Offset: 0x00402440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D92 RID: 23954
		// (get) Token: 0x0601BA78 RID: 113272 RVA: 0x00404243 File Offset: 0x00402443
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrackMoonIllustratedRequest.Descriptor;
			}
		}

		// Token: 0x0601BA79 RID: 113273 RVA: 0x0040424A File Offset: 0x0040244A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonIllustratedRequest()
		{
		}

		// Token: 0x0601BA7A RID: 113274 RVA: 0x0040425D File Offset: 0x0040245D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonIllustratedRequest(TrackMoonIllustratedRequest other) : this()
		{
			this.ids_ = other.ids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BA7B RID: 113275 RVA: 0x00404287 File Offset: 0x00402487
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonIllustratedRequest Clone()
		{
			return new TrackMoonIllustratedRequest(this);
		}

		// Token: 0x17005D93 RID: 23955
		// (get) Token: 0x0601BA7C RID: 113276 RVA: 0x0040428F File Offset: 0x0040248F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x0601BA7D RID: 113277 RVA: 0x00404297 File Offset: 0x00402497
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrackMoonIllustratedRequest);
		}

		// Token: 0x0601BA7E RID: 113278 RVA: 0x004042A5 File Offset: 0x004024A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrackMoonIllustratedRequest other)
		{
			return other != null && (other == this || (this.ids_.Equals(other.ids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BA7F RID: 113279 RVA: 0x004042D8 File Offset: 0x004024D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.ids_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BA80 RID: 113280 RVA: 0x0040430C File Offset: 0x0040250C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BA81 RID: 113281 RVA: 0x00404319 File Offset: 0x00402519
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BA82 RID: 113282 RVA: 0x00404322 File Offset: 0x00402522
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.ids_.WriteTo(ref output, TrackMoonIllustratedRequest._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BA83 RID: 113283 RVA: 0x0040434C File Offset: 0x0040254C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.ids_.CalculateSize(TrackMoonIllustratedRequest._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BA84 RID: 113284 RVA: 0x00404385 File Offset: 0x00402585
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrackMoonIllustratedRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.ids_.Add(other.ids_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BA85 RID: 113285 RVA: 0x004043B3 File Offset: 0x004025B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BA86 RID: 113286 RVA: 0x004043BC File Offset: 0x004025BC
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
				if (num != 88U && num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ids_.AddEntriesFrom(ref input, TrackMoonIllustratedRequest._repeated_ids_codec);
				}
			}
		}

		// Token: 0x0400A098 RID: 41112
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A099 RID: 41113
		public const int IdsFieldNumber = 11;

		// Token: 0x0400A09A RID: 41114
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(90U);

		// Token: 0x0400A09B RID: 41115
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();
	}
}
