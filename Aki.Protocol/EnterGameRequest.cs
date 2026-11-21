using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200043B RID: 1083
	[NetMessage(EMessageId.EnterGameRequest)]
	public sealed class EnterGameRequest : IMessage<EnterGameRequest>, IMessage, IEquatable<EnterGameRequest>, IDeepCloneable<EnterGameRequest>, IBufferMessage
	{
		// Token: 0x060067FF RID: 26623 RVA: 0x000FA019 File Offset: 0x000F8219
		[NullableContext(1)]
		public static EnterGameRequest Create()
		{
			return new EnterGameRequest();
		}

		// Token: 0x1700138D RID: 5005
		// (get) Token: 0x06006800 RID: 26624 RVA: 0x000FA020 File Offset: 0x000F8220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700138E RID: 5006
		// (get) Token: 0x06006801 RID: 26625 RVA: 0x000FA023 File Offset: 0x000F8223
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterGameRequest.Descriptor;
			}
		}

		// Token: 0x06006802 RID: 26626 RVA: 0x000FA02A File Offset: 0x000F822A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterGameRequest()
		{
		}

		// Token: 0x06006803 RID: 26627 RVA: 0x000FA034 File Offset: 0x000F8234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterGameRequest(EnterGameRequest other) : this()
		{
			this.singleInstanceId_ = other.singleInstanceId_;
			this.multiInstanceId_ = other.multiInstanceId_;
			this.mode_ = other.mode_;
			this.pos_ = ((other.pos_ != null) ? other.pos_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006804 RID: 26628 RVA: 0x000FA098 File Offset: 0x000F8298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterGameRequest Clone()
		{
			return new EnterGameRequest(this);
		}

		// Token: 0x1700138F RID: 5007
		// (get) Token: 0x06006805 RID: 26629 RVA: 0x000FA0A0 File Offset: 0x000F82A0
		// (set) Token: 0x06006806 RID: 26630 RVA: 0x000FA0A8 File Offset: 0x000F82A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SingleInstanceId
		{
			get
			{
				return this.singleInstanceId_;
			}
			set
			{
				this.singleInstanceId_ = value;
			}
		}

		// Token: 0x17001390 RID: 5008
		// (get) Token: 0x06006807 RID: 26631 RVA: 0x000FA0B1 File Offset: 0x000F82B1
		// (set) Token: 0x06006808 RID: 26632 RVA: 0x000FA0B9 File Offset: 0x000F82B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MultiInstanceId
		{
			get
			{
				return this.multiInstanceId_;
			}
			set
			{
				this.multiInstanceId_ = value;
			}
		}

		// Token: 0x17001391 RID: 5009
		// (get) Token: 0x06006809 RID: 26633 RVA: 0x000FA0C2 File Offset: 0x000F82C2
		// (set) Token: 0x0600680A RID: 26634 RVA: 0x000FA0CA File Offset: 0x000F82CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Mode
		{
			get
			{
				return this.mode_;
			}
			set
			{
				this.mode_ = value;
			}
		}

		// Token: 0x17001392 RID: 5010
		// (get) Token: 0x0600680B RID: 26635 RVA: 0x000FA0D3 File Offset: 0x000F82D3
		// (set) Token: 0x0600680C RID: 26636 RVA: 0x000FA0DB File Offset: 0x000F82DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector Pos
		{
			get
			{
				return this.pos_;
			}
			set
			{
				this.pos_ = value;
			}
		}

		// Token: 0x0600680D RID: 26637 RVA: 0x000FA0E4 File Offset: 0x000F82E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterGameRequest);
		}

		// Token: 0x0600680E RID: 26638 RVA: 0x000FA0F4 File Offset: 0x000F82F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterGameRequest other)
		{
			return other != null && (other == this || (this.SingleInstanceId == other.SingleInstanceId && this.MultiInstanceId == other.MultiInstanceId && this.Mode == other.Mode && object.Equals(this.Pos, other.Pos) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600680F RID: 26639 RVA: 0x000FA164 File Offset: 0x000F8364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SingleInstanceId != 0)
			{
				num ^= this.SingleInstanceId.GetHashCode();
			}
			if (this.MultiInstanceId != 0)
			{
				num ^= this.MultiInstanceId.GetHashCode();
			}
			if (this.Mode != 0)
			{
				num ^= this.Mode.GetHashCode();
			}
			if (this.pos_ != null)
			{
				num ^= this.Pos.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006810 RID: 26640 RVA: 0x000FA1EB File Offset: 0x000F83EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006811 RID: 26641 RVA: 0x000FA1F8 File Offset: 0x000F83F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006812 RID: 26642 RVA: 0x000FA204 File Offset: 0x000F8404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SingleInstanceId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SingleInstanceId);
			}
			if (this.MultiInstanceId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.MultiInstanceId);
			}
			if (this.Mode != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Mode);
			}
			if (this.pos_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Pos);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006813 RID: 26643 RVA: 0x000FA294 File Offset: 0x000F8494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SingleInstanceId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SingleInstanceId);
			}
			if (this.MultiInstanceId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MultiInstanceId);
			}
			if (this.Mode != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Mode);
			}
			if (this.pos_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Pos);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006814 RID: 26644 RVA: 0x000FA31C File Offset: 0x000F851C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterGameRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SingleInstanceId != 0)
			{
				this.SingleInstanceId = other.SingleInstanceId;
			}
			if (other.MultiInstanceId != 0)
			{
				this.MultiInstanceId = other.MultiInstanceId;
			}
			if (other.Mode != 0)
			{
				this.Mode = other.Mode;
			}
			if (other.pos_ != null)
			{
				if (this.pos_ == null)
				{
					this.Pos = new Vector();
				}
				this.Pos.MergeFrom(other.Pos);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006815 RID: 26645 RVA: 0x000FA3AC File Offset: 0x000F85AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006816 RID: 26646 RVA: 0x000FA3B8 File Offset: 0x000F85B8
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.SingleInstanceId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.MultiInstanceId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.Mode = input.ReadInt32();
						continue;
					}
					if (num == 34U)
					{
						if (this.pos_ == null)
						{
							this.Pos = new Vector();
						}
						input.ReadMessage(this.Pos);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040039E6 RID: 14822
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039E7 RID: 14823
		public const int SingleInstanceIdFieldNumber = 1;

		// Token: 0x040039E8 RID: 14824
		private int singleInstanceId_;

		// Token: 0x040039E9 RID: 14825
		public const int MultiInstanceIdFieldNumber = 2;

		// Token: 0x040039EA RID: 14826
		private int multiInstanceId_;

		// Token: 0x040039EB RID: 14827
		public const int ModeFieldNumber = 3;

		// Token: 0x040039EC RID: 14828
		private int mode_;

		// Token: 0x040039ED RID: 14829
		public const int PosFieldNumber = 4;

		// Token: 0x040039EE RID: 14830
		private Vector pos_;
	}
}
