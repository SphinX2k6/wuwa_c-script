using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001484 RID: 5252
	[NetMessage(EMessageId.TrapDefenseBuildingLevelUpResponse)]
	public sealed class TrapDefenseBuildingLevelUpResponse : IMessage<TrapDefenseBuildingLevelUpResponse>, IMessage, IEquatable<TrapDefenseBuildingLevelUpResponse>, IDeepCloneable<TrapDefenseBuildingLevelUpResponse>, IBufferMessage
	{
		// Token: 0x0601BE38 RID: 114232 RVA: 0x0040D585 File Offset: 0x0040B785
		[NullableContext(1)]
		public static TrapDefenseBuildingLevelUpResponse Create()
		{
			return new TrapDefenseBuildingLevelUpResponse();
		}

		// Token: 0x17005E6D RID: 24173
		// (get) Token: 0x0601BE39 RID: 114233 RVA: 0x0040D58C File Offset: 0x0040B78C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E6E RID: 24174
		// (get) Token: 0x0601BE3A RID: 114234 RVA: 0x0040D58F File Offset: 0x0040B78F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseBuildingLevelUpResponse.Descriptor;
			}
		}

		// Token: 0x0601BE3B RID: 114235 RVA: 0x0040D596 File Offset: 0x0040B796
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuildingLevelUpResponse()
		{
		}

		// Token: 0x0601BE3C RID: 114236 RVA: 0x0040D59E File Offset: 0x0040B79E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuildingLevelUpResponse(TrapDefenseBuildingLevelUpResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BE3D RID: 114237 RVA: 0x0040D5C3 File Offset: 0x0040B7C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuildingLevelUpResponse Clone()
		{
			return new TrapDefenseBuildingLevelUpResponse(this);
		}

		// Token: 0x17005E6F RID: 24175
		// (get) Token: 0x0601BE3E RID: 114238 RVA: 0x0040D5CB File Offset: 0x0040B7CB
		// (set) Token: 0x0601BE3F RID: 114239 RVA: 0x0040D5D3 File Offset: 0x0040B7D3
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

		// Token: 0x0601BE40 RID: 114240 RVA: 0x0040D5DC File Offset: 0x0040B7DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseBuildingLevelUpResponse);
		}

		// Token: 0x0601BE41 RID: 114241 RVA: 0x0040D5EA File Offset: 0x0040B7EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseBuildingLevelUpResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BE42 RID: 114242 RVA: 0x0040D618 File Offset: 0x0040B818
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

		// Token: 0x0601BE43 RID: 114243 RVA: 0x0040D65D File Offset: 0x0040B85D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BE44 RID: 114244 RVA: 0x0040D66A File Offset: 0x0040B86A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BE45 RID: 114245 RVA: 0x0040D673 File Offset: 0x0040B873
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BE46 RID: 114246 RVA: 0x0040D6A8 File Offset: 0x0040B8A8
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

		// Token: 0x0601BE47 RID: 114247 RVA: 0x0040D6E6 File Offset: 0x0040B8E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseBuildingLevelUpResponse other)
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

		// Token: 0x0601BE48 RID: 114248 RVA: 0x0040D717 File Offset: 0x0040B917
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BE49 RID: 114249 RVA: 0x0040D720 File Offset: 0x0040B920
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A1C8 RID: 41416
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A1C9 RID: 41417
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x0400A1CA RID: 41418
		private ErrorCode errorCode_;
	}
}
