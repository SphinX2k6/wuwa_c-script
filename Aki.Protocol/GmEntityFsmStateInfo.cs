using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006E9 RID: 1769
	public sealed class GmEntityFsmStateInfo : IMessage<GmEntityFsmStateInfo>, IMessage, IEquatable<GmEntityFsmStateInfo>, IDeepCloneable<GmEntityFsmStateInfo>, IBufferMessage
	{
		// Token: 0x0600A194 RID: 41364 RVA: 0x00187231 File Offset: 0x00185431
		[NullableContext(1)]
		public static GmEntityFsmStateInfo Create()
		{
			return new GmEntityFsmStateInfo();
		}

		// Token: 0x17002074 RID: 8308
		// (get) Token: 0x0600A195 RID: 41365 RVA: 0x00187238 File Offset: 0x00185438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GmEntityFsmStateInfo> Parser
		{
			get
			{
				return GmEntityFsmStateInfo._parser;
			}
		}

		// Token: 0x17002075 RID: 8309
		// (get) Token: 0x0600A196 RID: 41366 RVA: 0x0018723F File Offset: 0x0018543F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002076 RID: 8310
		// (get) Token: 0x0600A197 RID: 41367 RVA: 0x00187242 File Offset: 0x00185442
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GmEntityFsmStateInfo.Descriptor;
			}
		}

		// Token: 0x0600A198 RID: 41368 RVA: 0x00187249 File Offset: 0x00185449
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmEntityFsmStateInfo()
		{
		}

		// Token: 0x0600A199 RID: 41369 RVA: 0x0018725C File Offset: 0x0018545C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmEntityFsmStateInfo(GmEntityFsmStateInfo other) : this()
		{
			this.stateIndex_ = other.stateIndex_;
			this.gmEntityFsmTransitionInfos_ = other.gmEntityFsmTransitionInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A19A RID: 41370 RVA: 0x00187292 File Offset: 0x00185492
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmEntityFsmStateInfo Clone()
		{
			return new GmEntityFsmStateInfo(this);
		}

		// Token: 0x17002077 RID: 8311
		// (get) Token: 0x0600A19B RID: 41371 RVA: 0x0018729A File Offset: 0x0018549A
		// (set) Token: 0x0600A19C RID: 41372 RVA: 0x001872A2 File Offset: 0x001854A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StateIndex
		{
			get
			{
				return this.stateIndex_;
			}
			set
			{
				this.stateIndex_ = value;
			}
		}

		// Token: 0x17002078 RID: 8312
		// (get) Token: 0x0600A19D RID: 41373 RVA: 0x001872AB File Offset: 0x001854AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GmEntityFsmTransitionInfo> GmEntityFsmTransitionInfos
		{
			get
			{
				return this.gmEntityFsmTransitionInfos_;
			}
		}

		// Token: 0x0600A19E RID: 41374 RVA: 0x001872B3 File Offset: 0x001854B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GmEntityFsmStateInfo);
		}

		// Token: 0x0600A19F RID: 41375 RVA: 0x001872C4 File Offset: 0x001854C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GmEntityFsmStateInfo other)
		{
			return other != null && (other == this || (this.StateIndex == other.StateIndex && this.gmEntityFsmTransitionInfos_.Equals(other.gmEntityFsmTransitionInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A1A0 RID: 41376 RVA: 0x00187314 File Offset: 0x00185514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.StateIndex != 0)
			{
				num ^= this.StateIndex.GetHashCode();
			}
			num ^= this.gmEntityFsmTransitionInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A1A1 RID: 41377 RVA: 0x00187361 File Offset: 0x00185561
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A1A2 RID: 41378 RVA: 0x0018736E File Offset: 0x0018556E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A1A3 RID: 41379 RVA: 0x00187378 File Offset: 0x00185578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.StateIndex != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.StateIndex);
			}
			this.gmEntityFsmTransitionInfos_.WriteTo(ref output, GmEntityFsmStateInfo._repeated_gmEntityFsmTransitionInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A1A4 RID: 41380 RVA: 0x001873C8 File Offset: 0x001855C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.StateIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StateIndex);
			}
			num += this.gmEntityFsmTransitionInfos_.CalculateSize(GmEntityFsmStateInfo._repeated_gmEntityFsmTransitionInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A1A5 RID: 41381 RVA: 0x0018741C File Offset: 0x0018561C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GmEntityFsmStateInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.StateIndex != 0)
			{
				this.StateIndex = other.StateIndex;
			}
			this.gmEntityFsmTransitionInfos_.Add(other.gmEntityFsmTransitionInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A1A6 RID: 41382 RVA: 0x00187469 File Offset: 0x00185669
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A1A7 RID: 41383 RVA: 0x00187474 File Offset: 0x00185674
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
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.gmEntityFsmTransitionInfos_.AddEntriesFrom(ref input, GmEntityFsmStateInfo._repeated_gmEntityFsmTransitionInfos_codec);
					}
				}
				else
				{
					this.StateIndex = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004B5E RID: 19294
		private static readonly MessageParser<GmEntityFsmStateInfo> _parser = new MessageParser<GmEntityFsmStateInfo>(() => new GmEntityFsmStateInfo());

		// Token: 0x04004B5F RID: 19295
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B60 RID: 19296
		public const int StateIndexFieldNumber = 1;

		// Token: 0x04004B61 RID: 19297
		private int stateIndex_;

		// Token: 0x04004B62 RID: 19298
		public const int GmEntityFsmTransitionInfosFieldNumber = 2;

		// Token: 0x04004B63 RID: 19299
		private static readonly FieldCodec<GmEntityFsmTransitionInfo> _repeated_gmEntityFsmTransitionInfos_codec = FieldCodec.ForMessage<GmEntityFsmTransitionInfo>(18U, GmEntityFsmTransitionInfo.Parser);

		// Token: 0x04004B64 RID: 19300
		private readonly RepeatedField<GmEntityFsmTransitionInfo> gmEntityFsmTransitionInfos_ = new RepeatedField<GmEntityFsmTransitionInfo>();
	}
}
