using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003F1 RID: 1009
	[NetMessage(EMessageId.DropCatchInfoResponse)]
	public sealed class DropCatchInfoResponse : IMessage<DropCatchInfoResponse>, IMessage, IEquatable<DropCatchInfoResponse>, IDeepCloneable<DropCatchInfoResponse>, IBufferMessage
	{
		// Token: 0x060061F9 RID: 25081 RVA: 0x000EC3D6 File Offset: 0x000EA5D6
		[NullableContext(1)]
		public static DropCatchInfoResponse Create()
		{
			return new DropCatchInfoResponse();
		}

		// Token: 0x1700123E RID: 4670
		// (get) Token: 0x060061FA RID: 25082 RVA: 0x000EC3DD File Offset: 0x000EA5DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700123F RID: 4671
		// (get) Token: 0x060061FB RID: 25083 RVA: 0x000EC3E0 File Offset: 0x000EA5E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DropCatchInfoResponse.Descriptor;
			}
		}

		// Token: 0x060061FC RID: 25084 RVA: 0x000EC3E7 File Offset: 0x000EA5E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropCatchInfoResponse()
		{
		}

		// Token: 0x060061FD RID: 25085 RVA: 0x000EC3FA File Offset: 0x000EA5FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropCatchInfoResponse(DropCatchInfoResponse other) : this()
		{
			this.infos_ = other.infos_.Clone();
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060061FE RID: 25086 RVA: 0x000EC430 File Offset: 0x000EA630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropCatchInfoResponse Clone()
		{
			return new DropCatchInfoResponse(this);
		}

		// Token: 0x17001240 RID: 4672
		// (get) Token: 0x060061FF RID: 25087 RVA: 0x000EC438 File Offset: 0x000EA638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DropCatchLevelInfo> Infos
		{
			get
			{
				return this.infos_;
			}
		}

		// Token: 0x17001241 RID: 4673
		// (get) Token: 0x06006200 RID: 25088 RVA: 0x000EC440 File Offset: 0x000EA640
		// (set) Token: 0x06006201 RID: 25089 RVA: 0x000EC448 File Offset: 0x000EA648
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

		// Token: 0x06006202 RID: 25090 RVA: 0x000EC451 File Offset: 0x000EA651
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DropCatchInfoResponse);
		}

		// Token: 0x06006203 RID: 25091 RVA: 0x000EC460 File Offset: 0x000EA660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DropCatchInfoResponse other)
		{
			return other != null && (other == this || (this.infos_.Equals(other.infos_) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006204 RID: 25092 RVA: 0x000EC4B0 File Offset: 0x000EA6B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.infos_.GetHashCode();
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006205 RID: 25093 RVA: 0x000EC503 File Offset: 0x000EA703
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006206 RID: 25094 RVA: 0x000EC510 File Offset: 0x000EA710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006207 RID: 25095 RVA: 0x000EC51C File Offset: 0x000EA71C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.infos_.WriteTo(ref output, DropCatchInfoResponse._repeated_infos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006208 RID: 25096 RVA: 0x000EC56C File Offset: 0x000EA76C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.infos_.CalculateSize(DropCatchInfoResponse._repeated_infos_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006209 RID: 25097 RVA: 0x000EC5C0 File Offset: 0x000EA7C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DropCatchInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.infos_.Add(other.infos_);
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600620A RID: 25098 RVA: 0x000EC60D File Offset: 0x000EA80D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600620B RID: 25099 RVA: 0x000EC618 File Offset: 0x000EA818
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
				if (num != 16U)
				{
					if (num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.infos_.AddEntriesFrom(ref input, DropCatchInfoResponse._repeated_infos_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003815 RID: 14357
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003816 RID: 14358
		public const int InfosFieldNumber = 12;

		// Token: 0x04003817 RID: 14359
		private static readonly FieldCodec<DropCatchLevelInfo> _repeated_infos_codec = FieldCodec.ForMessage<DropCatchLevelInfo>(98U, DropCatchLevelInfo.Parser);

		// Token: 0x04003818 RID: 14360
		private readonly RepeatedField<DropCatchLevelInfo> infos_ = new RepeatedField<DropCatchLevelInfo>();

		// Token: 0x04003819 RID: 14361
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x0400381A RID: 14362
		private ErrorCode errorCode_;
	}
}
