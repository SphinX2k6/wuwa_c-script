using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000871 RID: 2161
	[NetMessage(EMessageId.KickWorldTeamResponse)]
	public sealed class KickWorldTeamResponse : IMessage<KickWorldTeamResponse>, IMessage, IEquatable<KickWorldTeamResponse>, IDeepCloneable<KickWorldTeamResponse>, IBufferMessage
	{
		// Token: 0x0600C0C0 RID: 49344 RVA: 0x001CA3C1 File Offset: 0x001C85C1
		[NullableContext(1)]
		public static KickWorldTeamResponse Create()
		{
			return new KickWorldTeamResponse();
		}

		// Token: 0x170026F0 RID: 9968
		// (get) Token: 0x0600C0C1 RID: 49345 RVA: 0x001CA3C8 File Offset: 0x001C85C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170026F1 RID: 9969
		// (get) Token: 0x0600C0C2 RID: 49346 RVA: 0x001CA3CB File Offset: 0x001C85CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KickWorldTeamResponse.Descriptor;
			}
		}

		// Token: 0x0600C0C3 RID: 49347 RVA: 0x001CA3D2 File Offset: 0x001C85D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KickWorldTeamResponse()
		{
		}

		// Token: 0x0600C0C4 RID: 49348 RVA: 0x001CA3DA File Offset: 0x001C85DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KickWorldTeamResponse(KickWorldTeamResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C0C5 RID: 49349 RVA: 0x001CA3FF File Offset: 0x001C85FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KickWorldTeamResponse Clone()
		{
			return new KickWorldTeamResponse(this);
		}

		// Token: 0x170026F2 RID: 9970
		// (get) Token: 0x0600C0C6 RID: 49350 RVA: 0x001CA407 File Offset: 0x001C8607
		// (set) Token: 0x0600C0C7 RID: 49351 RVA: 0x001CA40F File Offset: 0x001C860F
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

		// Token: 0x0600C0C8 RID: 49352 RVA: 0x001CA418 File Offset: 0x001C8618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KickWorldTeamResponse);
		}

		// Token: 0x0600C0C9 RID: 49353 RVA: 0x001CA426 File Offset: 0x001C8626
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KickWorldTeamResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C0CA RID: 49354 RVA: 0x001CA454 File Offset: 0x001C8654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0600C0CB RID: 49355 RVA: 0x001CA499 File Offset: 0x001C8699
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C0CC RID: 49356 RVA: 0x001CA4A6 File Offset: 0x001C86A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C0CD RID: 49357 RVA: 0x001CA4AF File Offset: 0x001C86AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C0CE RID: 49358 RVA: 0x001CA4E4 File Offset: 0x001C86E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0600C0CF RID: 49359 RVA: 0x001CA522 File Offset: 0x001C8722
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KickWorldTeamResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C0D0 RID: 49360 RVA: 0x001CA553 File Offset: 0x001C8753
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C0D1 RID: 49361 RVA: 0x001CA55C File Offset: 0x001C875C
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400540A RID: 21514
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400540B RID: 21515
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x0400540C RID: 21516
		private ErrorCode errorCode_;
	}
}
