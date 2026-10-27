using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006FC RID: 1788
	public sealed class GmEntityFsmMachineInfo : IMessage<GmEntityFsmMachineInfo>, IMessage, IEquatable<GmEntityFsmMachineInfo>, IDeepCloneable<GmEntityFsmMachineInfo>, IBufferMessage
	{
		// Token: 0x0600A2D5 RID: 41685 RVA: 0x0018999C File Offset: 0x00187B9C
		[NullableContext(1)]
		public static GmEntityFsmMachineInfo Create()
		{
			return new GmEntityFsmMachineInfo();
		}

		// Token: 0x170020B9 RID: 8377
		// (get) Token: 0x0600A2D6 RID: 41686 RVA: 0x001899A3 File Offset: 0x00187BA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GmEntityFsmMachineInfo> Parser
		{
			get
			{
				return GmEntityFsmMachineInfo._parser;
			}
		}

		// Token: 0x170020BA RID: 8378
		// (get) Token: 0x0600A2D7 RID: 41687 RVA: 0x001899AA File Offset: 0x00187BAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170020BB RID: 8379
		// (get) Token: 0x0600A2D8 RID: 41688 RVA: 0x001899AD File Offset: 0x00187BAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GmEntityFsmMachineInfo.Descriptor;
			}
		}

		// Token: 0x0600A2D9 RID: 41689 RVA: 0x001899B4 File Offset: 0x00187BB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmEntityFsmMachineInfo()
		{
		}

		// Token: 0x0600A2DA RID: 41690 RVA: 0x001899C7 File Offset: 0x00187BC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmEntityFsmMachineInfo(GmEntityFsmMachineInfo other) : this()
		{
			this.stateIndex_ = other.stateIndex_;
			this.gmEntityFsmStateInfos_ = other.gmEntityFsmStateInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A2DB RID: 41691 RVA: 0x001899FD File Offset: 0x00187BFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmEntityFsmMachineInfo Clone()
		{
			return new GmEntityFsmMachineInfo(this);
		}

		// Token: 0x170020BC RID: 8380
		// (get) Token: 0x0600A2DC RID: 41692 RVA: 0x00189A05 File Offset: 0x00187C05
		// (set) Token: 0x0600A2DD RID: 41693 RVA: 0x00189A0D File Offset: 0x00187C0D
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

		// Token: 0x170020BD RID: 8381
		// (get) Token: 0x0600A2DE RID: 41694 RVA: 0x00189A16 File Offset: 0x00187C16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GmEntityFsmStateInfo> GmEntityFsmStateInfos
		{
			get
			{
				return this.gmEntityFsmStateInfos_;
			}
		}

		// Token: 0x0600A2DF RID: 41695 RVA: 0x00189A1E File Offset: 0x00187C1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GmEntityFsmMachineInfo);
		}

		// Token: 0x0600A2E0 RID: 41696 RVA: 0x00189A2C File Offset: 0x00187C2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GmEntityFsmMachineInfo other)
		{
			return other != null && (other == this || (this.StateIndex == other.StateIndex && this.gmEntityFsmStateInfos_.Equals(other.gmEntityFsmStateInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A2E1 RID: 41697 RVA: 0x00189A7C File Offset: 0x00187C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.StateIndex != 0)
			{
				num ^= this.StateIndex.GetHashCode();
			}
			num ^= this.gmEntityFsmStateInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A2E2 RID: 41698 RVA: 0x00189AC9 File Offset: 0x00187CC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A2E3 RID: 41699 RVA: 0x00189AD6 File Offset: 0x00187CD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A2E4 RID: 41700 RVA: 0x00189AE0 File Offset: 0x00187CE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.StateIndex != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.StateIndex);
			}
			this.gmEntityFsmStateInfos_.WriteTo(ref output, GmEntityFsmMachineInfo._repeated_gmEntityFsmStateInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A2E5 RID: 41701 RVA: 0x00189B30 File Offset: 0x00187D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.StateIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StateIndex);
			}
			num += this.gmEntityFsmStateInfos_.CalculateSize(GmEntityFsmMachineInfo._repeated_gmEntityFsmStateInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A2E6 RID: 41702 RVA: 0x00189B84 File Offset: 0x00187D84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GmEntityFsmMachineInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.StateIndex != 0)
			{
				this.StateIndex = other.StateIndex;
			}
			this.gmEntityFsmStateInfos_.Add(other.gmEntityFsmStateInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A2E7 RID: 41703 RVA: 0x00189BD1 File Offset: 0x00187DD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A2E8 RID: 41704 RVA: 0x00189BDC File Offset: 0x00187DDC
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
						this.gmEntityFsmStateInfos_.AddEntriesFrom(ref input, GmEntityFsmMachineInfo._repeated_gmEntityFsmStateInfos_codec);
					}
				}
				else
				{
					this.StateIndex = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004B5E RID: 19294
		private static readonly MessageParser<GmEntityFsmMachineInfo> _parser = new MessageParser<GmEntityFsmMachineInfo>(() => new GmEntityFsmMachineInfo());

		// Token: 0x04004B5F RID: 19295
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B60 RID: 19296
		public const int StateIndexFieldNumber = 1;

		// Token: 0x04004B61 RID: 19297
		private int stateIndex_;

		// Token: 0x04004B62 RID: 19298
		public const int GmEntityFsmStateInfosFieldNumber = 2;

		// Token: 0x04004B63 RID: 19299
		private static readonly FieldCodec<GmEntityFsmStateInfo> _repeated_gmEntityFsmStateInfos_codec = FieldCodec.ForMessage<GmEntityFsmStateInfo>(18U, GmEntityFsmStateInfo.Parser);

		// Token: 0x04004B64 RID: 19300
		private readonly RepeatedField<GmEntityFsmStateInfo> gmEntityFsmStateInfos_ = new RepeatedField<GmEntityFsmStateInfo>();
	}
}
