using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B9F RID: 2975
	public sealed class OrnamentDressInfo : IMessage<OrnamentDressInfo>, IMessage, IEquatable<OrnamentDressInfo>, IDeepCloneable<OrnamentDressInfo>, IBufferMessage
	{
		// Token: 0x0601027C RID: 66172 RVA: 0x0025C488 File Offset: 0x0025A688
		[NullableContext(1)]
		public static OrnamentDressInfo Create()
		{
			return new OrnamentDressInfo();
		}

		// Token: 0x170034F9 RID: 13561
		// (get) Token: 0x0601027D RID: 66173 RVA: 0x0025C48F File Offset: 0x0025A68F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OrnamentDressInfo> Parser
		{
			get
			{
				return OrnamentDressInfo._parser;
			}
		}

		// Token: 0x170034FA RID: 13562
		// (get) Token: 0x0601027E RID: 66174 RVA: 0x0025C496 File Offset: 0x0025A696
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170034FB RID: 13563
		// (get) Token: 0x0601027F RID: 66175 RVA: 0x0025C499 File Offset: 0x0025A699
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OrnamentDressInfo.Descriptor;
			}
		}

		// Token: 0x06010280 RID: 66176 RVA: 0x0025C4A0 File Offset: 0x0025A6A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrnamentDressInfo()
		{
		}

		// Token: 0x06010281 RID: 66177 RVA: 0x0025C4B3 File Offset: 0x0025A6B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrnamentDressInfo(OrnamentDressInfo other) : this()
		{
			this.roleSkinId_ = other.roleSkinId_;
			this.dressOrnamentIds_ = other.dressOrnamentIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010282 RID: 66178 RVA: 0x0025C4E9 File Offset: 0x0025A6E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrnamentDressInfo Clone()
		{
			return new OrnamentDressInfo(this);
		}

		// Token: 0x170034FC RID: 13564
		// (get) Token: 0x06010283 RID: 66179 RVA: 0x0025C4F1 File Offset: 0x0025A6F1
		// (set) Token: 0x06010284 RID: 66180 RVA: 0x0025C4F9 File Offset: 0x0025A6F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleSkinId
		{
			get
			{
				return this.roleSkinId_;
			}
			set
			{
				this.roleSkinId_ = value;
			}
		}

		// Token: 0x170034FD RID: 13565
		// (get) Token: 0x06010285 RID: 66181 RVA: 0x0025C502 File Offset: 0x0025A702
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DressOrnamentIds
		{
			get
			{
				return this.dressOrnamentIds_;
			}
		}

		// Token: 0x06010286 RID: 66182 RVA: 0x0025C50A File Offset: 0x0025A70A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OrnamentDressInfo);
		}

		// Token: 0x06010287 RID: 66183 RVA: 0x0025C518 File Offset: 0x0025A718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OrnamentDressInfo other)
		{
			return other != null && (other == this || (this.RoleSkinId == other.RoleSkinId && this.dressOrnamentIds_.Equals(other.dressOrnamentIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010288 RID: 66184 RVA: 0x0025C568 File Offset: 0x0025A768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleSkinId != 0)
			{
				num ^= this.RoleSkinId.GetHashCode();
			}
			num ^= this.dressOrnamentIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010289 RID: 66185 RVA: 0x0025C5B5 File Offset: 0x0025A7B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601028A RID: 66186 RVA: 0x0025C5C2 File Offset: 0x0025A7C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601028B RID: 66187 RVA: 0x0025C5CC File Offset: 0x0025A7CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleSkinId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleSkinId);
			}
			this.dressOrnamentIds_.WriteTo(ref output, OrnamentDressInfo._repeated_dressOrnamentIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601028C RID: 66188 RVA: 0x0025C61C File Offset: 0x0025A81C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleSkinId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleSkinId);
			}
			num += this.dressOrnamentIds_.CalculateSize(OrnamentDressInfo._repeated_dressOrnamentIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601028D RID: 66189 RVA: 0x0025C670 File Offset: 0x0025A870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OrnamentDressInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleSkinId != 0)
			{
				this.RoleSkinId = other.RoleSkinId;
			}
			this.dressOrnamentIds_.Add(other.dressOrnamentIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601028E RID: 66190 RVA: 0x0025C6BD File Offset: 0x0025A8BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601028F RID: 66191 RVA: 0x0025C6C8 File Offset: 0x0025A8C8
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
					if (num != 16U && num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.dressOrnamentIds_.AddEntriesFrom(ref input, OrnamentDressInfo._repeated_dressOrnamentIds_codec);
					}
				}
				else
				{
					this.RoleSkinId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006755 RID: 26453
		private static readonly MessageParser<OrnamentDressInfo> _parser = new MessageParser<OrnamentDressInfo>(() => new OrnamentDressInfo());

		// Token: 0x04006756 RID: 26454
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006757 RID: 26455
		public const int RoleSkinIdFieldNumber = 1;

		// Token: 0x04006758 RID: 26456
		private int roleSkinId_;

		// Token: 0x04006759 RID: 26457
		public const int DressOrnamentIdsFieldNumber = 2;

		// Token: 0x0400675A RID: 26458
		private static readonly FieldCodec<int> _repeated_dressOrnamentIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x0400675B RID: 26459
		private readonly RepeatedField<int> dressOrnamentIds_ = new RepeatedField<int>();
	}
}
