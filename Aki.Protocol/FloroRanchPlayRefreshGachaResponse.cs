using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005C5 RID: 1477
	[NetMessage(EMessageId.FloroRanchPlayRefreshGachaResponse)]
	public sealed class FloroRanchPlayRefreshGachaResponse : IMessage<FloroRanchPlayRefreshGachaResponse>, IMessage, IEquatable<FloroRanchPlayRefreshGachaResponse>, IDeepCloneable<FloroRanchPlayRefreshGachaResponse>, IBufferMessage
	{
		// Token: 0x06008880 RID: 34944 RVA: 0x00148DB2 File Offset: 0x00146FB2
		[NullableContext(1)]
		public static FloroRanchPlayRefreshGachaResponse Create()
		{
			return new FloroRanchPlayRefreshGachaResponse();
		}

		// Token: 0x17001AC4 RID: 6852
		// (get) Token: 0x06008881 RID: 34945 RVA: 0x00148DB9 File Offset: 0x00146FB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001AC5 RID: 6853
		// (get) Token: 0x06008882 RID: 34946 RVA: 0x00148DBC File Offset: 0x00146FBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayRefreshGachaResponse.Descriptor;
			}
		}

		// Token: 0x06008883 RID: 34947 RVA: 0x00148DC3 File Offset: 0x00146FC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayRefreshGachaResponse()
		{
		}

		// Token: 0x06008884 RID: 34948 RVA: 0x00148DCC File Offset: 0x00146FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayRefreshGachaResponse(FloroRanchPlayRefreshGachaResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.gacha_ = ((other.gacha_ != null) ? other.gacha_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008885 RID: 34949 RVA: 0x00148E18 File Offset: 0x00147018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayRefreshGachaResponse Clone()
		{
			return new FloroRanchPlayRefreshGachaResponse(this);
		}

		// Token: 0x17001AC6 RID: 6854
		// (get) Token: 0x06008886 RID: 34950 RVA: 0x00148E20 File Offset: 0x00147020
		// (set) Token: 0x06008887 RID: 34951 RVA: 0x00148E28 File Offset: 0x00147028
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

		// Token: 0x17001AC7 RID: 6855
		// (get) Token: 0x06008888 RID: 34952 RVA: 0x00148E31 File Offset: 0x00147031
		// (set) Token: 0x06008889 RID: 34953 RVA: 0x00148E39 File Offset: 0x00147039
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchGacha Gacha
		{
			get
			{
				return this.gacha_;
			}
			set
			{
				this.gacha_ = value;
			}
		}

		// Token: 0x0600888A RID: 34954 RVA: 0x00148E42 File Offset: 0x00147042
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayRefreshGachaResponse);
		}

		// Token: 0x0600888B RID: 34955 RVA: 0x00148E50 File Offset: 0x00147050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayRefreshGachaResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.Gacha, other.Gacha) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600888C RID: 34956 RVA: 0x00148EA0 File Offset: 0x001470A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.gacha_ != null)
			{
				num ^= this.Gacha.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600888D RID: 34957 RVA: 0x00148EFB File Offset: 0x001470FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600888E RID: 34958 RVA: 0x00148F08 File Offset: 0x00147108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600888F RID: 34959 RVA: 0x00148F14 File Offset: 0x00147114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.gacha_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.Gacha);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008890 RID: 34960 RVA: 0x00148F70 File Offset: 0x00147170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.gacha_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Gacha);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008891 RID: 34961 RVA: 0x00148FC8 File Offset: 0x001471C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchPlayRefreshGachaResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.gacha_ != null)
			{
				if (this.gacha_ == null)
				{
					this.Gacha = new FloroRanchGacha();
				}
				this.Gacha.MergeFrom(other.Gacha);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008892 RID: 34962 RVA: 0x00149030 File Offset: 0x00147230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008893 RID: 34963 RVA: 0x0014903C File Offset: 0x0014723C
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
				if (num != 64U)
				{
					if (num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.gacha_ == null)
						{
							this.Gacha = new FloroRanchGacha();
						}
						input.ReadMessage(this.Gacha);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004334 RID: 17204
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004335 RID: 17205
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04004336 RID: 17206
		private ErrorCode errorCode_;

		// Token: 0x04004337 RID: 17207
		public const int GachaFieldNumber = 11;

		// Token: 0x04004338 RID: 17208
		private FloroRanchGacha gacha_;
	}
}
