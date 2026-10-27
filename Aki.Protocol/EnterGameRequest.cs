using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000452 RID: 1106
	[NetMessage(EMessageId.EnterGameRequest)]
	public sealed class EnterGameRequest : IMessage<EnterGameRequest>, IMessage, IEquatable<EnterGameRequest>, IDeepCloneable<EnterGameRequest>, IBufferMessage
	{
		// Token: 0x0600698F RID: 27023 RVA: 0x000FD1A5 File Offset: 0x000FB3A5
		[NullableContext(1)]
		public static EnterGameRequest Create()
		{
			return new EnterGameRequest();
		}

		// Token: 0x170013E2 RID: 5090
		// (get) Token: 0x06006990 RID: 27024 RVA: 0x000FD1AC File Offset: 0x000FB3AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170013E3 RID: 5091
		// (get) Token: 0x06006991 RID: 27025 RVA: 0x000FD1AF File Offset: 0x000FB3AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterGameRequest.Descriptor;
			}
		}

		// Token: 0x06006992 RID: 27026 RVA: 0x000FD1B6 File Offset: 0x000FB3B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterGameRequest()
		{
		}

		// Token: 0x06006993 RID: 27027 RVA: 0x000FD1C0 File Offset: 0x000FB3C0
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

		// Token: 0x06006994 RID: 27028 RVA: 0x000FD224 File Offset: 0x000FB424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterGameRequest Clone()
		{
			return new EnterGameRequest(this);
		}

		// Token: 0x170013E4 RID: 5092
		// (get) Token: 0x06006995 RID: 27029 RVA: 0x000FD22C File Offset: 0x000FB42C
		// (set) Token: 0x06006996 RID: 27030 RVA: 0x000FD234 File Offset: 0x000FB434
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

		// Token: 0x170013E5 RID: 5093
		// (get) Token: 0x06006997 RID: 27031 RVA: 0x000FD23D File Offset: 0x000FB43D
		// (set) Token: 0x06006998 RID: 27032 RVA: 0x000FD245 File Offset: 0x000FB445
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

		// Token: 0x170013E6 RID: 5094
		// (get) Token: 0x06006999 RID: 27033 RVA: 0x000FD24E File Offset: 0x000FB44E
		// (set) Token: 0x0600699A RID: 27034 RVA: 0x000FD256 File Offset: 0x000FB456
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

		// Token: 0x170013E7 RID: 5095
		// (get) Token: 0x0600699B RID: 27035 RVA: 0x000FD25F File Offset: 0x000FB45F
		// (set) Token: 0x0600699C RID: 27036 RVA: 0x000FD267 File Offset: 0x000FB467
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

		// Token: 0x0600699D RID: 27037 RVA: 0x000FD270 File Offset: 0x000FB470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterGameRequest);
		}

		// Token: 0x0600699E RID: 27038 RVA: 0x000FD280 File Offset: 0x000FB480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterGameRequest other)
		{
			return other != null && (other == this || (this.SingleInstanceId == other.SingleInstanceId && this.MultiInstanceId == other.MultiInstanceId && this.Mode == other.Mode && object.Equals(this.Pos, other.Pos) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600699F RID: 27039 RVA: 0x000FD2F0 File Offset: 0x000FB4F0
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

		// Token: 0x060069A0 RID: 27040 RVA: 0x000FD377 File Offset: 0x000FB577
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060069A1 RID: 27041 RVA: 0x000FD384 File Offset: 0x000FB584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060069A2 RID: 27042 RVA: 0x000FD390 File Offset: 0x000FB590
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

		// Token: 0x060069A3 RID: 27043 RVA: 0x000FD420 File Offset: 0x000FB620
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

		// Token: 0x060069A4 RID: 27044 RVA: 0x000FD4A8 File Offset: 0x000FB6A8
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

		// Token: 0x060069A5 RID: 27045 RVA: 0x000FD538 File Offset: 0x000FB738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060069A6 RID: 27046 RVA: 0x000FD544 File Offset: 0x000FB744
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

		// Token: 0x040039F9 RID: 14841
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039FA RID: 14842
		public const int SingleInstanceIdFieldNumber = 1;

		// Token: 0x040039FB RID: 14843
		private int singleInstanceId_;

		// Token: 0x040039FC RID: 14844
		public const int MultiInstanceIdFieldNumber = 2;

		// Token: 0x040039FD RID: 14845
		private int multiInstanceId_;

		// Token: 0x040039FE RID: 14846
		public const int ModeFieldNumber = 3;

		// Token: 0x040039FF RID: 14847
		private int mode_;

		// Token: 0x04003A00 RID: 14848
		public const int PosFieldNumber = 4;

		// Token: 0x04003A01 RID: 14849
		private Vector pos_;
	}
}
