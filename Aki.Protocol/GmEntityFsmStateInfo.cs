using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006FD RID: 1789
	public sealed class GmEntityFsmStateInfo : IMessage<GmEntityFsmStateInfo>, IMessage, IEquatable<GmEntityFsmStateInfo>, IDeepCloneable<GmEntityFsmStateInfo>, IBufferMessage
	{
		// Token: 0x0600A2EA RID: 41706 RVA: 0x00189C65 File Offset: 0x00187E65
		[NullableContext(1)]
		public static GmEntityFsmStateInfo Create()
		{
			return new GmEntityFsmStateInfo();
		}

		// Token: 0x170020BE RID: 8382
		// (get) Token: 0x0600A2EB RID: 41707 RVA: 0x00189C6C File Offset: 0x00187E6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GmEntityFsmStateInfo> Parser
		{
			get
			{
				return GmEntityFsmStateInfo._parser;
			}
		}

		// Token: 0x170020BF RID: 8383
		// (get) Token: 0x0600A2EC RID: 41708 RVA: 0x00189C73 File Offset: 0x00187E73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170020C0 RID: 8384
		// (get) Token: 0x0600A2ED RID: 41709 RVA: 0x00189C76 File Offset: 0x00187E76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GmEntityFsmStateInfo.Descriptor;
			}
		}

		// Token: 0x0600A2EE RID: 41710 RVA: 0x00189C7D File Offset: 0x00187E7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmEntityFsmStateInfo()
		{
		}

		// Token: 0x0600A2EF RID: 41711 RVA: 0x00189C90 File Offset: 0x00187E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmEntityFsmStateInfo(GmEntityFsmStateInfo other) : this()
		{
			this.stateIndex_ = other.stateIndex_;
			this.gmEntityFsmTransitionInfos_ = other.gmEntityFsmTransitionInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A2F0 RID: 41712 RVA: 0x00189CC6 File Offset: 0x00187EC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmEntityFsmStateInfo Clone()
		{
			return new GmEntityFsmStateInfo(this);
		}

		// Token: 0x170020C1 RID: 8385
		// (get) Token: 0x0600A2F1 RID: 41713 RVA: 0x00189CCE File Offset: 0x00187ECE
		// (set) Token: 0x0600A2F2 RID: 41714 RVA: 0x00189CD6 File Offset: 0x00187ED6
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

		// Token: 0x170020C2 RID: 8386
		// (get) Token: 0x0600A2F3 RID: 41715 RVA: 0x00189CDF File Offset: 0x00187EDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GmEntityFsmTransitionInfo> GmEntityFsmTransitionInfos
		{
			get
			{
				return this.gmEntityFsmTransitionInfos_;
			}
		}

		// Token: 0x0600A2F4 RID: 41716 RVA: 0x00189CE7 File Offset: 0x00187EE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GmEntityFsmStateInfo);
		}

		// Token: 0x0600A2F5 RID: 41717 RVA: 0x00189CF8 File Offset: 0x00187EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GmEntityFsmStateInfo other)
		{
			return other != null && (other == this || (this.StateIndex == other.StateIndex && this.gmEntityFsmTransitionInfos_.Equals(other.gmEntityFsmTransitionInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A2F6 RID: 41718 RVA: 0x00189D48 File Offset: 0x00187F48
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

		// Token: 0x0600A2F7 RID: 41719 RVA: 0x00189D95 File Offset: 0x00187F95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A2F8 RID: 41720 RVA: 0x00189DA2 File Offset: 0x00187FA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A2F9 RID: 41721 RVA: 0x00189DAC File Offset: 0x00187FAC
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

		// Token: 0x0600A2FA RID: 41722 RVA: 0x00189DFC File Offset: 0x00187FFC
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

		// Token: 0x0600A2FB RID: 41723 RVA: 0x00189E50 File Offset: 0x00188050
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

		// Token: 0x0600A2FC RID: 41724 RVA: 0x00189E9D File Offset: 0x0018809D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A2FD RID: 41725 RVA: 0x00189EA8 File Offset: 0x001880A8
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

		// Token: 0x04004B65 RID: 19301
		private static readonly MessageParser<GmEntityFsmStateInfo> _parser = new MessageParser<GmEntityFsmStateInfo>(() => new GmEntityFsmStateInfo());

		// Token: 0x04004B66 RID: 19302
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B67 RID: 19303
		public const int StateIndexFieldNumber = 1;

		// Token: 0x04004B68 RID: 19304
		private int stateIndex_;

		// Token: 0x04004B69 RID: 19305
		public const int GmEntityFsmTransitionInfosFieldNumber = 2;

		// Token: 0x04004B6A RID: 19306
		private static readonly FieldCodec<GmEntityFsmTransitionInfo> _repeated_gmEntityFsmTransitionInfos_codec = FieldCodec.ForMessage<GmEntityFsmTransitionInfo>(18U, GmEntityFsmTransitionInfo.Parser);

		// Token: 0x04004B6B RID: 19307
		private readonly RepeatedField<GmEntityFsmTransitionInfo> gmEntityFsmTransitionInfos_ = new RepeatedField<GmEntityFsmTransitionInfo>();
	}
}
