using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006E8 RID: 1768
	public sealed class GmEntityFsmMachineInfo : IMessage<GmEntityFsmMachineInfo>, IMessage, IEquatable<GmEntityFsmMachineInfo>, IDeepCloneable<GmEntityFsmMachineInfo>, IBufferMessage
	{
		// Token: 0x0600A17F RID: 41343 RVA: 0x00186F68 File Offset: 0x00185168
		[NullableContext(1)]
		public static GmEntityFsmMachineInfo Create()
		{
			return new GmEntityFsmMachineInfo();
		}

		// Token: 0x1700206F RID: 8303
		// (get) Token: 0x0600A180 RID: 41344 RVA: 0x00186F6F File Offset: 0x0018516F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GmEntityFsmMachineInfo> Parser
		{
			get
			{
				return GmEntityFsmMachineInfo._parser;
			}
		}

		// Token: 0x17002070 RID: 8304
		// (get) Token: 0x0600A181 RID: 41345 RVA: 0x00186F76 File Offset: 0x00185176
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002071 RID: 8305
		// (get) Token: 0x0600A182 RID: 41346 RVA: 0x00186F79 File Offset: 0x00185179
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GmEntityFsmMachineInfo.Descriptor;
			}
		}

		// Token: 0x0600A183 RID: 41347 RVA: 0x00186F80 File Offset: 0x00185180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmEntityFsmMachineInfo()
		{
		}

		// Token: 0x0600A184 RID: 41348 RVA: 0x00186F93 File Offset: 0x00185193
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmEntityFsmMachineInfo(GmEntityFsmMachineInfo other) : this()
		{
			this.stateIndex_ = other.stateIndex_;
			this.gmEntityFsmStateInfos_ = other.gmEntityFsmStateInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A185 RID: 41349 RVA: 0x00186FC9 File Offset: 0x001851C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmEntityFsmMachineInfo Clone()
		{
			return new GmEntityFsmMachineInfo(this);
		}

		// Token: 0x17002072 RID: 8306
		// (get) Token: 0x0600A186 RID: 41350 RVA: 0x00186FD1 File Offset: 0x001851D1
		// (set) Token: 0x0600A187 RID: 41351 RVA: 0x00186FD9 File Offset: 0x001851D9
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

		// Token: 0x17002073 RID: 8307
		// (get) Token: 0x0600A188 RID: 41352 RVA: 0x00186FE2 File Offset: 0x001851E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GmEntityFsmStateInfo> GmEntityFsmStateInfos
		{
			get
			{
				return this.gmEntityFsmStateInfos_;
			}
		}

		// Token: 0x0600A189 RID: 41353 RVA: 0x00186FEA File Offset: 0x001851EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GmEntityFsmMachineInfo);
		}

		// Token: 0x0600A18A RID: 41354 RVA: 0x00186FF8 File Offset: 0x001851F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GmEntityFsmMachineInfo other)
		{
			return other != null && (other == this || (this.StateIndex == other.StateIndex && this.gmEntityFsmStateInfos_.Equals(other.gmEntityFsmStateInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A18B RID: 41355 RVA: 0x00187048 File Offset: 0x00185248
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

		// Token: 0x0600A18C RID: 41356 RVA: 0x00187095 File Offset: 0x00185295
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A18D RID: 41357 RVA: 0x001870A2 File Offset: 0x001852A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A18E RID: 41358 RVA: 0x001870AC File Offset: 0x001852AC
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

		// Token: 0x0600A18F RID: 41359 RVA: 0x001870FC File Offset: 0x001852FC
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

		// Token: 0x0600A190 RID: 41360 RVA: 0x00187150 File Offset: 0x00185350
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

		// Token: 0x0600A191 RID: 41361 RVA: 0x0018719D File Offset: 0x0018539D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A192 RID: 41362 RVA: 0x001871A8 File Offset: 0x001853A8
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

		// Token: 0x04004B57 RID: 19287
		private static readonly MessageParser<GmEntityFsmMachineInfo> _parser = new MessageParser<GmEntityFsmMachineInfo>(() => new GmEntityFsmMachineInfo());

		// Token: 0x04004B58 RID: 19288
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B59 RID: 19289
		public const int StateIndexFieldNumber = 1;

		// Token: 0x04004B5A RID: 19290
		private int stateIndex_;

		// Token: 0x04004B5B RID: 19291
		public const int GmEntityFsmStateInfosFieldNumber = 2;

		// Token: 0x04004B5C RID: 19292
		private static readonly FieldCodec<GmEntityFsmStateInfo> _repeated_gmEntityFsmStateInfos_codec = FieldCodec.ForMessage<GmEntityFsmStateInfo>(18U, GmEntityFsmStateInfo.Parser);

		// Token: 0x04004B5D RID: 19293
		private readonly RepeatedField<GmEntityFsmStateInfo> gmEntityFsmStateInfos_ = new RepeatedField<GmEntityFsmStateInfo>();
	}
}
