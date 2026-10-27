using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001334 RID: 4916
	[NetMessage(EMessageId.TeleportDataResponse)]
	public sealed class TeleportDataResponse : IMessage<TeleportDataResponse>, IMessage, IEquatable<TeleportDataResponse>, IDeepCloneable<TeleportDataResponse>, IBufferMessage
	{
		// Token: 0x0601A1DD RID: 106973 RVA: 0x003CAFF6 File Offset: 0x003C91F6
		[NullableContext(1)]
		public static TeleportDataResponse Create()
		{
			return new TeleportDataResponse();
		}

		// Token: 0x17005812 RID: 22546
		// (get) Token: 0x0601A1DE RID: 106974 RVA: 0x003CAFFD File Offset: 0x003C91FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005813 RID: 22547
		// (get) Token: 0x0601A1DF RID: 106975 RVA: 0x003CB000 File Offset: 0x003C9200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeleportDataResponse.Descriptor;
			}
		}

		// Token: 0x0601A1E0 RID: 106976 RVA: 0x003CB007 File Offset: 0x003C9207
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportDataResponse()
		{
		}

		// Token: 0x0601A1E1 RID: 106977 RVA: 0x003CB01A File Offset: 0x003C921A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportDataResponse(TeleportDataResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this.ids_ = other.ids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A1E2 RID: 106978 RVA: 0x003CB050 File Offset: 0x003C9250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportDataResponse Clone()
		{
			return new TeleportDataResponse(this);
		}

		// Token: 0x17005814 RID: 22548
		// (get) Token: 0x0601A1E3 RID: 106979 RVA: 0x003CB058 File Offset: 0x003C9258
		// (set) Token: 0x0601A1E4 RID: 106980 RVA: 0x003CB060 File Offset: 0x003C9260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x17005815 RID: 22549
		// (get) Token: 0x0601A1E5 RID: 106981 RVA: 0x003CB069 File Offset: 0x003C9269
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x0601A1E6 RID: 106982 RVA: 0x003CB071 File Offset: 0x003C9271
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeleportDataResponse);
		}

		// Token: 0x0601A1E7 RID: 106983 RVA: 0x003CB080 File Offset: 0x003C9280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeleportDataResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && this.ids_.Equals(other.ids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A1E8 RID: 106984 RVA: 0x003CB0D0 File Offset: 0x003C92D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			num ^= this.ids_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A1E9 RID: 106985 RVA: 0x003CB123 File Offset: 0x003C9323
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A1EA RID: 106986 RVA: 0x003CB130 File Offset: 0x003C9330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A1EB RID: 106987 RVA: 0x003CB13C File Offset: 0x003C933C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrCode);
			}
			this.ids_.WriteTo(ref output, TeleportDataResponse._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A1EC RID: 106988 RVA: 0x003CB18C File Offset: 0x003C938C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			num += this.ids_.CalculateSize(TeleportDataResponse._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A1ED RID: 106989 RVA: 0x003CB1E0 File Offset: 0x003C93E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TeleportDataResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			this.ids_.Add(other.ids_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A1EE RID: 106990 RVA: 0x003CB22D File Offset: 0x003C942D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A1EF RID: 106991 RVA: 0x003CB238 File Offset: 0x003C9438
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
				if (num != 40U)
				{
					if (num != 56U && num != 58U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ids_.AddEntriesFrom(ref input, TeleportDataResponse._repeated_ids_codec);
					}
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009869 RID: 39017
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400986A RID: 39018
		public const int ErrCodeFieldNumber = 5;

		// Token: 0x0400986B RID: 39019
		private ErrorCode errCode_;

		// Token: 0x0400986C RID: 39020
		public const int IdsFieldNumber = 7;

		// Token: 0x0400986D RID: 39021
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(58U);

		// Token: 0x0400986E RID: 39022
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();
	}
}
