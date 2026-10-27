using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000630 RID: 1584
	[NetMessage(EMessageId.FormationResponse)]
	public sealed class FormationResponse : IMessage<FormationResponse>, IMessage, IEquatable<FormationResponse>, IDeepCloneable<FormationResponse>, IBufferMessage
	{
		// Token: 0x060091FF RID: 37375 RVA: 0x001612A2 File Offset: 0x0015F4A2
		[NullableContext(1)]
		public static FormationResponse Create()
		{
			return new FormationResponse();
		}

		// Token: 0x17001D06 RID: 7430
		// (get) Token: 0x06009200 RID: 37376 RVA: 0x001612A9 File Offset: 0x0015F4A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D07 RID: 7431
		// (get) Token: 0x06009201 RID: 37377 RVA: 0x001612AC File Offset: 0x0015F4AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FormationResponse.Descriptor;
			}
		}

		// Token: 0x06009202 RID: 37378 RVA: 0x001612B3 File Offset: 0x0015F4B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationResponse()
		{
		}

		// Token: 0x06009203 RID: 37379 RVA: 0x001612C6 File Offset: 0x0015F4C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationResponse(FormationResponse other) : this()
		{
			this.formation_ = other.formation_.Clone();
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009204 RID: 37380 RVA: 0x001612FC File Offset: 0x0015F4FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationResponse Clone()
		{
			return new FormationResponse(this);
		}

		// Token: 0x17001D08 RID: 7432
		// (get) Token: 0x06009205 RID: 37381 RVA: 0x00161304 File Offset: 0x0015F504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Formation> Formation
		{
			get
			{
				return this.formation_;
			}
		}

		// Token: 0x17001D09 RID: 7433
		// (get) Token: 0x06009206 RID: 37382 RVA: 0x0016130C File Offset: 0x0015F50C
		// (set) Token: 0x06009207 RID: 37383 RVA: 0x00161314 File Offset: 0x0015F514
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

		// Token: 0x06009208 RID: 37384 RVA: 0x0016131D File Offset: 0x0015F51D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FormationResponse);
		}

		// Token: 0x06009209 RID: 37385 RVA: 0x0016132C File Offset: 0x0015F52C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FormationResponse other)
		{
			return other != null && (other == this || (this.formation_.Equals(other.formation_) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600920A RID: 37386 RVA: 0x0016137C File Offset: 0x0015F57C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.formation_.GetHashCode();
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

		// Token: 0x0600920B RID: 37387 RVA: 0x001613CF File Offset: 0x0015F5CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600920C RID: 37388 RVA: 0x001613DC File Offset: 0x0015F5DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600920D RID: 37389 RVA: 0x001613E8 File Offset: 0x0015F5E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.formation_.WriteTo(ref output, FormationResponse._repeated_formation_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600920E RID: 37390 RVA: 0x00161438 File Offset: 0x0015F638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.formation_.CalculateSize(FormationResponse._repeated_formation_codec);
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

		// Token: 0x0600920F RID: 37391 RVA: 0x0016148C File Offset: 0x0015F68C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FormationResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.formation_.Add(other.formation_);
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009210 RID: 37392 RVA: 0x001614D9 File Offset: 0x0015F6D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009211 RID: 37393 RVA: 0x001614E4 File Offset: 0x0015F6E4
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
				if (num != 56U)
				{
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.formation_.AddEntriesFrom(ref input, FormationResponse._repeated_formation_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400466D RID: 18029
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400466E RID: 18030
		public const int FormationFieldNumber = 15;

		// Token: 0x0400466F RID: 18031
		private static readonly FieldCodec<Formation> _repeated_formation_codec = FieldCodec.ForMessage<Formation>(122U, Aki.Protocol.Formation.Parser);

		// Token: 0x04004670 RID: 18032
		private readonly RepeatedField<Formation> formation_ = new RepeatedField<Formation>();

		// Token: 0x04004671 RID: 18033
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04004672 RID: 18034
		private ErrorCode errorCode_;
	}
}
