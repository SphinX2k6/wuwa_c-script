using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013A7 RID: 5031
	[NetMessage(EMessageId.TeleportDataResponse)]
	public sealed class TeleportDataResponse : IMessage<TeleportDataResponse>, IMessage, IEquatable<TeleportDataResponse>, IDeepCloneable<TeleportDataResponse>, IBufferMessage
	{
		// Token: 0x0601AC64 RID: 109668 RVA: 0x003E612E File Offset: 0x003E432E
		[NullableContext(1)]
		public static TeleportDataResponse Create()
		{
			return new TeleportDataResponse();
		}

		// Token: 0x17005AA5 RID: 23205
		// (get) Token: 0x0601AC65 RID: 109669 RVA: 0x003E6135 File Offset: 0x003E4335
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005AA6 RID: 23206
		// (get) Token: 0x0601AC66 RID: 109670 RVA: 0x003E6138 File Offset: 0x003E4338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeleportDataResponse.Descriptor;
			}
		}

		// Token: 0x0601AC67 RID: 109671 RVA: 0x003E613F File Offset: 0x003E433F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportDataResponse()
		{
		}

		// Token: 0x0601AC68 RID: 109672 RVA: 0x003E6152 File Offset: 0x003E4352
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportDataResponse(TeleportDataResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this.ids_ = other.ids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AC69 RID: 109673 RVA: 0x003E6188 File Offset: 0x003E4388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportDataResponse Clone()
		{
			return new TeleportDataResponse(this);
		}

		// Token: 0x17005AA7 RID: 23207
		// (get) Token: 0x0601AC6A RID: 109674 RVA: 0x003E6190 File Offset: 0x003E4390
		// (set) Token: 0x0601AC6B RID: 109675 RVA: 0x003E6198 File Offset: 0x003E4398
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

		// Token: 0x17005AA8 RID: 23208
		// (get) Token: 0x0601AC6C RID: 109676 RVA: 0x003E61A1 File Offset: 0x003E43A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x0601AC6D RID: 109677 RVA: 0x003E61A9 File Offset: 0x003E43A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeleportDataResponse);
		}

		// Token: 0x0601AC6E RID: 109678 RVA: 0x003E61B8 File Offset: 0x003E43B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeleportDataResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && this.ids_.Equals(other.ids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AC6F RID: 109679 RVA: 0x003E6208 File Offset: 0x003E4408
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

		// Token: 0x0601AC70 RID: 109680 RVA: 0x003E625B File Offset: 0x003E445B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AC71 RID: 109681 RVA: 0x003E6268 File Offset: 0x003E4468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AC72 RID: 109682 RVA: 0x003E6274 File Offset: 0x003E4474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.ids_.WriteTo(ref output, TeleportDataResponse._repeated_ids_codec);
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AC73 RID: 109683 RVA: 0x003E62C4 File Offset: 0x003E44C4
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

		// Token: 0x0601AC74 RID: 109684 RVA: 0x003E6318 File Offset: 0x003E4518
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

		// Token: 0x0601AC75 RID: 109685 RVA: 0x003E6365 File Offset: 0x003E4565
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AC76 RID: 109686 RVA: 0x003E6370 File Offset: 0x003E4570
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
				if (num != 24U && num != 26U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.ids_.AddEntriesFrom(ref input, TeleportDataResponse._repeated_ids_codec);
				}
			}
		}

		// Token: 0x04009CAB RID: 40107
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009CAC RID: 40108
		public const int ErrCodeFieldNumber = 10;

		// Token: 0x04009CAD RID: 40109
		private ErrorCode errCode_;

		// Token: 0x04009CAE RID: 40110
		public const int IdsFieldNumber = 3;

		// Token: 0x04009CAF RID: 40111
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04009CB0 RID: 40112
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();
	}
}
