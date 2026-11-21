using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000569 RID: 1385
	[NetMessage(EMessageId.FishingShipFixResponse)]
	public sealed class FishingShipFixResponse : IMessage<FishingShipFixResponse>, IMessage, IEquatable<FishingShipFixResponse>, IDeepCloneable<FishingShipFixResponse>, IBufferMessage
	{
		// Token: 0x06008136 RID: 33078 RVA: 0x001383A2 File Offset: 0x001365A2
		[NullableContext(1)]
		public static FishingShipFixResponse Create()
		{
			return new FishingShipFixResponse();
		}

		// Token: 0x17001927 RID: 6439
		// (get) Token: 0x06008137 RID: 33079 RVA: 0x001383A9 File Offset: 0x001365A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001928 RID: 6440
		// (get) Token: 0x06008138 RID: 33080 RVA: 0x001383AC File Offset: 0x001365AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingShipFixResponse.Descriptor;
			}
		}

		// Token: 0x06008139 RID: 33081 RVA: 0x001383B3 File Offset: 0x001365B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingShipFixResponse()
		{
		}

		// Token: 0x0600813A RID: 33082 RVA: 0x001383BB File Offset: 0x001365BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingShipFixResponse(FishingShipFixResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600813B RID: 33083 RVA: 0x001383E0 File Offset: 0x001365E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingShipFixResponse Clone()
		{
			return new FishingShipFixResponse(this);
		}

		// Token: 0x17001929 RID: 6441
		// (get) Token: 0x0600813C RID: 33084 RVA: 0x001383E8 File Offset: 0x001365E8
		// (set) Token: 0x0600813D RID: 33085 RVA: 0x001383F0 File Offset: 0x001365F0
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

		// Token: 0x0600813E RID: 33086 RVA: 0x001383F9 File Offset: 0x001365F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingShipFixResponse);
		}

		// Token: 0x0600813F RID: 33087 RVA: 0x00138407 File Offset: 0x00136607
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingShipFixResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008140 RID: 33088 RVA: 0x00138438 File Offset: 0x00136638
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

		// Token: 0x06008141 RID: 33089 RVA: 0x0013847D File Offset: 0x0013667D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008142 RID: 33090 RVA: 0x0013848A File Offset: 0x0013668A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008143 RID: 33091 RVA: 0x00138493 File Offset: 0x00136693
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008144 RID: 33092 RVA: 0x001384C8 File Offset: 0x001366C8
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

		// Token: 0x06008145 RID: 33093 RVA: 0x00138506 File Offset: 0x00136706
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingShipFixResponse other)
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

		// Token: 0x06008146 RID: 33094 RVA: 0x00138537 File Offset: 0x00136737
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008147 RID: 33095 RVA: 0x00138540 File Offset: 0x00136740
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400413D RID: 16701
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400413E RID: 16702
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x0400413F RID: 16703
		private ErrorCode errorCode_;
	}
}
