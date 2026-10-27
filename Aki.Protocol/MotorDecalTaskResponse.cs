using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A2E RID: 2606
	[NetMessage(EMessageId.MotorDecalTaskResponse)]
	public sealed class MotorDecalTaskResponse : IMessage<MotorDecalTaskResponse>, IMessage, IEquatable<MotorDecalTaskResponse>, IDeepCloneable<MotorDecalTaskResponse>, IBufferMessage
	{
		// Token: 0x0600E3AC RID: 58284 RVA: 0x00214EDD File Offset: 0x002130DD
		[NullableContext(1)]
		public static MotorDecalTaskResponse Create()
		{
			return new MotorDecalTaskResponse();
		}

		// Token: 0x17002E27 RID: 11815
		// (get) Token: 0x0600E3AD RID: 58285 RVA: 0x00214EE4 File Offset: 0x002130E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E28 RID: 11816
		// (get) Token: 0x0600E3AE RID: 58286 RVA: 0x00214EE7 File Offset: 0x002130E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorDecalTaskResponse.Descriptor;
			}
		}

		// Token: 0x0600E3AF RID: 58287 RVA: 0x00214EEE File Offset: 0x002130EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDecalTaskResponse()
		{
		}

		// Token: 0x0600E3B0 RID: 58288 RVA: 0x00214F01 File Offset: 0x00213101
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDecalTaskResponse(MotorDecalTaskResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.ids_ = other.ids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E3B1 RID: 58289 RVA: 0x00214F37 File Offset: 0x00213137
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDecalTaskResponse Clone()
		{
			return new MotorDecalTaskResponse(this);
		}

		// Token: 0x17002E29 RID: 11817
		// (get) Token: 0x0600E3B2 RID: 58290 RVA: 0x00214F3F File Offset: 0x0021313F
		// (set) Token: 0x0600E3B3 RID: 58291 RVA: 0x00214F47 File Offset: 0x00213147
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

		// Token: 0x17002E2A RID: 11818
		// (get) Token: 0x0600E3B4 RID: 58292 RVA: 0x00214F50 File Offset: 0x00213150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x0600E3B5 RID: 58293 RVA: 0x00214F58 File Offset: 0x00213158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorDecalTaskResponse);
		}

		// Token: 0x0600E3B6 RID: 58294 RVA: 0x00214F68 File Offset: 0x00213168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorDecalTaskResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.ids_.Equals(other.ids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E3B7 RID: 58295 RVA: 0x00214FB8 File Offset: 0x002131B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.ids_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E3B8 RID: 58296 RVA: 0x0021500B File Offset: 0x0021320B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E3B9 RID: 58297 RVA: 0x00215018 File Offset: 0x00213218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E3BA RID: 58298 RVA: 0x00215024 File Offset: 0x00213224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.ids_.WriteTo(ref output, MotorDecalTaskResponse._repeated_ids_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E3BB RID: 58299 RVA: 0x00215074 File Offset: 0x00213274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.ids_.CalculateSize(MotorDecalTaskResponse._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E3BC RID: 58300 RVA: 0x002150C8 File Offset: 0x002132C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorDecalTaskResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.ids_.Add(other.ids_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E3BD RID: 58301 RVA: 0x00215115 File Offset: 0x00213315
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E3BE RID: 58302 RVA: 0x00215120 File Offset: 0x00213320
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
				if (num != 88U && num != 90U)
				{
					if (num != 104U)
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
					this.ids_.AddEntriesFrom(ref input, MotorDecalTaskResponse._repeated_ids_codec);
				}
			}
		}

		// Token: 0x04005D3E RID: 23870
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005D3F RID: 23871
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04005D40 RID: 23872
		private ErrorCode errorCode_;

		// Token: 0x04005D41 RID: 23873
		public const int IdsFieldNumber = 11;

		// Token: 0x04005D42 RID: 23874
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(90U);

		// Token: 0x04005D43 RID: 23875
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();
	}
}
