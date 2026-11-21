using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010D0 RID: 4304
	[NetMessage(EMessageId.RoleTowerPhantomAddAttrsResponse)]
	public sealed class RoleTowerPhantomAddAttrsResponse : IMessage<RoleTowerPhantomAddAttrsResponse>, IMessage, IEquatable<RoleTowerPhantomAddAttrsResponse>, IDeepCloneable<RoleTowerPhantomAddAttrsResponse>, IBufferMessage
	{
		// Token: 0x06017016 RID: 94230 RVA: 0x00358814 File Offset: 0x00356A14
		[NullableContext(1)]
		public static RoleTowerPhantomAddAttrsResponse Create()
		{
			return new RoleTowerPhantomAddAttrsResponse();
		}

		// Token: 0x17004D2F RID: 19759
		// (get) Token: 0x06017017 RID: 94231 RVA: 0x0035881B File Offset: 0x00356A1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D30 RID: 19760
		// (get) Token: 0x06017018 RID: 94232 RVA: 0x0035881E File Offset: 0x00356A1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerPhantomAddAttrsResponse.Descriptor;
			}
		}

		// Token: 0x06017019 RID: 94233 RVA: 0x00358825 File Offset: 0x00356A25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerPhantomAddAttrsResponse()
		{
		}

		// Token: 0x0601701A RID: 94234 RVA: 0x00358838 File Offset: 0x00356A38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerPhantomAddAttrsResponse(RoleTowerPhantomAddAttrsResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.phantomAddAttrInfos_ = other.phantomAddAttrInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601701B RID: 94235 RVA: 0x0035886E File Offset: 0x00356A6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerPhantomAddAttrsResponse Clone()
		{
			return new RoleTowerPhantomAddAttrsResponse(this);
		}

		// Token: 0x17004D31 RID: 19761
		// (get) Token: 0x0601701C RID: 94236 RVA: 0x00358876 File Offset: 0x00356A76
		// (set) Token: 0x0601701D RID: 94237 RVA: 0x0035887E File Offset: 0x00356A7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17004D32 RID: 19762
		// (get) Token: 0x0601701E RID: 94238 RVA: 0x00358887 File Offset: 0x00356A87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleTowerPhantomAddAttr> PhantomAddAttrInfos
		{
			get
			{
				return this.phantomAddAttrInfos_;
			}
		}

		// Token: 0x0601701F RID: 94239 RVA: 0x0035888F File Offset: 0x00356A8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerPhantomAddAttrsResponse);
		}

		// Token: 0x06017020 RID: 94240 RVA: 0x003588A0 File Offset: 0x00356AA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerPhantomAddAttrsResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.phantomAddAttrInfos_.Equals(other.phantomAddAttrInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017021 RID: 94241 RVA: 0x003588F0 File Offset: 0x00356AF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.phantomAddAttrInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017022 RID: 94242 RVA: 0x00358943 File Offset: 0x00356B43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017023 RID: 94243 RVA: 0x00358950 File Offset: 0x00356B50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017024 RID: 94244 RVA: 0x0035895C File Offset: 0x00356B5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.phantomAddAttrInfos_.WriteTo(ref output, RoleTowerPhantomAddAttrsResponse._repeated_phantomAddAttrInfos_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017025 RID: 94245 RVA: 0x003589AC File Offset: 0x00356BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.phantomAddAttrInfos_.CalculateSize(RoleTowerPhantomAddAttrsResponse._repeated_phantomAddAttrInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017026 RID: 94246 RVA: 0x00358A00 File Offset: 0x00356C00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerPhantomAddAttrsResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.phantomAddAttrInfos_.Add(other.phantomAddAttrInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017027 RID: 94247 RVA: 0x00358A4D File Offset: 0x00356C4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017028 RID: 94248 RVA: 0x00358A58 File Offset: 0x00356C58
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
				if (num != 82U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.phantomAddAttrInfos_.AddEntriesFrom(ref input, RoleTowerPhantomAddAttrsResponse._repeated_phantomAddAttrInfos_codec);
				}
			}
		}

		// Token: 0x040089AF RID: 35247
		private UnknownFieldSet _unknownFields;

		// Token: 0x040089B0 RID: 35248
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x040089B1 RID: 35249
		private ErrorCode errorCode_;

		// Token: 0x040089B2 RID: 35250
		public const int PhantomAddAttrInfosFieldNumber = 10;

		// Token: 0x040089B3 RID: 35251
		private static readonly FieldCodec<RoleTowerPhantomAddAttr> _repeated_phantomAddAttrInfos_codec = FieldCodec.ForMessage<RoleTowerPhantomAddAttr>(82U, RoleTowerPhantomAddAttr.Parser);

		// Token: 0x040089B4 RID: 35252
		private readonly RepeatedField<RoleTowerPhantomAddAttr> phantomAddAttrInfos_ = new RepeatedField<RoleTowerPhantomAddAttr>();
	}
}
