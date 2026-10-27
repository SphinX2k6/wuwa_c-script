using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001127 RID: 4391
	[NetMessage(EMessageId.RoverRogueShopRefreshResponse)]
	public sealed class RoverRogueShopRefreshResponse : IMessage<RoverRogueShopRefreshResponse>, IMessage, IEquatable<RoverRogueShopRefreshResponse>, IDeepCloneable<RoverRogueShopRefreshResponse>, IBufferMessage
	{
		// Token: 0x060176CA RID: 95946 RVA: 0x003670B5 File Offset: 0x003652B5
		[NullableContext(1)]
		public static RoverRogueShopRefreshResponse Create()
		{
			return new RoverRogueShopRefreshResponse();
		}

		// Token: 0x17004E9F RID: 20127
		// (get) Token: 0x060176CB RID: 95947 RVA: 0x003670BC File Offset: 0x003652BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004EA0 RID: 20128
		// (get) Token: 0x060176CC RID: 95948 RVA: 0x003670BF File Offset: 0x003652BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueShopRefreshResponse.Descriptor;
			}
		}

		// Token: 0x060176CD RID: 95949 RVA: 0x003670C6 File Offset: 0x003652C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueShopRefreshResponse()
		{
		}

		// Token: 0x060176CE RID: 95950 RVA: 0x003670D0 File Offset: 0x003652D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueShopRefreshResponse(RoverRogueShopRefreshResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.snapshot_ = ((other.snapshot_ != null) ? other.snapshot_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060176CF RID: 95951 RVA: 0x0036711C File Offset: 0x0036531C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueShopRefreshResponse Clone()
		{
			return new RoverRogueShopRefreshResponse(this);
		}

		// Token: 0x17004EA1 RID: 20129
		// (get) Token: 0x060176D0 RID: 95952 RVA: 0x00367124 File Offset: 0x00365324
		// (set) Token: 0x060176D1 RID: 95953 RVA: 0x0036712C File Offset: 0x0036532C
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

		// Token: 0x17004EA2 RID: 20130
		// (get) Token: 0x060176D2 RID: 95954 RVA: 0x00367135 File Offset: 0x00365335
		// (set) Token: 0x060176D3 RID: 95955 RVA: 0x0036713D File Offset: 0x0036533D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueShopSnapshot Snapshot
		{
			get
			{
				return this.snapshot_;
			}
			set
			{
				this.snapshot_ = value;
			}
		}

		// Token: 0x060176D4 RID: 95956 RVA: 0x00367146 File Offset: 0x00365346
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueShopRefreshResponse);
		}

		// Token: 0x060176D5 RID: 95957 RVA: 0x00367154 File Offset: 0x00365354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueShopRefreshResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.Snapshot, other.Snapshot) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060176D6 RID: 95958 RVA: 0x003671A4 File Offset: 0x003653A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.snapshot_ != null)
			{
				num ^= this.Snapshot.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060176D7 RID: 95959 RVA: 0x003671FF File Offset: 0x003653FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060176D8 RID: 95960 RVA: 0x0036720C File Offset: 0x0036540C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060176D9 RID: 95961 RVA: 0x00367218 File Offset: 0x00365418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.snapshot_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.Snapshot);
			}
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

		// Token: 0x060176DA RID: 95962 RVA: 0x00367274 File Offset: 0x00365474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.snapshot_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Snapshot);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060176DB RID: 95963 RVA: 0x003672CC File Offset: 0x003654CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueShopRefreshResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.snapshot_ != null)
			{
				if (this.snapshot_ == null)
				{
					this.Snapshot = new RoverRogueShopSnapshot();
				}
				this.Snapshot.MergeFrom(other.Snapshot);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060176DC RID: 95964 RVA: 0x00367334 File Offset: 0x00365534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060176DD RID: 95965 RVA: 0x00367340 File Offset: 0x00365540
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
				if (num != 50U)
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
					if (this.snapshot_ == null)
					{
						this.Snapshot = new RoverRogueShopSnapshot();
					}
					input.ReadMessage(this.Snapshot);
				}
			}
		}

		// Token: 0x04008B50 RID: 35664
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008B51 RID: 35665
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04008B52 RID: 35666
		private ErrorCode errorCode_;

		// Token: 0x04008B53 RID: 35667
		public const int SnapshotFieldNumber = 6;

		// Token: 0x04008B54 RID: 35668
		private RoverRogueShopSnapshot snapshot_;
	}
}
