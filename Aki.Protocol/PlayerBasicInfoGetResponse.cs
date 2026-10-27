using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D82 RID: 3458
	[NetMessage(EMessageId.PlayerBasicInfoGetResponse)]
	public sealed class PlayerBasicInfoGetResponse : IMessage<PlayerBasicInfoGetResponse>, IMessage, IEquatable<PlayerBasicInfoGetResponse>, IDeepCloneable<PlayerBasicInfoGetResponse>, IBufferMessage
	{
		// Token: 0x06012A40 RID: 76352 RVA: 0x002B8095 File Offset: 0x002B6295
		[NullableContext(1)]
		public static PlayerBasicInfoGetResponse Create()
		{
			return new PlayerBasicInfoGetResponse();
		}

		// Token: 0x17003DCF RID: 15823
		// (get) Token: 0x06012A41 RID: 76353 RVA: 0x002B809C File Offset: 0x002B629C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003DD0 RID: 15824
		// (get) Token: 0x06012A42 RID: 76354 RVA: 0x002B809F File Offset: 0x002B629F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerBasicInfoGetResponse.Descriptor;
			}
		}

		// Token: 0x06012A43 RID: 76355 RVA: 0x002B80A6 File Offset: 0x002B62A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerBasicInfoGetResponse()
		{
		}

		// Token: 0x06012A44 RID: 76356 RVA: 0x002B80B0 File Offset: 0x002B62B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerBasicInfoGetResponse(PlayerBasicInfoGetResponse other) : this()
		{
			this.info_ = ((other.info_ != null) ? other.info_.Clone() : null);
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012A45 RID: 76357 RVA: 0x002B80FC File Offset: 0x002B62FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerBasicInfoGetResponse Clone()
		{
			return new PlayerBasicInfoGetResponse(this);
		}

		// Token: 0x17003DD1 RID: 15825
		// (get) Token: 0x06012A46 RID: 76358 RVA: 0x002B8104 File Offset: 0x002B6304
		// (set) Token: 0x06012A47 RID: 76359 RVA: 0x002B810C File Offset: 0x002B630C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerDetails Info
		{
			get
			{
				return this.info_;
			}
			set
			{
				this.info_ = value;
			}
		}

		// Token: 0x17003DD2 RID: 15826
		// (get) Token: 0x06012A48 RID: 76360 RVA: 0x002B8115 File Offset: 0x002B6315
		// (set) Token: 0x06012A49 RID: 76361 RVA: 0x002B811D File Offset: 0x002B631D
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

		// Token: 0x06012A4A RID: 76362 RVA: 0x002B8126 File Offset: 0x002B6326
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerBasicInfoGetResponse);
		}

		// Token: 0x06012A4B RID: 76363 RVA: 0x002B8134 File Offset: 0x002B6334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerBasicInfoGetResponse other)
		{
			return other != null && (other == this || (object.Equals(this.Info, other.Info) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012A4C RID: 76364 RVA: 0x002B8184 File Offset: 0x002B6384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.info_ != null)
			{
				num ^= this.Info.GetHashCode();
			}
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

		// Token: 0x06012A4D RID: 76365 RVA: 0x002B81DF File Offset: 0x002B63DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012A4E RID: 76366 RVA: 0x002B81EC File Offset: 0x002B63EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012A4F RID: 76367 RVA: 0x002B81F8 File Offset: 0x002B63F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.info_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.Info);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012A50 RID: 76368 RVA: 0x002B8254 File Offset: 0x002B6454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.info_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Info);
			}
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

		// Token: 0x06012A51 RID: 76369 RVA: 0x002B82AC File Offset: 0x002B64AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerBasicInfoGetResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.info_ != null)
			{
				if (this.info_ == null)
				{
					this.Info = new PlayerDetails();
				}
				this.Info.MergeFrom(other.Info);
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012A52 RID: 76370 RVA: 0x002B8314 File Offset: 0x002B6514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012A53 RID: 76371 RVA: 0x002B8320 File Offset: 0x002B6520
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
				if (num != 82U)
				{
					if (num != 120U)
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
					if (this.info_ == null)
					{
						this.Info = new PlayerDetails();
					}
					input.ReadMessage(this.Info);
				}
			}
		}

		// Token: 0x040073A3 RID: 29603
		private UnknownFieldSet _unknownFields;

		// Token: 0x040073A4 RID: 29604
		public const int InfoFieldNumber = 10;

		// Token: 0x040073A5 RID: 29605
		private PlayerDetails info_;

		// Token: 0x040073A6 RID: 29606
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x040073A7 RID: 29607
		private ErrorCode errorCode_;
	}
}
