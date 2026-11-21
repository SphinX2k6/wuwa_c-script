using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D0F RID: 3343
	[NetMessage(EMessageId.PhBaPlanSetPlanStatusRequest)]
	public sealed class PhBaPlanSetPlanStatusRequest : IMessage<PhBaPlanSetPlanStatusRequest>, IMessage, IEquatable<PhBaPlanSetPlanStatusRequest>, IDeepCloneable<PhBaPlanSetPlanStatusRequest>, IBufferMessage
	{
		// Token: 0x06012145 RID: 74053 RVA: 0x002A49C1 File Offset: 0x002A2BC1
		[NullableContext(1)]
		public static PhBaPlanSetPlanStatusRequest Create()
		{
			return new PhBaPlanSetPlanStatusRequest();
		}

		// Token: 0x17003BE5 RID: 15333
		// (get) Token: 0x06012146 RID: 74054 RVA: 0x002A49C8 File Offset: 0x002A2BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003BE6 RID: 15334
		// (get) Token: 0x06012147 RID: 74055 RVA: 0x002A49CB File Offset: 0x002A2BCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhBaPlanSetPlanStatusRequest.Descriptor;
			}
		}

		// Token: 0x06012148 RID: 74056 RVA: 0x002A49D2 File Offset: 0x002A2BD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanSetPlanStatusRequest()
		{
		}

		// Token: 0x06012149 RID: 74057 RVA: 0x002A49E5 File Offset: 0x002A2BE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanSetPlanStatusRequest(PhBaPlanSetPlanStatusRequest other) : this()
		{
			this.setInfo_ = other.setInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601214A RID: 74058 RVA: 0x002A4A0F File Offset: 0x002A2C0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanSetPlanStatusRequest Clone()
		{
			return new PhBaPlanSetPlanStatusRequest(this);
		}

		// Token: 0x17003BE7 RID: 15335
		// (get) Token: 0x0601214B RID: 74059 RVA: 0x002A4A17 File Offset: 0x002A2C17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhBaPlanSetStatusInfo> SetInfo
		{
			get
			{
				return this.setInfo_;
			}
		}

		// Token: 0x0601214C RID: 74060 RVA: 0x002A4A1F File Offset: 0x002A2C1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhBaPlanSetPlanStatusRequest);
		}

		// Token: 0x0601214D RID: 74061 RVA: 0x002A4A2D File Offset: 0x002A2C2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhBaPlanSetPlanStatusRequest other)
		{
			return other != null && (other == this || (this.setInfo_.Equals(other.setInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601214E RID: 74062 RVA: 0x002A4A60 File Offset: 0x002A2C60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.setInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601214F RID: 74063 RVA: 0x002A4A94 File Offset: 0x002A2C94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012150 RID: 74064 RVA: 0x002A4AA1 File Offset: 0x002A2CA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012151 RID: 74065 RVA: 0x002A4AAA File Offset: 0x002A2CAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.setInfo_.WriteTo(ref output, PhBaPlanSetPlanStatusRequest._repeated_setInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012152 RID: 74066 RVA: 0x002A4AD4 File Offset: 0x002A2CD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.setInfo_.CalculateSize(PhBaPlanSetPlanStatusRequest._repeated_setInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012153 RID: 74067 RVA: 0x002A4B0D File Offset: 0x002A2D0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhBaPlanSetPlanStatusRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.setInfo_.Add(other.setInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012154 RID: 74068 RVA: 0x002A4B3B File Offset: 0x002A2D3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012155 RID: 74069 RVA: 0x002A4B44 File Offset: 0x002A2D44
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.setInfo_.AddEntriesFrom(ref input, PhBaPlanSetPlanStatusRequest._repeated_setInfo_codec);
				}
			}
		}

		// Token: 0x04007176 RID: 29046
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007177 RID: 29047
		public const int SetInfoFieldNumber = 3;

		// Token: 0x04007178 RID: 29048
		private static readonly FieldCodec<PhBaPlanSetStatusInfo> _repeated_setInfo_codec = FieldCodec.ForMessage<PhBaPlanSetStatusInfo>(26U, PhBaPlanSetStatusInfo.Parser);

		// Token: 0x04007179 RID: 29049
		private readonly RepeatedField<PhBaPlanSetStatusInfo> setInfo_ = new RepeatedField<PhBaPlanSetStatusInfo>();
	}
}
