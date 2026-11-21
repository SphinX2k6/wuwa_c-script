using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F29 RID: 3881
	[NetMessage(EMessageId.RhythmChangePartnerRoleResponse)]
	public sealed class RhythmChangePartnerRoleResponse : IMessage<RhythmChangePartnerRoleResponse>, IMessage, IEquatable<RhythmChangePartnerRoleResponse>, IDeepCloneable<RhythmChangePartnerRoleResponse>, IBufferMessage
	{
		// Token: 0x06014CC3 RID: 85187 RVA: 0x0030523D File Offset: 0x0030343D
		[NullableContext(1)]
		public static RhythmChangePartnerRoleResponse Create()
		{
			return new RhythmChangePartnerRoleResponse();
		}

		// Token: 0x1700452D RID: 17709
		// (get) Token: 0x06014CC4 RID: 85188 RVA: 0x00305244 File Offset: 0x00303444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700452E RID: 17710
		// (get) Token: 0x06014CC5 RID: 85189 RVA: 0x00305247 File Offset: 0x00303447
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RhythmChangePartnerRoleResponse.Descriptor;
			}
		}

		// Token: 0x06014CC6 RID: 85190 RVA: 0x0030524E File Offset: 0x0030344E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmChangePartnerRoleResponse()
		{
		}

		// Token: 0x06014CC7 RID: 85191 RVA: 0x00305256 File Offset: 0x00303456
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmChangePartnerRoleResponse(RhythmChangePartnerRoleResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014CC8 RID: 85192 RVA: 0x0030527B File Offset: 0x0030347B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmChangePartnerRoleResponse Clone()
		{
			return new RhythmChangePartnerRoleResponse(this);
		}

		// Token: 0x1700452F RID: 17711
		// (get) Token: 0x06014CC9 RID: 85193 RVA: 0x00305283 File Offset: 0x00303483
		// (set) Token: 0x06014CCA RID: 85194 RVA: 0x0030528B File Offset: 0x0030348B
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

		// Token: 0x06014CCB RID: 85195 RVA: 0x00305294 File Offset: 0x00303494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RhythmChangePartnerRoleResponse);
		}

		// Token: 0x06014CCC RID: 85196 RVA: 0x003052A2 File Offset: 0x003034A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RhythmChangePartnerRoleResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014CCD RID: 85197 RVA: 0x003052D0 File Offset: 0x003034D0
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

		// Token: 0x06014CCE RID: 85198 RVA: 0x00305315 File Offset: 0x00303515
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014CCF RID: 85199 RVA: 0x00305322 File Offset: 0x00303522
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014CD0 RID: 85200 RVA: 0x0030532B File Offset: 0x0030352B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014CD1 RID: 85201 RVA: 0x00305360 File Offset: 0x00303560
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

		// Token: 0x06014CD2 RID: 85202 RVA: 0x0030539E File Offset: 0x0030359E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RhythmChangePartnerRoleResponse other)
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

		// Token: 0x06014CD3 RID: 85203 RVA: 0x003053CF File Offset: 0x003035CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014CD4 RID: 85204 RVA: 0x003053D8 File Offset: 0x003035D8
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007E00 RID: 32256
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007E01 RID: 32257
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04007E02 RID: 32258
		private ErrorCode errorCode_;
	}
}
