using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000625 RID: 1573
	[NetMessage(EMessageId.FoundationCoreOperateResponse)]
	public sealed class FoundationCoreOperateResponse : IMessage<FoundationCoreOperateResponse>, IMessage, IEquatable<FoundationCoreOperateResponse>, IDeepCloneable<FoundationCoreOperateResponse>, IBufferMessage
	{
		// Token: 0x06009173 RID: 37235 RVA: 0x001607A8 File Offset: 0x0015E9A8
		[NullableContext(1)]
		public static FoundationCoreOperateResponse Create()
		{
			return new FoundationCoreOperateResponse();
		}

		// Token: 0x17001CEC RID: 7404
		// (get) Token: 0x06009174 RID: 37236 RVA: 0x001607AF File Offset: 0x0015E9AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001CED RID: 7405
		// (get) Token: 0x06009175 RID: 37237 RVA: 0x001607B2 File Offset: 0x0015E9B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FoundationCoreOperateResponse.Descriptor;
			}
		}

		// Token: 0x06009176 RID: 37238 RVA: 0x001607B9 File Offset: 0x0015E9B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FoundationCoreOperateResponse()
		{
		}

		// Token: 0x06009177 RID: 37239 RVA: 0x001607C4 File Offset: 0x0015E9C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FoundationCoreOperateResponse(FoundationCoreOperateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.fromFoundationEntityId_ = other.fromFoundationEntityId_;
			this.foundationCoreInfo_ = ((other.foundationCoreInfo_ != null) ? other.foundationCoreInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009178 RID: 37240 RVA: 0x0016081C File Offset: 0x0015EA1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FoundationCoreOperateResponse Clone()
		{
			return new FoundationCoreOperateResponse(this);
		}

		// Token: 0x17001CEE RID: 7406
		// (get) Token: 0x06009179 RID: 37241 RVA: 0x00160824 File Offset: 0x0015EA24
		// (set) Token: 0x0600917A RID: 37242 RVA: 0x0016082C File Offset: 0x0015EA2C
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

		// Token: 0x17001CEF RID: 7407
		// (get) Token: 0x0600917B RID: 37243 RVA: 0x00160835 File Offset: 0x0015EA35
		// (set) Token: 0x0600917C RID: 37244 RVA: 0x0016083D File Offset: 0x0015EA3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FromFoundationEntityId
		{
			get
			{
				return this.fromFoundationEntityId_;
			}
			set
			{
				this.fromFoundationEntityId_ = value;
			}
		}

		// Token: 0x17001CF0 RID: 7408
		// (get) Token: 0x0600917D RID: 37245 RVA: 0x00160846 File Offset: 0x0015EA46
		// (set) Token: 0x0600917E RID: 37246 RVA: 0x0016084E File Offset: 0x0015EA4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FoundationCoreInfo FoundationCoreInfo
		{
			get
			{
				return this.foundationCoreInfo_;
			}
			set
			{
				this.foundationCoreInfo_ = value;
			}
		}

		// Token: 0x0600917F RID: 37247 RVA: 0x00160857 File Offset: 0x0015EA57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FoundationCoreOperateResponse);
		}

		// Token: 0x06009180 RID: 37248 RVA: 0x00160868 File Offset: 0x0015EA68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FoundationCoreOperateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.FromFoundationEntityId == other.FromFoundationEntityId && object.Equals(this.FoundationCoreInfo, other.FoundationCoreInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009181 RID: 37249 RVA: 0x001608C8 File Offset: 0x0015EAC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.FromFoundationEntityId != 0)
			{
				num ^= this.FromFoundationEntityId.GetHashCode();
			}
			if (this.foundationCoreInfo_ != null)
			{
				num ^= this.FoundationCoreInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009182 RID: 37250 RVA: 0x0016093C File Offset: 0x0015EB3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009183 RID: 37251 RVA: 0x00160949 File Offset: 0x0015EB49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009184 RID: 37252 RVA: 0x00160954 File Offset: 0x0015EB54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.foundationCoreInfo_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.FoundationCoreInfo);
			}
			if (this.FromFoundationEntityId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.FromFoundationEntityId);
			}
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

		// Token: 0x06009185 RID: 37253 RVA: 0x001609CC File Offset: 0x0015EBCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.FromFoundationEntityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FromFoundationEntityId);
			}
			if (this.foundationCoreInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FoundationCoreInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009186 RID: 37254 RVA: 0x00160A3C File Offset: 0x0015EC3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FoundationCoreOperateResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.FromFoundationEntityId != 0)
			{
				this.FromFoundationEntityId = other.FromFoundationEntityId;
			}
			if (other.foundationCoreInfo_ != null)
			{
				if (this.foundationCoreInfo_ == null)
				{
					this.FoundationCoreInfo = new FoundationCoreInfo();
				}
				this.FoundationCoreInfo.MergeFrom(other.FoundationCoreInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009187 RID: 37255 RVA: 0x00160AB8 File Offset: 0x0015ECB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009188 RID: 37256 RVA: 0x00160AC4 File Offset: 0x0015ECC4
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
				if (num != 26U)
				{
					if (num != 32U)
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
						this.FromFoundationEntityId = input.ReadInt32();
					}
				}
				else
				{
					if (this.foundationCoreInfo_ == null)
					{
						this.FoundationCoreInfo = new FoundationCoreInfo();
					}
					input.ReadMessage(this.FoundationCoreInfo);
				}
			}
		}

		// Token: 0x040046AE RID: 18094
		private UnknownFieldSet _unknownFields;

		// Token: 0x040046AF RID: 18095
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x040046B0 RID: 18096
		private ErrorCode errorCode_;

		// Token: 0x040046B1 RID: 18097
		public const int FromFoundationEntityIdFieldNumber = 4;

		// Token: 0x040046B2 RID: 18098
		private int fromFoundationEntityId_;

		// Token: 0x040046B3 RID: 18099
		public const int FoundationCoreInfoFieldNumber = 3;

		// Token: 0x040046B4 RID: 18100
		private FoundationCoreInfo foundationCoreInfo_;
	}
}
